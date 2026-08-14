using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001914")]
public class CSGetLimitedChestDescRes
{
	[Token(Token = "0x4009EB6")]
	[FieldOffset(Offset = "0x8")]
	public List<GachaDesc> limited_chest_desc_list;

	[Token(Token = "0x6007F6D")]
	[Address(RVA = "0x318678C", Offset = "0x318678C", VA = "0x318678C")]
	public CSGetLimitedChestDescRes()
	{
	}
}
