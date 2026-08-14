using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003FA6")]
public static class PlatformUtility
{
	[Token(Token = "0x2003FA7")]
	public delegate void LogCallback(string log);

	[Token(Token = "0x2003FA8")]
	public class PlatformUtilityOption
	{
		[Token(Token = "0x401ACF9")]
		[FieldOffset(Offset = "0x8")]
		public string AndroidFileProviderAuthorities;

		[Token(Token = "0x6019E95")]
		[Address(RVA = "0x3315BF8", Offset = "0x3315BF8", VA = "0x3315BF8")]
		public PlatformUtilityOption()
		{
		}
	}

	[Token(Token = "0x2003FA9")]
	public class OpenedWith
	{
		[Token(Token = "0x401ACFA")]
		[FieldOffset(Offset = "0x8")]
		public Dictionary<string, string> Params;

		[Token(Token = "0x401ACFB")]
		[FieldOffset(Offset = "0xC")]
		public string Url;

		[Token(Token = "0x401ACFC")]
		[FieldOffset(Offset = "0x10")]
		public string WebUrl;

		[Token(Token = "0x401ACFD")]
		[FieldOffset(Offset = "0x14")]
		public int NotifyType;

		[Token(Token = "0x401ACFE")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<KeyValuePair<string, string>, string> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x17001C4F")]
		public bool HasParams
		{
			[Token(Token = "0x6019E97")]
			[Address(RVA = "0x2986590", Offset = "0x2986590", VA = "0x2986590")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17001C50")]
		public bool HasUrl
		{
			[Token(Token = "0x6019E98")]
			[Address(RVA = "0x2986614", Offset = "0x2986614", VA = "0x2986614")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17001C51")]
		public bool HasWebUrl
		{
			[Token(Token = "0x6019E99")]
			[Address(RVA = "0x29866A0", Offset = "0x29866A0", VA = "0x29866A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17001C52")]
		public bool HasNotifyType
		{
			[Token(Token = "0x6019E9A")]
			[Address(RVA = "0x298672C", Offset = "0x298672C", VA = "0x298672C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6019E96")]
		[Address(RVA = "0x2986588", Offset = "0x2986588", VA = "0x2986588")]
		public OpenedWith()
		{
		}

		[Token(Token = "0x6019E9B")]
		[Address(RVA = "0x2986740", Offset = "0x2986740", VA = "0x2986740")]
		public static string ToString(OpenedWith ow)
		{
			return null;
		}

		[Token(Token = "0x6019E9C")]
		[Address(RVA = "0x298695C", Offset = "0x298695C", VA = "0x298695C")]
		public static bool HasValue(OpenedWith ow)
		{
			return default(bool);
		}

		[Token(Token = "0x6019E9D")]
		[Address(RVA = "0x29869B8", Offset = "0x29869B8", VA = "0x29869B8")]
		public void FromJson(string json)
		{
		}

		[Token(Token = "0x6019E9E")]
		[Address(RVA = "0x2986EFC", Offset = "0x2986EFC", VA = "0x2986EFC")]
		private static string _003CToString_003Em__0(KeyValuePair<string, string> pair)
		{
			return null;
		}
	}

	[Token(Token = "0x2003FAA")]
	public delegate void BatteryChargingChangedCallback(bool charging);

	[Token(Token = "0x2003FAB")]
	public delegate void BatteryLevelChangedCallback(float level);

	[Token(Token = "0x2003FAC")]
	public enum LocalNotificationImportance
	{
		[Token(Token = "0x401AD00")]
		Unspecified = -1000,
		[Token(Token = "0x401AD01")]
		None = 0,
		[Token(Token = "0x401AD02")]
		Min = 1,
		[Token(Token = "0x401AD03")]
		Low = 2,
		[Token(Token = "0x401AD04")]
		Default = 3,
		[Token(Token = "0x401AD05")]
		High = 4,
		[Token(Token = "0x401AD06")]
		Max = 5
	}

	[Token(Token = "0x2003FAD")]
	public enum LocalNotificationAuthorizationStatus
	{
		[Token(Token = "0x401AD08")]
		NotDetermined,
		[Token(Token = "0x401AD09")]
		Denied,
		[Token(Token = "0x401AD0A")]
		Authorized
	}

	[Token(Token = "0x2003FAE")]
	private sealed class _003COnTakenScreenshot_003Ec__AnonStorey0
	{
		[Token(Token = "0x401AD0B")]
		[FieldOffset(Offset = "0x8")]
		internal string clue;

		[Token(Token = "0x6019EA7")]
		[Address(RVA = "0x2985518", Offset = "0x2985518", VA = "0x2985518")]
		public _003COnTakenScreenshot_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6019EA8")]
		[Address(RVA = "0x2985EB8", Offset = "0x2985EB8", VA = "0x2985EB8")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x401ACF3")]
	[FieldOffset(Offset = "0x0")]
	private static LogCallback OnLog;

	[Token(Token = "0x401ACF4")]
	[FieldOffset(Offset = "0x4")]
	private static LogCallback OnLogError;

	[Token(Token = "0x401ACF5")]
	[FieldOffset(Offset = "0x8")]
	internal static Action<string> _SaveImageToAlbumCallback;

	[Token(Token = "0x401ACF6")]
	[FieldOffset(Offset = "0xC")]
	public static BatteryChargingChangedCallback OnBatteryChargingChanged;

	[Token(Token = "0x401ACF7")]
	[FieldOffset(Offset = "0x10")]
	public static BatteryLevelChangedCallback OnBatteryLevelChanged;

	[Token(Token = "0x401ACF8")]
	[FieldOffset(Offset = "0x14")]
	private static Action _OnTakenScreenshot;

	[Token(Token = "0x17001C4B")]
	public static string DeviceIdentifier
	{
		[Token(Token = "0x6019E6E")]
		[Address(RVA = "0x298457C", Offset = "0x298457C", VA = "0x298457C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C4C")]
	public static string VersionCode
	{
		[Token(Token = "0x6019E6F")]
		[Address(RVA = "0x29845F8", Offset = "0x29845F8", VA = "0x29845F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C4D")]
	public static bool IsBuiltForMobileOnStandalone
	{
		[Token(Token = "0x6019E75")]
		[Address(RVA = "0x2984BBC", Offset = "0x2984BBC", VA = "0x2984BBC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001C4E")]
	public static bool IsRunningMobileOnStandalone
	{
		[Token(Token = "0x6019E76")]
		[Address(RVA = "0x2984BC4", Offset = "0x2984BC4", VA = "0x2984BC4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6019E5F")]
	[Address(RVA = "0x29839A4", Offset = "0x29839A4", VA = "0x29839A4")]
	public static void Init(PlatformUtilityOption option)
	{
	}

	[Token(Token = "0x6019E60")]
	[Address(RVA = "0x2983A50", Offset = "0x2983A50", VA = "0x2983A50")]
	public static void SetLogCallbacks(LogCallback onLog, LogCallback onLogError)
	{
	}

	[Token(Token = "0x6019E61")]
	[Address(RVA = "0x2983AC4", Offset = "0x2983AC4", VA = "0x2983AC4")]
	internal static void Log(string log)
	{
	}

	[Token(Token = "0x6019E62")]
	[Address(RVA = "0x2983EF8", Offset = "0x2983EF8", VA = "0x2983EF8")]
	internal static void LogError(string logError)
	{
	}

	[Token(Token = "0x6019E63")]
	[Address(RVA = "0x2983F70", Offset = "0x2983F70", VA = "0x2983F70")]
	public static void SetUnitySendMessageGameObjectName(string gameObjectName)
	{
	}

	[Token(Token = "0x6019E64")]
	[Address(RVA = "0x2983FF4", Offset = "0x2983FF4", VA = "0x2983FF4")]
	public static OpenedWith GetOpenedWith()
	{
		return null;
	}

	[Token(Token = "0x6019E65")]
	[Address(RVA = "0x2984070", Offset = "0x2984070", VA = "0x2984070")]
	public static void ClearOpenedWith()
	{
	}

	[Token(Token = "0x6019E66")]
	[Address(RVA = "0x29840EC", Offset = "0x29840EC", VA = "0x29840EC")]
	public static void SetCanHandleLowMemory(bool canHandle)
	{
	}

	[Token(Token = "0x6019E67")]
	[Address(RVA = "0x2984170", Offset = "0x2984170", VA = "0x2984170")]
	public static void CopyStringToClipboard(string content)
	{
	}

	[Token(Token = "0x6019E68")]
	[Address(RVA = "0x29841F4", Offset = "0x29841F4", VA = "0x29841F4")]
	public static string CopyStringFromClipboard()
	{
		return null;
	}

	[Token(Token = "0x6019E69")]
	[Address(RVA = "0x2984270", Offset = "0x2984270", VA = "0x2984270")]
	public static void SaveImageToAlbum(byte[] imageData, string title, string description, Action<string> callback)
	{
	}

	[Token(Token = "0x6019E6A")]
	[Address(RVA = "0x2984320", Offset = "0x2984320", VA = "0x2984320")]
	public static void CancelSaveImageToAlbumCallback()
	{
	}

	[Token(Token = "0x6019E6B")]
	[Address(RVA = "0x2984388", Offset = "0x2984388", VA = "0x2984388")]
	public static void SendText(string title, string text)
	{
	}

	[Token(Token = "0x6019E6C")]
	[Address(RVA = "0x2984414", Offset = "0x2984414", VA = "0x2984414")]
	public static bool SendImage(string text, string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x6019E6D")]
	[Address(RVA = "0x29844F8", Offset = "0x29844F8", VA = "0x29844F8")]
	public static void NativeLog(string text)
	{
	}

	[Token(Token = "0x6019E70")]
	[Address(RVA = "0x29848F0", Offset = "0x29848F0", VA = "0x29848F0")]
	public static bool IsEmulator()
	{
		return default(bool);
	}

	[Token(Token = "0x6019E71")]
	[Address(RVA = "0x298496C", Offset = "0x298496C", VA = "0x298496C")]
	public static string GetNetworkType()
	{
		return null;
	}

	[Token(Token = "0x6019E72")]
	[Address(RVA = "0x2984A14", Offset = "0x2984A14", VA = "0x2984A14")]
	public static string GetNetworkName()
	{
		return null;
	}

	[Token(Token = "0x6019E73")]
	[Address(RVA = "0x2984ABC", Offset = "0x2984ABC", VA = "0x2984ABC")]
	public static void ToggleBatteryReport(bool shouldReport)
	{
	}

	[Token(Token = "0x6019E74")]
	[Address(RVA = "0x2984B40", Offset = "0x2984B40", VA = "0x2984B40")]
	public static float GetBatteryLevel()
	{
		return default(float);
	}

	[Token(Token = "0x6019E77")]
	[Address(RVA = "0x2984BCC", Offset = "0x2984BCC", VA = "0x2984BCC")]
	public static int GetAppMemory()
	{
		return default(int);
	}

	[Token(Token = "0x6019E78")]
	[Address(RVA = "0x2984C48", Offset = "0x2984C48", VA = "0x2984C48")]
	public static int GetAvailMemory()
	{
		return default(int);
	}

	[Token(Token = "0x6019E79")]
	[Address(RVA = "0x2984CE8", Offset = "0x2984CE8", VA = "0x2984CE8")]
	public static int GetTotalMemory()
	{
		return default(int);
	}

	[Token(Token = "0x6019E7A")]
	[Address(RVA = "0x2984D88", Offset = "0x2984D88", VA = "0x2984D88")]
	public static string GetPlatformInfo()
	{
		return null;
	}

	[Token(Token = "0x6019E7B")]
	[Address(RVA = "0x2984DE4", Offset = "0x2984DE4", VA = "0x2984DE4")]
	public static bool IsTotalMemoryAboveThreshold(float number_gigabytes)
	{
		return default(bool);
	}

	[Token(Token = "0x6019E7C")]
	[Address(RVA = "0x29850D0", Offset = "0x29850D0", VA = "0x29850D0")]
	public static int GetLowMemoryThreshold()
	{
		return default(int);
	}

	[Token(Token = "0x6019E7D")]
	[Address(RVA = "0x298517C", Offset = "0x298517C", VA = "0x298517C")]
	public static bool IsBatteryCharging()
	{
		return default(bool);
	}

	[Token(Token = "0x6019E7E")]
	[Address(RVA = "0x29851F8", Offset = "0x29851F8", VA = "0x29851F8")]
	public static float GetWifiSignalLevel()
	{
		return default(float);
	}

	[Token(Token = "0x6019E7F")]
	[Address(RVA = "0x2985274", Offset = "0x2985274", VA = "0x2985274")]
	public static int IntPtrBytes()
	{
		return default(int);
	}

	[Token(Token = "0x6019E80")]
	[Address(RVA = "0x298527C", Offset = "0x298527C", VA = "0x298527C")]
	public static bool Is32BitsProcess()
	{
		return default(bool);
	}

	[Token(Token = "0x6019E81")]
	[Address(RVA = "0x29852A0", Offset = "0x29852A0", VA = "0x29852A0")]
	public static bool Is64BitsProcess()
	{
		return default(bool);
	}

	[Token(Token = "0x6019E82")]
	[Address(RVA = "0x29852C4", Offset = "0x29852C4", VA = "0x29852C4")]
	public static bool SupportInAppReview()
	{
		return default(bool);
	}

	[Token(Token = "0x6019E83")]
	[Address(RVA = "0x2985340", Offset = "0x2985340", VA = "0x2985340")]
	public static bool DoInAppReview(Action<bool> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x6019E84")]
	[Address(RVA = "0x29853C4", Offset = "0x29853C4", VA = "0x29853C4")]
	public static void SetTakenScreenshotCallback(Action action)
	{
	}

	[Token(Token = "0x6019E85")]
	[Address(RVA = "0x2985428", Offset = "0x2985428", VA = "0x2985428")]
	internal static void OnTakenScreenshot(string clue)
	{
	}

	[Token(Token = "0x6019E86")]
	[Address(RVA = "0x2985520", Offset = "0x2985520", VA = "0x2985520")]
	public static bool SupportsLocalNotification()
	{
		return default(bool);
	}

	[Token(Token = "0x6019E87")]
	[Address(RVA = "0x2985528", Offset = "0x2985528", VA = "0x2985528")]
	public static bool ShouldCheckForLocalNotificationAuthorization()
	{
		return default(bool);
	}

	[Token(Token = "0x6019E88")]
	[Address(RVA = "0x2985530", Offset = "0x2985530", VA = "0x2985530")]
	public static bool ShouldSetupLocalNotificationChannels()
	{
		return default(bool);
	}

	[Token(Token = "0x6019E89")]
	[Address(RVA = "0x2985538", Offset = "0x2985538", VA = "0x2985538")]
	public static bool HasLocalNotificationChannels()
	{
		return default(bool);
	}

	[Token(Token = "0x6019E8A")]
	[Address(RVA = "0x29855B4", Offset = "0x29855B4", VA = "0x29855B4")]
	public static void SetupLocalNotificationChannel(string channel_id, string channel_name, string channel_description, LocalNotificationImportance importance)
	{
	}

	[Token(Token = "0x6019E8B")]
	[Address(RVA = "0x298565C", Offset = "0x298565C", VA = "0x298565C")]
	public static void GetLocalNotificationAuthorizationStatus(Action<LocalNotificationAuthorizationStatus> callback)
	{
	}

	[Token(Token = "0x6019E8C")]
	[Address(RVA = "0x29856CC", Offset = "0x29856CC", VA = "0x29856CC")]
	public static void RequestLocalNotificationAuthorization(Action<bool> callback)
	{
	}

	[Token(Token = "0x6019E8D")]
	[Address(RVA = "0x298573C", Offset = "0x298573C", VA = "0x298573C")]
	public static void ScheduleLocalNotification(int type, int id, string channel_id, string title, string subtitle, string content, string url, long time_ms, int times, int interval_ms, Action done)
	{
	}

	[Token(Token = "0x6019E8E")]
	[Address(RVA = "0x2985CA8", Offset = "0x2985CA8", VA = "0x2985CA8")]
	public static void UnscheduleLocalNotification(int id, Action done)
	{
	}

	[Token(Token = "0x6019E8F")]
	[Address(RVA = "0x2985DC0", Offset = "0x2985DC0", VA = "0x2985DC0")]
	public static void UnscheduleAllLocalNotifications()
	{
	}

	[Token(Token = "0x6019E90")]
	[Address(RVA = "0x2985E3C", Offset = "0x2985E3C", VA = "0x2985E3C")]
	public static void ClearAllNotifications()
	{
	}
}
