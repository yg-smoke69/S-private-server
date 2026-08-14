using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200011A")]
public class EPChallengeData : CsvDataIndexedReading
{
	[Token(Token = "0x400070F")]
	[FieldOffset(Offset = "0x8")]
	protected BaseItemInfo[] RewardLst;

	[Token(Token = "0x4000710")]
	[FieldOffset(Offset = "0xC")]
	public string ChallengeDesc;

	[Token(Token = "0x4000711")]
	[FieldOffset(Offset = "0x10")]
	public uint EPEventID;

	[Token(Token = "0x4000712")]
	[FieldOffset(Offset = "0x14")]
	public uint ChallengeId;

	[Token(Token = "0x4000713")]
	[FieldOffset(Offset = "0x18")]
	public int TargetValue;

	[Token(Token = "0x4000714")]
	[FieldOffset(Offset = "0x1C")]
	public int TargetValue2;

	[Token(Token = "0x4000715")]
	[FieldOffset(Offset = "0x20")]
	public uint AwardID;

	[Token(Token = "0x4000716")]
	[FieldOffset(Offset = "0x24")]
	public int AwardNum;

	[Token(Token = "0x4000717")]
	[FieldOffset(Offset = "0x28")]
	public uint AwardTime;

	[Token(Token = "0x4000718")]
	[FieldOffset(Offset = "0x2C")]
	public int SpecialChallenge;

	[Token(Token = "0x4000719")]
	[FieldOffset(Offset = "0x30")]
	public uint Group;

	[Token(Token = "0x400071A")]
	[FieldOffset(Offset = "0x34")]
	public EInventory.AwardType AwardType;

	[Token(Token = "0x400071B")]
	[FieldOffset(Offset = "0x38")]
	public ChallengeType ChallengeType;

	[Token(Token = "0x400071C")]
	[FieldOffset(Offset = "0x39")]
	public byte CountType;

	[Token(Token = "0x400071D")]
	[FieldOffset(Offset = "0x3A")]
	public byte DisplayType;

	[Token(Token = "0x400071E")]
	[FieldOffset(Offset = "0x3B")]
	public bool isTeamWork;

	[Token(Token = "0x400071F")]
	[FieldOffset(Offset = "0x3C")]
	public bool isEPOnly;

	[Token(Token = "0x4000720")]
	[FieldOffset(Offset = "0x40")]
	public string GoPos;

	[Token(Token = "0x4000721")]
	[FieldOffset(Offset = "0x44")]
	public uint condition1Type;

	[Token(Token = "0x4000722")]
	[FieldOffset(Offset = "0x48")]
	public uint condition2Type;

	[Token(Token = "0x60006DE")]
	[Address(RVA = "0x1C9AE78", Offset = "0x1C9AE78", VA = "0x1C9AE78")]
	public EPChallengeData()
	{
	}

	[Token(Token = "0x60006DF")]
	[Address(RVA = "0x1C9AE80", Offset = "0x1C9AE80", VA = "0x1C9AE80", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60006E0")]
	[Address(RVA = "0x1C9AEE4", Offset = "0x1C9AEE4", VA = "0x1C9AEE4", Slot = "7")]
	public override string[] GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x60006E1")]
	[Address(RVA = "0x1C9B668", Offset = "0x1C9B668", VA = "0x1C9B668", Slot = "9")]
	protected virtual void DoParseData(IIndexString ss, int[] index)
	{
	}

	[Token(Token = "0x60006E2")]
	[Address(RVA = "0x1C9C3C0", Offset = "0x1C9C3C0", VA = "0x1C9C3C0", Slot = "10")]
	protected virtual void DoCreateRewardList()
	{
	}

	[Token(Token = "0x60006E3")]
	[Address(RVA = "0x1C9C538", Offset = "0x1C9C538", VA = "0x1C9C538")]
	protected BaseItemInfo CreateAwardInfo()
	{
		return null;
	}

	[Token(Token = "0x60006E4")]
	[Address(RVA = "0x1C9C680", Offset = "0x1C9C680", VA = "0x1C9C680", Slot = "8")]
	public override void ParseData(IIndexString ss, int[] index)
	{
	}

	[Token(Token = "0x60006E5")]
	[Address(RVA = "0x1C9C728", Offset = "0x1C9C728", VA = "0x1C9C728")]
	public BaseItemInfo[] GetRewardLst()
	{
		return null;
	}

	[Token(Token = "0x60006E6")]
	[Address(RVA = "0x1C9C780", Offset = "0x1C9C780", VA = "0x1C9C780")]
	public static implicit operator EPChallengeData(EPWeeklyQuestData weekData)
	{
		return null;
	}

	[Token(Token = "0x60006E7")]
	[Address(RVA = "0x1C9C9D8", Offset = "0x1C9C9D8", VA = "0x1C9C9D8")]
	public string[] _003C_003EiFixBaseProxy_GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x60006E8")]
	[Address(RVA = "0x1C9C9E0", Offset = "0x1C9C9E0", VA = "0x1C9C9E0")]
	public void _003C_003EiFixBaseProxy_ParseData(IIndexString P0, int[] P1)
	{
	}
}
