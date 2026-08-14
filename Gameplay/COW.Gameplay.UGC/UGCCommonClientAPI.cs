using System.Collections.Generic;
using Il2CppDummyDll;
using message;

namespace COW.Gameplay.UGC;

[Token(Token = "0x2000C22")]
internal class UGCCommonClientAPI
{
	[Token(Token = "0x6005CBA")]
	[Address(RVA = "0x2F5B910", Offset = "0x2F5B910", VA = "0x2F5B910")]
	public UGCCommonClientAPI()
	{
	}

	[Token(Token = "0x6005CBB")]
	[Address(RVA = "0x2F5B918", Offset = "0x2F5B918", VA = "0x2F5B918")]
	public static void TestPlaySound()
	{
	}

	[Token(Token = "0x6005CBC")]
	[Address(RVA = "0x2F5B9B8", Offset = "0x2F5B9B8", VA = "0x2F5B9B8")]
	public static void PlaySound(string audioType)
	{
	}

	[Token(Token = "0x6005CBD")]
	[Address(RVA = "0x2F5BBD0", Offset = "0x2F5BBD0", VA = "0x2F5BBD0")]
	public static void PlayEffect(List<BGMHHCHJDFI> args)
	{
	}
}
