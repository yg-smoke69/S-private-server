using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013DF")]
public class WeaponSkinKill
{
	[Token(Token = "0x4008B5C")]
	[FieldOffset(Offset = "0x8")]
	public uint weapon_skin_id;

	[Token(Token = "0x4008B5D")]
	[FieldOffset(Offset = "0xC")]
	public uint cnt;

	[Token(Token = "0x6007AC0")]
	[Address(RVA = "0x33E5148", Offset = "0x33E5148", VA = "0x33E5148")]
	public WeaponSkinKill()
	{
	}
}
