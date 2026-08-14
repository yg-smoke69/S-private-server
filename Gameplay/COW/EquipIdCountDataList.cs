using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200017D")]
public class EquipIdCountDataList
{
	[Token(Token = "0x4000975")]
	[FieldOffset(Offset = "0x8")]
	public List<EquipIdCountData> Equips;

	[Token(Token = "0x60008A0")]
	[Address(RVA = "0x253990C", Offset = "0x253990C", VA = "0x253990C")]
	public EquipIdCountDataList()
	{
	}

	[Token(Token = "0x60008A1")]
	[Address(RVA = "0x2539914", Offset = "0x2539914", VA = "0x2539914")]
	public static EquipIdCountDataList Parse(string s)
	{
		return null;
	}
}
