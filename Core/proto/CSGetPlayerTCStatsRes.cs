using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200151A")]
public class CSGetPlayerTCStatsRes
{
	[Token(Token = "0x40090B8")]
	[FieldOffset(Offset = "0x8")]
	public AccountInfoWithTCStats cs_stats;

	[Token(Token = "0x6007B63")]
	[Address(RVA = "0x3094998", Offset = "0x3094998", VA = "0x3094998")]
	public CSGetPlayerTCStatsRes()
	{
	}
}
