using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001801")]
public class CSUpgradeWeaponSkinReq
{
	[Token(Token = "0x4009BDD")]
	[FieldOffset(Offset = "0x8")]
	public uint weapon_skin;

	[Token(Token = "0x4009BDE")]
	[FieldOffset(Offset = "0xC")]
	public uint weapon_set;

	[Token(Token = "0x4009BDF")]
	[FieldOffset(Offset = "0x10")]
	public uint weapon_id;

	[Token(Token = "0x6007E5B")]
	[Address(RVA = "0x309A7F0", Offset = "0x309A7F0", VA = "0x309A7F0")]
	public CSUpgradeWeaponSkinReq()
	{
	}
}
