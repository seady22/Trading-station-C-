// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.aspnet_Applications
// Assembly: TradePlatform.MT4.Data, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FF714B79-462F-457E-9D98-705104E62A16
// Assembly location: T:\work\mql4\ForexSharp1\TradePlatform.MT4.SDK\TradePlatform.MT4.Engine\lib\TradePlatform.MT4.Data.dll

using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace TradePlatform.MT4.Data
{
  [DataContract(IsReference = true)]
  [EdmEntityType(Name = "aspnet_Applications", NamespaceName = "TradePlatformModel")]
  [Serializable]
    public class aspnet_Applications : EntityObject, IEntityWithRelationships
  {
    private string _ApplicationName;
    private string _LoweredApplicationName;
    private Guid _ApplicationId;
    private string _Description;

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public string ApplicationName
    {
      get
      {
        return this._ApplicationName;
      }
      set
      {
        this.ReportPropertyChanging("ApplicationName");
        this._ApplicationName = StructuralObject.SetValidValue(value, false, "ApplicationName");
        this.ReportPropertyChanged("ApplicationName");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public string LoweredApplicationName
    {
      get
      {
        return this._LoweredApplicationName;
      }
      set
      {
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

    [EdmRelationshipNavigationProperty("TradePlatformModel", "FK__aspnet_Me__Appli__276EDEB3", "aspnet_Membership")]
    [DataMember]
    [SoapIgnore]
    [XmlIgnore]
    public EntityCollection<TradePlatform.MT4.Data.aspnet_Membership> aspnet_Membership
    {
      get
      {
          return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<TradePlatform.MT4.Data.aspnet_Membership>("TradePlatformModel.FK__aspnet_Me__Appli__276EDEB3", "aspnet_Membership");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<TradePlatform.MT4.Data.aspnet_Membership>("TradePlatformModel.FK__aspnet_Me__Appli__276EDEB3", "aspnet_Membership", value);
      }
    }

    [EdmRelationshipNavigationProperty("TradePlatformModel", "FK__aspnet_Ro__Appli__45F365D3", "aspnet_Roles")]
    [DataMember]
    [XmlIgnore]
    [SoapIgnore]
    public EntityCollection<TradePlatform.MT4.Data.aspnet_Roles> aspnet_Roles
    {
      get
      {
          return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<TradePlatform.MT4.Data.aspnet_Roles>("TradePlatformModel.FK__aspnet_Ro__Appli__45F365D3", "aspnet_Roles");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<TradePlatform.MT4.Data.aspnet_Roles>("TradePlatformModel.FK__aspnet_Ro__Appli__45F365D3", "aspnet_Roles", value);
      }
    }

    [SoapIgnore]
    [DataMember]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "FK__aspnet_Us__Appli__173876EA", "aspnet_Users")]
    [XmlIgnore]
    public EntityCollection<TradePlatform.MT4.Data.aspnet_Users> aspnet_Users
    {
      get
      {
          return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<TradePlatform.MT4.Data.aspnet_Users>("TradePlatformModel.FK__aspnet_Us__Appli__173876EA", "aspnet_Users");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<TradePlatform.MT4.Data.aspnet_Users>("TradePlatformModel.FK__aspnet_Us__Appli__173876EA", "aspnet_Users", value);
      }
    }

    public static aspnet_Applications Createaspnet_Applications(string applicationName, string loweredApplicationName, Guid applicationId)
    {
      return new aspnet_Applications()
      {
        ApplicationName = applicationName,
        LoweredApplicationName = loweredApplicationName,
        ApplicationId = applicationId
      };
    }
  }
}
