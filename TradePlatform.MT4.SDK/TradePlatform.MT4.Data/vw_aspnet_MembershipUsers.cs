// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.vw_aspnet_MembershipUsers
// Assembly: TradePlatform.MT4.Data, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FF714B79-462F-457E-9D98-705104E62A16
// Assembly location: T:\work\mql4\ForexSharp1\TradePlatform.MT4.SDK\TradePlatform.MT4.Engine\lib\TradePlatform.MT4.Data.dll

using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace TradePlatform.MT4.Data
{
  [EdmEntityType(Name = "vw_aspnet_MembershipUsers", NamespaceName = "TradePlatformModel")]
  [DataContract(IsReference = true)]
  [Serializable]
  public class vw_aspnet_MembershipUsers : EntityObject
  {
    private Guid _UserId;
    private int _PasswordFormat;
    private string _MobilePIN;
    private string _Email;
    private string _LoweredEmail;
    private string _PasswordQuestion;
    private string _PasswordAnswer;
    private bool _IsApproved;
    private bool _IsLockedOut;
    private DateTime _CreateDate;
    private DateTime _LastLoginDate;
    private DateTime _LastPasswordChangedDate;
    private DateTime _LastLockoutDate;
    private int _FailedPasswordAttemptCount;
    private DateTime _FailedPasswordAttemptWindowStart;
    private int _FailedPasswordAnswerAttemptCount;
    private DateTime _FailedPasswordAnswerAttemptWindowStart;
    private string _Comment;
    private Guid _ApplicationId;
    private string _UserName;
    private string _MobileAlias;
    private bool _IsAnonymous;
    private DateTime _LastActivityDate;

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    public Guid UserId
    {
      get
      {
        return this._UserId;
      }
      set
      {
        if (!(this._UserId != value))
          return;
        this.ReportPropertyChanging("UserId");
        this._UserId = StructuralObject.SetValidValue(value, "UserId");
        this.ReportPropertyChanged("UserId");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    [DataMember]
    public int PasswordFormat
    {
      get
      {
        return this._PasswordFormat;
      }
      set
      {
        if (this._PasswordFormat == value)
          return;
        this.ReportPropertyChanging("PasswordFormat");
        this._PasswordFormat = StructuralObject.SetValidValue(value, "PasswordFormat");
        this.ReportPropertyChanged("PasswordFormat");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public string MobilePIN
    {
      get
      {
        return this._MobilePIN;
      }
      set
      {
        this.ReportPropertyChanging("MobilePIN");
        this._MobilePIN = StructuralObject.SetValidValue(value, true, "MobilePIN");
        this.ReportPropertyChanged("MobilePIN");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public string Email
    {
      get
      {
        return this._Email;
      }
      set
      {
        this.ReportPropertyChanging("Email");
        this._Email = StructuralObject.SetValidValue(value, true, "Email");
        this.ReportPropertyChanged("Email");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public string LoweredEmail
    {
      get
      {
        return this._LoweredEmail;
      }
      set
      {
        this.ReportPropertyChanging("LoweredEmail");
        this._LoweredEmail = StructuralObject.SetValidValue(value, true, "LoweredEmail");
        this.ReportPropertyChanged("LoweredEmail");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public string PasswordQuestion
    {
      get
      {
        return this._PasswordQuestion;
      }
      set
      {
        this.ReportPropertyChanging("PasswordQuestion");
        this._PasswordQuestion = StructuralObject.SetValidValue(value, true, "PasswordQuestion");
        this.ReportPropertyChanged("PasswordQuestion");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public string PasswordAnswer
    {
      get
      {
        return this._PasswordAnswer;
      }
      set
      {
        this.ReportPropertyChanging("PasswordAnswer");
        this._PasswordAnswer = StructuralObject.SetValidValue(value, true, "PasswordAnswer");
        this.ReportPropertyChanged("PasswordAnswer");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    public bool IsApproved
    {
      get
      {
        return this._IsApproved;
      }
      set
      {
        if (this._IsApproved == value)
          return;
        this.ReportPropertyChanging("IsApproved");
        this._IsApproved = StructuralObject.SetValidValue(value, "IsApproved");
        this.ReportPropertyChanged("IsApproved");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    public bool IsLockedOut
    {
      get
      {
        return this._IsLockedOut;
      }
      set
      {
        if (this._IsLockedOut == value)
          return;
        this.ReportPropertyChanging("IsLockedOut");
        this._IsLockedOut = StructuralObject.SetValidValue(value, "IsLockedOut");
        this.ReportPropertyChanged("IsLockedOut");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    public DateTime CreateDate
    {
      get
      {
        return this._CreateDate;
      }
      set
      {
        if (!(this._CreateDate != value))
          return;
        this.ReportPropertyChanging("CreateDate");
        this._CreateDate = StructuralObject.SetValidValue(value, "CreateDate");
        this.ReportPropertyChanged("CreateDate");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    public DateTime LastLoginDate
    {
      get
      {
        return this._LastLoginDate;
      }
      set
      {
        if (!(this._LastLoginDate != value))
          return;
        this.ReportPropertyChanging("LastLoginDate");
        this._LastLoginDate = StructuralObject.SetValidValue(value, "LastLoginDate");
        this.ReportPropertyChanged("LastLoginDate");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    public DateTime LastPasswordChangedDate
    {
      get
      {
        return this._LastPasswordChangedDate;
      }
      set
      {
        if (!(this._LastPasswordChangedDate != value))
          return;
        this.ReportPropertyChanging("LastPasswordChangedDate");
        this._LastPasswordChangedDate = StructuralObject.SetValidValue(value, "LastPasswordChangedDate");
        this.ReportPropertyChanged("LastPasswordChangedDate");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    public DateTime LastLockoutDate
    {
      get
      {
        return this._LastLockoutDate;
      }
      set
      {
        if (!(this._LastLockoutDate != value))
          return;
        this.ReportPropertyChanging("LastLockoutDate");
        this._LastLockoutDate = StructuralObject.SetValidValue(value, "LastLockoutDate");
        this.ReportPropertyChanged("LastLockoutDate");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    [DataMember]
    public int FailedPasswordAttemptCount
    {
      get
      {
        return this._FailedPasswordAttemptCount;
      }
      set
      {
        if (this._FailedPasswordAttemptCount == value)
          return;
        this.ReportPropertyChanging("FailedPasswordAttemptCount");
        this._FailedPasswordAttemptCount = StructuralObject.SetValidValue(value, "FailedPasswordAttemptCount");
        this.ReportPropertyChanged("FailedPasswordAttemptCount");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    public DateTime FailedPasswordAttemptWindowStart
    {
      get
      {
        return this._FailedPasswordAttemptWindowStart;
      }
      set
      {
        if (!(this._FailedPasswordAttemptWindowStart != value))
          return;
        this.ReportPropertyChanging("FailedPasswordAttemptWindowStart");
        this._FailedPasswordAttemptWindowStart = StructuralObject.SetValidValue(value, "FailedPasswordAttemptWindowStart");
        this.ReportPropertyChanged("FailedPasswordAttemptWindowStart");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    [DataMember]
    public int FailedPasswordAnswerAttemptCount
    {
      get
      {
        return this._FailedPasswordAnswerAttemptCount;
      }
      set
      {
        if (this._FailedPasswordAnswerAttemptCount == value)
          return;
        this.ReportPropertyChanging("FailedPasswordAnswerAttemptCount");
        this._FailedPasswordAnswerAttemptCount = StructuralObject.SetValidValue(value, "FailedPasswordAnswerAttemptCount");
        this.ReportPropertyChanged("FailedPasswordAnswerAttemptCount");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    [DataMember]
    public DateTime FailedPasswordAnswerAttemptWindowStart
    {
      get
      {
        return this._FailedPasswordAnswerAttemptWindowStart;
      }
      set
      {
        if (!(this._FailedPasswordAnswerAttemptWindowStart != value))
          return;
        this.ReportPropertyChanging("FailedPasswordAnswerAttemptWindowStart");
        this._FailedPasswordAnswerAttemptWindowStart = StructuralObject.SetValidValue(value, "FailedPasswordAnswerAttemptWindowStart");
        this.ReportPropertyChanged("FailedPasswordAnswerAttemptWindowStart");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public string Comment
    {
      get
      {
        return this._Comment;
      }
      set
      {
        this.ReportPropertyChanging("Comment");
        this._Comment = StructuralObject.SetValidValue(value, true, "Comment");
        this.ReportPropertyChanged("Comment");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    [DataMember]
    public Guid ApplicationId
    {
      get
      {
        return this._ApplicationId;
      }
      set
      {
        if (!(this._ApplicationId != value))
          return;
        this.ReportPropertyChanging("ApplicationId");
        this._ApplicationId = StructuralObject.SetValidValue(value, "ApplicationId");
        this.ReportPropertyChanged("ApplicationId");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    public string UserName
    {
      get
      {
        return this._UserName;
      }
      set
      {
        if (!(this._UserName != value))
          return;
        this.ReportPropertyChanging("UserName");
        this._UserName = StructuralObject.SetValidValue(value, false, "UserName");
        this.ReportPropertyChanged("UserName");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public string MobileAlias
    {
      get
      {
        return this._MobileAlias;
      }
      set
      {
        this.ReportPropertyChanging("MobileAlias");
        this._MobileAlias = StructuralObject.SetValidValue(value, true, "MobileAlias");
        this.ReportPropertyChanged("MobileAlias");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    public bool IsAnonymous
    {
      get
      {
        return this._IsAnonymous;
      }
      set
      {
        if (this._IsAnonymous == value)
          return;
        this.ReportPropertyChanging("IsAnonymous");
        this._IsAnonymous = StructuralObject.SetValidValue(value, "IsAnonymous");
        this.ReportPropertyChanged("IsAnonymous");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    public DateTime LastActivityDate
    {
      get
      {
        return this._LastActivityDate;
      }
      set
      {
        if (!(this._LastActivityDate != value))
          return;
        this.ReportPropertyChanging("LastActivityDate");
        this._LastActivityDate = StructuralObject.SetValidValue(value, "LastActivityDate");
        this.ReportPropertyChanged("LastActivityDate");
      }
    }

    public static vw_aspnet_MembershipUsers Createvw_aspnet_MembershipUsers(Guid userId, int passwordFormat, bool isApproved, bool isLockedOut, DateTime createDate, DateTime lastLoginDate, DateTime lastPasswordChangedDate, DateTime lastLockoutDate, int failedPasswordAttemptCount, DateTime failedPasswordAttemptWindowStart, int failedPasswordAnswerAttemptCount, DateTime failedPasswordAnswerAttemptWindowStart, Guid applicationId, string userName, bool isAnonymous, DateTime lastActivityDate)
    {
      return new vw_aspnet_MembershipUsers()
      {
        UserId = userId,
        PasswordFormat = passwordFormat,
        IsApproved = isApproved,
        IsLockedOut = isLockedOut,
        CreateDate = createDate,
        LastLoginDate = lastLoginDate,
        LastPasswordChangedDate = lastPasswordChangedDate,
        LastLockoutDate = lastLockoutDate,
        FailedPasswordAttemptCount = failedPasswordAttemptCount,
        FailedPasswordAttemptWindowStart = failedPasswordAttemptWindowStart,
        FailedPasswordAnswerAttemptCount = failedPasswordAnswerAttemptCount,
        FailedPasswordAnswerAttemptWindowStart = failedPasswordAnswerAttemptWindowStart,
        ApplicationId = applicationId,
        UserName = userName,
        IsAnonymous = isAnonymous,
        LastActivityDate = lastActivityDate
      };
    }
  }
}
