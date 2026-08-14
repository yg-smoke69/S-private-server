using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200245A")]
internal class UIHUDUGC_MoreTeamLeaderboard_TeamItemController : UIHUDUGC_BaseLeaderboard_TeamItemController
{
	[Token(Token = "0x400E1D9")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_MoreTeamLeaderboard_TeamItemView m_View;

	[Token(Token = "0x400E1DA")]
	[FieldOffset(Offset = "0x2C")]
	private List<UIHUDUGC_MoreTeamLeaderboard_TeammateItemController> m_Teammates;

	[Token(Token = "0x400E1DB")]
	[FieldOffset(Offset = "0x30")]
	private List<int> m_ScoreTypes;

	[Token(Token = "0x400E1DC")]
	[FieldOffset(Offset = "0x34")]
	private Action<Vector3> m_ClickHelpBtnAction;

	[Token(Token = "0x600CEAF")]
	[Address(RVA = "0x2E181E4", Offset = "0x2E181E4", VA = "0x2E181E4")]
	public UIHUDUGC_MoreTeamLeaderboard_TeamItemController()
	{
	}

	[Token(Token = "0x600CEB0")]
	[Address(RVA = "0x2E18270", Offset = "0x2E18270", VA = "0x2E18270")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CEB1")]
	[Address(RVA = "0x2E18314", Offset = "0x2E18314", VA = "0x2E18314", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CEB2")]
	[Address(RVA = "0x2E16A40", Offset = "0x2E16A40", VA = "0x2E16A40")]
	public void SetViewData(List<int> scoreTypes)
	{
	}

	[Token(Token = "0x600CEB3")]
	[Address(RVA = "0x2E188BC", Offset = "0x2E188BC", VA = "0x2E188BC", Slot = "31")]
	public override UIHUDUGC_BaseLeaderboard_TeammateItemController CreateTeammateItem(Player player)
	{
		return null;
	}

	[Token(Token = "0x600CEB4")]
	[Address(RVA = "0x2E18AA8", Offset = "0x2E18AA8", VA = "0x2E18AA8")]
	public void SetTeamID(int teamIndex, bool isSelf)
	{
	}

	[Token(Token = "0x600CEB5")]
	[Address(RVA = "0x2E17238", Offset = "0x2E17238", VA = "0x2E17238")]
	public void SetTeamRank(int rank)
	{
	}

	[Token(Token = "0x600CEB6")]
	[Address(RVA = "0x2E1766C", Offset = "0x2E1766C", VA = "0x2E1766C")]
	public void SetTeamScore(int score)
	{
	}

	[Token(Token = "0x600CEB7")]
	[Address(RVA = "0x2E17B28", Offset = "0x2E17B28", VA = "0x2E17B28")]
	public void SetTeamColor(Color color)
	{
	}

	[Token(Token = "0x600CEB8")]
	[Address(RVA = "0x2E169E0", Offset = "0x2E169E0", VA = "0x2E169E0")]
	public void SetHelpBtnAction(Action<Vector3> action)
	{
	}

	[Token(Token = "0x600CEB9")]
	[Address(RVA = "0x2E18E18", Offset = "0x2E18E18", VA = "0x2E18E18")]
	private void OnHelpBtnClick()
	{
	}

	[Token(Token = "0x600CEBA")]
	[Address(RVA = "0x2E18F3C", Offset = "0x2E18F3C", VA = "0x2E18F3C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
