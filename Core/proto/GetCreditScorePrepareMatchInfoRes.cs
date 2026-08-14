using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014ED")]
public class GetCreditScorePrepareMatchInfoRes
{
	[Token(Token = "0x4009048")]
	[FieldOffset(Offset = "0x8")]
	public List<CreditPunishInfo> credit_punish_info;

	[Token(Token = "0x4009049")]
	[FieldOffset(Offset = "0x10")]
	public ulong account_id;

	[Token(Token = "0x6007B3D")]
	[Address(RVA = "0x30A1F4C", Offset = "0x30A1F4C", VA = "0x30A1F4C")]
	public GetCreditScorePrepareMatchInfoRes()
	{
	}
}
