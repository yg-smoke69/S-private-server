using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000128")]
public class EPWeeklyQuestData : CsvDataIndexedReading
{
	[Token(Token = "0x400078F")]
	[FieldOffset(Offset = "0x8")]
	public BaseItemInfo[] AwardList;

	[Token(Token = "0x4000790")]
	[FieldOffset(Offset = "0xC")]
	public string ChallengeName;

	[Token(Token = "0x4000791")]
	[FieldOffset(Offset = "0x10")]
	public string ChallengeDesc;

	[Token(Token = "0x4000792")]
	[FieldOffset(Offset = "0x18")]
	public DateTime StartTime;

	[Token(Token = "0x4000793")]
	[FieldOffset(Offset = "0x28")]
	public uint QuestGroup;

	[Token(Token = "0x4000794")]
	[FieldOffset(Offset = "0x2C")]
	public uint QuestId;

	[Token(Token = "0x4000795")]
	[FieldOffset(Offset = "0x30")]
	public uint EPEventId;

	[Token(Token = "0x4000796")]
	[FieldOffset(Offset = "0x34")]
	public uint TargetValue;

	[Token(Token = "0x4000797")]
	[FieldOffset(Offset = "0x38")]
	public uint TargetValue2;

	[Token(Token = "0x4000798")]
	[FieldOffset(Offset = "0x3C")]
	public uint AwardNum;

	[Token(Token = "0x4000799")]
	[FieldOffset(Offset = "0x40")]
	public byte CountType;

	[Token(Token = "0x400079A")]
	[FieldOffset(Offset = "0x41")]
	public byte ConditionType;

	[Token(Token = "0x400079B")]
	[FieldOffset(Offset = "0x42")]
	public bool IsEPOnly;

	[Token(Token = "0x400079C")]
	[FieldOffset(Offset = "0x43")]
	public bool IsTeamWork;

	[Token(Token = "0x400079D")]
	[FieldOffset(Offset = "0x44")]
	public string GoPos;

	[Token(Token = "0x400079E")]
	[FieldOffset(Offset = "0x48")]
	public uint condition1Type;

	[Token(Token = "0x400079F")]
	[FieldOffset(Offset = "0x4C")]
	public uint condition2Type;

	[Token(Token = "0x40007A0")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<EPWeeklyQuestData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6000734")]
	[Address(RVA = "0x251CF04", Offset = "0x251CF04", VA = "0x251CF04")]
	public EPWeeklyQuestData()
	{
	}

	[Token(Token = "0x6000735")]
	[Address(RVA = "0x251CF0C", Offset = "0x251CF0C", VA = "0x251CF0C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000736")]
	[Address(RVA = "0x251CF70", Offset = "0x251CF70", VA = "0x251CF70", Slot = "7")]
	public override string[] GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x6000737")]
	[Address(RVA = "0x251DE20", Offset = "0x251DE20", VA = "0x251DE20", Slot = "8")]
	public override void ParseData(IIndexString ss, int[] index)
	{
	}

	[Token(Token = "0x6000738")]
	[Address(RVA = "0x251F760", Offset = "0x251F760", VA = "0x251F760", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000739")]
	[Address(RVA = "0x251F918", Offset = "0x251F918", VA = "0x251F918")]
	public static void GetWeeklyDataByEPId(uint epId, out List<EPWeeklyQuestData> weeklyQuestLst)
	{
	}

	[Token(Token = "0x600073A")]
	[Address(RVA = "0x251FC20", Offset = "0x251FC20", VA = "0x251FC20")]
	public BaseItemInfo[] GetRewardList()
	{
		return null;
	}

	[Token(Token = "0x600073B")]
	[Address(RVA = "0x251FC78", Offset = "0x251FC78", VA = "0x251FC78")]
	private static int _003CGetWeeklyDataByEPId_003Em__0(EPWeeklyQuestData a, EPWeeklyQuestData b)
	{
		return default(int);
	}

	[Token(Token = "0x600073C")]
	[Address(RVA = "0x251FCD8", Offset = "0x251FCD8", VA = "0x251FCD8")]
	public string[] _003C_003EiFixBaseProxy_GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x600073D")]
	[Address(RVA = "0x251FCE0", Offset = "0x251FCE0", VA = "0x251FCE0")]
	public void _003C_003EiFixBaseProxy_ParseData(IIndexString P0, int[] P1)
	{
	}

	[Token(Token = "0x600073E")]
	[Address(RVA = "0x251FCE8", Offset = "0x251FCE8", VA = "0x251FCE8")]
	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
