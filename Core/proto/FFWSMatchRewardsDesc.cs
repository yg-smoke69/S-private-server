using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B94")]
public class FFWSMatchRewardsDesc
{
	[Token(Token = "0x400AD77")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AD78")]
	[FieldOffset(Offset = "0xC")]
	public uint match_score_lower_bound;

	[Token(Token = "0x400AD79")]
	[FieldOffset(Offset = "0x10")]
	public uint match_score_upper_bound;

	[Token(Token = "0x400AD7A")]
	[FieldOffset(Offset = "0x14")]
	public uint experience;

	[Token(Token = "0x400AD7B")]
	[FieldOffset(Offset = "0x18")]
	public uint award_id;

	[Token(Token = "0x400AD7C")]
	[FieldOffset(Offset = "0x1C")]
	public uint award_num;

	[Token(Token = "0x60081EF")]
	[Address(RVA = "0x30A0514", Offset = "0x30A0514", VA = "0x30A0514")]
	public FFWSMatchRewardsDesc()
	{
	}
}
