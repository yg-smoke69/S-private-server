using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20022A9")]
public class UIPopWindowFrameController : MonoBehaviour
{
	[Token(Token = "0x400D8E8")]
	public const string CONTENT_IN_ANIM_START_EVT_NAME = "ContentInAnimStart";

	[Token(Token = "0x400D8E9")]
	[FieldOffset(Offset = "0xC")]
	public UIPanel m_MainPanel;

	[Token(Token = "0x400D8EA")]
	[FieldOffset(Offset = "0x10")]
	public UIButton BtnClose;

	[Token(Token = "0x400D8EB")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LabelTitle;

	[Token(Token = "0x400D8EC")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnRule;

	[Token(Token = "0x400D8ED")]
	[FieldOffset(Offset = "0x1C")]
	private string m_RuleKey;

	[Token(Token = "0x400D8EE")]
	[FieldOffset(Offset = "0x20")]
	private UIPopWindowFrameStyle m_FrameStyle;

	[Token(Token = "0x400D8EF")]
	[FieldOffset(Offset = "0x24")]
	private UIBaseController m_ParentController;

	[Token(Token = "0x600BE93")]
	[Address(RVA = "0x2241B00", Offset = "0x2241B00", VA = "0x2241B00")]
	public UIPopWindowFrameController()
	{
	}

	[Token(Token = "0x600BE94")]
	[Address(RVA = "0x2241B08", Offset = "0x2241B08", VA = "0x2241B08")]
	public void InitFrame(UIBaseController parentController, UIPopWindowFrameStyle frameStyle)
	{
	}

	[Token(Token = "0x600BE95")]
	[Address(RVA = "0x2241F54", Offset = "0x2241F54", VA = "0x2241F54")]
	public void SetFrameDepth(int newDepth)
	{
	}

	[Token(Token = "0x600BE96")]
	[Address(RVA = "0x2241F88", Offset = "0x2241F88", VA = "0x2241F88")]
	public void OnBtnRuleClick()
	{
	}

	[Token(Token = "0x600BE97")]
	[Address(RVA = "0x224220C", Offset = "0x224220C", VA = "0x224220C")]
	public void SetCloseBtnVisble(bool flag)
	{
	}
}
