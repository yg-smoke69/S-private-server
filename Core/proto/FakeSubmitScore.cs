using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017B4")]
public class FakeSubmitScore
{
	[Token(Token = "0x4009B2C")]
	[FieldOffset(Offset = "0x8")]
	public int rank_score;

	[Token(Token = "0x4009B2D")]
	[FieldOffset(Offset = "0xC")]
	public int battle_score;

	[Token(Token = "0x4009B2E")]
	[FieldOffset(Offset = "0x10")]
	public int total_score;

	[Token(Token = "0x6007E0E")]
	[Address(RVA = "0x30A0B74", Offset = "0x30A0B74", VA = "0x30A0B74")]
	public FakeSubmitScore()
	{
	}
}
