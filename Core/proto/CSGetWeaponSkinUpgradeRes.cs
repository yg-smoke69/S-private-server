using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001800")]
public class CSGetWeaponSkinUpgradeRes
{
	[Token(Token = "0x4009BDC")]
	[FieldOffset(Offset = "0x8")]
	public List<WeaponSkinUpgradeDesc> weapon_skin_upgrade_desc;

	[Token(Token = "0x6007E5A")]
	[Address(RVA = "0x3096664", Offset = "0x3096664", VA = "0x3096664")]
	public CSGetWeaponSkinUpgradeRes()
	{
	}
}
