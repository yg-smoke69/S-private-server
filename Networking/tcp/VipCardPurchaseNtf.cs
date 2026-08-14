using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001DBC")]
public class VipCardPurchaseNtf
{
	[Token(Token = "0x400BC66")]
	[FieldOffset(Offset = "0x8")]
	private List<EVipCard.VipCardType> _003Ccard_types_003Ek__BackingField;

	[Token(Token = "0x17000F02")]
	public List<EVipCard.VipCardType> card_types
	{
		[Token(Token = "0x6008DE8")]
		[Address(RVA = "0x435FE7C", Offset = "0x435FE7C", VA = "0x435FE7C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008DE9")]
		[Address(RVA = "0x435FE74", Offset = "0x435FE74", VA = "0x435FE74")]
		private set
		{
		}
	}

	[Token(Token = "0x6008DE7")]
	[Address(RVA = "0x435FDE8", Offset = "0x435FDE8", VA = "0x435FDE8")]
	public VipCardPurchaseNtf()
	{
	}
}
