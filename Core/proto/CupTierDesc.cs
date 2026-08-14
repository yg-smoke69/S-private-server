using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BA5")]
public class CupTierDesc
{
	[Token(Token = "0x400ADE2")]
	[FieldOffset(Offset = "0x8")]
	public uint cup_type;

	[Token(Token = "0x400ADE3")]
	[FieldOffset(Offset = "0xC")]
	public uint tier;

	[Token(Token = "0x400ADE4")]
	[FieldOffset(Offset = "0x10")]
	public uint tier_lower_bound;

	[Token(Token = "0x400ADE5")]
	[FieldOffset(Offset = "0x14")]
	public bool is_pure_tier;

	[Token(Token = "0x6008200")]
	[Address(RVA = "0x309DFA0", Offset = "0x309DFA0", VA = "0x309DFA0")]
	public CupTierDesc()
	{
	}
}
