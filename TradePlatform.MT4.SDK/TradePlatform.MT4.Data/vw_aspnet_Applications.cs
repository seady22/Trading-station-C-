// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.vw_aspnet_Applications
// Assembly: TradePlatform.MT4.Data, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FF714B79-462F-457E-9D98-705104E62A16
// Assembly location: T:\work\mql4\ForexSharp1\TradePlatform.MT4.SDK\TradePlatform.MT4.Engine\lib\TradePlatform.MT4.Data.dll

using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace TradePlatform.MT4.Data
{
  [EdmEntityType(Name = "vw_aspnet_Applications", NamespaceName = "TradePlatformModel")]
  [DataContract(IsReference = true)]
  [Serializable]
  public class vw_aspnet_Applications : EntityObject
  {
    private string _ApplicationName;
    private string _LoweredApplicationName;
    private Guid _ApplicationId;
    private string _Description;

    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    [DataMember]
    public string ApplicationName
    {
      get
      {
        return this._ApplicationName;
      }
      set
      {
        if (!(this._ApplicationName != value))
          return;
        this.ReportPropertyChanging("ApplicationName");
        this._ApplicationName = StructuralObject.SetValidValue(value, false, "ApplicationName");
        this.ReportPropertyChanged("ApplicationName");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    [DataMember]
    public string LoweredApplicationName
    {
      get
      {
        return this._LoweredApplicationName;
      }
      set
      {
        if (!(this._LoweredApplicationName != value))
          return;
        this.ReportPropertyChanging("LoweredApplicationName");
        this._LoweredApplicationName = StructuralObject.SetValidValue(value, false, "LoweredApplicationName");
        this.ReportPropertyChanged("LoweredApplicationName");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    [DataMember]
    public Guid ApplicationId
    {
      get
      {
        return this._ApplicationId;
      }
      set
      {
        if (!(this._ApplicationId != value))
          return;
        this.ReportPropertyChanging("ApplicationId");
        this._ApplicationId = StructuralObject.SetValidValue(value, "ApplicationId");
        this.ReportPropertyChanged("ApplicationId");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public string Description
    {
      get
      {
        return this._Description;
      }
      set
      {
        this.ReportPropertyChanging("Description");
        this._Description = StructuralObject.SetValidValue(value, true, "Description");
        this.ReportPropertyChanged("Description");
      }
    }

    public static vw_aspnet_Applications Createvw_aspnet_Applications(string applicationName, string loweredApplicationName, Guid applicationId)
    {
      return new vw_aspnet_Applications()
      {
        ApplicationName = applicationName,
        LoweredApplicationName = loweredApplicationName,
        ApplicationId = applicationId
      };
    }
  }
}
