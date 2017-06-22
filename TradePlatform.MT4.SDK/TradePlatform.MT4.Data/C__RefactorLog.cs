// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.C__RefactorLog
// Assembly: TradePlatform.MT4.Data, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FF714B79-462F-457E-9D98-705104E62A16
// Assembly location: T:\work\mql4\ForexSharp1\TradePlatform.MT4.SDK\TradePlatform.MT4.Engine\lib\TradePlatform.MT4.Data.dll

using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace TradePlatform.MT4.Data
{
  [EdmEntityType(Name = "C__RefactorLog", NamespaceName = "TradePlatformModel")]
  [DataContract(IsReference = true)]
  [Serializable]
  public class C__RefactorLog : EntityObject
  {
    private Guid _OperationKey;

    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    [DataMember]
    public Guid OperationKey
    {
      get
      {
        return this._OperationKey;
      }
      set
      {
        if (!(this._OperationKey != value))
          return;
        this.ReportPropertyChanging("OperationKey");
        this._OperationKey = StructuralObject.SetValidValue(value, "OperationKey");
        this.ReportPropertyChanged("OperationKey");
      }
    }

    public static C__RefactorLog CreateC__RefactorLog(Guid operationKey)
    {
      return new C__RefactorLog()
      {
        OperationKey = operationKey
      };
    }
  }
}
