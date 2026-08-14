using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x2001E25")]
public class ISparkInterfaceImplMambet : _Attribute
{
	[Token(Token = "0x400BE75")]
	[FieldOffset(Offset = "0x8")]
	private bool _003CDebugEvent_003Ek__BackingField;

	[Token(Token = "0x400BE76")]
	[FieldOffset(Offset = "0x9")]
	private bool _003CDebugVoice_003Ek__BackingField;

	[Token(Token = "0x400BE77")]
	[FieldOffset(Offset = "0x0")]
	private static Action<string> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x400BE78")]
	[FieldOffset(Offset = "0x4")]
	private static Action<string> _003C_003Ef__mg_0024cache1;

	[Token(Token = "0x17000F1F")]
	public bool DebugEvent
	{
		[Token(Token = "0x600902D")]
		[Address(RVA = "0x3106B8C", Offset = "0x3106B8C", VA = "0x3106B8C", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600902E")]
		[Address(RVA = "0x3106B94", Offset = "0x3106B94", VA = "0x3106B94", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000F20")]
	public bool DebugVoice
	{
		[Token(Token = "0x600902F")]
		[Address(RVA = "0x3106B9C", Offset = "0x3106B9C", VA = "0x3106B9C", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009030")]
		[Address(RVA = "0x3106BA4", Offset = "0x3106BA4", VA = "0x3106BA4", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x600902A")]
	[Address(RVA = "0x3106A0C", Offset = "0x3106A0C", VA = "0x3106A0C")]
	public ISparkInterfaceImplMambet()
	{
	}

	[Token(Token = "0x600902B")]
	[Address(RVA = "0x3106A78", Offset = "0x3106A78", VA = "0x3106A78")]
	private static void Log(string log)
	{
	}

	[Token(Token = "0x600902C")]
	[Address(RVA = "0x3106AFC", Offset = "0x3106AFC", VA = "0x3106AFC")]
	private static void LogVerbose(string log)
	{
	}

	[Token(Token = "0x6009031")]
	[Address(RVA = "0x3106BAC", Offset = "0x3106BAC", VA = "0x3106BAC", Slot = "8")]
	public void Init(int game_id)
	{
	}

	[Token(Token = "0x6009032")]
	[Address(RVA = "0x3106CF4", Offset = "0x3106CF4", VA = "0x3106CF4", Slot = "10")]
	public void PushEvent(string type, string data)
	{
	}

	[Token(Token = "0x6009033")]
	[Address(RVA = "0x3106D80", Offset = "0x3106D80", VA = "0x3106D80", Slot = "9")]
	public void SetCurrentAccountID(string account_id)
	{
	}

	[Token(Token = "0x6009034")]
	[Address(RVA = "0x3106E64", Offset = "0x3106E64", VA = "0x3106E64", Slot = "11")]
	public void SetCallBack(Action<bool> connected_callback, Action<bool> mic_callback)
	{
	}

	[Token(Token = "0x6009035")]
	[Address(RVA = "0x310715C", Offset = "0x310715C", VA = "0x310715C", Slot = "12")]
	public void StartVoiceDataSender()
	{
	}

	[Token(Token = "0x6009036")]
	[Address(RVA = "0x3107264", Offset = "0x3107264", VA = "0x3107264", Slot = "13")]
	public void StopVoiceDataSender()
	{
	}

	[Token(Token = "0x6009037")]
	[Address(RVA = "0x31072F4", Offset = "0x31072F4", VA = "0x31072F4", Slot = "14")]
	public void OnSceneLoaded()
	{
	}

	[Token(Token = "0x6009038")]
	[Address(RVA = "0x3107370", Offset = "0x3107370", VA = "0x3107370", Slot = "18")]
	public bool IsCapturingUnityAudio()
	{
		return default(bool);
	}

	[Token(Token = "0x6009039")]
	[Address(RVA = "0x31073EC", Offset = "0x31073EC", VA = "0x31073EC", Slot = "19")]
	public void RequestMic()
	{
	}

	[Token(Token = "0x600903A")]
	[Address(RVA = "0x310747C", Offset = "0x310747C", VA = "0x310747C", Slot = "20")]
	public void ReleaseMic()
	{
	}

	[Token(Token = "0x600903B")]
	[Address(RVA = "0x310750C", Offset = "0x310750C", VA = "0x310750C", Slot = "21")]
	public void OnExternalAudioCaptureStart()
	{
	}

	[Token(Token = "0x600903C")]
	[Address(RVA = "0x310759C", Offset = "0x310759C", VA = "0x310759C", Slot = "22")]
	public void OnExternalAudioCaptureStop()
	{
	}

	[Token(Token = "0x600903D")]
	[Address(RVA = "0x310762C", Offset = "0x310762C", VA = "0x310762C")]
	private void OnUnityAudioCaptureCall(int calls)
	{
	}

	[Token(Token = "0x600903E")]
	[Address(RVA = "0x31077B0", Offset = "0x31077B0", VA = "0x31077B0", Slot = "23")]
	public void OnExternalAudioCaptured(byte[] sample, int channels, int sampleRate, Mambet.ExternalAudioChannel channel, int bytesPerSample)
	{
	}

	[Token(Token = "0x600903F")]
	[Address(RVA = "0x31079D0", Offset = "0x31079D0", VA = "0x31079D0", Slot = "15")]
	public bool IsVoiceDataSenderRunning()
	{
		return default(bool);
	}

	[Token(Token = "0x6009040")]
	[Address(RVA = "0x3107A4C", Offset = "0x3107A4C", VA = "0x3107A4C", Slot = "16")]
	public void StartCaptureUnityAudio()
	{
	}

	[Token(Token = "0x6009041")]
	[Address(RVA = "0x3107ADC", Offset = "0x3107ADC", VA = "0x3107ADC", Slot = "17")]
	public void StopCaptureUnityAudio()
	{
	}
}
