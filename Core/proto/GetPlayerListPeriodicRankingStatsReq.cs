using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200192D")]
public class GetPlayerListPeriodicRankingStatsReq
{
	[Token(Token = "0x4009F07")]
	[FieldOffset(Offset = "0x8")]
	public ulong[] account_ids;

	[Token(Token = "0x4009F08")]
	[FieldOffset(Offset = "0xC")]
	public uint season_id;

	[Token(Token = "0x4009F09")]
	[FieldOffset(Offset = "0x10")]
	public uint game_mode;

	[Token(Token = "0x4009F0A")]
	[FieldOffset(Offset = "0x14")]
	public string lock_region;

	[Token(Token = "0x6007F86")]
	[Address(RVA = "0x30A21A0", Offset = "0x30A21A0", VA = "0x30A21A0")]
	public GetPlayerListPeriodicRankingStatsReq()
	{
	}
}
