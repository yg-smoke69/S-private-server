using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000D4F")]
public static class LocalNotificationManager
{
	[Token(Token = "0x2000D50")]
	private class StatsRecord
	{
		[Token(Token = "0x4006B47")]
		[FieldOffset(Offset = "0x8")]
		public ulong LastSend;

		[Token(Token = "0x4006B48")]
		[FieldOffset(Offset = "0x10")]
		public bool Enabled;

		[Token(Token = "0x4006B49")]
		[FieldOffset(Offset = "0x14")]
		public Dictionary<string, bool> Channels;

		[Token(Token = "0x600662E")]
		[Address(RVA = "0x1527160", Offset = "0x1527160", VA = "0x1527160")]
		public StatsRecord()
		{
		}

		[Token(Token = "0x600662F")]
		[Address(RVA = "0x1524A00", Offset = "0x1524A00", VA = "0x1524A00")]
		public static string ToJSON(StatsRecord value)
		{
			return null;
		}

		[Token(Token = "0x6006630")]
		[Address(RVA = "0x1524320", Offset = "0x1524320", VA = "0x1524320")]
		public static StatsRecord FromJSON(string str)
		{
			return null;
		}
	}

	[Token(Token = "0x2000D51")]
	public enum NotifyType
	{
		[Token(Token = "0x4006B4B")]
		PlayTest = 0,
		[Token(Token = "0x4006B4C")]
		RebateCardRedeeming = 1,
		[Token(Token = "0x4006B4D")]
		IAPBundleCountdown = 2,
		[Token(Token = "0x4006B4E")]
		FreeGachaCooldown_0 = 10,
		[Token(Token = "0x4006B4F")]
		FreeGachaCooldown_1 = 11,
		[Token(Token = "0x4006B50")]
		FreeGachaCooldown_2 = 12,
		[Token(Token = "0x4006B51")]
		FreeGachaCooldown_Max = 13,
		[Token(Token = "0x4006B52")]
		Retention_0 = 20,
		[Token(Token = "0x4006B53")]
		Retention_1 = 21,
		[Token(Token = "0x4006B54")]
		Retention_2 = 22,
		[Token(Token = "0x4006B55")]
		Retention_3 = 23,
		[Token(Token = "0x4006B56")]
		Retention_4 = 24,
		[Token(Token = "0x4006B57")]
		Retention_Max = 25,
		[Token(Token = "0x4006B58")]
		Veteran_Activate = 30,
		[Token(Token = "0x4006B59")]
		Veteran_Reminder = 31,
		[Token(Token = "0x4006B5A")]
		NewPlayerActivity = 32,
		[Token(Token = "0x4006B5B")]
		BooyahDayActivity = 33,
		[Token(Token = "0x4006B5C")]
		LiveTvEsport = 35,
		[Token(Token = "0x4006B5D")]
		EsportsAnnouncement = 36,
		[Token(Token = "0x4006B5E")]
		ActivityStart_0 = 40,
		[Token(Token = "0x4006B5F")]
		ActivityStart_1 = 41,
		[Token(Token = "0x4006B60")]
		ActivityStart_2 = 42,
		[Token(Token = "0x4006B61")]
		ActivityStart_3 = 43,
		[Token(Token = "0x4006B62")]
		ActivityStart_4 = 44,
		[Token(Token = "0x4006B63")]
		ActivityStart_5 = 45,
		[Token(Token = "0x4006B64")]
		ActivityStart_6 = 46,
		[Token(Token = "0x4006B65")]
		ActivityStart_7 = 47,
		[Token(Token = "0x4006B66")]
		ActivityStart_MAX = 48,
		[Token(Token = "0x4006B67")]
		BackGroundDownloadEnd = 50,
		[Token(Token = "0x4006B68")]
		BackGroundDownloadStart = 51,
		[Token(Token = "0x4006B69")]
		BackGroundDonwloadFailed = 52,
		[Token(Token = "0x4006B6A")]
		ClanWarNotify = 53
	}

	[Token(Token = "0x2000D52")]
	public class NotifyInfo
	{
		[Token(Token = "0x2000D53")]
		public delegate string ReturnUrl(object[] parameters);

		[Token(Token = "0x4006B6B")]
		[FieldOffset(Offset = "0x8")]
		public int Id;

		[Token(Token = "0x4006B6C")]
		[FieldOffset(Offset = "0xC")]
		public string ChannelId;

		[Token(Token = "0x4006B6D")]
		[FieldOffset(Offset = "0x10")]
		public string LocKey_ChannelName;

