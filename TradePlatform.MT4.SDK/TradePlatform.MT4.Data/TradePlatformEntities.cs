// Decompiled with JetBrains decompiler
// Type: TradePlatform.MT4.Data.TradePlatformEntities
// Assembly: TradePlatform.MT4.Data, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FF714B79-462F-457E-9D98-705104E62A16
// Assembly location: T:\work\mql4\ForexSharp1\TradePlatform.MT4.SDK\TradePlatform.MT4.Engine\lib\TradePlatform.MT4.Data.dll

using System;
using System.Data.EntityClient;
using System.Data.Objects;

namespace TradePlatform.MT4.Data
{
  public class TradePlatformEntities : ObjectContext
  {
    private ObjectSet<TradePlatform.MT4.Data.C__RefactorLog> _C__RefactorLog;
    private ObjectSet<TradePlatform.MT4.Data.aspnet_Applications> _aspnet_Applications;
    private ObjectSet<TradePlatform.MT4.Data.aspnet_Membership> _aspnet_Membership;
    private ObjectSet<TradePlatform.MT4.Data.aspnet_Profile> _aspnet_Profile;
    private ObjectSet<TradePlatform.MT4.Data.aspnet_Roles> _aspnet_Roles;
    private ObjectSet<TradePlatform.MT4.Data.aspnet_SchemaVersions> _aspnet_SchemaVersions;
    private ObjectSet<TradePlatform.MT4.Data.aspnet_Users> _aspnet_Users;
    private ObjectSet<BankAccountGroup> _BankAccountGroups;
    private ObjectSet<BankAccount> _BankAccounts;
    private ObjectSet<BankTransactionCategory> _BankTransactionCategories;
    private ObjectSet<BankTransactionCategoryBudgetPeriod> _BankTransactionCategoryBudgetPeriods;
    private ObjectSet<BankTransactionCategoryBudget> _BankTransactionCategoryBudgets;
    private ObjectSet<BankTransactionCategoryGroup> _BankTransactionCategoryGroups;
    private ObjectSet<BankTransaction> _BankTransactions;
    private ObjectSet<ExpertSystem> _ExpertSystems;
    private ObjectSet<MetaTraderAccountFilterSet> _MetaTraderAccountFilterSets;
    private ObjectSet<MetaTraderAccount> _MetaTraderAccounts;
    private ObjectSet<MetaTraderOrderFilterSet> _MetaTraderOrderFilterSets;
    private ObjectSet<MetaTraderOrder> _MetaTraderOrders;
    private ObjectSet<MetaTraderTickData> _MetaTraderTickDatas;
    private ObjectSet<MonthlyData> _MonthlyDatas;
    private ObjectSet<RolePermission> _RolePermissions;
    private ObjectSet<ScheduledTaskParameter> _ScheduledTaskParameters;
    private ObjectSet<ScheduledTask> _ScheduledTasks;
    private ObjectSet<TradeDuplicatorBee> _TradeDuplicatorBees;
    private ObjectSet<TradeDuplicatorDrone> _TradeDuplicatorDrones;
    private ObjectSet<TradePlatform.MT4.Data.vw_aspnet_Applications> _vw_aspnet_Applications;
    private ObjectSet<TradePlatform.MT4.Data.vw_aspnet_MembershipUsers> _vw_aspnet_MembershipUsers;
    private ObjectSet<TradePlatform.MT4.Data.vw_aspnet_Profiles> _vw_aspnet_Profiles;
    private ObjectSet<TradePlatform.MT4.Data.vw_aspnet_Roles> _vw_aspnet_Roles;
    private ObjectSet<TradePlatform.MT4.Data.vw_aspnet_Users> _vw_aspnet_Users;
    private ObjectSet<TradePlatform.MT4.Data.vw_aspnet_UsersInRoles> _vw_aspnet_UsersInRoles;

    public ObjectSet<TradePlatform.MT4.Data.C__RefactorLog> C__RefactorLog
    {
      get
      {
        if (this._C__RefactorLog == null)
          this._C__RefactorLog = this.CreateObjectSet<TradePlatform.MT4.Data.C__RefactorLog>("C__RefactorLog");
        return this._C__RefactorLog;
      }
    }

    public ObjectSet<TradePlatform.MT4.Data.aspnet_Applications> aspnet_Applications
    {
      get
      {
        if (this._aspnet_Applications == null)
          this._aspnet_Applications = this.CreateObjectSet<TradePlatform.MT4.Data.aspnet_Applications>("aspnet_Applications");
        return this._aspnet_Applications;
      }
    }

    public ObjectSet<TradePlatform.MT4.Data.aspnet_Membership> aspnet_Membership
    {
      get
      {
        if (this._aspnet_Membership == null)
          this._aspnet_Membership = this.CreateObjectSet<TradePlatform.MT4.Data.aspnet_Membership>("aspnet_Membership");
        return this._aspnet_Membership;
      }
    }

    public ObjectSet<TradePlatform.MT4.Data.aspnet_Profile> aspnet_Profile
    {
      get
      {
        if (this._aspnet_Profile == null)
          this._aspnet_Profile = this.CreateObjectSet<TradePlatform.MT4.Data.aspnet_Profile>("aspnet_Profile");
        return this._aspnet_Profile;
      }
    }

    public ObjectSet<TradePlatform.MT4.Data.aspnet_Roles> aspnet_Roles
    {
      get
      {
        if (this._aspnet_Roles == null)
          this._aspnet_Roles = this.CreateObjectSet<TradePlatform.MT4.Data.aspnet_Roles>("aspnet_Roles");
        return this._aspnet_Roles;
      }
    }

    public ObjectSet<TradePlatform.MT4.Data.aspnet_SchemaVersions> aspnet_SchemaVersions
    {
      get
      {
        if (this._aspnet_SchemaVersions == null)
          this._aspnet_SchemaVersions = this.CreateObjectSet<TradePlatform.MT4.Data.aspnet_SchemaVersions>("aspnet_SchemaVersions");
        return this._aspnet_SchemaVersions;
      }
    }

    public ObjectSet<TradePlatform.MT4.Data.aspnet_Users> aspnet_Users
    {
      get
      {
        if (this._aspnet_Users == null)
          this._aspnet_Users = this.CreateObjectSet<TradePlatform.MT4.Data.aspnet_Users>("aspnet_Users");
        return this._aspnet_Users;
      }
    }

    public ObjectSet<BankAccountGroup> BankAccountGroups
    {
      get
      {
        if (this._BankAccountGroups == null)
          this._BankAccountGroups = this.CreateObjectSet<BankAccountGroup>("BankAccountGroups");
        return this._BankAccountGroups;
      }
    }

    public ObjectSet<BankAccount> BankAccounts
    {
      get
      {
        if (this._BankAccounts == null)
          this._BankAccounts = this.CreateObjectSet<BankAccount>("BankAccounts");
        return this._BankAccounts;
      }
    }

    public ObjectSet<BankTransactionCategory> BankTransactionCategories
    {
      get
      {
        if (this._BankTransactionCategories == null)
          this._BankTransactionCategories = this.CreateObjectSet<BankTransactionCategory>("BankTransactionCategories");
        return this._BankTransactionCategories;
      }
    }

    public ObjectSet<BankTransactionCategoryBudgetPeriod> BankTransactionCategoryBudgetPeriods
    {
      get
      {
        if (this._BankTransactionCategoryBudgetPeriods == null)
          this._BankTransactionCategoryBudgetPeriods = this.CreateObjectSet<BankTransactionCategoryBudgetPeriod>("BankTransactionCategoryBudgetPeriods");
        return this._BankTransactionCategoryBudgetPeriods;
      }
    }

    public ObjectSet<BankTransactionCategoryBudget> BankTransactionCategoryBudgets
    {
      get
      {
        if (this._BankTransactionCategoryBudgets == null)
          this._BankTransactionCategoryBudgets = this.CreateObjectSet<BankTransactionCategoryBudget>("BankTransactionCategoryBudgets");
        return this._BankTransactionCategoryBudgets;
      }
    }

    public ObjectSet<BankTransactionCategoryGroup> BankTransactionCategoryGroups
    {
      get
      {
        if (this._BankTransactionCategoryGroups == null)
          this._BankTransactionCategoryGroups = this.CreateObjectSet<BankTransactionCategoryGroup>("BankTransactionCategoryGroups");
        return this._BankTransactionCategoryGroups;
      }
    }

    public ObjectSet<BankTransaction> BankTransactions
    {
      get
      {
        if (this._BankTransactions == null)
          this._BankTransactions = this.CreateObjectSet<BankTransaction>("BankTransactions");
        return this._BankTransactions;
      }
    }

    public ObjectSet<ExpertSystem> ExpertSystems
    {
      get
      {
        if (this._ExpertSystems == null)
          this._ExpertSystems = this.CreateObjectSet<ExpertSystem>("ExpertSystems");
        return this._ExpertSystems;
      }
    }

    public ObjectSet<MetaTraderAccountFilterSet> MetaTraderAccountFilterSets
    {
      get
      {
        if (this._MetaTraderAccountFilterSets == null)
          this._MetaTraderAccountFilterSets = this.CreateObjectSet<MetaTraderAccountFilterSet>("MetaTraderAccountFilterSets");
        return this._MetaTraderAccountFilterSets;
      }
    }

    public ObjectSet<MetaTraderAccount> MetaTraderAccounts
    {
      get
      {
        if (this._MetaTraderAccounts == null)
          this._MetaTraderAccounts = this.CreateObjectSet<MetaTraderAccount>("MetaTraderAccounts");
        return this._MetaTraderAccounts;
      }
    }

    public ObjectSet<MetaTraderOrderFilterSet> MetaTraderOrderFilterSets
    {
      get
      {
        if (this._MetaTraderOrderFilterSets == null)
          this._MetaTraderOrderFilterSets = this.CreateObjectSet<MetaTraderOrderFilterSet>("MetaTraderOrderFilterSets");
        return this._MetaTraderOrderFilterSets;
      }
    }

    public ObjectSet<MetaTraderOrder> MetaTraderOrders
    {
      get
      {
        if (this._MetaTraderOrders == null)
          this._MetaTraderOrders = this.CreateObjectSet<MetaTraderOrder>("MetaTraderOrders");
        return this._MetaTraderOrders;
      }
    }

    public ObjectSet<MetaTraderTickData> MetaTraderTickDatas
    {
      get
      {
        if (this._MetaTraderTickDatas == null)
          this._MetaTraderTickDatas = this.CreateObjectSet<MetaTraderTickData>("MetaTraderTickDatas");
        return this._MetaTraderTickDatas;
      }
    }

    public ObjectSet<MonthlyData> MonthlyDatas
    {
      get
      {
        if (this._MonthlyDatas == null)
          this._MonthlyDatas = this.CreateObjectSet<MonthlyData>("MonthlyDatas");
        return this._MonthlyDatas;
      }
    }

    public ObjectSet<RolePermission> RolePermissions
    {
      get
      {
        if (this._RolePermissions == null)
          this._RolePermissions = this.CreateObjectSet<RolePermission>("RolePermissions");
        return this._RolePermissions;
      }
    }

    public ObjectSet<ScheduledTaskParameter> ScheduledTaskParameters
    {
      get
      {
        if (this._ScheduledTaskParameters == null)
          this._ScheduledTaskParameters = this.CreateObjectSet<ScheduledTaskParameter>("ScheduledTaskParameters");
        return this._ScheduledTaskParameters;
      }
    }

    public ObjectSet<ScheduledTask> ScheduledTasks
    {
      get
      {
        if (this._ScheduledTasks == null)
          this._ScheduledTasks = this.CreateObjectSet<ScheduledTask>("ScheduledTasks");
        return this._ScheduledTasks;
      }
    }

    public ObjectSet<TradeDuplicatorBee> TradeDuplicatorBees
    {
      get
      {
        if (this._TradeDuplicatorBees == null)
          this._TradeDuplicatorBees = this.CreateObjectSet<TradeDuplicatorBee>("TradeDuplicatorBees");
        return this._TradeDuplicatorBees;
      }
    }

    public ObjectSet<TradeDuplicatorDrone> TradeDuplicatorDrones
    {
      get
      {
        if (this._TradeDuplicatorDrones == null)
          this._TradeDuplicatorDrones = this.CreateObjectSet<TradeDuplicatorDrone>("TradeDuplicatorDrones");
        return this._TradeDuplicatorDrones;
      }
    }

    public ObjectSet<TradePlatform.MT4.Data.vw_aspnet_Applications> vw_aspnet_Applications
    {
      get
      {
        if (this._vw_aspnet_Applications == null)
          this._vw_aspnet_Applications = this.CreateObjectSet<TradePlatform.MT4.Data.vw_aspnet_Applications>("vw_aspnet_Applications");
        return this._vw_aspnet_Applications;
      }
    }

    public ObjectSet<TradePlatform.MT4.Data.vw_aspnet_MembershipUsers> vw_aspnet_MembershipUsers
    {
      get
      {
        if (this._vw_aspnet_MembershipUsers == null)
          this._vw_aspnet_MembershipUsers = this.CreateObjectSet<TradePlatform.MT4.Data.vw_aspnet_MembershipUsers>("vw_aspnet_MembershipUsers");
        return this._vw_aspnet_MembershipUsers;
      }
    }

    public ObjectSet<TradePlatform.MT4.Data.vw_aspnet_Profiles> vw_aspnet_Profiles
    {
      get
      {
        if (this._vw_aspnet_Profiles == null)
          this._vw_aspnet_Profiles = this.CreateObjectSet<TradePlatform.MT4.Data.vw_aspnet_Profiles>("vw_aspnet_Profiles");
        return this._vw_aspnet_Profiles;
      }
    }

    public ObjectSet<TradePlatform.MT4.Data.vw_aspnet_Roles> vw_aspnet_Roles
    {
      get
      {
        if (this._vw_aspnet_Roles == null)
          this._vw_aspnet_Roles = this.CreateObjectSet<TradePlatform.MT4.Data.vw_aspnet_Roles>("vw_aspnet_Roles");
        return this._vw_aspnet_Roles;
      }
    }

    public ObjectSet<TradePlatform.MT4.Data.vw_aspnet_Users> vw_aspnet_Users
    {
      get
      {
        if (this._vw_aspnet_Users == null)
          this._vw_aspnet_Users = this.CreateObjectSet<TradePlatform.MT4.Data.vw_aspnet_Users>("vw_aspnet_Users");
        return this._vw_aspnet_Users;
      }
    }

    public ObjectSet<TradePlatform.MT4.Data.vw_aspnet_UsersInRoles> vw_aspnet_UsersInRoles
    {
      get
      {
        if (this._vw_aspnet_UsersInRoles == null)
          this._vw_aspnet_UsersInRoles = this.CreateObjectSet<TradePlatform.MT4.Data.vw_aspnet_UsersInRoles>("vw_aspnet_UsersInRoles");
        return this._vw_aspnet_UsersInRoles;
      }
    }

    public TradePlatformEntities()
      : base("name=TradePlatformEntities", "TradePlatformEntities")
    {
      this.ContextOptions.LazyLoadingEnabled = true;
    }

    public TradePlatformEntities(string connectionString)
      : base(connectionString, "TradePlatformEntities")
    {
      this.ContextOptions.LazyLoadingEnabled = true;
    }

    public TradePlatformEntities(EntityConnection connection)
      : base(connection, "TradePlatformEntities")
    {
      this.ContextOptions.LazyLoadingEnabled = true;
    }

    public void AddToC__RefactorLog(TradePlatform.MT4.Data.C__RefactorLog c__RefactorLog)
    {
      this.AddObject("C__RefactorLog", (object) c__RefactorLog);
    }

