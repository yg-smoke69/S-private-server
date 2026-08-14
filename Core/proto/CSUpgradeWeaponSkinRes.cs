using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001802")]
public class CSUpgradeWeaponSkinRes
{
	[Token(Token = "0x4009BE0")]
	[FieldOffset(Offset = "0x8")]
	public uint next_weapon_skin;

	[Token(Token = "0x4009BE1")]
	[FieldOffset(Offset = "0xC")]
	public uint reward_item;

	[Token(Token = "0x6007E5C")]
	[Address(RVA = "0x309A7F8", Offset = "0x309A7F8", VA = "0x309A7F8")]
	public CSUpgradeWeaponSkinRes()
	{
	}
}
