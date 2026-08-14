using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20012F7")]
public class HackerInfo
{
	[Token(Token = "0x40085B4")]
	[FieldOffset(Offset = "0x8")]
	public uint hacker_cdt_id;

	[Token(Token = "0x40085B5")]
	[FieldOffset(Offset = "0xC")]
	public uint hacker_tag;

	[Token(Token = "0x40085B6")]
	[FieldOffset(Offset = "0x10")]
	public long hackerpool_time;

	[Token(Token = "0x6007A44")]
	[Address(RVA = "0x30A2E64", Offset = "0x30A2E64", VA = "0x30A2E64")]
	public HackerInfo()
	{
	}
}
