using System.Collections.Generic;
using TradePlatform.MT4.Data;

namespace TradePlatform.MT4.Engine.Extension
{
  public interface ITask
  {
    string Execute(List<ScheduledTaskParameter> patameters);
  }
}