		[Token(Token = "0x4006B6E")]
		[FieldOffset(Offset = "0x14")]
		public string LocKey_ChannelDescription;

		[Token(Token = "0x4006B6F")]
		[FieldOffset(Offset = "0x18")]
		public Func<string> Title;

		[Token(Token = "0x4006B70")]
		[FieldOffset(Offset = "0x1C")]
		public Func<string> SubTitle;

		[Token(Token = "0x4006B71")]
		[FieldOffset(Offset = "0x20")]
		public Func<string> Content;

		[Token(Token = "0x4006B72")]
		[FieldOffset(Offset = "0x24")]
		public PlatformUtility.LocalNotificationImportance ChannelImportance;

		[Token(Token = "0x4006B73")]
		[FieldOffset(Offset = "0x28")]
		public Func<int> MaxRandomDelay_MS;

		[Token(Token = "0x4006B74")]
		[FieldOffset(Offset = "0x2C")]
		public ReturnUrl Url;

		[Token(Token = "0x6006631")]
		[Address(RVA = "0x152CD30", Offset = "0x152CD30", VA = "0x152CD30")]
		public NotifyInfo()
		{
		}
	}

	[Token(Token = "0x2000D54")]
	public class NotifyConfiguration
	{
		[Token(Token = "0x4006B75")]
		[FieldOffset(Offset = "0x8")]
		public bool DefaultNotify;

		[Token(Token = "0x6006636")]
		[Address(RVA = "0x152C664", Offset = "0x152C664", VA = "0x152C664")]
		public NotifyConfiguration()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000D55")]
	private class NotifyData
	{
		[Token(Token = "0x4006B76")]
		[FieldOffset(Offset = "0x8")]
		public long ExpireAt;

		[Token(Token = "0x4006B77")]
		[FieldOffset(Offset = "0x10")]
		public bool DoNotify;

		[Token(Token = "0x6006637")]
		[Address(RVA = "0x1528830", Offset = "0x1528830", VA = "0x1528830")]
		public NotifyData()
		{
		}
	}

	[Token(Token = "0x2000D56")]
	private enum Action
	{
		[Token(Token = "0x4006B79")]
		UnscheduleAll,
		[Token(Token = "0x4006B7A")]
		Unschedule,
		[Token(Token = "0x4006B7B")]
		Schedule
	}

	[Token(Token = "0x2000D57")]
	private class _Task
	{
		[Token(Token = "0x4006B7C")]
		[FieldOffset(Offset = "0x8")]
		public Action Action;

		[Token(Token = "0x4006B7D")]
		[FieldOffset(Offset = "0xC")]
		public NotifyType Type;

		[Token(Token = "0x4006B7E")]
		[FieldOffset(Offset = "0x10")]
		public long TimeMS;

		[Token(Token = "0x4006B7F")]
		[FieldOffset(Offset = "0x18")]
		public int Times;

		[Token(Token = "0x4006B80")]
		[FieldOffset(Offset = "0x1C")]
		public int IntervalMS;

		[Token(Token = "0x4006B81")]
		[FieldOffset(Offset = "0x20")]
		public string overrideTitle;

		[Token(Token = "0x4006B82")]
		[FieldOffset(Offset = "0x24")]
		public string overrideContent;

		[Token(Token = "0x6006638")]
		[Address(RVA = "0x152BE18", Offset = "0x152BE18", VA = "0x152BE18")]
		public _Task()
		{
		}
	}

	[Token(Token = "0x2000D58")]
	private enum AuthroizationPhase
	{
		[Token(Token = "0x4006B84")]
		None,
		[Token(Token = "0x4006B85")]
		Getting,
		[Token(Token = "0x4006B86")]
		Authorizing,
		[Token(Token = "0x4006B87")]
		Done
	}

	[Token(Token = "0x2000D59")]
	private sealed class _003C_SendStatsEventLog_003Ec__AnonStorey0
	{
		[Token(Token = "0x4006B88")]
		[FieldOffset(Offset = "0x8")]
		internal StatsRecord now;

		[Token(Token = "0x6006639")]
		[Address(RVA = "0x1527158", Offset = "0x1527158", VA = "0x1527158")]
		public _003C_SendStatsEventLog_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600663A")]
		[Address(RVA = "0x152CC54", Offset = "0x152CC54", VA = "0x152CC54")]
		internal bool _003C_003Em__0(KeyValuePair<string, bool> lastPair)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4006B35")]
	[FieldOffset(Offset = "0x0")]
	private static readonly DateTime APOCH_UTC;

	[Token(Token = "0x4006B36")]
	[FieldOffset(Offset = "0x10")]
	public static readonly int MSPerDay;

