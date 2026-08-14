using Il2CppDummyDll;

[Token(Token = "0x2000D4A")]
public static class GameVoiceFacade
{
	[Token(Token = "0x4006B2F")]
	[FieldOffset(Offset = "0x0")]
	private static IGameVoiceInterface m_Impl;

	[Token(Token = "0x4006B30")]
	[FieldOffset(Offset = "0x4")]
	private static GameVoiceImpl_FreeFireVoice _mFreeFireVoiceImpl;

	[Token(Token = "0x170008A5")]
	public static GameVoiceImpl_FreeFireVoice FreeFireVoiceImpl
	{
		[Token(Token = "0x60065D6")]
		[Address(RVA = "0x344884C", Offset = "0x344884C", VA = "0x344884C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60065D7")]
	[Address(RVA = "0x3448A1C", Offset = "0x3448A1C", VA = "0x3448A1C")]
	public static void SetImpl(IGameVoiceInterface impl)
	{
	}

	[Token(Token = "0x60065D8")]
	[Address(RVA = "0x3448ADC", Offset = "0x3448ADC", VA = "0x3448ADC")]
	public static void SetGroupEnvironment(string environment)
	{
	}

	[Token(Token = "0x60065D9")]
	[Address(RVA = "0x3448C44", Offset = "0x3448C44", VA = "0x3448C44")]
	public static void SetRegion(int region_id, string region_name)
	{
	}

	[Token(Token = "0x60065DA")]
	[Address(RVA = "0x3448DC0", Offset = "0x3448DC0", VA = "0x3448DC0")]
	public static void SetExtraConfig(object extra_config)
	{
	}

	[Token(Token = "0x60065DB")]
	[Address(RVA = "0x3448F28", Offset = "0x3448F28", VA = "0x3448F28")]
	public static int Init(string callBack_objectName)
	{
		return default(int);
	}

	[Token(Token = "0x60065DC")]
	[Address(RVA = "0x3449094", Offset = "0x3449094", VA = "0x3449094")]
	public static void OnInited()
	{
	}

	[Token(Token = "0x60065DD")]
	[Address(RVA = "0x34491F4", Offset = "0x34491F4", VA = "0x34491F4")]
	public static int JoinRoom(RoomInfo info)
	{
		return default(int);
	}

	[Token(Token = "0x60065DE")]
	[Address(RVA = "0x3449360", Offset = "0x3449360", VA = "0x3449360")]
	public static void OnJoined(string room_id)
	{
	}

	[Token(Token = "0x60065DF")]
	[Address(RVA = "0x34494C8", Offset = "0x34494C8", VA = "0x34494C8")]
	public static int LeaveRoom()
	{
		return default(int);
	}

	[Token(Token = "0x60065E0")]
	[Address(RVA = "0x344962C", Offset = "0x344962C", VA = "0x344962C")]
	public static void PauseChannel(bool is_pause)
	{
	}

	[Token(Token = "0x60065E1")]
	[Address(RVA = "0x3449794", Offset = "0x3449794", VA = "0x3449794")]
	public static void SetMidCallback()
	{
	}

	[Token(Token = "0x60065E2")]
	[Address(RVA = "0x34498F4", Offset = "0x34498F4", VA = "0x34498F4")]
	public static int UnInit()
	{
		return default(int);
	}

	[Token(Token = "0x60065E3")]
	[Address(RVA = "0x3449A58", Offset = "0x3449A58", VA = "0x3449A58")]
	public static bool HasError(int error_code)
	{
		return default(bool);
	}

	[Token(Token = "0x60065E4")]
	[Address(RVA = "0x3449BC4", Offset = "0x3449BC4", VA = "0x3449BC4")]
	public static EGameVoiceEvent ParseEventType(int event_id)
	{
		return default(EGameVoiceEvent);
	}

	[Token(Token = "0x60065E5")]
	[Address(RVA = "0x3449D30", Offset = "0x3449D30", VA = "0x3449D30")]
	public static string ParseEventName(int event_id)
	{
		return null;
	}

	[Token(Token = "0x60065E6")]
	[Address(RVA = "0x3449EDC", Offset = "0x3449EDC", VA = "0x3449EDC")]
	public static string ParseErrorCodeName(int error_code)
	{
		return null;
	}

	[Token(Token = "0x60065E7")]
	[Address(RVA = "0x344A088", Offset = "0x344A088", VA = "0x344A088")]
	public static void SetVolume(uint volume)
	{
	}

	[Token(Token = "0x60065E8")]
	[Address(RVA = "0x344A1F0", Offset = "0x344A1F0", VA = "0x344A1F0")]
	public static bool IsSameWithCurMicMute(bool value)
	{
		return default(bool);
	}

	[Token(Token = "0x60065E9")]
	[Address(RVA = "0x344A360", Offset = "0x344A360", VA = "0x344A360")]
	public static bool IsSameWithCurSpeakerMute(bool value)
	{
		return default(bool);
	}

	[Token(Token = "0x60065EA")]
	[Address(RVA = "0x344A4D0", Offset = "0x344A4D0", VA = "0x344A4D0")]
	public static void SetMicAndSpeakerMute(bool micro_mute, bool speaker_mute)
	{
	}

	[Token(Token = "0x60065EB")]
	[Address(RVA = "0x344A8B4", Offset = "0x344A8B4", VA = "0x344A8B4")]
	public static void OnUpdate()
	{
	}

	[Token(Token = "0x60065EC")]
	[Address(RVA = "0x344AA14", Offset = "0x344AA14", VA = "0x344AA14")]
	public static void EnableVoiceCaptureCallBack(bool enable)
	{
	}

	[Token(Token = "0x60065ED")]
	[Address(RVA = "0x344AB7C", Offset = "0x344AB7C", VA = "0x344AB7C")]
	public static int MuteTargetPlayer(string player_id, bool is_mute)
	{
		return default(int);
	}

	[Token(Token = "0x60065EE")]
	[Address(RVA = "0x344ACFC", Offset = "0x344ACFC", VA = "0x344ACFC")]
	public static int SetReportInfo(int nTimeSec, string language)
	{
		return default(int);
	}

	[Token(Token = "0x60065EF")]
	[Address(RVA = "0x344AE7C", Offset = "0x344AE7C", VA = "0x344AE7C")]
	public static int ReportUserAudio(string reportUserID, string customData)
	{
		return default(int);
	}
}
