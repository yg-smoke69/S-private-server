using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013E1")]
public class WeaponDamage
{
	[Token(Token = "0x4008B60")]
	[FieldOffset(Offset = "0x8")]
	public uint weapon_id;

	[Token(Token = "0x4008B61")]
	[FieldOffset(Offset = "0xC")]
	public uint damage;

	[Token(Token = "0x4008B62")]
	[FieldOffset(Offset = "0x10")]
	public uint weapon_type;

	[Token(Token = "0x6007AC2")]
	[Address(RVA = "0x33E5120", Offset = "0x33E5120", VA = "0x33E5120")]
	public WeaponDamage()
	{
	}
}
