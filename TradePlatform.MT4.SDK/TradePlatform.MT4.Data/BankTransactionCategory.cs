// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.BankTransactionCategory
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
  [EdmEntityType(Name = "BankTransactionCategory", NamespaceName = "TradePlatformModel")]
  [DataContract(IsReference = true)]
  [Serializable]
  public class BankTransactionCategory : EntityObject
  {
    private int _Id;
    private byte[] _RowVersion;
    private string _Name;
    private bool _HasBudget;
    private int _BankTransactionCategoryGroup_BankTransactionCategory;

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

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
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
    public bool HasBudget
    {
      get
      {
        return this._HasBudget;
      }
      set
      {
        this.ReportPropertyChanging("HasBudget");
        this._HasBudget = StructuralObject.SetValidValue(value, "HasBudget");
        this.ReportPropertyChanged("HasBudget");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public int BankTransactionCategoryGroup_BankTransactionCategory
    {
      get
      {
        return this._BankTransactionCategoryGroup_BankTransactionCategory;
      }
      set
      {
        this.ReportPropertyChanging("BankTransactionCategoryGroup_BankTransactionCategory");
        this._BankTransactionCategoryGroup_BankTransactionCategory = StructuralObject.SetValidValue(value, "BankTransactionCategoryGroup_BankTransactionCategory");
        this.ReportPropertyChanged("BankTransactionCategoryGroup_BankTransactionCategory");
      }
    }

    [SoapIgnore]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "BankTransactionCategory_BankTransaction", "BankTransaction")]
    [XmlIgnore]
    [DataMember]
    public EntityCollection<BankTransaction> BankTransactions
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BankTransaction>("TradePlatformModel.BankTransactionCategory_BankTransaction", "BankTransaction");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BankTransaction>("TradePlatformModel.BankTransactionCategory_BankTransaction", "BankTransaction", value);
      }
    }

    [EdmRelationshipNavigationProperty("TradePlatformModel", "BankTransactionCategoryBudget_BankTransactionCategory", "BankTransactionCategoryBudget")]
    [XmlIgnore]
    [SoapIgnore]
    [DataMember]
    public EntityCollection<BankTransactionCategoryBudget> BankTransactionCategoryBudgets
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BankTransactionCategoryBudget>("TradePlatformModel.BankTransactionCategoryBudget_BankTransactionCategory", "BankTransactionCategoryBudget");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BankTransactionCategoryBudget>("TradePlatformModel.BankTransactionCategoryBudget_BankTransactionCategory", "BankTransactionCategoryBudget", value);
      }
    }

    [XmlIgnore]
    [DataMember]
    [SoapIgnore]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "BankTransactionCategoryGroup_BankTransactionCategory", "BankTransactionCategoryGroup")]
    public BankTransactionCategoryGroup BankTransactionCategoryGroup
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BankTransactionCategoryGroup>("TradePlatformModel.BankTransactionCategoryGroup_BankTransactionCategory", "BankTransactionCategoryGroup").Value;
      }
      set
      {
        ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BankTransactionCategoryGroup>("TradePlatformModel.BankTransactionCategoryGroup_BankTransactionCategory", "BankTransactionCategoryGroup").Value = value;
      }
    }

    [Browsable(false)]
    [DataMember]
    public EntityReference<BankTransactionCategoryGroup> BankTransactionCategoryGroupReference
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BankTransactionCategoryGroup>("TradePlatformModel.BankTransactionCategoryGroup_BankTransactionCategory", "BankTransactionCategoryGroup");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BankTransactionCategoryGroup>("TradePlatformModel.BankTransactionCategoryGroup_BankTransactionCategory", "BankTransactionCategoryGroup", value);
      }
    }

    public static BankTransactionCategory CreateBankTransactionCategory(int id, byte[] rowVersion, string name, bool hasBudget, int bankTransactionCategoryGroup_BankTransactionCategory)
    {
      return new BankTransactionCategory()
      {
        Id = id,
        RowVersion = rowVersion,
        Name = name,
        HasBudget = hasBudget,
        BankTransactionCategoryGroup_BankTransactionCategory = bankTransactionCategoryGroup_BankTransactionCategory
      };
    }
  }
}
