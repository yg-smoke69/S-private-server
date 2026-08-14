using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200225E")]
internal class UIHudUGCTwoTeamMatchResultController : UIHudTeamBattleMatchResultController
{
	[Token(Token = "0x600BBB5")]
	[Address(RVA = "0x1A678B0", Offset = "0x1A678B0", VA = "0x1A678B0")]
	public UIHudUGCTwoTeamMatchResultController()
	{
	}

	[Token(Token = "0x600BBB6")]
	[Address(RVA = "0x1A678B8", Offset = "0x1A678B8", VA = "0x1A678B8")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BBB7")]
	[Address(RVA = "0x1A67960", Offset = "0x1A67960", VA = "0x1A67960", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BBB8")]
	[Address(RVA = "0x1A679CC", Offset = "0x1A679CC", VA = "0x1A679CC", Slot = "48")]
	protected override void RefreshDetailUI(MatchStats stats)
	{
	}

	[Token(Token = "0x600BBB9")]
	[Address(RVA = "0x1A688CC", Offset = "0x1A688CC", VA = "0x1A688CC", Slot = "54")]
	protected override bool CheckIsWinTeamPlayerForSpectator(IHAAMHPPLMG playerID)
	{
		return default(bool);
	}

	[Token(Token = "0x600BBBA")]
	[Address(RVA = "0x1A68964", Offset = "0x1A68964", VA = "0x1A68964", Slot = "57")]
	protected override bool UseLongTeamList()
	{
		return default(bool);
	}

	[Token(Token = "0x600BBBB")]
	[Address(RVA = "0x1A67D6C", Offset = "0x1A67D6C", VA = "0x1A67D6C")]
	private void SetMatch(UGCMatchStats matchStats)
	{
	}

	[Token(Token = "0x600BBBC")]
	[Address(RVA = "0x1A685EC", Offset = "0x1A685EC", VA = "0x1A685EC")]
	private void SetTeam(bool isLeftSide, UGCTeamStats teamStats)
	{
	}

	[Token(Token = "0x600BBBD")]
	[Address(RVA = "0x1A689BC", Offset = "0x1A689BC", VA = "0x1A689BC")]
	private void SetAllTeammates(bool isLeftSide, List<UGCPlayerStats> playerStats)
	{
	}

	[Token(Token = "0x600BBBE")]
	[Address(RVA = "0x1A6833C", Offset = "0x1A6833C", VA = "0x1A6833C")]
	private void ClearDefaultUI()
	{
	}

	[Token(Token = "0x600BBBF")]
	[Address(RVA = "0x1A68BC0", Offset = "0x1A68BC0", VA = "0x1A68BC0")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BBC0")]
	[Address(RVA = "0x1A68BC8", Offset = "0x1A68BC8", VA = "0x1A68BC8")]
	public new void _003C_003EiFixBaseProxy_RefreshDetailUI(MatchStats P0)
	{
	}

	[Token(Token = "0x600BBC1")]
	[Address(RVA = "0x1A68BD0", Offset = "0x1A68BD0", VA = "0x1A68BD0")]
	public new bool _003C_003EiFixBaseProxy_CheckIsWinTeamPlayerForSpectator(IHAAMHPPLMG P0)
	{
		return default(bool);
	}

	[Token(Token = "0x600BBC2")]
	[Address(RVA = "0x1A68C04", Offset = "0x1A68C04", VA = "0x1A68C04")]
	public bool _003C_003EiFixBaseProxy_UseLongTeamList()
	{
		return default(bool);
	}
}
