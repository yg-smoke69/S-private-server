using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001646")]
public class CSClanNewsRes
{
	[Token(Token = "0x40095B8")]
	[FieldOffset(Offset = "0x8")]
	public List<ClanNews> news;

	[Token(Token = "0x6007C90")]
	[Address(RVA = "0x317EDBC", Offset = "0x317EDBC", VA = "0x317EDBC")]
	public CSClanNewsRes()
	{
	}
}
