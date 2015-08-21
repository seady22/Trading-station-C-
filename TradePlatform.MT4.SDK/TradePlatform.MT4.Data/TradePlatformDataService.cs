// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.TradePlatformDataService
// Assembly: TradePlatform.MT4.Data, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FF714B79-462F-457E-9D98-705104E62A16
// Assembly location: T:\work\mql4\ForexSharp1\TradePlatform.MT4.SDK\TradePlatform.MT4.Engine\lib\TradePlatform.MT4.Data.dll

using System.Data.Services;
using System.Data.Services.Common;

namespace TradePlatform.MT4.Data
{
  public class TradePlatformDataService : DataService<TradePlatformEntities>
  {
    public TradePlatformDataService()
    {
   //   base.\u002Ector(); TODO fixfix
    }

    public static void InitializeService(DataServiceConfiguration config)
    {
      config.SetEntitySetAccessRule("*", (EntitySetRights) 63);
      
      config.DataServiceBehavior.MaxProtocolVersion=DataServiceProtocolVersion.V1;
    }
  }
}
