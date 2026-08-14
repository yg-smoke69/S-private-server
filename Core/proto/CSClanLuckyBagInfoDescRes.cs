using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200164F")]
public class CSClanLuckyBagInfoDescRes
{
	[Token(Token = "0x40095E6")]
	[FieldOffset(Offset = "0x8")]
	public List<ClanLuckyBagInfoDesc> big_lucky_bag_info;

	[Token(Token = "0x6007C99")]
	[Address(RVA = "0x317EBFC", Offset = "0x317EBFC", VA = "0x317EBFC")]
	public CSClanLuckyBagInfoDescRes()
	{
	}
}
