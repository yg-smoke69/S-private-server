using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001591")]
public class SubmitTeamCupMatchStatsReq
{
	[Token(Token = "0x400938D")]
	[FieldOffset(Offset = "0x8")]
	public ulong match_id;

	[Token(Token = "0x400938E")]
	[FieldOffset(Offset = "0x10")]
	public string lock_region;

	[Token(Token = "0x400938F")]
	[FieldOffset(Offset = "0x14")]
	public string noti_region;

	[Token(Token = "0x4009390")]
	[FieldOffset(Offset = "0x18")]
	public CupMatchStats stats;

	[Token(Token = "0x6007BD9")]
	[Address(RVA = "0x33E2BE0", Offset = "0x33E2BE0", VA = "0x33E2BE0")]
	public SubmitTeamCupMatchStatsReq()
	{
	}
}
