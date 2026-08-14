using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001530")]
public class ExpDetail
{
	[Token(Token = "0x400920B")]
	[FieldOffset(Offset = "0x8")]
	public uint exp_match;

	[Token(Token = "0x400920C")]
	[FieldOffset(Offset = "0xC")]
	public uint exp_clan_buff;

	[Token(Token = "0x400920D")]
	[FieldOffset(Offset = "0x10")]
	public uint exp_event_bonus;

	[Token(Token = "0x400920E")]
	[FieldOffset(Offset = "0x14")]
	public uint exp_card;

	[Token(Token = "0x400920F")]
	[FieldOffset(Offset = "0x18")]
	public uint exp_ranking;

	[Token(Token = "0x4009210")]
	[FieldOffset(Offset = "0x1C")]
	public uint exp_championship;

	[Token(Token = "0x4009211")]
	[FieldOffset(Offset = "0x20")]
	public uint exp_other_bonus;

	[Token(Token = "0x6007B79")]
	[Address(RVA = "0x30A004C", Offset = "0x30A004C", VA = "0x30A004C")]
	public ExpDetail()
	{
	}
}
