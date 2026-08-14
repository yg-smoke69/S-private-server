using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001895")]
public class FFWS03TeamCardsInfo
{
	[Token(Token = "0x4009D4D")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x4009D4E")]
	[FieldOffset(Offset = "0xC")]
	public uint level;

	[Token(Token = "0x4009D4F")]
	[FieldOffset(Offset = "0x10")]
	public uint experience;

	[Token(Token = "0x4009D50")]
	[FieldOffset(Offset = "0x14")]
	public uint order;

	[Token(Token = "0x6007EEE")]
	[Address(RVA = "0x30A03A0", Offset = "0x30A03A0", VA = "0x30A03A0")]
	public FFWS03TeamCardsInfo()
	{
	}
}
