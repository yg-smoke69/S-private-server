using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200190B")]
public class CSGetAccountVipCardInfosRes
{
	[Token(Token = "0x4009EA1")]
	[FieldOffset(Offset = "0x8")]
	public List<VipCardInfo> infos;

	[Token(Token = "0x4009EA2")]
	[FieldOffset(Offset = "0xC")]
	public List<VipCardPurchaseInfo> purchase_infos;

	[Token(Token = "0x6007F64")]
	[Address(RVA = "0x3180E70", Offset = "0x3180E70", VA = "0x3180E70")]
	public CSGetAccountVipCardInfosRes()
	{
	}
}
