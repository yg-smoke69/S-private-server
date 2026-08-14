using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200160B")]
public class CSGetRebateRewardReq
{
	[Token(Token = "0x40094E2")]
	[FieldOffset(Offset = "0x8")]
	public string login_token;

	[Token(Token = "0x40094E3")]
	[FieldOffset(Offset = "0xC")]
	public uint[] rebate_card_ids;

	[Token(Token = "0x6007C55")]
	[Address(RVA = "0x3095014", Offset = "0x3095014", VA = "0x3095014")]
	public CSGetRebateRewardReq()
	{
	}
}
