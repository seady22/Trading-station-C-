using System;
using System.Linq;
using TradePlatform.MT4.Db;
using TradePlatform.MT4.Db.Entities;
using TradePlatform.MT4.SDK.API;
using TradePlatform.MT4.SDK.API.Constants;
using TradePlatform.MT4.SDK.API.Wrappers;
using TradePlatform.MT4.SDK.Library.Handlers;

namespace TradePlatform.MT4.SDK.Library.Experts
{
    public class LineBalanceAdvisor : ExtendedExpertAdvisor
    {
        public TradingFunctionWrapper TradingFunctionWrapper { get; set; }
        public AccountInformationWrapper AccountInformationWrapper { get; set; }
        public PredefinedVariablesWrapper PredefinedVariablesWrapper { get; set; }
        public TechnicalIndicatorsWrapper TechnicalIndicatorsWrapper { get; set; }
        public CommonFunctionsWrapper CommonFunctionsWrapper { get; set; }
        public Repository<ExpertDetails> LineBalanceAdvisorDetailsRepository { get; set; }

        protected override int Init()
        {
            return 1;
        }

        protected override int Start()
        {
            
            return 1;
        }

        protected override int DeInit()
        {
            return 1;
        }
    }
}

