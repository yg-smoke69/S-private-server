using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A24")]
public class ClanHonorDescList
{
	[Token(Token = "0x400A3D1")]
	[FieldOffset(Offset = "0x8")]
	public List<ClanHonorDesc> clan_honor_list;

	[Token(Token = "0x600807C")]
	[Address(RVA = "0x309B860", Offset = "0x309B860", VA = "0x309B860")]
	public ClanHonorDescList()
	{
	}
}