	[Token(Token = "0x4006B37")]
	private const string PLAYER_PREFS_KEY_STATS_RECORD = "LocalNotifyStatsRecord";

	[Token(Token = "0x4006B38")]
	[FieldOffset(Offset = "0x14")]
	private static bool _ShouldSendStatsEventLog;

	[Token(Token = "0x4006B39")]
	private const bool DEFAULT_NOTIFY = true;

	[Token(Token = "0x4006B3A")]
	[FieldOffset(Offset = "0x18")]
	private static readonly Dictionary<int, NotifyConfiguration> _NotifyConfigurations;

	[Token(Token = "0x4006B3B")]
	[FieldOffset(Offset = "0x1C")]
	private static readonly Dictionary<int, NotifyInfo> _NotifyInfos;

	[Token(Token = "0x4006B3C")]
	[FieldOffset(Offset = "0x20")]
	private static AuthroizationPhase _AuthorizationPhase;

	[Token(Token = "0x4006B3D")]
	[FieldOffset(Offset = "0x24")]
	private static PlatformUtility.LocalNotificationAuthorizationStatus _AuthorizationStatus;

	[Token(Token = "0x4006B3E")]
	[FieldOffset(Offset = "0x28")]
	private static Queue<_Task> _PendingTasks;

	[Token(Token = "0x4006B3F")]
	[FieldOffset(Offset = "0x2C")]
	private static _Task _ExecutingTask;

	[Token(Token = "0x4006B40")]
	[FieldOffset(Offset = "0x30")]
	private static Converter<KeyValuePair<string, bool>, EventLogger.EventLocalNotificationStats.Channel> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4006B41")]
	[FieldOffset(Offset = "0x34")]
	private static Converter<KeyValuePair<int, int>, EventLogger.EventLocalNotificationStats.TypeCount> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4006B42")]
	[FieldOffset(Offset = "0x38")]
	private static Converter<KeyValuePair<int, int>, EventLogger.EventLocalNotificationStats.TypeCount> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x4006B43")]
	[FieldOffset(Offset = "0x3C")]
	private static Action<PlatformUtility.LocalNotificationAuthorizationStatus> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x4006B44")]
	[FieldOffset(Offset = "0x40")]
	private static System.Action _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x4006B45")]
	[FieldOffset(Offset = "0x44")]
	private static System.Action _003C_003Ef__mg_0024cache1;

