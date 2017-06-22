// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.aspnet_Profile_GetProperties2_Result
// Assembly: TradePlatform.MT4.Data, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FF714B79-462F-457E-9D98-705104E62A16
// Assembly location: T:\work\mql4\ForexSharp1\TradePlatform.MT4.SDK\TradePlatform.MT4.Engine\lib\TradePlatform.MT4.Data.dll

using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace TradePlatform.MT4.Data
{
  [DataContract(IsReference = true)]
  [EdmComplexType(Name = "aspnet_Profile_GetProperties2_Result", NamespaceName = "TradePlatformModel")]
  [Serializable]
  public class aspnet_Profile_GetProperties2_Result : ComplexObject
  {
    private string _PropertyNames;
    private string _PropertyValuesString;
    private byte[] _PropertyValuesBinary;

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public string PropertyNames
    {
      get
      {
        return this._PropertyNames;
      }
      set
      {
        this.ReportPropertyChanging("PropertyNames");
        this._PropertyNames = StructuralObject.SetValidValue(value, false, "PropertyNames");
        this.ReportPropertyChanged("PropertyNames");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public string PropertyValuesString
    {
      get
      {
        return this._PropertyValuesString;
      }
      set
      {
        this.ReportPropertyChanging("PropertyValuesString");
        this._PropertyValuesString = StructuralObject.SetValidValue(value, false, "PropertyValuesString");
        this.ReportPropertyChanged("PropertyValuesString");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public byte[] PropertyValuesBinary
    {
      get
      {
        return StructuralObject.GetValidValue(this._PropertyValuesBinary);
      }
      set
      {
        this.ReportPropertyChanging("PropertyValuesBinary");
        this._PropertyValuesBinary = StructuralObject.SetValidValue(value, false, "PropertyValuesBinary");
        this.ReportPropertyChanged("PropertyValuesBinary");
      }
    }

    public static aspnet_Profile_GetProperties2_Result Createaspnet_Profile_GetProperties2_Result(string propertyNames, string propertyValuesString, byte[] propertyValuesBinary)
    {
      return new aspnet_Profile_GetProperties2_Result()
      {
        PropertyNames = propertyNames,
        PropertyValuesString = propertyValuesString,
        PropertyValuesBinary = propertyValuesBinary
      };
    }
  }
}
