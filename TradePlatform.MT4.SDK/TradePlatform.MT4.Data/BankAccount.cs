// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.BankAccount
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
  [EdmEntityType(Name = "BankAccount", NamespaceName = "TradePlatformModel")]
  [DataContract(IsReference = true)]
  [Serializable]
  public class BankAccount : EntityObject
  {
    private int _Id;
    private byte[] _RowVersion;
    private string _Name;
    private string _Number;
    private string _Abbr;
    private Decimal _InitionalDeposit;
    private int? _BankAccount_BankAccountGroup;

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

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public string Number
    {
      get
      {
        return this._Number;
      }
      set
      {
        this.ReportPropertyChanging("Number");
        this._Number = StructuralObject.SetValidValue(value, false, "Number");
        this.ReportPropertyChanged("Number");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public string Abbr
    {
      get
      {
        return this._Abbr;
      }
      set
      {
        this.ReportPropertyChanging("Abbr");
        this._Abbr = StructuralObject.SetValidValue(value, false, "Abbr");
        this.ReportPropertyChanged("Abbr");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public Decimal InitionalDeposit
    {
      get
      {
        return this._InitionalDeposit;
      }
      set
      {
        this.ReportPropertyChanging("InitionalDeposit");
        this._InitionalDeposit = StructuralObject.SetValidValue(value, "InitionalDeposit");
        this.ReportPropertyChanged("InitionalDeposit");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public int? BankAccount_BankAccountGroup
    {
      get
      {
        return this._BankAccount_BankAccountGroup;
      }
      set
      {
        this.ReportPropertyChanging("BankAccount_BankAccountGroup");
        this._BankAccount_BankAccountGroup = StructuralObject.SetValidValue(value, "BankAccount_BankAccountGroup");
        this.ReportPropertyChanged("BankAccount_BankAccountGroup");
      }
    }

    [SoapIgnore]
    [XmlIgnore]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "BankAccount_BankAccountGroup", "BankAccountGroup")]
    [DataMember]
    public BankAccountGroup BankAccountGroup
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BankAccountGroup>("TradePlatformModel.BankAccount_BankAccountGroup", "BankAccountGroup").Value;
      }
      set
      {
        ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BankAccountGroup>("TradePlatformModel.BankAccount_BankAccountGroup", "BankAccountGroup").Value = value;
      }
    }

    [DataMember]
    [Browsable(false)]
    public EntityReference<BankAccountGroup> BankAccountGroupReference
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BankAccountGroup>("TradePlatformModel.BankAccount_BankAccountGroup", "BankAccountGroup");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BankAccountGroup>("TradePlatformModel.BankAccount_BankAccountGroup", "BankAccountGroup", value);
      }
    }

    [XmlIgnore]
    [SoapIgnore]
    [DataMember]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "BankAccount_BankTransaction", "BankTransaction")]
    public EntityCollection<BankTransaction> BankTransactions
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BankTransaction>("TradePlatformModel.BankAccount_BankTransaction", "BankTransaction");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BankTransaction>("TradePlatformModel.BankAccount_BankTransaction", "BankTransaction", value);
      }
    }

    public static BankAccount CreateBankAccount(int id, byte[] rowVersion, string name, string number, string abbr, Decimal initionalDeposit)
    {
      return new BankAccount()
      {
        Id = id,
        RowVersion = rowVersion,
        Name = name,
        Number = number,
        Abbr = abbr,
        InitionalDeposit = initionalDeposit
      };
    }
  }
}
