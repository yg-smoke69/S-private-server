using System.Runtime.InteropServices;
using FFVoice;
using Il2CppDummyDll;

[Token(Token = "0x2000D47")]
public class GameVoiceImpl_FreeFireVoice : _Attribute
{
	[Token(Token = "0x2000D48")]
	public class FFVoiceInitExtraConfig
	{
		[Token(Token = "0x4006B28")]
		[FieldOffset(Offset = "0x8")]
		public string SdkValidDomain;

		[Token(Token = "0x4006B29")]
		[FieldOffset(Offset = "0xC")]
		public string QoSReportDomain;

		[Token(Token = "0x4006B2A")]
		[FieldOffset(Offset = "0x10")]
		public string APIDomain;

		[Token(Token = "0x4006B2B")]
		[FieldOffset(Offset = "0x14")]
		public string BackupSDKValidIP;

		[Token(Token = "0x60065D5")]
		[Address(RVA = "0x344CC1C", Offset = "0x344CC1C", VA = "0x344CC1C")]
		public FFVoiceInitExtraConfig(string url_config)
		{
		}
	}

	[Token(Token = "0x4006B23")]
	private const string AppKey = "YOUME728F5695F9F6CEAA8F19E87D7515D7D0F2AEC9F7";

	[Token(Token = "0x4006B24")]
	private const string AppSecret = "07YWGlLQypoD7HWllL3AekmMX1kZz3seaTIvIY1kXyFVjytKVXHbcnUy7WMR1omXJTJFT/CMPJIvcZLjwMmZSGAvSbN6gK8Cwz7TON2Xq5JZELK/zlr2ksT4OMuXM/Ctsj9lSjRlXugJ0mUVEc1j1zSqwMw05+hN+AdVnG21PZkBAAE=";

	[Token(Token = "0x4006B25")]
	[FieldOffset(Offset = "0x8")]
	private int RegionIDNum;

	[Token(Token = "0x4006B26")]
	[FieldOffset(Offset = "0xC")]
	private string ExtServerRegionName;

	[Token(Token = "0x4006B27")]
	[FieldOffset(Offset = "0x10")]
	private bool HaveEnabledPCM;

	[Token(Token = "0x170008A2")]
	public FFVoice_RTC_SERVER_REGION RegionID
	{
		[Token(Token = "0x60065B9")]
		[Address(RVA = "0x344B234", Offset = "0x344B234", VA = "0x344B234")]
		get
		{
			return default(FFVoice_RTC_SERVER_REGION);
		}
	}

