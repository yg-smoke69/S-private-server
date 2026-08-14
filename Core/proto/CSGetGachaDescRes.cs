using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016DA")]
public class CSGetGachaDescRes
{
	[Token(Token = "0x4009780")]
	[FieldOffset(Offset = "0x8")]
	public List<GachaDesc> gacha_desc_list;

	[Token(Token = "0x6007D34")]
	[Address(RVA = "0x31856D0", Offset = "0x31856D0", VA = "0x31856D0")]
	public CSGetGachaDescRes()
	{
	}
}
