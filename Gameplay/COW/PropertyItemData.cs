using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C15")]
public class PropertyItemData
{
	[Token(Token = "0x4010D4F")]
	[FieldOffset(Offset = "0x8")]
	public List<int> Levels;

	[Token(Token = "0x4010D50")]
	[FieldOffset(Offset = "0xC")]
	public WeaponSkinUpgradeInfoData FeatureData;

	[Token(Token = "0x6012562")]
	[Address(RVA = "0x196ABD4", Offset = "0x196ABD4", VA = "0x196ABD4")]
	public PropertyItemData()
	{
	}
}
