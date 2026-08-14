using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000129")]
public class EPWeeklyQuestGroupData : CSVBaseData
{
	[Token(Token = "0x40007A1")]
	[FieldOffset(Offset = "0x8")]
	public string ChallengeName;

	[Token(Token = "0x40007A2")]
	[FieldOffset(Offset = "0xC")]
	public string CdnUrl;

	[Token(Token = "0x40007A3")]
	[FieldOffset(Offset = "0x10")]
	public DateTime StartTime;

	[Token(Token = "0x40007A4")]
	[FieldOffset(Offset = "0x20")]
	public uint ID;

	[Token(Token = "0x40007A5")]
	[FieldOffset(Offset = "0x24")]
	public uint QuestGroup;

	[Token(Token = "0x40007A6")]
	[FieldOffset(Offset = "0x28")]
	public uint EPEventId;

	[Token(Token = "0x600073F")]
	[Address(RVA = "0x251FD14", Offset = "0x251FD14", VA = "0x251FD14")]
	public EPWeeklyQuestGroupData()
	{
	}

	[Token(Token = "0x6000740")]
	[Address(RVA = "0x251FD98", Offset = "0x251FD98", VA = "0x251FD98", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000741")]
	[Address(RVA = "0x2520034", Offset = "0x2520034", VA = "0x2520034", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}
}
