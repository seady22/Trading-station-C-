// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.aspnet_Profile
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
  [EdmEntityType(Name = "aspnet_Profile", NamespaceName = "TradePlatformModel")]
  [DataContract(IsReference = true)]
  [Serializable]
  public class aspnet_Profile : EntityObject
  {
    private Guid _UserId;
    private string _PropertyNames;
    private string _PropertyValuesString;
    private byte[] _PropertyValuesBinary;
    private DateTime _LastUpdatedDate;

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
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public string PropertyNames
    {
      get
      {
        return this._PropertyNames;
      }
      set
      {
        this.ReportPropertyChanging("PropertyNames");
        this._PropertyNames = StructuralObject.SetValidValue(value, false, "PropertyNames");
        this.ReportPropertyChanged("PropertyNames");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public string PropertyValuesString
    {
      get
      {
        return this._PropertyValuesString;
      }
      set
      {
        this.ReportPropertyChanging("PropertyValuesString");
        this._PropertyValuesString = StructuralObject.SetValidValue(value, false, "PropertyValuesString");
        this.ReportPropertyChanged("PropertyValuesString");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public byte[] PropertyValuesBinary
    {
      get
      {
        return StructuralObject.GetValidValue(this._PropertyValuesBinary);
      }
      set
      {
        this.ReportPropertyChanging("PropertyValuesBinary");
        this._PropertyValuesBinary = StructuralObject.SetValidValue(value, false, "PropertyValuesBinary");
        this.ReportPropertyChanged("PropertyValuesBinary");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public DateTime LastUpdatedDate
    {
      get
      {
        return this._LastUpdatedDate;
      }
      set
      {
        this.ReportPropertyChanging("LastUpdatedDate");
        this._LastUpdatedDate = StructuralObject.SetValidValue(value, "LastUpdatedDate");
        this.ReportPropertyChanged("LastUpdatedDate");
      }
    }

    [DataMember]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "FK__aspnet_Pr__UserI__3C69FB99", "aspnet_Users")]
    [XmlIgnore]
    [SoapIgnore]
    public aspnet_Users aspnet_Users
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<aspnet_Users>("TradePlatformModel.FK__aspnet_Pr__UserI__3C69FB99", "aspnet_Users").Value;
      }
      set
      {
        ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<aspnet_Users>("TradePlatformModel.FK__aspnet_Pr__UserI__3C69FB99", "aspnet_Users").Value = value;
      }
    }

    [DataMember]
    [Browsable(false)]
    public EntityReference<aspnet_Users> aspnet_UsersReference
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<aspnet_Users>("TradePlatformModel.FK__aspnet_Pr__UserI__3C69FB99", "aspnet_Users");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<aspnet_Users>("TradePlatformModel.FK__aspnet_Pr__UserI__3C69FB99", "aspnet_Users", value);
      }
    }

    public static aspnet_Profile Createaspnet_Profile(Guid userId, string propertyNames, string propertyValuesString, byte[] propertyValuesBinary, DateTime lastUpdatedDate)
    {
      return new aspnet_Profile()
      {
        UserId = userId,
        PropertyNames = propertyNames,
        PropertyValuesString = propertyValuesString,
        PropertyValuesBinary = propertyValuesBinary,
        LastUpdatedDate = lastUpdatedDate
      };
    }
  }
}
