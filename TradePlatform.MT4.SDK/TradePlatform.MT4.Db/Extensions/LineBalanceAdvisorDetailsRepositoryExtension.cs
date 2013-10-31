using System.Collections.Generic;
using System.Linq;
using TradePlatform.MT4.Db.Entities;
using TradePlatform.MT4.SDK.API.Constants;

namespace TradePlatform.MT4.Db.Extensions
{
    public static class LineBalanceAdvisorDetailsRepositoryExtension
    {
        public static List<LineBalanceAdvisorDetails> GetBalanceAdvisorDetailsByState(this Repository<LineBalanceAdvisorDetails> repository, State state )
        {
            return repository.GetAll().Where(q => q.State == state).ToList();
        }
    }
}
