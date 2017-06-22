// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.TradeDuplicatorDrone
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
  [EdmEntityType(Name = "TradeDuplicatorDrone", NamespaceName = "TradePlatformModel")]
  [Serializable]
  public class TradeDuplicatorDrone : EntityObject
  {
    private int _Id;
    private byte[] _RowVersion;
    private string _Name;
    private double _LotRatio;
    private int _Slippage;
    private int _TradeDuplicatorBee_TradeDuplicatorDrone;

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

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public double LotRatio
    {
      get
      {
        return this._LotRatio;
      }
      set
      {
        this.ReportPropertyChanging("LotRatio");
        this._LotRatio = StructuralObject.SetValidValue(value, "LotRatio");
        this.ReportPropertyChanged("LotRatio");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public int Slippage
    {
      get
      {
        return this._Slippage;
      }
      set
      {
        this.ReportPropertyChanging("Slippage");
        this._Slippage = StructuralObject.SetValidValue(value, "Slippage");
        this.ReportPropertyChanged("Slippage");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public int TradeDuplicatorBee_TradeDuplicatorDrone
    {
      get
      {
        return this._TradeDuplicatorBee_TradeDuplicatorDrone;
      }
      set
      {
        this.ReportPropertyChanging("TradeDuplicatorBee_TradeDuplicatorDrone");
        this._TradeDuplicatorBee_TradeDuplicatorDrone = StructuralObject.SetValidValue(value, "TradeDuplicatorBee_TradeDuplicatorDrone");
        this.ReportPropertyChanged("TradeDuplicatorBee_TradeDuplicatorDrone");
      }
    }

    [EdmRelationshipNavigationProperty("TradePlatformModel", "TradeDuplicatorBee_TradeDuplicatorDrone", "TradeDuplicatorBee")]
    [DataMember]
    [XmlIgnore]
    [SoapIgnore]
    public TradeDuplicatorBee TradeDuplicatorBee
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TradeDuplicatorBee>("TradePlatformModel.TradeDuplicatorBee_TradeDuplicatorDrone", "TradeDuplicatorBee").Value;
      }
      set
      {
        ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TradeDuplicatorBee>("TradePlatformModel.TradeDuplicatorBee_TradeDuplicatorDrone", "TradeDuplicatorBee").Value = value;
      }
    }

    [Browsable(false)]
    [DataMember]
    public EntityReference<TradeDuplicatorBee> TradeDuplicatorBeeReference
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TradeDuplicatorBee>("TradePlatformModel.TradeDuplicatorBee_TradeDuplicatorDrone", "TradeDuplicatorBee");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<TradeDuplicatorBee>("TradePlatformModel.TradeDuplicatorBee_TradeDuplicatorDrone", "TradeDuplicatorBee", value);
      }
    }

    public static TradeDuplicatorDrone CreateTradeDuplicatorDrone(int id, byte[] rowVersion, string name, double lotRatio, int slippage, int tradeDuplicatorBee_TradeDuplicatorDrone)
    {
      return new TradeDuplicatorDrone()
      {
        Id = id,
        RowVersion = rowVersion,
        Name = name,
        LotRatio = lotRatio,
        Slippage = slippage,
        TradeDuplicatorBee_TradeDuplicatorDrone = tradeDuplicatorBee_TradeDuplicatorDrone
      };
    }
  }
}
