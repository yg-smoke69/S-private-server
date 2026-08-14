using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019B7")]
public class MysteryBonusProbabilityDesc
{
	[Token(Token = "0x400A128")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A129")]
	[FieldOffset(Offset = "0xC")]
	public uint probability_id;

	[Token(Token = "0x400A12A")]
	[FieldOffset(Offset = "0x10")]
	public uint start_stage;

	[Token(Token = "0x400A12B")]
	[FieldOffset(Offset = "0x14")]
	public uint end_stage;

	[Token(Token = "0x400A12C")]
	[FieldOffset(Offset = "0x18")]
	public uint probability_weight;

	[Token(Token = "0x600800F")]
	[Address(RVA = "0x30A963C", Offset = "0x30A963C", VA = "0x30A963C")]
	public MysteryBonusProbabilityDesc()
	{
	}
}
