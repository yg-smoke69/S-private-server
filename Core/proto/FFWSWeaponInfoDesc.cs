using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B8D")]
public class FFWSWeaponInfoDesc
{
	[Token(Token = "0x400AD4A")]
	[FieldOffset(Offset = "0x8")]
	public uint weapon_id;

	[Token(Token = "0x400AD4B")]
	[FieldOffset(Offset = "0xC")]
	public string weapon_icon;

	[Token(Token = "0x400AD4C")]
	[FieldOffset(Offset = "0x10")]
	public uint weight;

	[Token(Token = "0x400AD4D")]
	[FieldOffset(Offset = "0x14")]
	public string weapon_name;

	[Token(Token = "0x60081E8")]
	[Address(RVA = "0x30A096C", Offset = "0x30A096C", VA = "0x30A096C")]
	public FFWSWeaponInfoDesc()
	{
	}
}
