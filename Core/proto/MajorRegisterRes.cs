using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001722")]
public class MajorRegisterRes
{
	[Token(Token = "0x4009918")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009919")]
	[FieldOffset(Offset = "0x10")]
	public bool first_game_open;

	[Token(Token = "0x400991A")]
	[FieldOffset(Offset = "0x11")]
	public bool br_tutorial_open;

	[Token(Token = "0x400991B")]
	[FieldOffset(Offset = "0x12")]
	public bool cs_tutorial_open;

	[Token(Token = "0x400991C")]
	[FieldOffset(Offset = "0x13")]
	public bool cs_abtest;

	[Token(Token = "0x400991D")]
	[FieldOffset(Offset = "0x14")]
	public bool basic_guide_open;

	[Token(Token = "0x400991E")]
	[FieldOffset(Offset = "0x15")]
	public bool is_nickname_success;

	[Token(Token = "0x400991F")]
	[FieldOffset(Offset = "0x18")]
	public string nickname;

	[Token(Token = "0x6007D7C")]
	[Address(RVA = "0x30A77B0", Offset = "0x30A77B0", VA = "0x30A77B0")]
	public MajorRegisterRes()
	{
	}
}
