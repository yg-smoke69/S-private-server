using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001945")]
public class WebAPIResetRankingPointsReq
{
	[Token(Token = "0x4009F54")]
	[FieldOffset(Offset = "0x8")]
	public string lock_region;

	[Token(Token = "0x4009F55")]
	[FieldOffset(Offset = "0x10")]
	public ulong account_id;

	[Token(Token = "0x6007F9E")]
	[Address(RVA = "0x33E541C", Offset = "0x33E541C", VA = "0x33E541C")]
	public WebAPIResetRankingPointsReq()
	{
	}
}
