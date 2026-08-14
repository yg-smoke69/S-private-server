using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2000D46")]
public class GameVoiceImplNone : _Attribute
{
	[Token(Token = "0x4006B21")]
	[FieldOffset(Offset = "0x8")]
	private bool _003CMicrophoneMute_003Ek__BackingField;

	[Token(Token = "0x4006B22")]
	[FieldOffset(Offset = "0x9")]
	private bool _003CSpeakerMute_003Ek__BackingField;

	[Token(Token = "0x170008A0")]
	public bool MicrophoneMute
	{
		[Token(Token = "0x600659F")]
		[Address(RVA = "0x344B08C", Offset = "0x344B08C", VA = "0x344B08C", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60065A0")]
		[Address(RVA = "0x344B094", Offset = "0x344B094", VA = "0x344B094", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x170008A1")]
	public bool SpeakerMute
	{
		[Token(Token = "0x60065A1")]
		[Address(RVA = "0x344B09C", Offset = "0x344B09C", VA = "0x344B09C", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60065A2")]
		[Address(RVA = "0x344B0A4", Offset = "0x344B0A4", VA = "0x344B0A4", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x600659E")]
	[Address(RVA = "0x3448AD4", Offset = "0x3448AD4", VA = "0x3448AD4")]
	public GameVoiceImplNone()
	{
	}

	[Token(Token = "0x60065A3")]
	[Address(RVA = "0x344B0AC", Offset = "0x344B0AC", VA = "0x344B0AC", Slot = "9")]
	public void SetExtraConfig(object extra_config)
	{
	}

	[Token(Token = "0x60065A4")]
	[Address(RVA = "0x344B0B0", Offset = "0x344B0B0", VA = "0x344B0B0", Slot = "10")]
	public int Init(string callBack_object)
	{
		return default(int);
	}

	[Token(Token = "0x60065A5")]
	[Address(RVA = "0x344B0B8", Offset = "0x344B0B8", VA = "0x344B0B8", Slot = "11")]
	public int JoinRoom(RoomInfo info)
	{
		return default(int);
	}

	[Token(Token = "0x60065A6")]
	[Address(RVA = "0x344B0C0", Offset = "0x344B0C0", VA = "0x344B0C0", Slot = "12")]
	public int LeaveRoom()
	{
		return default(int);
	}

	[Token(Token = "0x60065A7")]
	[Address(RVA = "0x344B0C8", Offset = "0x344B0C8", VA = "0x344B0C8", Slot = "8")]
	public void SetRegion(int region_id, string region_name)
	{
	}

	[Token(Token = "0x60065A8")]
	[Address(RVA = "0x344B0CC", Offset = "0x344B0CC", VA = "0x344B0CC", Slot = "16")]
	public bool HasError(int error_code)
	{
		return default(bool);
	}

	[Token(Token = "0x60065A9")]
	[Address(RVA = "0x344B0D4", Offset = "0x344B0D4", VA = "0x344B0D4", Slot = "17")]
	public void SetVolume(uint volume)
	{
	}

	[Token(Token = "0x60065AA")]
	[Address(RVA = "0x344B0D8", Offset = "0x344B0D8", VA = "0x344B0D8", Slot = "18")]
	public void PauseChannel(bool is_pause)
	{
	}

	[Token(Token = "0x60065AB")]
	[Address(RVA = "0x344B0DC", Offset = "0x344B0DC", VA = "0x344B0DC", Slot = "19")]
	public void SetMidCallback()
	{
	}

	[Token(Token = "0x60065AC")]
	[Address(RVA = "0x344B0E0", Offset = "0x344B0E0", VA = "0x344B0E0", Slot = "20")]
	public int UnInit()
	{
		return default(int);
	}

	[Token(Token = "0x60065AD")]
	[Address(RVA = "0x344B0E8", Offset = "0x344B0E8", VA = "0x344B0E8", Slot = "13")]
	public EGameVoiceEvent ParseEventType(int event_id)
	{
		return default(EGameVoiceEvent);
	}

	[Token(Token = "0x60065AE")]
	[Address(RVA = "0x344B0F0", Offset = "0x344B0F0", VA = "0x344B0F0", Slot = "21")]
	public void OnInited()
	{
	}

	[Token(Token = "0x60065AF")]
	[Address(RVA = "0x344B0F4", Offset = "0x344B0F4", VA = "0x344B0F4", Slot = "22")]
	public void OnJoined(string room_id)
	{
	}

	[Token(Token = "0x60065B0")]
	[Address(RVA = "0x344B0F8", Offset = "0x344B0F8", VA = "0x344B0F8", Slot = "14")]
	public string ParseEventName(int event_id)
	{
		return null;
	}

	[Token(Token = "0x60065B1")]
	[Address(RVA = "0x344B184", Offset = "0x344B184", VA = "0x344B184", Slot = "15")]
	public string ParseErrorCodeName(int error_code)
	{
		return null;
	}

	[Token(Token = "0x60065B2")]
	[Address(RVA = "0x344B210", Offset = "0x344B210", VA = "0x344B210", Slot = "23")]
	public void OnUpdate()
	{
	}

	[Token(Token = "0x60065B3")]
	[Address(RVA = "0x344B214", Offset = "0x344B214", VA = "0x344B214", Slot = "24")]
	public void SetGroupEnvironment(string environment)
	{
	}

	[Token(Token = "0x60065B4")]
	[Address(RVA = "0x344B218", Offset = "0x344B218", VA = "0x344B218", Slot = "25")]
	public void EnableVoiceCaptureCallBack(bool enable)
	{
	}

	[Token(Token = "0x60065B5")]
	[Address(RVA = "0x344B21C", Offset = "0x344B21C", VA = "0x344B21C", Slot = "26")]
	public int MuteTargetPlayer(string player_id, bool is_mute)
	{
		return default(int);
	}

	[Token(Token = "0x60065B6")]
	[Address(RVA = "0x344B224", Offset = "0x344B224", VA = "0x344B224", Slot = "27")]
	public int SetReportInfo(int nTimeSec, string language)
	{
		return default(int);
	}

	[Token(Token = "0x60065B7")]
	[Address(RVA = "0x344B22C", Offset = "0x344B22C", VA = "0x344B22C", Slot = "28")]
	public int ReportUserAudio(string reportUserID, string customData)
	{
		return default(int);
	}
}
