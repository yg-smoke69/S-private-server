using System;
using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x2001E24")]
public interface ISparkInterface
{
	[Token(Token = "0x17000F1D")]
	bool DebugEvent
	{
		[Token(Token = "0x6009016")]
		get;
		[Token(Token = "0x6009017")]
		set;
	}

	[Token(Token = "0x17000F1E")]
	bool DebugVoice
	{
		[Token(Token = "0x6009018")]
		get;
		[Token(Token = "0x6009019")]
		set;
	}

	[Token(Token = "0x600901A")]
	void Init(int game_id);

	[Token(Token = "0x600901B")]
	void SetCurrentAccountID(string account_id);

	[Token(Token = "0x600901C")]
	void PushEvent(string type, string data);

	[Token(Token = "0x600901D")]
	void SetCallBack(Action<bool> connected_callback, Action<bool> mic_callback);

	[Token(Token = "0x600901E")]
	void StartVoiceDataSender();

	[Token(Token = "0x600901F")]
	void StopVoiceDataSender();

	[Token(Token = "0x6009020")]
	void OnSceneLoaded();

	[Token(Token = "0x6009021")]
	bool IsVoiceDataSenderRunning();

	[Token(Token = "0x6009022")]
	void StartCaptureUnityAudio();

	[Token(Token = "0x6009023")]
	void StopCaptureUnityAudio();

	[Token(Token = "0x6009024")]
	bool IsCapturingUnityAudio();

	[Token(Token = "0x6009025")]
	void RequestMic();

	[Token(Token = "0x6009026")]
	void ReleaseMic();

	[Token(Token = "0x6009027")]
	void OnExternalAudioCaptureStart();

	[Token(Token = "0x6009028")]
	void OnExternalAudioCaptureStop();

	[Token(Token = "0x6009029")]
	void OnExternalAudioCaptured(byte[] sample, int channels, int sampleRate, Mambet.ExternalAudioChannel channel, int bytesPerSample);
}
