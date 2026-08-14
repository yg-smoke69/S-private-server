using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200190C")]
public class CSClaimVipCardAwardReq
{
	[Token(Token = "0x4009EA3")]
	[FieldOffset(Offset = "0x8")]
	public EVipCard.VipCardType card_type;

	[Token(Token = "0x4009EA4")]
	[FieldOffset(Offset = "0xC")]
	public bool claim_all;

	[Token(Token = "0x6007F65")]
	[Address(RVA = "0x317E998", Offset = "0x317E998", VA = "0x317E998")]
	public CSClaimVipCardAwardReq()
	{
	}
}
