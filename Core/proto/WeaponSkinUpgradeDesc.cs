using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B48")]
public class WeaponSkinUpgradeDesc
{
	[Token(Token = "0x400ABA4")]
	[FieldOffset(Offset = "0x8")]
	public uint weapon_skin_id;

	[Token(Token = "0x400ABA5")]
	[FieldOffset(Offset = "0xC")]
	public uint next_id;

	[Token(Token = "0x400ABA6")]
	[FieldOffset(Offset = "0x10")]
	public uint level;

	[Token(Token = "0x400ABA7")]
	[FieldOffset(Offset = "0x14")]
	public List<WeaponSkinUpdateItemDesc> items;

	[Token(Token = "0x400ABA8")]
	[FieldOffset(Offset = "0x18")]
	public uint reward_item;

	[Token(Token = "0x400ABA9")]
	[FieldOffset(Offset = "0x1C")]
	public uint weapon_set;

	[Token(Token = "0x400ABAA")]
	[FieldOffset(Offset = "0x20")]
	public WeaponSkinUpdateItemDesc exchange_item;

	[Token(Token = "0x60081A3")]
	[Address(RVA = "0x33E52A4", Offset = "0x33E52A4", VA = "0x33E52A4")]
	public WeaponSkinUpgradeDesc()
	{
	}
}
