using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003499")]
public class UICupMatchMemberReviewPopupView : UIBaseView
{
	[Token(Token = "0x401483B")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Tabs;

	[Token(Token = "0x401483C")]
	[FieldOffset(Offset = "0x18")]
	public UITable Btns;

	[Token(Token = "0x401483D")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggleButton BtnApply;

	[Token(Token = "0x401483E")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ApplyRedPoint;

	[Token(Token = "0x401483F")]
	[FieldOffset(Offset = "0x24")]
	public UIToggleButton BtnInvite;

	[Token(Token = "0x4014840")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelUnSelect;

	[Token(Token = "0x4014841")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject InviteRedPoint;

	[Token(Token = "0x4014842")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Apply;

	[Token(Token = "0x4014843")]
	[FieldOffset(Offset = "0x34")]
	public UIEasyList ApplyEasyList;

	[Token(Token = "0x4014844")]
	[FieldOffset(Offset = "0x38")]
	public UIButton RejectAll;

	[Token(Token = "0x4014845")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject ApplyNoData;

	[Token(Token = "0x4014846")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Invite;

	[Token(Token = "0x4014847")]
	[FieldOffset(Offset = "0x44")]
	public UIEasyList InviteEasyList;

	[Token(Token = "0x4014848")]
	[FieldOffset(Offset = "0x48")]
	public UIButton RejectAllInvite;

	[Token(Token = "0x4014849")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject InviteNoData;

	[Token(Token = "0x401484A")]
	[FieldOffset(Offset = "0x50")]
	public UIButton Refresh;

	[Token(Token = "0x401484B")]
	[FieldOffset(Offset = "0x54")]
	public GameObject RefreshIcon;

	[Token(Token = "0x401484C")]
	[FieldOffset(Offset = "0x58")]
	public UICountDownLabel CountDownLabel;

	[Token(Token = "0x601617F")]
	[Address(RVA = "0x2AA8B10", Offset = "0x2AA8B10", VA = "0x2AA8B10")]
	public UICupMatchMemberReviewPopupView()
	{
	}

	[Token(Token = "0x6016180")]
	[Address(RVA = "0x2AA8B18", Offset = "0x2AA8B18", VA = "0x2AA8B18", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016181")]
	[Address(RVA = "0x2AA92C0", Offset = "0x2AA92C0", VA = "0x2AA92C0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