    public void AddToaspnet_Applications(TradePlatform.MT4.Data.aspnet_Applications aspnet_Applications)
    {
      this.AddObject("aspnet_Applications", (object) aspnet_Applications);
    }

    public void AddToaspnet_Membership(TradePlatform.MT4.Data.aspnet_Membership aspnet_Membership)
    {
      this.AddObject("aspnet_Membership", (object) aspnet_Membership);
    }

    public void AddToaspnet_Profile(TradePlatform.MT4.Data.aspnet_Profile aspnet_Profile)
    {
      this.AddObject("aspnet_Profile", (object) aspnet_Profile);
    }

    public void AddToaspnet_Roles(TradePlatform.MT4.Data.aspnet_Roles aspnet_Roles)
    {
      this.AddObject("aspnet_Roles", (object) aspnet_Roles);
    }

    public void AddToaspnet_SchemaVersions(TradePlatform.MT4.Data.aspnet_SchemaVersions aspnet_SchemaVersions)
    {
      this.AddObject("aspnet_SchemaVersions", (object) aspnet_SchemaVersions);
    }

    public void AddToaspnet_Users(TradePlatform.MT4.Data.aspnet_Users aspnet_Users)
    {
      this.AddObject("aspnet_Users", (object) aspnet_Users);
    }

    public void AddToBankAccountGroups(BankAccountGroup bankAccountGroup)
    {
      this.AddObject("BankAccountGroups", (object) bankAccountGroup);
    }

    public void AddToBankAccounts(BankAccount bankAccount)
    {
      this.AddObject("BankAccounts", (object) bankAccount);
    }

    public void AddToBankTransactionCategories(BankTransactionCategory bankTransactionCategory)
    {
      this.AddObject("BankTransactionCategories", (object) bankTransactionCategory);
    }

    public void AddToBankTransactionCategoryBudgetPeriods(BankTransactionCategoryBudgetPeriod bankTransactionCategoryBudgetPeriod)
    {
      this.AddObject("BankTransactionCategoryBudgetPeriods", (object) bankTransactionCategoryBudgetPeriod);
    }

    public void AddToBankTransactionCategoryBudgets(BankTransactionCategoryBudget bankTransactionCategoryBudget)
    {
      this.AddObject("BankTransactionCategoryBudgets", (object) bankTransactionCategoryBudget);
    }

    public void AddToBankTransactionCategoryGroups(BankTransactionCategoryGroup bankTransactionCategoryGroup)
    {
      this.AddObject("BankTransactionCategoryGroups", (object) bankTransactionCategoryGroup);
    }

    public void AddToBankTransactions(BankTransaction bankTransaction)
    {
      this.AddObject("BankTransactions", (object) bankTransaction);
    }

    public void AddToExpertSystems(ExpertSystem expertSystem)
    {
      this.AddObject("ExpertSystems", (object) expertSystem);
    }

    public void AddToMetaTraderAccountFilterSets(MetaTraderAccountFilterSet metaTraderAccountFilterSet)
    {
      this.AddObject("MetaTraderAccountFilterSets", (object) metaTraderAccountFilterSet);
    }

    public void AddToMetaTraderAccounts(MetaTraderAccount metaTraderAccount)
    {
      this.AddObject("MetaTraderAccounts", (object) metaTraderAccount);
    }

    public void AddToMetaTraderOrderFilterSets(MetaTraderOrderFilterSet metaTraderOrderFilterSet)
    {
      this.AddObject("MetaTraderOrderFilterSets", (object) metaTraderOrderFilterSet);
    }

    public void AddToMetaTraderOrders(MetaTraderOrder metaTraderOrder)
    {
      this.AddObject("MetaTraderOrders", (object) metaTraderOrder);
    }

    public void AddToMetaTraderTickDatas(MetaTraderTickData metaTraderTickData)
    {
      this.AddObject("MetaTraderTickDatas", (object) metaTraderTickData);
    }

    public void AddToMonthlyDatas(MonthlyData monthlyData)
    {
      this.AddObject("MonthlyDatas", (object) monthlyData);
    }

    public void AddToRolePermissions(RolePermission rolePermission)
    {
      this.AddObject("RolePermissions", (object) rolePermission);
    }

    public void AddToScheduledTaskParameters(ScheduledTaskParameter scheduledTaskParameter)
    {
      this.AddObject("ScheduledTaskParameters", (object) scheduledTaskParameter);
    }

    public void AddToScheduledTasks(ScheduledTask scheduledTask)
    {
      this.AddObject("ScheduledTasks", (object) scheduledTask);
    }

    public void AddToTradeDuplicatorBees(TradeDuplicatorBee tradeDuplicatorBee)
    {
      this.AddObject("TradeDuplicatorBees", (object) tradeDuplicatorBee);
    }

    public void AddToTradeDuplicatorDrones(TradeDuplicatorDrone tradeDuplicatorDrone)
    {
      this.AddObject("TradeDuplicatorDrones", (object) tradeDuplicatorDrone);
    }

    public void AddTovw_aspnet_Applications(TradePlatform.MT4.Data.vw_aspnet_Applications vw_aspnet_Applications)
    {
      this.AddObject("vw_aspnet_Applications", (object) vw_aspnet_Applications);
    }

    public void AddTovw_aspnet_MembershipUsers(TradePlatform.MT4.Data.vw_aspnet_MembershipUsers vw_aspnet_MembershipUsers)
    {
      this.AddObject("vw_aspnet_MembershipUsers", (object) vw_aspnet_MembershipUsers);
    }

    public void AddTovw_aspnet_Profiles(TradePlatform.MT4.Data.vw_aspnet_Profiles vw_aspnet_Profiles)
    {
      this.AddObject("vw_aspnet_Profiles", (object) vw_aspnet_Profiles);
    }

    public void AddTovw_aspnet_Roles(TradePlatform.MT4.Data.vw_aspnet_Roles vw_aspnet_Roles)
    {
      this.AddObject("vw_aspnet_Roles", (object) vw_aspnet_Roles);
    }

    public void AddTovw_aspnet_Users(TradePlatform.MT4.Data.vw_aspnet_Users vw_aspnet_Users)
    {
      this.AddObject("vw_aspnet_Users", (object) vw_aspnet_Users);
    }

    public void AddTovw_aspnet_UsersInRoles(TradePlatform.MT4.Data.vw_aspnet_UsersInRoles vw_aspnet_UsersInRoles)
    {
      this.AddObject("vw_aspnet_UsersInRoles", (object) vw_aspnet_UsersInRoles);
    }

    public ObjectResult<string> aspnet_AnyDataInTables(int? tablesToCheck)
    {
      return this.ExecuteFunction<string>("aspnet_AnyDataInTables", new ObjectParameter[1]
      {
        !tablesToCheck.HasValue ? new ObjectParameter("TablesToCheck", typeof (int)) : new ObjectParameter("TablesToCheck", (object) tablesToCheck)
      });
    }

    public int aspnet_Applications_CreateApplication(string applicationName, ObjectParameter applicationId)
    {
      return this.ExecuteFunction("aspnet_Applications_CreateApplication", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        applicationId
      });
    }

    public int aspnet_CheckSchemaVersion(string feature, string compatibleSchemaVersion)
    {
      return this.ExecuteFunction("aspnet_CheckSchemaVersion", new ObjectParameter[2]
      {
        feature == null ? new ObjectParameter("Feature", typeof (string)) : new ObjectParameter("Feature", (object) feature),
        compatibleSchemaVersion == null ? new ObjectParameter("CompatibleSchemaVersion", typeof (string)) : new ObjectParameter("CompatibleSchemaVersion", (object) compatibleSchemaVersion)
      });
    }

