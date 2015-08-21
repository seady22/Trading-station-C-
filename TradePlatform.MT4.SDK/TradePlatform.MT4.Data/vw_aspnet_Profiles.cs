// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.vw_aspnet_Profiles
// Assembly: TradePlatform.MT4.Data, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FF714B79-462F-457E-9D98-705104E62A16
// Assembly location: T:\work\mql4\ForexSharp1\TradePlatform.MT4.SDK\TradePlatform.MT4.Engine\lib\TradePlatform.MT4.Data.dll

using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace TradePlatform.MT4.Data
{
  [DataContract(IsReference = true)]
  [EdmEntityType(Name = "vw_aspnet_Profiles", NamespaceName = "TradePlatformModel")]
  [Serializable]
  public class vw_aspnet_Profiles : EntityObject
  {
    private Guid _UserId;
    private DateTime _LastUpdatedDate;
    private int? _DataSize;

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    public Guid UserId
    {
      get
      {
        return this._UserId;
      }
      set
      {
        if (!(this._UserId != value))
          return;
        this.ReportPropertyChanging("UserId");
        this._UserId = StructuralObject.SetValidValue(value, "UserId");
        this.ReportPropertyChanged("UserId");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    [DataMember]
    public DateTime LastUpdatedDate
    {
      get
      {
        return this._LastUpdatedDate;
      }
      set
      {
        if (!(this._LastUpdatedDate != value))
          return;
        this.ReportPropertyChanging("LastUpdatedDate");
        this._LastUpdatedDate = StructuralObject.SetValidValue(value, "LastUpdatedDate");
        this.ReportPropertyChanged("LastUpdatedDate");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public int? DataSize
    {
      get
      {
        return this._DataSize;
      }
      set
      {
        this.ReportPropertyChanging("DataSize");
        this._DataSize = StructuralObject.SetValidValue(value, "DataSize");
        this.ReportPropertyChanged("DataSize");
      }
    }

    public static vw_aspnet_Profiles Createvw_aspnet_Profiles(Guid userId, DateTime lastUpdatedDate)
    {
      return new vw_aspnet_Profiles()
      {
        UserId = userId,
        LastUpdatedDate = lastUpdatedDate
      };
    }
  }
}
