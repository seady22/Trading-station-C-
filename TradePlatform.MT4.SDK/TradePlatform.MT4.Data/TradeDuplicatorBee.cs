// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.TradeDuplicatorBee
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
  [EdmEntityType(Name = "TradeDuplicatorBee", NamespaceName = "TradePlatformModel")]
  [DataContract(IsReference = true)]
  [Serializable]
  public class TradeDuplicatorBee : EntityObject
  {
    private int _Id;
    private byte[] _RowVersion;
    private string _Name;
    private int _TradeDuplicatorBee_MetaTraderAccount;

    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    [DataMember]
    public int Id
    {
      get
      {
        return this._Id;
      }
      set
      {
        if (this._Id == value)
          return;
        this.ReportPropertyChanging("Id");
        this._Id = StructuralObject.SetValidValue(value, "Id");
        this.ReportPropertyChanged("Id");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public byte[] RowVersion
    {
      get
      {
        return StructuralObject.GetValidValue(this._RowVersion);
      }
      set
      {
        this.ReportPropertyChanging("RowVersion");
        this._RowVersion = StructuralObject.SetValidValue(value, true, "RowVersion");
        this.ReportPropertyChanged("RowVersion");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public string Name
    {
      get
      {
        return this._Name;
      }
      set
      {
        this.ReportPropertyChanging("Name");
        this._Name = StructuralObject.SetValidValue(value, false, "Name");
        this.ReportPropertyChanged("Name");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public int TradeDuplicatorBee_MetaTraderAccount
    {
      get
      {
        return this._TradeDuplicatorBee_MetaTraderAccount;
      }
      set
      {
        this.ReportPropertyChanging("TradeDuplicatorBee_MetaTraderAccount");
        this._TradeDuplicatorBee_MetaTraderAccount = StructuralObject.SetValidValue(value, "TradeDuplicatorBee_MetaTraderAccount");
        this.ReportPropertyChanged("TradeDuplicatorBee_MetaTraderAccount");
      }
    }

    [EdmRelationshipNavigationProperty("TradePlatformModel", "TradeDuplicatorBee_MetaTraderAccount", "MetaTraderAccount")]
    [XmlIgnore]
    [DataMember]
    [SoapIgnore]
    public MetaTraderAccount MetaTraderAccount
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<MetaTraderAccount>("TradePlatformModel.TradeDuplicatorBee_MetaTraderAccount", "MetaTraderAccount").Value;
      }
      set
      {
        ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<MetaTraderAccount>("TradePlatformModel.TradeDuplicatorBee_MetaTraderAccount", "MetaTraderAccount").Value = value;
      }
    }

    [DataMember]
    [Browsable(false)]
    public EntityReference<MetaTraderAccount> MetaTraderAccountReference
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<MetaTraderAccount>("TradePlatformModel.TradeDuplicatorBee_MetaTraderAccount", "MetaTraderAccount");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<MetaTraderAccount>("TradePlatformModel.TradeDuplicatorBee_MetaTraderAccount", "MetaTraderAccount", value);
      }
    }

    [SoapIgnore]
    [DataMember]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "TradeDuplicatorBee_TradeDuplicatorDrone", "TradeDuplicatorDrone")]
    [XmlIgnore]
    public EntityCollection<TradeDuplicatorDrone> TradeDuplicatorDrones
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<TradeDuplicatorDrone>("TradePlatformModel.TradeDuplicatorBee_TradeDuplicatorDrone", "TradeDuplicatorDrone");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<TradeDuplicatorDrone>("TradePlatformModel.TradeDuplicatorBee_TradeDuplicatorDrone", "TradeDuplicatorDrone", value);
      }
    }

    public static TradeDuplicatorBee CreateTradeDuplicatorBee(int id, byte[] rowVersion, string name, int tradeDuplicatorBee_MetaTraderAccount)
    {
      return new TradeDuplicatorBee()
      {
        Id = id,
        RowVersion = rowVersion,
        Name = name,
        TradeDuplicatorBee_MetaTraderAccount = tradeDuplicatorBee_MetaTraderAccount
      };
    }
  }
}
