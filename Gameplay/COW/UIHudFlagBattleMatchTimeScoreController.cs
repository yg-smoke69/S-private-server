using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003351")]
public class UIHudFlagBattleMatchTimeScoreController : UIBaseController
{
	[Token(Token = "0x40138C3")]
	[FieldOffset(Offset = "0x28")]
	private UIHudFlagBattleMatchTimeScoreView m_View;

	[Token(Token = "0x40138C4")]
	[FieldOffset(Offset = "0x2C")]
	private UITimeLabelHelper m_TimeHelper;

	[Token(Token = "0x40138C5")]
	[FieldOffset(Offset = "0x30")]
	private int targetScore;

	[Token(Token = "0x40138C6")]
	[FieldOffset(Offset = "0x34")]
	private int m_ShowEffectScore;

	[Token(Token = "0x40138C7")]
	[FieldOffset(Offset = "0x38")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x40138C8")]
	[FieldOffset(Offset = "0x3C")]
	private List<GameObject> m_MyTeamEnergyStoneList;

	[Token(Token = "0x40138C9")]
	[FieldOffset(Offset = "0x40")]
	private List<GameObject> m_OppoTeamEnergyStoneList;

	[Token(Token = "0x6015D15")]
	[Address(RVA = "0x1BB02E0", Offset = "0x1BB02E0", VA = "0x1BB02E0")]
	public UIHudFlagBattleMatchTimeScoreController()
	{
	}

	[Token(Token = "0x6015D16")]
	[Address(RVA = "0x1BB03B0", Offset = "0x1BB03B0", VA = "0x1BB03B0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6015D17")]
	[Address(RVA = "0x1BB0458", Offset = "0x1BB0458", VA = "0x1BB0458", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6015D18")]
	[Address(RVA = "0x1BB09E4", Offset = "0x1BB09E4", VA = "0x1BB09E4")]
	private void InitScoreUI()
	{
	}

	[Token(Token = "0x6015D19")]
	[Address(RVA = "0x1BB0D24", Offset = "0x1BB0D24", VA = "0x1BB0D24", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6015D1A")]
	[Address(RVA = "0x1BB0EC0", Offset = "0x1BB0EC0", VA = "0x1BB0EC0")]
	private void OnPhaseTimeChange(object[] data)
	{
	}

	[Token(Token = "0x6015D1B")]
	[Address(RVA = "0x1BB0F44", Offset = "0x1BB0F44", VA = "0x1BB0F44")]
	private void OnEnergyStoneCountChange(object[] data)
	{
	}

	[Token(Token = "0x6015D1C")]
	[Address(RVA = "0x1BB1190", Offset = "0x1BB1190", VA = "0x1BB1190")]
	private void OnShowWinGOalTutorial(object[] param)
	{
	}

	[Token(Token = "0x6015D1D")]
	[Address(RVA = "0x1BB12CC", Offset = "0x1BB12CC", VA = "0x1BB12CC")]
	private void Update()
	{
	}

	[Token(Token = "0x6015D1E")]
	[Address(RVA = "0x1BB1344", Offset = "0x1BB1344", VA = "0x1BB1344")]
	private void OnLeaderBoardClick()
	{
	}

	[Token(Token = "0x6015D1F")]
	[Address(RVA = "0x1BB149C", Offset = "0x1BB149C", VA = "0x1BB149C")]
	private void OnTeamScoreChange(object[] data)
	{
	}

	[Token(Token = "0x6015D20")]
	[Address(RVA = "0x1BB0B70", Offset = "0x1BB0B70", VA = "0x1BB0B70")]
	private void ClearUIShow()
	{
	}

	[Token(Token = "0x6015D21")]
	[Address(RVA = "0x1BB1730", Offset = "0x1BB1730", VA = "0x1BB1730")]
	private void PlayLocalOccupyEffect()
	{
	}

	[Token(Token = "0x6015D22")]
	[Address(RVA = "0x1BB181C", Offset = "0x1BB181C", VA = "0x1BB181C")]
	private void PlayOppOccupyEffect()
	{
	}

	[Token(Token = "0x6015D23")]
	[Address(RVA = "0x1BB1908", Offset = "0x1BB1908", VA = "0x1BB1908")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6015D24")]
	[Address(RVA = "0x1BB1910", Offset = "0x1BB1910", VA = "0x1BB1910")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
