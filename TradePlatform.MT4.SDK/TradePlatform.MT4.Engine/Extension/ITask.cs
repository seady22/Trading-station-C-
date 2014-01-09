using System.Collections.Generic;

namespace TradePlatform.MT4.Engine.Extension
{
  public interface ITask
  {
    string Execute(List<ScheduledTaskParameter> patameters);
  }
}
