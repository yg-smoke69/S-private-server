using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004099")]
internal class UPDMessagePoolManager
{
	[Token(Token = "0x401B240")]
	[FieldOffset(Offset = "0x0")]
	private static List<UPDMessagePoolInterface> Pools;

	[Token(Token = "0x601A4AD")]
	[Address(RVA = "0x2BC50F8", Offset = "0x2BC50F8", VA = "0x2BC50F8")]
	public UPDMessagePoolManager()
	{
	}

	[Token(Token = "0x601A4AE")]
	[Address(RVA = "0x2BC5100", Offset = "0x2BC5100", VA = "0x2BC5100")]
	public static void ClearPool()
	{
	}

	[Token(Token = "0x601A4AF")]
	[Address(RVA = "0x2BC530C", Offset = "0x2BC530C", VA = "0x2BC530C")]
	public static void Register(UPDMessagePoolInterface pool)
	{
	}
}
