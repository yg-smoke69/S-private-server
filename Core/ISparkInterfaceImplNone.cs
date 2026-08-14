using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x2001E26")]
public class ISparkInterfaceImplNone : _Attribute
{
	[Token(Token = "0x400BE79")]
	[FieldOffset(Offset = "0x8")]
	private bool _003CDebugEvent_003Ek__BackingField;

	[Token(Token = "0x400BE7A")]
	[FieldOffset(Offset = "0x9")]
	private bool _003CDebugVoice_003Ek__BackingField;

	[Token(Token = "0x17000F21")]
	public bool DebugEvent
	{
		[Token(Token = "0x6009045")]
		[Address(RVA = "0x3107B7C", Offset = "0x3107B7C", VA = "0x3107B7C", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009046")]
		[Address(RVA = "0x3107B84", Offset = "0x3107B84", VA = "0x3107B84", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000F22")]
	public bool DebugVoice
	{
		[Token(Token = "0x6009047")]
		[Address(RVA = "0x3107B8C", Offset = "0x3107B8C", VA = "0x3107B8C", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009048")]
		[Address(RVA = "0x3107B94", Offset = "0x3107B94", VA = "0x3107B94", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x6009042")]
	[Address(RVA = "0x3107B6C", Offset = "0x3107B6C", VA = "0x3107B6C")]
	public ISparkInterfaceImplNone()
	{
	}

	[Token(Token = "0x6009043")]
	[Address(RVA = "0x3107B74", Offset = "0x3107B74", VA = "0x3107B74", Slot = "10")]
	public void PushEvent(string type, string data)
	{
	}

	[Token(Token = "0x6009044")]
	[Address(RVA = "0x3107B78", Offset = "0x3107B78", VA = "0x3107B78", Slot = "9")]
	public void SetCurrentAccountID(string account_id)
	{
	}

	[Token(Token = "0x6009049")]
	[Address(RVA = "0x3107B9C", Offset = "0x3107B9C", VA = "0x3107B9C", Slot = "8")]
	public void Init(int game_id)
	{
	}

	[Token(Token = "0x600904A")]
	[Address(RVA = "0x3107BA0", Offset = "0x3107BA0", VA = "0x3107BA0", Slot = "11")]
	public void SetCallBack(Action<bool> connected_callback, Action<bool> mic_callback)
	{
	}

	[Token(Token = "0x600904B")]
	[Address(RVA = "0x3107BA4", Offset = "0x3107BA4", VA = "0x3107BA4", Slot = "12")]
	public void StartVoiceDataSender()
	{
	}

	[Token(Token = "0x600904C")]
	[Address(RVA = "0x3107BA8", Offset = "0x3107BA8", VA = "0x3107BA8", Slot = "13")]
	public void StopVoiceDataSender()
	{
	}

	[Token(Token = "0x600904D")]
	[Address(RVA = "0x3107BAC", Offset = "0x3107BAC", VA = "0x3107BAC", Slot = "14")]
	public void OnSceneLoaded()
	{
	}

	[Token(Token = "0x600904E")]
	[Address(RVA = "0x3107BB0", Offset = "0x3107BB0", VA = "0x3107BB0", Slot = "18")]
	public bool IsCapturingUnityAudio()
	{
		return default(bool);
	}

	[Token(Token = "0x600904F")]
	[Address(RVA = "0x3107BB8", Offset = "0x3107BB8", VA = "0x3107BB8", Slot = "19")]
	public void RequestMic()
	{
	}

	[Token(Token = "0x6009050")]
	[Address(RVA = "0x3107BBC", Offset = "0x3107BBC", VA = "0x3107BBC", Slot = "20")]
	public void ReleaseMic()
	{
	}

	[Token(Token = "0x6009051")]
	[Address(RVA = "0x3107BC0", Offset = "0x3107BC0", VA = "0x3107BC0", Slot = "21")]
	public void OnExternalAudioCaptureStart()
	{
	}

	[Token(Token = "0x6009052")]
	[Address(RVA = "0x3107C3C", Offset = "0x3107C3C", VA = "0x3107C3C", Slot = "22")]
	public void OnExternalAudioCaptureStop()
	{
	}

	[Token(Token = "0x6009053")]
	[Address(RVA = "0x3107CB8", Offset = "0x3107CB8", VA = "0x3107CB8", Slot = "23")]
	public void OnExternalAudioCaptured(byte[] sample, int channels, int sampleRate, Mambet.ExternalAudioChannel channel, int bytesPerSample)
	{
	}

	[Token(Token = "0x6009054")]
	[Address(RVA = "0x3107CBC", Offset = "0x3107CBC", VA = "0x3107CBC", Slot = "15")]
	public bool IsVoiceDataSenderRunning()
	{
		return default(bool);
	}

	[Token(Token = "0x6009055")]
	[Address(RVA = "0x3107CC4", Offset = "0x3107CC4", VA = "0x3107CC4", Slot = "16")]
	public void StartCaptureUnityAudio()
	{
	}

	[Token(Token = "0x6009056")]
	[Address(RVA = "0x3107CC8", Offset = "0x3107CC8", VA = "0x3107CC8", Slot = "17")]
	public void StopCaptureUnityAudio()
	{
	}
}
