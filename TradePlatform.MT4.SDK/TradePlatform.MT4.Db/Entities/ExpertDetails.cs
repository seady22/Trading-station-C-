using System;
using FluentNHibernate.Data;
using TradePlatform.MT4.SDK.API;
using TradePlatform.MT4.SDK.API.Constants;

namespace TradePlatform.MT4.Db.Entities
{
    public class ExpertDetails :  Entity
    {
        public virtual int Id { get; set; }
        public virtual SymbolsEnum Pair { get; set; }
        public virtual TIME_FRAME TimeFrame { get; set; }
        public virtual DateTime CreatedOn { get; set; }
        public virtual DateTime? ClosedOn { get; set; }
        public virtual State State { get; set; }
        public virtual double BalanceOnCreate { get; set; }
        public virtual double? BalanceOnClose { get; set; }
        public virtual TREND_TYPE TrendType { get; set; }
    }
}
