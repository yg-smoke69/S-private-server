using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A53")]
public class UnlockProfileConfig
{
	[Token(Token = "0x400A4E5")]
	[FieldOffset(Offset = "0x8")]
	public uint avatar_id;

	[Token(Token = "0x400A4E6")]
	[FieldOffset(Offset = "0xC")]
	public uint level;

	[Token(Token = "0x400A4E7")]
	[FieldOffset(Offset = "0x10")]
	public uint debris_count;

	[Token(Token = "0x400A4E8")]
	[FieldOffset(Offset = "0x14")]
	public uint coins;

	[Token(Token = "0x400A4E9")]
	[FieldOffset(Offset = "0x18")]
	public uint gems;

	[Token(Token = "0x60080AB")]
	[Address(RVA = "0x33E411C", Offset = "0x33E411C", VA = "0x33E411C")]
	public UnlockProfileConfig()
	{
	}
}
