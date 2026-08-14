using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200010B")]
public class CSShopItemData : CSVBaseData, _Attribute
{
	[Token(Token = "0x40006C5")]
	[FieldOffset(Offset = "0x8")]
	public uint iID;

	[Token(Token = "0x40006C6")]
	[FieldOffset(Offset = "0xC")]
	public uint price;

	[Token(Token = "0x40006C7")]
	[FieldOffset(Offset = "0x10")]
	public uint filter;

	[Token(Token = "0x40006C8")]
	[FieldOffset(Offset = "0x14")]
	public bool bonus;

	[Token(Token = "0x40006C9")]
	[FieldOffset(Offset = "0x18")]
	public uint limitation;

	[Token(Token = "0x40006CA")]
	[FieldOffset(Offset = "0x1C")]
	public uint stack;

	[Token(Token = "0x40006CB")]
	[FieldOffset(Offset = "0x20")]
	public List<uint> hideCheckItemList;

	[Token(Token = "0x40006CC")]
	[FieldOffset(Offset = "0x24")]
	public bool onlyShow;

	[Token(Token = "0x60006AC")]
	[Address(RVA = "0x182BB64", Offset = "0x182BB64", VA = "0x182BB64")]
	public CSShopItemData()
	{
	}

	[Token(Token = "0x60006AD")]
	[Address(RVA = "0x182BBE8", Offset = "0x182BBE8", VA = "0x182BBE8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60006AE")]
	[Address(RVA = "0x182BC4C", Offset = "0x182BC4C", VA = "0x182BC4C", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x60006AF")]
	[Address(RVA = "0x182BCA4", Offset = "0x182BCA4", VA = "0x182BCA4", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
