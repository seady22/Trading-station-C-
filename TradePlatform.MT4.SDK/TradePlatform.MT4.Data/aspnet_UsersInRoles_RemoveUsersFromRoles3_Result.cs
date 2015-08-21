// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.aspnet_UsersInRoles_RemoveUsersFromRoles3_Result
// Assembly: TradePlatform.MT4.Data, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FF714B79-462F-457E-9D98-705104E62A16
// Assembly location: T:\work\mql4\ForexSharp1\TradePlatform.MT4.SDK\TradePlatform.MT4.Engine\lib\TradePlatform.MT4.Data.dll

using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace TradePlatform.MT4.Data
{
  [DataContract(IsReference = true)]
  [EdmComplexType(Name = "aspnet_UsersInRoles_RemoveUsersFromRoles3_Result", NamespaceName = "TradePlatformModel")]
  [Serializable]
  public class aspnet_UsersInRoles_RemoveUsersFromRoles3_Result : ComplexObject
  {
    private string _Column1;
    private string _Name;

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public string Column1
    {
      get
      {
        return this._Column1;
      }
      set
      {
        this.ReportPropertyChanging("Column1");
        this._Column1 = StructuralObject.SetValidValue(value, false, "Column1");
        this.ReportPropertyChanged("Column1");
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

    public static aspnet_UsersInRoles_RemoveUsersFromRoles3_Result Createaspnet_UsersInRoles_RemoveUsersFromRoles3_Result(string column1, string name)
    {
      return new aspnet_UsersInRoles_RemoveUsersFromRoles3_Result()
      {
        Column1 = column1,
        Name = name
      };
    }
  }
}
