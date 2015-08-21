// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.BankAccountGroup
// Assembly: TradePlatform.MT4.Data, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FF714B79-462F-457E-9D98-705104E62A16
// Assembly location: T:\work\mql4\ForexSharp1\TradePlatform.MT4.SDK\TradePlatform.MT4.Engine\lib\TradePlatform.MT4.Data.dll

using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace TradePlatform.MT4.Data
{
  [DataContract(IsReference = true)]
  [EdmEntityType(Name = "BankAccountGroup", NamespaceName = "TradePlatformModel")]
  [Serializable]
  public class BankAccountGroup : EntityObject
  {
    private int _Id;
    private byte[] _RowVersion;
    private string _Name;

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

    [SoapIgnore]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "BankAccount_BankAccountGroup", "BankAccount")]
    [XmlIgnore]
    [DataMember]
    public EntityCollection<BankAccount> BankAccounts
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BankAccount>("TradePlatformModel.BankAccount_BankAccountGroup", "BankAccount");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BankAccount>("TradePlatformModel.BankAccount_BankAccountGroup", "BankAccount", value);
      }
    }

    public static BankAccountGroup CreateBankAccountGroup(int id, byte[] rowVersion, string name)
    {
      return new BankAccountGroup()
      {
        Id = id,
        RowVersion = rowVersion,
        Name = name
      };
    }
  }
}
