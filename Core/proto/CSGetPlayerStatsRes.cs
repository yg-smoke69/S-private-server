using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001518")]
public class CSGetPlayerStatsRes
{
	[Token(Token = "0x40090B1")]
	[FieldOffset(Offset = "0x8")]
	public AccountInfoWithStatsToClient solo_stats;

	[Token(Token = "0x40090B2")]
	[FieldOffset(Offset = "0xC")]
	public AccountInfoWithStatsToClient duo_stats;

	[Token(Token = "0x40090B3")]
	[FieldOffset(Offset = "0x10")]
	public AccountInfoWithStatsToClient quad_stats;

	[Token(Token = "0x6007B61")]
	[Address(RVA = "0x3094988", Offset = "0x3094988", VA = "0x3094988")]
	public CSGetPlayerStatsRes()
	{
	}
}
