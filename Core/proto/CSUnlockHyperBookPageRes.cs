using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200198D")]
public class CSUnlockHyperBookPageRes
{
	[Token(Token = "0x400A011")]
	[FieldOffset(Offset = "0x8")]
	public uint book_id;

	[Token(Token = "0x400A012")]
	[FieldOffset(Offset = "0xC")]
	public uint sort_id;

	[Token(Token = "0x400A013")]
	[FieldOffset(Offset = "0x10")]
	public ExchangeChangeData award;

	[Token(Token = "0x6007FE8")]
	[Address(RVA = "0x309A4A4", Offset = "0x309A4A4", VA = "0x309A4A4")]
	public CSUnlockHyperBookPageRes()
	{
	}
}
