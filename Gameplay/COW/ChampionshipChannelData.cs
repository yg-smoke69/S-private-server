using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DB7")]
public class ChampionshipChannelData : CSVBaseData
{
	[Token(Token = "0x40118AB")]
	[FieldOffset(Offset = "0x8")]
	public List<string> RegionList;

	[Token(Token = "0x40118AC")]
	[FieldOffset(Offset = "0xC")]
	public int ChannelID;

	[Token(Token = "0x40118AD")]
	[FieldOffset(Offset = "0x10")]
	public string Icon;

	[Token(Token = "0x6013231")]
	[Address(RVA = "0x172244C", Offset = "0x172244C", VA = "0x172244C")]
	public ChampionshipChannelData()
	{
	}

	[Token(Token = "0x6013232")]
	[Address(RVA = "0x17224D0", Offset = "0x17224D0", VA = "0x17224D0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6013233")]
	[Address(RVA = "0x1722534", Offset = "0x1722534", VA = "0x1722534", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
