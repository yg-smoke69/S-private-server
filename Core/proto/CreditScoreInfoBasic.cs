using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001393")]
public class CreditScoreInfoBasic
{
	[Token(Token = "0x4008A0B")]
	[FieldOffset(Offset = "0x8")]
	public uint credit_score;

	[Token(Token = "0x4008A0C")]
	[FieldOffset(Offset = "0xC")]
	public bool is_init;

	[Token(Token = "0x4008A0D")]
	[FieldOffset(Offset = "0x10")]
	public ECreditScore.RewardState reward_state;

	[Token(Token = "0x6007A8F")]
	[Address(RVA = "0x309D918", Offset = "0x309D918", VA = "0x309D918")]
	public CreditScoreInfoBasic()
	{
	}
}
