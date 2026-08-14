using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A1F")]
public class UIUGCCommentView : UIBaseView
{
	[Token(Token = "0x40188A8")]
	[FieldOffset(Offset = "0x14")]
	public UILabel SelectedTxt;

	[Token(Token = "0x40188A9")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid SelectedGrid;

	[Token(Token = "0x40188AA")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Tips;

	[Token(Token = "0x40188AB")]
	[FieldOffset(Offset = "0x20")]
	public UIToggleButton PositionCommentBtn;

	[Token(Token = "0x40188AC")]
	[FieldOffset(Offset = "0x24")]
	public UIToggleButton NegativeCommentBtn;

	[Token(Token = "0x40188AD")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid ToBeSelectedGrid;

	[Token(Token = "0x40188AE")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnConfirm;

	[Token(Token = "0x6017203")]
	[Address(RVA = "0x2B8600C", Offset = "0x2B8600C", VA = "0x2B8600C")]
	public UIUGCCommentView()
	{
	}

	[Token(Token = "0x6017204")]
	[Address(RVA = "0x2B86014", Offset = "0x2B86014", VA = "0x2B86014", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017205")]
	[Address(RVA = "0x2B863F0", Offset = "0x2B863F0", VA = "0x2B863F0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
