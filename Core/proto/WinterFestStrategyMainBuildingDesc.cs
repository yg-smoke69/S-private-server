using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BCC")]
public class WinterFestStrategyMainBuildingDesc
{
	[Token(Token = "0x400AEE0")]
	[FieldOffset(Offset = "0x8")]
	public uint level;

	[Token(Token = "0x400AEE1")]
	[FieldOffset(Offset = "0xC")]
	public uint order_pool;

	[Token(Token = "0x400AEE2")]
	[FieldOffset(Offset = "0x10")]
	public uint order_cnt;

	[Token(Token = "0x400AEE3")]
	[FieldOffset(Offset = "0x14")]
	public uint other_order_pool;

	[Token(Token = "0x400AEE4")]
	[FieldOffset(Offset = "0x18")]
	public List<MiniGameItem> upgrade_require_items;

	[Token(Token = "0x400AEE5")]
	[FieldOffset(Offset = "0x1C")]
	public uint appearance_level;

	[Token(Token = "0x6008227")]
	[Address(RVA = "0x33E5D34", Offset = "0x33E5D34", VA = "0x33E5D34")]
	public WinterFestStrategyMainBuildingDesc()
	{
	}
}
