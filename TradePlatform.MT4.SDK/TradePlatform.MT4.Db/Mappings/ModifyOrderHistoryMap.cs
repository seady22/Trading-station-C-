using FluentNHibernate.Mapping;
using TradePlatform.MT4.Db.Entities;

namespace TradePlatform.MT4.Db.Mappings
{
    public class ModifyOrderHistoryMap : ClassMap<ModifyOrderHistory>
    {
        public ModifyOrderHistoryMap()
        {
            Table("ExpertDetails");
            Schema("ModifyOrderHistory");

            Id(x => x.Id);
            Map(x => x.CreatedOn);
            Map(x => x.OrderId);
            Map(x => x.OrderId);
            Map(x => x.Points);
            Map(x => x.UpdatedStopLoss);
            Map(x => x.UpdatedTakeProfit);
        }
    }
}
