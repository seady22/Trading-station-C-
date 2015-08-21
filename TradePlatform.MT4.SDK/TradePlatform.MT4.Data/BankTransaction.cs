// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.BankTransaction
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
  [EdmEntityType(Name = "BankTransaction", NamespaceName = "TradePlatformModel")]
  [DataContract(IsReference = true)]
  [Serializable]
  public class BankTransaction : EntityObject
  {
    private int _Id;
    private byte[] _RowVersion;
    private string _Payee;
    private DateTime _TransactionDate;
    private string _Comment;
    private Decimal _Ammount;
    private string _TransactionUniqueId;
    private int _BankAccount_BankTransaction;
    private int _BankTransactionCategory_BankTransaction;

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

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public string Payee
    {
      get
      {
        return this._Payee;
      }
      set
      {
        this.ReportPropertyChanging("Payee");
        this._Payee = StructuralObject.SetValidValue(value, true, "Payee");
        this.ReportPropertyChanged("Payee");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public DateTime TransactionDate
    {
      get
      {
        return this._TransactionDate;
      }
      set
      {
        this.ReportPropertyChanging("TransactionDate");
        this._TransactionDate = StructuralObject.SetValidValue(value, "TransactionDate");
        this.ReportPropertyChanged("TransactionDate");
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
    public Decimal Ammount
    {
      get
      {
        return this._Ammount;
      }
      set
      {
        this.ReportPropertyChanging("Ammount");
        this._Ammount = StructuralObject.SetValidValue(value, "Ammount");
        this.ReportPropertyChanged("Ammount");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public string TransactionUniqueId
    {
      get
      {
        return this._TransactionUniqueId;
      }
      set
      {
        this.ReportPropertyChanging("TransactionUniqueId");
        this._TransactionUniqueId = StructuralObject.SetValidValue(value, false, "TransactionUniqueId");
        this.ReportPropertyChanged("TransactionUniqueId");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public int BankAccount_BankTransaction
    {
      get
      {
        return this._BankAccount_BankTransaction;
      }
      set
      {
        this.ReportPropertyChanging("BankAccount_BankTransaction");
        this._BankAccount_BankTransaction = StructuralObject.SetValidValue(value, "BankAccount_BankTransaction");
        this.ReportPropertyChanged("BankAccount_BankTransaction");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public int BankTransactionCategory_BankTransaction
    {
      get
      {
        return this._BankTransactionCategory_BankTransaction;
      }
      set
      {
        this.ReportPropertyChanging("BankTransactionCategory_BankTransaction");
        this._BankTransactionCategory_BankTransaction = StructuralObject.SetValidValue(value, "BankTransactionCategory_BankTransaction");
        this.ReportPropertyChanged("BankTransactionCategory_BankTransaction");
      }
    }

    [DataMember]
    [SoapIgnore]
    [XmlIgnore]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "BankAccount_BankTransaction", "BankAccount")]
    public BankAccount BankAccount
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BankAccount>("TradePlatformModel.BankAccount_BankTransaction", "BankAccount").Value;
      }
      set
      {
        ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BankAccount>("TradePlatformModel.BankAccount_BankTransaction", "BankAccount").Value = value;
      }
    }

    [DataMember]
    [Browsable(false)]
    public EntityReference<BankAccount> BankAccountReference
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BankAccount>("TradePlatformModel.BankAccount_BankTransaction", "BankAccount");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BankAccount>("TradePlatformModel.BankAccount_BankTransaction", "BankAccount", value);
      }
    }

    [XmlIgnore]
    [DataMember]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "BankTransactionCategory_BankTransaction", "BankTransactionCategory")]
    [SoapIgnore]
    public BankTransactionCategory BankTransactionCategory
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BankTransactionCategory>("TradePlatformModel.BankTransactionCategory_BankTransaction", "BankTransactionCategory").Value;
      }
      set
      {
        ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BankTransactionCategory>("TradePlatformModel.BankTransactionCategory_BankTransaction", "BankTransactionCategory").Value = value;
      }
    }

    [Browsable(false)]
    [DataMember]
    public EntityReference<BankTransactionCategory> BankTransactionCategoryReference
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BankTransactionCategory>("TradePlatformModel.BankTransactionCategory_BankTransaction", "BankTransactionCategory");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BankTransactionCategory>("TradePlatformModel.BankTransactionCategory_BankTransaction", "BankTransactionCategory", value);
      }
    }

    public static BankTransaction CreateBankTransaction(int id, byte[] rowVersion, DateTime transactionDate, Decimal ammount, string transactionUniqueId, int bankAccount_BankTransaction, int bankTransactionCategory_BankTransaction)
    {
      return new BankTransaction()
      {
        Id = id,
        RowVersion = rowVersion,
        TransactionDate = transactionDate,
        Ammount = ammount,
        TransactionUniqueId = transactionUniqueId,
        BankAccount_BankTransaction = bankAccount_BankTransaction,
        BankTransactionCategory_BankTransaction = bankTransactionCategory_BankTransaction
      };
    }
  }
}
