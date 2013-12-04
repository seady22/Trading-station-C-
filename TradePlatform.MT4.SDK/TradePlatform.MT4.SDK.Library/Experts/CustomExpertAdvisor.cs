﻿using System;
using System.Linq;
using log4net;
using TradePlatform.MT4.Db;
using TradePlatform.MT4.Db.Entities;
using TradePlatform.MT4.SDK.API;
using TradePlatform.MT4.SDK.API.Constants;
using TradePlatform.MT4.SDK.Library.Config;
using TradePlatform.MT4.SDK.Library.Handlers;

namespace TradePlatform.MT4.SDK.Library.Experts
{
    public abstract class CustomExpertAdvisor : ExtendedExpertAdvisor
    {
        public IRepository<ExpertDetails> ExpertDetailsRepository = new Repository<ExpertDetails>();
        protected ILog _logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        protected ExpertElement _config;
        protected string _symbol;

        protected override int Init()
        {
            return 1;
        }

        protected override int DeInit()
        {
            return 1;
        }

        protected override int Start()
        {
            GetSymbol();
            ReadConfigData();
            if (!IsOrderOpenForSymbol() & IsWorkDay())
            {
                UpdateOrdersInDb();
                var trendType = GetTrendType();
                if (CanOpenOffer(trendType))
                {
                    OpenOffer(trendType);
                }
            }
            return 1;
        }

        private void GetSymbol()
        {
            _symbol = this.Symbol();
        }

        private bool IsOrderOpenForSymbol()
        {
            var result = false;
            var ordersTotal = this.OrdersTotal();
            for (int i = 0; i < ordersTotal; i++)
            {
                var isOrderSelected = this.OrderSelect(i, SELECT_BY.SELECT_BY_POS);
                if (isOrderSelected)
                {
                    var orderInDb = ExpertDetailsRepository.GetAll().Single(x => x.ClosedOn == null && x.Pair == _symbol && x.ExpertName == GetType().Name);
                    var orderSymbol = this.OrderSymbol();
                    if (orderSymbol == _symbol & orderInDb != null)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }

        private bool IsWorkDay()
        {
            var currentDateTime = DateTime.Now;
            return (currentDateTime.DayOfWeek != DayOfWeek.Saturday | currentDateTime.DayOfWeek != DayOfWeek.Sunday) ;
        }

        private void UpdateOrdersInDb()
        {
            var orderInDb =
                ExpertDetailsRepository.GetAll().Where(x => x.ClosedOn == null && x.Pair == _symbol && x.ExpertName == GetType().Name).ToList();

            foreach (var openedOrder in orderInDb)
            {
                openedOrder.ClosedOn = DateTime.Now;
                openedOrder.BalanceOnClose = this.AccountEquity();
                openedOrder.State = State.Closed.ToString();
                openedOrder.Profit = (double)(openedOrder.BalanceOnClose - openedOrder.BalanceOnCreate);
                ExpertDetailsRepository.Update(openedOrder);
                _logger.DebugFormat("OrderId={0}. Order was updated. ClosedOn={1}, BalanceOnClosed={2}, State={3}, Profit={4}, Pair={5}", openedOrder.Id, openedOrder.ClosedOn, openedOrder.BalanceOnClose, openedOrder.State, openedOrder.Profit, openedOrder.Pair);
            }
        }

        protected TIME_FRAME GetCurrentTimeFrame()
        {
            var timeFrame = (TIME_FRAME)Enum.Parse(typeof(TIME_FRAME), _config.TimeFrame);
            return timeFrame;
        }

        public void OpenOffer(TREND_TYPE trendType)
        {
            var point = this.Point();
            var accountBalance = this.AccountEquity();
            var result = -1;

            double ask = this.Ask();
            double bid = this.Bid();

            if (trendType == TREND_TYPE.ASC)
            {
                var takeProfit = bid + int.Parse(_config.TakeProfit)*point;
                var stopLoss = bid - int.Parse(_config.StopLoss)*point;
                result = this.OrderSend(_symbol, ORDER_TYPE.OP_BUY, double.Parse(_config.OrderAmount), ask, 3,
                    stopLoss, takeProfit);
                _logger.DebugFormat("Open buy offer. Ask price={0}, StopLoss={1}, TakeProfit={2}, Symbol={3}", ask,
                    stopLoss, takeProfit, _symbol);

                if (result == -1)
                {
                    result = this.OrderSend(_symbol, ORDER_TYPE.OP_BUY, double.Parse(_config.OrderAmount), ask, 3,
                        stopLoss, takeProfit);
                    _logger.DebugFormat("OpenOffer was sent second time. Result = {0}", result);
                    if (result == -1)
                    {
                        _logger.DebugFormat("OpenOffer was not executed. Try later");
                        return;
                    }
                }
            }

            if (trendType == TREND_TYPE.DESC)
            {
                var takeProfit = ask - int.Parse(_config.TakeProfit)*point;
                var stopLoss = ask + int.Parse(_config.StopLoss)*point;
                result = this.OrderSend(_symbol, ORDER_TYPE.OP_SELL, double.Parse(_config.OrderAmount), bid, 3, stopLoss, takeProfit);
                    
                _logger.DebugFormat("Open sell offer. Bid price={0}, StopLoss={1}, TakeProfit={2}, Symbol={3}", bid,
                    stopLoss, takeProfit, _symbol);

                if (result == -1)
                {
                    result = this.OrderSend(_symbol, ORDER_TYPE.OP_SELL, double.Parse(_config.OrderAmount), bid, 3,
                        stopLoss, takeProfit);
                    _logger.DebugFormat("OpenOffer was sent second time.Symbol={0}", _symbol);
                    if (result == -1)
                    {
                        _logger.DebugFormat("OpenOffer was not executed. Try later");
                        return;
                    }
                }
            }
            var expertDetailRecord = new ExpertDetails
            {
                State = State.Active.ToString(),
                CreatedOn = DateTime.Now,
                Pair = _symbol,
                TimeFrame = GetCurrentTimeFrame(),
                TrendType = trendType.ToString(),
                BalanceOnCreate = accountBalance,
                ExpertName = GetType().Name,
                OrderId = result
            };
            ExpertDetailsRepository.Save(expertDetailRecord);
            _logger.DebugFormat("New expertDetail Record was added. Id={0}. Pair={1}, TrendType={2}",
                expertDetailRecord.Id, expertDetailRecord.Pair, expertDetailRecord.TrendType);
        }

        abstract protected TREND_TYPE GetTrendType();
        abstract protected bool CanOpenOffer(TREND_TYPE trendType);
        protected abstract void ReadConfigData();
    }
}
