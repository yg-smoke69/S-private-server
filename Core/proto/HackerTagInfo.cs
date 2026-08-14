using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20012F6")]
public class HackerTagInfo
{
	[Token(Token = "0x40085B2")]
	[FieldOffset(Offset = "0x8")]
	public uint hacker_tag;

	[Token(Token = "0x40085B3")]
	[FieldOffset(Offset = "0x10")]
	public long hackerpool_time;

	[Token(Token = "0x6007A43")]
	[Address(RVA = "0x30A2F0C", Offset = "0x30A2F0C", VA = "0x30A2F0C")]
	public HackerTagInfo()
	{
	}
}
