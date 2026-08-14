using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017F9")]
public class CSGetMoneyHeistRewardsRes
{
	[Token(Token = "0x4009BCA")]
	[FieldOffset(Offset = "0x8")]
	public List<AwardDesc> award_goods;

	[Token(Token = "0x6007E53")]
	[Address(RVA = "0x3187958", Offset = "0x3187958", VA = "0x3187958")]
	public CSGetMoneyHeistRewardsRes()
	{
	}
}
