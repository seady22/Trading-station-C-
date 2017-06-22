// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.ExpertSystem
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
  [EdmEntityType(Name = "ExpertSystem", NamespaceName = "TradePlatformModel")]
  [Serializable]
  public class ExpertSystem : EntityObject
  {
    private int _Id;
    private byte[] _RowVersion;
    private string _SystemVersion;
    private string _ExpertVersion;
    private string _ExpertName;
    private bool? _ExpertAllowAddones;
    private bool? _ModuleTacticsAutoEven;
    private bool? _ModuleTacticsAutoEvenAll;
    private int? _ModuleTacticsAutoEvenBars;
    private int? _ModuleTacticsAutoEvenPips;
    private int? _ModuleTacticsEvenStop;
    private bool? _ModuleTacticsAutoTrail;
    private bool? _ModuleTacticsAutoTrailAll;
    private int? _ModuleTacticsAutoTrailBars;
    private int? _ModuleTacticsAutoTrailPips;
    private int? _ModuleTacticsTrailStop;
    private bool? _ModuleTacticsAutoLockLoss;
    private bool? _ModuleTacticsAutoLockLossAll;
    private int? _ModuleTacticsAutoLockLossPips;
    private double? _ModuleTacticsLockLossRatio;
    private int? _ModuleTacticsLockLossStop;
    private bool? _ModuleTacticsAutoLock;
    private bool? _ModuleTacticsAutoLockAll;
    private int? _ModuleTacticsAutoLockPips;
    private int? _ModuleTacticsLockStop;
    private bool? _ModuleTacticsRelock;
    private double? _ModuleTacticsPartialLockRatio;
    private bool? _ModuleTacticsAutoMartin;
    private double? _ModuleTacticsMartinExponent;
    private int? _ModuleTacticsMartinKnees;
    private bool? _ModuleTacticsAutoBalance;
    private int? _ModuleTacticsBalancePips;
    private bool? _ModuleTacticsHalfTake;
    private int? _ModuleTacticsHalfTakeTake;
    private int? _ModuleTacticsHalfTakeStop;
    private bool? _ModuleTacticsSmartStop;
    private int? _ModuleTacticsSmartStopPips;
    private int? _ModuleTacticsSmartStopBars;
    private int? _ModuleTacticsSmartStopBreak;
    private int? _ModuleTacticsDispersPips;
    private int? _ModuleTacticsDispersBars;
    private int? _ModuleTacticsVolatile;
    private bool? _ModuleTraderUseStrategy;
    private bool? _ModuleTraderUseTrendFilter;
    private bool? _ModuleTraderUsePositionLock;
    private int? _ModuleTraderHoursStart;
    private int? _ModuleTraderHoursEnd;
    private int? _ModuleTraderLossInARow;
    private int? _ModuleTraderEquityLimit;
    private bool? _ModuleTraderOnlyInZones;
    private bool? _ModuleTraderTakeInZones;
    private bool? _AdnVisualTraderIsActive;
    private string _AdnVisualTraderOrderComment;
    private int? _ModuleMMStopLoss;
    private int? _ModuleMMTakeProfit;
    private int? _ModuleMMMinMarginLevel;
    private int? _ModuleMMMaxOpenOrders;
    private int? _ModuleMMMaxSpread;
    private double? _ModuleMMRiskFactor;
    private bool? _ModuleMMUseFixedLot;
    private double? _ModuleMMFixedLot;
    private bool? _ExtOperatorUseDefaultPoint;
    private double? _ExtOperatorPoint;
    private int? _ExtOperatorMagicNumber;
    private bool? _ExtOperatorAutoMagic;
    private int? _ExtOperatorRequoteTimes;
    private int? _ExtOperatorRequoteSleep;
    private int? _ExtOperatorSlippage;
    private bool? _ExtOperatorStealthMode;
    private bool? _ExtOperatorSetStopAfter;
    private int? _SignalIndicatorsEMASlow;
    private int? _SignalIndicatorsEMAFast;
    private int? _SignalIndicatorsRSIPeriod;
    private int? _SignalIndicatorsRSIUpper;
    private int? _SignalIndicatorsRSILower;
    private int? _SignalPASlippage;
    private bool? _AdnStealthUseBestPrice;
    private int? _ExtTimeTRM;
    private bool? _AdnReportingIsActive;
    private bool? _AdnLevelsIsActive;
    private bool? _AdnDiagnosticsUseDebug;
    private bool? _AdnDiagnosticsUseTrace;
    private bool? _AdnDiagnosticsUseLog;
    private bool? _AdnDiagnosticsUseNotify;
    private bool? _AdnDiagnosticsShowOrders;
    private bool? _AdnDiagnosticsShowInfo;
    private bool? _BridgeNETIsActive;
    private string _BridgeNETServer;
    private int? _BridgeNETPort;
    private string _WorkingSymbol;
    private int? _WorkingPeriod;
    private string _State;
    private DateTime _LastActivity;
    private string _LastExecutionError;
    private int _ExpertSystem_MetaTraderAccount;

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
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public string SystemVersion
    {
      get
      {
        return this._SystemVersion;
      }
      set
      {
        this.ReportPropertyChanging("SystemVersion");
        this._SystemVersion = StructuralObject.SetValidValue(value, true, "SystemVersion");
        this.ReportPropertyChanged("SystemVersion");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public string ExpertVersion
    {
      get
      {
        return this._ExpertVersion;
      }
      set
      {
        this.ReportPropertyChanging("ExpertVersion");
        this._ExpertVersion = StructuralObject.SetValidValue(value, true, "ExpertVersion");
        this.ReportPropertyChanged("ExpertVersion");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public string ExpertName
    {
      get
      {
        return this._ExpertName;
      }
      set
      {
        this.ReportPropertyChanging("ExpertName");
        this._ExpertName = StructuralObject.SetValidValue(value, true, "ExpertName");
        this.ReportPropertyChanged("ExpertName");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public bool? ExpertAllowAddones
    {
      get
      {
        return this._ExpertAllowAddones;
      }
      set
      {
        this.ReportPropertyChanging("ExpertAllowAddones");
        this._ExpertAllowAddones = StructuralObject.SetValidValue(value, "ExpertAllowAddones");
        this.ReportPropertyChanged("ExpertAllowAddones");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public bool? ModuleTacticsAutoEven
    {
      get
      {
        return this._ModuleTacticsAutoEven;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsAutoEven");
        this._ModuleTacticsAutoEven = StructuralObject.SetValidValue(value, "ModuleTacticsAutoEven");
        this.ReportPropertyChanged("ModuleTacticsAutoEven");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public bool? ModuleTacticsAutoEvenAll
    {
      get
      {
        return this._ModuleTacticsAutoEvenAll;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsAutoEvenAll");
        this._ModuleTacticsAutoEvenAll = StructuralObject.SetValidValue(value, "ModuleTacticsAutoEvenAll");
        this.ReportPropertyChanged("ModuleTacticsAutoEvenAll");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public int? ModuleTacticsAutoEvenBars
    {
      get
      {
        return this._ModuleTacticsAutoEvenBars;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsAutoEvenBars");
        this._ModuleTacticsAutoEvenBars = StructuralObject.SetValidValue(value, "ModuleTacticsAutoEvenBars");
        this.ReportPropertyChanged("ModuleTacticsAutoEvenBars");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public int? ModuleTacticsAutoEvenPips
    {
      get
      {
        return this._ModuleTacticsAutoEvenPips;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsAutoEvenPips");
        this._ModuleTacticsAutoEvenPips = StructuralObject.SetValidValue(value, "ModuleTacticsAutoEvenPips");
        this.ReportPropertyChanged("ModuleTacticsAutoEvenPips");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public int? ModuleTacticsEvenStop
    {
      get
      {
        return this._ModuleTacticsEvenStop;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsEvenStop");
        this._ModuleTacticsEvenStop = StructuralObject.SetValidValue(value, "ModuleTacticsEvenStop");
        this.ReportPropertyChanged("ModuleTacticsEvenStop");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public bool? ModuleTacticsAutoTrail
    {
      get
      {
        return this._ModuleTacticsAutoTrail;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsAutoTrail");
        this._ModuleTacticsAutoTrail = StructuralObject.SetValidValue(value, "ModuleTacticsAutoTrail");
        this.ReportPropertyChanged("ModuleTacticsAutoTrail");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public bool? ModuleTacticsAutoTrailAll
    {
      get
      {
        return this._ModuleTacticsAutoTrailAll;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsAutoTrailAll");
        this._ModuleTacticsAutoTrailAll = StructuralObject.SetValidValue(value, "ModuleTacticsAutoTrailAll");
        this.ReportPropertyChanged("ModuleTacticsAutoTrailAll");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public int? ModuleTacticsAutoTrailBars
    {
      get
      {
        return this._ModuleTacticsAutoTrailBars;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsAutoTrailBars");
        this._ModuleTacticsAutoTrailBars = StructuralObject.SetValidValue(value, "ModuleTacticsAutoTrailBars");
        this.ReportPropertyChanged("ModuleTacticsAutoTrailBars");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public int? ModuleTacticsAutoTrailPips
    {
      get
      {
        return this._ModuleTacticsAutoTrailPips;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsAutoTrailPips");
        this._ModuleTacticsAutoTrailPips = StructuralObject.SetValidValue(value, "ModuleTacticsAutoTrailPips");
        this.ReportPropertyChanged("ModuleTacticsAutoTrailPips");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public int? ModuleTacticsTrailStop
    {
      get
      {
        return this._ModuleTacticsTrailStop;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsTrailStop");
        this._ModuleTacticsTrailStop = StructuralObject.SetValidValue(value, "ModuleTacticsTrailStop");
        this.ReportPropertyChanged("ModuleTacticsTrailStop");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public bool? ModuleTacticsAutoLockLoss
    {
      get
      {
        return this._ModuleTacticsAutoLockLoss;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsAutoLockLoss");
        this._ModuleTacticsAutoLockLoss = StructuralObject.SetValidValue(value, "ModuleTacticsAutoLockLoss");
        this.ReportPropertyChanged("ModuleTacticsAutoLockLoss");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public bool? ModuleTacticsAutoLockLossAll
    {
      get
      {
        return this._ModuleTacticsAutoLockLossAll;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsAutoLockLossAll");
        this._ModuleTacticsAutoLockLossAll = StructuralObject.SetValidValue(value, "ModuleTacticsAutoLockLossAll");
        this.ReportPropertyChanged("ModuleTacticsAutoLockLossAll");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public int? ModuleTacticsAutoLockLossPips
    {
      get
      {
        return this._ModuleTacticsAutoLockLossPips;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsAutoLockLossPips");
        this._ModuleTacticsAutoLockLossPips = StructuralObject.SetValidValue(value, "ModuleTacticsAutoLockLossPips");
        this.ReportPropertyChanged("ModuleTacticsAutoLockLossPips");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public double? ModuleTacticsLockLossRatio
    {
      get
      {
        return this._ModuleTacticsLockLossRatio;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsLockLossRatio");
        this._ModuleTacticsLockLossRatio = StructuralObject.SetValidValue(value, "ModuleTacticsLockLossRatio");
        this.ReportPropertyChanged("ModuleTacticsLockLossRatio");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public int? ModuleTacticsLockLossStop
    {
      get
      {
        return this._ModuleTacticsLockLossStop;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsLockLossStop");
        this._ModuleTacticsLockLossStop = StructuralObject.SetValidValue(value, "ModuleTacticsLockLossStop");
        this.ReportPropertyChanged("ModuleTacticsLockLossStop");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public bool? ModuleTacticsAutoLock
    {
      get
      {
        return this._ModuleTacticsAutoLock;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsAutoLock");
        this._ModuleTacticsAutoLock = StructuralObject.SetValidValue(value, "ModuleTacticsAutoLock");
        this.ReportPropertyChanged("ModuleTacticsAutoLock");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public bool? ModuleTacticsAutoLockAll
    {
      get
      {
        return this._ModuleTacticsAutoLockAll;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsAutoLockAll");
        this._ModuleTacticsAutoLockAll = StructuralObject.SetValidValue(value, "ModuleTacticsAutoLockAll");
        this.ReportPropertyChanged("ModuleTacticsAutoLockAll");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public int? ModuleTacticsAutoLockPips
    {
      get
      {
        return this._ModuleTacticsAutoLockPips;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsAutoLockPips");
        this._ModuleTacticsAutoLockPips = StructuralObject.SetValidValue(value, "ModuleTacticsAutoLockPips");
        this.ReportPropertyChanged("ModuleTacticsAutoLockPips");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public int? ModuleTacticsLockStop
    {
      get
      {
        return this._ModuleTacticsLockStop;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsLockStop");
        this._ModuleTacticsLockStop = StructuralObject.SetValidValue(value, "ModuleTacticsLockStop");
        this.ReportPropertyChanged("ModuleTacticsLockStop");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public bool? ModuleTacticsRelock
    {
      get
      {
        return this._ModuleTacticsRelock;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsRelock");
        this._ModuleTacticsRelock = StructuralObject.SetValidValue(value, "ModuleTacticsRelock");
        this.ReportPropertyChanged("ModuleTacticsRelock");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public double? ModuleTacticsPartialLockRatio
    {
      get
      {
        return this._ModuleTacticsPartialLockRatio;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsPartialLockRatio");
        this._ModuleTacticsPartialLockRatio = StructuralObject.SetValidValue(value, "ModuleTacticsPartialLockRatio");
        this.ReportPropertyChanged("ModuleTacticsPartialLockRatio");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public bool? ModuleTacticsAutoMartin
    {
      get
      {
        return this._ModuleTacticsAutoMartin;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsAutoMartin");
        this._ModuleTacticsAutoMartin = StructuralObject.SetValidValue(value, "ModuleTacticsAutoMartin");
        this.ReportPropertyChanged("ModuleTacticsAutoMartin");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public double? ModuleTacticsMartinExponent
    {
      get
      {
        return this._ModuleTacticsMartinExponent;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsMartinExponent");
        this._ModuleTacticsMartinExponent = StructuralObject.SetValidValue(value, "ModuleTacticsMartinExponent");
        this.ReportPropertyChanged("ModuleTacticsMartinExponent");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public int? ModuleTacticsMartinKnees
    {
      get
      {
        return this._ModuleTacticsMartinKnees;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsMartinKnees");
        this._ModuleTacticsMartinKnees = StructuralObject.SetValidValue(value, "ModuleTacticsMartinKnees");
        this.ReportPropertyChanged("ModuleTacticsMartinKnees");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public bool? ModuleTacticsAutoBalance
    {
      get
      {
        return this._ModuleTacticsAutoBalance;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsAutoBalance");
        this._ModuleTacticsAutoBalance = StructuralObject.SetValidValue(value, "ModuleTacticsAutoBalance");
        this.ReportPropertyChanged("ModuleTacticsAutoBalance");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public int? ModuleTacticsBalancePips
    {
      get
      {
        return this._ModuleTacticsBalancePips;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsBalancePips");
        this._ModuleTacticsBalancePips = StructuralObject.SetValidValue(value, "ModuleTacticsBalancePips");
        this.ReportPropertyChanged("ModuleTacticsBalancePips");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public bool? ModuleTacticsHalfTake
    {
      get
      {
        return this._ModuleTacticsHalfTake;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsHalfTake");
        this._ModuleTacticsHalfTake = StructuralObject.SetValidValue(value, "ModuleTacticsHalfTake");
        this.ReportPropertyChanged("ModuleTacticsHalfTake");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public int? ModuleTacticsHalfTakeTake
    {
      get
      {
        return this._ModuleTacticsHalfTakeTake;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsHalfTakeTake");
        this._ModuleTacticsHalfTakeTake = StructuralObject.SetValidValue(value, "ModuleTacticsHalfTakeTake");
        this.ReportPropertyChanged("ModuleTacticsHalfTakeTake");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public int? ModuleTacticsHalfTakeStop
    {
      get
      {
        return this._ModuleTacticsHalfTakeStop;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsHalfTakeStop");
        this._ModuleTacticsHalfTakeStop = StructuralObject.SetValidValue(value, "ModuleTacticsHalfTakeStop");
        this.ReportPropertyChanged("ModuleTacticsHalfTakeStop");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public bool? ModuleTacticsSmartStop
    {
      get
      {
        return this._ModuleTacticsSmartStop;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsSmartStop");
        this._ModuleTacticsSmartStop = StructuralObject.SetValidValue(value, "ModuleTacticsSmartStop");
        this.ReportPropertyChanged("ModuleTacticsSmartStop");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public int? ModuleTacticsSmartStopPips
    {
      get
      {
        return this._ModuleTacticsSmartStopPips;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsSmartStopPips");
        this._ModuleTacticsSmartStopPips = StructuralObject.SetValidValue(value, "ModuleTacticsSmartStopPips");
        this.ReportPropertyChanged("ModuleTacticsSmartStopPips");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public int? ModuleTacticsSmartStopBars
    {
      get
      {
        return this._ModuleTacticsSmartStopBars;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsSmartStopBars");
        this._ModuleTacticsSmartStopBars = StructuralObject.SetValidValue(value, "ModuleTacticsSmartStopBars");
        this.ReportPropertyChanged("ModuleTacticsSmartStopBars");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public int? ModuleTacticsSmartStopBreak
    {
      get
      {
        return this._ModuleTacticsSmartStopBreak;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsSmartStopBreak");
        this._ModuleTacticsSmartStopBreak = StructuralObject.SetValidValue(value, "ModuleTacticsSmartStopBreak");
        this.ReportPropertyChanged("ModuleTacticsSmartStopBreak");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public int? ModuleTacticsDispersPips
    {
      get
      {
        return this._ModuleTacticsDispersPips;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsDispersPips");
        this._ModuleTacticsDispersPips = StructuralObject.SetValidValue(value, "ModuleTacticsDispersPips");
        this.ReportPropertyChanged("ModuleTacticsDispersPips");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public int? ModuleTacticsDispersBars
    {
      get
      {
        return this._ModuleTacticsDispersBars;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsDispersBars");
        this._ModuleTacticsDispersBars = StructuralObject.SetValidValue(value, "ModuleTacticsDispersBars");
        this.ReportPropertyChanged("ModuleTacticsDispersBars");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public int? ModuleTacticsVolatile
    {
      get
      {
        return this._ModuleTacticsVolatile;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTacticsVolatile");
        this._ModuleTacticsVolatile = StructuralObject.SetValidValue(value, "ModuleTacticsVolatile");
        this.ReportPropertyChanged("ModuleTacticsVolatile");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public bool? ModuleTraderUseStrategy
    {
      get
      {
        return this._ModuleTraderUseStrategy;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTraderUseStrategy");
        this._ModuleTraderUseStrategy = StructuralObject.SetValidValue(value, "ModuleTraderUseStrategy");
        this.ReportPropertyChanged("ModuleTraderUseStrategy");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public bool? ModuleTraderUseTrendFilter
    {
      get
      {
        return this._ModuleTraderUseTrendFilter;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTraderUseTrendFilter");
        this._ModuleTraderUseTrendFilter = StructuralObject.SetValidValue(value, "ModuleTraderUseTrendFilter");
        this.ReportPropertyChanged("ModuleTraderUseTrendFilter");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public bool? ModuleTraderUsePositionLock
    {
      get
      {
        return this._ModuleTraderUsePositionLock;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTraderUsePositionLock");
        this._ModuleTraderUsePositionLock = StructuralObject.SetValidValue(value, "ModuleTraderUsePositionLock");
        this.ReportPropertyChanged("ModuleTraderUsePositionLock");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public int? ModuleTraderHoursStart
    {
      get
      {
        return this._ModuleTraderHoursStart;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTraderHoursStart");
        this._ModuleTraderHoursStart = StructuralObject.SetValidValue(value, "ModuleTraderHoursStart");
        this.ReportPropertyChanged("ModuleTraderHoursStart");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public int? ModuleTraderHoursEnd
    {
      get
      {
        return this._ModuleTraderHoursEnd;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTraderHoursEnd");
        this._ModuleTraderHoursEnd = StructuralObject.SetValidValue(value, "ModuleTraderHoursEnd");
        this.ReportPropertyChanged("ModuleTraderHoursEnd");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public int? ModuleTraderLossInARow
    {
      get
      {
        return this._ModuleTraderLossInARow;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTraderLossInARow");
        this._ModuleTraderLossInARow = StructuralObject.SetValidValue(value, "ModuleTraderLossInARow");
        this.ReportPropertyChanged("ModuleTraderLossInARow");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public int? ModuleTraderEquityLimit
    {
      get
      {
        return this._ModuleTraderEquityLimit;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTraderEquityLimit");
        this._ModuleTraderEquityLimit = StructuralObject.SetValidValue(value, "ModuleTraderEquityLimit");
        this.ReportPropertyChanged("ModuleTraderEquityLimit");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public bool? ModuleTraderOnlyInZones
    {
      get
      {
        return this._ModuleTraderOnlyInZones;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTraderOnlyInZones");
        this._ModuleTraderOnlyInZones = StructuralObject.SetValidValue(value, "ModuleTraderOnlyInZones");
        this.ReportPropertyChanged("ModuleTraderOnlyInZones");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public bool? ModuleTraderTakeInZones
    {
      get
      {
        return this._ModuleTraderTakeInZones;
      }
      set
      {
        this.ReportPropertyChanging("ModuleTraderTakeInZones");
        this._ModuleTraderTakeInZones = StructuralObject.SetValidValue(value, "ModuleTraderTakeInZones");
        this.ReportPropertyChanged("ModuleTraderTakeInZones");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public bool? AdnVisualTraderIsActive
    {
      get
      {
        return this._AdnVisualTraderIsActive;
      }
      set
      {
        this.ReportPropertyChanging("AdnVisualTraderIsActive");
        this._AdnVisualTraderIsActive = StructuralObject.SetValidValue(value, "AdnVisualTraderIsActive");
        this.ReportPropertyChanged("AdnVisualTraderIsActive");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public string AdnVisualTraderOrderComment
    {
      get
      {
        return this._AdnVisualTraderOrderComment;
      }
      set
      {
        this.ReportPropertyChanging("AdnVisualTraderOrderComment");
        this._AdnVisualTraderOrderComment = StructuralObject.SetValidValue(value, true, "AdnVisualTraderOrderComment");
        this.ReportPropertyChanged("AdnVisualTraderOrderComment");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public int? ModuleMMStopLoss
    {
      get
      {
        return this._ModuleMMStopLoss;
      }
      set
      {
        this.ReportPropertyChanging("ModuleMMStopLoss");
        this._ModuleMMStopLoss = StructuralObject.SetValidValue(value, "ModuleMMStopLoss");
        this.ReportPropertyChanged("ModuleMMStopLoss");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public int? ModuleMMTakeProfit
    {
      get
      {
        return this._ModuleMMTakeProfit;
      }
      set
      {
        this.ReportPropertyChanging("ModuleMMTakeProfit");
        this._ModuleMMTakeProfit = StructuralObject.SetValidValue(value, "ModuleMMTakeProfit");
        this.ReportPropertyChanged("ModuleMMTakeProfit");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public int? ModuleMMMinMarginLevel
    {
      get
      {
        return this._ModuleMMMinMarginLevel;
      }
      set
      {
        this.ReportPropertyChanging("ModuleMMMinMarginLevel");
        this._ModuleMMMinMarginLevel = StructuralObject.SetValidValue(value, "ModuleMMMinMarginLevel");
        this.ReportPropertyChanged("ModuleMMMinMarginLevel");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public int? ModuleMMMaxOpenOrders
    {
      get
      {
        return this._ModuleMMMaxOpenOrders;
      }
      set
      {
        this.ReportPropertyChanging("ModuleMMMaxOpenOrders");
        this._ModuleMMMaxOpenOrders = StructuralObject.SetValidValue(value, "ModuleMMMaxOpenOrders");
        this.ReportPropertyChanged("ModuleMMMaxOpenOrders");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public int? ModuleMMMaxSpread
    {
      get
      {
        return this._ModuleMMMaxSpread;
      }
      set
      {
        this.ReportPropertyChanging("ModuleMMMaxSpread");
        this._ModuleMMMaxSpread = StructuralObject.SetValidValue(value, "ModuleMMMaxSpread");
        this.ReportPropertyChanged("ModuleMMMaxSpread");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public double? ModuleMMRiskFactor
    {
      get
      {
        return this._ModuleMMRiskFactor;
      }
      set
      {
        this.ReportPropertyChanging("ModuleMMRiskFactor");
        this._ModuleMMRiskFactor = StructuralObject.SetValidValue(value, "ModuleMMRiskFactor");
        this.ReportPropertyChanged("ModuleMMRiskFactor");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public bool? ModuleMMUseFixedLot
    {
      get
      {
        return this._ModuleMMUseFixedLot;
      }
      set
      {
        this.ReportPropertyChanging("ModuleMMUseFixedLot");
        this._ModuleMMUseFixedLot = StructuralObject.SetValidValue(value, "ModuleMMUseFixedLot");
        this.ReportPropertyChanged("ModuleMMUseFixedLot");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public double? ModuleMMFixedLot
    {
      get
      {
        return this._ModuleMMFixedLot;
      }
      set
      {
        this.ReportPropertyChanging("ModuleMMFixedLot");
        this._ModuleMMFixedLot = StructuralObject.SetValidValue(value, "ModuleMMFixedLot");
        this.ReportPropertyChanged("ModuleMMFixedLot");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public bool? ExtOperatorUseDefaultPoint
    {
      get
      {
        return this._ExtOperatorUseDefaultPoint;
      }
      set
      {
        this.ReportPropertyChanging("ExtOperatorUseDefaultPoint");
        this._ExtOperatorUseDefaultPoint = StructuralObject.SetValidValue(value, "ExtOperatorUseDefaultPoint");
        this.ReportPropertyChanged("ExtOperatorUseDefaultPoint");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public double? ExtOperatorPoint
    {
      get
      {
        return this._ExtOperatorPoint;
      }
      set
      {
        this.ReportPropertyChanging("ExtOperatorPoint");
        this._ExtOperatorPoint = StructuralObject.SetValidValue(value, "ExtOperatorPoint");
        this.ReportPropertyChanged("ExtOperatorPoint");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public int? ExtOperatorMagicNumber
    {
      get
      {
        return this._ExtOperatorMagicNumber;
      }
      set
      {
        this.ReportPropertyChanging("ExtOperatorMagicNumber");
        this._ExtOperatorMagicNumber = StructuralObject.SetValidValue(value, "ExtOperatorMagicNumber");
        this.ReportPropertyChanged("ExtOperatorMagicNumber");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public bool? ExtOperatorAutoMagic
    {
      get
      {
        return this._ExtOperatorAutoMagic;
      }
      set
      {
        this.ReportPropertyChanging("ExtOperatorAutoMagic");
        this._ExtOperatorAutoMagic = StructuralObject.SetValidValue(value, "ExtOperatorAutoMagic");
        this.ReportPropertyChanged("ExtOperatorAutoMagic");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public int? ExtOperatorRequoteTimes
    {
      get
      {
        return this._ExtOperatorRequoteTimes;
      }
      set
      {
        this.ReportPropertyChanging("ExtOperatorRequoteTimes");
        this._ExtOperatorRequoteTimes = StructuralObject.SetValidValue(value, "ExtOperatorRequoteTimes");
        this.ReportPropertyChanged("ExtOperatorRequoteTimes");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public int? ExtOperatorRequoteSleep
    {
      get
      {
        return this._ExtOperatorRequoteSleep;
      }
      set
      {
        this.ReportPropertyChanging("ExtOperatorRequoteSleep");
        this._ExtOperatorRequoteSleep = StructuralObject.SetValidValue(value, "ExtOperatorRequoteSleep");
        this.ReportPropertyChanged("ExtOperatorRequoteSleep");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public int? ExtOperatorSlippage
    {
      get
      {
        return this._ExtOperatorSlippage;
      }
      set
      {
        this.ReportPropertyChanging("ExtOperatorSlippage");
        this._ExtOperatorSlippage = StructuralObject.SetValidValue(value, "ExtOperatorSlippage");
        this.ReportPropertyChanged("ExtOperatorSlippage");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public bool? ExtOperatorStealthMode
    {
      get
      {
        return this._ExtOperatorStealthMode;
      }
      set
      {
        this.ReportPropertyChanging("ExtOperatorStealthMode");
        this._ExtOperatorStealthMode = StructuralObject.SetValidValue(value, "ExtOperatorStealthMode");
        this.ReportPropertyChanged("ExtOperatorStealthMode");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public bool? ExtOperatorSetStopAfter
    {
      get
      {
        return this._ExtOperatorSetStopAfter;
      }
      set
      {
        this.ReportPropertyChanging("ExtOperatorSetStopAfter");
        this._ExtOperatorSetStopAfter = StructuralObject.SetValidValue(value, "ExtOperatorSetStopAfter");
        this.ReportPropertyChanged("ExtOperatorSetStopAfter");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public int? SignalIndicatorsEMASlow
    {
      get
      {
        return this._SignalIndicatorsEMASlow;
      }
      set
      {
        this.ReportPropertyChanging("SignalIndicatorsEMASlow");
        this._SignalIndicatorsEMASlow = StructuralObject.SetValidValue(value, "SignalIndicatorsEMASlow");
        this.ReportPropertyChanged("SignalIndicatorsEMASlow");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public int? SignalIndicatorsEMAFast
    {
      get
      {
        return this._SignalIndicatorsEMAFast;
      }
      set
      {
        this.ReportPropertyChanging("SignalIndicatorsEMAFast");
        this._SignalIndicatorsEMAFast = StructuralObject.SetValidValue(value, "SignalIndicatorsEMAFast");
        this.ReportPropertyChanged("SignalIndicatorsEMAFast");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public int? SignalIndicatorsRSIPeriod
    {
      get
      {
        return this._SignalIndicatorsRSIPeriod;
      }
      set
      {
        this.ReportPropertyChanging("SignalIndicatorsRSIPeriod");
        this._SignalIndicatorsRSIPeriod = StructuralObject.SetValidValue(value, "SignalIndicatorsRSIPeriod");
        this.ReportPropertyChanged("SignalIndicatorsRSIPeriod");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public int? SignalIndicatorsRSIUpper
    {
      get
      {
        return this._SignalIndicatorsRSIUpper;
      }
      set
      {
        this.ReportPropertyChanging("SignalIndicatorsRSIUpper");
        this._SignalIndicatorsRSIUpper = StructuralObject.SetValidValue(value, "SignalIndicatorsRSIUpper");
        this.ReportPropertyChanged("SignalIndicatorsRSIUpper");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public int? SignalIndicatorsRSILower
    {
      get
      {
        return this._SignalIndicatorsRSILower;
      }
      set
      {
        this.ReportPropertyChanging("SignalIndicatorsRSILower");
        this._SignalIndicatorsRSILower = StructuralObject.SetValidValue(value, "SignalIndicatorsRSILower");
        this.ReportPropertyChanged("SignalIndicatorsRSILower");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public int? SignalPASlippage
    {
      get
      {
        return this._SignalPASlippage;
      }
      set
      {
        this.ReportPropertyChanging("SignalPASlippage");
        this._SignalPASlippage = StructuralObject.SetValidValue(value, "SignalPASlippage");
        this.ReportPropertyChanged("SignalPASlippage");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public bool? AdnStealthUseBestPrice
    {
      get
      {
        return this._AdnStealthUseBestPrice;
      }
      set
      {
        this.ReportPropertyChanging("AdnStealthUseBestPrice");
        this._AdnStealthUseBestPrice = StructuralObject.SetValidValue(value, "AdnStealthUseBestPrice");
        this.ReportPropertyChanged("AdnStealthUseBestPrice");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public int? ExtTimeTRM
    {
      get
      {
        return this._ExtTimeTRM;
      }
      set
      {
        this.ReportPropertyChanging("ExtTimeTRM");
        this._ExtTimeTRM = StructuralObject.SetValidValue(value, "ExtTimeTRM");
        this.ReportPropertyChanged("ExtTimeTRM");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public bool? AdnReportingIsActive
    {
      get
      {
        return this._AdnReportingIsActive;
      }
      set
      {
        this.ReportPropertyChanging("AdnReportingIsActive");
        this._AdnReportingIsActive = StructuralObject.SetValidValue(value, "AdnReportingIsActive");
        this.ReportPropertyChanged("AdnReportingIsActive");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public bool? AdnLevelsIsActive
    {
      get
      {
        return this._AdnLevelsIsActive;
      }
      set
      {
        this.ReportPropertyChanging("AdnLevelsIsActive");
        this._AdnLevelsIsActive = StructuralObject.SetValidValue(value, "AdnLevelsIsActive");
        this.ReportPropertyChanged("AdnLevelsIsActive");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public bool? AdnDiagnosticsUseDebug
    {
      get
      {
        return this._AdnDiagnosticsUseDebug;
      }
      set
      {
        this.ReportPropertyChanging("AdnDiagnosticsUseDebug");
        this._AdnDiagnosticsUseDebug = StructuralObject.SetValidValue(value, "AdnDiagnosticsUseDebug");
        this.ReportPropertyChanged("AdnDiagnosticsUseDebug");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public bool? AdnDiagnosticsUseTrace
    {
      get
      {
        return this._AdnDiagnosticsUseTrace;
      }
      set
      {
        this.ReportPropertyChanging("AdnDiagnosticsUseTrace");
        this._AdnDiagnosticsUseTrace = StructuralObject.SetValidValue(value, "AdnDiagnosticsUseTrace");
        this.ReportPropertyChanged("AdnDiagnosticsUseTrace");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public bool? AdnDiagnosticsUseLog
    {
      get
      {
        return this._AdnDiagnosticsUseLog;
      }
      set
      {
        this.ReportPropertyChanging("AdnDiagnosticsUseLog");
        this._AdnDiagnosticsUseLog = StructuralObject.SetValidValue(value, "AdnDiagnosticsUseLog");
        this.ReportPropertyChanged("AdnDiagnosticsUseLog");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public bool? AdnDiagnosticsUseNotify
    {
      get
      {
        return this._AdnDiagnosticsUseNotify;
      }
      set
      {
        this.ReportPropertyChanging("AdnDiagnosticsUseNotify");
        this._AdnDiagnosticsUseNotify = StructuralObject.SetValidValue(value, "AdnDiagnosticsUseNotify");
        this.ReportPropertyChanged("AdnDiagnosticsUseNotify");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public bool? AdnDiagnosticsShowOrders
    {
      get
      {
        return this._AdnDiagnosticsShowOrders;
      }
      set
      {
        this.ReportPropertyChanging("AdnDiagnosticsShowOrders");
        this._AdnDiagnosticsShowOrders = StructuralObject.SetValidValue(value, "AdnDiagnosticsShowOrders");
        this.ReportPropertyChanged("AdnDiagnosticsShowOrders");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public bool? AdnDiagnosticsShowInfo
    {
      get
      {
        return this._AdnDiagnosticsShowInfo;
      }
      set
      {
        this.ReportPropertyChanging("AdnDiagnosticsShowInfo");
        this._AdnDiagnosticsShowInfo = StructuralObject.SetValidValue(value, "AdnDiagnosticsShowInfo");
        this.ReportPropertyChanged("AdnDiagnosticsShowInfo");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public bool? BridgeNETIsActive
    {
      get
      {
        return this._BridgeNETIsActive;
      }
      set
      {
        this.ReportPropertyChanging("BridgeNETIsActive");
        this._BridgeNETIsActive = StructuralObject.SetValidValue(value, "BridgeNETIsActive");
        this.ReportPropertyChanged("BridgeNETIsActive");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public string BridgeNETServer
    {
      get
      {
        return this._BridgeNETServer;
      }
      set
      {
        this.ReportPropertyChanging("BridgeNETServer");
        this._BridgeNETServer = StructuralObject.SetValidValue(value, true, "BridgeNETServer");
        this.ReportPropertyChanged("BridgeNETServer");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public int? BridgeNETPort
    {
      get
      {
        return this._BridgeNETPort;
      }
      set
      {
        this.ReportPropertyChanging("BridgeNETPort");
        this._BridgeNETPort = StructuralObject.SetValidValue(value, "BridgeNETPort");
        this.ReportPropertyChanged("BridgeNETPort");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public string WorkingSymbol
    {
      get
      {
        return this._WorkingSymbol;
      }
      set
      {
        this.ReportPropertyChanging("WorkingSymbol");
        this._WorkingSymbol = StructuralObject.SetValidValue(value, true, "WorkingSymbol");
        this.ReportPropertyChanged("WorkingSymbol");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public int? WorkingPeriod
    {
      get
      {
        return this._WorkingPeriod;
      }
      set
      {
        this.ReportPropertyChanging("WorkingPeriod");
        this._WorkingPeriod = StructuralObject.SetValidValue(value, "WorkingPeriod");
        this.ReportPropertyChanged("WorkingPeriod");
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

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public DateTime LastActivity
    {
      get
      {
        return this._LastActivity;
      }
      set
      {
        this.ReportPropertyChanging("LastActivity");
        this._LastActivity = StructuralObject.SetValidValue(value, "LastActivity");
        this.ReportPropertyChanged("LastActivity");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public string LastExecutionError
    {
      get
      {
        return this._LastExecutionError;
      }
      set
      {
        this.ReportPropertyChanging("LastExecutionError");
        this._LastExecutionError = StructuralObject.SetValidValue(value, true, "LastExecutionError");
        this.ReportPropertyChanged("LastExecutionError");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public int ExpertSystem_MetaTraderAccount
    {
      get
      {
        return this._ExpertSystem_MetaTraderAccount;
      }
      set
      {
        this.ReportPropertyChanging("ExpertSystem_MetaTraderAccount");
        this._ExpertSystem_MetaTraderAccount = StructuralObject.SetValidValue(value, "ExpertSystem_MetaTraderAccount");
        this.ReportPropertyChanged("ExpertSystem_MetaTraderAccount");
      }
    }

    [XmlIgnore]
    [DataMember]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "ExpertSystem_MetaTraderAccount", "MetaTraderAccount")]
    [SoapIgnore]
    public MetaTraderAccount MetaTraderAccount
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<MetaTraderAccount>("TradePlatformModel.ExpertSystem_MetaTraderAccount", "MetaTraderAccount").Value;
      }
      set
      {
        ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<MetaTraderAccount>("TradePlatformModel.ExpertSystem_MetaTraderAccount", "MetaTraderAccount").Value = value;
      }
    }

    [DataMember]
    [Browsable(false)]
    public EntityReference<MetaTraderAccount> MetaTraderAccountReference
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<MetaTraderAccount>("TradePlatformModel.ExpertSystem_MetaTraderAccount", "MetaTraderAccount");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<MetaTraderAccount>("TradePlatformModel.ExpertSystem_MetaTraderAccount", "MetaTraderAccount", value);
      }
    }

    [SoapIgnore]
    [DataMember]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "ExpertSystem_MetaTraderOrder", "MetaTraderOrder")]
    [XmlIgnore]
    public EntityCollection<MetaTraderOrder> MetaTraderOrders
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<MetaTraderOrder>("TradePlatformModel.ExpertSystem_MetaTraderOrder", "MetaTraderOrder");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<MetaTraderOrder>("TradePlatformModel.ExpertSystem_MetaTraderOrder", "MetaTraderOrder", value);
      }
    }

    public static ExpertSystem CreateExpertSystem(int id, byte[] rowVersion, string state, DateTime lastActivity, int expertSystem_MetaTraderAccount)
    {
      return new ExpertSystem()
      {
        Id = id,
        RowVersion = rowVersion,
        State = state,
        LastActivity = lastActivity,
        ExpertSystem_MetaTraderAccount = expertSystem_MetaTraderAccount
      };
    }
  }
}
