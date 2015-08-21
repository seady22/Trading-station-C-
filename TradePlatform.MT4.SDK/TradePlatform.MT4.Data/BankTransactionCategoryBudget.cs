// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.BankTransactionCategoryBudget
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
  [EdmEntityType(Name = "BankTransactionCategoryBudget", NamespaceName = "TradePlatformModel")]
  [Serializable]
  public class BankTransactionCategoryBudget : EntityObject
  {
    private int _Id;
    private byte[] _RowVersion;
    private Decimal _PeriodLimit;
    private int _BankTransactionCategoryBudget_BankTransactionCategory;
    private int _BankTransactionCategoryBudgetP_BankTransactionCategoryBudget;

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

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public Decimal PeriodLimit
    {
      get
      {
        return this._PeriodLimit;
      }
      set
      {
        this.ReportPropertyChanging("PeriodLimit");
        this._PeriodLimit = StructuralObject.SetValidValue(value, "PeriodLimit");
        this.ReportPropertyChanged("PeriodLimit");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public int BankTransactionCategoryBudget_BankTransactionCategory
    {
      get
      {
        return this._BankTransactionCategoryBudget_BankTransactionCategory;
      }
      set
      {
        this.ReportPropertyChanging("BankTransactionCategoryBudget_BankTransactionCategory");
        this._BankTransactionCategoryBudget_BankTransactionCategory = StructuralObject.SetValidValue(value, "BankTransactionCategoryBudget_BankTransactionCategory");
        this.ReportPropertyChanged("BankTransactionCategoryBudget_BankTransactionCategory");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public int BankTransactionCategoryBudgetP_BankTransactionCategoryBudget
    {
      get
      {
        return this._BankTransactionCategoryBudgetP_BankTransactionCategoryBudget;
      }
      set
      {
        this.ReportPropertyChanging("BankTransactionCategoryBudgetP_BankTransactionCategoryBudget");
        this._BankTransactionCategoryBudgetP_BankTransactionCategoryBudget = StructuralObject.SetValidValue(value, "BankTransactionCategoryBudgetP_BankTransactionCategoryBudget");
        this.ReportPropertyChanged("BankTransactionCategoryBudgetP_BankTransactionCategoryBudget");
      }
    }

    [DataMember]
    [XmlIgnore]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "BankTransactionCategoryBudget_BankTransactionCategory", "BankTransactionCategory")]
    [SoapIgnore]
    public BankTransactionCategory BankTransactionCategory
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BankTransactionCategory>("TradePlatformModel.BankTransactionCategoryBudget_BankTransactionCategory", "BankTransactionCategory").Value;
      }
      set
      {
        ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BankTransactionCategory>("TradePlatformModel.BankTransactionCategoryBudget_BankTransactionCategory", "BankTransactionCategory").Value = value;
      }
    }

    [DataMember]
    [Browsable(false)]
    public EntityReference<BankTransactionCategory> BankTransactionCategoryReference
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BankTransactionCategory>("TradePlatformModel.BankTransactionCategoryBudget_BankTransactionCategory", "BankTransactionCategory");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BankTransactionCategory>("TradePlatformModel.BankTransactionCategoryBudget_BankTransactionCategory", "BankTransactionCategory", value);
      }
    }

    [DataMember]
    [XmlIgnore]
    [SoapIgnore]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "BankTransactionCategoryBudgetP_BankTransactionCategoryBudget", "BankTransactionCategoryBudgetPeriod")]
    public BankTransactionCategoryBudgetPeriod BankTransactionCategoryBudgetPeriod
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BankTransactionCategoryBudgetPeriod>("TradePlatformModel.BankTransactionCategoryBudgetP_BankTransactionCategoryBudget", "BankTransactionCategoryBudgetPeriod").Value;
      }
      set
      {
        ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BankTransactionCategoryBudgetPeriod>("TradePlatformModel.BankTransactionCategoryBudgetP_BankTransactionCategoryBudget", "BankTransactionCategoryBudgetPeriod").Value = value;
      }
    }

    [Browsable(false)]
    [DataMember]
    public EntityReference<BankTransactionCategoryBudgetPeriod> BankTransactionCategoryBudgetPeriodReference
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BankTransactionCategoryBudgetPeriod>("TradePlatformModel.BankTransactionCategoryBudgetP_BankTransactionCategoryBudget", "BankTransactionCategoryBudgetPeriod");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BankTransactionCategoryBudgetPeriod>("TradePlatformModel.BankTransactionCategoryBudgetP_BankTransactionCategoryBudget", "BankTransactionCategoryBudgetPeriod", value);
      }
    }

    public static BankTransactionCategoryBudget CreateBankTransactionCategoryBudget(int id, byte[] rowVersion, Decimal periodLimit, int bankTransactionCategoryBudget_BankTransactionCategory, int bankTransactionCategoryBudgetP_BankTransactionCategoryBudget)
    {
      return new BankTransactionCategoryBudget()
      {
        Id = id,
        RowVersion = rowVersion,
        PeriodLimit = periodLimit,
        BankTransactionCategoryBudget_BankTransactionCategory = bankTransactionCategoryBudget_BankTransactionCategory,
        BankTransactionCategoryBudgetP_BankTransactionCategoryBudget = bankTransactionCategoryBudgetP_BankTransactionCategoryBudget
      };
    }
  }
}
