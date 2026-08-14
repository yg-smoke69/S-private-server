using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001855")]
public class WinterFestStrategyAccountInfo
{
	[Token(Token = "0x4009CC7")]
	[FieldOffset(Offset = "0x8")]
	public List<WinterFestStrategyBuildingInfo> buildings;

	[Token(Token = "0x4009CC8")]
	[FieldOffset(Offset = "0xC")]
	public uint devote_points;

	[Token(Token = "0x4009CC9")]
	[FieldOffset(Offset = "0x10")]
	public uint[] pending_orders;

	[Token(Token = "0x4009CCA")]
	[FieldOffset(Offset = "0x14")]
	public uint[] finished_orders;

	[Token(Token = "0x4009CCB")]
	[FieldOffset(Offset = "0x18")]
	public uint orders_expire_time;

	[Token(Token = "0x4009CCC")]
	[FieldOffset(Offset = "0x1C")]
	public List<WinterFestStrategyHelpLog> history;

	[Token(Token = "0x4009CCD")]
	[FieldOffset(Offset = "0x20")]
	public uint order_help_num;

	[Token(Token = "0x6007EAE")]
	[Address(RVA = "0x33E5AD8", Offset = "0x33E5AD8", VA = "0x33E5AD8")]
	public WinterFestStrategyAccountInfo()
	{
	}
}
