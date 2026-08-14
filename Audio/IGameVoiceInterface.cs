using Il2CppDummyDll;

[Token(Token = "0x2000D45")]
public interface IGameVoiceInterface
{
	[Token(Token = "0x1700089E")]
	bool MicrophoneMute
	{
		[Token(Token = "0x6006585")]
		get;
		[Token(Token = "0x6006586")]
		set;
	}

	[Token(Token = "0x1700089F")]
	bool SpeakerMute
	{
		[Token(Token = "0x6006587")]
		get;
		[Token(Token = "0x6006588")]
		set;
	}

	[Token(Token = "0x6006589")]
	void SetRegion(int region_id, string region_name);

	[Token(Token = "0x600658A")]
	void SetExtraConfig(object extra_config);

	[Token(Token = "0x600658B")]
	int Init(string callBack_object);

	[Token(Token = "0x600658C")]
	int JoinRoom(RoomInfo info);

	[Token(Token = "0x600658D")]
	int LeaveRoom();

	[Token(Token = "0x600658E")]
	EGameVoiceEvent ParseEventType(int event_id);

	[Token(Token = "0x600658F")]
	string ParseEventName(int event_id);

	[Token(Token = "0x6006590")]
	string ParseErrorCodeName(int error_code);

	[Token(Token = "0x6006591")]
	bool HasError(int error_code);

	[Token(Token = "0x6006592")]
	void SetVolume(uint volume);

	[Token(Token = "0x6006593")]
	void PauseChannel(bool is_pause);

	[Token(Token = "0x6006594")]
	void SetMidCallback();

	[Token(Token = "0x6006595")]
	int UnInit();

	[Token(Token = "0x6006596")]
	void OnInited();

	[Token(Token = "0x6006597")]
	void OnJoined(string room_id);

	[Token(Token = "0x6006598")]
	void OnUpdate();

	[Token(Token = "0x6006599")]
	void SetGroupEnvironment(string environment);

	[Token(Token = "0x600659A")]
	void EnableVoiceCaptureCallBack(bool enable);

	[Token(Token = "0x600659B")]
	int MuteTargetPlayer(string player_id, bool is_mute);

	[Token(Token = "0x600659C")]
	int SetReportInfo(int nTimeSec, string language);

	[Token(Token = "0x600659D")]
	int ReportUserAudio(string reportUserID, string customData);
}
