// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.vw_aspnet_UsersInRoles
// Assembly: TradePlatform.MT4.Data, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FF714B79-462F-457E-9D98-705104E62A16
// Assembly location: T:\work\mql4\ForexSharp1\TradePlatform.MT4.SDK\TradePlatform.MT4.Engine\lib\TradePlatform.MT4.Data.dll

using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace TradePlatform.MT4.Data
{
  [DataContract(IsReference = true)]
  [EdmEntityType(Name = "vw_aspnet_UsersInRoles", NamespaceName = "TradePlatformModel")]
  [Serializable]
  public class vw_aspnet_UsersInRoles : EntityObject
  {
    private Guid _UserId;
    private Guid _RoleId;

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

    public static vw_aspnet_UsersInRoles Createvw_aspnet_UsersInRoles(Guid userId, Guid roleId)
    {
      return new vw_aspnet_UsersInRoles()
      {
        UserId = userId,
        RoleId = roleId
      };
    }
  }
}
