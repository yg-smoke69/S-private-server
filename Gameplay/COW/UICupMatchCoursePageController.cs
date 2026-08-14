using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002067")]
public class UICupMatchCoursePageController : UIBaseController
{
	[Token(Token = "0x400CB2E")]
	[FieldOffset(Offset = "0x28")]
	private UICupMatchCoursePageView m_View;

	[Token(Token = "0x400CB2F")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelCupMatch m_Model;

	[Token(Token = "0x400CB30")]
	[FieldOffset(Offset = "0x30")]
	private int m_CupMatchKey;

	[Token(Token = "0x400CB31")]
	[FieldOffset(Offset = "0x34")]
	private UICupMatchRewardBoxController m_CourseRewardBoxCtrl;

	[Token(Token = "0x400CB32")]
	[FieldOffset(Offset = "0x38")]
	private UICupMatchRewardBoxController m_ChallengeRewardBoxCtrl;

	[Token(Token = "0x400CB33")]
	[FieldOffset(Offset = "0x3C")]
	private UICupMatchCourseController m_CourseCtrl;

	[Token(Token = "0x600A600")]
	[Address(RVA = "0x274BEF4", Offset = "0x274BEF4", VA = "0x274BEF4")]
	public UICupMatchCoursePageController()
	{
	}

	[Token(Token = "0x600A601")]
	[Address(RVA = "0x274BF78", Offset = "0x274BF78", VA = "0x274BF78")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A602")]
	[Address(RVA = "0x274C020", Offset = "0x274C020", VA = "0x274C020", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A603")]
	[Address(RVA = "0x2741BE8", Offset = "0x2741BE8", VA = "0x2741BE8")]
	public void SetViewData(int cupMatchKey)
	{
	}

	[Token(Token = "0x600A604")]
	[Address(RVA = "0x274C3BC", Offset = "0x274C3BC", VA = "0x274C3BC")]
	private void ShowChallengeInfo()
	{
	}

	[Token(Token = "0x600A605")]
	[Address(RVA = "0x274C490", Offset = "0x274C490", VA = "0x274C490")]
	private void SetChallengeInfoGOSActive(bool show)
	{
	}

	[Token(Token = "0x600A606")]
	[Address(RVA = "0x274C740", Offset = "0x274C740", VA = "0x274C740")]
	private void ShowCourseInfo()
	{
	}

	[Token(Token = "0x600A607")]
	[Address(RVA = "0x274C630", Offset = "0x274C630", VA = "0x274C630")]
	private void SetCourseInfoGoActive(bool show)
	{
	}

	[Token(Token = "0x600A608")]
	[Address(RVA = "0x2741DD4", Offset = "0x2741DD4", VA = "0x2741DD4")]
	public void RefreshRewardBox()
	{
	}

	[Token(Token = "0x600A609")]
	[Address(RVA = "0x2741C48", Offset = "0x2741C48", VA = "0x2741C48")]
	public void RefreshCourse()
	{
	}

	[Token(Token = "0x600A60A")]
	[Address(RVA = "0x274C8B4", Offset = "0x274C8B4", VA = "0x274C8B4")]
	private void OnGotoChallengeBtnClick()
	{
	}

	[Token(Token = "0x600A60B")]
	[Address(RVA = "0x274C9A4", Offset = "0x274C9A4", VA = "0x274C9A4")]
	private void OnShowCourseBtnClick()
	{
	}

	[Token(Token = "0x600A60C")]
	[Address(RVA = "0x274732C", Offset = "0x274732C", VA = "0x274732C")]
	public void ShowCoursePage()
	{
	}

	[Token(Token = "0x600A60D")]
	[Address(RVA = "0x274CA94", Offset = "0x274CA94", VA = "0x274CA94")]
	private void OnCourseShowAllRewardBtnClick()
	{
	}

	[Token(Token = "0x600A60E")]
	[Address(RVA = "0x274CC04", Offset = "0x274CC04", VA = "0x274CC04")]
	private void ShowAllReward()
	{
	}

	[Token(Token = "0x600A60F")]
	[Address(RVA = "0x2746508", Offset = "0x2746508", VA = "0x2746508")]
	public void SetShareBtnState(bool show)
	{
	}

	[Token(Token = "0x600A610")]
	[Address(RVA = "0x274CD80", Offset = "0x274CD80", VA = "0x274CD80")]
	private void OnTeamTireClick()
	{
	}

	[Token(Token = "0x600A611")]
	[Address(RVA = "0x274CFC8", Offset = "0x274CFC8", VA = "0x274CFC8")]
	private void OnShareBtnClick()
	{
	}

	[Token(Token = "0x600A612")]
	[Address(RVA = "0x274D120", Offset = "0x274D120", VA = "0x274D120", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x600A613")]
	[Address(RVA = "0x274D1C4", Offset = "0x274D1C4", VA = "0x274D1C4", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x600A614")]
	[Address(RVA = "0x274D268", Offset = "0x274D268", VA = "0x274D268")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A615")]
	[Address(RVA = "0x274D270", Offset = "0x274D270", VA = "0x274D270")]
	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x600A616")]
	[Address(RVA = "0x274D278", Offset = "0x274D278", VA = "0x274D278")]
	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
