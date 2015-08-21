// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.BankTransactionCategoryBudgetPeriod
// Assembly: TradePlatform.MT4.Data, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FF714B79-462F-457E-9D98-705104E62A16
// Assembly location: T:\work\mql4\ForexSharp1\TradePlatform.MT4.SDK\TradePlatform.MT4.Engine\lib\TradePlatform.MT4.Data.dll

using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace TradePlatform.MT4.Data
{
  [EdmEntityType(Name = "BankTransactionCategoryBudgetPeriod", NamespaceName = "TradePlatformModel")]
  [DataContract(IsReference = true)]
  [Serializable]
  public class BankTransactionCategoryBudgetPeriod : EntityObject
  {
    private int _Id;
    private byte[] _RowVersion;
    private DateTime _BudgetPeriodStart;
    private DateTime _BudgetPeriodEnd;
    private string _Comment;

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
    public DateTime BudgetPeriodStart
    {
      get
      {
        return this._BudgetPeriodStart;
      }
      set
      {
        this.ReportPropertyChanging("BudgetPeriodStart");
        this._BudgetPeriodStart = StructuralObject.SetValidValue(value, "BudgetPeriodStart");
        this.ReportPropertyChanged("BudgetPeriodStart");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public DateTime BudgetPeriodEnd
    {
      get
      {
        return this._BudgetPeriodEnd;
      }
      set
      {
        this.ReportPropertyChanging("BudgetPeriodEnd");
        this._BudgetPeriodEnd = StructuralObject.SetValidValue(value, "BudgetPeriodEnd");
        this.ReportPropertyChanged("BudgetPeriodEnd");
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

    [XmlIgnore]
    [SoapIgnore]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "BankTransactionCategoryBudgetP_BankTransactionCategoryBudget", "BankTransactionCategoryBudget")]
    [DataMember]
    public EntityCollection<BankTransactionCategoryBudget> BankTransactionCategoryBudgets
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BankTransactionCategoryBudget>("TradePlatformModel.BankTransactionCategoryBudgetP_BankTransactionCategoryBudget", "BankTransactionCategoryBudget");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BankTransactionCategoryBudget>("TradePlatformModel.BankTransactionCategoryBudgetP_BankTransactionCategoryBudget", "BankTransactionCategoryBudget", value);
      }
    }

    public static BankTransactionCategoryBudgetPeriod CreateBankTransactionCategoryBudgetPeriod(int id, byte[] rowVersion, DateTime budgetPeriodStart, DateTime budgetPeriodEnd)
    {
      return new BankTransactionCategoryBudgetPeriod()
      {
        Id = id,
        RowVersion = rowVersion,
        BudgetPeriodStart = budgetPeriodStart,
        BudgetPeriodEnd = budgetPeriodEnd
      };
    }
  }
}
