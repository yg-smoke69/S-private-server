using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000245")]
public class TeamConfigData : CSVBaseData, _Attribute
{
	[Token(Token = "0x4000DCF")]
	[FieldOffset(Offset = "0x8")]
	public uint TeamID;

	[Token(Token = "0x4000DD0")]
	[FieldOffset(Offset = "0xC")]
	public uint Count;

	[Token(Token = "0x4000DD1")]
	[FieldOffset(Offset = "0x10")]
	public string TitleKey;

	[Token(Token = "0x4000DD2")]
	[FieldOffset(Offset = "0x14")]
	public uint[] PrivilegeID;

	[Token(Token = "0x4000DD3")]
	[FieldOffset(Offset = "0x18")]
	public uint Order;

	[Token(Token = "0x6000B67")]
	[Address(RVA = "0x289D4FC", Offset = "0x289D4FC", VA = "0x289D4FC")]
	public TeamConfigData()
	{
	}

	[Token(Token = "0x6000B68")]
	[Address(RVA = "0x289D580", Offset = "0x289D580", VA = "0x289D580", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x6000B69")]
	[Address(RVA = "0x289D5D8", Offset = "0x289D5D8", VA = "0x289D5D8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000B6A")]
	[Address(RVA = "0x289D63C", Offset = "0x289D63C", VA = "0x289D63C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
