using FluentNHibernate.Mapping;
using TradePlatform.MT4.Db.Entities;
using TradePlatform.MT4.SDK.API;
using TradePlatform.MT4.SDK.API.Constants;

namespace TradePlatform.MT4.Db.Mappings
{
    public class ExpertDetailsMap : ClassMap<ExpertDetails>
    {
        public ExpertDetailsMap()
        {
            Table("ExpertDetails");
            Schema("ExpertAdvisors");

            Id(x => x.Id);
            Map(x => x.Pair).CustomType<SymbolsEnum>();
            Map(x => x.State).CustomType<State>();
            Map(x => x.TimeFrame).CustomType<TIME_FRAME>();
            Map(x => x.CreatedOn);
            Map(x => x.BalanceOnCreate);
            Map(x => x.BalanceOnClose);
            Map(x => x.ClosedOn);
            Map(x => x.TrendType).CustomType<TREND_TYPE>();
            Map(x => x.ExpertName);
        }
    }
}