    public int aspnet_Membership_ChangePasswordQuestionAndAnswer(string applicationName, string userName, string newPasswordQuestion, string newPasswordAnswer)
    {
      return this.ExecuteFunction("aspnet_Membership_ChangePasswordQuestionAndAnswer", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), newPasswordQuestion == null ? new ObjectParameter("NewPasswordQuestion", typeof (string)) : new ObjectParameter("NewPasswordQuestion", (object) newPasswordQuestion), newPasswordAnswer == null ? new ObjectParameter("NewPasswordAnswer", typeof (string)) : new ObjectParameter("NewPasswordAnswer", (object) newPasswordAnswer));
    }

    public int aspnet_Membership_CreateUser(string applicationName, string userName, string password, string passwordSalt, string email, string passwordQuestion, string passwordAnswer, bool? isApproved, DateTime? currentTimeUtc, DateTime? createDate, int? uniqueEmail, int? passwordFormat, ObjectParameter userId)
    {
      return this.ExecuteFunction("aspnet_Membership_CreateUser", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), password == null ? new ObjectParameter("Password", typeof (string)) : new ObjectParameter("Password", (object) password), passwordSalt == null ? new ObjectParameter("PasswordSalt", typeof (string)) : new ObjectParameter("PasswordSalt", (object) passwordSalt), email == null ? new ObjectParameter("Email", typeof (string)) : new ObjectParameter("Email", (object) email), passwordQuestion == null ? new ObjectParameter("PasswordQuestion", typeof (string)) : new ObjectParameter("PasswordQuestion", (object) passwordQuestion), passwordAnswer == null ? new ObjectParameter("PasswordAnswer", typeof (string)) : new ObjectParameter("PasswordAnswer", (object) passwordAnswer), !isApproved.HasValue ? new ObjectParameter("IsApproved", typeof (bool)) : new ObjectParameter("IsApproved", (object) isApproved), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), !createDate.HasValue ? new ObjectParameter("CreateDate", typeof (DateTime)) : new ObjectParameter("CreateDate", (object) createDate), !uniqueEmail.HasValue ? new ObjectParameter("UniqueEmail", typeof (int)) : new ObjectParameter("UniqueEmail", (object) uniqueEmail), !passwordFormat.HasValue ? new ObjectParameter("PasswordFormat", typeof (int)) : new ObjectParameter("PasswordFormat", (object) passwordFormat), userId);
    }

    public int aspnet_Membership_FindUsersByEmail(string applicationName, string emailToMatch, int? pageIndex, int? pageSize)
    {
      return this.ExecuteFunction("aspnet_Membership_FindUsersByEmail", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), emailToMatch == null ? new ObjectParameter("EmailToMatch", typeof (string)) : new ObjectParameter("EmailToMatch", (object) emailToMatch), !pageIndex.HasValue ? new ObjectParameter("PageIndex", typeof (int)) : new ObjectParameter("PageIndex", (object) pageIndex), !pageSize.HasValue ? new ObjectParameter("PageSize", typeof (int)) : new ObjectParameter("PageSize", (object) pageSize));
    }

    public int aspnet_Membership_FindUsersByName(string applicationName, string userNameToMatch, int? pageIndex, int? pageSize)
    {
      return this.ExecuteFunction("aspnet_Membership_FindUsersByName", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userNameToMatch == null ? new ObjectParameter("UserNameToMatch", typeof (string)) : new ObjectParameter("UserNameToMatch", (object) userNameToMatch), !pageIndex.HasValue ? new ObjectParameter("PageIndex", typeof (int)) : new ObjectParameter("PageIndex", (object) pageIndex), !pageSize.HasValue ? new ObjectParameter("PageSize", typeof (int)) : new ObjectParameter("PageSize", (object) pageSize));
    }

    public int aspnet_Membership_GetAllUsers(string applicationName, int? pageIndex, int? pageSize)
    {
      return this.ExecuteFunction("aspnet_Membership_GetAllUsers", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), !pageIndex.HasValue ? new ObjectParameter("PageIndex", typeof (int)) : new ObjectParameter("PageIndex", (object) pageIndex), !pageSize.HasValue ? new ObjectParameter("PageSize", typeof (int)) : new ObjectParameter("PageSize", (object) pageSize));
    }

    public int aspnet_Membership_GetNumberOfUsersOnline(string applicationName, int? minutesSinceLastInActive, DateTime? currentTimeUtc)
    {
      return this.ExecuteFunction("aspnet_Membership_GetNumberOfUsersOnline", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), !minutesSinceLastInActive.HasValue ? new ObjectParameter("MinutesSinceLastInActive", typeof (int)) : new ObjectParameter("MinutesSinceLastInActive", (object) minutesSinceLastInActive), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc));
    }

    public ObjectResult<aspnet_Membership_GetPassword_Result> aspnet_Membership_GetPassword(string applicationName, string userName, int? maxInvalidPasswordAttempts, int? passwordAttemptWindow, DateTime? currentTimeUtc, string passwordAnswer)
    {
      return this.ExecuteFunction<aspnet_Membership_GetPassword_Result>("aspnet_Membership_GetPassword", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !maxInvalidPasswordAttempts.HasValue ? new ObjectParameter("MaxInvalidPasswordAttempts", typeof (int)) : new ObjectParameter("MaxInvalidPasswordAttempts", (object) maxInvalidPasswordAttempts), !passwordAttemptWindow.HasValue ? new ObjectParameter("PasswordAttemptWindow", typeof (int)) : new ObjectParameter("PasswordAttemptWindow", (object) passwordAttemptWindow), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), passwordAnswer == null ? new ObjectParameter("PasswordAnswer", typeof (string)) : new ObjectParameter("PasswordAnswer", (object) passwordAnswer));
    }

    public ObjectResult<aspnet_Membership_GetPasswordWithFormat_Result> aspnet_Membership_GetPasswordWithFormat(string applicationName, string userName, bool? updateLastLoginActivityDate, DateTime? currentTimeUtc)
    {
      return this.ExecuteFunction<aspnet_Membership_GetPasswordWithFormat_Result>("aspnet_Membership_GetPasswordWithFormat", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !updateLastLoginActivityDate.HasValue ? new ObjectParameter("UpdateLastLoginActivityDate", typeof (bool)) : new ObjectParameter("UpdateLastLoginActivityDate", (object) updateLastLoginActivityDate), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc));
    }

    public ObjectResult<string> aspnet_Membership_GetUserByEmail(string applicationName, string email)
    {
      return this.ExecuteFunction<string>("aspnet_Membership_GetUserByEmail", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        email == null ? new ObjectParameter("Email", typeof (string)) : new ObjectParameter("Email", (object) email)
      });
    }

    public ObjectResult<aspnet_Membership_GetUserByName_Result> aspnet_Membership_GetUserByName(string applicationName, string userName, DateTime? currentTimeUtc, bool? updateLastActivity)
    {
      return this.ExecuteFunction<aspnet_Membership_GetUserByName_Result>("aspnet_Membership_GetUserByName", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), !updateLastActivity.HasValue ? new ObjectParameter("UpdateLastActivity", typeof (bool)) : new ObjectParameter("UpdateLastActivity", (object) updateLastActivity));
    }

    public ObjectResult<aspnet_Membership_GetUserByUserId_Result> aspnet_Membership_GetUserByUserId(Guid? userId, DateTime? currentTimeUtc, bool? updateLastActivity)
    {
      return this.ExecuteFunction<aspnet_Membership_GetUserByUserId_Result>("aspnet_Membership_GetUserByUserId", !userId.HasValue ? new ObjectParameter("UserId", typeof (Guid)) : new ObjectParameter("UserId", (object) userId), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), !updateLastActivity.HasValue ? new ObjectParameter("UpdateLastActivity", typeof (bool)) : new ObjectParameter("UpdateLastActivity", (object) updateLastActivity));
    }

    public int aspnet_Membership_ResetPassword(string applicationName, string userName, string newPassword, int? maxInvalidPasswordAttempts, int? passwordAttemptWindow, string passwordSalt, DateTime? currentTimeUtc, int? passwordFormat, string passwordAnswer)
    {
      return this.ExecuteFunction("aspnet_Membership_ResetPassword", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), newPassword == null ? new ObjectParameter("NewPassword", typeof (string)) : new ObjectParameter("NewPassword", (object) newPassword), !maxInvalidPasswordAttempts.HasValue ? new ObjectParameter("MaxInvalidPasswordAttempts", typeof (int)) : new ObjectParameter("MaxInvalidPasswordAttempts", (object) maxInvalidPasswordAttempts), !passwordAttemptWindow.HasValue ? new ObjectParameter("PasswordAttemptWindow", typeof (int)) : new ObjectParameter("PasswordAttemptWindow", (object) passwordAttemptWindow), passwordSalt == null ? new ObjectParameter("PasswordSalt", typeof (string)) : new ObjectParameter("PasswordSalt", (object) passwordSalt), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), !passwordFormat.HasValue ? new ObjectParameter("PasswordFormat", typeof (int)) : new ObjectParameter("PasswordFormat", (object) passwordFormat), passwordAnswer == null ? new ObjectParameter("PasswordAnswer", typeof (string)) : new ObjectParameter("PasswordAnswer", (object) passwordAnswer));
    }

    public int aspnet_Membership_SetPassword(string applicationName, string userName, string newPassword, string passwordSalt, DateTime? currentTimeUtc, int? passwordFormat)
    {
      return this.ExecuteFunction("aspnet_Membership_SetPassword", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), newPassword == null ? new ObjectParameter("NewPassword", typeof (string)) : new ObjectParameter("NewPassword", (object) newPassword), passwordSalt == null ? new ObjectParameter("PasswordSalt", typeof (string)) : new ObjectParameter("PasswordSalt", (object) passwordSalt), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), !passwordFormat.HasValue ? new ObjectParameter("PasswordFormat", typeof (int)) : new ObjectParameter("PasswordFormat", (object) passwordFormat));
    }

    public int aspnet_Membership_UnlockUser(string applicationName, string userName)
    {
      return this.ExecuteFunction("aspnet_Membership_UnlockUser", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName)
      });
    }

    public int aspnet_Membership_UpdateUser(string applicationName, string userName, string email, string comment, bool? isApproved, DateTime? lastLoginDate, DateTime? lastActivityDate, int? uniqueEmail, DateTime? currentTimeUtc)
    {
      return this.ExecuteFunction("aspnet_Membership_UpdateUser", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), email == null ? new ObjectParameter("Email", typeof (string)) : new ObjectParameter("Email", (object) email), comment == null ? new ObjectParameter("Comment", typeof (string)) : new ObjectParameter("Comment", (object) comment), !isApproved.HasValue ? new ObjectParameter("IsApproved", typeof (bool)) : new ObjectParameter("IsApproved", (object) isApproved), !lastLoginDate.HasValue ? new ObjectParameter("LastLoginDate", typeof (DateTime)) : new ObjectParameter("LastLoginDate", (object) lastLoginDate), !lastActivityDate.HasValue ? new ObjectParameter("LastActivityDate", typeof (DateTime)) : new ObjectParameter("LastActivityDate", (object) lastActivityDate), !uniqueEmail.HasValue ? new ObjectParameter("UniqueEmail", typeof (int)) : new ObjectParameter("UniqueEmail", (object) uniqueEmail), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc));
    }

    public int aspnet_Membership_UpdateUserInfo(string applicationName, string userName, bool? isPasswordCorrect, bool? updateLastLoginActivityDate, int? maxInvalidPasswordAttempts, int? passwordAttemptWindow, DateTime? currentTimeUtc, DateTime? lastLoginDate, DateTime? lastActivityDate)
    {
      return this.ExecuteFunction("aspnet_Membership_UpdateUserInfo", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !isPasswordCorrect.HasValue ? new ObjectParameter("IsPasswordCorrect", typeof (bool)) : new ObjectParameter("IsPasswordCorrect", (object) isPasswordCorrect), !updateLastLoginActivityDate.HasValue ? new ObjectParameter("UpdateLastLoginActivityDate", typeof (bool)) : new ObjectParameter("UpdateLastLoginActivityDate", (object) updateLastLoginActivityDate), !maxInvalidPasswordAttempts.HasValue ? new ObjectParameter("MaxInvalidPasswordAttempts", typeof (int)) : new ObjectParameter("MaxInvalidPasswordAttempts", (object) maxInvalidPasswordAttempts), !passwordAttemptWindow.HasValue ? new ObjectParameter("PasswordAttemptWindow", typeof (int)) : new ObjectParameter("PasswordAttemptWindow", (object) passwordAttemptWindow), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), !lastLoginDate.HasValue ? new ObjectParameter("LastLoginDate", typeof (DateTime)) : new ObjectParameter("LastLoginDate", (object) lastLoginDate), !lastActivityDate.HasValue ? new ObjectParameter("LastActivityDate", typeof (DateTime)) : new ObjectParameter("LastActivityDate", (object) lastActivityDate));
    }

    public ObjectResult<int?> aspnet_Profile_DeleteInactiveProfiles(string applicationName, int? profileAuthOptions, DateTime? inactiveSinceDate)
    {
      return this.ExecuteFunction<int?>("aspnet_Profile_DeleteInactiveProfiles", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), !profileAuthOptions.HasValue ? new ObjectParameter("ProfileAuthOptions", typeof (int)) : new ObjectParameter("ProfileAuthOptions", (object) profileAuthOptions), !inactiveSinceDate.HasValue ? new ObjectParameter("InactiveSinceDate", typeof (DateTime)) : new ObjectParameter("InactiveSinceDate", (object) inactiveSinceDate));
    }

    public int aspnet_Profile_DeleteProfiles(string applicationName, string userNames)
    {
      return this.ExecuteFunction("aspnet_Profile_DeleteProfiles", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        userNames == null ? new ObjectParameter("UserNames", typeof (string)) : new ObjectParameter("UserNames", (object) userNames)
      });
    }

    public ObjectResult<int?> aspnet_Profile_GetNumberOfInactiveProfiles(string applicationName, int? profileAuthOptions, DateTime? inactiveSinceDate)
    {
      return this.ExecuteFunction<int?>("aspnet_Profile_GetNumberOfInactiveProfiles", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), !profileAuthOptions.HasValue ? new ObjectParameter("ProfileAuthOptions", typeof (int)) : new ObjectParameter("ProfileAuthOptions", (object) profileAuthOptions), !inactiveSinceDate.HasValue ? new ObjectParameter("InactiveSinceDate", typeof (DateTime)) : new ObjectParameter("InactiveSinceDate", (object) inactiveSinceDate));
    }

    public int aspnet_Profile_GetProfiles(string applicationName, int? profileAuthOptions, int? pageIndex, int? pageSize, string userNameToMatch, DateTime? inactiveSinceDate)
    {
      return this.ExecuteFunction("aspnet_Profile_GetProfiles", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), !profileAuthOptions.HasValue ? new ObjectParameter("ProfileAuthOptions", typeof (int)) : new ObjectParameter("ProfileAuthOptions", (object) profileAuthOptions), !pageIndex.HasValue ? new ObjectParameter("PageIndex", typeof (int)) : new ObjectParameter("PageIndex", (object) pageIndex), !pageSize.HasValue ? new ObjectParameter("PageSize", typeof (int)) : new ObjectParameter("PageSize", (object) pageSize), userNameToMatch == null ? new ObjectParameter("UserNameToMatch", typeof (string)) : new ObjectParameter("UserNameToMatch", (object) userNameToMatch), !inactiveSinceDate.HasValue ? new ObjectParameter("InactiveSinceDate", typeof (DateTime)) : new ObjectParameter("InactiveSinceDate", (object) inactiveSinceDate));
    }

    public ObjectResult<aspnet_Profile_GetProperties_Result> aspnet_Profile_GetProperties(string applicationName, string userName, DateTime? currentTimeUtc)
    {
      return this.ExecuteFunction<aspnet_Profile_GetProperties_Result>("aspnet_Profile_GetProperties", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc));
    }

    public int aspnet_Profile_SetProperties(string applicationName, string propertyNames, string propertyValuesString, byte[] propertyValuesBinary, string userName, bool? isUserAnonymous, DateTime? currentTimeUtc)
    {
      return this.ExecuteFunction("aspnet_Profile_SetProperties", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), propertyNames == null ? new ObjectParameter("PropertyNames", typeof (string)) : new ObjectParameter("PropertyNames", (object) propertyNames), propertyValuesString == null ? new ObjectParameter("PropertyValuesString", typeof (string)) : new ObjectParameter("PropertyValuesString", (object) propertyValuesString), propertyValuesBinary == null ? new ObjectParameter("PropertyValuesBinary", typeof (byte[])) : new ObjectParameter("PropertyValuesBinary", (object) propertyValuesBinary), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !isUserAnonymous.HasValue ? new ObjectParameter("IsUserAnonymous", typeof (bool)) : new ObjectParameter("IsUserAnonymous", (object) isUserAnonymous), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc));
    }

    public int aspnet_RegisterSchemaVersion(string feature, string compatibleSchemaVersion, bool? isCurrentVersion, bool? removeIncompatibleSchema)
    {
      return this.ExecuteFunction("aspnet_RegisterSchemaVersion", feature == null ? new ObjectParameter("Feature", typeof (string)) : new ObjectParameter("Feature", (object) feature), compatibleSchemaVersion == null ? new ObjectParameter("CompatibleSchemaVersion", typeof (string)) : new ObjectParameter("CompatibleSchemaVersion", (object) compatibleSchemaVersion), !isCurrentVersion.HasValue ? new ObjectParameter("IsCurrentVersion", typeof (bool)) : new ObjectParameter("IsCurrentVersion", (object) isCurrentVersion), !removeIncompatibleSchema.HasValue ? new ObjectParameter("RemoveIncompatibleSchema", typeof (bool)) : new ObjectParameter("RemoveIncompatibleSchema", (object) removeIncompatibleSchema));
    }

    public int aspnet_Roles_CreateRole(string applicationName, string roleName)
    {
      return this.ExecuteFunction("aspnet_Roles_CreateRole", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        roleName == null ? new ObjectParameter("RoleName", typeof (string)) : new ObjectParameter("RoleName", (object) roleName)
      });
    }

    public int aspnet_Roles_DeleteRole(string applicationName, string roleName, bool? deleteOnlyIfRoleIsEmpty)
    {
      return this.ExecuteFunction("aspnet_Roles_DeleteRole", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), roleName == null ? new ObjectParameter("RoleName", typeof (string)) : new ObjectParameter("RoleName", (object) roleName), !deleteOnlyIfRoleIsEmpty.HasValue ? new ObjectParameter("DeleteOnlyIfRoleIsEmpty", typeof (bool)) : new ObjectParameter("DeleteOnlyIfRoleIsEmpty", (object) deleteOnlyIfRoleIsEmpty));
    }

    public ObjectResult<string> aspnet_Roles_GetAllRoles(string applicationName)
    {
      return this.ExecuteFunction<string>("aspnet_Roles_GetAllRoles", new ObjectParameter[1]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName)
      });
    }

    public int aspnet_Roles_RoleExists(string applicationName, string roleName)
    {
      return this.ExecuteFunction("aspnet_Roles_RoleExists", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        roleName == null ? new ObjectParameter("RoleName", typeof (string)) : new ObjectParameter("RoleName", (object) roleName)
      });
    }

    public int aspnet_Setup_RemoveAllRoleMembers(string name)
    {
      return this.ExecuteFunction("aspnet_Setup_RemoveAllRoleMembers", new ObjectParameter[1]
      {
        name == null ? new ObjectParameter("name", typeof (string)) : new ObjectParameter("name", (object) name)
      });
    }

    public int aspnet_Setup_RestorePermissions(string name)
    {
      return this.ExecuteFunction("aspnet_Setup_RestorePermissions", new ObjectParameter[1]
      {
        name == null ? new ObjectParameter("name", typeof (string)) : new ObjectParameter("name", (object) name)
      });
    }

    public int aspnet_UnRegisterSchemaVersion(string feature, string compatibleSchemaVersion)
    {
      return this.ExecuteFunction("aspnet_UnRegisterSchemaVersion", new ObjectParameter[2]
      {
        feature == null ? new ObjectParameter("Feature", typeof (string)) : new ObjectParameter("Feature", (object) feature),
        compatibleSchemaVersion == null ? new ObjectParameter("CompatibleSchemaVersion", typeof (string)) : new ObjectParameter("CompatibleSchemaVersion", (object) compatibleSchemaVersion)
      });
    }

    public int aspnet_Users_CreateUser(Guid? applicationId, string userName, bool? isUserAnonymous, DateTime? lastActivityDate, ObjectParameter userId)
    {
      return this.ExecuteFunction("aspnet_Users_CreateUser", !applicationId.HasValue ? new ObjectParameter("ApplicationId", typeof (Guid)) : new ObjectParameter("ApplicationId", (object) applicationId), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !isUserAnonymous.HasValue ? new ObjectParameter("IsUserAnonymous", typeof (bool)) : new ObjectParameter("IsUserAnonymous", (object) isUserAnonymous), !lastActivityDate.HasValue ? new ObjectParameter("LastActivityDate", typeof (DateTime)) : new ObjectParameter("LastActivityDate", (object) lastActivityDate), userId);
    }

    public int aspnet_Users_DeleteUser(string applicationName, string userName, int? tablesToDeleteFrom, ObjectParameter numTablesDeletedFrom)
    {
      return this.ExecuteFunction("aspnet_Users_DeleteUser", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !tablesToDeleteFrom.HasValue ? new ObjectParameter("TablesToDeleteFrom", typeof (int)) : new ObjectParameter("TablesToDeleteFrom", (object) tablesToDeleteFrom), numTablesDeletedFrom);
    }

    public ObjectResult<string> aspnet_UsersInRoles_AddUsersToRoles(string applicationName, string userNames, string roleNames, DateTime? currentTimeUtc)
    {
      return this.ExecuteFunction<string>("aspnet_UsersInRoles_AddUsersToRoles", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userNames == null ? new ObjectParameter("UserNames", typeof (string)) : new ObjectParameter("UserNames", (object) userNames), roleNames == null ? new ObjectParameter("RoleNames", typeof (string)) : new ObjectParameter("RoleNames", (object) roleNames), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc));
    }

    public ObjectResult<string> aspnet_UsersInRoles_FindUsersInRole(string applicationName, string roleName, string userNameToMatch)
    {
      return this.ExecuteFunction<string>("aspnet_UsersInRoles_FindUsersInRole", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), roleName == null ? new ObjectParameter("RoleName", typeof (string)) : new ObjectParameter("RoleName", (object) roleName), userNameToMatch == null ? new ObjectParameter("UserNameToMatch", typeof (string)) : new ObjectParameter("UserNameToMatch", (object) userNameToMatch));
    }

    public ObjectResult<string> aspnet_UsersInRoles_GetRolesForUser(string applicationName, string userName)
    {
      return this.ExecuteFunction<string>("aspnet_UsersInRoles_GetRolesForUser", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName)
      });
    }

    public ObjectResult<string> aspnet_UsersInRoles_GetUsersInRoles(string applicationName, string roleName)
    {
      return this.ExecuteFunction<string>("aspnet_UsersInRoles_GetUsersInRoles", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        roleName == null ? new ObjectParameter("RoleName", typeof (string)) : new ObjectParameter("RoleName", (object) roleName)
      });
    }

    public int aspnet_UsersInRoles_IsUserInRole(string applicationName, string userName, string roleName)
    {
      return this.ExecuteFunction("aspnet_UsersInRoles_IsUserInRole", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), roleName == null ? new ObjectParameter("RoleName", typeof (string)) : new ObjectParameter("RoleName", (object) roleName));
    }

    public ObjectResult<aspnet_UsersInRoles_RemoveUsersFromRoles_Result> aspnet_UsersInRoles_RemoveUsersFromRoles(string applicationName, string userNames, string roleNames)
    {
      return this.ExecuteFunction<aspnet_UsersInRoles_RemoveUsersFromRoles_Result>("aspnet_UsersInRoles_RemoveUsersFromRoles", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userNames == null ? new ObjectParameter("UserNames", typeof (string)) : new ObjectParameter("UserNames", (object) userNames), roleNames == null ? new ObjectParameter("RoleNames", typeof (string)) : new ObjectParameter("RoleNames", (object) roleNames));
    }

    public ObjectResult<string> aspnet_AnyDataInTables1(int? tablesToCheck)
    {
      return this.ExecuteFunction<string>("aspnet_AnyDataInTables1", new ObjectParameter[1]
      {
        !tablesToCheck.HasValue ? new ObjectParameter("TablesToCheck", typeof (int)) : new ObjectParameter("TablesToCheck", (object) tablesToCheck)
      });
    }

    public int aspnet_Applications_CreateApplication1(string applicationName, ObjectParameter applicationId)
    {
      return this.ExecuteFunction("aspnet_Applications_CreateApplication1", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        applicationId
      });
    }

    public int aspnet_CheckSchemaVersion1(string feature, string compatibleSchemaVersion)
    {
      return this.ExecuteFunction("aspnet_CheckSchemaVersion1", new ObjectParameter[2]
      {
        feature == null ? new ObjectParameter("Feature", typeof (string)) : new ObjectParameter("Feature", (object) feature),
        compatibleSchemaVersion == null ? new ObjectParameter("CompatibleSchemaVersion", typeof (string)) : new ObjectParameter("CompatibleSchemaVersion", (object) compatibleSchemaVersion)
      });
    }

    public int aspnet_Membership_ChangePasswordQuestionAndAnswer1(string applicationName, string userName, string newPasswordQuestion, string newPasswordAnswer)
    {
      return this.ExecuteFunction("aspnet_Membership_ChangePasswordQuestionAndAnswer1", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), newPasswordQuestion == null ? new ObjectParameter("NewPasswordQuestion", typeof (string)) : new ObjectParameter("NewPasswordQuestion", (object) newPasswordQuestion), newPasswordAnswer == null ? new ObjectParameter("NewPasswordAnswer", typeof (string)) : new ObjectParameter("NewPasswordAnswer", (object) newPasswordAnswer));
    }

    public int aspnet_Membership_CreateUser1(string applicationName, string userName, string password, string passwordSalt, string email, string passwordQuestion, string passwordAnswer, bool? isApproved, DateTime? currentTimeUtc, DateTime? createDate, int? uniqueEmail, int? passwordFormat, ObjectParameter userId)
    {
      return this.ExecuteFunction("aspnet_Membership_CreateUser1", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), password == null ? new ObjectParameter("Password", typeof (string)) : new ObjectParameter("Password", (object) password), passwordSalt == null ? new ObjectParameter("PasswordSalt", typeof (string)) : new ObjectParameter("PasswordSalt", (object) passwordSalt), email == null ? new ObjectParameter("Email", typeof (string)) : new ObjectParameter("Email", (object) email), passwordQuestion == null ? new ObjectParameter("PasswordQuestion", typeof (string)) : new ObjectParameter("PasswordQuestion", (object) passwordQuestion), passwordAnswer == null ? new ObjectParameter("PasswordAnswer", typeof (string)) : new ObjectParameter("PasswordAnswer", (object) passwordAnswer), !isApproved.HasValue ? new ObjectParameter("IsApproved", typeof (bool)) : new ObjectParameter("IsApproved", (object) isApproved), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), !createDate.HasValue ? new ObjectParameter("CreateDate", typeof (DateTime)) : new ObjectParameter("CreateDate", (object) createDate), !uniqueEmail.HasValue ? new ObjectParameter("UniqueEmail", typeof (int)) : new ObjectParameter("UniqueEmail", (object) uniqueEmail), !passwordFormat.HasValue ? new ObjectParameter("PasswordFormat", typeof (int)) : new ObjectParameter("PasswordFormat", (object) passwordFormat), userId);
    }

    public int aspnet_Membership_FindUsersByEmail1(string applicationName, string emailToMatch, int? pageIndex, int? pageSize)
    {
      return this.ExecuteFunction("aspnet_Membership_FindUsersByEmail1", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), emailToMatch == null ? new ObjectParameter("EmailToMatch", typeof (string)) : new ObjectParameter("EmailToMatch", (object) emailToMatch), !pageIndex.HasValue ? new ObjectParameter("PageIndex", typeof (int)) : new ObjectParameter("PageIndex", (object) pageIndex), !pageSize.HasValue ? new ObjectParameter("PageSize", typeof (int)) : new ObjectParameter("PageSize", (object) pageSize));
    }

    public int aspnet_Membership_FindUsersByName1(string applicationName, string userNameToMatch, int? pageIndex, int? pageSize)
    {
      return this.ExecuteFunction("aspnet_Membership_FindUsersByName1", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userNameToMatch == null ? new ObjectParameter("UserNameToMatch", typeof (string)) : new ObjectParameter("UserNameToMatch", (object) userNameToMatch), !pageIndex.HasValue ? new ObjectParameter("PageIndex", typeof (int)) : new ObjectParameter("PageIndex", (object) pageIndex), !pageSize.HasValue ? new ObjectParameter("PageSize", typeof (int)) : new ObjectParameter("PageSize", (object) pageSize));
    }

    public int aspnet_Membership_GetAllUsers1(string applicationName, int? pageIndex, int? pageSize)
    {
      return this.ExecuteFunction("aspnet_Membership_GetAllUsers1", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), !pageIndex.HasValue ? new ObjectParameter("PageIndex", typeof (int)) : new ObjectParameter("PageIndex", (object) pageIndex), !pageSize.HasValue ? new ObjectParameter("PageSize", typeof (int)) : new ObjectParameter("PageSize", (object) pageSize));
    }

    public int aspnet_Membership_GetNumberOfUsersOnline1(string applicationName, int? minutesSinceLastInActive, DateTime? currentTimeUtc)
    {
      return this.ExecuteFunction("aspnet_Membership_GetNumberOfUsersOnline1", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), !minutesSinceLastInActive.HasValue ? new ObjectParameter("MinutesSinceLastInActive", typeof (int)) : new ObjectParameter("MinutesSinceLastInActive", (object) minutesSinceLastInActive), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc));
    }

    public ObjectResult<aspnet_Membership_GetPassword1_Result> aspnet_Membership_GetPassword1(string applicationName, string userName, int? maxInvalidPasswordAttempts, int? passwordAttemptWindow, DateTime? currentTimeUtc, string passwordAnswer)
    {
      return this.ExecuteFunction<aspnet_Membership_GetPassword1_Result>("aspnet_Membership_GetPassword1", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !maxInvalidPasswordAttempts.HasValue ? new ObjectParameter("MaxInvalidPasswordAttempts", typeof (int)) : new ObjectParameter("MaxInvalidPasswordAttempts", (object) maxInvalidPasswordAttempts), !passwordAttemptWindow.HasValue ? new ObjectParameter("PasswordAttemptWindow", typeof (int)) : new ObjectParameter("PasswordAttemptWindow", (object) passwordAttemptWindow), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), passwordAnswer == null ? new ObjectParameter("PasswordAnswer", typeof (string)) : new ObjectParameter("PasswordAnswer", (object) passwordAnswer));
    }

    public ObjectResult<aspnet_Membership_GetPasswordWithFormat1_Result> aspnet_Membership_GetPasswordWithFormat1(string applicationName, string userName, bool? updateLastLoginActivityDate, DateTime? currentTimeUtc)
    {
      return this.ExecuteFunction<aspnet_Membership_GetPasswordWithFormat1_Result>("aspnet_Membership_GetPasswordWithFormat1", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !updateLastLoginActivityDate.HasValue ? new ObjectParameter("UpdateLastLoginActivityDate", typeof (bool)) : new ObjectParameter("UpdateLastLoginActivityDate", (object) updateLastLoginActivityDate), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc));
    }

    public ObjectResult<string> aspnet_Membership_GetUserByEmail1(string applicationName, string email)
    {
      return this.ExecuteFunction<string>("aspnet_Membership_GetUserByEmail1", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        email == null ? new ObjectParameter("Email", typeof (string)) : new ObjectParameter("Email", (object) email)
      });
    }

    public ObjectResult<aspnet_Membership_GetUserByName1_Result> aspnet_Membership_GetUserByName1(string applicationName, string userName, DateTime? currentTimeUtc, bool? updateLastActivity)
    {
      return this.ExecuteFunction<aspnet_Membership_GetUserByName1_Result>("aspnet_Membership_GetUserByName1", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), !updateLastActivity.HasValue ? new ObjectParameter("UpdateLastActivity", typeof (bool)) : new ObjectParameter("UpdateLastActivity", (object) updateLastActivity));
    }

    public ObjectResult<aspnet_Membership_GetUserByUserId1_Result> aspnet_Membership_GetUserByUserId1(Guid? userId, DateTime? currentTimeUtc, bool? updateLastActivity)
    {
      return this.ExecuteFunction<aspnet_Membership_GetUserByUserId1_Result>("aspnet_Membership_GetUserByUserId1", !userId.HasValue ? new ObjectParameter("UserId", typeof (Guid)) : new ObjectParameter("UserId", (object) userId), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), !updateLastActivity.HasValue ? new ObjectParameter("UpdateLastActivity", typeof (bool)) : new ObjectParameter("UpdateLastActivity", (object) updateLastActivity));
    }

    public int aspnet_Membership_ResetPassword1(string applicationName, string userName, string newPassword, int? maxInvalidPasswordAttempts, int? passwordAttemptWindow, string passwordSalt, DateTime? currentTimeUtc, int? passwordFormat, string passwordAnswer)
    {
      return this.ExecuteFunction("aspnet_Membership_ResetPassword1", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), newPassword == null ? new ObjectParameter("NewPassword", typeof (string)) : new ObjectParameter("NewPassword", (object) newPassword), !maxInvalidPasswordAttempts.HasValue ? new ObjectParameter("MaxInvalidPasswordAttempts", typeof (int)) : new ObjectParameter("MaxInvalidPasswordAttempts", (object) maxInvalidPasswordAttempts), !passwordAttemptWindow.HasValue ? new ObjectParameter("PasswordAttemptWindow", typeof (int)) : new ObjectParameter("PasswordAttemptWindow", (object) passwordAttemptWindow), passwordSalt == null ? new ObjectParameter("PasswordSalt", typeof (string)) : new ObjectParameter("PasswordSalt", (object) passwordSalt), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), !passwordFormat.HasValue ? new ObjectParameter("PasswordFormat", typeof (int)) : new ObjectParameter("PasswordFormat", (object) passwordFormat), passwordAnswer == null ? new ObjectParameter("PasswordAnswer", typeof (string)) : new ObjectParameter("PasswordAnswer", (object) passwordAnswer));
    }

    public int aspnet_Membership_SetPassword1(string applicationName, string userName, string newPassword, string passwordSalt, DateTime? currentTimeUtc, int? passwordFormat)
    {
      return this.ExecuteFunction("aspnet_Membership_SetPassword1", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), newPassword == null ? new ObjectParameter("NewPassword", typeof (string)) : new ObjectParameter("NewPassword", (object) newPassword), passwordSalt == null ? new ObjectParameter("PasswordSalt", typeof (string)) : new ObjectParameter("PasswordSalt", (object) passwordSalt), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), !passwordFormat.HasValue ? new ObjectParameter("PasswordFormat", typeof (int)) : new ObjectParameter("PasswordFormat", (object) passwordFormat));
    }

    public int aspnet_Membership_UnlockUser1(string applicationName, string userName)
    {
      return this.ExecuteFunction("aspnet_Membership_UnlockUser1", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName)
      });
    }

    public int aspnet_Membership_UpdateUser1(string applicationName, string userName, string email, string comment, bool? isApproved, DateTime? lastLoginDate, DateTime? lastActivityDate, int? uniqueEmail, DateTime? currentTimeUtc)
    {
      return this.ExecuteFunction("aspnet_Membership_UpdateUser1", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), email == null ? new ObjectParameter("Email", typeof (string)) : new ObjectParameter("Email", (object) email), comment == null ? new ObjectParameter("Comment", typeof (string)) : new ObjectParameter("Comment", (object) comment), !isApproved.HasValue ? new ObjectParameter("IsApproved", typeof (bool)) : new ObjectParameter("IsApproved", (object) isApproved), !lastLoginDate.HasValue ? new ObjectParameter("LastLoginDate", typeof (DateTime)) : new ObjectParameter("LastLoginDate", (object) lastLoginDate), !lastActivityDate.HasValue ? new ObjectParameter("LastActivityDate", typeof (DateTime)) : new ObjectParameter("LastActivityDate", (object) lastActivityDate), !uniqueEmail.HasValue ? new ObjectParameter("UniqueEmail", typeof (int)) : new ObjectParameter("UniqueEmail", (object) uniqueEmail), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc));
    }

    public int aspnet_Membership_UpdateUserInfo1(string applicationName, string userName, bool? isPasswordCorrect, bool? updateLastLoginActivityDate, int? maxInvalidPasswordAttempts, int? passwordAttemptWindow, DateTime? currentTimeUtc, DateTime? lastLoginDate, DateTime? lastActivityDate)
    {
      return this.ExecuteFunction("aspnet_Membership_UpdateUserInfo1", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !isPasswordCorrect.HasValue ? new ObjectParameter("IsPasswordCorrect", typeof (bool)) : new ObjectParameter("IsPasswordCorrect", (object) isPasswordCorrect), !updateLastLoginActivityDate.HasValue ? new ObjectParameter("UpdateLastLoginActivityDate", typeof (bool)) : new ObjectParameter("UpdateLastLoginActivityDate", (object) updateLastLoginActivityDate), !maxInvalidPasswordAttempts.HasValue ? new ObjectParameter("MaxInvalidPasswordAttempts", typeof (int)) : new ObjectParameter("MaxInvalidPasswordAttempts", (object) maxInvalidPasswordAttempts), !passwordAttemptWindow.HasValue ? new ObjectParameter("PasswordAttemptWindow", typeof (int)) : new ObjectParameter("PasswordAttemptWindow", (object) passwordAttemptWindow), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), !lastLoginDate.HasValue ? new ObjectParameter("LastLoginDate", typeof (DateTime)) : new ObjectParameter("LastLoginDate", (object) lastLoginDate), !lastActivityDate.HasValue ? new ObjectParameter("LastActivityDate", typeof (DateTime)) : new ObjectParameter("LastActivityDate", (object) lastActivityDate));
    }

    public ObjectResult<int?> aspnet_Profile_DeleteInactiveProfiles1(string applicationName, int? profileAuthOptions, DateTime? inactiveSinceDate)
    {
      return this.ExecuteFunction<int?>("aspnet_Profile_DeleteInactiveProfiles1", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), !profileAuthOptions.HasValue ? new ObjectParameter("ProfileAuthOptions", typeof (int)) : new ObjectParameter("ProfileAuthOptions", (object) profileAuthOptions), !inactiveSinceDate.HasValue ? new ObjectParameter("InactiveSinceDate", typeof (DateTime)) : new ObjectParameter("InactiveSinceDate", (object) inactiveSinceDate));
    }

    public int aspnet_Profile_DeleteProfiles1(string applicationName, string userNames)
    {
      return this.ExecuteFunction("aspnet_Profile_DeleteProfiles1", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        userNames == null ? new ObjectParameter("UserNames", typeof (string)) : new ObjectParameter("UserNames", (object) userNames)
      });
    }

    public ObjectResult<int?> aspnet_Profile_GetNumberOfInactiveProfiles1(string applicationName, int? profileAuthOptions, DateTime? inactiveSinceDate)
    {
      return this.ExecuteFunction<int?>("aspnet_Profile_GetNumberOfInactiveProfiles1", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), !profileAuthOptions.HasValue ? new ObjectParameter("ProfileAuthOptions", typeof (int)) : new ObjectParameter("ProfileAuthOptions", (object) profileAuthOptions), !inactiveSinceDate.HasValue ? new ObjectParameter("InactiveSinceDate", typeof (DateTime)) : new ObjectParameter("InactiveSinceDate", (object) inactiveSinceDate));
    }

    public int aspnet_Profile_GetProfiles1(string applicationName, int? profileAuthOptions, int? pageIndex, int? pageSize, string userNameToMatch, DateTime? inactiveSinceDate)
    {
      return this.ExecuteFunction("aspnet_Profile_GetProfiles1", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), !profileAuthOptions.HasValue ? new ObjectParameter("ProfileAuthOptions", typeof (int)) : new ObjectParameter("ProfileAuthOptions", (object) profileAuthOptions), !pageIndex.HasValue ? new ObjectParameter("PageIndex", typeof (int)) : new ObjectParameter("PageIndex", (object) pageIndex), !pageSize.HasValue ? new ObjectParameter("PageSize", typeof (int)) : new ObjectParameter("PageSize", (object) pageSize), userNameToMatch == null ? new ObjectParameter("UserNameToMatch", typeof (string)) : new ObjectParameter("UserNameToMatch", (object) userNameToMatch), !inactiveSinceDate.HasValue ? new ObjectParameter("InactiveSinceDate", typeof (DateTime)) : new ObjectParameter("InactiveSinceDate", (object) inactiveSinceDate));
    }

    public ObjectResult<aspnet_Profile_GetProperties1_Result> aspnet_Profile_GetProperties1(string applicationName, string userName, DateTime? currentTimeUtc)
    {
      return this.ExecuteFunction<aspnet_Profile_GetProperties1_Result>("aspnet_Profile_GetProperties1", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc));
    }

    public int aspnet_Profile_SetProperties1(string applicationName, string propertyNames, string propertyValuesString, byte[] propertyValuesBinary, string userName, bool? isUserAnonymous, DateTime? currentTimeUtc)
    {
      return this.ExecuteFunction("aspnet_Profile_SetProperties1", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), propertyNames == null ? new ObjectParameter("PropertyNames", typeof (string)) : new ObjectParameter("PropertyNames", (object) propertyNames), propertyValuesString == null ? new ObjectParameter("PropertyValuesString", typeof (string)) : new ObjectParameter("PropertyValuesString", (object) propertyValuesString), propertyValuesBinary == null ? new ObjectParameter("PropertyValuesBinary", typeof (byte[])) : new ObjectParameter("PropertyValuesBinary", (object) propertyValuesBinary), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !isUserAnonymous.HasValue ? new ObjectParameter("IsUserAnonymous", typeof (bool)) : new ObjectParameter("IsUserAnonymous", (object) isUserAnonymous), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc));
    }

    public int aspnet_RegisterSchemaVersion1(string feature, string compatibleSchemaVersion, bool? isCurrentVersion, bool? removeIncompatibleSchema)
    {
      return this.ExecuteFunction("aspnet_RegisterSchemaVersion1", feature == null ? new ObjectParameter("Feature", typeof (string)) : new ObjectParameter("Feature", (object) feature), compatibleSchemaVersion == null ? new ObjectParameter("CompatibleSchemaVersion", typeof (string)) : new ObjectParameter("CompatibleSchemaVersion", (object) compatibleSchemaVersion), !isCurrentVersion.HasValue ? new ObjectParameter("IsCurrentVersion", typeof (bool)) : new ObjectParameter("IsCurrentVersion", (object) isCurrentVersion), !removeIncompatibleSchema.HasValue ? new ObjectParameter("RemoveIncompatibleSchema", typeof (bool)) : new ObjectParameter("RemoveIncompatibleSchema", (object) removeIncompatibleSchema));
    }

    public int aspnet_Roles_CreateRole1(string applicationName, string roleName)
    {
      return this.ExecuteFunction("aspnet_Roles_CreateRole1", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        roleName == null ? new ObjectParameter("RoleName", typeof (string)) : new ObjectParameter("RoleName", (object) roleName)
      });
    }

    public int aspnet_Roles_DeleteRole1(string applicationName, string roleName, bool? deleteOnlyIfRoleIsEmpty)
    {
      return this.ExecuteFunction("aspnet_Roles_DeleteRole1", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), roleName == null ? new ObjectParameter("RoleName", typeof (string)) : new ObjectParameter("RoleName", (object) roleName), !deleteOnlyIfRoleIsEmpty.HasValue ? new ObjectParameter("DeleteOnlyIfRoleIsEmpty", typeof (bool)) : new ObjectParameter("DeleteOnlyIfRoleIsEmpty", (object) deleteOnlyIfRoleIsEmpty));
    }

    public ObjectResult<string> aspnet_Roles_GetAllRoles1(string applicationName)
    {
      return this.ExecuteFunction<string>("aspnet_Roles_GetAllRoles1", new ObjectParameter[1]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName)
      });
    }

    public int aspnet_Roles_RoleExists1(string applicationName, string roleName)
    {
      return this.ExecuteFunction("aspnet_Roles_RoleExists1", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        roleName == null ? new ObjectParameter("RoleName", typeof (string)) : new ObjectParameter("RoleName", (object) roleName)
      });
    }

    public int aspnet_Setup_RemoveAllRoleMembers1(string name)
    {
      return this.ExecuteFunction("aspnet_Setup_RemoveAllRoleMembers1", new ObjectParameter[1]
      {
        name == null ? new ObjectParameter("name", typeof (string)) : new ObjectParameter("name", (object) name)
      });
    }

    public int aspnet_Setup_RestorePermissions1(string name)
    {
      return this.ExecuteFunction("aspnet_Setup_RestorePermissions1", new ObjectParameter[1]
      {
        name == null ? new ObjectParameter("name", typeof (string)) : new ObjectParameter("name", (object) name)
      });
    }

    public int aspnet_UnRegisterSchemaVersion1(string feature, string compatibleSchemaVersion)
    {
      return this.ExecuteFunction("aspnet_UnRegisterSchemaVersion1", new ObjectParameter[2]
      {
        feature == null ? new ObjectParameter("Feature", typeof (string)) : new ObjectParameter("Feature", (object) feature),
        compatibleSchemaVersion == null ? new ObjectParameter("CompatibleSchemaVersion", typeof (string)) : new ObjectParameter("CompatibleSchemaVersion", (object) compatibleSchemaVersion)
      });
    }

    public int aspnet_Users_CreateUser1(Guid? applicationId, string userName, bool? isUserAnonymous, DateTime? lastActivityDate, ObjectParameter userId)
    {
      return this.ExecuteFunction("aspnet_Users_CreateUser1", !applicationId.HasValue ? new ObjectParameter("ApplicationId", typeof (Guid)) : new ObjectParameter("ApplicationId", (object) applicationId), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !isUserAnonymous.HasValue ? new ObjectParameter("IsUserAnonymous", typeof (bool)) : new ObjectParameter("IsUserAnonymous", (object) isUserAnonymous), !lastActivityDate.HasValue ? new ObjectParameter("LastActivityDate", typeof (DateTime)) : new ObjectParameter("LastActivityDate", (object) lastActivityDate), userId);
    }

    public int aspnet_Users_DeleteUser1(string applicationName, string userName, int? tablesToDeleteFrom, ObjectParameter numTablesDeletedFrom)
    {
      return this.ExecuteFunction("aspnet_Users_DeleteUser1", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !tablesToDeleteFrom.HasValue ? new ObjectParameter("TablesToDeleteFrom", typeof (int)) : new ObjectParameter("TablesToDeleteFrom", (object) tablesToDeleteFrom), numTablesDeletedFrom);
    }

    public ObjectResult<string> aspnet_UsersInRoles_AddUsersToRoles1(string applicationName, string userNames, string roleNames, DateTime? currentTimeUtc)
    {
      return this.ExecuteFunction<string>("aspnet_UsersInRoles_AddUsersToRoles1", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userNames == null ? new ObjectParameter("UserNames", typeof (string)) : new ObjectParameter("UserNames", (object) userNames), roleNames == null ? new ObjectParameter("RoleNames", typeof (string)) : new ObjectParameter("RoleNames", (object) roleNames), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc));
    }

    public ObjectResult<string> aspnet_UsersInRoles_FindUsersInRole1(string applicationName, string roleName, string userNameToMatch)
    {
      return this.ExecuteFunction<string>("aspnet_UsersInRoles_FindUsersInRole1", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), roleName == null ? new ObjectParameter("RoleName", typeof (string)) : new ObjectParameter("RoleName", (object) roleName), userNameToMatch == null ? new ObjectParameter("UserNameToMatch", typeof (string)) : new ObjectParameter("UserNameToMatch", (object) userNameToMatch));
    }

    public ObjectResult<string> aspnet_UsersInRoles_GetRolesForUser1(string applicationName, string userName)
    {
      return this.ExecuteFunction<string>("aspnet_UsersInRoles_GetRolesForUser1", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName)
      });
    }

    public ObjectResult<string> aspnet_UsersInRoles_GetUsersInRoles1(string applicationName, string roleName)
    {
      return this.ExecuteFunction<string>("aspnet_UsersInRoles_GetUsersInRoles1", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        roleName == null ? new ObjectParameter("RoleName", typeof (string)) : new ObjectParameter("RoleName", (object) roleName)
      });
    }

    public int aspnet_UsersInRoles_IsUserInRole1(string applicationName, string userName, string roleName)
    {
      return this.ExecuteFunction("aspnet_UsersInRoles_IsUserInRole1", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), roleName == null ? new ObjectParameter("RoleName", typeof (string)) : new ObjectParameter("RoleName", (object) roleName));
    }

    public ObjectResult<aspnet_UsersInRoles_RemoveUsersFromRoles1_Result> aspnet_UsersInRoles_RemoveUsersFromRoles1(string applicationName, string userNames, string roleNames)
    {
      return this.ExecuteFunction<aspnet_UsersInRoles_RemoveUsersFromRoles1_Result>("aspnet_UsersInRoles_RemoveUsersFromRoles1", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userNames == null ? new ObjectParameter("UserNames", typeof (string)) : new ObjectParameter("UserNames", (object) userNames), roleNames == null ? new ObjectParameter("RoleNames", typeof (string)) : new ObjectParameter("RoleNames", (object) roleNames));
    }

    public ObjectResult<string> aspnet_AnyDataInTables2(int? tablesToCheck)
    {
      return this.ExecuteFunction<string>("aspnet_AnyDataInTables2", new ObjectParameter[1]
      {
        !tablesToCheck.HasValue ? new ObjectParameter("TablesToCheck", typeof (int)) : new ObjectParameter("TablesToCheck", (object) tablesToCheck)
      });
    }

    public int aspnet_Applications_CreateApplication2(string applicationName, ObjectParameter applicationId)
    {
      return this.ExecuteFunction("aspnet_Applications_CreateApplication2", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        applicationId
      });
    }

    public int aspnet_CheckSchemaVersion2(string feature, string compatibleSchemaVersion)
    {
      return this.ExecuteFunction("aspnet_CheckSchemaVersion2", new ObjectParameter[2]
      {
        feature == null ? new ObjectParameter("Feature", typeof (string)) : new ObjectParameter("Feature", (object) feature),
        compatibleSchemaVersion == null ? new ObjectParameter("CompatibleSchemaVersion", typeof (string)) : new ObjectParameter("CompatibleSchemaVersion", (object) compatibleSchemaVersion)
      });
    }

    public int aspnet_Membership_ChangePasswordQuestionAndAnswer2(string applicationName, string userName, string newPasswordQuestion, string newPasswordAnswer)
    {
      return this.ExecuteFunction("aspnet_Membership_ChangePasswordQuestionAndAnswer2", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), newPasswordQuestion == null ? new ObjectParameter("NewPasswordQuestion", typeof (string)) : new ObjectParameter("NewPasswordQuestion", (object) newPasswordQuestion), newPasswordAnswer == null ? new ObjectParameter("NewPasswordAnswer", typeof (string)) : new ObjectParameter("NewPasswordAnswer", (object) newPasswordAnswer));
    }

    public int aspnet_Membership_CreateUser2(string applicationName, string userName, string password, string passwordSalt, string email, string passwordQuestion, string passwordAnswer, bool? isApproved, DateTime? currentTimeUtc, DateTime? createDate, int? uniqueEmail, int? passwordFormat, ObjectParameter userId)
    {
      return this.ExecuteFunction("aspnet_Membership_CreateUser2", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), password == null ? new ObjectParameter("Password", typeof (string)) : new ObjectParameter("Password", (object) password), passwordSalt == null ? new ObjectParameter("PasswordSalt", typeof (string)) : new ObjectParameter("PasswordSalt", (object) passwordSalt), email == null ? new ObjectParameter("Email", typeof (string)) : new ObjectParameter("Email", (object) email), passwordQuestion == null ? new ObjectParameter("PasswordQuestion", typeof (string)) : new ObjectParameter("PasswordQuestion", (object) passwordQuestion), passwordAnswer == null ? new ObjectParameter("PasswordAnswer", typeof (string)) : new ObjectParameter("PasswordAnswer", (object) passwordAnswer), !isApproved.HasValue ? new ObjectParameter("IsApproved", typeof (bool)) : new ObjectParameter("IsApproved", (object) isApproved), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), !createDate.HasValue ? new ObjectParameter("CreateDate", typeof (DateTime)) : new ObjectParameter("CreateDate", (object) createDate), !uniqueEmail.HasValue ? new ObjectParameter("UniqueEmail", typeof (int)) : new ObjectParameter("UniqueEmail", (object) uniqueEmail), !passwordFormat.HasValue ? new ObjectParameter("PasswordFormat", typeof (int)) : new ObjectParameter("PasswordFormat", (object) passwordFormat), userId);
    }

    public int aspnet_Membership_FindUsersByEmail2(string applicationName, string emailToMatch, int? pageIndex, int? pageSize)
    {
      return this.ExecuteFunction("aspnet_Membership_FindUsersByEmail2", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), emailToMatch == null ? new ObjectParameter("EmailToMatch", typeof (string)) : new ObjectParameter("EmailToMatch", (object) emailToMatch), !pageIndex.HasValue ? new ObjectParameter("PageIndex", typeof (int)) : new ObjectParameter("PageIndex", (object) pageIndex), !pageSize.HasValue ? new ObjectParameter("PageSize", typeof (int)) : new ObjectParameter("PageSize", (object) pageSize));
    }

    public int aspnet_Membership_FindUsersByName2(string applicationName, string userNameToMatch, int? pageIndex, int? pageSize)
    {
      return this.ExecuteFunction("aspnet_Membership_FindUsersByName2", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userNameToMatch == null ? new ObjectParameter("UserNameToMatch", typeof (string)) : new ObjectParameter("UserNameToMatch", (object) userNameToMatch), !pageIndex.HasValue ? new ObjectParameter("PageIndex", typeof (int)) : new ObjectParameter("PageIndex", (object) pageIndex), !pageSize.HasValue ? new ObjectParameter("PageSize", typeof (int)) : new ObjectParameter("PageSize", (object) pageSize));
    }

    public int aspnet_Membership_GetAllUsers2(string applicationName, int? pageIndex, int? pageSize)
    {
      return this.ExecuteFunction("aspnet_Membership_GetAllUsers2", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), !pageIndex.HasValue ? new ObjectParameter("PageIndex", typeof (int)) : new ObjectParameter("PageIndex", (object) pageIndex), !pageSize.HasValue ? new ObjectParameter("PageSize", typeof (int)) : new ObjectParameter("PageSize", (object) pageSize));
    }

    public int aspnet_Membership_GetNumberOfUsersOnline2(string applicationName, int? minutesSinceLastInActive, DateTime? currentTimeUtc)
    {
      return this.ExecuteFunction("aspnet_Membership_GetNumberOfUsersOnline2", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), !minutesSinceLastInActive.HasValue ? new ObjectParameter("MinutesSinceLastInActive", typeof (int)) : new ObjectParameter("MinutesSinceLastInActive", (object) minutesSinceLastInActive), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc));
    }

    public ObjectResult<aspnet_Membership_GetPassword2_Result> aspnet_Membership_GetPassword2(string applicationName, string userName, int? maxInvalidPasswordAttempts, int? passwordAttemptWindow, DateTime? currentTimeUtc, string passwordAnswer)
    {
      return this.ExecuteFunction<aspnet_Membership_GetPassword2_Result>("aspnet_Membership_GetPassword2", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !maxInvalidPasswordAttempts.HasValue ? new ObjectParameter("MaxInvalidPasswordAttempts", typeof (int)) : new ObjectParameter("MaxInvalidPasswordAttempts", (object) maxInvalidPasswordAttempts), !passwordAttemptWindow.HasValue ? new ObjectParameter("PasswordAttemptWindow", typeof (int)) : new ObjectParameter("PasswordAttemptWindow", (object) passwordAttemptWindow), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), passwordAnswer == null ? new ObjectParameter("PasswordAnswer", typeof (string)) : new ObjectParameter("PasswordAnswer", (object) passwordAnswer));
    }

    public ObjectResult<aspnet_Membership_GetPasswordWithFormat2_Result> aspnet_Membership_GetPasswordWithFormat2(string applicationName, string userName, bool? updateLastLoginActivityDate, DateTime? currentTimeUtc)
    {
      return this.ExecuteFunction<aspnet_Membership_GetPasswordWithFormat2_Result>("aspnet_Membership_GetPasswordWithFormat2", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !updateLastLoginActivityDate.HasValue ? new ObjectParameter("UpdateLastLoginActivityDate", typeof (bool)) : new ObjectParameter("UpdateLastLoginActivityDate", (object) updateLastLoginActivityDate), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc));
    }

    public ObjectResult<string> aspnet_Membership_GetUserByEmail2(string applicationName, string email)
    {
      return this.ExecuteFunction<string>("aspnet_Membership_GetUserByEmail2", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        email == null ? new ObjectParameter("Email", typeof (string)) : new ObjectParameter("Email", (object) email)
      });
    }

    public ObjectResult<aspnet_Membership_GetUserByName2_Result> aspnet_Membership_GetUserByName2(string applicationName, string userName, DateTime? currentTimeUtc, bool? updateLastActivity)
    {
      return this.ExecuteFunction<aspnet_Membership_GetUserByName2_Result>("aspnet_Membership_GetUserByName2", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), !updateLastActivity.HasValue ? new ObjectParameter("UpdateLastActivity", typeof (bool)) : new ObjectParameter("UpdateLastActivity", (object) updateLastActivity));
    }

    public ObjectResult<aspnet_Membership_GetUserByUserId2_Result> aspnet_Membership_GetUserByUserId2(Guid? userId, DateTime? currentTimeUtc, bool? updateLastActivity)
    {
      return this.ExecuteFunction<aspnet_Membership_GetUserByUserId2_Result>("aspnet_Membership_GetUserByUserId2", !userId.HasValue ? new ObjectParameter("UserId", typeof (Guid)) : new ObjectParameter("UserId", (object) userId), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), !updateLastActivity.HasValue ? new ObjectParameter("UpdateLastActivity", typeof (bool)) : new ObjectParameter("UpdateLastActivity", (object) updateLastActivity));
    }

    public int aspnet_Membership_ResetPassword2(string applicationName, string userName, string newPassword, int? maxInvalidPasswordAttempts, int? passwordAttemptWindow, string passwordSalt, DateTime? currentTimeUtc, int? passwordFormat, string passwordAnswer)
    {
      return this.ExecuteFunction("aspnet_Membership_ResetPassword2", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), newPassword == null ? new ObjectParameter("NewPassword", typeof (string)) : new ObjectParameter("NewPassword", (object) newPassword), !maxInvalidPasswordAttempts.HasValue ? new ObjectParameter("MaxInvalidPasswordAttempts", typeof (int)) : new ObjectParameter("MaxInvalidPasswordAttempts", (object) maxInvalidPasswordAttempts), !passwordAttemptWindow.HasValue ? new ObjectParameter("PasswordAttemptWindow", typeof (int)) : new ObjectParameter("PasswordAttemptWindow", (object) passwordAttemptWindow), passwordSalt == null ? new ObjectParameter("PasswordSalt", typeof (string)) : new ObjectParameter("PasswordSalt", (object) passwordSalt), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), !passwordFormat.HasValue ? new ObjectParameter("PasswordFormat", typeof (int)) : new ObjectParameter("PasswordFormat", (object) passwordFormat), passwordAnswer == null ? new ObjectParameter("PasswordAnswer", typeof (string)) : new ObjectParameter("PasswordAnswer", (object) passwordAnswer));
    }

    public int aspnet_Membership_SetPassword2(string applicationName, string userName, string newPassword, string passwordSalt, DateTime? currentTimeUtc, int? passwordFormat)
    {
      return this.ExecuteFunction("aspnet_Membership_SetPassword2", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), newPassword == null ? new ObjectParameter("NewPassword", typeof (string)) : new ObjectParameter("NewPassword", (object) newPassword), passwordSalt == null ? new ObjectParameter("PasswordSalt", typeof (string)) : new ObjectParameter("PasswordSalt", (object) passwordSalt), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), !passwordFormat.HasValue ? new ObjectParameter("PasswordFormat", typeof (int)) : new ObjectParameter("PasswordFormat", (object) passwordFormat));
    }

    public int aspnet_Membership_UnlockUser2(string applicationName, string userName)
    {
      return this.ExecuteFunction("aspnet_Membership_UnlockUser2", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName)
      });
    }

    public int aspnet_Membership_UpdateUser2(string applicationName, string userName, string email, string comment, bool? isApproved, DateTime? lastLoginDate, DateTime? lastActivityDate, int? uniqueEmail, DateTime? currentTimeUtc)
    {
      return this.ExecuteFunction("aspnet_Membership_UpdateUser2", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), email == null ? new ObjectParameter("Email", typeof (string)) : new ObjectParameter("Email", (object) email), comment == null ? new ObjectParameter("Comment", typeof (string)) : new ObjectParameter("Comment", (object) comment), !isApproved.HasValue ? new ObjectParameter("IsApproved", typeof (bool)) : new ObjectParameter("IsApproved", (object) isApproved), !lastLoginDate.HasValue ? new ObjectParameter("LastLoginDate", typeof (DateTime)) : new ObjectParameter("LastLoginDate", (object) lastLoginDate), !lastActivityDate.HasValue ? new ObjectParameter("LastActivityDate", typeof (DateTime)) : new ObjectParameter("LastActivityDate", (object) lastActivityDate), !uniqueEmail.HasValue ? new ObjectParameter("UniqueEmail", typeof (int)) : new ObjectParameter("UniqueEmail", (object) uniqueEmail), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc));
    }

    public int aspnet_Membership_UpdateUserInfo2(string applicationName, string userName, bool? isPasswordCorrect, bool? updateLastLoginActivityDate, int? maxInvalidPasswordAttempts, int? passwordAttemptWindow, DateTime? currentTimeUtc, DateTime? lastLoginDate, DateTime? lastActivityDate)
    {
      return this.ExecuteFunction("aspnet_Membership_UpdateUserInfo2", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !isPasswordCorrect.HasValue ? new ObjectParameter("IsPasswordCorrect", typeof (bool)) : new ObjectParameter("IsPasswordCorrect", (object) isPasswordCorrect), !updateLastLoginActivityDate.HasValue ? new ObjectParameter("UpdateLastLoginActivityDate", typeof (bool)) : new ObjectParameter("UpdateLastLoginActivityDate", (object) updateLastLoginActivityDate), !maxInvalidPasswordAttempts.HasValue ? new ObjectParameter("MaxInvalidPasswordAttempts", typeof (int)) : new ObjectParameter("MaxInvalidPasswordAttempts", (object) maxInvalidPasswordAttempts), !passwordAttemptWindow.HasValue ? new ObjectParameter("PasswordAttemptWindow", typeof (int)) : new ObjectParameter("PasswordAttemptWindow", (object) passwordAttemptWindow), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), !lastLoginDate.HasValue ? new ObjectParameter("LastLoginDate", typeof (DateTime)) : new ObjectParameter("LastLoginDate", (object) lastLoginDate), !lastActivityDate.HasValue ? new ObjectParameter("LastActivityDate", typeof (DateTime)) : new ObjectParameter("LastActivityDate", (object) lastActivityDate));
    }

    public ObjectResult<int?> aspnet_Profile_DeleteInactiveProfiles2(string applicationName, int? profileAuthOptions, DateTime? inactiveSinceDate)
    {
      return this.ExecuteFunction<int?>("aspnet_Profile_DeleteInactiveProfiles2", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), !profileAuthOptions.HasValue ? new ObjectParameter("ProfileAuthOptions", typeof (int)) : new ObjectParameter("ProfileAuthOptions", (object) profileAuthOptions), !inactiveSinceDate.HasValue ? new ObjectParameter("InactiveSinceDate", typeof (DateTime)) : new ObjectParameter("InactiveSinceDate", (object) inactiveSinceDate));
    }

    public int aspnet_Profile_DeleteProfiles2(string applicationName, string userNames)
    {
      return this.ExecuteFunction("aspnet_Profile_DeleteProfiles2", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        userNames == null ? new ObjectParameter("UserNames", typeof (string)) : new ObjectParameter("UserNames", (object) userNames)
      });
    }

    public ObjectResult<int?> aspnet_Profile_GetNumberOfInactiveProfiles2(string applicationName, int? profileAuthOptions, DateTime? inactiveSinceDate)
    {
      return this.ExecuteFunction<int?>("aspnet_Profile_GetNumberOfInactiveProfiles2", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), !profileAuthOptions.HasValue ? new ObjectParameter("ProfileAuthOptions", typeof (int)) : new ObjectParameter("ProfileAuthOptions", (object) profileAuthOptions), !inactiveSinceDate.HasValue ? new ObjectParameter("InactiveSinceDate", typeof (DateTime)) : new ObjectParameter("InactiveSinceDate", (object) inactiveSinceDate));
    }

    public int aspnet_Profile_GetProfiles2(string applicationName, int? profileAuthOptions, int? pageIndex, int? pageSize, string userNameToMatch, DateTime? inactiveSinceDate)
    {
      return this.ExecuteFunction("aspnet_Profile_GetProfiles2", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), !profileAuthOptions.HasValue ? new ObjectParameter("ProfileAuthOptions", typeof (int)) : new ObjectParameter("ProfileAuthOptions", (object) profileAuthOptions), !pageIndex.HasValue ? new ObjectParameter("PageIndex", typeof (int)) : new ObjectParameter("PageIndex", (object) pageIndex), !pageSize.HasValue ? new ObjectParameter("PageSize", typeof (int)) : new ObjectParameter("PageSize", (object) pageSize), userNameToMatch == null ? new ObjectParameter("UserNameToMatch", typeof (string)) : new ObjectParameter("UserNameToMatch", (object) userNameToMatch), !inactiveSinceDate.HasValue ? new ObjectParameter("InactiveSinceDate", typeof (DateTime)) : new ObjectParameter("InactiveSinceDate", (object) inactiveSinceDate));
    }

    public ObjectResult<aspnet_Profile_GetProperties2_Result> aspnet_Profile_GetProperties2(string applicationName, string userName, DateTime? currentTimeUtc)
    {
      return this.ExecuteFunction<aspnet_Profile_GetProperties2_Result>("aspnet_Profile_GetProperties2", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc));
    }

    public int aspnet_Profile_SetProperties2(string applicationName, string propertyNames, string propertyValuesString, byte[] propertyValuesBinary, string userName, bool? isUserAnonymous, DateTime? currentTimeUtc)
    {
      return this.ExecuteFunction("aspnet_Profile_SetProperties2", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), propertyNames == null ? new ObjectParameter("PropertyNames", typeof (string)) : new ObjectParameter("PropertyNames", (object) propertyNames), propertyValuesString == null ? new ObjectParameter("PropertyValuesString", typeof (string)) : new ObjectParameter("PropertyValuesString", (object) propertyValuesString), propertyValuesBinary == null ? new ObjectParameter("PropertyValuesBinary", typeof (byte[])) : new ObjectParameter("PropertyValuesBinary", (object) propertyValuesBinary), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !isUserAnonymous.HasValue ? new ObjectParameter("IsUserAnonymous", typeof (bool)) : new ObjectParameter("IsUserAnonymous", (object) isUserAnonymous), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc));
    }

    public int aspnet_RegisterSchemaVersion2(string feature, string compatibleSchemaVersion, bool? isCurrentVersion, bool? removeIncompatibleSchema)
    {
      return this.ExecuteFunction("aspnet_RegisterSchemaVersion2", feature == null ? new ObjectParameter("Feature", typeof (string)) : new ObjectParameter("Feature", (object) feature), compatibleSchemaVersion == null ? new ObjectParameter("CompatibleSchemaVersion", typeof (string)) : new ObjectParameter("CompatibleSchemaVersion", (object) compatibleSchemaVersion), !isCurrentVersion.HasValue ? new ObjectParameter("IsCurrentVersion", typeof (bool)) : new ObjectParameter("IsCurrentVersion", (object) isCurrentVersion), !removeIncompatibleSchema.HasValue ? new ObjectParameter("RemoveIncompatibleSchema", typeof (bool)) : new ObjectParameter("RemoveIncompatibleSchema", (object) removeIncompatibleSchema));
    }

    public int aspnet_Roles_CreateRole2(string applicationName, string roleName)
    {
      return this.ExecuteFunction("aspnet_Roles_CreateRole2", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        roleName == null ? new ObjectParameter("RoleName", typeof (string)) : new ObjectParameter("RoleName", (object) roleName)
      });
    }

    public int aspnet_Roles_DeleteRole2(string applicationName, string roleName, bool? deleteOnlyIfRoleIsEmpty)
    {
      return this.ExecuteFunction("aspnet_Roles_DeleteRole2", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), roleName == null ? new ObjectParameter("RoleName", typeof (string)) : new ObjectParameter("RoleName", (object) roleName), !deleteOnlyIfRoleIsEmpty.HasValue ? new ObjectParameter("DeleteOnlyIfRoleIsEmpty", typeof (bool)) : new ObjectParameter("DeleteOnlyIfRoleIsEmpty", (object) deleteOnlyIfRoleIsEmpty));
    }

    public ObjectResult<string> aspnet_Roles_GetAllRoles2(string applicationName)
    {
      return this.ExecuteFunction<string>("aspnet_Roles_GetAllRoles2", new ObjectParameter[1]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName)
      });
    }

    public int aspnet_Roles_RoleExists2(string applicationName, string roleName)
    {
      return this.ExecuteFunction("aspnet_Roles_RoleExists2", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        roleName == null ? new ObjectParameter("RoleName", typeof (string)) : new ObjectParameter("RoleName", (object) roleName)
      });
    }

    public int aspnet_Setup_RemoveAllRoleMembers2(string name)
    {
      return this.ExecuteFunction("aspnet_Setup_RemoveAllRoleMembers2", new ObjectParameter[1]
      {
        name == null ? new ObjectParameter("name", typeof (string)) : new ObjectParameter("name", (object) name)
      });
    }

    public int aspnet_Setup_RestorePermissions2(string name)
    {
      return this.ExecuteFunction("aspnet_Setup_RestorePermissions2", new ObjectParameter[1]
      {
        name == null ? new ObjectParameter("name", typeof (string)) : new ObjectParameter("name", (object) name)
      });
    }

    public int aspnet_UnRegisterSchemaVersion2(string feature, string compatibleSchemaVersion)
    {
      return this.ExecuteFunction("aspnet_UnRegisterSchemaVersion2", new ObjectParameter[2]
      {
        feature == null ? new ObjectParameter("Feature", typeof (string)) : new ObjectParameter("Feature", (object) feature),
        compatibleSchemaVersion == null ? new ObjectParameter("CompatibleSchemaVersion", typeof (string)) : new ObjectParameter("CompatibleSchemaVersion", (object) compatibleSchemaVersion)
      });
    }

    public int aspnet_Users_CreateUser2(Guid? applicationId, string userName, bool? isUserAnonymous, DateTime? lastActivityDate, ObjectParameter userId)
    {
      return this.ExecuteFunction("aspnet_Users_CreateUser2", !applicationId.HasValue ? new ObjectParameter("ApplicationId", typeof (Guid)) : new ObjectParameter("ApplicationId", (object) applicationId), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !isUserAnonymous.HasValue ? new ObjectParameter("IsUserAnonymous", typeof (bool)) : new ObjectParameter("IsUserAnonymous", (object) isUserAnonymous), !lastActivityDate.HasValue ? new ObjectParameter("LastActivityDate", typeof (DateTime)) : new ObjectParameter("LastActivityDate", (object) lastActivityDate), userId);
    }

    public int aspnet_Users_DeleteUser2(string applicationName, string userName, int? tablesToDeleteFrom, ObjectParameter numTablesDeletedFrom)
    {
      return this.ExecuteFunction("aspnet_Users_DeleteUser2", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !tablesToDeleteFrom.HasValue ? new ObjectParameter("TablesToDeleteFrom", typeof (int)) : new ObjectParameter("TablesToDeleteFrom", (object) tablesToDeleteFrom), numTablesDeletedFrom);
    }

    public ObjectResult<string> aspnet_UsersInRoles_AddUsersToRoles2(string applicationName, string userNames, string roleNames, DateTime? currentTimeUtc)
    {
      return this.ExecuteFunction<string>("aspnet_UsersInRoles_AddUsersToRoles2", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userNames == null ? new ObjectParameter("UserNames", typeof (string)) : new ObjectParameter("UserNames", (object) userNames), roleNames == null ? new ObjectParameter("RoleNames", typeof (string)) : new ObjectParameter("RoleNames", (object) roleNames), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc));
    }

    public ObjectResult<string> aspnet_UsersInRoles_FindUsersInRole2(string applicationName, string roleName, string userNameToMatch)
    {
      return this.ExecuteFunction<string>("aspnet_UsersInRoles_FindUsersInRole2", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), roleName == null ? new ObjectParameter("RoleName", typeof (string)) : new ObjectParameter("RoleName", (object) roleName), userNameToMatch == null ? new ObjectParameter("UserNameToMatch", typeof (string)) : new ObjectParameter("UserNameToMatch", (object) userNameToMatch));
    }

    public ObjectResult<string> aspnet_UsersInRoles_GetRolesForUser2(string applicationName, string userName)
    {
      return this.ExecuteFunction<string>("aspnet_UsersInRoles_GetRolesForUser2", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName)
      });
    }

    public ObjectResult<string> aspnet_UsersInRoles_GetUsersInRoles2(string applicationName, string roleName)
    {
      return this.ExecuteFunction<string>("aspnet_UsersInRoles_GetUsersInRoles2", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        roleName == null ? new ObjectParameter("RoleName", typeof (string)) : new ObjectParameter("RoleName", (object) roleName)
      });
    }

    public int aspnet_UsersInRoles_IsUserInRole2(string applicationName, string userName, string roleName)
    {
      return this.ExecuteFunction("aspnet_UsersInRoles_IsUserInRole2", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), roleName == null ? new ObjectParameter("RoleName", typeof (string)) : new ObjectParameter("RoleName", (object) roleName));
    }

    public ObjectResult<aspnet_UsersInRoles_RemoveUsersFromRoles2_Result> aspnet_UsersInRoles_RemoveUsersFromRoles2(string applicationName, string userNames, string roleNames)
    {
      return this.ExecuteFunction<aspnet_UsersInRoles_RemoveUsersFromRoles2_Result>("aspnet_UsersInRoles_RemoveUsersFromRoles2", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userNames == null ? new ObjectParameter("UserNames", typeof (string)) : new ObjectParameter("UserNames", (object) userNames), roleNames == null ? new ObjectParameter("RoleNames", typeof (string)) : new ObjectParameter("RoleNames", (object) roleNames));
    }

    public ObjectResult<string> aspnet_AnyDataInTables3(int? tablesToCheck)
    {
      return this.ExecuteFunction<string>("aspnet_AnyDataInTables3", new ObjectParameter[1]
      {
        !tablesToCheck.HasValue ? new ObjectParameter("TablesToCheck", typeof (int)) : new ObjectParameter("TablesToCheck", (object) tablesToCheck)
      });
    }

    public int aspnet_Applications_CreateApplication3(string applicationName, ObjectParameter applicationId)
    {
      return this.ExecuteFunction("aspnet_Applications_CreateApplication3", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        applicationId
      });
    }

    public int aspnet_CheckSchemaVersion3(string feature, string compatibleSchemaVersion)
    {
      return this.ExecuteFunction("aspnet_CheckSchemaVersion3", new ObjectParameter[2]
      {
        feature == null ? new ObjectParameter("Feature", typeof (string)) : new ObjectParameter("Feature", (object) feature),
        compatibleSchemaVersion == null ? new ObjectParameter("CompatibleSchemaVersion", typeof (string)) : new ObjectParameter("CompatibleSchemaVersion", (object) compatibleSchemaVersion)
      });
    }

    public int aspnet_Membership_ChangePasswordQuestionAndAnswer3(string applicationName, string userName, string newPasswordQuestion, string newPasswordAnswer)
    {
      return this.ExecuteFunction("aspnet_Membership_ChangePasswordQuestionAndAnswer3", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), newPasswordQuestion == null ? new ObjectParameter("NewPasswordQuestion", typeof (string)) : new ObjectParameter("NewPasswordQuestion", (object) newPasswordQuestion), newPasswordAnswer == null ? new ObjectParameter("NewPasswordAnswer", typeof (string)) : new ObjectParameter("NewPasswordAnswer", (object) newPasswordAnswer));
    }

    public int aspnet_Membership_CreateUser3(string applicationName, string userName, string password, string passwordSalt, string email, string passwordQuestion, string passwordAnswer, bool? isApproved, DateTime? currentTimeUtc, DateTime? createDate, int? uniqueEmail, int? passwordFormat, ObjectParameter userId)
    {
      return this.ExecuteFunction("aspnet_Membership_CreateUser3", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), password == null ? new ObjectParameter("Password", typeof (string)) : new ObjectParameter("Password", (object) password), passwordSalt == null ? new ObjectParameter("PasswordSalt", typeof (string)) : new ObjectParameter("PasswordSalt", (object) passwordSalt), email == null ? new ObjectParameter("Email", typeof (string)) : new ObjectParameter("Email", (object) email), passwordQuestion == null ? new ObjectParameter("PasswordQuestion", typeof (string)) : new ObjectParameter("PasswordQuestion", (object) passwordQuestion), passwordAnswer == null ? new ObjectParameter("PasswordAnswer", typeof (string)) : new ObjectParameter("PasswordAnswer", (object) passwordAnswer), !isApproved.HasValue ? new ObjectParameter("IsApproved", typeof (bool)) : new ObjectParameter("IsApproved", (object) isApproved), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), !createDate.HasValue ? new ObjectParameter("CreateDate", typeof (DateTime)) : new ObjectParameter("CreateDate", (object) createDate), !uniqueEmail.HasValue ? new ObjectParameter("UniqueEmail", typeof (int)) : new ObjectParameter("UniqueEmail", (object) uniqueEmail), !passwordFormat.HasValue ? new ObjectParameter("PasswordFormat", typeof (int)) : new ObjectParameter("PasswordFormat", (object) passwordFormat), userId);
    }

    public int aspnet_Membership_FindUsersByEmail3(string applicationName, string emailToMatch, int? pageIndex, int? pageSize)
    {
      return this.ExecuteFunction("aspnet_Membership_FindUsersByEmail3", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), emailToMatch == null ? new ObjectParameter("EmailToMatch", typeof (string)) : new ObjectParameter("EmailToMatch", (object) emailToMatch), !pageIndex.HasValue ? new ObjectParameter("PageIndex", typeof (int)) : new ObjectParameter("PageIndex", (object) pageIndex), !pageSize.HasValue ? new ObjectParameter("PageSize", typeof (int)) : new ObjectParameter("PageSize", (object) pageSize));
    }

    public int aspnet_Membership_FindUsersByName3(string applicationName, string userNameToMatch, int? pageIndex, int? pageSize)
    {
      return this.ExecuteFunction("aspnet_Membership_FindUsersByName3", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userNameToMatch == null ? new ObjectParameter("UserNameToMatch", typeof (string)) : new ObjectParameter("UserNameToMatch", (object) userNameToMatch), !pageIndex.HasValue ? new ObjectParameter("PageIndex", typeof (int)) : new ObjectParameter("PageIndex", (object) pageIndex), !pageSize.HasValue ? new ObjectParameter("PageSize", typeof (int)) : new ObjectParameter("PageSize", (object) pageSize));
    }

    public int aspnet_Membership_GetAllUsers3(string applicationName, int? pageIndex, int? pageSize)
    {
      return this.ExecuteFunction("aspnet_Membership_GetAllUsers3", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), !pageIndex.HasValue ? new ObjectParameter("PageIndex", typeof (int)) : new ObjectParameter("PageIndex", (object) pageIndex), !pageSize.HasValue ? new ObjectParameter("PageSize", typeof (int)) : new ObjectParameter("PageSize", (object) pageSize));
    }

    public int aspnet_Membership_GetNumberOfUsersOnline3(string applicationName, int? minutesSinceLastInActive, DateTime? currentTimeUtc)
    {
      return this.ExecuteFunction("aspnet_Membership_GetNumberOfUsersOnline3", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), !minutesSinceLastInActive.HasValue ? new ObjectParameter("MinutesSinceLastInActive", typeof (int)) : new ObjectParameter("MinutesSinceLastInActive", (object) minutesSinceLastInActive), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc));
    }

    public ObjectResult<aspnet_Membership_GetPassword3_Result> aspnet_Membership_GetPassword3(string applicationName, string userName, int? maxInvalidPasswordAttempts, int? passwordAttemptWindow, DateTime? currentTimeUtc, string passwordAnswer)
    {
      return this.ExecuteFunction<aspnet_Membership_GetPassword3_Result>("aspnet_Membership_GetPassword3", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !maxInvalidPasswordAttempts.HasValue ? new ObjectParameter("MaxInvalidPasswordAttempts", typeof (int)) : new ObjectParameter("MaxInvalidPasswordAttempts", (object) maxInvalidPasswordAttempts), !passwordAttemptWindow.HasValue ? new ObjectParameter("PasswordAttemptWindow", typeof (int)) : new ObjectParameter("PasswordAttemptWindow", (object) passwordAttemptWindow), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), passwordAnswer == null ? new ObjectParameter("PasswordAnswer", typeof (string)) : new ObjectParameter("PasswordAnswer", (object) passwordAnswer));
    }

    public ObjectResult<aspnet_Membership_GetPasswordWithFormat3_Result> aspnet_Membership_GetPasswordWithFormat3(string applicationName, string userName, bool? updateLastLoginActivityDate, DateTime? currentTimeUtc)
    {
      return this.ExecuteFunction<aspnet_Membership_GetPasswordWithFormat3_Result>("aspnet_Membership_GetPasswordWithFormat3", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !updateLastLoginActivityDate.HasValue ? new ObjectParameter("UpdateLastLoginActivityDate", typeof (bool)) : new ObjectParameter("UpdateLastLoginActivityDate", (object) updateLastLoginActivityDate), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc));
    }

    public ObjectResult<string> aspnet_Membership_GetUserByEmail3(string applicationName, string email)
    {
      return this.ExecuteFunction<string>("aspnet_Membership_GetUserByEmail3", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        email == null ? new ObjectParameter("Email", typeof (string)) : new ObjectParameter("Email", (object) email)
      });
    }

    public ObjectResult<aspnet_Membership_GetUserByName3_Result> aspnet_Membership_GetUserByName3(string applicationName, string userName, DateTime? currentTimeUtc, bool? updateLastActivity)
    {
      return this.ExecuteFunction<aspnet_Membership_GetUserByName3_Result>("aspnet_Membership_GetUserByName3", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), !updateLastActivity.HasValue ? new ObjectParameter("UpdateLastActivity", typeof (bool)) : new ObjectParameter("UpdateLastActivity", (object) updateLastActivity));
    }

    public ObjectResult<aspnet_Membership_GetUserByUserId3_Result> aspnet_Membership_GetUserByUserId3(Guid? userId, DateTime? currentTimeUtc, bool? updateLastActivity)
    {
      return this.ExecuteFunction<aspnet_Membership_GetUserByUserId3_Result>("aspnet_Membership_GetUserByUserId3", !userId.HasValue ? new ObjectParameter("UserId", typeof (Guid)) : new ObjectParameter("UserId", (object) userId), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), !updateLastActivity.HasValue ? new ObjectParameter("UpdateLastActivity", typeof (bool)) : new ObjectParameter("UpdateLastActivity", (object) updateLastActivity));
    }

    public int aspnet_Membership_ResetPassword3(string applicationName, string userName, string newPassword, int? maxInvalidPasswordAttempts, int? passwordAttemptWindow, string passwordSalt, DateTime? currentTimeUtc, int? passwordFormat, string passwordAnswer)
    {
      return this.ExecuteFunction("aspnet_Membership_ResetPassword3", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), newPassword == null ? new ObjectParameter("NewPassword", typeof (string)) : new ObjectParameter("NewPassword", (object) newPassword), !maxInvalidPasswordAttempts.HasValue ? new ObjectParameter("MaxInvalidPasswordAttempts", typeof (int)) : new ObjectParameter("MaxInvalidPasswordAttempts", (object) maxInvalidPasswordAttempts), !passwordAttemptWindow.HasValue ? new ObjectParameter("PasswordAttemptWindow", typeof (int)) : new ObjectParameter("PasswordAttemptWindow", (object) passwordAttemptWindow), passwordSalt == null ? new ObjectParameter("PasswordSalt", typeof (string)) : new ObjectParameter("PasswordSalt", (object) passwordSalt), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), !passwordFormat.HasValue ? new ObjectParameter("PasswordFormat", typeof (int)) : new ObjectParameter("PasswordFormat", (object) passwordFormat), passwordAnswer == null ? new ObjectParameter("PasswordAnswer", typeof (string)) : new ObjectParameter("PasswordAnswer", (object) passwordAnswer));
    }

    public int aspnet_Membership_SetPassword3(string applicationName, string userName, string newPassword, string passwordSalt, DateTime? currentTimeUtc, int? passwordFormat)
    {
      return this.ExecuteFunction("aspnet_Membership_SetPassword3", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), newPassword == null ? new ObjectParameter("NewPassword", typeof (string)) : new ObjectParameter("NewPassword", (object) newPassword), passwordSalt == null ? new ObjectParameter("PasswordSalt", typeof (string)) : new ObjectParameter("PasswordSalt", (object) passwordSalt), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), !passwordFormat.HasValue ? new ObjectParameter("PasswordFormat", typeof (int)) : new ObjectParameter("PasswordFormat", (object) passwordFormat));
    }

    public int aspnet_Membership_UnlockUser3(string applicationName, string userName)
    {
      return this.ExecuteFunction("aspnet_Membership_UnlockUser3", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName)
      });
    }

    public int aspnet_Membership_UpdateUser3(string applicationName, string userName, string email, string comment, bool? isApproved, DateTime? lastLoginDate, DateTime? lastActivityDate, int? uniqueEmail, DateTime? currentTimeUtc)
    {
      return this.ExecuteFunction("aspnet_Membership_UpdateUser3", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), email == null ? new ObjectParameter("Email", typeof (string)) : new ObjectParameter("Email", (object) email), comment == null ? new ObjectParameter("Comment", typeof (string)) : new ObjectParameter("Comment", (object) comment), !isApproved.HasValue ? new ObjectParameter("IsApproved", typeof (bool)) : new ObjectParameter("IsApproved", (object) isApproved), !lastLoginDate.HasValue ? new ObjectParameter("LastLoginDate", typeof (DateTime)) : new ObjectParameter("LastLoginDate", (object) lastLoginDate), !lastActivityDate.HasValue ? new ObjectParameter("LastActivityDate", typeof (DateTime)) : new ObjectParameter("LastActivityDate", (object) lastActivityDate), !uniqueEmail.HasValue ? new ObjectParameter("UniqueEmail", typeof (int)) : new ObjectParameter("UniqueEmail", (object) uniqueEmail), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc));
    }

    public int aspnet_Membership_UpdateUserInfo3(string applicationName, string userName, bool? isPasswordCorrect, bool? updateLastLoginActivityDate, int? maxInvalidPasswordAttempts, int? passwordAttemptWindow, DateTime? currentTimeUtc, DateTime? lastLoginDate, DateTime? lastActivityDate)
    {
      return this.ExecuteFunction("aspnet_Membership_UpdateUserInfo3", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !isPasswordCorrect.HasValue ? new ObjectParameter("IsPasswordCorrect", typeof (bool)) : new ObjectParameter("IsPasswordCorrect", (object) isPasswordCorrect), !updateLastLoginActivityDate.HasValue ? new ObjectParameter("UpdateLastLoginActivityDate", typeof (bool)) : new ObjectParameter("UpdateLastLoginActivityDate", (object) updateLastLoginActivityDate), !maxInvalidPasswordAttempts.HasValue ? new ObjectParameter("MaxInvalidPasswordAttempts", typeof (int)) : new ObjectParameter("MaxInvalidPasswordAttempts", (object) maxInvalidPasswordAttempts), !passwordAttemptWindow.HasValue ? new ObjectParameter("PasswordAttemptWindow", typeof (int)) : new ObjectParameter("PasswordAttemptWindow", (object) passwordAttemptWindow), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc), !lastLoginDate.HasValue ? new ObjectParameter("LastLoginDate", typeof (DateTime)) : new ObjectParameter("LastLoginDate", (object) lastLoginDate), !lastActivityDate.HasValue ? new ObjectParameter("LastActivityDate", typeof (DateTime)) : new ObjectParameter("LastActivityDate", (object) lastActivityDate));
    }

    public ObjectResult<int?> aspnet_Profile_DeleteInactiveProfiles3(string applicationName, int? profileAuthOptions, DateTime? inactiveSinceDate)
    {
      return this.ExecuteFunction<int?>("aspnet_Profile_DeleteInactiveProfiles3", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), !profileAuthOptions.HasValue ? new ObjectParameter("ProfileAuthOptions", typeof (int)) : new ObjectParameter("ProfileAuthOptions", (object) profileAuthOptions), !inactiveSinceDate.HasValue ? new ObjectParameter("InactiveSinceDate", typeof (DateTime)) : new ObjectParameter("InactiveSinceDate", (object) inactiveSinceDate));
    }

    public int aspnet_Profile_DeleteProfiles3(string applicationName, string userNames)
    {
      return this.ExecuteFunction("aspnet_Profile_DeleteProfiles3", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        userNames == null ? new ObjectParameter("UserNames", typeof (string)) : new ObjectParameter("UserNames", (object) userNames)
      });
    }

    public ObjectResult<int?> aspnet_Profile_GetNumberOfInactiveProfiles3(string applicationName, int? profileAuthOptions, DateTime? inactiveSinceDate)
    {
      return this.ExecuteFunction<int?>("aspnet_Profile_GetNumberOfInactiveProfiles3", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), !profileAuthOptions.HasValue ? new ObjectParameter("ProfileAuthOptions", typeof (int)) : new ObjectParameter("ProfileAuthOptions", (object) profileAuthOptions), !inactiveSinceDate.HasValue ? new ObjectParameter("InactiveSinceDate", typeof (DateTime)) : new ObjectParameter("InactiveSinceDate", (object) inactiveSinceDate));
    }

    public int aspnet_Profile_GetProfiles3(string applicationName, int? profileAuthOptions, int? pageIndex, int? pageSize, string userNameToMatch, DateTime? inactiveSinceDate)
    {
      return this.ExecuteFunction("aspnet_Profile_GetProfiles3", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), !profileAuthOptions.HasValue ? new ObjectParameter("ProfileAuthOptions", typeof (int)) : new ObjectParameter("ProfileAuthOptions", (object) profileAuthOptions), !pageIndex.HasValue ? new ObjectParameter("PageIndex", typeof (int)) : new ObjectParameter("PageIndex", (object) pageIndex), !pageSize.HasValue ? new ObjectParameter("PageSize", typeof (int)) : new ObjectParameter("PageSize", (object) pageSize), userNameToMatch == null ? new ObjectParameter("UserNameToMatch", typeof (string)) : new ObjectParameter("UserNameToMatch", (object) userNameToMatch), !inactiveSinceDate.HasValue ? new ObjectParameter("InactiveSinceDate", typeof (DateTime)) : new ObjectParameter("InactiveSinceDate", (object) inactiveSinceDate));
    }

    public ObjectResult<aspnet_Profile_GetProperties3_Result> aspnet_Profile_GetProperties3(string applicationName, string userName, DateTime? currentTimeUtc)
    {
      return this.ExecuteFunction<aspnet_Profile_GetProperties3_Result>("aspnet_Profile_GetProperties3", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc));
    }

    public int aspnet_Profile_SetProperties3(string applicationName, string propertyNames, string propertyValuesString, byte[] propertyValuesBinary, string userName, bool? isUserAnonymous, DateTime? currentTimeUtc)
    {
      return this.ExecuteFunction("aspnet_Profile_SetProperties3", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), propertyNames == null ? new ObjectParameter("PropertyNames", typeof (string)) : new ObjectParameter("PropertyNames", (object) propertyNames), propertyValuesString == null ? new ObjectParameter("PropertyValuesString", typeof (string)) : new ObjectParameter("PropertyValuesString", (object) propertyValuesString), propertyValuesBinary == null ? new ObjectParameter("PropertyValuesBinary", typeof (byte[])) : new ObjectParameter("PropertyValuesBinary", (object) propertyValuesBinary), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !isUserAnonymous.HasValue ? new ObjectParameter("IsUserAnonymous", typeof (bool)) : new ObjectParameter("IsUserAnonymous", (object) isUserAnonymous), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc));
    }

    public int aspnet_RegisterSchemaVersion3(string feature, string compatibleSchemaVersion, bool? isCurrentVersion, bool? removeIncompatibleSchema)
    {
      return this.ExecuteFunction("aspnet_RegisterSchemaVersion3", feature == null ? new ObjectParameter("Feature", typeof (string)) : new ObjectParameter("Feature", (object) feature), compatibleSchemaVersion == null ? new ObjectParameter("CompatibleSchemaVersion", typeof (string)) : new ObjectParameter("CompatibleSchemaVersion", (object) compatibleSchemaVersion), !isCurrentVersion.HasValue ? new ObjectParameter("IsCurrentVersion", typeof (bool)) : new ObjectParameter("IsCurrentVersion", (object) isCurrentVersion), !removeIncompatibleSchema.HasValue ? new ObjectParameter("RemoveIncompatibleSchema", typeof (bool)) : new ObjectParameter("RemoveIncompatibleSchema", (object) removeIncompatibleSchema));
    }

    public int aspnet_Roles_CreateRole3(string applicationName, string roleName)
    {
      return this.ExecuteFunction("aspnet_Roles_CreateRole3", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        roleName == null ? new ObjectParameter("RoleName", typeof (string)) : new ObjectParameter("RoleName", (object) roleName)
      });
    }

    public int aspnet_Roles_DeleteRole3(string applicationName, string roleName, bool? deleteOnlyIfRoleIsEmpty)
    {
      return this.ExecuteFunction("aspnet_Roles_DeleteRole3", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), roleName == null ? new ObjectParameter("RoleName", typeof (string)) : new ObjectParameter("RoleName", (object) roleName), !deleteOnlyIfRoleIsEmpty.HasValue ? new ObjectParameter("DeleteOnlyIfRoleIsEmpty", typeof (bool)) : new ObjectParameter("DeleteOnlyIfRoleIsEmpty", (object) deleteOnlyIfRoleIsEmpty));
    }

    public ObjectResult<string> aspnet_Roles_GetAllRoles3(string applicationName)
    {
      return this.ExecuteFunction<string>("aspnet_Roles_GetAllRoles3", new ObjectParameter[1]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName)
      });
    }

    public int aspnet_Roles_RoleExists3(string applicationName, string roleName)
    {
      return this.ExecuteFunction("aspnet_Roles_RoleExists3", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        roleName == null ? new ObjectParameter("RoleName", typeof (string)) : new ObjectParameter("RoleName", (object) roleName)
      });
    }

    public int aspnet_Setup_RemoveAllRoleMembers3(string name)
    {
      return this.ExecuteFunction("aspnet_Setup_RemoveAllRoleMembers3", new ObjectParameter[1]
      {
        name == null ? new ObjectParameter("name", typeof (string)) : new ObjectParameter("name", (object) name)
      });
    }

    public int aspnet_Setup_RestorePermissions3(string name)
    {
      return this.ExecuteFunction("aspnet_Setup_RestorePermissions3", new ObjectParameter[1]
      {
        name == null ? new ObjectParameter("name", typeof (string)) : new ObjectParameter("name", (object) name)
      });
    }

    public int aspnet_UnRegisterSchemaVersion3(string feature, string compatibleSchemaVersion)
    {
      return this.ExecuteFunction("aspnet_UnRegisterSchemaVersion3", new ObjectParameter[2]
      {
        feature == null ? new ObjectParameter("Feature", typeof (string)) : new ObjectParameter("Feature", (object) feature),
        compatibleSchemaVersion == null ? new ObjectParameter("CompatibleSchemaVersion", typeof (string)) : new ObjectParameter("CompatibleSchemaVersion", (object) compatibleSchemaVersion)
      });
    }

    public int aspnet_Users_CreateUser3(Guid? applicationId, string userName, bool? isUserAnonymous, DateTime? lastActivityDate, ObjectParameter userId)
    {
      return this.ExecuteFunction("aspnet_Users_CreateUser3", !applicationId.HasValue ? new ObjectParameter("ApplicationId", typeof (Guid)) : new ObjectParameter("ApplicationId", (object) applicationId), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !isUserAnonymous.HasValue ? new ObjectParameter("IsUserAnonymous", typeof (bool)) : new ObjectParameter("IsUserAnonymous", (object) isUserAnonymous), !lastActivityDate.HasValue ? new ObjectParameter("LastActivityDate", typeof (DateTime)) : new ObjectParameter("LastActivityDate", (object) lastActivityDate), userId);
    }

    public int aspnet_Users_DeleteUser3(string applicationName, string userName, int? tablesToDeleteFrom, ObjectParameter numTablesDeletedFrom)
    {
      return this.ExecuteFunction("aspnet_Users_DeleteUser3", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), !tablesToDeleteFrom.HasValue ? new ObjectParameter("TablesToDeleteFrom", typeof (int)) : new ObjectParameter("TablesToDeleteFrom", (object) tablesToDeleteFrom), numTablesDeletedFrom);
    }

    public ObjectResult<string> aspnet_UsersInRoles_AddUsersToRoles3(string applicationName, string userNames, string roleNames, DateTime? currentTimeUtc)
    {
      return this.ExecuteFunction<string>("aspnet_UsersInRoles_AddUsersToRoles3", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userNames == null ? new ObjectParameter("UserNames", typeof (string)) : new ObjectParameter("UserNames", (object) userNames), roleNames == null ? new ObjectParameter("RoleNames", typeof (string)) : new ObjectParameter("RoleNames", (object) roleNames), !currentTimeUtc.HasValue ? new ObjectParameter("CurrentTimeUtc", typeof (DateTime)) : new ObjectParameter("CurrentTimeUtc", (object) currentTimeUtc));
    }

    public ObjectResult<string> aspnet_UsersInRoles_FindUsersInRole3(string applicationName, string roleName, string userNameToMatch)
    {
      return this.ExecuteFunction<string>("aspnet_UsersInRoles_FindUsersInRole3", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), roleName == null ? new ObjectParameter("RoleName", typeof (string)) : new ObjectParameter("RoleName", (object) roleName), userNameToMatch == null ? new ObjectParameter("UserNameToMatch", typeof (string)) : new ObjectParameter("UserNameToMatch", (object) userNameToMatch));
    }

    public ObjectResult<string> aspnet_UsersInRoles_GetRolesForUser3(string applicationName, string userName)
    {
      return this.ExecuteFunction<string>("aspnet_UsersInRoles_GetRolesForUser3", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName)
      });
    }

    public ObjectResult<string> aspnet_UsersInRoles_GetUsersInRoles3(string applicationName, string roleName)
    {
      return this.ExecuteFunction<string>("aspnet_UsersInRoles_GetUsersInRoles3", new ObjectParameter[2]
      {
        applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName),
        roleName == null ? new ObjectParameter("RoleName", typeof (string)) : new ObjectParameter("RoleName", (object) roleName)
      });
    }

    public int aspnet_UsersInRoles_IsUserInRole3(string applicationName, string userName, string roleName)
    {
      return this.ExecuteFunction("aspnet_UsersInRoles_IsUserInRole3", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userName == null ? new ObjectParameter("UserName", typeof (string)) : new ObjectParameter("UserName", (object) userName), roleName == null ? new ObjectParameter("RoleName", typeof (string)) : new ObjectParameter("RoleName", (object) roleName));
    }

    public ObjectResult<aspnet_UsersInRoles_RemoveUsersFromRoles3_Result> aspnet_UsersInRoles_RemoveUsersFromRoles3(string applicationName, string userNames, string roleNames)
    {
      return this.ExecuteFunction<aspnet_UsersInRoles_RemoveUsersFromRoles3_Result>("aspnet_UsersInRoles_RemoveUsersFromRoles3", applicationName == null ? new ObjectParameter("ApplicationName", typeof (string)) : new ObjectParameter("ApplicationName", (object) applicationName), userNames == null ? new ObjectParameter("UserNames", typeof (string)) : new ObjectParameter("UserNames", (object) userNames), roleNames == null ? new ObjectParameter("RoleNames", typeof (string)) : new ObjectParameter("RoleNames", (object) roleNames));
    }
  }
}
