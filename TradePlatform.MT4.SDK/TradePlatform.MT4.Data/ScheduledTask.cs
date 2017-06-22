// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.ScheduledTask
// Assembly: TradePlatform.MT4.Data, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FF714B79-462F-457E-9D98-705104E62A16
// Assembly location: T:\work\mql4\ForexSharp1\TradePlatform.MT4.SDK\TradePlatform.MT4.Engine\lib\TradePlatform.MT4.Data.dll

using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace TradePlatform.MT4.Data
{
  [EdmEntityType(Name = "ScheduledTask", NamespaceName = "TradePlatformModel")]
  [DataContract(IsReference = true)]
  [Serializable]
  public class ScheduledTask : EntityObject
  {
    private int _Id;
    private byte[] _RowVersion;
    private string _Name;
    private string _Type;
    private int _Interval;
    private int _Executions;
    private bool _IsActive;
    private string _State;
    private string _LastMessage;
    private DateTime? _LastExecution;
    private string _LastError;

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

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public string Type
    {
      get
      {
        return this._Type;
      }
      set
      {
        this.ReportPropertyChanging("Type");
        this._Type = StructuralObject.SetValidValue(value, false, "Type");
        this.ReportPropertyChanged("Type");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public int Interval
    {
      get
      {
        return this._Interval;
      }
      set
      {
        this.ReportPropertyChanging("Interval");
        this._Interval = StructuralObject.SetValidValue(value, "Interval");
        this.ReportPropertyChanged("Interval");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public int Executions
    {
      get
      {
        return this._Executions;
      }
      set
      {
        this.ReportPropertyChanging("Executions");
        this._Executions = StructuralObject.SetValidValue(value, "Executions");
        this.ReportPropertyChanged("Executions");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public bool IsActive
    {
      get
      {
        return this._IsActive;
      }
      set
      {
        this.ReportPropertyChanging("IsActive");
        this._IsActive = StructuralObject.SetValidValue(value, "IsActive");
        this.ReportPropertyChanged("IsActive");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public string State
    {
      get
      {
        return this._State;
      }
      set
      {
        this.ReportPropertyChanging("State");
        this._State = StructuralObject.SetValidValue(value, false, "State");
        this.ReportPropertyChanged("State");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public string LastMessage
    {
      get
      {
        return this._LastMessage;
      }
      set
      {
        this.ReportPropertyChanging("LastMessage");
        this._LastMessage = StructuralObject.SetValidValue(value, true, "LastMessage");
        this.ReportPropertyChanged("LastMessage");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public DateTime? LastExecution
    {
      get
      {
        return this._LastExecution;
      }
      set
      {
        this.ReportPropertyChanging("LastExecution");
        this._LastExecution = StructuralObject.SetValidValue(value, "LastExecution");
        this.ReportPropertyChanged("LastExecution");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public string LastError
    {
      get
      {
        return this._LastError;
      }
      set
      {
        this.ReportPropertyChanging("LastError");
        this._LastError = StructuralObject.SetValidValue(value, true, "LastError");
        this.ReportPropertyChanged("LastError");
      }
    }

    [XmlIgnore]
    [DataMember]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "ScheduledTaskParameter_ScheduledTask", "ScheduledTaskParameter")]
    [SoapIgnore]
    public EntityCollection<ScheduledTaskParameter> ScheduledTaskParameters
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<ScheduledTaskParameter>("TradePlatformModel.ScheduledTaskParameter_ScheduledTask", "ScheduledTaskParameter");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<ScheduledTaskParameter>("TradePlatformModel.ScheduledTaskParameter_ScheduledTask", "ScheduledTaskParameter", value);
      }
    }

    public static ScheduledTask CreateScheduledTask(int id, byte[] rowVersion, string name, string type, int interval, int executions, bool isActive, string state)
    {
      return new ScheduledTask()
      {
        Id = id,
        RowVersion = rowVersion,
        Name = name,
        Type = type,
        Interval = interval,
        Executions = executions,
        IsActive = isActive,
        State = state
      };
    }
  }
}
