using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A27")]
public class UIUGCDebuggerConsoleView : UIBaseView
{
	[Token(Token = "0x40188E0")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView ScrollView;

	[Token(Token = "0x40188E1")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList Grid;

	[Token(Token = "0x40188E2")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnScrollToEnd;

	[Token(Token = "0x40188E3")]
	[FieldOffset(Offset = "0x20")]
	public UIToggle ToggleInfo;

	[Token(Token = "0x40188E4")]
	[FieldOffset(Offset = "0x24")]
	public UIToggle ToggleWarnning;

	[Token(Token = "0x40188E5")]
	[FieldOffset(Offset = "0x28")]
	public UIToggle ToggleError;

	[Token(Token = "0x40188E6")]
	[FieldOffset(Offset = "0x2C")]
	public UIToggle ToggleSystem;

	[Token(Token = "0x40188E7")]
	[FieldOffset(Offset = "0x30")]
	public UIButton CloseBtn;

	[Token(Token = "0x40188E8")]
	[FieldOffset(Offset = "0x34")]
	public GameObject notify_down;

	[Token(Token = "0x40188E9")]
	[FieldOffset(Offset = "0x38")]
	public UIButton TestAddLogBtn;

	[Token(Token = "0x40188EA")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject LabelIfEmpty;

	[Token(Token = "0x40188EB")]
	[FieldOffset(Offset = "0x40")]
	public GameObject ToggleList;

	[Token(Token = "0x601721B")]
	[Address(RVA = "0x2B91D18", Offset = "0x2B91D18", VA = "0x2B91D18")]
	public UIUGCDebuggerConsoleView()
	{
	}

	[Token(Token = "0x601721C")]
	[Address(RVA = "0x2B91D20", Offset = "0x2B91D20", VA = "0x2B91D20", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601721D")]
	[Address(RVA = "0x2B922C4", Offset = "0x2B922C4", VA = "0x2B922C4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
