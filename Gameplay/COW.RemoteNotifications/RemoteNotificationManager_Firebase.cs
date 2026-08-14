using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW.RemoteNotifications;

[Token(Token = "0x2001DD0")]
public class RemoteNotificationManager_Firebase : RemoteNotificationManager
{
	[Token(Token = "0x2001DD1")]
	private enum UserProperty
	{
		[Token(Token = "0x400BCD5")]
		Environment,
		[Token(Token = "0x400BCD6")]
		Region,
		[Token(Token = "0x400BCD7")]
		Language,
		[Token(Token = "0x400BCD8")]
		LastActiveServerTime,
		[Token(Token = "0x400BCD9")]
		PlayerLevel,
		[Token(Token = "0x400BCDA")]
		IsPaid,
		[Token(Token = "0x400BCDB")]
		ElitePassBadgeNumber,
		[Token(Token = "0x400BCDC")]
		ClanID,
		[Token(Token = "0x400BCDD")]
		InClan,
		[Token(Token = "0x400BCDE")]
		TimeZoneOffsetHours,
		[Token(Token = "0x400BCDF")]
		TimeZoneStandardName,
		[Token(Token = "0x400BCE0")]
		GamesPlayed_RankedMatch,
		[Token(Token = "0x400BCE1")]
		Variant,
		[Token(Token = "0x400BCE2")]
		Store
	}

	[Token(Token = "0x2001DD2")]
	private class UserPropertyInfo
	{
		[Token(Token = "0x400BCE3")]
		[FieldOffset(Offset = "0x8")]
		public string Key;

		[Token(Token = "0x400BCE4")]
		[FieldOffset(Offset = "0xC")]
		public Func<string> Value;

		[Token(Token = "0x6008E86")]
		[Address(RVA = "0x19762A4", Offset = "0x19762A4", VA = "0x19762A4")]
		public UserPropertyInfo()
		{
		}
	}

	[Token(Token = "0x2001DD3")]
	private enum UserPropertyTopic
	{
		[Token(Token = "0x400BCE6")]
		Basic,
		[Token(Token = "0x400BCE7")]
		IsPaid,
		[Token(Token = "0x400BCE8")]
		InClan,
		[Token(Token = "0x400BCE9")]
		Store
	}

	[Token(Token = "0x2001DD4")]
	private class TopicTask
	{
		[Token(Token = "0x400BCEA")]
		[FieldOffset(Offset = "0x8")]
		public bool IsSubscribe;

		[Token(Token = "0x400BCEB")]
		[FieldOffset(Offset = "0xC")]
		public string Topic;

		[Token(Token = "0x400BCEC")]
		[FieldOffset(Offset = "0x10")]
		public string PlayerPrefKey;

		[Token(Token = "0x6008E87")]
		[Address(RVA = "0x1979E34", Offset = "0x1979E34", VA = "0x1979E34")]
		public TopicTask()
		{
		}
	}

	[Token(Token = "0x400BCBA")]
	private const string PLAYER_PREFS_KEY_USER_PROPERTIES_TEMPLATE = "RNM_FIREBASE_USER_PROPERTIES_{0}";

	[Token(Token = "0x400BCBB")]
	private const string PLAYER_PREFS_KEY_USER_ID = "RNM_FIREBASE_USER_ID";

	[Token(Token = "0x400BCBC")]
	private const string FIREBASE_USER_PROPERTY_NAME_TEMPLATE = "sigma_{0}";

	[Token(Token = "0x400BCBD")]
	[FieldOffset(Offset = "0x8")]
	private readonly Dictionary<int, UserPropertyInfo> USER_PROPERTIES;

	[Token(Token = "0x400BCBE")]
	[FieldOffset(Offset = "0xC")]
	private string _PendingUserId;

