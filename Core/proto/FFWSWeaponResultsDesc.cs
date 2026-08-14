using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B8E")]
public class FFWSWeaponResultsDesc
{
	[Token(Token = "0x400AD4E")]
	[FieldOffset(Offset = "0x8")]
	public uint weapon_id;

	[Token(Token = "0x400AD4F")]
	[FieldOffset(Offset = "0xC")]
	public uint weapon_kill;

	[Token(Token = "0x60081E9")]
	[Address(RVA = "0x30A0A18", Offset = "0x30A0A18", VA = "0x30A0A18")]
	public FFWSWeaponResultsDesc()
	{
	}
}
