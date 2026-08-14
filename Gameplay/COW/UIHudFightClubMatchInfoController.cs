using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200204F")]
internal class UIHudFightClubMatchInfoController : UIBaseController
{
	[Token(Token = "0x400CA82")]
	[FieldOffset(Offset = "0x28")]
	private UIHudFightClubMatchInfoView m_View;

	[Token(Token = "0x400CA83")]
	[FieldOffset(Offset = "0x2C")]
	private int mSeconds;

	[Token(Token = "0x400CA84")]
	[FieldOffset(Offset = "0x30")]
	private StringBuilder m_Timer;

	[Token(Token = "0x400CA85")]
	[FieldOffset(Offset = "0x34")]
	private uint min;

	[Token(Token = "0x400CA86")]
	[FieldOffset(Offset = "0x38")]
	private uint sec;

	[Token(Token = "0x400CA87")]
	[FieldOffset(Offset = "0x3C")]
	private List<UIHudCSPlayerStateInfoView> m_MyTeamViews;

	[Token(Token = "0x400CA88")]
	[FieldOffset(Offset = "0x40")]
	private List<UIHudCSPlayerStateInfoView> m_OppoTeamViews;

	[Token(Token = "0x400CA89")]
	[FieldOffset(Offset = "0x44")]
	private BPBDKNHJODF mGame;

	[Token(Token = "0x400CA8A")]
	[FieldOffset(Offset = "0x48")]
	private uint m_TutorialLeadboardDelayCall;

	[Token(Token = "0x400CA8B")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x400CA8C")]
	[FieldOffset(Offset = "0x50")]
	private int m_TeamCount;

	[Token(Token = "0x600A4AC")]
	[Address(RVA = "0x1B9C428", Offset = "0x1B9C428", VA = "0x1B9C428")]
	public UIHudFightClubMatchInfoController()
	{
	}

	[Token(Token = "0x600A4AD")]
	[Address(RVA = "0x1B9C500", Offset = "0x1B9C500", VA = "0x1B9C500")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A4AE")]
	[Address(RVA = "0x1B9C5A8", Offset = "0x1B9C5A8", VA = "0x1B9C5A8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A4AF")]
	[Address(RVA = "0x1B9CDA8", Offset = "0x1B9CDA8", VA = "0x1B9CDA8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A4B0")]
	[Address(RVA = "0x1B9D298", Offset = "0x1B9D298", VA = "0x1B9D298", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600A4B1")]
	[Address(RVA = "0x1B9D3F4", Offset = "0x1B9D3F4", VA = "0x1B9D3F4")]
	private void OnBtnLeaderboardClick()
	{
	}

	[Token(Token = "0x600A4B2")]
	[Address(RVA = "0x1B9D314", Offset = "0x1B9D314", VA = "0x1B9D314")]
	private void SetUIData()
	{
	}

	[Token(Token = "0x600A4B3")]
	[Address(RVA = "0x1B9DE6C", Offset = "0x1B9DE6C", VA = "0x1B9DE6C")]
	private void RefreshTeamStatesUI(IHAAMHPPLMG pId)
	{
	}

	[Token(Token = "0x600A4B4")]
	[Address(RVA = "0x1B9D730", Offset = "0x1B9D730", VA = "0x1B9D730")]
	private void SetTeamStatesUI(List<IHAAMHPPLMG> pids, List<UIHudCSPlayerStateInfoView> views, bool ascending = true)
	{
	}

	[Token(Token = "0x600A4B5")]
	[Address(RVA = "0x1B9E000", Offset = "0x1B9E000", VA = "0x1B9E000")]
	private void Update()
	{
	}

	[Token(Token = "0x600A4B6")]
	[Address(RVA = "0x1B9E560", Offset = "0x1B9E560", VA = "0x1B9E560")]
	private void OnPlayerHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600A4B7")]
	[Address(RVA = "0x1B9E6B8", Offset = "0x1B9E6B8", VA = "0x1B9E6B8")]
	private void OnPlayerStateChanged(object[] data)
	{
	}

	[Token(Token = "0x600A4B8")]
	[Address(RVA = "0x1B9E7CC", Offset = "0x1B9E7CC", VA = "0x1B9E7CC")]
	private void OnPlayerQuit(object[] data)
	{
	}

	[Token(Token = "0x600A4B9")]
	[Address(RVA = "0x1B9E91C", Offset = "0x1B9E91C", VA = "0x1B9E91C")]
	private void OnScoreChanged(object[] data)
	{
	}

	[Token(Token = "0x600A4BA")]
	[Address(RVA = "0x1B9ECCC", Offset = "0x1B9ECCC", VA = "0x1B9ECCC")]
	private void OnNewPhaseEnter(object[] data)
	{
	}

	[Token(Token = "0x600A4BB")]
	[Address(RVA = "0x1B9EDB4", Offset = "0x1B9EDB4", VA = "0x1B9EDB4")]
	private void OnStartMatchEndShow(object[] data)
	{
	}

	[Token(Token = "0x600A4BC")]
	[Address(RVA = "0x1B9D54C", Offset = "0x1B9D54C", VA = "0x1B9D54C")]
	private void SetRoundInfoUI()
	{
	}

	[Token(Token = "0x600A4BD")]
	[Address(RVA = "0x1B9EE20", Offset = "0x1B9EE20", VA = "0x1B9EE20")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A4BE")]
	[Address(RVA = "0x1B9EE28", Offset = "0x1B9EE28", VA = "0x1B9EE28")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600A4BF")]
	[Address(RVA = "0x1B9EE30", Offset = "0x1B9EE30", VA = "0x1B9EE30")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