	[Token(Token = "0x400BCBF")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, string> _PendingUserProperties;

	[Token(Token = "0x400BCC0")]
	private const string PLAYER_PREFS_KEY_USER_PROPERTY_TOPIC_TEMPLATE = "RNM_FIREBASE_USER_PROPERTY_TOPIC_{0}";

	[Token(Token = "0x400BCC1")]
	private const string FIREBASE_USER_PROPERTY_TOPIC_TEMPLATE = "ff_{0}";

	[Token(Token = "0x400BCC2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<int, int[]> USER_PROPERTY_TOPICS;

	[Token(Token = "0x400BCC3")]
	[FieldOffset(Offset = "0x4")]
	private static readonly Dictionary<int, string> USER_PROPERTY_TOPIC_TEMPLATES;

	[Token(Token = "0x400BCC4")]
	[FieldOffset(Offset = "0x14")]
	private TopicTask _PendingTopicTask;

	[Token(Token = "0x400BCC5")]
	[FieldOffset(Offset = "0x18")]
	private Queue<TopicTask> _TopicTasks;

	[Token(Token = "0x400BCC6")]
	[FieldOffset(Offset = "0x8")]
	private static Func<string> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400BCC7")]
	[FieldOffset(Offset = "0xC")]
	private static Func<string> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400BCC8")]
	[FieldOffset(Offset = "0x10")]
	private static Func<string> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x400BCC9")]
	[FieldOffset(Offset = "0x14")]
	private static Func<string> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x400BCCA")]
	[FieldOffset(Offset = "0x18")]
	private static Func<string> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x400BCCB")]
	[FieldOffset(Offset = "0x1C")]
	private static Func<string> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x400BCCC")]
	[FieldOffset(Offset = "0x20")]
	private static Func<string> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x400BCCD")]
	[FieldOffset(Offset = "0x24")]
	private static Func<string> _003C_003Ef__am_0024cache7;

	[Token(Token = "0x400BCCE")]
	[FieldOffset(Offset = "0x28")]
	private static Func<string> _003C_003Ef__am_0024cache8;

	[Token(Token = "0x400BCCF")]
	[FieldOffset(Offset = "0x2C")]
	private static Func<string> _003C_003Ef__am_0024cache9;

	[Token(Token = "0x400BCD0")]
	[FieldOffset(Offset = "0x30")]
	private static Func<string> _003C_003Ef__am_0024cacheA;

	[Token(Token = "0x400BCD1")]
	[FieldOffset(Offset = "0x34")]
	private static Func<string> _003C_003Ef__am_0024cacheB;

	[Token(Token = "0x400BCD2")]
	[FieldOffset(Offset = "0x38")]
	private static Func<string> _003C_003Ef__am_0024cacheC;

	[Token(Token = "0x400BCD3")]
	[FieldOffset(Offset = "0x3C")]
	private static Func<string> _003C_003Ef__am_0024cacheD;

	[Token(Token = "0x17000F07")]
	private static bool DisableCacheForFirebaseAnalytics
	{
		[Token(Token = "0x6008E52")]
		[Address(RVA = "0x19762AC", Offset = "0x19762AC", VA = "0x19762AC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000F08")]
	private static bool DisableCacheForFirebaseMessaging
	{
		[Token(Token = "0x6008E53")]
		[Address(RVA = "0x1976AB0", Offset = "0x1976AB0", VA = "0x1976AB0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000F09")]
	private static bool UseAnalyticsUserProperties
	{
		[Token(Token = "0x6008E54")]
		[Address(RVA = "0x1976B88", Offset = "0x1976B88", VA = "0x1976B88")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000F0A")]
	private static bool UseMessagingTopics
	{
		[Token(Token = "0x6008E55")]
		[Address(RVA = "0x1976C88", Offset = "0x1976C88", VA = "0x1976C88")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6008E50")]
	[Address(RVA = "0x1974BC0", Offset = "0x1974BC0", VA = "0x1974BC0")]
	internal RemoteNotificationManager_Firebase()
	{
	}

	[Token(Token = "0x6008E51")]
	[Address(RVA = "0x1976384", Offset = "0x1976384", VA = "0x1976384")]
	private void LogVerbose(string log)
	{
	}

	[Token(Token = "0x6008E56")]
	[Address(RVA = "0x1976D88", Offset = "0x1976D88", VA = "0x1976D88")]
	private string FormatFirebaseUserPropertyName(string key)
	{
		return null;
	}

	[Token(Token = "0x6008E57")]
	[Address(RVA = "0x1976E3C", Offset = "0x1976E3C", VA = "0x1976E3C")]
	private string FormatUserPropertyPlayerPrefsKey(string key)
	{
		return null;
	}

	[Token(Token = "0x6008E58")]
	[Address(RVA = "0x1976EF0", Offset = "0x1976EF0", VA = "0x1976EF0")]
	private void LogUserInfo(string method)
	{
	}

	[Token(Token = "0x6008E59")]
	[Address(RVA = "0x197775C", Offset = "0x197775C", VA = "0x197775C")]
	private void UpdateUserInfo(bool force = false)
	{
	}

	[Token(Token = "0x6008E5A")]
	[Address(RVA = "0x1977ADC", Offset = "0x1977ADC", VA = "0x1977ADC")]
	private void _UpdateUserId(string userId)
	{
	}

	[Token(Token = "0x6008E5B")]
	[Address(RVA = "0x19778F8", Offset = "0x19778F8", VA = "0x19778F8")]
	private void UpdateUserId(bool force = false)
	{
	}

	[Token(Token = "0x6008E5C")]
	[Address(RVA = "0x1977DCC", Offset = "0x1977DCC", VA = "0x1977DCC")]
	private void ClearUserId()
	{
	}

	[Token(Token = "0x6008E5D")]
	[Address(RVA = "0x1977E78", Offset = "0x1977E78", VA = "0x1977E78")]
	private void _UpdateUserProperty(UserProperty userProperty, string value)
	{
	}

	[Token(Token = "0x6008E5E")]
	[Address(RVA = "0x19766EC", Offset = "0x19766EC", VA = "0x19766EC")]
	private void UpdateUserProperty(UserProperty userProperty, bool force = false)
	{
	}

	[Token(Token = "0x6008E5F")]
	[Address(RVA = "0x19785C8", Offset = "0x19785C8", VA = "0x19785C8")]
	private void ClearUserProperty(UserProperty userProperty)
	{
	}

	[Token(Token = "0x6008E60")]
	[Address(RVA = "0x19786EC", Offset = "0x19786EC", VA = "0x19786EC", Slot = "5")]
	public override void AfterLoginSDK()
	{
	}

	[Token(Token = "0x6008E61")]
	[Address(RVA = "0x197875C", Offset = "0x197875C", VA = "0x197875C", Slot = "6")]
	public override void BeforeLoginServer()
	{
	}

	[Token(Token = "0x6008E62")]
	[Address(RVA = "0x1978760", Offset = "0x1978760", VA = "0x1978760", Slot = "7")]
	public override void AfterLoginServer()
	{
	}

	[Token(Token = "0x6008E63")]
	[Address(RVA = "0x1978AA0", Offset = "0x1978AA0", VA = "0x1978AA0", Slot = "9")]
	public override void AfterLogoutServer()
	{
	}

	[Token(Token = "0x6008E64")]
	[Address(RVA = "0x1978B10", Offset = "0x1978B10", VA = "0x1978B10", Slot = "11")]
	public override void AfterLogoutSDK()
	{
	}

	[Token(Token = "0x6008E65")]
	[Address(RVA = "0x1978B7C", Offset = "0x1978B7C", VA = "0x1978B7C", Slot = "13")]
	public override void AfterChangeLanguage()
	{
	}

	[Token(Token = "0x6008E66")]
	[Address(RVA = "0x1978BF0", Offset = "0x1978BF0", VA = "0x1978BF0", Slot = "17")]
	public override void AfterChangeClanID()
	{
	}

	[Token(Token = "0x6008E67")]
	[Address(RVA = "0x1978C70", Offset = "0x1978C70", VA = "0x1978C70", Slot = "19")]
	public override void AfterChangeElitePassBadgeNumber()
	{
	}

	[Token(Token = "0x6008E68")]
	[Address(RVA = "0x1978CE4", Offset = "0x1978CE4", VA = "0x1978CE4", Slot = "15")]
	public override void AfterChangeFirstTimePaid()
	{
	}

	[Token(Token = "0x6008E69")]
	[Address(RVA = "0x1978D64", Offset = "0x1978D64", VA = "0x1978D64", Slot = "21")]
	public override void AfterChangePlayerLevel()
	{
	}

	[Token(Token = "0x6008E6A")]
	[Address(RVA = "0x1978DD8", Offset = "0x1978DD8", VA = "0x1978DD8", Slot = "22")]
	public override void BeforeChangeGamesPlayedInRankedMatch()
	{
	}

	[Token(Token = "0x6008E6B")]
	[Address(RVA = "0x1978DDC", Offset = "0x1978DDC", VA = "0x1978DDC", Slot = "23")]
	public override void AfterChangeGamesPlayedInRankedMatch()
	{
	}

	[Token(Token = "0x6008E6C")]
	[Address(RVA = "0x197763C", Offset = "0x197763C", VA = "0x197763C")]
	private string FormatTopicPlayerPrefsKey(UserPropertyTopic topic)
	{
		return null;
	}

	[Token(Token = "0x6008E6D")]
	[Address(RVA = "0x1978E50", Offset = "0x1978E50", VA = "0x1978E50")]
	private string UserPropertyTopicValue(UserPropertyTopic topic)
	{
		return null;
	}

	[Token(Token = "0x6008E6E")]
	[Address(RVA = "0x1976444", Offset = "0x1976444", VA = "0x1976444")]
	private void ClearCachedUserPropertyTopics()
	{
	}

	[Token(Token = "0x6008E6F")]
	[Address(RVA = "0x1978848", Offset = "0x1978848", VA = "0x1978848")]
	private void UpdateUserPropertyTopic(UserPropertyTopic topic)
	{
	}

	[Token(Token = "0x6008E70")]
	[Address(RVA = "0x19797C8", Offset = "0x19797C8", VA = "0x19797C8")]
	private void _SubscribeTopic(string playerPrefsKey, string topic)
	{
	}

	[Token(Token = "0x6008E71")]
	[Address(RVA = "0x1979E3C", Offset = "0x1979E3C", VA = "0x1979E3C")]
	private void _OnSubscribedTopic(string topic, bool isOK, string error)
	{
	}

	[Token(Token = "0x6008E72")]
	[Address(RVA = "0x1979160", Offset = "0x1979160", VA = "0x1979160")]
	private void _UnsubscribeTopic(string playerPrefsKey, string topic)
	{
	}

	[Token(Token = "0x6008E73")]
	[Address(RVA = "0x197A5EC", Offset = "0x197A5EC", VA = "0x197A5EC")]
	private void _OnUnsubscribedTopic(string topic, bool isOK, string error)
	{
	}

	[Token(Token = "0x6008E74")]
	[Address(RVA = "0x197A104", Offset = "0x197A104", VA = "0x197A104")]
	private void _ProcessTopicTaskQueue()
	{
	}

	[Token(Token = "0x6008E76")]
	[Address(RVA = "0x197AC74", Offset = "0x197AC74", VA = "0x197AC74")]
	private static string _003CUSER_PROPERTIES_003Em__0()
	{
		return null;
	}

	[Token(Token = "0x6008E77")]
	[Address(RVA = "0x197AD6C", Offset = "0x197AD6C", VA = "0x197AD6C")]
	private static string _003CUSER_PROPERTIES_003Em__1()
	{
		return null;
	}

	[Token(Token = "0x6008E78")]
	[Address(RVA = "0x197ADF8", Offset = "0x197ADF8", VA = "0x197ADF8")]
	private static string _003CUSER_PROPERTIES_003Em__2()
	{
		return null;
	}

	[Token(Token = "0x6008E79")]
	[Address(RVA = "0x197AEB0", Offset = "0x197AEB0", VA = "0x197AEB0")]
	private static string _003CUSER_PROPERTIES_003Em__3()
	{
		return null;
	}

	[Token(Token = "0x6008E7A")]
	[Address(RVA = "0x197AF50", Offset = "0x197AF50", VA = "0x197AF50")]
	private static string _003CUSER_PROPERTIES_003Em__4()
	{
		return null;
	}

	[Token(Token = "0x6008E7B")]
	[Address(RVA = "0x197B044", Offset = "0x197B044", VA = "0x197B044")]
	private static string _003CUSER_PROPERTIES_003Em__5()
	{
		return null;
	}

	[Token(Token = "0x6008E7C")]
	[Address(RVA = "0x197B15C", Offset = "0x197B15C", VA = "0x197B15C")]
	private static string _003CUSER_PROPERTIES_003Em__6()
	{
		return null;
	}

	[Token(Token = "0x6008E7D")]
	[Address(RVA = "0x197B250", Offset = "0x197B250", VA = "0x197B250")]
	private static string _003CUSER_PROPERTIES_003Em__7()
	{
		return null;
	}

	[Token(Token = "0x6008E7E")]
	[Address(RVA = "0x197B348", Offset = "0x197B348", VA = "0x197B348")]
	private static string _003CUSER_PROPERTIES_003Em__8()
	{
		return null;
	}

	[Token(Token = "0x6008E7F")]
	[Address(RVA = "0x197B464", Offset = "0x197B464", VA = "0x197B464")]
	private static string _003CUSER_PROPERTIES_003Em__9()
	{
		return null;
	}

	[Token(Token = "0x6008E80")]
	[Address(RVA = "0x197B5A0", Offset = "0x197B5A0", VA = "0x197B5A0")]
	private static string _003CUSER_PROPERTIES_003Em__A()
	{
		return null;
	}

	[Token(Token = "0x6008E81")]
	[Address(RVA = "0x197B644", Offset = "0x197B644", VA = "0x197B644")]
	private static string _003CUSER_PROPERTIES_003Em__B()
	{
		return null;
	}

	[Token(Token = "0x6008E82")]
	[Address(RVA = "0x197B754", Offset = "0x197B754", VA = "0x197B754")]
	private static string _003CUSER_PROPERTIES_003Em__C()
	{
		return null;
	}

	[Token(Token = "0x6008E83")]
	[Address(RVA = "0x197B7B0", Offset = "0x197B7B0", VA = "0x197B7B0")]
	private static string _003CUSER_PROPERTIES_003Em__D()
	{
		return null;
	}

	[Token(Token = "0x6008E84")]
	[Address(RVA = "0x197B80C", Offset = "0x197B80C", VA = "0x197B80C")]
	private void _003CRemoteNotificationManager_Firebase_003Em__E()
	{
	}

	[Token(Token = "0x6008E85")]
	[Address(RVA = "0x197BBEC", Offset = "0x197BBEC", VA = "0x197BBEC")]
	private string _003CUserPropertyTopicValue_003Em__F(int p)
	{
		return null;
	}
}
