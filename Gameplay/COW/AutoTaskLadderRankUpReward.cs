using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E63")]
public class AutoTaskLadderRankUpReward : AutoPopupTask
{
	[Token(Token = "0x400BF50")]
	[FieldOffset(Offset = "0x8")]
	private List<LadderLevelData> m_RankUpRewardList;

	[Token(Token = "0x400BF51")]
	[FieldOffset(Offset = "0xC")]
	private bool isBRDone;

	[Token(Token = "0x400BF52")]
	[FieldOffset(Offset = "0x10")]
	private string rankName;

	[Token(Token = "0x400BF53")]
	[FieldOffset(Offset = "0x14")]
	private ResourceID RankIconRes;

	[Token(Token = "0x400BF54")]
	[FieldOffset(Offset = "0x18")]
	private uint rank;

	[Token(Token = "0x400BF55")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60091FB")]
	[Address(RVA = "0x10F58F4", Offset = "0x10F58F4", VA = "0x10F58F4")]
	public AutoTaskLadderRankUpReward()
	{
	}

	[Token(Token = "0x60091FC")]
	[Address(RVA = "0x10F5A6C", Offset = "0x10F5A6C", VA = "0x10F5A6C", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x60091FD")]
	[Address(RVA = "0x10F5AC4", Offset = "0x10F5AC4", VA = "0x10F5AC4", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x60091FE")]
	[Address(RVA = "0x10F6220", Offset = "0x10F6220", VA = "0x10F6220", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x60091FF")]
	[Address(RVA = "0x10F5D10", Offset = "0x10F5D10", VA = "0x10F5D10")]
	private void ShowBRLadderRankUpReward()
	{
	}

	[Token(Token = "0x6009200")]
	[Address(RVA = "0x10F62F8", Offset = "0x10F62F8", VA = "0x10F62F8")]
	private void _003CShowBRLadderRankUpReward_003Em__0()
	{
	}

	[Token(Token = "0x6009201")]
	[Address(RVA = "0x10F638C", Offset = "0x10F638C", VA = "0x10F638C")]
	private static CommonRewardItemInfo _003CShowBRLadderRankUpReward_003Em__1(BaseItemInfo item)
	{
		return null;
	}
}
