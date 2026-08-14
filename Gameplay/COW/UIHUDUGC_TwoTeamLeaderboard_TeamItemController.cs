using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002481")]
internal class UIHUDUGC_TwoTeamLeaderboard_TeamItemController : UIHUDUGC_BaseLeaderboard_TeamItemController
{
	[Token(Token = "0x400E274")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_TwoTeamLeaderboard_TeamItemView m_View;

	[Token(Token = "0x400E275")]
	[FieldOffset(Offset = "0x2C")]
	private List<UIHUDUGC_TwoTeamLeaderboard_TeammateItemController> m_TeammateList;

	[Token(Token = "0x400E276")]
	[FieldOffset(Offset = "0x30")]
	private List<int> m_ScoreTypes;

	[Token(Token = "0x600D042")]
	[Address(RVA = "0x292982C", Offset = "0x292982C", VA = "0x292982C")]
	public UIHUDUGC_TwoTeamLeaderboard_TeamItemController()
	{
	}

	[Token(Token = "0x600D043")]
	[Address(RVA = "0x29298B8", Offset = "0x29298B8", VA = "0x29298B8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D044")]
	[Address(RVA = "0x292995C", Offset = "0x292995C", VA = "0x292995C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D045")]
	[Address(RVA = "0x29285AC", Offset = "0x29285AC", VA = "0x29285AC")]
	public void SetViewData(List<int> scoreTypes)
	{
	}

	[Token(Token = "0x600D046")]
	[Address(RVA = "0x2929DD8", Offset = "0x2929DD8", VA = "0x2929DD8", Slot = "31")]
	public override UIHUDUGC_BaseLeaderboard_TeammateItemController CreateTeammateItem(Player player)
	{
		return null;
	}

	[Token(Token = "0x600D047")]
	[Address(RVA = "0x29272DC", Offset = "0x29272DC", VA = "0x29272DC")]
	public void CheckScrollView()
	{
	}

	[Token(Token = "0x600D048")]
	[Address(RVA = "0x2929FC0", Offset = "0x2929FC0", VA = "0x2929FC0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
