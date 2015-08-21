// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.aspnet_Membership_GetUserByUserId3_Result
// Assembly: TradePlatform.MT4.Data, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FF714B79-462F-457E-9D98-705104E62A16
// Assembly location: T:\work\mql4\ForexSharp1\TradePlatform.MT4.SDK\TradePlatform.MT4.Engine\lib\TradePlatform.MT4.Data.dll

using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace TradePlatform.MT4.Data
{
  [DataContract(IsReference = true)]
  [EdmComplexType(Name = "aspnet_Membership_GetUserByUserId3_Result", NamespaceName = "TradePlatformModel")]
  [Serializable]
  public class aspnet_Membership_GetUserByUserId3_Result : ComplexObject
  {
    private string _Email;
    private string _PasswordQuestion;
    private string _Comment;
    private bool _IsApproved;
    private DateTime _CreateDate;
    private DateTime _LastLoginDate;
    private DateTime _LastActivityDate;
    private DateTime _LastPasswordChangedDate;
    private string _UserName;
    private bool _IsLockedOut;
    private DateTime _LastLockoutDate;

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

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
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

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
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
    public DateTime LastActivityDate
    {
      get
      {
        return this._LastActivityDate;
      }
      set
      {
        this.ReportPropertyChanging("LastActivityDate");
        this._LastActivityDate = StructuralObject.SetValidValue(value, "LastActivityDate");
        this.ReportPropertyChanged("LastActivityDate");
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
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
    public string UserName
    {
      get
      {
        return this._UserName;
      }
      set
      {
        this.ReportPropertyChanging("UserName");
        this._UserName = StructuralObject.SetValidValue(value, false, "UserName");
        this.ReportPropertyChanged("UserName");
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

    public static aspnet_Membership_GetUserByUserId3_Result Createaspnet_Membership_GetUserByUserId3_Result(bool isApproved, DateTime createDate, DateTime lastLoginDate, DateTime lastActivityDate, DateTime lastPasswordChangedDate, string userName, bool isLockedOut, DateTime lastLockoutDate)
    {
      return new aspnet_Membership_GetUserByUserId3_Result()
      {
        IsApproved = isApproved,
        CreateDate = createDate,
        LastLoginDate = lastLoginDate,
        LastActivityDate = lastActivityDate,
        LastPasswordChangedDate = lastPasswordChangedDate,
        UserName = userName,
        IsLockedOut = isLockedOut,
        LastLockoutDate = lastLockoutDate
      };
    }
  }
}
