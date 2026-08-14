using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AEB")]
public class ReviveTokenCostDesc
{
	[Token(Token = "0x400A93E")]
	[FieldOffset(Offset = "0x8")]
	public uint gem_cost_self;

	[Token(Token = "0x400A93F")]
	[FieldOffset(Offset = "0xC")]
	public uint gem_cost_teammate;

	[Token(Token = "0x400A940")]
	[FieldOffset(Offset = "0x10")]
	public uint gem_cost_wiped;

	[Token(Token = "0x6008146")]
	[Address(RVA = "0x33E1AB0", Offset = "0x33E1AB0", VA = "0x33E1AB0")]
	public ReviveTokenCostDesc()
	{
	}
}