	[Token(Token = "0x170008A3")]
	public bool MicrophoneMute
	{
		[Token(Token = "0x60065BA")]
		[Address(RVA = "0x344B460", Offset = "0x344B460", VA = "0x344B460", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60065BB")]
		[Address(RVA = "0x344B4FC", Offset = "0x344B4FC", VA = "0x344B4FC", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x170008A4")]
	public bool SpeakerMute
	{
		[Token(Token = "0x60065BC")]
		[Address(RVA = "0x344B5A0", Offset = "0x344B5A0", VA = "0x344B5A0", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60065BD")]
		[Address(RVA = "0x344B63C", Offset = "0x344B63C", VA = "0x344B63C", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x60065B8")]
	[Address(RVA = "0x3448974", Offset = "0x3448974", VA = "0x3448974")]
	public GameVoiceImpl_FreeFireVoice()
	{
	}

	[Token(Token = "0x60065BE")]
	[Address(RVA = "0x344B740", Offset = "0x344B740", VA = "0x344B740", Slot = "8")]
	public void SetRegion(int region_id, string region_name)
	{
	}

	[Token(Token = "0x60065BF")]
	[Address(RVA = "0x344B74C", Offset = "0x344B74C", VA = "0x344B74C", Slot = "9")]
	public void SetExtraConfig(object extra_config)
	{
	}

	[Token(Token = "0x60065C0")]
	[Address(RVA = "0x344B8A0", Offset = "0x344B8A0", VA = "0x344B8A0", Slot = "10")]
	public int Init(string callBack_objectName)
	{
		return default(int);
	}

	[Token(Token = "0x60065C1")]
	[Address(RVA = "0x344BAD4", Offset = "0x344BAD4", VA = "0x344BAD4", Slot = "11")]
	public int JoinRoom(RoomInfo info)
	{
		return default(int);
	}

	[Token(Token = "0x60065C2")]
	[Address(RVA = "0x344BBBC", Offset = "0x344BBBC", VA = "0x344BBBC", Slot = "12")]
	public int LeaveRoom()
	{
		return default(int);
	}

	[Token(Token = "0x60065C3")]
	[Address(RVA = "0x344BC58", Offset = "0x344BC58", VA = "0x344BC58", Slot = "16")]
	public bool HasError(int error_code)
	{
		return default(bool);
	}

	[Token(Token = "0x60065C4")]
	[Address(RVA = "0x344BC68", Offset = "0x344BC68", VA = "0x344BC68", Slot = "17")]
	public void SetVolume(uint volume)
	{
	}

	[Token(Token = "0x60065C5")]
	[Address(RVA = "0x344BD0C", Offset = "0x344BD0C", VA = "0x344BD0C", Slot = "18")]
	public void PauseChannel(bool is_pause)
	{
	}

	[Token(Token = "0x60065C6")]
	[Address(RVA = "0x344BDFC", Offset = "0x344BDFC", VA = "0x344BDFC", Slot = "19")]
	public void SetMidCallback()
	{
	}

	[Token(Token = "0x60065C7")]
	[Address(RVA = "0x344BE9C", Offset = "0x344BE9C", VA = "0x344BE9C", Slot = "20")]
	public int UnInit()
	{
		return default(int);
	}

	[Token(Token = "0x60065C8")]
	[Address(RVA = "0x344BF38", Offset = "0x344BF38", VA = "0x344BF38", Slot = "13")]
	public EGameVoiceEvent ParseEventType(int event_id)
	{
		return default(EGameVoiceEvent);
	}

	[Token(Token = "0x60065C9")]
	[Address(RVA = "0x344C088", Offset = "0x344C088", VA = "0x344C088", Slot = "21")]
	public void OnInited()
	{
	}

	[Token(Token = "0x60065CA")]
	[Address(RVA = "0x344C218", Offset = "0x344C218", VA = "0x344C218", Slot = "22")]
	public void OnJoined(string room_id)
	{
	}

	[Token(Token = "0x60065CB")]
	[Address(RVA = "0x344C598", Offset = "0x344C598", VA = "0x344C598", Slot = "25")]
	public void EnableVoiceCaptureCallBack(bool enable)
	{
	}

	[Token(Token = "0x60065CC")]
	[Address(RVA = "0x344C7F0", Offset = "0x344C7F0", VA = "0x344C7F0")]
	private void OnPcmCallBack(FFVoiceAPI.FFVoicePcmCallbackData data)
	{
	}

	[Token(Token = "0x60065CD")]
	[Address(RVA = "0x344C89C", Offset = "0x344C89C", VA = "0x344C89C")]
	private void OnPcmCallBack_Empty(FFVoiceAPI.FFVoicePcmCallbackData data)
	{
	}

	[Token(Token = "0x60065CE")]
	[Address(RVA = "0x344C8A0", Offset = "0x344C8A0", VA = "0x344C8A0", Slot = "14")]
	public string ParseEventName(int event_id)
	{
		return null;
	}

	[Token(Token = "0x60065CF")]
	[Address(RVA = "0x344C958", Offset = "0x344C958", VA = "0x344C958", Slot = "15")]
	public string ParseErrorCodeName(int error_code)
	{
		return null;
	}

	[Token(Token = "0x60065D0")]
	[Address(RVA = "0x344CA10", Offset = "0x344CA10", VA = "0x344CA10", Slot = "24")]
	public void SetGroupEnvironment(string environment)
	{
	}

	[Token(Token = "0x60065D1")]
	[Address(RVA = "0x344CA14", Offset = "0x344CA14", VA = "0x344CA14", Slot = "23")]
	public void OnUpdate()
	{
	}

	[Token(Token = "0x60065D2")]
	[Address(RVA = "0x344CA18", Offset = "0x344CA18", VA = "0x344CA18", Slot = "26")]
	public int MuteTargetPlayer(string player_id, bool is_mute)
	{
		return default(int);
	}

	[Token(Token = "0x60065D3")]
	[Address(RVA = "0x344CAC4", Offset = "0x344CAC4", VA = "0x344CAC4", Slot = "27")]
	public int SetReportInfo(int nTimeSec, string language)
	{
		return default(int);
	}

	[Token(Token = "0x60065D4")]
	[Address(RVA = "0x344CB70", Offset = "0x344CB70", VA = "0x344CB70", Slot = "28")]
	public int ReportUserAudio(string reportUserID, string customData)
	{
		return default(int);
	}
}
