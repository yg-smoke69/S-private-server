using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026C9")]
public class UIHud2TeamsTimeScoreController : UIBaseController
{
	[Token(Token = "0x400EF63")]
	[FieldOffset(Offset = "0x28")]
	private UIHud2TeamsTimeScoreView m_View;

	[Token(Token = "0x400EF64")]
	[FieldOffset(Offset = "0x2C")]
	private UITimeLabelHelper m_TimeHelper;

	[Token(Token = "0x400EF65")]
	[FieldOffset(Offset = "0x30")]
	private bool m_GuildWarFinalBgPlayed;

	[Token(Token = "0x400EF66")]
	[FieldOffset(Offset = "0x34")]
	private uint m_ScoreEffectDelayCallIDTeam1;

	[Token(Token = "0x400EF67")]
	[FieldOffset(Offset = "0x38")]
	private uint m_ScoreEffectDelayCallIDTeam2;

	[Token(Token = "0x600EA71")]
	[Address(RVA = "0x1634184", Offset = "0x1634184", VA = "0x1634184")]
	public UIHud2TeamsTimeScoreController()
	{
	}

	[Token(Token = "0x600EA72")]
	[Address(RVA = "0x1634208", Offset = "0x1634208", VA = "0x1634208")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EA73")]
	[Address(RVA = "0x16342AC", Offset = "0x16342AC", VA = "0x16342AC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EA74")]
	[Address(RVA = "0x16348D4", Offset = "0x16348D4", VA = "0x16348D4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EA75")]
	[Address(RVA = "0x1634B40", Offset = "0x1634B40", VA = "0x1634B40")]
	private void OnBtnLeaderboardClick()
	{
	}

	[Token(Token = "0x600EA76")]
	[Address(RVA = "0x1634C98", Offset = "0x1634C98", VA = "0x1634C98")]
	private void OnTDMPhaseChange(object[] data)
	{
	}

	[Token(Token = "0x600EA77")]
	[Address(RVA = "0x1634DFC", Offset = "0x1634DFC", VA = "0x1634DFC")]
	private void OnPhaseTimeChange(object[] data)
	{
	}

	[Token(Token = "0x600EA78")]
	[Address(RVA = "0x1634E80", Offset = "0x1634E80", VA = "0x1634E80")]
	private void Update()
	{
	}

	[Token(Token = "0x600EA79")]
	[Address(RVA = "0x163508C", Offset = "0x163508C", VA = "0x163508C")]
	private void OnTeamScoreChange(object[] data)
	{
	}

	[Token(Token = "0x600EA7A")]
	[Address(RVA = "0x1635BE8", Offset = "0x1635BE8", VA = "0x1635BE8")]
	private void OnTargetScoreChange(object[] data)
	{
	}

	[Token(Token = "0x600EA7B")]
	[Address(RVA = "0x16351B4", Offset = "0x16351B4", VA = "0x16351B4")]
	private void UpdateTeamScore(int teamIndex, int score)
	{
	}

	[Token(Token = "0x600EA7C")]
	[Address(RVA = "0x1635D28", Offset = "0x1635D28", VA = "0x1635D28")]
	private void OnADSBonusTeamScoreStart(object[] data)
	{
	}

	[Token(Token = "0x600EA7D")]
	[Address(RVA = "0x1635FBC", Offset = "0x1635FBC", VA = "0x1635FBC")]
	private void _003CUpdateTeamScore_003Em__0()
	{
	}

	[Token(Token = "0x600EA7E")]
	[Address(RVA = "0x1636088", Offset = "0x1636088", VA = "0x1636088")]
	private void _003CUpdateTeamScore_003Em__1()
	{
	}

	[Token(Token = "0x600EA7F")]
	[Address(RVA = "0x1636154", Offset = "0x1636154", VA = "0x1636154")]
	private void _003CUpdateTeamScore_003Em__2()
	{
	}

	[Token(Token = "0x600EA80")]
	[Address(RVA = "0x1636220", Offset = "0x1636220", VA = "0x1636220")]
	private void _003CUpdateTeamScore_003Em__3()
	{
	}

	[Token(Token = "0x600EA81")]
	[Address(RVA = "0x16362EC", Offset = "0x16362EC", VA = "0x16362EC")]
	private void _003CUpdateTeamScore_003Em__4()
	{
	}

	[Token(Token = "0x600EA82")]
	[Address(RVA = "0x16363B8", Offset = "0x16363B8", VA = "0x16363B8")]
	private void _003CUpdateTeamScore_003Em__5()
	{
	}

	[Token(Token = "0x600EA83")]
	[Address(RVA = "0x1636484", Offset = "0x1636484", VA = "0x1636484")]
	private void _003COnADSBonusTeamScoreStart_003Em__6()
	{
	}

	[Token(Token = "0x600EA84")]
	[Address(RVA = "0x16364FC", Offset = "0x16364FC", VA = "0x16364FC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EA85")]
	[Address(RVA = "0x1636504", Offset = "0x1636504", VA = "0x1636504")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
