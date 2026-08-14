using System;
using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x2001E27")]
public static class SparkFacade
{
	[Token(Token = "0x400BE7B")]
	[FieldOffset(Offset = "0x0")]
	private static ISparkInterface m_Impl;

	[Token(Token = "0x6009057")]
	[Address(RVA = "0x21D59C8", Offset = "0x21D59C8", VA = "0x21D59C8")]
	public static void SetImpl(ISparkInterface impl)
	{
	}

	[Token(Token = "0x6009058")]
	[Address(RVA = "0x21D5A80", Offset = "0x21D5A80", VA = "0x21D5A80")]
	public static void SetDebugEvent(bool debug)
	{
	}

	[Token(Token = "0x6009059")]
	[Address(RVA = "0x21D5BE8", Offset = "0x21D5BE8", VA = "0x21D5BE8")]
	public static void SetDebugVoice(bool debug)
	{
	}

	[Token(Token = "0x600905A")]
	[Address(RVA = "0x21D5D50", Offset = "0x21D5D50", VA = "0x21D5D50")]
	public static void Init(int game_id)
	{
	}

	[Token(Token = "0x600905B")]
	[Address(RVA = "0x21D5EB8", Offset = "0x21D5EB8", VA = "0x21D5EB8")]
	public static void SetCurrentAccountID(string account_id)
	{
	}

	[Token(Token = "0x600905C")]
	[Address(RVA = "0x21D6020", Offset = "0x21D6020", VA = "0x21D6020")]
	public static void PushEvent(string type, string data)
	{
	}

	[Token(Token = "0x600905D")]
	[Address(RVA = "0x21D623C", Offset = "0x21D623C", VA = "0x21D623C")]
	public static void SetCallBack(Action<bool> connected_callback, Action<bool> mic_callback)
	{
	}

	[Token(Token = "0x600905E")]
	[Address(RVA = "0x21D63B8", Offset = "0x21D63B8", VA = "0x21D63B8")]
	public static void StartVoiceDataSender()
	{
	}

	[Token(Token = "0x600905F")]
	[Address(RVA = "0x21D6518", Offset = "0x21D6518", VA = "0x21D6518")]
	public static void StopVoiceDataSender()
	{
	}

	[Token(Token = "0x6009060")]
	[Address(RVA = "0x21D6678", Offset = "0x21D6678", VA = "0x21D6678")]
	public static void OnSceneLoaded()
	{
	}

	[Token(Token = "0x6009061")]
	[Address(RVA = "0x21D67D8", Offset = "0x21D67D8", VA = "0x21D67D8")]
	public static bool IsVoiceDataSenderRunning()
	{
		return default(bool);
	}

	[Token(Token = "0x6009062")]
	[Address(RVA = "0x21D693C", Offset = "0x21D693C", VA = "0x21D693C")]
	public static void StartCaptureUnityAudio()
	{
	}

	[Token(Token = "0x6009063")]
	[Address(RVA = "0x21D6A9C", Offset = "0x21D6A9C", VA = "0x21D6A9C")]
	public static void StopCaptureUnityAudio()
	{
	}

	[Token(Token = "0x6009064")]
	[Address(RVA = "0x21D6BFC", Offset = "0x21D6BFC", VA = "0x21D6BFC")]
	public static bool IsCapturingUnityAudio()
	{
		return default(bool);
	}

	[Token(Token = "0x6009065")]
	[Address(RVA = "0x21D6D60", Offset = "0x21D6D60", VA = "0x21D6D60")]
	public static void RequestMic()
	{
	}

	[Token(Token = "0x6009066")]
	[Address(RVA = "0x21D6EC0", Offset = "0x21D6EC0", VA = "0x21D6EC0")]
	public static void ReleaseMic()
	{
	}

	[Token(Token = "0x6009067")]
	[Address(RVA = "0x21D7020", Offset = "0x21D7020", VA = "0x21D7020")]
	public static void OnExternalAudioCaptureStart()
	{
	}

	[Token(Token = "0x6009068")]
	[Address(RVA = "0x21D7180", Offset = "0x21D7180", VA = "0x21D7180")]
	public static void OnExternalAudioCaptureStop()
	{
	}

	[Token(Token = "0x6009069")]
	[Address(RVA = "0x21D72E0", Offset = "0x21D72E0", VA = "0x21D72E0")]
	public static void OnExternalAudioCaptured(byte[] sample, int channels, int sampleRate, Mambet.ExternalAudioChannel channel, int bytesPerSample)
	{
	}
}
