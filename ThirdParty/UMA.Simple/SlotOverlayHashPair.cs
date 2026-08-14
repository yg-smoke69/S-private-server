using System.Collections.Generic;
using Il2CppDummyDll;

namespace UMA.Simple;

[Token(Token = "0x2003C87")]
public class SlotOverlayHashPair
{
	[Token(Token = "0x4019B94")]
	[FieldOffset(Offset = "0x8")]
	public int SlotHash;

	[Token(Token = "0x4019B95")]
	[FieldOffset(Offset = "0xC")]
	public int OverlayHash;

	[Token(Token = "0x4019B96")]
	[FieldOffset(Offset = "0x10")]
	public bool NullOverlay;

	[Token(Token = "0x4019B97")]
	[FieldOffset(Offset = "0x0")]
	private static List<SlotOverlayHashPair> s_SharedList;

	[Token(Token = "0x601836C")]
	[Address(RVA = "0x2D66B74", Offset = "0x2D66B74", VA = "0x2D66B74")]
	public SlotOverlayHashPair(int s, int o, bool n)
	{
	}

	[Token(Token = "0x601836D")]
	[Address(RVA = "0x2D66BA4", Offset = "0x2D66BA4", VA = "0x2D66BA4")]
	public static List<SlotOverlayHashPair> GetSharedList(bool clear = true)
	{
		return null;
	}
}
