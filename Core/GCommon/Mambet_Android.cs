using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003F80")]
public static class Mambet_Android
{
	[Token(Token = "0x401AC51")]
	[FieldOffset(Offset = "0x0")]
	private static AndroidJavaClass _Mambet;

	[Token(Token = "0x17001C3A")]
	private static AndroidJavaClass Mambet
	{
		[Token(Token = "0x6019DA0")]
		[Address(RVA = "0x296833C", Offset = "0x296833C", VA = "0x296833C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6019DA1")]
	[Address(RVA = "0x2963490", Offset = "0x2963490", VA = "0x2963490")]
	public static void SetUnitySendMessageGameObjectName(string gameObjectName)
	{
	}

	[Token(Token = "0x6019DA2")]
	[Address(RVA = "0x29632F4", Offset = "0x29632F4", VA = "0x29632F4")]
	public static void Init(int game_id, bool debug_mode)
	{
	}

	[Token(Token = "0x6019DA3")]
	[Address(RVA = "0x2963594", Offset = "0x2963594", VA = "0x2963594")]
	public static void SetAccountID(string accountID)
	{
	}

	[Token(Token = "0x6019DA4")]
	[Address(RVA = "0x2963698", Offset = "0x2963698", VA = "0x2963698")]
	public static void PushEvent(string type, string data)
	{
	}

	[Token(Token = "0x6019DA5")]
	[Address(RVA = "0x296280C", Offset = "0x296280C", VA = "0x296280C")]
	public static void VoiceDataSender_Start(bool debug_voice)
	{
	}

	[Token(Token = "0x6019DA6")]
	[Address(RVA = "0x29629C8", Offset = "0x29629C8", VA = "0x29629C8")]
	public static void VoiceDataSender_Stop()
	{
	}

	[Token(Token = "0x6019DA7")]
	[Address(RVA = "0x2964E40", Offset = "0x2964E40", VA = "0x2964E40")]
	public static void VoiceDataSender_SendUnityAudioData(int channels, int samplingRateHz, float[] sample, int id)
	{
	}

	[Token(Token = "0x6019DA8")]
	[Address(RVA = "0x2965D2C", Offset = "0x2965D2C", VA = "0x2965D2C")]
	public static void VoiceDataSender_SendAudioData(int channels, int samplingRateHz, int bytesPerSample, byte[] sample, int source, int id)
	{
	}

	[Token(Token = "0x6019DA9")]
	[Address(RVA = "0x2962AF4", Offset = "0x2962AF4", VA = "0x2962AF4")]
	public static void VoiceDataSender_RequestMic()
	{
	}

	[Token(Token = "0x6019DAA")]
	[Address(RVA = "0x2962B94", Offset = "0x2962B94", VA = "0x2962B94")]
	public static void VoiceDataSender_ReleaseMic()
	{
	}
}
