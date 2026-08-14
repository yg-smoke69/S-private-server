using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E55")]
public class AutoTaskCSTutoRecommendPop : AutoPopupTask
{
	[Token(Token = "0x400BF3B")]
	[FieldOffset(Offset = "0x8")]
	private UITutorialCSRecommendPopupController m_TutoCsCtrl;

	[Token(Token = "0x60091C1")]
	[Address(RVA = "0x10EBF5C", Offset = "0x10EBF5C", VA = "0x10EBF5C")]
	public AutoTaskCSTutoRecommendPop()
	{
	}

	[Token(Token = "0x60091C2")]
	[Address(RVA = "0x10EBF64", Offset = "0x10EBF64", VA = "0x10EBF64", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x60091C3")]
	[Address(RVA = "0x10ECB9C", Offset = "0x10ECB9C", VA = "0x10ECB9C")]
	private bool GetNewPlanTutorial()
	{
		return default(bool);
	}

	[Token(Token = "0x60091C4")]
	[Address(RVA = "0x10EC858", Offset = "0x10EC858", VA = "0x10EC858")]
	private bool IsSkipSelectGuide()
	{
		return default(bool);
	}

	[Token(Token = "0x60091C5")]
	[Address(RVA = "0x10ED120", Offset = "0x10ED120", VA = "0x10ED120", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x60091C6")]
	[Address(RVA = "0x10ED220", Offset = "0x10ED220", VA = "0x10ED220", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}
}
