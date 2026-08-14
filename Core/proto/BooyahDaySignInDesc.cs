using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B4B")]
public class BooyahDaySignInDesc
{
	[Token(Token = "0x400ABB4")]
	[FieldOffset(Offset = "0x8")]
	public uint sign_id;

	[Token(Token = "0x400ABB5")]
	[FieldOffset(Offset = "0xC")]
	public uint booyah_num;

	[Token(Token = "0x400ABB6")]
	[FieldOffset(Offset = "0x10")]
	public uint token_id;

	[Token(Token = "0x400ABB7")]
	[FieldOffset(Offset = "0x14")]
	public uint token_num;

	[Token(Token = "0x60081A6")]
	[Address(RVA = "0x317CBD8", Offset = "0x317CBD8", VA = "0x317CBD8")]
	public BooyahDaySignInDesc()
	{
	}
}
