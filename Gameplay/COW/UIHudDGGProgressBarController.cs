using System.Text;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200272D")]
public class UIHudDGGProgressBarController : UIBaseController
{
	[Token(Token = "0x400F1BB")]
	[FieldOffset(Offset = "0x28")]
	private UIHudDGGProgressBarView m_View;

	[Token(Token = "0x400F1BC")]
	[FieldOffset(Offset = "0x2C")]
	private int m_WinScore;

	[Token(Token = "0x400F1BD")]
	[FieldOffset(Offset = "0x30")]
	private int m_WinTime;

	[Token(Token = "0x400F1BE")]
	[FieldOffset(Offset = "0x34")]
	private int m_MatchEndTime;

	[Token(Token = "0x400F1BF")]
	[FieldOffset(Offset = "0x38")]
	private int m_CurLeftTime;

	[Token(Token = "0x400F1C0")]
	[FieldOffset(Offset = "0x3C")]
	private StringBuilder m_Timer;

	[Token(Token = "0x400F1C1")]
	[FieldOffset(Offset = "0x40")]
	private int m_MyScore;

	[Token(Token = "0x400F1C2")]
	[FieldOffset(Offset = "0x44")]
	private int m_LeadingTeamID;

	[Token(Token = "0x400F1C3")]
	[FieldOffset(Offset = "0x48")]
	private int m_LeadingScore;

	[Token(Token = "0x400F1C4")]
	[FieldOffset(Offset = "0x4C")]
	private int m_2ndScore;

	[Token(Token = "0x400F1C5")]
	[FieldOffset(Offset = "0x50")]
	private int m_1stDepth;

	[Token(Token = "0x400F1C6")]
	[FieldOffset(Offset = "0x54")]
	private int m_2ndDepth;

	[Token(Token = "0x600EE76")]
	[Address(RVA = "0x1CCA7AC", Offset = "0x1CCA7AC", VA = "0x1CCA7AC")]
	public UIHudDGGProgressBarController()
	{
	}

	[Token(Token = "0x600EE77")]
	[Address(RVA = "0x1CCA84C", Offset = "0x1CCA84C", VA = "0x1CCA84C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EE78")]
	[Address(RVA = "0x1CCA8F0", Offset = "0x1CCA8F0", VA = "0x1CCA8F0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EE79")]
	[Address(RVA = "0x1CCB754", Offset = "0x1CCB754", VA = "0x1CCB754", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EE7A")]
	[Address(RVA = "0x1CCBC30", Offset = "0x1CCBC30", VA = "0x1CCBC30")]
	private void OnScoreChange(object[] data)
	{
	}

	[Token(Token = "0x600EE7B")]
	[Address(RVA = "0x1CCC038", Offset = "0x1CCC038", VA = "0x1CCC038")]
	private void OnLeadingTeamIDChange(object[] data)
	{
	}

	[Token(Token = "0x600EE7C")]
	[Address(RVA = "0x1CCC128", Offset = "0x1CCC128", VA = "0x1CCC128")]
	private void OnLeadingScoreChange(object[] data)
	{
	}

	[Token(Token = "0x600EE7D")]
	[Address(RVA = "0x1CCC218", Offset = "0x1CCC218", VA = "0x1CCC218")]
	private void On2ndTeamIDChange(object[] data)
	{
	}

	[Token(Token = "0x600EE7E")]
	[Address(RVA = "0x1CCC280", Offset = "0x1CCC280", VA = "0x1CCC280")]
	private void On2ndScoreChange(object[] data)
	{
	}

	[Token(Token = "0x600EE7F")]
	[Address(RVA = "0x1CCC370", Offset = "0x1CCC370", VA = "0x1CCC370")]
	public void OnFirstSecondInfoChange(int firstTeamdID, int firstScore, int secondTeamID, int secondScore)
	{
	}

	[Token(Token = "0x600EE80")]
	[Address(RVA = "0x1CCC408", Offset = "0x1CCC408", VA = "0x1CCC408")]
	public void OnWinScoreChange(object[] data)
	{
	}

	[Token(Token = "0x600EE81")]
	[Address(RVA = "0x1CCC4F0", Offset = "0x1CCC4F0", VA = "0x1CCC4F0")]
	private void OnWinTimeChange(object[] data)
	{
	}

	[Token(Token = "0x600EE82")]
	[Address(RVA = "0x1CCC5D8", Offset = "0x1CCC5D8", VA = "0x1CCC5D8")]
	private void OnShowScoreTutorial(object[] data)
	{
	}

	[Token(Token = "0x600EE83")]
	[Address(RVA = "0x1CCC768", Offset = "0x1CCC768", VA = "0x1CCC768")]
	public void OnMatchEndTimeChange(object[] data)
	{
	}

	[Token(Token = "0x600EE84")]
	[Address(RVA = "0x1CCC850", Offset = "0x1CCC850", VA = "0x1CCC850")]
	private void OnStartMatchEndShow(object[] data)
	{
	}

	[Token(Token = "0x600EE85")]
	[Address(RVA = "0x1CCBEA4", Offset = "0x1CCBEA4", VA = "0x1CCBEA4")]
	private void UpdateBar()
	{
	}

	[Token(Token = "0x600EE86")]
	[Address(RVA = "0x1CCAEE4", Offset = "0x1CCAEE4", VA = "0x1CCAEE4")]
	private void UpdateBarDetail(bool isLocalLeading)
	{
	}

	[Token(Token = "0x600EE87")]
	[Address(RVA = "0x1CCC8BC", Offset = "0x1CCC8BC", VA = "0x1CCC8BC")]
	private void Update()
	{
	}

	[Token(Token = "0x600EE88")]
	[Address(RVA = "0x1CCCC78", Offset = "0x1CCCC78", VA = "0x1CCCC78")]
	private void _003COnShowScoreTutorial_003Em__0()
	{
	}

	[Token(Token = "0x600EE89")]
	[Address(RVA = "0x1CCCD60", Offset = "0x1CCCD60", VA = "0x1CCCD60")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EE8A")]
	[Address(RVA = "0x1CCCD68", Offset = "0x1CCCD68", VA = "0x1CCCD68")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
