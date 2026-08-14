using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200173A")]
public class CSIAPPurchaseRes
{
	[Token(Token = "0x40099A2")]
	[FieldOffset(Offset = "0x8")]
	public List<AwardDesc> awards;

	[Token(Token = "0x40099A3")]
	[FieldOffset(Offset = "0xC")]
	public EStore.RebateCardBillStatus status;

	[Token(Token = "0x6007D94")]
	[Address(RVA = "0x30972F0", Offset = "0x30972F0", VA = "0x30972F0")]
	public CSIAPPurchaseRes()
	{
	}
}
