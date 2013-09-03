using FluentNHibernate.Data;

namespace TradePlatform.MT4.Db.Entities
{
    public class LineBalanceAdvisorDetails :  Entity
    {
        public virtual int Id { get; set; }
        public virtual string Content { get; set; }
    }
}
