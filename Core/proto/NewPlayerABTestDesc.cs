using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A1E")]
public class NewPlayerABTestDesc
{
	[Token(Token = "0x400A3B2")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A3B3")]
	[FieldOffset(Offset = "0xC")]
	public bool ab_test_switch;

	[Token(Token = "0x400A3B4")]
	[FieldOffset(Offset = "0x10")]
	public uint probability;

	[Token(Token = "0x6008076")]
	[Address(RVA = "0x30A9BE8", Offset = "0x30A9BE8", VA = "0x30A9BE8")]
	public NewPlayerABTestDesc()
	{
	}
}
