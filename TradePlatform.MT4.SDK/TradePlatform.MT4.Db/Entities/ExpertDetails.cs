using System;
using FluentNHibernate.Data;
using TradePlatform.MT4.SDK.API;

namespace TradePlatform.MT4.Db.Entities
{
    public class ExpertDetails :  Entity
    {
        public virtual int Id { get; set; }
        public virtual string Pair { get; set; }
        public virtual TIME_FRAME TimeFrame { get; set; }
        public virtual DateTime CreatedOn { get; set; }
        public virtual DateTime? ClosedOn { get; set; }
        public virtual string State { get; set; }
        public virtual double BalanceOnCreate { get; set; }
        public virtual double? BalanceOnClose { get; set; }
        public virtual string TrendType { get; set; }
        public virtual string ExpertName { get; set; }
        public virtual double Profit { get; set; }
    }
}
