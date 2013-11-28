using FluentNHibernate.Mapping;
using TradePlatform.MT4.Db.Entities;
using TradePlatform.MT4.SDK.API;

namespace TradePlatform.MT4.Db.Mappings
{
    public class ExpertDetailsMap : ClassMap<ExpertDetails>
    {
        public ExpertDetailsMap()
        {
            Table("ExpertDetails");
            Schema("ExpertAdvisors");

            Id(x => x.Id);
            Map(x => x.Pair);
            Map(x => x.State);
            Map(x => x.TimeFrame).CustomType<TIME_FRAME>();
            Map(x => x.CreatedOn);
            Map(x => x.BalanceOnCreate);
            Map(x => x.BalanceOnClose);
            Map(x => x.ClosedOn);
            Map(x => x.TrendType);
            Map(x => x.ExpertName);
            Map(x => x.Profit);
            Map(x => x.OrderId);
        }
    }
}
