// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.aspnet_Membership
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
  [EdmEntityType(Name = "aspnet_Membership", NamespaceName = "TradePlatformModel")]
  [Serializable]
  public class aspnet_Membership : EntityObject
  {
    private Guid _ApplicationId;
    private Guid _UserId;
    private string _Password;
    private int _PasswordFormat;
    private string _PasswordSalt;
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

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public Guid ApplicationId
    {
      get
      {
        return this._ApplicationId;
      }
      set
      {
        this.ReportPropertyChanging("ApplicationId");
        this._ApplicationId = StructuralObject.SetValidValue(value, "ApplicationId");
        this.ReportPropertyChanged("ApplicationId");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    [DataMember]
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

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public string Password
    {
      get
      {
        return this._Password;
      }
      set
      {
        this.ReportPropertyChanging("Password");
        this._Password = StructuralObject.SetValidValue(value, false, "Password");
        this.ReportPropertyChanged("Password");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public int PasswordFormat
    {
      get
      {
        return this._PasswordFormat;
      }
      set
      {
        this.ReportPropertyChanging("PasswordFormat");
        this._PasswordFormat = StructuralObject.SetValidValue(value, "PasswordFormat");
        this.ReportPropertyChanged("PasswordFormat");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public string PasswordSalt
    {
      get
      {
        return this._PasswordSalt;
      }
      set
      {
        this.ReportPropertyChanging("PasswordSalt");
        this._PasswordSalt = StructuralObject.SetValidValue(value, false, "PasswordSalt");
        this.ReportPropertyChanged("PasswordSalt");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
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

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
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

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
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

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
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

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
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
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public bool IsApproved
    {
      get
      {
        return this._IsApproved;
      }
      set
      {
        this.ReportPropertyChanging("IsApproved");
        this._IsApproved = StructuralObject.SetValidValue(value, "IsApproved");
        this.ReportPropertyChanged("IsApproved");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public bool IsLockedOut
    {
      get
      {
        return this._IsLockedOut;
      }
      set
      {
        this.ReportPropertyChanging("IsLockedOut");
        this._IsLockedOut = StructuralObject.SetValidValue(value, "IsLockedOut");
        this.ReportPropertyChanged("IsLockedOut");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public DateTime CreateDate
    {
      get
      {
        return this._CreateDate;
      }
      set
      {
        this.ReportPropertyChanging("CreateDate");
        this._CreateDate = StructuralObject.SetValidValue(value, "CreateDate");
        this.ReportPropertyChanged("CreateDate");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public DateTime LastLoginDate
    {
      get
      {
        return this._LastLoginDate;
      }
      set
      {
        this.ReportPropertyChanging("LastLoginDate");
        this._LastLoginDate = StructuralObject.SetValidValue(value, "LastLoginDate");
        this.ReportPropertyChanged("LastLoginDate");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public DateTime LastPasswordChangedDate
    {
      get
      {
        return this._LastPasswordChangedDate;
      }
      set
      {
        this.ReportPropertyChanging("LastPasswordChangedDate");
        this._LastPasswordChangedDate = StructuralObject.SetValidValue(value, "LastPasswordChangedDate");
        this.ReportPropertyChanged("LastPasswordChangedDate");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public DateTime LastLockoutDate
    {
      get
      {
        return this._LastLockoutDate;
      }
      set
      {
        this.ReportPropertyChanging("LastLockoutDate");
        this._LastLockoutDate = StructuralObject.SetValidValue(value, "LastLockoutDate");
        this.ReportPropertyChanged("LastLockoutDate");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public int FailedPasswordAttemptCount
    {
      get
      {
        return this._FailedPasswordAttemptCount;
      }
      set
      {
        this.ReportPropertyChanging("FailedPasswordAttemptCount");
        this._FailedPasswordAttemptCount = StructuralObject.SetValidValue(value, "FailedPasswordAttemptCount");
        this.ReportPropertyChanged("FailedPasswordAttemptCount");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public DateTime FailedPasswordAttemptWindowStart
    {
      get
      {
        return this._FailedPasswordAttemptWindowStart;
      }
      set
      {
        this.ReportPropertyChanging("FailedPasswordAttemptWindowStart");
        this._FailedPasswordAttemptWindowStart = StructuralObject.SetValidValue(value, "FailedPasswordAttemptWindowStart");
        this.ReportPropertyChanged("FailedPasswordAttemptWindowStart");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public int FailedPasswordAnswerAttemptCount
    {
      get
      {
        return this._FailedPasswordAnswerAttemptCount;
      }
      set
      {
        this.ReportPropertyChanging("FailedPasswordAnswerAttemptCount");
        this._FailedPasswordAnswerAttemptCount = StructuralObject.SetValidValue(value, "FailedPasswordAnswerAttemptCount");
        this.ReportPropertyChanged("FailedPasswordAnswerAttemptCount");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public DateTime FailedPasswordAnswerAttemptWindowStart
    {
      get
      {
        return this._FailedPasswordAnswerAttemptWindowStart;
      }
      set
      {
        this.ReportPropertyChanging("FailedPasswordAnswerAttemptWindowStart");
        this._FailedPasswordAnswerAttemptWindowStart = StructuralObject.SetValidValue(value, "FailedPasswordAnswerAttemptWindowStart");
        this.ReportPropertyChanged("FailedPasswordAnswerAttemptWindowStart");
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
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

    [XmlIgnore]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "FK__aspnet_Me__Appli__276EDEB3", "aspnet_Applications")]
    [SoapIgnore]
    [DataMember]
    public aspnet_Applications aspnet_Applications
    {
      get
      {
          return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<aspnet_Applications>("TradePlatformModel.FK__aspnet_Me__Appli__276EDEB3", "aspnet_Applications").Value;
      }
      set
      {
        ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<aspnet_Applications>("TradePlatformModel.FK__aspnet_Me__Appli__276EDEB3", "aspnet_Applications").Value = value;
      }
    }

    [DataMember]
    [Browsable(false)]
    public EntityReference<aspnet_Applications> aspnet_ApplicationsReference
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<aspnet_Applications>("TradePlatformModel.FK__aspnet_Me__Appli__276EDEB3", "aspnet_Applications");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<aspnet_Applications>("TradePlatformModel.FK__aspnet_Me__Appli__276EDEB3", "aspnet_Applications", value);
      }
    }

    [SoapIgnore]
    [XmlIgnore]
    [DataMember]
    [EdmRelationshipNavigationProperty("TradePlatformModel", "FK__aspnet_Me__UserI__286302EC", "aspnet_Users")]
    public aspnet_Users aspnet_Users
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<aspnet_Users>("TradePlatformModel.FK__aspnet_Me__UserI__286302EC", "aspnet_Users").Value;
      }
      set
      {
        ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<aspnet_Users>("TradePlatformModel.FK__aspnet_Me__UserI__286302EC", "aspnet_Users").Value = value;
      }
    }

    [DataMember]
    [Browsable(false)]
    public EntityReference<aspnet_Users> aspnet_UsersReference
    {
      get
      {
        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<aspnet_Users>("TradePlatformModel.FK__aspnet_Me__UserI__286302EC", "aspnet_Users");
      }
      set
      {
        if (value == null)
          return;
        ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<aspnet_Users>("TradePlatformModel.FK__aspnet_Me__UserI__286302EC", "aspnet_Users", value);
      }
    }

    public static aspnet_Membership Createaspnet_Membership(Guid applicationId, Guid userId, string password, int passwordFormat, string passwordSalt, bool isApproved, bool isLockedOut, DateTime createDate, DateTime lastLoginDate, DateTime lastPasswordChangedDate, DateTime lastLockoutDate, int failedPasswordAttemptCount, DateTime failedPasswordAttemptWindowStart, int failedPasswordAnswerAttemptCount, DateTime failedPasswordAnswerAttemptWindowStart)
    {
      return new aspnet_Membership()
      {
        ApplicationId = applicationId,
        UserId = userId,
        Password = password,
        PasswordFormat = passwordFormat,
        PasswordSalt = passwordSalt,
        IsApproved = isApproved,
        IsLockedOut = isLockedOut,
        CreateDate = createDate,
        LastLoginDate = lastLoginDate,
        LastPasswordChangedDate = lastPasswordChangedDate,
        LastLockoutDate = lastLockoutDate,
        FailedPasswordAttemptCount = failedPasswordAttemptCount,
        FailedPasswordAttemptWindowStart = failedPasswordAttemptWindowStart,
        FailedPasswordAnswerAttemptCount = failedPasswordAnswerAttemptCount,
        FailedPasswordAnswerAttemptWindowStart = failedPasswordAnswerAttemptWindowStart
      };
    }
  }
}
