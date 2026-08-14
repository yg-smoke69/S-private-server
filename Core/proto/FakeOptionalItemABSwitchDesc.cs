using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B07")]
public class FakeOptionalItemABSwitchDesc
{
	[Token(Token = "0x400A9F1")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A9F2")]
	[FieldOffset(Offset = "0xC")]
	public bool ab_test_switch;

	[Token(Token = "0x400A9F3")]
	[FieldOffset(Offset = "0x10")]
	public uint probability;

	[Token(Token = "0x6008162")]
	[Address(RVA = "0x30A0ACC", Offset = "0x30A0ACC", VA = "0x30A0ACC")]
	public FakeOptionalItemABSwitchDesc()
	{
	}
}
