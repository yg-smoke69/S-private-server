using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200151E")]
public class APIMatchAccountStats
{
	[Token(Token = "0x40090C4")]
	[FieldOffset(Offset = "0x8")]
	public ulong match_id;

	[Token(Token = "0x40090C5")]
	[FieldOffset(Offset = "0x10")]
	public ulong account_id;

	[Token(Token = "0x40090C6")]
	[FieldOffset(Offset = "0x18")]
	public uint create_time;

	[Token(Token = "0x40090C7")]
	[FieldOffset(Offset = "0x1C")]
	public uint end_time;

	[Token(Token = "0x40090C8")]
	[FieldOffset(Offset = "0x20")]
	public MatchIncome income;

	[Token(Token = "0x40090C9")]
	[FieldOffset(Offset = "0x24")]
	public MatchStats match_stats;

	[Token(Token = "0x6007B67")]
	[Address(RVA = "0x3179384", Offset = "0x3179384", VA = "0x3179384")]
	public APIMatchAccountStats()
	{
	}
}
