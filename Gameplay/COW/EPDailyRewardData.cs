using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200011D")]
public class EPDailyRewardData : CSVBaseData
{
	[Token(Token = "0x400072D")]
	[FieldOffset(Offset = "0x8")]
	public uint EPEventId;

	[Token(Token = "0x400072E")]
	[FieldOffset(Offset = "0xC")]
	public uint CountNum;

	[Token(Token = "0x400072F")]
	[FieldOffset(Offset = "0x10")]
	public uint AwardId;

	[Token(Token = "0x4000730")]
	[FieldOffset(Offset = "0x14")]
	public uint AwardNum;

	[Token(Token = "0x4000731")]
	[FieldOffset(Offset = "0x18")]
	public uint EPAwardNum;

	[Token(Token = "0x4000732")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<EPDailyRewardData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60006FA")]
	[Address(RVA = "0x1C9E788", Offset = "0x1C9E788", VA = "0x1C9E788")]
	public EPDailyRewardData()
	{
	}

	[Token(Token = "0x60006FB")]
	[Address(RVA = "0x1C9E80C", Offset = "0x1C9E80C", VA = "0x1C9E80C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60006FC")]
	[Address(RVA = "0x1C9E894", Offset = "0x1C9E894", VA = "0x1C9E894", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x60006FD")]
	[Address(RVA = "0x1C9EA54", Offset = "0x1C9EA54", VA = "0x1C9EA54")]
	public static void GetDailyRewardByEPId(uint epId, out List<EPDailyRewardData> dailyRewardData)
	{
	}

	[Token(Token = "0x60006FE")]
	[Address(RVA = "0x1C9ED74", Offset = "0x1C9ED74", VA = "0x1C9ED74")]
	private static int _003CGetDailyRewardByEPId_003Em__0(EPDailyRewardData a, EPDailyRewardData b)
	{
		return default(int);
	}
}
