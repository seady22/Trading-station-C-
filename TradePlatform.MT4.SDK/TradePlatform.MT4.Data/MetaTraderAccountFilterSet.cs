// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.MetaTraderAccountFilterSet
// Assembly: TradePlatform.MT4.Data, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FF714B79-462F-457E-9D98-705104E62A16
// Assembly location: T:\work\mql4\ForexSharp1\TradePlatform.MT4.SDK\TradePlatform.MT4.Engine\lib\TradePlatform.MT4.Data.dll

using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace TradePlatform.MT4.Data
{
  [EdmEntityType(Name = "MetaTraderAccountFilterSet", NamespaceName = "TradePlatformModel")]
  [DataContract(IsReference = true)]
  [Serializable]
  public class MetaTraderAccountFilterSet : EntityObject
  {
    private int _Id;
    private byte[] _RowVersion;
    private string _Name;
    private bool? _IsDemo;
    private bool? _IsTesting;
    private bool? _IsOptimization;
    private string _AccountName;
    private int? _AccountNumber;
    private string _AccountCompany;

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

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public bool? IsDemo
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

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public bool? IsTesting
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

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public bool? IsOptimization
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
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public string AccountName
    {
      get
      {
        return this._AccountName;
      }
      set
      {
        this.ReportPropertyChanging("AccountName");
        this._AccountName = StructuralObject.SetValidValue(value, true, "AccountName");
        this.ReportPropertyChanged("AccountName");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public int? AccountNumber
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

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
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
        this._AccountCompany = StructuralObject.SetValidValue(value, true, "AccountCompany");
        this.ReportPropertyChanged("AccountCompany");
      }
    }

    public static MetaTraderAccountFilterSet CreateMetaTraderAccountFilterSet(int id, byte[] rowVersion, string name)
    {
      return new MetaTraderAccountFilterSet()
      {
        Id = id,
        RowVersion = rowVersion,
        Name = name
      };
    }
  }
}
