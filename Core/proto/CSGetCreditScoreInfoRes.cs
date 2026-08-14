using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001940")]
public class CSGetCreditScoreInfoRes
{
	[Token(Token = "0x4009F40")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009F41")]
	[FieldOffset(Offset = "0x10")]
	public uint credit_score;

	[Token(Token = "0x4009F42")]
	[FieldOffset(Offset = "0x14")]
	public bool is_init;

	[Token(Token = "0x4009F43")]
	[FieldOffset(Offset = "0x18")]
	public ECreditScore.RewardState reward_state;

	[Token(Token = "0x6007F99")]
	[Address(RVA = "0x3183500", Offset = "0x3183500", VA = "0x3183500")]
	public CSGetCreditScoreInfoRes()
	{
	}
}
