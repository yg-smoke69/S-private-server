using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200011B")]
internal class EPDailyChallengeData : EPChallengeData
{
	[Token(Token = "0x4000723")]
	[FieldOffset(Offset = "0x4C")]
	public uint ChallengeDate;

	[Token(Token = "0x4000724")]
	[FieldOffset(Offset = "0x50")]
	public EInventory.AwardType AwardType2;

	[Token(Token = "0x4000725")]
	[FieldOffset(Offset = "0x54")]
	public uint AwardID2;

	[Token(Token = "0x4000726")]
	[FieldOffset(Offset = "0x58")]
	public uint AwardNum2;

	[Token(Token = "0x4000727")]
	[FieldOffset(Offset = "0x5C")]
	public uint AwardTime2;

	[Token(Token = "0x60006E9")]
	[Address(RVA = "0x1C9CA00", Offset = "0x1C9CA00", VA = "0x1C9CA00")]
	public EPDailyChallengeData()
	{
	}

	[Token(Token = "0x60006EA")]
	[Address(RVA = "0x1C9CA08", Offset = "0x1C9CA08", VA = "0x1C9CA08", Slot = "7")]
	public override string[] GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x60006EB")]
	[Address(RVA = "0x1C9CCC0", Offset = "0x1C9CCC0", VA = "0x1C9CCC0", Slot = "9")]
	protected override void DoParseData(IIndexString ss, int[] index)
	{
	}

	[Token(Token = "0x60006EC")]
	[Address(RVA = "0x1C9D2C0", Offset = "0x1C9D2C0", VA = "0x1C9D2C0", Slot = "10")]
	protected override void DoCreateRewardList()
	{
	}

	[Token(Token = "0x60006ED")]
	[Address(RVA = "0x1C9D578", Offset = "0x1C9D578", VA = "0x1C9D578")]
	protected BaseItemInfo CreateAwardInfo2()
	{
		return null;
	}

	[Token(Token = "0x60006EE")]
	[Address(RVA = "0x1C9D6BC", Offset = "0x1C9D6BC", VA = "0x1C9D6BC")]
	public static List<EPDailyChallengeData> GetDailyChallengeDataByDateOfWeek(uint date)
	{
		return null;
	}

	[Token(Token = "0x60006EF")]
	[Address(RVA = "0x1C9D8EC", Offset = "0x1C9D8EC", VA = "0x1C9D8EC")]
	public BaseItemInfo[] GetDailyRewardLst()
	{
		return null;
	}

	[Token(Token = "0x60006F0")]
	[Address(RVA = "0x1C9D944", Offset = "0x1C9D944", VA = "0x1C9D944")]
	public new string[] _003C_003EiFixBaseProxy_GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x60006F1")]
	[Address(RVA = "0x1C9D948", Offset = "0x1C9D948", VA = "0x1C9D948")]
	public void _003C_003EiFixBaseProxy_DoParseData(IIndexString P0, int[] P1)
	{
	}

	[Token(Token = "0x60006F2")]
	[Address(RVA = "0x1C9D94C", Offset = "0x1C9D94C", VA = "0x1C9D94C")]
	public void _003C_003EiFixBaseProxy_DoCreateRewardList()
	{
	}
}
