using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2003DBC")]
public static class AkCallbackManager
{
	[Token(Token = "0x2003DBD")]
	public delegate void EventCallback(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info);

	[Token(Token = "0x2003DBE")]
	public delegate void MonitoringCallback(AkMonitorErrorCode in_errorCode, AkMonitorErrorLevel in_errorLevel, uint in_playingID, ulong in_gameObjID, string in_msg);

	[Token(Token = "0x2003DBF")]
	public delegate void BankCallback(uint in_bankID, IntPtr in_InMemoryBankPtr, AKRESULT in_eLoadResult, uint in_memPoolId, object in_Cookie);

	[Token(Token = "0x2003DC0")]
	public class EventCallbackPackage
	{
		[Token(Token = "0x401A39E")]
		[FieldOffset(Offset = "0x8")]
		public bool m_bNotifyEndOfEvent;

		[Token(Token = "0x401A39F")]
		[FieldOffset(Offset = "0xC")]
		public EventCallback m_Callback;

		[Token(Token = "0x401A3A0")]
		[FieldOffset(Offset = "0x10")]
		public object m_Cookie;

		[Token(Token = "0x401A3A1")]
		[FieldOffset(Offset = "0x14")]
		public uint m_playingID;

		[Token(Token = "0x601925E")]
		[Address(RVA = "0x35CD984", Offset = "0x35CD984", VA = "0x35CD984")]
		public EventCallbackPackage()
		{
		}

		[Token(Token = "0x601925F")]
		[Address(RVA = "0x35CD98C", Offset = "0x35CD98C", VA = "0x35CD98C")]
		public static EventCallbackPackage Create(EventCallback in_cb, object in_cookie, ref uint io_Flags)
		{
			return null;
		}

		[Token(Token = "0x6019260")]
		[Address(RVA = "0x35CD018", Offset = "0x35CD018", VA = "0x35CD018")]
		public void RemoveCookies()
		{
		}

		[Token(Token = "0x6019261")]
		[Address(RVA = "0x35CDB1C", Offset = "0x35CDB1C", VA = "0x35CDB1C", Slot = "1")]
		~EventCallbackPackage()
		{
		}
	}

	[Token(Token = "0x2003DC1")]
	public class BankCallbackPackage
	{
		[Token(Token = "0x401A3A2")]
		[FieldOffset(Offset = "0x8")]
		public BankCallback m_Callback;

		[Token(Token = "0x401A3A3")]
		[FieldOffset(Offset = "0xC")]
		public object m_Cookie;

		[Token(Token = "0x6019262")]
		[Address(RVA = "0x35CD7DC", Offset = "0x35CD7DC", VA = "0x35CD7DC")]
		public BankCallbackPackage(BankCallback in_cb, object in_cookie)
		{
		}
	}

	[Token(Token = "0x2003DC2")]
	public delegate AKRESULT BGMCallback(bool in_bOtherAudioPlaying, object in_Cookie);

	[Token(Token = "0x2003DC3")]
	public class BGMCallbackPackage
	{
		[Token(Token = "0x401A3A4")]
		[FieldOffset(Offset = "0x8")]
		public BGMCallback m_Callback;

		[Token(Token = "0x401A3A5")]
		[FieldOffset(Offset = "0xC")]
		public object m_Cookie;

		[Token(Token = "0x6019267")]
		[Address(RVA = "0x35CB1A4", Offset = "0x35CB1A4", VA = "0x35CB1A4")]
		public BGMCallbackPackage()
		{
		}
	}

	[Token(Token = "0x2003DC4")]
	public class InitializationSettings
	{
		[Token(Token = "0x401A3A6")]
		[FieldOffset(Offset = "0x0")]
		public static int DefaultBufferSize;

		[Token(Token = "0x401A3A7")]
		[FieldOffset(Offset = "0x4")]
		public static bool DefaultIsLoggingEnabled;

		[Token(Token = "0x401A3A8")]
		[FieldOffset(Offset = "0x8")]
		public int BufferSize;

		[Token(Token = "0x401A3A9")]
		[FieldOffset(Offset = "0xC")]
		public bool IsLoggingEnabled;

		[Token(Token = "0x6019268")]
		[Address(RVA = "0x35C9728", Offset = "0x35C9728", VA = "0x35C9728")]
		public InitializationSettings()
		{
		}
	}

	[Token(Token = "0x401A38D")]
	[FieldOffset(Offset = "0x0")]
	private static bool _003CIsLoggingEnabled_003Ek__BackingField;

	[Token(Token = "0x401A38E")]
	[FieldOffset(Offset = "0x4")]
	private static readonly AkEventCallbackInfo AkEventCallbackInfo;

	[Token(Token = "0x401A38F")]
	[FieldOffset(Offset = "0x8")]
	private static readonly AkDynamicSequenceItemCallbackInfo AkDynamicSequenceItemCallbackInfo;

