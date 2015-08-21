// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.aspnet_Membership_GetPassword1_Result
// Assembly: TradePlatform.MT4.Data, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FF714B79-462F-457E-9D98-705104E62A16
// Assembly location: T:\work\mql4\ForexSharp1\TradePlatform.MT4.SDK\TradePlatform.MT4.Engine\lib\TradePlatform.MT4.Data.dll

using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace TradePlatform.MT4.Data
{
  [EdmComplexType(Name = "aspnet_Membership_GetPassword1_Result", NamespaceName = "TradePlatformModel")]
  [DataContract(IsReference = true)]
  [Serializable]
  public class aspnet_Membership_GetPassword1_Result : ComplexObject
  {
    private string _Column1;
    private int? _Column2;

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
  }
}
