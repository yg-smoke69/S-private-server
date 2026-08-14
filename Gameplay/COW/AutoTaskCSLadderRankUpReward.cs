using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001E54")]
public class AutoTaskCSLadderRankUpReward : AutoPopupTask
{
	[Token(Token = "0x400BF34")]
	[FieldOffset(Offset = "0x8")]
	private List<CSRankData> m_CSRankUpRewardList;

	[Token(Token = "0x400BF35")]
	[FieldOffset(Offset = "0xC")]
	private bool isCSDone;

	[Token(Token = "0x400BF36")]
	[FieldOffset(Offset = "0x10")]
	private string rankName;

	[Token(Token = "0x400BF37")]
	[FieldOffset(Offset = "0x14")]
	private ResourceID RankIconRes;

	[Token(Token = "0x400BF38")]
	[FieldOffset(Offset = "0x18")]
	private uint rank;

	[Token(Token = "0x400BF39")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<AwardDesc, BaseItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400BF3A")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x60091B9")]
	[Address(RVA = "0x10EAF20", Offset = "0x10EAF20", VA = "0x10EAF20")]
	public AutoTaskCSLadderRankUpReward()
	{
	}

	[Token(Token = "0x60091BA")]
	[Address(RVA = "0x10EB098", Offset = "0x10EB098", VA = "0x10EB098", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x60091BB")]
	[Address(RVA = "0x10EB0F0", Offset = "0x10EB0F0", VA = "0x10EB0F0", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x60091BC")]
	[Address(RVA = "0x10EB968", Offset = "0x10EB968", VA = "0x10EB968", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x60091BD")]
	[Address(RVA = "0x10EB33C", Offset = "0x10EB33C", VA = "0x10EB33C")]
	private void ShowCSLadderRankUpReward()
	{
	}

	[Token(Token = "0x60091BE")]
	[Address(RVA = "0x10EBA40", Offset = "0x10EBA40", VA = "0x10EBA40")]
	private void _003CShowCSLadderRankUpReward_003Em__0()
	{
	}

	[Token(Token = "0x60091BF")]
	[Address(RVA = "0x10EBAD4", Offset = "0x10EBAD4", VA = "0x10EBAD4")]
	private static BaseItemInfo _003CShowCSLadderRankUpReward_003Em__1(AwardDesc item)
	{
		return null;
	}

	[Token(Token = "0x60091C0")]
	[Address(RVA = "0x10EBB58", Offset = "0x10EBB58", VA = "0x10EBB58")]
	private static CommonRewardItemInfo _003CShowCSLadderRankUpReward_003Em__2(BaseItemInfo item)
	{
		return null;
	}
}
