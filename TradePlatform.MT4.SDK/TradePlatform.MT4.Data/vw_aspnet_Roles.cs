// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.vw_aspnet_Roles
// Assembly: TradePlatform.MT4.Data, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FF714B79-462F-457E-9D98-705104E62A16
// Assembly location: T:\work\mql4\ForexSharp1\TradePlatform.MT4.SDK\TradePlatform.MT4.Engine\lib\TradePlatform.MT4.Data.dll

using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace TradePlatform.MT4.Data
{
  [DataContract(IsReference = true)]
  [EdmEntityType(Name = "vw_aspnet_Roles", NamespaceName = "TradePlatformModel")]
  [Serializable]
  public class vw_aspnet_Roles : EntityObject
  {
    private Guid _ApplicationId;
    private Guid _RoleId;
    private string _RoleName;
    private string _LoweredRoleName;
    private string _Description;

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

    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    [DataMember]
    public Guid RoleId
    {
      get
      {
        return this._RoleId;
      }
      set
      {
        if (!(this._RoleId != value))
          return;
        this.ReportPropertyChanging("RoleId");
        this._RoleId = StructuralObject.SetValidValue(value, "RoleId");
        this.ReportPropertyChanged("RoleId");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    [DataMember]
    public string RoleName
    {
      get
      {
        return this._RoleName;
      }
      set
      {
        if (!(this._RoleName != value))
          return;
        this.ReportPropertyChanging("RoleName");
        this._RoleName = StructuralObject.SetValidValue(value, false, "RoleName");
        this.ReportPropertyChanged("RoleName");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    [DataMember]
    public string LoweredRoleName
    {
      get
      {
        return this._LoweredRoleName;
      }
      set
      {
        if (!(this._LoweredRoleName != value))
          return;
        this.ReportPropertyChanging("LoweredRoleName");
        this._LoweredRoleName = StructuralObject.SetValidValue(value, false, "LoweredRoleName");
        this.ReportPropertyChanged("LoweredRoleName");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
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

    public static vw_aspnet_Roles Createvw_aspnet_Roles(Guid applicationId, Guid roleId, string roleName, string loweredRoleName)
    {
      return new vw_aspnet_Roles()
      {
        ApplicationId = applicationId,
        RoleId = roleId,
        RoleName = roleName,
        LoweredRoleName = loweredRoleName
      };
    }
  }
}
