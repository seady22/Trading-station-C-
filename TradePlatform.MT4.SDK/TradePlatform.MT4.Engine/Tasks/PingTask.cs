using System.Collections.Generic;
using System.ComponentModel.Composition;
using TradePlatform.MT4.Data;
using TradePlatform.MT4.Engine.Extension;

namespace TradePlatform.MT4.Engine.Tasks
{
  [MinInterval(5000)]
  [Name("Ping")]
  [Export(typeof (ITask))]
  public class PingTask : ITask
  {
    public string Execute(List<ScheduledTaskParameter> parameters)
    {
      return "*** PING ***";
    }
  }
}
