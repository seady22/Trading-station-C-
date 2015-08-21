// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.MetaTraderOrder
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
  [EdmEntityType(Name = "MetaTraderOrder", NamespaceName = "TradePlatformModel")]
  [DataContract(IsReference = true)]
  [Serializable]
  public class MetaTraderOrder : EntityObject
  {
    private int _Id;
    private byte[] _RowVersion;
    private int _Ticket;
    private string _Comment;
    private DateTime _OpenTime;
    private DateTime _CloseTime;
    private double _OpenPrice;
    private double _ClosePrice;
    private double _StopLoss;
    private double _TakeProfit;
    private string _Type;
    private double _Size;
    private string _Symbol;
    private Decimal _Swap;
    private Decimal _Profit;
    private int _MagicNumber;
    private Decimal _Commission;
    private bool _IsClosed;
    private int _MetaTraderOrder_MetaTraderAccount;
    private int? _ExpertSystem_MetaTraderOrder;

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

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
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
    public int Ticket
    {
      get
      {
        return this._Ticket;
      }
      set
      {
        this.ReportPropertyChanging("Ticket");
        this._Ticket = StructuralObject.SetValidValue(value, "Ticket");
        this.ReportPropertyChanged("Ticket");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public string Comment
    {
      get
      {
        return this._Comment;
      }
      set
      {
        this.ReportPropertyChanging("Comment");
        this._Comment = StructuralObject.SetValidValue(value, true, "Comment");
        this.ReportPropertyChanged("Comment");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public DateTime OpenTime
    {
      get
      {
        return this._OpenTime;
      }
      set
      {
        this.ReportPropertyChanging("OpenTime");
        this._OpenTime = StructuralObject.SetValidValue(value, "OpenTime");
        this.ReportPropertyChanged("OpenTime");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public DateTime CloseTime
    {
      get
      {
        return this._CloseTime;
      }
      set
      {
        this.ReportPropertyChanging("CloseTime");
        this._CloseTime = StructuralObject.SetValidValue(value, "CloseTime");
        this.ReportPropertyChanged("CloseTime");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public double OpenPrice
    {
      get
      {
        return this._OpenPrice;
      }
      set
      {
        this.ReportPropertyChanging("OpenPrice");
        this._OpenPrice = StructuralObject.SetValidValue(value, "OpenPrice");
        this.ReportPropertyChanged("OpenPrice");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public double ClosePrice
    {
      get
      {
        return this._ClosePrice;
      }
      set
      {
        this.ReportPropertyChanging("ClosePrice");
        this._ClosePrice = StructuralObject.SetValidValue(value, "ClosePrice");
        this.ReportPropertyChanged("ClosePrice");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public double StopLoss
    {
      get
      {
        return this._StopLoss;
      }
      set
      {
        this.ReportPropertyChanging("StopLoss");
        this._StopLoss = StructuralObject.SetValidValue(value, "StopLoss");
        this.ReportPropertyChanged("StopLoss");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public double TakeProfit
    {
      get
      {
        return this._TakeProfit;
      }
      set
      {
        this.ReportPropertyChanging("TakeProfit");
        this._TakeProfit = StructuralObject.SetValidValue(value, "TakeProfit");
        this.ReportPropertyChanged("TakeProfit");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public string Type
    {
      get
      {
        return this._Type;
      }
      set
      {
        this.ReportPropertyChanging("Type");
        this._Type = StructuralObject.SetValidValue(value, false, "Type");
        this.ReportPropertyChanged("Type");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public double Size
    {
      get
      {
        return this._Size;
      }
      set
      {
        this.ReportPropertyChanging("Size");
        this._Size = StructuralObject.SetValidValue(value, "Size");
        this.ReportPropertyChanged("Size");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public string Symbol
    {
      get
      {
        return this._Symbol;
      }
      set
      {
        this.ReportPropertyChanging("Symbol");
        this._Symbol = StructuralObject.SetValidValue(value, false, "Symbol");
        this.ReportPropertyChanged("Symbol");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public Decimal Swap
    {
      get
      {
        return this._Swap;
      }
      set
      {
        this.ReportPropertyChanging("Swap");
        this._Swap = StructuralObject.SetValidValue(value, "Swap");
        this.ReportPropertyChanged("Swap");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public Decimal Profit
    {
      get
      {
        return this._Profit;
      }
      set
      {
        this.ReportPropertyChanging("Profit");
        this._Profit = StructuralObject.SetValidValue(value, "Profit");
        this.ReportPropertyChanged("Profit");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public int MagicNumber
    {
      get
      {
        return this._MagicNumber;
      }
      set
      {
        this.ReportPropertyChanging("MagicNumber");
        this._MagicNumber = StructuralObject.SetValidValue(value, "MagicNumber");
        this.ReportPropertyChanged("MagicNumber");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public Decimal Commission
    {
      get
      {
        return this._Commission;
      }
      set
      {
        this.ReportPropertyChanging("Commission");
        this._Commission = StructuralObject.SetValidValue(value, "Commission");
        this.ReportPropertyChanged("Commission");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public bool IsClosed
    {
      get
      {
        return this._IsClosed;
      }
      set
      {
        this.ReportPropertyChanging("IsClosed");
        this._IsClosed = StructuralObject.SetValidValue(value, "IsClosed");
        this.ReportPropertyChanged("IsClosed");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public int MetaTraderOrder_MetaTraderAccount
    {
      get
      {
        return this._MetaTraderOrder_MetaTraderAccount;
      }
      set
      {
        this.ReportPropertyChanging("MetaTraderOrder_MetaTraderAccount");
        this._MetaTraderOrder_MetaTraderAccount = StructuralObject.SetValidValue(value, "MetaTraderOrder_MetaTraderAccount");
        this.ReportPropertyChanged("MetaTraderOrder_MetaTraderAccount");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public int? ExpertSystem_MetaTraderOrder
    {
      get
      {
        return this._ExpertSystem_MetaTraderOrder;
      }
      set
      {
        this.ReportPropertyChanging("ExpertSystem_MetaTraderOrder");
        this._ExpertSystem_MetaTraderOrder = StructuralObject.SetValidValue(value, "ExpertSystem_MetaTraderOrder");
        this.ReportPropertyChanged("ExpertSystem_MetaTraderOrder");
      }
    }

    [XmlIgnore]
    [SoapIgnore]
    [DataMember]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "ExpertSystem_MetaTraderOrder", "ExpertSystem")]
    public ExpertSystem ExpertSystem
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ExpertSystem>("TradePlatformModel.ExpertSystem_MetaTraderOrder", "ExpertSystem").Value;
      }
      set
      {
        ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ExpertSystem>("TradePlatformModel.ExpertSystem_MetaTraderOrder", "ExpertSystem").Value = value;
      }
    }

    [DataMember]
    [Browsable(false)]
    public EntityReference<ExpertSystem> ExpertSystemReference
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ExpertSystem>("TradePlatformModel.ExpertSystem_MetaTraderOrder", "ExpertSystem");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<ExpertSystem>("TradePlatformModel.ExpertSystem_MetaTraderOrder", "ExpertSystem", value);
      }
    }

    [SoapIgnore]
    [DataMember]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "MetaTraderOrder_MetaTraderAccount", "MetaTraderAccount")]
    [XmlIgnore]
    public MetaTraderAccount MetaTraderAccount
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<MetaTraderAccount>("TradePlatformModel.MetaTraderOrder_MetaTraderAccount", "MetaTraderAccount").Value;
      }
      set
      {
        ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<MetaTraderAccount>("TradePlatformModel.MetaTraderOrder_MetaTraderAccount", "MetaTraderAccount").Value = value;
      }
    }

    [DataMember]
    [Browsable(false)]
    public EntityReference<MetaTraderAccount> MetaTraderAccountReference
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<MetaTraderAccount>("TradePlatformModel.MetaTraderOrder_MetaTraderAccount", "MetaTraderAccount");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<MetaTraderAccount>("TradePlatformModel.MetaTraderOrder_MetaTraderAccount", "MetaTraderAccount", value);
      }
    }

    public static MetaTraderOrder CreateMetaTraderOrder(int id, byte[] rowVersion, int ticket, DateTime openTime, DateTime closeTime, double openPrice, double closePrice, double stopLoss, double takeProfit, string type, double size, string symbol, Decimal swap, Decimal profit, int magicNumber, Decimal commission, bool isClosed, int metaTraderOrder_MetaTraderAccount)
    {
      return new MetaTraderOrder()
      {
        Id = id,
        RowVersion = rowVersion,
        Ticket = ticket,
        OpenTime = openTime,
        CloseTime = closeTime,
        OpenPrice = openPrice,
        ClosePrice = closePrice,
        StopLoss = stopLoss,
        TakeProfit = takeProfit,
        Type = type,
        Size = size,
        Symbol = symbol,
        Swap = swap,
        Profit = profit,
        MagicNumber = magicNumber,
        Commission = commission,
        IsClosed = isClosed,
        MetaTraderOrder_MetaTraderAccount = metaTraderOrder_MetaTraderAccount
      };
    }
  }
}
