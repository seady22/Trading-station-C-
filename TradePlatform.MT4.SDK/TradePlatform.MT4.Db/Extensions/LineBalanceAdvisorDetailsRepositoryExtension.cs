using System.Collections.Generic;
using System.Linq;
using TradePlatform.MT4.Db.Entities;

namespace TradePlatform.MT4.Db.Extensions
{
    public static class LineBalanceAdvisorDetailsRepositoryExtension
    {
        public static List<LineBalanceAdvisorDetails> GetBalanceAdvisorDetailsByState(this Repository<LineBalanceAdvisorDetails> repository, State state )
        {
            return repository.Items.Where(q => q.State == state).ToList();
        }
    }
}
