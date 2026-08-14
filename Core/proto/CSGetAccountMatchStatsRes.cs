using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001516")]
public class CSGetAccountMatchStatsRes
{
	[Token(Token = "0x40090AD")]
	[FieldOffset(Offset = "0x8")]
	public MatchIncome income;

	[Token(Token = "0x40090AE")]
	[FieldOffset(Offset = "0xC")]
	public MatchStats stats;

	[Token(Token = "0x6007B5F")]
	[Address(RVA = "0x3180D50", Offset = "0x3180D50", VA = "0x3180D50")]
	public CSGetAccountMatchStatsRes()
	{
	}
}
