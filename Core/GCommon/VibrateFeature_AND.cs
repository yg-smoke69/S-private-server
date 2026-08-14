using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x200404E")]
public static class VibrateFeature_AND
{
	[Token(Token = "0x401B0FF")]
	[FieldOffset(Offset = "0x0")]
	private static AndroidJavaClass m_VibrateUtil;

	[Token(Token = "0x401B100")]
	[FieldOffset(Offset = "0x4")]
	private static AndroidJavaObject m_CurrentActivity;

	[Token(Token = "0x17001CB6")]
	private static AndroidJavaClass VibrateUtil
	{
		[Token(Token = "0x601A2BC")]
		[Address(RVA = "0x2BD556C", Offset = "0x2BD556C", VA = "0x2BD556C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CB7")]
	private static AndroidJavaObject CurrentAvtivity
	{
		[Token(Token = "0x601A2BD")]
		[Address(RVA = "0x2BD562C", Offset = "0x2BD562C", VA = "0x2BD562C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601A2BE")]
	[Address(RVA = "0x2BD5720", Offset = "0x2BD5720", VA = "0x2BD5720")]
	public static void StartVibrate(long[] _vibrateInfo, bool _isLoop = false)
	{
	}

	[Token(Token = "0x601A2BF")]
	[Address(RVA = "0x2BD58F4", Offset = "0x2BD58F4", VA = "0x2BD58F4")]
	public static void StopVibrate()
	{
	}
}
