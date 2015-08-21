// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.aspnet_Roles
// Assembly: TradePlatform.MT4.Data, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FF714B79-462F-457E-9D98-705104E62A16
// Assembly location: T:\work\mql4\ForexSharp1\TradePlatform.MT4.SDK\TradePlatform.MT4.Engine\lib\TradePlatform.MT4.Data.dll

using System;
using System.ComponentModel;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace TradePlatform.MT4.Data
{
  [DataContract(IsReference = true)]
  [EdmEntityType(Name = "aspnet_Roles", NamespaceName = "TradePlatformModel")]
  [Serializable]
  public class aspnet_Roles : EntityObject
  {
    private Guid _ApplicationId;
    private Guid _RoleId;
    private string _RoleName;
    private string _LoweredRoleName;
    private string _Description;

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public Guid ApplicationId
    {
      get
      {
        return this._ApplicationId;
      }
      set
      {
        this.ReportPropertyChanging("ApplicationId");
        this._ApplicationId = StructuralObject.SetValidValue(value, "ApplicationId");
        this.ReportPropertyChanged("ApplicationId");
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

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public string RoleName
    {
      get
      {
        return this._RoleName;
      }
      set
      {
        this.ReportPropertyChanging("RoleName");
        this._RoleName = StructuralObject.SetValidValue(value, false, "RoleName");
        this.ReportPropertyChanged("RoleName");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public string LoweredRoleName
    {
      get
      {
        return this._LoweredRoleName;
      }
      set
      {
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

    [XmlIgnore]
    [SoapIgnore]
    [DataMember]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "FK__aspnet_Ro__Appli__45F365D3", "aspnet_Applications")]
    public aspnet_Applications aspnet_Applications
    {
      get
      {
          return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<aspnet_Applications>("TradePlatformModel.FK__aspnet_Ro__Appli__45F365D3", "aspnet_Applications").Value;
      }
      set
      {
          ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<aspnet_Applications>("TradePlatformModel.FK__aspnet_Ro__Appli__45F365D3", "aspnet_Applications").Value = value;
      }
    }

    [DataMember]
    [Browsable(false)]
    public EntityReference<aspnet_Applications> aspnet_ApplicationsReference
    {
      get
      {
          return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<aspnet_Applications>("TradePlatformModel.FK__aspnet_Ro__Appli__45F365D3", "aspnet_Applications");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<aspnet_Applications>("TradePlatformModel.FK__aspnet_Ro__Appli__45F365D3", "aspnet_Applications", value);
      }
    }

    [SoapIgnore]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "aspnet_UsersInRoles", "aspnet_Users")]
    [XmlIgnore]
    [DataMember]
    public EntityCollection<TradePlatform.MT4.Data.aspnet_Users> aspnet_Users
    {
      get
      {
          return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<TradePlatform.MT4.Data.aspnet_Users>("TradePlatformModel.aspnet_UsersInRoles", "aspnet_Users");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<TradePlatform.MT4.Data.aspnet_Users>("TradePlatformModel.aspnet_UsersInRoles", "aspnet_Users", value);
      }
    }

    public static aspnet_Roles Createaspnet_Roles(Guid applicationId, Guid roleId, string roleName, string loweredRoleName)
    {
      return new aspnet_Roles()
      {
        ApplicationId = applicationId,
        RoleId = roleId,
        RoleName = roleName,
        LoweredRoleName = loweredRoleName
      };
    }
  }
}
