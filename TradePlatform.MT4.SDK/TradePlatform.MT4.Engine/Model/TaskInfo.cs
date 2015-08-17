using System;
using System.Collections.Generic;
using TradePlatform.MT4.Data;
using TradePlatform.MT4.Engine.Extension;

namespace TradePlatform.MT4.Engine.Model
{
  internal class TaskInfo
  {
    private Func<ITask> _taskAccessor;

    public TimeSpan MinInterval { get; private set; }

    public string Name { get; private set; }

    internal string TaskExecutionResult { get; private set; }

    internal List<ScheduledTaskParameter> Patameters { get; set; }

    public TaskInfo(TimeSpan mininterval, string name, Func<ITask> taskAccessor)
    {
      this.MinInterval = mininterval;
      this.Name = name;
      this._taskAccessor = taskAccessor;
    }

    public void ExecuteTask()
    {
      this.TaskExecutionResult = this._taskAccessor().Execute(this.Patameters);
    }
  }
}
