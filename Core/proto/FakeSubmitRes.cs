using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017B6")]
public class FakeSubmitRes
{
	[Token(Token = "0x4009B38")]
	[FieldOffset(Offset = "0x8")]
	public SubmitChampionshipTeamMatchStatsReq fake_submit_req;

	[Token(Token = "0x4009B39")]
	[FieldOffset(Offset = "0xC")]
	public FakeSubmitScore score;

	[Token(Token = "0x6007E10")]
	[Address(RVA = "0x30A0B6C", Offset = "0x30A0B6C", VA = "0x30A0B6C")]
	public FakeSubmitRes()
	{
	}
}
