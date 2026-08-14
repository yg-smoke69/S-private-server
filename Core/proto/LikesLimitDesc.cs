using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A1F")]
public class LikesLimitDesc
{
	[Token(Token = "0x400A3B5")]
	[FieldOffset(Offset = "0x8")]
	public uint max_likes_per_match;

	[Token(Token = "0x400A3B6")]
	[FieldOffset(Offset = "0xC")]
	public uint max_likes_per_protocol;

	[Token(Token = "0x6008077")]
	[Address(RVA = "0x30A46D4", Offset = "0x30A46D4", VA = "0x30A46D4")]
	public LikesLimitDesc()
	{
	}
}
