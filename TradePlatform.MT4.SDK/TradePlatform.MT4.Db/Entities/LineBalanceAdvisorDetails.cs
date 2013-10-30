using System;
using FluentNHibernate.Data;
using TradePlatform.MT4.SDK.API;

namespace TradePlatform.MT4.Db.Entities
{
    public class LineBalanceAdvisorDetails :  Entity
    {
        public virtual int Id { get; set; }
        public virtual SymbolsEnum Pair { get; set; }
        public virtual TIME_FRAME TimeFrame { get; set; }
        public virtual DateTime CreatedOn { get; set; }
        public virtual DateTime? ActivedOn { get; set; }
        public virtual DateTime? ClosedOn { get; set; }
        public virtual State State { get; set; }
        public virtual double CurrentBalance { get; set; }
        public virtual double? UpdatedBalance { get; set; }
        public virtual string TrendType { get; set; }
    }
}
