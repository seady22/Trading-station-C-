using FluentNHibernate.Mapping;
using TradePlatform.MT4.Db.Entities;
using TradePlatform.MT4.SDK.API;
using TradePlatform.MT4.SDK.API.Constants;

namespace TradePlatform.MT4.Db.Mappings
{
    public class LineBalanceAdvisorDetailsMap : ClassMap<LineBalanceAdvisorDetails>
    {
        public LineBalanceAdvisorDetailsMap()
        {
            Table("LineBalanceAdvisorDetails");
            Schema("ExpertAdvisors");

            Id(x => x.Id);
            Map(x => x.Pair).CustomType<SymbolsEnum>();
            Map(x => x.State).CustomType<State>();
            Map(x => x.TimeFrame).CustomType<TIME_FRAME>();
            Map(x => x.CreatedOn);
            Map(x => x.CurrentBalance);
            Map(x => x.UpdatedBalance);
            Map(x => x.ActivedOn);
            Map(x => x.ClosedOn);
            Map(x => x.TrendType);
        }
    }
}
