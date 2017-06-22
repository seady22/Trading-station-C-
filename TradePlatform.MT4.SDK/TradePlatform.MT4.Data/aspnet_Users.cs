// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.aspnet_Users
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
  [EdmEntityType(Name = "aspnet_Users", NamespaceName = "TradePlatformModel")]
  [Serializable]
  public class aspnet_Users : EntityObject
  {
    private Guid _ApplicationId;
    private Guid _UserId;
    private string _UserName;
    private string _LoweredUserName;
    private string _MobileAlias;
    private bool _IsAnonymous;
    private DateTime _LastActivityDate;

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

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public string UserName
    {
      get
      {
        return this._UserName;
      }
      set
      {
        this.ReportPropertyChanging("UserName");
        this._UserName = StructuralObject.SetValidValue(value, false, "UserName");
        this.ReportPropertyChanged("UserName");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public string LoweredUserName
    {
      get
      {
        return this._LoweredUserName;
      }
      set
      {
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

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public bool IsAnonymous
    {
      get
      {
        return this._IsAnonymous;
      }
      set
      {
        this.ReportPropertyChanging("IsAnonymous");
        this._IsAnonymous = StructuralObject.SetValidValue(value, "IsAnonymous");
        this.ReportPropertyChanged("IsAnonymous");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public DateTime LastActivityDate
    {
      get
      {
        return this._LastActivityDate;
      }
      set
      {
        this.ReportPropertyChanging("LastActivityDate");
        this._LastActivityDate = StructuralObject.SetValidValue(value, "LastActivityDate");
        this.ReportPropertyChanged("LastActivityDate");
      }
    }

    [SoapIgnore]
    [XmlIgnore]
    [DataMember]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "FK__aspnet_Us__Appli__173876EA", "aspnet_Applications")]
    public aspnet_Applications aspnet_Applications
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<aspnet_Applications>("TradePlatformModel.FK__aspnet_Us__Appli__173876EA", "aspnet_Applications").Value;
      }
      set
      {
        ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<aspnet_Applications>("TradePlatformModel.FK__aspnet_Us__Appli__173876EA", "aspnet_Applications").Value = value;
      }
    }

    [Browsable(false)]
    [DataMember]
    public EntityReference<aspnet_Applications> aspnet_ApplicationsReference
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<aspnet_Applications>("TradePlatformModel.FK__aspnet_Us__Appli__173876EA", "aspnet_Applications");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<aspnet_Applications>("TradePlatformModel.FK__aspnet_Us__Appli__173876EA", "aspnet_Applications", value);
      }
    }

    [XmlIgnore]
    [SoapIgnore]
    [DataMember]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "FK__aspnet_Me__UserI__286302EC", "aspnet_Membership")]
    public aspnet_Membership aspnet_Membership
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<aspnet_Membership>("TradePlatformModel.FK__aspnet_Me__UserI__286302EC", "aspnet_Membership").Value;
      }
      set
      {
        ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<aspnet_Membership>("TradePlatformModel.FK__aspnet_Me__UserI__286302EC", "aspnet_Membership").Value = value;
      }
    }

    [DataMember]
    [Browsable(false)]
    public EntityReference<aspnet_Membership> aspnet_MembershipReference
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<aspnet_Membership>("TradePlatformModel.FK__aspnet_Me__UserI__286302EC", "aspnet_Membership");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<aspnet_Membership>("TradePlatformModel.FK__aspnet_Me__UserI__286302EC", "aspnet_Membership", value);
      }
    }

    [SoapIgnore]
    [XmlIgnore]
    [DataMember]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "FK__aspnet_Pr__UserI__3C69FB99", "aspnet_Profile")]
    public aspnet_Profile aspnet_Profile
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<aspnet_Profile>("TradePlatformModel.FK__aspnet_Pr__UserI__3C69FB99", "aspnet_Profile").Value;
      }
      set
      {
        ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<aspnet_Profile>("TradePlatformModel.FK__aspnet_Pr__UserI__3C69FB99", "aspnet_Profile").Value = value;
      }
    }

    [DataMember]
    [Browsable(false)]
    public EntityReference<aspnet_Profile> aspnet_ProfileReference
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<aspnet_Profile>("TradePlatformModel.FK__aspnet_Pr__UserI__3C69FB99", "aspnet_Profile");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<aspnet_Profile>("TradePlatformModel.FK__aspnet_Pr__UserI__3C69FB99", "aspnet_Profile", value);
      }
    }

    [XmlIgnore]
    [DataMember]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "aspnet_UsersInRoles", "aspnet_Roles")]
    [SoapIgnore]
    public EntityCollection<TradePlatform.MT4.Data.aspnet_Roles> aspnet_Roles
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<TradePlatform.MT4.Data.aspnet_Roles>("TradePlatformModel.aspnet_UsersInRoles", "aspnet_Roles");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<TradePlatform.MT4.Data.aspnet_Roles>("TradePlatformModel.aspnet_UsersInRoles", "aspnet_Roles", value);
      }
    }

    public static aspnet_Users Createaspnet_Users(Guid applicationId, Guid userId, string userName, string loweredUserName, bool isAnonymous, DateTime lastActivityDate)
    {
      return new aspnet_Users()
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
