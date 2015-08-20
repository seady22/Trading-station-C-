using System;
using System.Collections.Generic;

namespace TradePlatform.MT4.Core
{
  public abstract class ExpertAdvisor : MqlHandler
  {
    protected abstract int Init();

    protected abstract int Start();

    protected abstract int DeInit();

    public override string ResolveMethod(string methodName, List<string> parameters)
    {
      switch (methodName)
      {
        case "Init":
          return this.Init().ToString();
        case "Start":
          return this.Start().ToString();
        case "DeInit":
          return this.DeInit().ToString();
        default:
          throw new Exception("No method found");
      }
    }
  }
}
