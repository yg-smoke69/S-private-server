using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200179D")]
public class AccountChampionshipInfo
{
	[Token(Token = "0x4009ACA")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009ACB")]
	[FieldOffset(Offset = "0x10")]
	public uint championship_type;

	[Token(Token = "0x4009ACC")]
	[FieldOffset(Offset = "0x14")]
	public uint championship_id;

	[Token(Token = "0x4009ACD")]
	[FieldOffset(Offset = "0x18")]
	public uint trial_valid_score;

	[Token(Token = "0x4009ACE")]
	[FieldOffset(Offset = "0x1C")]
	public uint trial_pos;

	[Token(Token = "0x4009ACF")]
	[FieldOffset(Offset = "0x20")]
	public bool can_get_trial_reward;

	[Token(Token = "0x4009AD0")]
	[FieldOffset(Offset = "0x24")]
	public uint final_valid_score;

	[Token(Token = "0x4009AD1")]
	[FieldOffset(Offset = "0x28")]
	public uint final_pos;

	[Token(Token = "0x4009AD2")]
	[FieldOffset(Offset = "0x2C")]
	public bool rewarded;

	[Token(Token = "0x4009AD3")]
	[FieldOffset(Offset = "0x2D")]
	public bool is_enter_final;

	[Token(Token = "0x6007DF7")]
	[Address(RVA = "0x3179430", Offset = "0x3179430", VA = "0x3179430")]
	public AccountChampionshipInfo()
	{
	}
}
