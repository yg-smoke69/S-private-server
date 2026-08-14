using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200205A")]
internal class UIHudCSSOMatchInfoController : UIBaseController
{
	[Token(Token = "0x400CAC6")]
	[FieldOffset(Offset = "0x28")]
	private UIHudCSSOMatchInfoView m_View;

	[Token(Token = "0x400CAC7")]
	[FieldOffset(Offset = "0x2C")]
	private int mSeconds;

	[Token(Token = "0x400CAC8")]
	[FieldOffset(Offset = "0x30")]
	private StringBuilder m_Timer;

	[Token(Token = "0x400CAC9")]
	[FieldOffset(Offset = "0x34")]
	private uint min;

	[Token(Token = "0x400CACA")]
	[FieldOffset(Offset = "0x38")]
	private uint sec;

	[Token(Token = "0x400CACB")]
	[FieldOffset(Offset = "0x3C")]
	private List<UIHudCSPlayerStateInfoView> m_MyTeamViews;

	[Token(Token = "0x400CACC")]
	[FieldOffset(Offset = "0x40")]
	private List<UIHudCSPlayerStateInfoView> m_OppoTeamViews;

	[Token(Token = "0x400CACD")]
	[FieldOffset(Offset = "0x44")]
	private UIHudCSSOTeamInfoView m_MyTeam;

	[Token(Token = "0x400CACE")]
	[FieldOffset(Offset = "0x48")]
	private UIHudCSSOTeamInfoView m_OppoTeam;

	[Token(Token = "0x400CACF")]
	[FieldOffset(Offset = "0x4C")]
	private BIKDLLIBDKE mGame;

	[Token(Token = "0x400CAD0")]
	[FieldOffset(Offset = "0x50")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x400CAD1")]
	[FieldOffset(Offset = "0x54")]
	private int m_TeamCount;

	[Token(Token = "0x600A551")]
	[Address(RVA = "0x212F2DC", Offset = "0x212F2DC", VA = "0x212F2DC")]
	public UIHudCSSOMatchInfoController()
	{
	}

	[Token(Token = "0x600A552")]
	[Address(RVA = "0x212F3B4", Offset = "0x212F3B4", VA = "0x212F3B4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A553")]
	[Address(RVA = "0x212F45C", Offset = "0x212F45C", VA = "0x212F45C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A554")]
	[Address(RVA = "0x212FCBC", Offset = "0x212FCBC", VA = "0x212FCBC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A555")]
	[Address(RVA = "0x2130130", Offset = "0x2130130", VA = "0x2130130", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600A556")]
	[Address(RVA = "0x2130298", Offset = "0x2130298", VA = "0x2130298")]
	private void OnBtnLeaderboardClick()
	{
	}

	[Token(Token = "0x600A557")]
	[Address(RVA = "0x21301AC", Offset = "0x21301AC", VA = "0x21301AC")]
	private void SetUIData()
	{
	}

	[Token(Token = "0x600A558")]
	[Address(RVA = "0x2131188", Offset = "0x2131188", VA = "0x2131188")]
	private void RefreshTeamStatesUI(IHAAMHPPLMG pId)
	{
	}

	[Token(Token = "0x600A559")]
	[Address(RVA = "0x2130628", Offset = "0x2130628", VA = "0x2130628")]
	private void SetTeamStatesUI(List<IHAAMHPPLMG> pids, List<UIHudCSPlayerStateInfoView> views, bool ascending = true)
	{
	}

	[Token(Token = "0x600A55A")]
	[Address(RVA = "0x213131C", Offset = "0x213131C", VA = "0x213131C")]
	private void Update()
	{
	}

	[Token(Token = "0x600A55B")]
	[Address(RVA = "0x21317A8", Offset = "0x21317A8", VA = "0x21317A8")]
	private void OnPlayerHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600A55C")]
	[Address(RVA = "0x2131900", Offset = "0x2131900", VA = "0x2131900")]
	private void OnPlayerStateChanged(object[] data)
	{
	}

	[Token(Token = "0x600A55D")]
	[Address(RVA = "0x2131A14", Offset = "0x2131A14", VA = "0x2131A14")]
	private void OnPlayerQuit(object[] data)
	{
	}

	[Token(Token = "0x600A55E")]
	[Address(RVA = "0x2131B64", Offset = "0x2131B64", VA = "0x2131B64")]
	private void OnNewPhaseEnter(object[] data)
	{
	}

	[Token(Token = "0x600A55F")]
	[Address(RVA = "0x213204C", Offset = "0x213204C", VA = "0x213204C")]
	private void OnNewMiniPhaseEnter(object[] data)
	{
	}

	[Token(Token = "0x600A560")]
	[Address(RVA = "0x21321A0", Offset = "0x21321A0", VA = "0x21321A0")]
	private void OnStartMatchEndShow(object[] data)
	{
	}

	[Token(Token = "0x600A561")]
	[Address(RVA = "0x2130418", Offset = "0x2130418", VA = "0x2130418")]
	private void SetRoundInfoUI()
	{
	}

	[Token(Token = "0x600A562")]
	[Address(RVA = "0x2130D64", Offset = "0x2130D64", VA = "0x2130D64")]
	private void SetUIColor()
	{
	}

	[Token(Token = "0x600A563")]
	[Address(RVA = "0x2131E60", Offset = "0x2131E60", VA = "0x2131E60")]
	private int CalTeamCount()
	{
		return default(int);
	}

	[Token(Token = "0x600A564")]
	[Address(RVA = "0x213220C", Offset = "0x213220C", VA = "0x213220C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A565")]
	[Address(RVA = "0x2132214", Offset = "0x2132214", VA = "0x2132214")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600A566")]
	[Address(RVA = "0x213221C", Offset = "0x213221C", VA = "0x213221C")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