	[Token(Token = "0x401A390")]
	[FieldOffset(Offset = "0xC")]
	private static readonly AkMIDIEventCallbackInfo AkMIDIEventCallbackInfo;

	[Token(Token = "0x401A391")]
	[FieldOffset(Offset = "0x10")]
	private static readonly AkMarkerCallbackInfo AkMarkerCallbackInfo;

	[Token(Token = "0x401A392")]
	[FieldOffset(Offset = "0x14")]
	private static readonly AkDurationCallbackInfo AkDurationCallbackInfo;

	[Token(Token = "0x401A393")]
	[FieldOffset(Offset = "0x18")]
	private static readonly AkMusicSyncCallbackInfo AkMusicSyncCallbackInfo;

	[Token(Token = "0x401A394")]
	[FieldOffset(Offset = "0x1C")]
	private static readonly AkMusicPlaylistCallbackInfo AkMusicPlaylistCallbackInfo;

	[Token(Token = "0x401A395")]
	[FieldOffset(Offset = "0x20")]
	private static readonly AkAudioSourceChangeCallbackInfo AkAudioSourceChangeCallbackInfo;

	[Token(Token = "0x401A396")]
	[FieldOffset(Offset = "0x24")]
	private static readonly AkMonitoringCallbackInfo AkMonitoringCallbackInfo;

	[Token(Token = "0x401A397")]
	[FieldOffset(Offset = "0x28")]
	private static readonly AkBankCallbackInfo AkBankCallbackInfo;

	[Token(Token = "0x401A398")]
	[FieldOffset(Offset = "0x2C")]
	private static readonly Dictionary<int, EventCallbackPackage> m_mapEventCallbacks;

	[Token(Token = "0x401A399")]
	[FieldOffset(Offset = "0x30")]
	private static readonly Dictionary<int, BankCallbackPackage> m_mapBankCallbacks;

	[Token(Token = "0x401A39A")]
	[FieldOffset(Offset = "0x34")]
	private static EventCallbackPackage m_LastAddedEventPackage;

	[Token(Token = "0x401A39B")]
	[FieldOffset(Offset = "0x38")]
	private static IntPtr m_pNotifMem;

	[Token(Token = "0x401A39C")]
	[FieldOffset(Offset = "0x3C")]
	private static MonitoringCallback m_MonitoringCB;

	[Token(Token = "0x401A39D")]
	[FieldOffset(Offset = "0x40")]
	private static BGMCallbackPackage ms_sourceChangeCallbackPkg;

	[Token(Token = "0x17001B1A")]
	private static bool IsLoggingEnabled
	{
		[Token(Token = "0x6019246")]
		[Address(RVA = "0x35C9DC8", Offset = "0x35C9DC8", VA = "0x35C9DC8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6019247")]
		[Address(RVA = "0x35C9E54", Offset = "0x35C9E54", VA = "0x35C9E54")]
		set
		{
		}
	}

	[Token(Token = "0x6019248")]
	[Address(RVA = "0x35C9EE4", Offset = "0x35C9EE4", VA = "0x35C9EE4")]
	public static void RemoveEventCallback(uint in_playingID)
	{
	}

	[Token(Token = "0x6019249")]
	[Address(RVA = "0x35CA298", Offset = "0x35CA298", VA = "0x35CA298")]
	public static void RemoveEventCallbackCookie(object in_cookie)
	{
	}

	[Token(Token = "0x601924A")]
	[Address(RVA = "0x35CA700", Offset = "0x35CA700", VA = "0x35CA700")]
	public static void RemoveBankCallback(object in_cookie)
	{
	}

	[Token(Token = "0x601924B")]
	[Address(RVA = "0x35CAAD4", Offset = "0x35CAAD4", VA = "0x35CAAD4")]
	public static void SetLastAddedPlayingID(uint in_playingID)
	{
	}

	[Token(Token = "0x601924C")]
	[Address(RVA = "0x35CAC18", Offset = "0x35CAC18", VA = "0x35CAC18")]
	public static AKRESULT Init(InitializationSettings settings)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601924D")]
	[Address(RVA = "0x35CADE4", Offset = "0x35CADE4", VA = "0x35CADE4")]
	public static void Term()
	{
	}

	[Token(Token = "0x601924E")]
	[Address(RVA = "0x35CAF9C", Offset = "0x35CAF9C", VA = "0x35CAF9C")]
	public static void SetMonitoringCallback(AkMonitorErrorLevel in_Level, MonitoringCallback in_CB)
	{
	}

	[Token(Token = "0x601924F")]
	[Address(RVA = "0x35CB0C4", Offset = "0x35CB0C4", VA = "0x35CB0C4")]
	public static void SetBGMCallback(BGMCallback in_CB, object in_cookie)
	{
	}

	[Token(Token = "0x6019250")]
	[Address(RVA = "0x35CB1AC", Offset = "0x35CB1AC", VA = "0x35CB1AC")]
	public static int PostCallbacks()
	{
		return default(int);
	}
}
