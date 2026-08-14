using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002483")]
internal class UIHUDUGC_TwoTeamLeaderboardController : UIHUDUGC_BaseLeaderboardController
{
	[Token(Token = "0x400E279")]
	[FieldOffset(Offset = "0x40")]
	private UIHUDUGC_TwoTeamLeaderboardView m_View;

	[Token(Token = "0x400E27A")]
	[FieldOffset(Offset = "0x44")]
	private TwoTeamLeaderboardHudEntity m_ViewData;

	[Token(Token = "0x400E27B")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<int, UIHUDUGC_TwoTeamLeaderboard_TeamItemController> m_TeamDict;

	[Token(Token = "0x400E27C")]
	[FieldOffset(Offset = "0x4C")]
	private Dictionary<IHAAMHPPLMG, UIHUDUGC_BaseLeaderboard_TeammateItemController> m_TeammateDict;

	[Token(Token = "0x600D056")]
	[Address(RVA = "0x2926E2C", Offset = "0x2926E2C", VA = "0x2926E2C")]
	public UIHUDUGC_TwoTeamLeaderboardController()
	{
	}

	[Token(Token = "0x600D057")]
	[Address(RVA = "0x2926EEC", Offset = "0x2926EEC", VA = "0x2926EEC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D058")]
	[Address(RVA = "0x2926F90", Offset = "0x2926F90", VA = "0x2926F90", Slot = "33")]
	protected override void InitView()
	{
	}

	[Token(Token = "0x600D059")]
	[Address(RVA = "0x29270E0", Offset = "0x29270E0", VA = "0x29270E0", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600D05A")]
	[Address(RVA = "0x29273B4", Offset = "0x29273B4", VA = "0x29273B4", Slot = "39")]
	public override void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600D05B")]
	[Address(RVA = "0x29276AC", Offset = "0x29276AC", VA = "0x29276AC", Slot = "40")]
	public override void DestroyEntity()
	{
	}

	[Token(Token = "0x600D05C")]
	[Address(RVA = "0x292772C", Offset = "0x292772C", VA = "0x292772C", Slot = "36")]
	protected override UIHUDUGC_BaseLeaderboard_TeamItemController GetTeamItem(int teamIndex)
	{
		return null;
	}

	[Token(Token = "0x600D05D")]
	[Address(RVA = "0x2927838", Offset = "0x2927838", VA = "0x2927838", Slot = "34")]
	protected override UIHUDUGC_BaseLeaderboard_TeammateItemController CreateTeammateItem(Player player)
	{
		return null;
	}

	[Token(Token = "0x600D05E")]
	[Address(RVA = "0x2927A58", Offset = "0x2927A58", VA = "0x2927A58", Slot = "35")]
	protected override UIHUDUGC_BaseLeaderboard_TeammateItemController FindTeammateItem(IHAAMHPPLMG playerId)
	{
		return null;
	}

	[Token(Token = "0x600D05F")]
	[Address(RVA = "0x2927BBC", Offset = "0x2927BBC", VA = "0x2927BBC", Slot = "38")]
	protected override void UpdateAllTeammateItemInfo()
	{
	}

	[Token(Token = "0x600D060")]
	[Address(RVA = "0x2927DAC", Offset = "0x2927DAC", VA = "0x2927DAC")]
	private void OnSpaceBtnClick()
	{
	}

	[Token(Token = "0x600D061")]
	[Address(RVA = "0x2927FB4", Offset = "0x2927FB4", VA = "0x2927FB4")]
	private void OnOpenStateChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600D062")]
	[Address(RVA = "0x292803C", Offset = "0x292803C", VA = "0x292803C")]
	private void OnLeftTeamIndexChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600D063")]
	[Address(RVA = "0x2928AD0", Offset = "0x2928AD0", VA = "0x2928AD0")]
	private void OnRightTeamIndexChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600D064")]
	[Address(RVA = "0x2929040", Offset = "0x2929040", VA = "0x2929040")]
	private void OnLeftTeamScoreChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600D065")]
	[Address(RVA = "0x2929104", Offset = "0x2929104", VA = "0x2929104")]
	private void OnRightTeamScoreChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600D066")]
	[Address(RVA = "0x29291C8", Offset = "0x29291C8", VA = "0x29291C8")]
	private void OnPlayerScoreTypesChanged(List<object> old, List<object> cur)
	{
	}

	[Token(Token = "0x600D067")]
	[Address(RVA = "0x2929524", Offset = "0x2929524", VA = "0x2929524")]
	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600D068")]
	[Address(RVA = "0x292952C", Offset = "0x292952C", VA = "0x292952C")]
	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	[Token(Token = "0x600D069")]
	[Address(RVA = "0x2929534", Offset = "0x2929534", VA = "0x2929534")]
	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}

	[Token(Token = "0x600D06A")]
	[Address(RVA = "0x292953C", Offset = "0x292953C", VA = "0x292953C")]
	public void _003C_003EiFixBaseProxy_UpdateAllTeammateItemInfo()
	{
	}
}
