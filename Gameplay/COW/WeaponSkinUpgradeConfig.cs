using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2000267")]
public class WeaponSkinUpgradeConfig : CSVBaseData
{
	[Token(Token = "0x4000EA7")]
	[FieldOffset(Offset = "0x8")]
	public uint weapon_skin_id;

	[Token(Token = "0x4000EA8")]
	[FieldOffset(Offset = "0xC")]
	public uint next_id;

	[Token(Token = "0x4000EA9")]
	[FieldOffset(Offset = "0x10")]
	public uint level;

	[Token(Token = "0x4000EAA")]
	[FieldOffset(Offset = "0x14")]
	public List<WeaponSkinUpdateItemDesc> items;

	[Token(Token = "0x4000EAB")]
	[FieldOffset(Offset = "0x18")]
	public uint reward_item;

	[Token(Token = "0x4000EAC")]
	[FieldOffset(Offset = "0x1C")]
	public WeaponSkinUpdateItemDesc exchange_item;

	[Token(Token = "0x6000BD3")]
	[Address(RVA = "0x21AB240", Offset = "0x21AB240", VA = "0x21AB240")]
	public WeaponSkinUpgradeConfig()
	{
	}

	[Token(Token = "0x6000BD4")]
	[Address(RVA = "0x21AB2C4", Offset = "0x21AB2C4", VA = "0x21AB2C4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000BD5")]
	[Address(RVA = "0x21AB328", Offset = "0x21AB328", VA = "0x21AB328", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
