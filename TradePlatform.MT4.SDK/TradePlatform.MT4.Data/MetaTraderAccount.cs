// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.MetaTraderAccount
// Assembly: TradePlatform.MT4.Data, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FF714B79-462F-457E-9D98-705104E62A16
// Assembly location: T:\work\mql4\ForexSharp1\TradePlatform.MT4.SDK\TradePlatform.MT4.Engine\lib\TradePlatform.MT4.Data.dll

using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace TradePlatform.MT4.Data
{
  [EdmEntityType(Name = "MetaTraderAccount", NamespaceName = "TradePlatformModel")]
  [DataContract(IsReference = true)]
  [Serializable]
  public class MetaTraderAccount : EntityObject
  {
    private int _Id;
    private byte[] _RowVersion;
    private Decimal _AccountBalance;
    private double _AccountCredit;
    private string _AccountCompany;
    private string _AccountCurrency;
    private Decimal _AccountEquity;
    private Decimal _AccountFreeMargin;
    private double _AccountFreeMarginMode;
    private int _AccountLeverage;
    private Decimal _AccountMargin;
    private string _AccountName;
    private int _AccountNumber;
    private Decimal _AccountProfit;
    private string _AccountServer;
    private int _AccountStopoutLevel;
    private int _AccountStopoutMode;
    private bool _IsDemo;
    private bool _IsTesting;
    private bool _IsOptimization;
    private bool _IsExpertEnabled;
    private Decimal? _DrawDown;

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

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public Decimal AccountBalance
    {
      get
      {
        return this._AccountBalance;
      }
      set
      {
        this.ReportPropertyChanging("AccountBalance");
        this._AccountBalance = StructuralObject.SetValidValue(value, "AccountBalance");
        this.ReportPropertyChanged("AccountBalance");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public double AccountCredit
    {
      get
      {
        return this._AccountCredit;
      }
      set
      {
        this.ReportPropertyChanging("AccountCredit");
        this._AccountCredit = StructuralObject.SetValidValue(value, "AccountCredit");
        this.ReportPropertyChanged("AccountCredit");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public string AccountCompany
    {
      get
      {
        return this._AccountCompany;
      }
      set
      {
        this.ReportPropertyChanging("AccountCompany");
        this._AccountCompany = StructuralObject.SetValidValue(value, false, "AccountCompany");
        this.ReportPropertyChanged("AccountCompany");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public string AccountCurrency
    {
      get
      {
        return this._AccountCurrency;
      }
      set
      {
        this.ReportPropertyChanging("AccountCurrency");
        this._AccountCurrency = StructuralObject.SetValidValue(value, false, "AccountCurrency");
        this.ReportPropertyChanged("AccountCurrency");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public Decimal AccountEquity
    {
      get
      {
        return this._AccountEquity;
      }
      set
      {
        this.ReportPropertyChanging("AccountEquity");
        this._AccountEquity = StructuralObject.SetValidValue(value, "AccountEquity");
        this.ReportPropertyChanged("AccountEquity");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public Decimal AccountFreeMargin
    {
      get
      {
        return this._AccountFreeMargin;
      }
      set
      {
        this.ReportPropertyChanging("AccountFreeMargin");
        this._AccountFreeMargin = StructuralObject.SetValidValue(value, "AccountFreeMargin");
        this.ReportPropertyChanged("AccountFreeMargin");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public double AccountFreeMarginMode
    {
      get
      {
        return this._AccountFreeMarginMode;
      }
      set
      {
        this.ReportPropertyChanging("AccountFreeMarginMode");
        this._AccountFreeMarginMode = StructuralObject.SetValidValue(value, "AccountFreeMarginMode");
        this.ReportPropertyChanged("AccountFreeMarginMode");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public int AccountLeverage
    {
      get
      {
        return this._AccountLeverage;
      }
      set
      {
        this.ReportPropertyChanging("AccountLeverage");
        this._AccountLeverage = StructuralObject.SetValidValue(value, "AccountLeverage");
        this.ReportPropertyChanged("AccountLeverage");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public Decimal AccountMargin
    {
      get
      {
        return this._AccountMargin;
      }
      set
      {
        this.ReportPropertyChanging("AccountMargin");
        this._AccountMargin = StructuralObject.SetValidValue(value, "AccountMargin");
        this.ReportPropertyChanged("AccountMargin");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public string AccountName
    {
      get
      {
        return this._AccountName;
      }
      set
      {
        this.ReportPropertyChanging("AccountName");
        this._AccountName = StructuralObject.SetValidValue(value, false, "AccountName");
        this.ReportPropertyChanged("AccountName");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public int AccountNumber
    {
      get
      {
        return this._AccountNumber;
      }
      set
      {
        this.ReportPropertyChanging("AccountNumber");
        this._AccountNumber = StructuralObject.SetValidValue(value, "AccountNumber");
        this.ReportPropertyChanged("AccountNumber");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public Decimal AccountProfit
    {
      get
      {
        return this._AccountProfit;
      }
      set
      {
        this.ReportPropertyChanging("AccountProfit");
        this._AccountProfit = StructuralObject.SetValidValue(value, "AccountProfit");
        this.ReportPropertyChanged("AccountProfit");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public string AccountServer
    {
      get
      {
        return this._AccountServer;
      }
      set
      {
        this.ReportPropertyChanging("AccountServer");
        this._AccountServer = StructuralObject.SetValidValue(value, false, "AccountServer");
        this.ReportPropertyChanged("AccountServer");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public int AccountStopoutLevel
    {
      get
      {
        return this._AccountStopoutLevel;
      }
      set
      {
        this.ReportPropertyChanging("AccountStopoutLevel");
        this._AccountStopoutLevel = StructuralObject.SetValidValue(value, "AccountStopoutLevel");
        this.ReportPropertyChanged("AccountStopoutLevel");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public int AccountStopoutMode
    {
      get
      {
        return this._AccountStopoutMode;
      }
      set
      {
        this.ReportPropertyChanging("AccountStopoutMode");
        this._AccountStopoutMode = StructuralObject.SetValidValue(value, "AccountStopoutMode");
        this.ReportPropertyChanged("AccountStopoutMode");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public bool IsDemo
    {
      get
      {
        return this._IsDemo;
      }
      set
      {
        this.ReportPropertyChanging("IsDemo");
        this._IsDemo = StructuralObject.SetValidValue(value, "IsDemo");
        this.ReportPropertyChanged("IsDemo");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public bool IsTesting
    {
      get
      {
        return this._IsTesting;
      }
      set
      {
        this.ReportPropertyChanging("IsTesting");
        this._IsTesting = StructuralObject.SetValidValue(value, "IsTesting");
        this.ReportPropertyChanged("IsTesting");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public bool IsOptimization
    {
      get
      {
        return this._IsOptimization;
      }
      set
      {
        this.ReportPropertyChanging("IsOptimization");
        this._IsOptimization = StructuralObject.SetValidValue(value, "IsOptimization");
        this.ReportPropertyChanged("IsOptimization");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public bool IsExpertEnabled
    {
      get
      {
        return this._IsExpertEnabled;
      }
      set
      {
        this.ReportPropertyChanging("IsExpertEnabled");
        this._IsExpertEnabled = StructuralObject.SetValidValue(value, "IsExpertEnabled");
        this.ReportPropertyChanged("IsExpertEnabled");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public Decimal? DrawDown
    {
      get
      {
        return this._DrawDown;
      }
      set
      {
        this.ReportPropertyChanging("DrawDown");
        this._DrawDown = StructuralObject.SetValidValue(value, "DrawDown");
        this.ReportPropertyChanged("DrawDown");
      }
    }

    [EdmRelationshipNavigationProperty("TradePlatformModel", "ExpertSystem_MetaTraderAccount", "ExpertSystem")]
    [XmlIgnore]
    [DataMember]
    [SoapIgnore]
    public EntityCollection<ExpertSystem> ExpertSystems
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<ExpertSystem>("TradePlatformModel.ExpertSystem_MetaTraderAccount", "ExpertSystem");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<ExpertSystem>("TradePlatformModel.ExpertSystem_MetaTraderAccount", "ExpertSystem", value);
      }
    }

    [EdmRelationshipNavigationProperty("TradePlatformModel", "MetaTraderOrder_MetaTraderAccount", "MetaTraderOrder")]
    [XmlIgnore]
    [SoapIgnore]
    [DataMember]
    public EntityCollection<MetaTraderOrder> MetaTraderOrders
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<MetaTraderOrder>("TradePlatformModel.MetaTraderOrder_MetaTraderAccount", "MetaTraderOrder");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<MetaTraderOrder>("TradePlatformModel.MetaTraderOrder_MetaTraderAccount", "MetaTraderOrder", value);
      }
    }

    [DataMember]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "MetaTraderTickData_MetaTraderAccount", "MetaTraderTickData")]
    [SoapIgnore]
    [XmlIgnore]
    public EntityCollection<MetaTraderTickData> MetaTraderTickDatas
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<MetaTraderTickData>("TradePlatformModel.MetaTraderTickData_MetaTraderAccount", "MetaTraderTickData");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<MetaTraderTickData>("TradePlatformModel.MetaTraderTickData_MetaTraderAccount", "MetaTraderTickData", value);
      }
    }

    [DataMember]
    [SoapIgnore]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "MonthlyData_MetaTraderAccount", "MonthlyData")]
    [XmlIgnore]
    public EntityCollection<MonthlyData> MonthlyDatas
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<MonthlyData>("TradePlatformModel.MonthlyData_MetaTraderAccount", "MonthlyData");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<MonthlyData>("TradePlatformModel.MonthlyData_MetaTraderAccount", "MonthlyData", value);
      }
    }

    [SoapIgnore]
    [DataMember]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "TradeDuplicatorBee_MetaTraderAccount", "TradeDuplicatorBee")]
    [XmlIgnore]
    public EntityCollection<TradeDuplicatorBee> TradeDuplicatorBees
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<TradeDuplicatorBee>("TradePlatformModel.TradeDuplicatorBee_MetaTraderAccount", "TradeDuplicatorBee");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<TradeDuplicatorBee>("TradePlatformModel.TradeDuplicatorBee_MetaTraderAccount", "TradeDuplicatorBee", value);
      }
    }

    public static MetaTraderAccount CreateMetaTraderAccount(int id, byte[] rowVersion, Decimal accountBalance, double accountCredit, string accountCompany, string accountCurrency, Decimal accountEquity, Decimal accountFreeMargin, double accountFreeMarginMode, int accountLeverage, Decimal accountMargin, string accountName, int accountNumber, Decimal accountProfit, string accountServer, int accountStopoutLevel, int accountStopoutMode, bool isDemo, bool isTesting, bool isOptimization, bool isExpertEnabled)
    {
      return new MetaTraderAccount()
      {
        Id = id,
        RowVersion = rowVersion,
        AccountBalance = accountBalance,
        AccountCredit = accountCredit,
        AccountCompany = accountCompany,
        AccountCurrency = accountCurrency,
        AccountEquity = accountEquity,
        AccountFreeMargin = accountFreeMargin,
        AccountFreeMarginMode = accountFreeMarginMode,
        AccountLeverage = accountLeverage,
        AccountMargin = accountMargin,
        AccountName = accountName,
        AccountNumber = accountNumber,
        AccountProfit = accountProfit,
        AccountServer = accountServer,
        AccountStopoutLevel = accountStopoutLevel,
        AccountStopoutMode = accountStopoutMode,
        IsDemo = isDemo,
        IsTesting = isTesting,
        IsOptimization = isOptimization,
        IsExpertEnabled = isExpertEnabled
      };
    }
  }
}
