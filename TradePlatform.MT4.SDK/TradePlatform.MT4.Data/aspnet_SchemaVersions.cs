// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.aspnet_SchemaVersions
// Assembly: TradePlatform.MT4.Data, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FF714B79-462F-457E-9D98-705104E62A16
// Assembly location: T:\work\mql4\ForexSharp1\TradePlatform.MT4.SDK\TradePlatform.MT4.Engine\lib\TradePlatform.MT4.Data.dll

using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace TradePlatform.MT4.Data
{
  [DataContract(IsReference = true)]
  [EdmEntityType(Name = "aspnet_SchemaVersions", NamespaceName = "TradePlatformModel")]
  [Serializable]
  public class aspnet_SchemaVersions : EntityObject
  {
    private string _Feature;
    private string _CompatibleSchemaVersion;
    private bool _IsCurrentVersion;

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    public string Feature
    {
      get
      {
        return this._Feature;
      }
      set
      {
        if (!(this._Feature != value))
          return;
        this.ReportPropertyChanging("Feature");
        this._Feature = StructuralObject.SetValidValue(value, false, "Feature");
        this.ReportPropertyChanged("Feature");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    public string CompatibleSchemaVersion
    {
      get
      {
        return this._CompatibleSchemaVersion;
      }
      set
      {
        if (!(this._CompatibleSchemaVersion != value))
          return;
        this.ReportPropertyChanging("CompatibleSchemaVersion");
        this._CompatibleSchemaVersion = StructuralObject.SetValidValue(value, false, "CompatibleSchemaVersion");
        this.ReportPropertyChanged("CompatibleSchemaVersion");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public bool IsCurrentVersion
    {
      get
      {
        return this._IsCurrentVersion;
      }
      set
      {
        this.ReportPropertyChanging("IsCurrentVersion");
        this._IsCurrentVersion = StructuralObject.SetValidValue(value, "IsCurrentVersion");
        this.ReportPropertyChanged("IsCurrentVersion");
      }
    }

    public static aspnet_SchemaVersions Createaspnet_SchemaVersions(string feature, string compatibleSchemaVersion, bool isCurrentVersion)
    {
      return new aspnet_SchemaVersions()
      {
        Feature = feature,
        CompatibleSchemaVersion = compatibleSchemaVersion,
        IsCurrentVersion = isCurrentVersion
      };
    }
  }
}
