using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000121")]
public class EPMonthlyQuestData : CsvDataIndexedReading
{
	[Token(Token = "0x4000748")]
	[FieldOffset(Offset = "0x8")]
	public string ChallengeName;

	[Token(Token = "0x4000749")]
	[FieldOffset(Offset = "0xC")]
	public string ChallengeDesc;

	[Token(Token = "0x400074A")]
	[FieldOffset(Offset = "0x10")]
	public uint QuestId;

	[Token(Token = "0x400074B")]
	[FieldOffset(Offset = "0x14")]
	public uint EPEventId;

	[Token(Token = "0x400074C")]
	[FieldOffset(Offset = "0x18")]
	public uint TargetValue;

	[Token(Token = "0x400074D")]
	[FieldOffset(Offset = "0x1C")]
	public uint TargetValue2;

	[Token(Token = "0x400074E")]
	[FieldOffset(Offset = "0x20")]
	public uint AwardId;

	[Token(Token = "0x400074F")]
	[FieldOffset(Offset = "0x24")]
	public uint AwardNum;

	[Token(Token = "0x4000750")]
	[FieldOffset(Offset = "0x28")]
	public uint AwardTime;

	[Token(Token = "0x4000751")]
	[FieldOffset(Offset = "0x2C")]
	public uint AwardId2;

	[Token(Token = "0x4000752")]
	[FieldOffset(Offset = "0x30")]
	public uint AwardNum2;

	[Token(Token = "0x4000753")]
	[FieldOffset(Offset = "0x34")]
	public uint AwardTime2;

	[Token(Token = "0x4000754")]
	[FieldOffset(Offset = "0x38")]
	public uint AwardId3;

	[Token(Token = "0x4000755")]
	[FieldOffset(Offset = "0x3C")]
	public uint AwardNum3;

	[Token(Token = "0x4000756")]
	[FieldOffset(Offset = "0x40")]
	public uint AwardTime3;

	[Token(Token = "0x4000757")]
	[FieldOffset(Offset = "0x44")]
	public byte CountType;

	[Token(Token = "0x4000758")]
	[FieldOffset(Offset = "0x45")]
	public byte ConditionType;

	[Token(Token = "0x4000759")]
	[FieldOffset(Offset = "0x46")]
	public byte AwardType;

	[Token(Token = "0x400075A")]
	[FieldOffset(Offset = "0x47")]
	public byte AwardType2;

	[Token(Token = "0x400075B")]
	[FieldOffset(Offset = "0x48")]
	public byte AwardType3;

	[Token(Token = "0x600070E")]
	[Address(RVA = "0x1C9FAD4", Offset = "0x1C9FAD4", VA = "0x1C9FAD4")]
	public EPMonthlyQuestData()
	{
	}

	[Token(Token = "0x600070F")]
	[Address(RVA = "0x1C9FADC", Offset = "0x1C9FADC", VA = "0x1C9FADC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000710")]
	[Address(RVA = "0x1C9FB40", Offset = "0x1C9FB40", VA = "0x1C9FB40", Slot = "7")]
	public override string[] GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x6000711")]
	[Address(RVA = "0x1CA07D4", Offset = "0x1CA07D4", VA = "0x1CA07D4", Slot = "8")]
	public override void ParseData(IIndexString ss, int[] index)
	{
	}

	[Token(Token = "0x6000712")]
	[Address(RVA = "0x1CA184C", Offset = "0x1CA184C", VA = "0x1CA184C")]
	public static void GetMonthlyDataByEPId(uint epID, out List<EPMonthlyQuestData> monthlyQuestLst)
	{
	}

	[Token(Token = "0x6000713")]
	[Address(RVA = "0x1CA1AA8", Offset = "0x1CA1AA8", VA = "0x1CA1AA8")]
	public void GetRewardList(out List<BaseItemInfo> rewardList)
	{
	}

	[Token(Token = "0x6000714")]
	[Address(RVA = "0x1CA1D20", Offset = "0x1CA1D20", VA = "0x1CA1D20")]
	public string[] _003C_003EiFixBaseProxy_GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x6000715")]
	[Address(RVA = "0x1CA1D28", Offset = "0x1CA1D28", VA = "0x1CA1D28")]
	public void _003C_003EiFixBaseProxy_ParseData(IIndexString P0, int[] P1)
	{
	}
}
