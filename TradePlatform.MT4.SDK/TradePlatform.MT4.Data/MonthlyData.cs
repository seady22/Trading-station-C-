// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.MonthlyData
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
  [EdmEntityType(Name = "MonthlyData", NamespaceName = "TradePlatformModel")]
  [DataContract(IsReference = true)]
  [Serializable]
  public class MonthlyData : EntityObject
  {
    private int _Id;
    private byte[] _RowVersion;
    private int _MonthlyData_MetaTraderAccount;

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
    public int MonthlyData_MetaTraderAccount
    {
      get
      {
        return this._MonthlyData_MetaTraderAccount;
      }
      set
      {
        this.ReportPropertyChanging("MonthlyData_MetaTraderAccount");
        this._MonthlyData_MetaTraderAccount = StructuralObject.SetValidValue(value, "MonthlyData_MetaTraderAccount");
        this.ReportPropertyChanged("MonthlyData_MetaTraderAccount");
      }
    }

    [EdmRelationshipNavigationProperty("TradePlatformModel", "MonthlyData_MetaTraderAccount", "MetaTraderAccount")]
    [XmlIgnore]
    [DataMember]
    [SoapIgnore]
    public MetaTraderAccount MetaTraderAccount
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<MetaTraderAccount>("TradePlatformModel.MonthlyData_MetaTraderAccount", "MetaTraderAccount").Value;
      }
      set
      {
        ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<MetaTraderAccount>("TradePlatformModel.MonthlyData_MetaTraderAccount", "MetaTraderAccount").Value = value;
      }
    }

    [DataMember]
    [Browsable(false)]
    public EntityReference<MetaTraderAccount> MetaTraderAccountReference
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<MetaTraderAccount>("TradePlatformModel.MonthlyData_MetaTraderAccount", "MetaTraderAccount");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<MetaTraderAccount>("TradePlatformModel.MonthlyData_MetaTraderAccount", "MetaTraderAccount", value);
      }
    }

    public static MonthlyData CreateMonthlyData(int id, byte[] rowVersion, int monthlyData_MetaTraderAccount)
    {
      return new MonthlyData()
      {
        Id = id,
        RowVersion = rowVersion,
        MonthlyData_MetaTraderAccount = monthlyData_MetaTraderAccount
      };
    }
  }
}
