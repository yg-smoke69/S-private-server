using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003735")]
public class UIHudSceneEditModeSelectConfirmWndView : UIBaseView
{
	[Token(Token = "0x4016507")]
	[FieldOffset(Offset = "0x14")]
	public UIToggleButtonGroup ToggleGroup;

	[Token(Token = "0x4016508")]
	[FieldOffset(Offset = "0x18")]
	public UIToggleButton ModeCSBtn;

	[Token(Token = "0x4016509")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggleButton ModePartyBtn;

	[Token(Token = "0x401650A")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnCancel;

	[Token(Token = "0x401650B")]
	[FieldOffset(Offset = "0x24")]
	public UILabel BtnCancelTxt;

	[Token(Token = "0x401650C")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnApply;

	[Token(Token = "0x401650D")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel BtnApplyTxt;

	[Token(Token = "0x601694A")]
	[Address(RVA = "0x24E38E8", Offset = "0x24E38E8", VA = "0x24E38E8")]
	public UIHudSceneEditModeSelectConfirmWndView()
	{
	}

	[Token(Token = "0x601694B")]
	[Address(RVA = "0x24E38F0", Offset = "0x24E38F0", VA = "0x24E38F0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601694C")]
	[Address(RVA = "0x24E3CD8", Offset = "0x24E3CD8", VA = "0x24E3CD8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
