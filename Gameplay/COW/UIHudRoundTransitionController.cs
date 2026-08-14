using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2002055")]
internal class UIHudRoundTransitionController : UIBaseController
{
	[Token(Token = "0x400CAA6")]
	[FieldOffset(Offset = "0x28")]
	private UIHudRoundTransitionView m_View;

	[Token(Token = "0x400CAA7")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x400CAA8")]
	[FieldOffset(Offset = "0x30")]
	private List<GameObject> m_BonusItemList;

	[Token(Token = "0x400CAA9")]
	[FieldOffset(Offset = "0x34")]
	private JBCMHIAGMHA mGame;

	[Token(Token = "0x400CAAA")]
	[FieldOffset(Offset = "0x38")]
	private int m_ScoreCached;

	[Token(Token = "0x400CAAB")]
	[FieldOffset(Offset = "0x3C")]
	private float m_Time;

	[Token(Token = "0x400CAAC")]
	[FieldOffset(Offset = "0x40")]
	private bool m_ScoreAnimTick;

	[Token(Token = "0x400CAAD")]
	[FieldOffset(Offset = "0x41")]
	private bool m_IsSetSelfTeamInfo;

	[Token(Token = "0x400CAAE")]
	[FieldOffset(Offset = "0x42")]
	private bool m_IsSetOppoTeamInfo;

	[Token(Token = "0x400CAAF")]
	[FieldOffset(Offset = "0x44")]
	private int m_LocalPlayerTeamId;

	[Token(Token = "0x600A503")]
	[Address(RVA = "0x1C40400", Offset = "0x1C40400", VA = "0x1C40400")]
	public UIHudRoundTransitionController()
	{
	}

	[Token(Token = "0x600A504")]
	[Address(RVA = "0x1C404B8", Offset = "0x1C404B8", VA = "0x1C404B8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A505")]
	[Address(RVA = "0x1C40560", Offset = "0x1C40560", VA = "0x1C40560", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A506")]
	[Address(RVA = "0x1C41450", Offset = "0x1C41450", VA = "0x1C41450", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600A507")]
	[Address(RVA = "0x1C41B44", Offset = "0x1C41B44", VA = "0x1C41B44", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600A508")]
	[Address(RVA = "0x1C42458", Offset = "0x1C42458", VA = "0x1C42458")]
	private void Update()
	{
	}

	[Token(Token = "0x600A509")]
	[Address(RVA = "0x1C42960", Offset = "0x1C42960", VA = "0x1C42960")]
	private void OnEarnedCoinChanged(object[] data)
	{
	}

	[Token(Token = "0x600A50A")]
	[Address(RVA = "0x1C42054", Offset = "0x1C42054", VA = "0x1C42054")]
	private void SetUIData()
	{
	}

	[Token(Token = "0x600A50B")]
	[Address(RVA = "0x1C42AEC", Offset = "0x1C42AEC", VA = "0x1C42AEC")]
	public void SetBonusDetailsView(DMJPAJFMMMB res)
	{
	}

	[Token(Token = "0x600A50C")]
	[Address(RVA = "0x1C435E0", Offset = "0x1C435E0", VA = "0x1C435E0")]
	private string GetDescriptionOfBonusType(IKFOMLELBPG bonusType)
	{
		return null;
	}

	[Token(Token = "0x600A50D")]
	[Address(RVA = "0x1C43B2C", Offset = "0x1C43B2C", VA = "0x1C43B2C")]
	private void OnScoreChanged(object[] data)
	{
	}

	[Token(Token = "0x600A50E")]
	[Address(RVA = "0x1C42508", Offset = "0x1C42508", VA = "0x1C42508")]
	private void ShowScores()
	{
	}

	[Token(Token = "0x600A50F")]
	[Address(RVA = "0x1C423F0", Offset = "0x1C423F0", VA = "0x1C423F0")]
	private void ResetScoreAnimation()
	{
	}

	[Token(Token = "0x600A510")]
	[Address(RVA = "0x1C43D04", Offset = "0x1C43D04", VA = "0x1C43D04")]
	private void OnLocalPlayerJoin(object[] data)
	{
	}

	[Token(Token = "0x600A511")]
	[Address(RVA = "0x1C41200", Offset = "0x1C41200", VA = "0x1C41200")]
	private void OnFactionIDChanged(object[] data)
	{
	}

	[Token(Token = "0x600A512")]
	[Address(RVA = "0x1C44030", Offset = "0x1C44030", VA = "0x1C44030")]
	private void OnNewPhaseEnter(object[] data)
	{
	}

	[Token(Token = "0x600A513")]
	[Address(RVA = "0x1C446A0", Offset = "0x1C446A0", VA = "0x1C446A0")]
	private void OnMatchPoint(object[] data)
	{
	}

	[Token(Token = "0x600A514")]
	[Address(RVA = "0x1C442B8", Offset = "0x1C442B8", VA = "0x1C442B8")]
	private void RefreshMatchPointNode()
	{
	}

	[Token(Token = "0x600A515")]
	[Address(RVA = "0x1C44708", Offset = "0x1C44708", VA = "0x1C44708")]
	private void OnAnimEventGridReposition(object[] data)
	{
	}

	[Token(Token = "0x600A516")]
	[Address(RVA = "0x1C447A4", Offset = "0x1C447A4", VA = "0x1C447A4")]
	private void OnAnimEventShowMatchPoint(object[] data)
	{
	}

	[Token(Token = "0x600A517")]
	[Address(RVA = "0x1C44908", Offset = "0x1C44908", VA = "0x1C44908")]
	private void OnAnimEventShowLastRound(object[] data)
	{
	}

	[Token(Token = "0x600A518")]
	[Address(RVA = "0x1C44AE8", Offset = "0x1C44AE8", VA = "0x1C44AE8")]
	private void OnTransitionAppear(object[] data)
	{
	}

	[Token(Token = "0x600A519")]
	[Address(RVA = "0x1C44C24", Offset = "0x1C44C24", VA = "0x1C44C24")]
	private void OnShowRound(object[] data)
	{
	}

	[Token(Token = "0x600A51A")]
	[Address(RVA = "0x1C44D60", Offset = "0x1C44D60", VA = "0x1C44D60")]
	private void OnGameZoneIndexChanged(object[] data)
	{
	}

	[Token(Token = "0x600A51B")]
	[Address(RVA = "0x1C4512C", Offset = "0x1C4512C", VA = "0x1C4512C")]
	private void OnPlayerJoin(object[] data)
	{
	}

	[Token(Token = "0x600A51C")]
	[Address(RVA = "0x1C45660", Offset = "0x1C45660", VA = "0x1C45660")]
	private void OnObserveredPlayerJoin(IHAAMHPPLMG playerID)
	{
	}

	[Token(Token = "0x600A51D")]
	[Address(RVA = "0x1C45B3C", Offset = "0x1C45B3C", VA = "0x1C45B3C")]
	private bool IsTeamOnLeft(IHAAMHPPLMG pId)
	{
		return default(bool);
	}

	[Token(Token = "0x600A51E")]
	[Address(RVA = "0x1C45C00", Offset = "0x1C45C00", VA = "0x1C45C00")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A51F")]
	[Address(RVA = "0x1C45C08", Offset = "0x1C45C08", VA = "0x1C45C08")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600A520")]
	[Address(RVA = "0x1C45C10", Offset = "0x1C45C10", VA = "0x1C45C10")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
