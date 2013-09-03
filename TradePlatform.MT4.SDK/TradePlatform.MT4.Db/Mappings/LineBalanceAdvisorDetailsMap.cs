using FluentNHibernate.Mapping;
using TradePlatform.MT4.Db.Entities;

namespace TradePlatform.MT4.Db.Mappings
{
    public class LineBalanceAdvisorDetailsMap : ClassMap<LineBalanceAdvisorDetails>
    {
        public LineBalanceAdvisorDetailsMap()
        {
            Id(x => x.Id);
            Map(x => x.Content).Column("Content");
            Table("LineBalanceAdvisorDetails");
            Schema("ExpertAdvisors");
        }
    }
}
