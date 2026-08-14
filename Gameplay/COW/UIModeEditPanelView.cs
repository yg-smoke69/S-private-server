using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038B1")]
public class UIModeEditPanelView : UIBaseView
{
	[Token(Token = "0x4017723")]
	[FieldOffset(Offset = "0x14")]
	public UIButton CloseBtn;

	[Token(Token = "0x4017724")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelTitle;

	[Token(Token = "0x4017725")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView ScrollViewPanel;

	[Token(Token = "0x4017726")]
	[FieldOffset(Offset = "0x20")]
	public UIEasyList TabContainer;

	[Token(Token = "0x4017727")]
	[FieldOffset(Offset = "0x24")]
	public UIPanel CContainer;

	[Token(Token = "0x4017728")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnReset;

	[Token(Token = "0x4017729")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnOK;

	[Token(Token = "0x401772A")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BtnBlockEdit;

	[Token(Token = "0x401772B")]
	[FieldOffset(Offset = "0x34")]
	public UIButton HelpBtn;

	[Token(Token = "0x401772C")]
	[FieldOffset(Offset = "0x38")]
	public GameObject EditBtns;

	[Token(Token = "0x401772D")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton SwitchModeBtn;

	[Token(Token = "0x401772E")]
	[FieldOffset(Offset = "0x40")]
	public UIPanel BgTexture;

	[Token(Token = "0x6016DBE")]
	[Address(RVA = "0x13152D4", Offset = "0x13152D4", VA = "0x13152D4")]
	public UIModeEditPanelView()
	{
	}

	[Token(Token = "0x6016DBF")]
	[Address(RVA = "0x13152DC", Offset = "0x13152DC", VA = "0x13152DC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016DC0")]
	[Address(RVA = "0x1315898", Offset = "0x1315898", VA = "0x1315898")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
