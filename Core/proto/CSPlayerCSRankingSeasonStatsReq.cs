using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200154B")]
public class CSPlayerCSRankingSeasonStatsReq
{
	[Token(Token = "0x40092AC")]
	[FieldOffset(Offset = "0x8")]
	public uint season_id;

	[Token(Token = "0x40092AD")]
	[FieldOffset(Offset = "0x10")]
	public ulong account_id;

	[Token(Token = "0x6007B93")]
	[Address(RVA = "0x3098504", Offset = "0x3098504", VA = "0x3098504")]
	public CSPlayerCSRankingSeasonStatsReq()
	{
	}
}
