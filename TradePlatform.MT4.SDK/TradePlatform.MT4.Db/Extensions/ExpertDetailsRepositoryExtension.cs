using System.Collections.Generic;
using System.Linq;
using TradePlatform.MT4.Db.Entities;
using TradePlatform.MT4.SDK.API.Constants;

namespace TradePlatform.MT4.Db.Extensions
{
    public static class ExpertDetailsRepositoryExtension
    {
        public static List<ExpertDetails> GetBalanceAdvisorDetailsByState(this Repository<ExpertDetails> repository, State state )
        {
            return repository.GetAll().Where(q => q.State == state).ToList();
        }
    }
}
