// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.ScheduledTaskParameter
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
  [DataContract(IsReference = true)]
  [EdmEntityType(Name = "ScheduledTaskParameter", NamespaceName = "TradePlatformModel")]
  [Serializable]
  public class ScheduledTaskParameter : EntityObject
  {
    private int _Id;
    private byte[] _RowVersion;
    private string _Name;
    private string _Value;
    private int _ScheduledTaskParameter_ScheduledTask;

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

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public string Value
    {
      get
      {
        return this._Value;
      }
      set
      {
        this.ReportPropertyChanging("Value");
        this._Value = StructuralObject.SetValidValue(value, false, "Value");
        this.ReportPropertyChanged("Value");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public int ScheduledTaskParameter_ScheduledTask
    {
      get
      {
        return this._ScheduledTaskParameter_ScheduledTask;
      }
      set
      {
        this.ReportPropertyChanging("ScheduledTaskParameter_ScheduledTask");
        this._ScheduledTaskParameter_ScheduledTask = StructuralObject.SetValidValue(value, "ScheduledTaskParameter_ScheduledTask");
        this.ReportPropertyChanged("ScheduledTaskParameter_ScheduledTask");
      }
    }

    [EdmRelationshipNavigationProperty("TradePlatformModel", "ScheduledTaskParameter_ScheduledTask", "ScheduledTask")]
    [DataMember]
    [XmlIgnore]
    [SoapIgnore]
    public ScheduledTask ScheduledTask
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ScheduledTask>("TradePlatformModel.ScheduledTaskParameter_ScheduledTask", "ScheduledTask").Value;
      }
      set
      {
        ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ScheduledTask>("TradePlatformModel.ScheduledTaskParameter_ScheduledTask", "ScheduledTask").Value = value;
      }
    }

    [Browsable(false)]
    [DataMember]
    public EntityReference<ScheduledTask> ScheduledTaskReference
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ScheduledTask>("TradePlatformModel.ScheduledTaskParameter_ScheduledTask", "ScheduledTask");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<ScheduledTask>("TradePlatformModel.ScheduledTaskParameter_ScheduledTask", "ScheduledTask", value);
      }
    }

    public static ScheduledTaskParameter CreateScheduledTaskParameter(int id, byte[] rowVersion, string name, string value, int scheduledTaskParameter_ScheduledTask)
    {
      return new ScheduledTaskParameter()
      {
        Id = id,
        RowVersion = rowVersion,
        Name = name,
        Value = value,
        ScheduledTaskParameter_ScheduledTask = scheduledTaskParameter_ScheduledTask
      };
    }
  }
}
