using FluentNHibernate.Data;

namespace TradePlatform.MT4.Db.Entities
{
    public class ModifyOrderHistory : Entity
    {
        public virtual int Id { get; set; }
        public virtual int OrderId { get; set; }
        public virtual double UpdatedTakeProfit { get; set; }
        public virtual double UpdatedStopLoss { get; set; }
        public virtual int Points { get; set; }
        public virtual int CreatedOn { get; set; }
    }
}
