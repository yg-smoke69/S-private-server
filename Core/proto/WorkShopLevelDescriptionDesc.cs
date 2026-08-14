using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C2D")]
public class WorkShopLevelDescriptionDesc
{
	[Token(Token = "0x400B16C")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400B16D")]
	[FieldOffset(Offset = "0xC")]
	public uint game_mode;

	[Token(Token = "0x400B16E")]
	[FieldOffset(Offset = "0x10")]
	public string image_url;

	[Token(Token = "0x6008291")]
	[Address(RVA = "0x33E5EE0", Offset = "0x33E5EE0", VA = "0x33E5EE0")]
	public WorkShopLevelDescriptionDesc()
	{
	}
}
