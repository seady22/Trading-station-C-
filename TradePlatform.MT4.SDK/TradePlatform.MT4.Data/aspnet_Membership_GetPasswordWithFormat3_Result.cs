// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.aspnet_Membership_GetPasswordWithFormat3_Result
// Assembly: TradePlatform.MT4.Data, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FF714B79-462F-457E-9D98-705104E62A16
// Assembly location: T:\work\mql4\ForexSharp1\TradePlatform.MT4.SDK\TradePlatform.MT4.Engine\lib\TradePlatform.MT4.Data.dll

using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace TradePlatform.MT4.Data
{
  [DataContract(IsReference = true)]
  [EdmComplexType(Name = "aspnet_Membership_GetPasswordWithFormat3_Result", NamespaceName = "TradePlatformModel")]
  [Serializable]
  public class aspnet_Membership_GetPasswordWithFormat3_Result : ComplexObject
  {
    private string _Column1;
    private int? _Column2;
    private string _Column3;
    private int? _Column4;
    private int? _Column5;
    private bool? _Column6;
    private DateTime? _Column7;
    private DateTime? _Column8;

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public string Column1
    {
      get
      {
        return this._Column1;
      }
      set
      {
        this.ReportPropertyChanging("Column1");
        this._Column1 = StructuralObject.SetValidValue(value, true, "Column1");
        this.ReportPropertyChanged("Column1");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public int? Column2
    {
      get
      {
        return this._Column2;
      }
      set
      {
        this.ReportPropertyChanging("Column2");
        this._Column2 = StructuralObject.SetValidValue(value, "Column2");
        this.ReportPropertyChanged("Column2");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public string Column3
    {
      get
      {
        return this._Column3;
      }
      set
      {
        this.ReportPropertyChanging("Column3");
        this._Column3 = StructuralObject.SetValidValue(value, true, "Column3");
        this.ReportPropertyChanged("Column3");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public int? Column4
    {
      get
      {
        return this._Column4;
      }
      set
      {
        this.ReportPropertyChanging("Column4");
        this._Column4 = StructuralObject.SetValidValue(value, "Column4");
        this.ReportPropertyChanged("Column4");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public int? Column5
    {
      get
      {
        return this._Column5;
      }
      set
      {
        this.ReportPropertyChanging("Column5");
        this._Column5 = StructuralObject.SetValidValue(value, "Column5");
        this.ReportPropertyChanged("Column5");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public bool? Column6
    {
      get
      {
        return this._Column6;
      }
      set
      {
        this.ReportPropertyChanging("Column6");
        this._Column6 = StructuralObject.SetValidValue(value, "Column6");
        this.ReportPropertyChanged("Column6");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public DateTime? Column7
    {
      get
      {
        return this._Column7;
      }
      set
      {
        this.ReportPropertyChanging("Column7");
        this._Column7 = StructuralObject.SetValidValue(value, "Column7");
        this.ReportPropertyChanged("Column7");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public DateTime? Column8
    {
      get
      {
        return this._Column8;
      }
      set
      {
        this.ReportPropertyChanging("Column8");
        this._Column8 = StructuralObject.SetValidValue(value, "Column8");
        this.ReportPropertyChanged("Column8");
      }
    }
  }
}
