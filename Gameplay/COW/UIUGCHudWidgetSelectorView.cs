using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A3D")]
public class UIUGCHudWidgetSelectorView : UIBaseView
{
	[Token(Token = "0x401897A")]
	[FieldOffset(Offset = "0x14")]
	public GameObject TopLeft;

	[Token(Token = "0x401897B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject TopRight;

	[Token(Token = "0x401897C")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Bottom;

	[Token(Token = "0x401897D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject BottomRight;

	[Token(Token = "0x401897E")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Top;

	[Token(Token = "0x401897F")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Right;

	[Token(Token = "0x4018980")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Left;

	[Token(Token = "0x4018981")]
	[FieldOffset(Offset = "0x30")]
	public UIWidget Frame;

	[Token(Token = "0x601725D")]
	[Address(RVA = "0x2779CEC", Offset = "0x2779CEC", VA = "0x2779CEC")]
	public UIUGCHudWidgetSelectorView()
	{
	}

	[Token(Token = "0x601725E")]
	[Address(RVA = "0x2779CF4", Offset = "0x2779CF4", VA = "0x2779CF4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601725F")]
	[Address(RVA = "0x277A0E8", Offset = "0x277A0E8", VA = "0x277A0E8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
