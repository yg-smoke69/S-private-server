using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Firebase;
using Firebase.Analytics;
using Firebase.Messaging;
using Il2CppDummyDll;
using InterApp;

namespace COW;

[Token(Token = "0x20003A8")]
public static class FirebaseManager
{
	[Token(Token = "0x20003A9")]
	public static class Crashlytics
	{
		[Token(Token = "0x40037B0")]
		[FieldOffset(Offset = "0x0")]
		private static bool _003CCrashlyticsInited_003Ek__BackingField;

		[Token(Token = "0x1700017D")]
		public static bool UseCrashlytics
		{
			[Token(Token = "0x6000F33")]
			[Address(RVA = "0xDE9434", Offset = "0xDE9434", VA = "0xDE9434")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000F34")]
			[Address(RVA = "0xDE9508", Offset = "0xDE9508", VA = "0xDE9508")]
			set
			{
			}
		}

		[Token(Token = "0x1700017E")]
		public static bool CrashlyticsInited
		{
			[Token(Token = "0x6000F35")]
			[Address(RVA = "0xDE96C8", Offset = "0xDE96C8", VA = "0xDE96C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000F36")]
			[Address(RVA = "0xDE972C", Offset = "0xDE972C", VA = "0xDE972C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000F37")]
		[Address(RVA = "0xDE7FEC", Offset = "0xDE7FEC", VA = "0xDE7FEC")]
		internal static void Init()
		{
		}

		[Token(Token = "0x6000F38")]
		[Address(RVA = "0xDE6CE4", Offset = "0xDE6CE4", VA = "0xDE6CE4")]
		internal static void Shutdown()
		{
		}

		[Token(Token = "0x6000F39")]
		[Address(RVA = "0xDE9790", Offset = "0xDE9790", VA = "0xDE9790")]
		public static void SetUserId(string userId)
		{
		}

		[Token(Token = "0x6000F3A")]
		[Address(RVA = "0xDE9910", Offset = "0xDE9910", VA = "0xDE9910")]
		public static void SetKeyValue(string key, string value)
		{
		}

		[Token(Token = "0x6000F3B")]
		[Address(RVA = "0xDE9AA0", Offset = "0xDE9AA0", VA = "0xDE9AA0")]
		public static void Log(string msg)
		{
		}

		[Token(Token = "0x6000F3C")]
		[Address(RVA = "0xDE9C20", Offset = "0xDE9C20", VA = "0xDE9C20")]
		public static void Report(Exception exception)
		{
		}
	}

	[Token(Token = "0x20003AA")]
	public static class Analytics
	{
		[Token(Token = "0x40037B1")]
		[FieldOffset(Offset = "0x0")]
		private static bool _003CAnalyticsInited_003Ek__BackingField;

		[Token(Token = "0x40037B2")]
		[FieldOffset(Offset = "0x4")]
		private static Converter<KeyValuePair<string, string>, Parameter> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x1700017F")]
		public static bool UseAnalytics
		{
			[Token(Token = "0x6000F3D")]
			[Address(RVA = "0xDE8B84", Offset = "0xDE8B84", VA = "0xDE8B84")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000180")]
		public static bool AnalyticsInited
		{
			[Token(Token = "0x6000F3E")]
			[Address(RVA = "0xDE8D10", Offset = "0xDE8D10", VA = "0xDE8D10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000F3F")]
			[Address(RVA = "0xDE8D74", Offset = "0xDE8D74", VA = "0xDE8D74")]
			private set
			{
			}
		}

		[Token(Token = "0x6000F40")]
		[Address(RVA = "0xDE81FC", Offset = "0xDE81FC", VA = "0xDE81FC")]
		public static void Init()
		{
		}

		[Token(Token = "0x6000F41")]
		[Address(RVA = "0xDE6E98", Offset = "0xDE6E98", VA = "0xDE6E98")]
		internal static void Shutdown()
		{
		}

		[Token(Token = "0x6000F42")]
		[Address(RVA = "0xDE8DD8", Offset = "0xDE8DD8", VA = "0xDE8DD8")]
		public static void SetUserId(string userId)
		{
		}

		[Token(Token = "0x6000F43")]
		[Address(RVA = "0xDE8F84", Offset = "0xDE8F84", VA = "0xDE8F84")]
		public static void SetUserProperty(string key, string value)
		{
		}

		[Token(Token = "0x6000F44")]
		[Address(RVA = "0xDE9140", Offset = "0xDE9140", VA = "0xDE9140")]
		public static void LogEvent(string eventName, [Optional] Dictionary<string, string> parameters)
		{
		}

		[Token(Token = "0x6000F45")]
		[Address(RVA = "0xDE9374", Offset = "0xDE9374", VA = "0xDE9374")]
		private static Parameter _003CLogEvent_003Em__0(KeyValuePair<string, string> pair)
		{
			return null;
		}
	}

	[Token(Token = "0x20003AB")]
	public static class Messaging
	{
		[Token(Token = "0x20003AC")]
		public class FirebaseMessagingDelegate : OpenedWithParamsDelegate
		{
			[Token(Token = "0x40037BA")]
			public const string MSG_ID_KEY = "google.message_id";

			[Token(Token = "0x40037BB")]
			public const string DEEP_LINK_URL_KEY = "sigma.deeplink.url";

			[Token(Token = "0x40037BC")]
			public const string WEB_VIEW_URL_KEY = "sigma.webview.url";

			[Token(Token = "0x40037BD")]
			public const string WEB_VIEW_STYLE_KEY = "sigma.webview.style";

			[Token(Token = "0x40037BE")]
			public const string BROWSER_URL_KEY = "sigma.browser.url";

			[Token(Token = "0x6000F53")]
			[Address(RVA = "0xDEBC08", Offset = "0xDEBC08", VA = "0xDEBC08")]
			public FirebaseMessagingDelegate()
			{
			}

			[Token(Token = "0x6000F54")]
			[Address(RVA = "0xDEBC10", Offset = "0xDEBC10", VA = "0xDEBC10", Slot = "5")]
			public override bool CanProcess(Dictionary<string, string> parameters)
			{
				return default(bool);
			}

			[Token(Token = "0x6000F55")]
			[Address(RVA = "0xDEBD1C", Offset = "0xDEBD1C", VA = "0xDEBD1C", Slot = "6")]
			public override OpenedWithParams Process(Dictionary<string, string> parameters)
			{
				return null;
			}

			[Token(Token = "0x6000F56")]
			[Address(RVA = "0xDEBFC0", Offset = "0xDEBFC0", VA = "0xDEBFC0")]
			public bool _003C_003EiFixBaseProxy_CanProcess(Dictionary<string, string> P0)
			{
				return default(bool);
			}

			[Token(Token = "0x6000F57")]
			[Address(RVA = "0xDEBFC8", Offset = "0xDEBFC8", VA = "0xDEBFC8")]
			public OpenedWithParams _003C_003EiFixBaseProxy_Process(Dictionary<string, string> P0)
			{
				return null;
			}
		}

		[Token(Token = "0x20003AD")]
		private sealed class _003CSubscribeTopic_003Ec__AnonStorey0
		{
			[Token(Token = "0x20003AE")]
			private sealed class _003CSubscribeTopic_003Ec__AnonStorey1
			{
				[Token(Token = "0x40037C1")]
				[FieldOffset(Offset = "0x8")]
				internal bool isOK;

				[Token(Token = "0x40037C2")]
				[FieldOffset(Offset = "0xC")]
				internal string errorMessage;

				[Token(Token = "0x40037C3")]
				[FieldOffset(Offset = "0x10")]
				internal _003CSubscribeTopic_003Ec__AnonStorey0 _003C_003Ef__ref_00240;

				[Token(Token = "0x6000F5A")]
				[Address(RVA = "0xDEB56C", Offset = "0xDEB56C", VA = "0xDEB56C")]
				public _003CSubscribeTopic_003Ec__AnonStorey1()
				{
				}

				[Token(Token = "0x6000F5B")]
				[Address(RVA = "0xDEB574", Offset = "0xDEB574", VA = "0xDEB574")]
				internal void _003C_003Em__0()
				{
				}
			}

			[Token(Token = "0x40037BF")]
			[FieldOffset(Offset = "0x8")]
			internal string topic;

			[Token(Token = "0x40037C0")]
			[FieldOffset(Offset = "0xC")]
			internal Action<string, bool, string> callback;

			[Token(Token = "0x6000F58")]
			[Address(RVA = "0xDEA59C", Offset = "0xDEA59C", VA = "0xDEA59C")]
			public _003CSubscribeTopic_003Ec__AnonStorey0()
			{
			}

			[Token(Token = "0x6000F59")]
			[Address(RVA = "0xDEB088", Offset = "0xDEB088", VA = "0xDEB088")]
			internal void _003C_003Em__0(Task task)
			{
			}
		}

		[Token(Token = "0x20003AF")]
		private sealed class _003CUnsubscribeTopic_003Ec__AnonStorey2
		{
			[Token(Token = "0x20003B0")]
			private sealed class _003CUnsubscribeTopic_003Ec__AnonStorey3
			{
				[Token(Token = "0x40037C6")]
				[FieldOffset(Offset = "0x8")]
				internal bool isOK;

				[Token(Token = "0x40037C7")]
				[FieldOffset(Offset = "0xC")]
				internal string errorMessage;

				[Token(Token = "0x40037C8")]
				[FieldOffset(Offset = "0x10")]
				internal _003CUnsubscribeTopic_003Ec__AnonStorey2 _003C_003Ef__ref_00242;

				[Token(Token = "0x6000F5E")]
				[Address(RVA = "0xDEBB2C", Offset = "0xDEBB2C", VA = "0xDEBB2C")]
				public _003CUnsubscribeTopic_003Ec__AnonStorey3()
				{
				}

				[Token(Token = "0x6000F5F")]
				[Address(RVA = "0xDEBB34", Offset = "0xDEBB34", VA = "0xDEBB34")]
				internal void _003C_003Em__0()
				{
				}
			}

			[Token(Token = "0x40037C4")]
			[FieldOffset(Offset = "0x8")]
			internal string topic;

			[Token(Token = "0x40037C5")]
			[FieldOffset(Offset = "0xC")]
			internal Action<string, bool, string> callback;

			[Token(Token = "0x6000F5C")]
			[Address(RVA = "0xDEA790", Offset = "0xDEA790", VA = "0xDEA790")]
			public _003CUnsubscribeTopic_003Ec__AnonStorey2()
			{
			}

			[Token(Token = "0x6000F5D")]
			[Address(RVA = "0xDEB648", Offset = "0xDEB648", VA = "0xDEB648")]
			internal void _003C_003Em__0(Task task)
			{
			}
		}

		[Token(Token = "0x40037B3")]
		[FieldOffset(Offset = "0x0")]
		private static bool _003CMessagingInited_003Ek__BackingField;

		[Token(Token = "0x40037B4")]
		[FieldOffset(Offset = "0x1")]
		private static bool _003CMessagingIniting_003Ek__BackingField;

		[Token(Token = "0x40037B5")]
		[FieldOffset(Offset = "0x4")]
		public static Action OnInited;

		[Token(Token = "0x40037B6")]
		[FieldOffset(Offset = "0x8")]
		private static EventHandler<TokenReceivedEventArgs> _003C_003Ef__mg_0024cache0;

		[Token(Token = "0x40037B7")]
		[FieldOffset(Offset = "0xC")]
		private static EventHandler<MessageReceivedEventArgs> _003C_003Ef__mg_0024cache1;

		[Token(Token = "0x40037B8")]
		[FieldOffset(Offset = "0x10")]
		private static Action<Task> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x40037B9")]
		[FieldOffset(Offset = "0x14")]
		private static Action<Task<string>> _003C_003Ef__am_0024cache1;

		[Token(Token = "0x17000181")]
		public static bool UseMessaging
		{
			[Token(Token = "0x6000F46")]
			[Address(RVA = "0xDE9DA0", Offset = "0xDE9DA0", VA = "0xDE9DA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000182")]
		public static bool MessagingInited
		{
			[Token(Token = "0x6000F47")]
			[Address(RVA = "0xDE9F2C", Offset = "0xDE9F2C", VA = "0xDE9F2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000F48")]
			[Address(RVA = "0xDE9F90", Offset = "0xDE9F90", VA = "0xDE9F90")]
			private set
			{
			}
		}

		[Token(Token = "0x17000183")]
		public static bool MessagingIniting
		{
			[Token(Token = "0x6000F49")]
			[Address(RVA = "0xDE9FF4", Offset = "0xDE9FF4", VA = "0xDE9FF4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000F4A")]
			[Address(RVA = "0xDEA058", Offset = "0xDEA058", VA = "0xDEA058")]
			private set
			{
			}
		}

		[Token(Token = "0x6000F4B")]
		[Address(RVA = "0xDE8440", Offset = "0xDE8440", VA = "0xDE8440")]
		public static void Init()
		{
		}

		[Token(Token = "0x6000F4C")]
		[Address(RVA = "0xDE7078", Offset = "0xDE7078", VA = "0xDE7078")]
		internal static void Shutdown()
		{
		}

		[Token(Token = "0x6000F4D")]
		[Address(RVA = "0xDEA0BC", Offset = "0xDEA0BC", VA = "0xDEA0BC")]
		public static void OnTokenReceived(object sender, TokenReceivedEventArgs token)
		{
		}

		[Token(Token = "0x6000F4E")]
		[Address(RVA = "0xDEA268", Offset = "0xDEA268", VA = "0xDEA268")]
		public static void OnMessageReceived(object sender, MessageReceivedEventArgs e)
		{
		}

		[Token(Token = "0x6000F4F")]
		[Address(RVA = "0xDEA3B0", Offset = "0xDEA3B0", VA = "0xDEA3B0")]
		public static void SubscribeTopic(string topic, Action<string, bool, string> callback)
		{
		}

		[Token(Token = "0x6000F50")]
		[Address(RVA = "0xDEA5A4", Offset = "0xDEA5A4", VA = "0xDEA5A4")]
		public static void UnsubscribeTopic(string topic, Action<string, bool, string> callback)
		{
		}

		[Token(Token = "0x6000F51")]
		[Address(RVA = "0xDEA798", Offset = "0xDEA798", VA = "0xDEA798")]
		private static void _003CInit_003Em__0(Task deleteTask)
		{
		}

		[Token(Token = "0x6000F52")]
		[Address(RVA = "0xDEABA4", Offset = "0xDEABA4", VA = "0xDEABA4")]
		private static void _003CInit_003Em__1(Task<string> getTask)
		{
		}
	}

	[Token(Token = "0x40037A8")]
	[FieldOffset(Offset = "0x0")]
	private static bool _PendingShutdown;

	[Token(Token = "0x40037A9")]
	[FieldOffset(Offset = "0x1")]
	private static bool _003CIsInited_003Ek__BackingField;

	[Token(Token = "0x40037AA")]
	[FieldOffset(Offset = "0x2")]
	private static bool _003CIsIniting_003Ek__BackingField;

	[Token(Token = "0x40037AB")]
	[FieldOffset(Offset = "0x3")]
	private static bool _003CIsOK_003Ek__BackingField;

	[Token(Token = "0x40037AC")]
	[FieldOffset(Offset = "0x4")]
	private static HashSet<Action> _InitCallbacks;

	[Token(Token = "0x40037AD")]
	[FieldOffset(Offset = "0x8")]
	private static Action<Task<DependencyStatus>> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x40037AE")]
	[FieldOffset(Offset = "0xC")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x40037AF")]
	[FieldOffset(Offset = "0x10")]
	private static Action _003C_003Ef__am_0024cache2;

	[Token(Token = "0x17000177")]
	public static bool UseFirebase
	{
		[Token(Token = "0x6000F23")]
		[Address(RVA = "0xDE5E8C", Offset = "0xDE5E8C", VA = "0xDE5E8C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000178")]
	public static bool ShouldUseFirebase
	{
		[Token(Token = "0x6000F24")]
		[Address(RVA = "0xDE6104", Offset = "0xDE6104", VA = "0xDE6104")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000F25")]
		[Address(RVA = "0xDE62AC", Offset = "0xDE62AC", VA = "0xDE62AC")]
		set
		{
		}
	}

	[Token(Token = "0x17000179")]
	public static bool CanUseFirebase
	{
		[Token(Token = "0x6000F26")]
		[Address(RVA = "0xDE61EC", Offset = "0xDE61EC", VA = "0xDE61EC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700017A")]
	public static bool IsInited
	{
		[Token(Token = "0x6000F27")]
		[Address(RVA = "0xDE65FC", Offset = "0xDE65FC", VA = "0xDE65FC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000F28")]
		[Address(RVA = "0xDE6B34", Offset = "0xDE6B34", VA = "0xDE6B34")]
		private set
		{
		}
	}

	[Token(Token = "0x1700017B")]
	public static bool IsIniting
	{
		[Token(Token = "0x6000F29")]
		[Address(RVA = "0xDE6570", Offset = "0xDE6570", VA = "0xDE6570")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000F2A")]
		[Address(RVA = "0xDE6BC4", Offset = "0xDE6BC4", VA = "0xDE6BC4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700017C")]
	public static bool IsOK
	{
		[Token(Token = "0x6000F2B")]
		[Address(RVA = "0xDE6688", Offset = "0xDE6688", VA = "0xDE6688")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000F2C")]
		[Address(RVA = "0xDE6C54", Offset = "0xDE6C54", VA = "0xDE6C54")]
		private set
		{
		}
	}

	[Token(Token = "0x6000F2D")]
	[Address(RVA = "0xDE6714", Offset = "0xDE6714", VA = "0xDE6714")]
	private static void Shutdown()
	{
	}

	[Token(Token = "0x6000F2E")]
	[Address(RVA = "0xDE72AC", Offset = "0xDE72AC", VA = "0xDE72AC")]
	public static void Init([Optional] Action callback)
	{
	}

	[Token(Token = "0x6000F30")]
	[Address(RVA = "0xDE7874", Offset = "0xDE7874", VA = "0xDE7874")]
	private static void _003CInit_003Em__0(Task<DependencyStatus> task)
	{
	}

	[Token(Token = "0x6000F31")]
	[Address(RVA = "0xDE7D04", Offset = "0xDE7D04", VA = "0xDE7D04")]
	private static void _003CInit_003Em__1()
	{
	}

	[Token(Token = "0x6000F32")]
	[Address(RVA = "0xDE8980", Offset = "0xDE8980", VA = "0xDE8980")]
	private static void _003CInit_003Em__2()
	{
	}
}
