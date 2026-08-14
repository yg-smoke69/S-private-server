using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200012A")]
public class EPWeeklyQuestRewardData : CSVBaseData
{
	[Token(Token = "0x40007A7")]
	[FieldOffset(Offset = "0x8")]
	private BaseItemInfo[] AwardList;

	[Token(Token = "0x40007A8")]
	[FieldOffset(Offset = "0xC")]
	public uint ID;

	[Token(Token = "0x40007A9")]
	[FieldOffset(Offset = "0x10")]
	public uint WeekId;

	[Token(Token = "0x40007AA")]
	[FieldOffset(Offset = "0x14")]
	public uint EPEventId;

	[Token(Token = "0x40007AB")]
	[FieldOffset(Offset = "0x18")]
	public uint NeedQuestNum;

	[Token(Token = "0x6000742")]
	[Address(RVA = "0x25200A0", Offset = "0x25200A0", VA = "0x25200A0")]
	public EPWeeklyQuestRewardData()
	{
	}

	[Token(Token = "0x6000743")]
	[Address(RVA = "0x2520124", Offset = "0x2520124", VA = "0x2520124", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000744")]
	[Address(RVA = "0x2520188", Offset = "0x2520188", VA = "0x2520188", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000745")]
	[Address(RVA = "0x2520800", Offset = "0x2520800", VA = "0x2520800")]
	public BaseItemInfo[] GetRewardLst()
	{
		return null;
	}

	[Token(Token = "0x6000746")]
	[Address(RVA = "0x2520858", Offset = "0x2520858", VA = "0x2520858")]
	public static void GetWeeklyDataByEPId(uint epId, out Dictionary<uint, List<EPWeeklyQuestRewardData>> result)
	{
	}
}
