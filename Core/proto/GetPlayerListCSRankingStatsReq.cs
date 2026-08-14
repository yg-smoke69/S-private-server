using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001550")]
public class GetPlayerListCSRankingStatsReq
{
	[Token(Token = "0x40092BB")]
	[FieldOffset(Offset = "0x8")]
	public ulong[] account_ids;

	[Token(Token = "0x40092BC")]
	[FieldOffset(Offset = "0xC")]
	public uint season_id;

	[Token(Token = "0x40092BD")]
	[FieldOffset(Offset = "0x10")]
	public uint game_mode;

	[Token(Token = "0x40092BE")]
	[FieldOffset(Offset = "0x14")]
	public string lock_region;

	[Token(Token = "0x6007B98")]
	[Address(RVA = "0x30A2100", Offset = "0x30A2100", VA = "0x30A2100")]
	public GetPlayerListCSRankingStatsReq()
	{
	}
}
