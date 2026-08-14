using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BE7")]
public class LimitedChestABtestDesc
{
	[Token(Token = "0x400AFA9")]
	[FieldOffset(Offset = "0x8")]
	public uint chest_id;

	[Token(Token = "0x400AFAA")]
	[FieldOffset(Offset = "0xC")]
	public uint chest_sub_id;

	[Token(Token = "0x400AFAB")]
	[FieldOffset(Offset = "0x10")]
	public string @class;

	[Token(Token = "0x400AFAC")]
	[FieldOffset(Offset = "0x14")]
	public uint original_melon_pi;

	[Token(Token = "0x400AFAD")]
	[FieldOffset(Offset = "0x18")]
	public uint abtest_melon_pi;

	[Token(Token = "0x6008242")]
	[Address(RVA = "0x30A4808", Offset = "0x30A4808", VA = "0x30A4808")]
	public LimitedChestABtestDesc()
	{
	}
}
