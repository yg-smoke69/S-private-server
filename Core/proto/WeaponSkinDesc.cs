using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019A9")]
public class WeaponSkinDesc
{
	[Token(Token = "0x400A0F0")]
	[FieldOffset(Offset = "0x8")]
	public uint item_id;

	[Token(Token = "0x400A0F1")]
	[FieldOffset(Offset = "0xC")]
	public uint weapon_id;

	[Token(Token = "0x400A0F2")]
	[FieldOffset(Offset = "0x10")]
	public bool is_show;

	[Token(Token = "0x6008000")]
	[Address(RVA = "0x33E5140", Offset = "0x33E5140", VA = "0x33E5140")]
	public WeaponSkinDesc()
	{
	}
}
