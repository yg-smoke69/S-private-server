using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015C6")]
public class CSGetLegendClothesDescRes
{
	[Token(Token = "0x4009444")]
	[FieldOffset(Offset = "0x8")]
	public List<LegendClothUnlockDesc> legend_clothes;

	[Token(Token = "0x6007C10")]
	[Address(RVA = "0x3186700", Offset = "0x3186700", VA = "0x3186700")]
	public CSGetLegendClothesDescRes()
	{
	}
}