	[Token(Token = "0x4006B46")]
	[FieldOffset(Offset = "0x48")]
	private static Action<bool> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x170008A6")]
	public static long CurrentUTCTimeStampMS
	{
		[Token(Token = "0x60065FE")]
		[Address(RVA = "0x1523A00", Offset = "0x1523A00", VA = "0x1523A00")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x170008A7")]
	private static long SendStatsEventLogInterval
	{
		[Token(Token = "0x6006601")]
		[Address(RVA = "0x15240F8", Offset = "0x15240F8", VA = "0x15240F8")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x170008A8")]
	private static StatsRecord LastSentStatsRecord
	{
		[Token(Token = "0x6006602")]
		[Address(RVA = "0x1524244", Offset = "0x1524244", VA = "0x1524244")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006603")]
		[Address(RVA = "0x1524914", Offset = "0x1524914", VA = "0x1524914")]
		set
		{
		}
	}

	[Token(Token = "0x60065FF")]
	[Address(RVA = "0x1523C80", Offset = "0x1523C80", VA = "0x1523C80")]
	public static void Init()
	{
	}

	[Token(Token = "0x6006600")]
	[Address(RVA = "0x1524024", Offset = "0x1524024", VA = "0x1524024")]
	public static void AfterLoginServer()
	{
	}

	[Token(Token = "0x6006604")]
	[Address(RVA = "0x1524EA0", Offset = "0x1524EA0", VA = "0x1524EA0")]
	public static void CheckSendStatsEventLog()
	{
	}

	[Token(Token = "0x6006605")]
	[Address(RVA = "0x1526FB4", Offset = "0x1526FB4", VA = "0x1526FB4")]
	private static string IntToNotifyType(int notifyType)
	{
		return null;
	}

	[Token(Token = "0x6006606")]
	[Address(RVA = "0x152528C", Offset = "0x152528C", VA = "0x152528C")]
	private static void _SendStatsEventLog(PlatformUtility.LocalNotificationAuthorizationStatus status)
	{
	}

	[Token(Token = "0x6006607")]
	[Address(RVA = "0x1527168", Offset = "0x1527168", VA = "0x1527168")]
	private static void LogVerbose(string log)
	{
	}

	[Token(Token = "0x6006608")]
	[Address(RVA = "0x152726C", Offset = "0x152726C", VA = "0x152726C")]
	private static void Log(string log)
	{
	}

	[Token(Token = "0x6006609")]
	[Address(RVA = "0x1527338", Offset = "0x1527338", VA = "0x1527338")]
	private static void LogError(string log)
	{
	}

	[Token(Token = "0x600660A")]
	[Address(RVA = "0x1527404", Offset = "0x1527404", VA = "0x1527404")]
	public static TimeSpan UTC_To_Local()
	{
		return default(TimeSpan);
	}

	[Token(Token = "0x600660B")]
	[Address(RVA = "0x1523B08", Offset = "0x1523B08", VA = "0x1523B08")]
	private static long TimeStampMS(DateTime dateTime)
	{
		return default(long);
	}

	[Token(Token = "0x600660C")]
	[Address(RVA = "0x152751C", Offset = "0x152751C", VA = "0x152751C")]
	public static long NextTimeStampMS_Local(long notifyTimeOfDay_Local_MS)
	{
		return default(long);
	}

	[Token(Token = "0x600660D")]
	[Address(RVA = "0x1527774", Offset = "0x1527774", VA = "0x1527774")]
	public static long NextTimeStampMS_UTC(long notifyTimeOfDay_UTC_MS)
	{
		return default(long);
	}

	[Token(Token = "0x600660E")]
	[Address(RVA = "0x1527B28", Offset = "0x1527B28", VA = "0x1527B28")]
	public static int GetNotifyID(NotifyType notifyType)
	{
		return default(int);
	}

	[Token(Token = "0x600660F")]
	[Address(RVA = "0x1527B80", Offset = "0x1527B80", VA = "0x1527B80")]
	public static string GetPrefKey(NotifyType notifyType)
	{
		return null;
	}

	[Token(Token = "0x6006610")]
	[Address(RVA = "0x1527CD4", Offset = "0x1527CD4", VA = "0x1527CD4")]
	public static bool IsSupported()
	{
		return default(bool);
	}

	[Token(Token = "0x6006611")]
	[Address(RVA = "0x1527D2C", Offset = "0x1527D2C", VA = "0x1527D2C")]
	public static NotifyConfiguration GetNotifyConfiguration(NotifyType type)
	{
		return null;
	}

	[Token(Token = "0x6006612")]
	[Address(RVA = "0x1527EB0", Offset = "0x1527EB0", VA = "0x1527EB0")]
	public static void SetNotifyConfiguration(NotifyType type, NotifyConfiguration configuration)
	{
	}

	[Token(Token = "0x6006613")]
	[Address(RVA = "0x1527FC0", Offset = "0x1527FC0", VA = "0x1527FC0")]
	public static NotifyInfo GetNotifyInfo(NotifyType type)
	{
		return null;
	}

	[Token(Token = "0x6006614")]
	[Address(RVA = "0x1528188", Offset = "0x1528188", VA = "0x1528188")]
	public static void SetNotifyInfo(NotifyType type, NotifyInfo info)
	{
	}

	[Token(Token = "0x6006615")]
	[Address(RVA = "0x15281E4", Offset = "0x15281E4", VA = "0x15281E4")]
	public static bool IsScheduled(NotifyType notifyType)
	{
		return default(bool);
	}

	[Token(Token = "0x6006616")]
	[Address(RVA = "0x1528344", Offset = "0x1528344", VA = "0x1528344")]
	private static NotifyData GetNotifyData(NotifyType notifyType)
	{
		return null;
	}

	[Token(Token = "0x6006617")]
	[Address(RVA = "0x1528838", Offset = "0x1528838", VA = "0x1528838")]
	private static void SetNotifyData(NotifyType notifyType, NotifyData notifyData)
	{
	}

	[Token(Token = "0x6006618")]
	[Address(RVA = "0x15289AC", Offset = "0x15289AC", VA = "0x15289AC")]
	public static void ScheduleDailyWithLocalTimeOfDay(NotifyType notifyType, int hour, int minute, int second, int times, int firstDay = 0)
	{
	}

	[Token(Token = "0x6006619")]
	[Address(RVA = "0x1528DEC", Offset = "0x1528DEC", VA = "0x1528DEC")]
	public static void ScheduleDailyWithLocalTimeOfDay_MS(NotifyType notifyType, long timeOfDayMS, int times, int firstDay = 0)
	{
	}

	[Token(Token = "0x600661A")]
	[Address(RVA = "0x15276C8", Offset = "0x15276C8", VA = "0x15276C8")]
	public static long PositiveRemainder(long a, long b)
	{
		return default(long);
	}

	[Token(Token = "0x600661B")]
	[Address(RVA = "0x1529744", Offset = "0x1529744", VA = "0x1529744")]
	public static bool GetShouldNotify(NotifyType notifyType)
	{
		return default(bool);
	}

	[Token(Token = "0x600661C")]
	[Address(RVA = "0x1529824", Offset = "0x1529824", VA = "0x1529824")]
	public static void SetShouldNotify(NotifyType notifyType, bool shouldNotify)
	{
	}

	[Token(Token = "0x600661D")]
	[Address(RVA = "0x1529918", Offset = "0x1529918", VA = "0x1529918")]
	private static void _AddToPendingTasks(_Task task)
	{
	}

	[Token(Token = "0x600661E")]
	[Address(RVA = "0x1529C1C", Offset = "0x1529C1C", VA = "0x1529C1C")]
	private static void _ProcessPendingTasks()
	{
	}

	[Token(Token = "0x600661F")]
	[Address(RVA = "0x152B8AC", Offset = "0x152B8AC", VA = "0x152B8AC")]
	private static void _AuthorizeAndExecute()
	{
	}

	[Token(Token = "0x6006620")]
	[Address(RVA = "0x1529138", Offset = "0x1529138", VA = "0x1529138")]
	public static void Schedule(NotifyType notifyType, long time_ms, int times, int interval_ms, bool isUTC = true, string overrideTitle = "", string overrideContent = "")
	{
	}

	[Token(Token = "0x6006621")]
	[Address(RVA = "0x152A720", Offset = "0x152A720", VA = "0x152A720")]
	private static void _Schedule(NotifyType notifyType, long time_ms, int times, int interval_ms, string overrideTitle = "", string overrideContent = "")
	{
	}

	[Token(Token = "0x6006622")]
	[Address(RVA = "0x152C284", Offset = "0x152C284", VA = "0x152C284")]
	private static void _Scheduled()
	{
	}

	[Token(Token = "0x6006623")]
	[Address(RVA = "0x152BC38", Offset = "0x152BC38", VA = "0x152BC38")]
	public static void Unschedule(NotifyType notifyType)
	{
	}

	[Token(Token = "0x6006624")]
	[Address(RVA = "0x152A3B0", Offset = "0x152A3B0", VA = "0x152A3B0")]
	private static void _Unschedule(NotifyType notifyType)
	{
	}

	[Token(Token = "0x6006625")]
	[Address(RVA = "0x152C370", Offset = "0x152C370", VA = "0x152C370")]
	private static void _Unscheduled()
	{
	}

	[Token(Token = "0x6006626")]
	[Address(RVA = "0x1523D88", Offset = "0x1523D88", VA = "0x1523D88")]
	public static void UnscheduleAll()
	{
	}

	[Token(Token = "0x6006627")]
	[Address(RVA = "0x152A2D0", Offset = "0x152A2D0", VA = "0x152A2D0")]
	private static void _UnscheduleAll()
	{
	}

	[Token(Token = "0x6006629")]
	[Address(RVA = "0x152C674", Offset = "0x152C674", VA = "0x152C674")]
	private static EventLogger.EventLocalNotificationStats.Channel _003C_SendStatsEventLog_003Em__0(KeyValuePair<string, bool> c)
	{
		return null;
	}

	[Token(Token = "0x600662A")]
	[Address(RVA = "0x152C750", Offset = "0x152C750", VA = "0x152C750")]
	private static EventLogger.EventLocalNotificationStats.TypeCount _003C_SendStatsEventLog_003Em__1(KeyValuePair<int, int> r)
	{
		return null;
	}

	[Token(Token = "0x600662B")]
	[Address(RVA = "0x152C844", Offset = "0x152C844", VA = "0x152C844")]
	private static EventLogger.EventLocalNotificationStats.TypeCount _003C_SendStatsEventLog_003Em__2(KeyValuePair<int, int> r)
	{
		return null;
	}

	[Token(Token = "0x600662C")]
	[Address(RVA = "0x152C938", Offset = "0x152C938", VA = "0x152C938")]
	private static void _003C_AuthorizeAndExecute_003Em__3(PlatformUtility.LocalNotificationAuthorizationStatus status)
	{
	}

	[Token(Token = "0x600662D")]
	[Address(RVA = "0x152CB70", Offset = "0x152CB70", VA = "0x152CB70")]
	private static void _003C_AuthorizeAndExecute_003Em__4(bool granted)
	{
	}
}
