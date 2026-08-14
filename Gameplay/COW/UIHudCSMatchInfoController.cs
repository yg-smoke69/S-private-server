using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002046")]
internal class UIHudCSMatchInfoController : UIBaseController
{
	[Token(Token = "0x2002047")]
	private struct CSPlayerState
	{
		[Token(Token = "0x400CA59")]
		[FieldOffset(Offset = "0x0")]
		public UIHudCSPlayerStateInfoView view;

		[Token(Token = "0x400CA5A")]
		[FieldOffset(Offset = "0x4")]
		public ETeammateState state;
	}

	[Token(Token = "0x400CA4D")]
	[FieldOffset(Offset = "0x28")]
	private UIHudCSMatchInfoView m_View;

	[Token(Token = "0x400CA4E")]
	[FieldOffset(Offset = "0x2C")]
	private int mSeconds;

	[Token(Token = "0x400CA4F")]
	[FieldOffset(Offset = "0x30")]
	private StringBuilder m_Timer;

	[Token(Token = "0x400CA50")]
	[FieldOffset(Offset = "0x34")]
	private uint min;

	[Token(Token = "0x400CA51")]
	[FieldOffset(Offset = "0x38")]
	private uint sec;

	[Token(Token = "0x400CA52")]
	[FieldOffset(Offset = "0x3C")]
	private List<UIHudCSPlayerStateInfoView> m_MyTeamViews;

	[Token(Token = "0x400CA53")]
	[FieldOffset(Offset = "0x40")]
	private List<UIHudCSPlayerStateInfoView> m_OppoTeamViews;

	[Token(Token = "0x400CA54")]
	[FieldOffset(Offset = "0x44")]
	private JBCMHIAGMHA mGame;

	[Token(Token = "0x400CA55")]
	[FieldOffset(Offset = "0x48")]
	private uint m_TutorialLeadboardDelayCall;

	[Token(Token = "0x400CA56")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x400CA57")]
	[FieldOffset(Offset = "0x50")]
	private uint m_BaseTeamCount;

	[Token(Token = "0x400CA58")]
	[FieldOffset(Offset = "0x54")]
	private uint m_BaseItemSize;

	[Token(Token = "0x600A425")]
	[Address(RVA = "0x1F13658", Offset = "0x1F13658", VA = "0x1F13658")]
	public UIHudCSMatchInfoController()
	{
	}

	[Token(Token = "0x600A426")]
	[Address(RVA = "0x1F13738", Offset = "0x1F13738", VA = "0x1F13738")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A427")]
	[Address(RVA = "0x1F137E0", Offset = "0x1F137E0", VA = "0x1F137E0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A428")]
	[Address(RVA = "0x1F14960", Offset = "0x1F14960", VA = "0x1F14960")]
	private void OnShowCSGuideEnemyScore(object[] data)
	{
	}

	[Token(Token = "0x600A429")]
	[Address(RVA = "0x1F14ACC", Offset = "0x1F14ACC", VA = "0x1F14ACC")]
	private void OnShowCSGuideGameBallLabel(object[] data)
	{
	}

	[Token(Token = "0x600A42A")]
	[Address(RVA = "0x1F14868", Offset = "0x1F14868", VA = "0x1F14868")]
	private void CheckTutorialCSPaused()
	{
	}

	[Token(Token = "0x600A42B")]
	[Address(RVA = "0x1F14DA8", Offset = "0x1F14DA8", VA = "0x1F14DA8")]
	private void OnShowCSGuideFriendScore(object[] data)
	{
	}

	[Token(Token = "0x600A42C")]
	[Address(RVA = "0x1F14F14", Offset = "0x1F14F14", VA = "0x1F14F14")]
	private void OnShowCSGuideScore(object[] data)
	{
	}

	[Token(Token = "0x600A42D")]
	[Address(RVA = "0x1F14C3C", Offset = "0x1F14C3C", VA = "0x1F14C3C")]
	private void OnShowCSGuideHelloKetty(object[] data)
	{
	}

	[Token(Token = "0x600A42E")]
	[Address(RVA = "0x1F15080", Offset = "0x1F15080", VA = "0x1F15080", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A42F")]
	[Address(RVA = "0x1F155D8", Offset = "0x1F155D8", VA = "0x1F155D8", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600A430")]
	[Address(RVA = "0x1F15734", Offset = "0x1F15734", VA = "0x1F15734")]
	private void OnBtnLeaderboardClick()
	{
	}

	[Token(Token = "0x600A431")]
	[Address(RVA = "0x1F15654", Offset = "0x1F15654", VA = "0x1F15654")]
	private void SetUIData()
	{
	}

	[Token(Token = "0x600A432")]
	[Address(RVA = "0x1F15FF0", Offset = "0x1F15FF0", VA = "0x1F15FF0")]
	private void RefreshTeamStatesUI(IHAAMHPPLMG pId)
	{
	}

	[Token(Token = "0x600A433")]
	[Address(RVA = "0x1F15A70", Offset = "0x1F15A70", VA = "0x1F15A70")]
	private void SetTeamStatesUI(List<IHAAMHPPLMG> pids, List<UIHudCSPlayerStateInfoView> views, bool ascending = true)
	{
	}

	[Token(Token = "0x600A434")]
	[Address(RVA = "0x1F1642C", Offset = "0x1F1642C", VA = "0x1F1642C")]
	private void Update()
	{
	}

	[Token(Token = "0x600A435")]
	[Address(RVA = "0x1F169BC", Offset = "0x1F169BC", VA = "0x1F169BC")]
	private void OnPlayerHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600A436")]
	[Address(RVA = "0x1F16B14", Offset = "0x1F16B14", VA = "0x1F16B14")]
	private void OnPlayerStateChanged(object[] data)
	{
	}

	[Token(Token = "0x600A437")]
	[Address(RVA = "0x1F16C28", Offset = "0x1F16C28", VA = "0x1F16C28")]
	private void OnPlayerQuit(object[] data)
	{
	}

	[Token(Token = "0x600A438")]
	[Address(RVA = "0x1F16D78", Offset = "0x1F16D78", VA = "0x1F16D78")]
	private void OnShowTutorialLeaderBoard(object[] data)
	{
	}

	[Token(Token = "0x600A439")]
	[Address(RVA = "0x1F16F04", Offset = "0x1F16F04", VA = "0x1F16F04")]
	private void OnScoreChanged(object[] data)
	{
	}

	[Token(Token = "0x600A43A")]
	[Address(RVA = "0x1F172B4", Offset = "0x1F172B4", VA = "0x1F172B4")]
	private void OnNewPhaseEnter(object[] data)
	{
	}

	[Token(Token = "0x600A43B")]
	[Address(RVA = "0x1F1739C", Offset = "0x1F1739C", VA = "0x1F1739C")]
	private void OnStartMatchEndShow(object[] data)
	{
	}

	[Token(Token = "0x600A43C")]
	[Address(RVA = "0x1F1588C", Offset = "0x1F1588C", VA = "0x1F1588C")]
	private void SetRoundInfoUI()
	{
	}

	[Token(Token = "0x600A43D")]
	[Address(RVA = "0x1F17408", Offset = "0x1F17408", VA = "0x1F17408")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A43E")]
	[Address(RVA = "0x1F17410", Offset = "0x1F17410", VA = "0x1F17410")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600A43F")]
	[Address(RVA = "0x1F17418", Offset = "0x1F17418", VA = "0x1F17418")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
