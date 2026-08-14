using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BEF")]
public class PeriodicRankingPointsDesc
{
	[Token(Token = "0x400AFED")]
	[FieldOffset(Offset = "0x8")]
	public uint game_mode;

	[Token(Token = "0x400AFEE")]
	[FieldOffset(Offset = "0xC")]
	public uint index;

	[Token(Token = "0x400AFEF")]
	[FieldOffset(Offset = "0x10")]
	public int solo;

	[Token(Token = "0x400AFF0")]
	[FieldOffset(Offset = "0x14")]
	public int dual;

	[Token(Token = "0x400AFF1")]
	[FieldOffset(Offset = "0x18")]
	public int quad;

	[Token(Token = "0x400AFF2")]
	[FieldOffset(Offset = "0x1C")]
	public int penta;

	[Token(Token = "0x600824A")]
	[Address(RVA = "0x33DF490", Offset = "0x33DF490", VA = "0x33DF490")]
	public PeriodicRankingPointsDesc()
	{
	}
}
