using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BCD")]
public class WinterFestStrategyOrderDesc
{
	[Token(Token = "0x400AEE6")]
	[FieldOffset(Offset = "0x8")]
	public uint pool;

	[Token(Token = "0x400AEE7")]
	[FieldOffset(Offset = "0xC")]
	public uint id;

	[Token(Token = "0x400AEE8")]
	[FieldOffset(Offset = "0x10")]
	public List<MiniGameItem> request_items;

	[Token(Token = "0x400AEE9")]
	[FieldOffset(Offset = "0x14")]
	public AwardDesc reward_items;

	[Token(Token = "0x400AEEA")]
	[FieldOffset(Offset = "0x18")]
	public uint building_material;

	[Token(Token = "0x400AEEB")]
	[FieldOffset(Offset = "0x1C")]
	public uint devote_points;

	[Token(Token = "0x400AEEC")]
	[FieldOffset(Offset = "0x20")]
	public bool is_other;

	[Token(Token = "0x6008228")]
	[Address(RVA = "0x33E5DC0", Offset = "0x33E5DC0", VA = "0x33E5DC0")]
	public WinterFestStrategyOrderDesc()
	{
	}
}
