using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013E0")]
public class WeaponSkinDamage
{
	[Token(Token = "0x4008B5E")]
	[FieldOffset(Offset = "0x8")]
	public uint weapon_skin_id;

	[Token(Token = "0x4008B5F")]
	[FieldOffset(Offset = "0xC")]
	public uint damage;

	[Token(Token = "0x6007AC1")]
	[Address(RVA = "0x33E5138", Offset = "0x33E5138", VA = "0x33E5138")]
	public WeaponSkinDamage()
	{
	}
}
