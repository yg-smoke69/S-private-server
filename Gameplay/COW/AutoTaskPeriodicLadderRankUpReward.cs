using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001E67")]
public class AutoTaskPeriodicLadderRankUpReward : AutoPopupTask
{
	[Token(Token = "0x400BF5F")]
	[FieldOffset(Offset = "0x8")]
	private List<PeriodicRankData> m_PeriodicRankUpRewardList;

	[Token(Token = "0x400BF60")]
	[FieldOffset(Offset = "0xC")]
	private bool isPeriodicDone;

	[Token(Token = "0x400BF61")]
	[FieldOffset(Offset = "0x10")]
	private string rankName;

	[Token(Token = "0x400BF62")]
	[FieldOffset(Offset = "0x14")]
	private ResourceID RankIconRes;

	[Token(Token = "0x400BF63")]
	[FieldOffset(Offset = "0x18")]
	private uint rank;

	[Token(Token = "0x400BF64")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<AwardDesc, BaseItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400BF65")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x6009210")]
	[Address(RVA = "0x10F7C1C", Offset = "0x10F7C1C", VA = "0x10F7C1C")]
	public AutoTaskPeriodicLadderRankUpReward()
	{
	}

	[Token(Token = "0x6009211")]
	[Address(RVA = "0x10F7D94", Offset = "0x10F7D94", VA = "0x10F7D94", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x6009212")]
	[Address(RVA = "0x10F7DEC", Offset = "0x10F7DEC", VA = "0x10F7DEC", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x6009213")]
	[Address(RVA = "0x10F8664", Offset = "0x10F8664", VA = "0x10F8664", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6009214")]
	[Address(RVA = "0x10F8038", Offset = "0x10F8038", VA = "0x10F8038")]
	private void ShowPeriodicLadderRankUpReward()
	{
	}

	[Token(Token = "0x6009215")]
	[Address(RVA = "0x10F873C", Offset = "0x10F873C", VA = "0x10F873C")]
	private void _003CShowPeriodicLadderRankUpReward_003Em__0()
	{
	}

	[Token(Token = "0x6009216")]
	[Address(RVA = "0x10F87D0", Offset = "0x10F87D0", VA = "0x10F87D0")]
	private static BaseItemInfo _003CShowPeriodicLadderRankUpReward_003Em__1(AwardDesc item)
	{
		return null;
	}

	[Token(Token = "0x6009217")]
	[Address(RVA = "0x10F8854", Offset = "0x10F8854", VA = "0x10F8854")]
	private static CommonRewardItemInfo _003CShowPeriodicLadderRankUpReward_003Em__2(BaseItemInfo item)
	{
		return null;
	}
}
