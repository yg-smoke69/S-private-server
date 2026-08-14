using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200151D")]
public class MatchAccountStats
{
	[Token(Token = "0x40090BE")]
	[FieldOffset(Offset = "0x8")]
	public ulong match_id;

	[Token(Token = "0x40090BF")]
	[FieldOffset(Offset = "0x10")]
	public ulong account_id;

	[Token(Token = "0x40090C0")]
	[FieldOffset(Offset = "0x18")]
	public uint create_time;

	[Token(Token = "0x40090C1")]
	[FieldOffset(Offset = "0x1C")]
	public uint end_time;

	[Token(Token = "0x40090C2")]
	[FieldOffset(Offset = "0x20")]
	public MatchIncome income;

	[Token(Token = "0x40090C3")]
	[FieldOffset(Offset = "0x24")]
	public MatchStats stats;

	[Token(Token = "0x6007B66")]
	[Address(RVA = "0x30A7988", Offset = "0x30A7988", VA = "0x30A7988")]
	public MatchAccountStats()
	{
	}
}
