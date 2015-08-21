// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.RolePermission
// Assembly: TradePlatform.MT4.Data, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FF714B79-462F-457E-9D98-705104E62A16
// Assembly location: T:\work\mql4\ForexSharp1\TradePlatform.MT4.SDK\TradePlatform.MT4.Engine\lib\TradePlatform.MT4.Data.dll

using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace TradePlatform.MT4.Data
{
  [DataContract(IsReference = true)]
  [EdmEntityType(Name = "RolePermission", NamespaceName = "TradePlatformModel")]
  [Serializable]
  public class RolePermission : EntityObject
  {
    private string _RoleName;
    private string _PermissionId;

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
    public string PermissionId
    {
      get
      {
        return this._PermissionId;
      }
      set
      {
        if (!(this._PermissionId != value))
          return;
        this.ReportPropertyChanging("PermissionId");
        this._PermissionId = StructuralObject.SetValidValue(value, false, "PermissionId");
        this.ReportPropertyChanged("PermissionId");
      }
    }

    public static RolePermission CreateRolePermission(string roleName, string permissionId)
    {
      return new RolePermission()
      {
        RoleName = roleName,
        PermissionId = permissionId
      };
    }
  }
}
