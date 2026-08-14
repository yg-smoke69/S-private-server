using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001941")]
public class CSGetCreditScoreChangeInfoRes
{
	[Token(Token = "0x4009F44")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009F45")]
	[FieldOffset(Offset = "0x10")]
	public List<CreditScoreChangeInfo> credit_score_change_list;

	[Token(Token = "0x6007F9A")]
	[Address(RVA = "0x31833B4", Offset = "0x31833B4", VA = "0x31833B4")]
	public CSGetCreditScoreChangeInfoRes()
	{
	}
}
