// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.MetaTraderTickData
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
  [EdmEntityType(Name = "MetaTraderTickData", NamespaceName = "TradePlatformModel")]
  [Serializable]
  public class MetaTraderTickData : EntityObject
  {
    private int _Id;
    private byte[] _RowVersion;
    private double _Bid;
    private double _Ask;
    private DateTime _TickDate;
    private Decimal _Equity;
    private int _MetaTraderTickData_MetaTraderAccount;

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
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
    public double Bid
    {
      get
      {
        return this._Bid;
      }
      set
      {
        this.ReportPropertyChanging("Bid");
        this._Bid = StructuralObject.SetValidValue(value, "Bid");
        this.ReportPropertyChanged("Bid");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public double Ask
    {
      get
      {
        return this._Ask;
      }
      set
      {
        this.ReportPropertyChanging("Ask");
        this._Ask = StructuralObject.SetValidValue(value, "Ask");
        this.ReportPropertyChanged("Ask");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public DateTime TickDate
    {
      get
      {
        return this._TickDate;
      }
      set
      {
        this.ReportPropertyChanging("TickDate");
        this._TickDate = StructuralObject.SetValidValue(value, "TickDate");
        this.ReportPropertyChanged("TickDate");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public Decimal Equity
    {
      get
      {
        return this._Equity;
      }
      set
      {
        this.ReportPropertyChanging("Equity");
        this._Equity = StructuralObject.SetValidValue(value, "Equity");
        this.ReportPropertyChanged("Equity");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public int MetaTraderTickData_MetaTraderAccount
    {
      get
      {
        return this._MetaTraderTickData_MetaTraderAccount;
      }
      set
      {
        this.ReportPropertyChanging("MetaTraderTickData_MetaTraderAccount");
        this._MetaTraderTickData_MetaTraderAccount = StructuralObject.SetValidValue(value, "MetaTraderTickData_MetaTraderAccount");
        this.ReportPropertyChanged("MetaTraderTickData_MetaTraderAccount");
      }
    }

    [XmlIgnore]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "MetaTraderTickData_MetaTraderAccount", "MetaTraderAccount")]
    [DataMember]
    [SoapIgnore]
    public MetaTraderAccount MetaTraderAccount
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<MetaTraderAccount>("TradePlatformModel.MetaTraderTickData_MetaTraderAccount", "MetaTraderAccount").Value;
      }
      set
      {
        ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<MetaTraderAccount>("TradePlatformModel.MetaTraderTickData_MetaTraderAccount", "MetaTraderAccount").Value = value;
      }
    }

    [DataMember]
    [Browsable(false)]
    public EntityReference<MetaTraderAccount> MetaTraderAccountReference
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<MetaTraderAccount>("TradePlatformModel.MetaTraderTickData_MetaTraderAccount", "MetaTraderAccount");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<MetaTraderAccount>("TradePlatformModel.MetaTraderTickData_MetaTraderAccount", "MetaTraderAccount", value);
      }
    }

    public static MetaTraderTickData CreateMetaTraderTickData(int id, byte[] rowVersion, double bid, double ask, DateTime tickDate, Decimal equity, int metaTraderTickData_MetaTraderAccount)
    {
      return new MetaTraderTickData()
      {
        Id = id,
        RowVersion = rowVersion,
        Bid = bid,
        Ask = ask,
        TickDate = tickDate,
        Equity = equity,
        MetaTraderTickData_MetaTraderAccount = metaTraderTickData_MetaTraderAccount
      };
    }
  }
}
