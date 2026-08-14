using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001555")]
public class CSFeedPetRes
{
	[Token(Token = "0x40092C9")]
	[FieldOffset(Offset = "0x8")]
	public uint old_level;

	[Token(Token = "0x40092CA")]
	[FieldOffset(Offset = "0xC")]
	public uint new_level;

	[Token(Token = "0x40092CB")]
	[FieldOffset(Offset = "0x10")]
	public uint old_exp;

	[Token(Token = "0x40092CC")]
	[FieldOffset(Offset = "0x14")]
	public uint new_exp;

	[Token(Token = "0x40092CD")]
	[FieldOffset(Offset = "0x18")]
	public uint add_exp;

	[Token(Token = "0x6007B9D")]
	[Address(RVA = "0x318052C", Offset = "0x318052C", VA = "0x318052C")]
	public CSFeedPetRes()
	{
	}
}
