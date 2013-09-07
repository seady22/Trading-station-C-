using FluentNHibernate.Mapping;
using TradePlatform.MT4.Db.Entities;

namespace TradePlatform.MT4.Db.Mappings
{
    public class LineBalanceAdvisorDetailsMap : ClassMap<LineBalanceAdvisorDetails>
    {
        public LineBalanceAdvisorDetailsMap()
        {
            Table("LineBalanceAdvisorDetails");
            Schema("ExpertAdvisors");
            Id(x => x.Id);
            Map(x => x.Pair);
            Map(x => x.State);
            Map(x => x.TimeFrame);
            Map(x => x.CreatedOn);
        }
    }
}
