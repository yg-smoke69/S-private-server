using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001F49")]
public class UIGuideNode
{
	[Token(Token = "0x400C4A9")]
	[FieldOffset(Offset = "0x8")]
	private float m_Lapsed;

	[Token(Token = "0x400C4AA")]
	[FieldOffset(Offset = "0xC")]
	private readonly float m_Duration;

	[Token(Token = "0x400C4AB")]
	[FieldOffset(Offset = "0x10")]
	private bool m_ForceFinished;

	[Token(Token = "0x400C4AC")]
	[FieldOffset(Offset = "0x14")]
	private readonly OpenGuideControllerDelegate m_OpenGuideControl;

	[Token(Token = "0x400C4AD")]
	[FieldOffset(Offset = "0x18")]
	private readonly CommonGuideSetting m_CommonGuideSetting;

	[Token(Token = "0x400C4AE")]
	[FieldOffset(Offset = "0x1C")]
	private readonly UIButton m_BindButton;

	[Token(Token = "0x400C4AF")]
	[FieldOffset(Offset = "0x20")]
	private readonly UIWidget m_BindWidget;

	[Token(Token = "0x400C4B0")]
	[FieldOffset(Offset = "0x24")]
	private readonly Side m_AnchorSide;

	[Token(Token = "0x400C4B1")]
	[FieldOffset(Offset = "0x28")]
	private readonly bool m_NeedFollowTarget;

	[Token(Token = "0x6009A94")]
	[Address(RVA = "0x2027180", Offset = "0x2027180", VA = "0x2027180")]
	public UIGuideNode(float duration, UIButton button, UIWidget widget, Side anchorSide, CommonGuideSetting commonGuideSetting, OpenGuideControllerDelegate openGuideControl, bool needFollowTarget = false)
	{
	}

	[Token(Token = "0x6009A95")]
	[Address(RVA = "0x20271CC", Offset = "0x20271CC", VA = "0x20271CC", Slot = "4")]
	public virtual void OnEnter()
	{
	}

	[Token(Token = "0x6009A96")]
	[Address(RVA = "0x2027378", Offset = "0x2027378", VA = "0x2027378")]
	public void ForceFinish()
	{
	}

	[Token(Token = "0x6009A97")]
	[Address(RVA = "0x20273D4", Offset = "0x20273D4", VA = "0x20273D4", Slot = "5")]
	public virtual void OnExit()
	{
	}

	[Token(Token = "0x6009A98")]
	[Address(RVA = "0x2027428", Offset = "0x2027428", VA = "0x2027428", Slot = "6")]
	public virtual bool Update()
	{
		return default(bool);
	}
}
