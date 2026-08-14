using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000242")]
internal class TDMLikeShopConfigData : CSVBaseData
{
	[Token(Token = "0x4000DC5")]
	[FieldOffset(Offset = "0x8")]
	public uint indexID;

	[Token(Token = "0x4000DC6")]
	[FieldOffset(Offset = "0xC")]
	public List<TDMLikeShopItem> items;

	[Token(Token = "0x4000DC7")]
	[FieldOffset(Offset = "0x10")]
	public uint mainItemId;

	[Token(Token = "0x4000DC8")]
	[FieldOffset(Offset = "0x14")]
	public uint price;

	[Token(Token = "0x4000DC9")]
	[FieldOffset(Offset = "0x18")]
	public uint filter;

	[Token(Token = "0x4000DCA")]
	[FieldOffset(Offset = "0x1C")]
	public bool displayFirstOne;

	[Token(Token = "0x4000DCB")]
	[FieldOffset(Offset = "0x20")]
	public uint limitation;

	[Token(Token = "0x6000B58")]
	[Address(RVA = "0x2891F34", Offset = "0x2891F34", VA = "0x2891F34")]
	public TDMLikeShopConfigData()
	{
	}

	[Token(Token = "0x6000B59")]
	[Address(RVA = "0x2891FEC", Offset = "0x2891FEC", VA = "0x2891FEC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000B5A")]
	[Address(RVA = "0x2892050", Offset = "0x2892050", VA = "0x2892050", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
