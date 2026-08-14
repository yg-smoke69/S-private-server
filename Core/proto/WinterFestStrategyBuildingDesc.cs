using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BCE")]
public class WinterFestStrategyBuildingDesc
{
	[Token(Token = "0x400AEED")]
	[FieldOffset(Offset = "0x8")]
	public uint building_id;

	[Token(Token = "0x400AEEE")]
	[FieldOffset(Offset = "0xC")]
	public uint building_level;

	[Token(Token = "0x400AEEF")]
	[FieldOffset(Offset = "0x10")]
	public string building_name;

	[Token(Token = "0x400AEF0")]
	[FieldOffset(Offset = "0x14")]
	public uint product_id;

	[Token(Token = "0x400AEF1")]
	[FieldOffset(Offset = "0x18")]
	public uint building_eff;

	[Token(Token = "0x400AEF2")]
	[FieldOffset(Offset = "0x1C")]
	public uint building_capacity;

	[Token(Token = "0x400AEF3")]
	[FieldOffset(Offset = "0x20")]
	public uint main_building_unlock;

	[Token(Token = "0x400AEF4")]
	[FieldOffset(Offset = "0x24")]
	public List<MiniGameItem> upgrade_require_items;

	[Token(Token = "0x400AEF5")]
	[FieldOffset(Offset = "0x28")]
	public uint appearance_level;

	[Token(Token = "0x6008229")]
	[Address(RVA = "0x33E5B98", Offset = "0x33E5B98", VA = "0x33E5B98")]
	public WinterFestStrategyBuildingDesc()
	{
	}
}
