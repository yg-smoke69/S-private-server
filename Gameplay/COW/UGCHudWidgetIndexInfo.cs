using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003282")]
public class UGCHudWidgetIndexInfo
{
	[Token(Token = "0x40133EF")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x40133F0")]
	[FieldOffset(Offset = "0xC")]
	public string Name;

	[Token(Token = "0x60154D0")]
	[Address(RVA = "0x29F0C0C", Offset = "0x29F0C0C", VA = "0x29F0C0C")]
	public UGCHudWidgetIndexInfo()
	{
	}
}
