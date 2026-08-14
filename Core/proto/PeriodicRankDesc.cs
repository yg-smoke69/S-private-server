using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BEC")]
public class PeriodicRankDesc
{
	[Token(Token = "0x400AFDD")]
	[FieldOffset(Offset = "0x8")]
	public uint game_mode;

	[Token(Token = "0x400AFDE")]
	[FieldOffset(Offset = "0xC")]
	public uint rank;

	[Token(Token = "0x400AFDF")]
	[FieldOffset(Offset = "0x10")]
	public string rank_desc;

	[Token(Token = "0x400AFE0")]
	[FieldOffset(Offset = "0x14")]
	public string rank_name;

	[Token(Token = "0x400AFE1")]
	[FieldOffset(Offset = "0x18")]
	public uint rank_up_star;

	[Token(Token = "0x400AFE2")]
	[FieldOffset(Offset = "0x1C")]
	public uint lower_bound;

	[Token(Token = "0x400AFE3")]
	[FieldOffset(Offset = "0x20")]
	public uint upper_bound;

	[Token(Token = "0x400AFE4")]
	[FieldOffset(Offset = "0x24")]
	public bool is_streak_bonus;

	[Token(Token = "0x400AFE5")]
	[FieldOffset(Offset = "0x25")]
	public bool is_rank_protect;

	[Token(Token = "0x400AFE6")]
	[FieldOffset(Offset = "0x28")]
	public uint achieve_protection_score;

	[Token(Token = "0x6008247")]
	[Address(RVA = "0x33DF348", Offset = "0x33DF348", VA = "0x33DF348")]
	public PeriodicRankDesc()
	{
	}
}
