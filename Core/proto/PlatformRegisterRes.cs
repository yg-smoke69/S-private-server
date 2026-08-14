using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200139D")]
public class PlatformRegisterRes
{
	[Token(Token = "0x4008A34")]
	[FieldOffset(Offset = "0x8")]
	public bool success;

	[Token(Token = "0x4008A35")]
	[FieldOffset(Offset = "0xC")]
	public string reason;

	[Token(Token = "0x4008A36")]
	[FieldOffset(Offset = "0x10")]
	public ulong account_id;

	[Token(Token = "0x4008A37")]
	[FieldOffset(Offset = "0x18")]
	public bool first_game_open;

	[Token(Token = "0x4008A38")]
	[FieldOffset(Offset = "0x19")]
	public bool br_tutorial_open;

	[Token(Token = "0x4008A39")]
	[FieldOffset(Offset = "0x1A")]
	public bool cs_tutorial_open;

	[Token(Token = "0x4008A3A")]
	[FieldOffset(Offset = "0x1B")]
	public bool cs_abtest;

	[Token(Token = "0x4008A3B")]
	[FieldOffset(Offset = "0x1C")]
	public bool basic_guide_open;

	[Token(Token = "0x4008A3C")]
	[FieldOffset(Offset = "0x20")]
	public string nickname;

	[Token(Token = "0x6007A98")]
	[Address(RVA = "0x33DFDE8", Offset = "0x33DFDE8", VA = "0x33DFDE8")]
	public PlatformRegisterRes()
	{
	}
}
