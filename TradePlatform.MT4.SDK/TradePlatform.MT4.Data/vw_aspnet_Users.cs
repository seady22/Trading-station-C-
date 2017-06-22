// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.vw_aspnet_Users
// Assembly: TradePlatform.MT4.Data, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FF714B79-462F-457E-9D98-705104E62A16
// Assembly location: T:\work\mql4\ForexSharp1\TradePlatform.MT4.SDK\TradePlatform.MT4.Engine\lib\TradePlatform.MT4.Data.dll

using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace TradePlatform.MT4.Data
{
  [DataContract(IsReference = true)]
  [EdmEntityType(Name = "vw_aspnet_Users", NamespaceName = "TradePlatformModel")]
  [Serializable]
  public class vw_aspnet_Users : EntityObject
  {
    private Guid _ApplicationId;
    private Guid _UserId;
    private string _UserName;
    private string _LoweredUserName;
    private string _MobileAlias;
    private bool _IsAnonymous;
    private DateTime _LastActivityDate;

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
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

    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    [DataMember]
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

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    public string UserName
    {
      get
      {
        return this._UserName;
      }
      set
      {
        if (!(this._UserName != value))
          return;
        this.ReportPropertyChanging("UserName");
        this._UserName = StructuralObject.SetValidValue(value, false, "UserName");
        this.ReportPropertyChanged("UserName");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    [DataMember]
    public string LoweredUserName
    {
      get
      {
        return this._LoweredUserName;
      }
      set
      {
        if (!(this._LoweredUserName != value))
          return;
        this.ReportPropertyChanging("LoweredUserName");
        this._LoweredUserName = StructuralObject.SetValidValue(value, false, "LoweredUserName");
        this.ReportPropertyChanged("LoweredUserName");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public string MobileAlias
    {
      get
      {
        return this._MobileAlias;
      }
      set
      {
        this.ReportPropertyChanging("MobileAlias");
        this._MobileAlias = StructuralObject.SetValidValue(value, true, "MobileAlias");
        this.ReportPropertyChanged("MobileAlias");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    [DataMember]
    public bool IsAnonymous
    {
      get
      {
        return this._IsAnonymous;
      }
      set
      {
        if (this._IsAnonymous == value)
          return;
        this.ReportPropertyChanging("IsAnonymous");
        this._IsAnonymous = StructuralObject.SetValidValue(value, "IsAnonymous");
        this.ReportPropertyChanged("IsAnonymous");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    public DateTime LastActivityDate
    {
      get
      {
        return this._LastActivityDate;
      }
      set
      {
        if (!(this._LastActivityDate != value))
          return;
        this.ReportPropertyChanging("LastActivityDate");
        this._LastActivityDate = StructuralObject.SetValidValue(value, "LastActivityDate");
        this.ReportPropertyChanged("LastActivityDate");
      }
    }

    public static vw_aspnet_Users Createvw_aspnet_Users(Guid applicationId, Guid userId, string userName, string loweredUserName, bool isAnonymous, DateTime lastActivityDate)
    {
      return new vw_aspnet_Users()
      {
        ApplicationId = applicationId,
        UserId = userId,
        UserName = userName,
        LoweredUserName = loweredUserName,
        IsAnonymous = isAnonymous,
        LastActivityDate = lastActivityDate
      };
    }
  }
}
