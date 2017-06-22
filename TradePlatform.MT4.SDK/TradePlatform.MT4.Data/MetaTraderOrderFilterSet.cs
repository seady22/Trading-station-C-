// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.MetaTraderOrderFilterSet
// Assembly: TradePlatform.MT4.Data, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FF714B79-462F-457E-9D98-705104E62A16
// Assembly location: T:\work\mql4\ForexSharp1\TradePlatform.MT4.SDK\TradePlatform.MT4.Engine\lib\TradePlatform.MT4.Data.dll

using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace TradePlatform.MT4.Data
{
  [EdmEntityType(Name = "MetaTraderOrderFilterSet", NamespaceName = "TradePlatformModel")]
  [DataContract(IsReference = true)]
  [Serializable]
  public class MetaTraderOrderFilterSet : EntityObject
  {
    private int _Id;
    private byte[] _RowVersion;
    private string _Name;
    private DateTime? _CloseTimeFrom;
    private DateTime? _CloseTimeTo;
    private DateTime? _OpenTimeFrom;
    private DateTime? _OpenTimeTo;
    private string _CommentContains;
    private string _CommentNotContains;
    private string _Symbol;
    private int? _MagicNumber;
    private string _Type;
    private bool? _IsClosed;

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

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public DateTime? CloseTimeFrom
    {
      get
      {
        return this._CloseTimeFrom;
      }
      set
      {
        this.ReportPropertyChanging("CloseTimeFrom");
        this._CloseTimeFrom = StructuralObject.SetValidValue(value, "CloseTimeFrom");
        this.ReportPropertyChanged("CloseTimeFrom");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public DateTime? CloseTimeTo
    {
      get
      {
        return this._CloseTimeTo;
      }
      set
      {
        this.ReportPropertyChanging("CloseTimeTo");
        this._CloseTimeTo = StructuralObject.SetValidValue(value, "CloseTimeTo");
        this.ReportPropertyChanged("CloseTimeTo");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public DateTime? OpenTimeFrom
    {
      get
      {
        return this._OpenTimeFrom;
      }
      set
      {
        this.ReportPropertyChanging("OpenTimeFrom");
        this._OpenTimeFrom = StructuralObject.SetValidValue(value, "OpenTimeFrom");
        this.ReportPropertyChanged("OpenTimeFrom");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public DateTime? OpenTimeTo
    {
      get
      {
        return this._OpenTimeTo;
      }
      set
      {
        this.ReportPropertyChanging("OpenTimeTo");
        this._OpenTimeTo = StructuralObject.SetValidValue(value, "OpenTimeTo");
        this.ReportPropertyChanged("OpenTimeTo");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public string CommentContains
    {
      get
      {
        return this._CommentContains;
      }
      set
      {
        this.ReportPropertyChanging("CommentContains");
        this._CommentContains = StructuralObject.SetValidValue(value, true, "CommentContains");
        this.ReportPropertyChanged("CommentContains");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public string CommentNotContains
    {
      get
      {
        return this._CommentNotContains;
      }
      set
      {
        this.ReportPropertyChanging("CommentNotContains");
        this._CommentNotContains = StructuralObject.SetValidValue(value, true, "CommentNotContains");
        this.ReportPropertyChanged("CommentNotContains");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public string Symbol
    {
      get
      {
        return this._Symbol;
      }
      set
      {
        this.ReportPropertyChanging("Symbol");
        this._Symbol = StructuralObject.SetValidValue(value, true, "Symbol");
        this.ReportPropertyChanged("Symbol");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public int? MagicNumber
    {
      get
      {
        return this._MagicNumber;
      }
      set
      {
        this.ReportPropertyChanging("MagicNumber");
        this._MagicNumber = StructuralObject.SetValidValue(value, "MagicNumber");
        this.ReportPropertyChanged("MagicNumber");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public string Type
    {
      get
      {
        return this._Type;
      }
      set
      {
        this.ReportPropertyChanging("Type");
        this._Type = StructuralObject.SetValidValue(value, true, "Type");
        this.ReportPropertyChanged("Type");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public bool? IsClosed
    {
      get
      {
        return this._IsClosed;
      }
      set
      {
        this.ReportPropertyChanging("IsClosed");
        this._IsClosed = StructuralObject.SetValidValue(value, "IsClosed");
        this.ReportPropertyChanged("IsClosed");
      }
    }

    public static MetaTraderOrderFilterSet CreateMetaTraderOrderFilterSet(int id, byte[] rowVersion, string name)
    {
      return new MetaTraderOrderFilterSet()
      {
        Id = id,
        RowVersion = rowVersion,
        Name = name
      };
    }
  }
}
