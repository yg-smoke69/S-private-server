using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003977")]
public class UIRoomToggleBtnTemplateView : UIBaseView
{
	[Token(Token = "0x4018118")]
	[FieldOffset(Offset = "0x14")]
	public UIToggleButtonGroup ToggleBtnGo;

	[Token(Token = "0x4018119")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ToggleBtnLabel;

	[Token(Token = "0x401811A")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggleButton EnabledToggle;

	[Token(Token = "0x401811B")]
	[FieldOffset(Offset = "0x20")]
	public UISprite EnabledLabelCheckmark;

	[Token(Token = "0x401811C")]
	[FieldOffset(Offset = "0x24")]
	public UILabel EnabledLabel;

	[Token(Token = "0x401811D")]
	[FieldOffset(Offset = "0x28")]
	public UIToggleButton DisabledToggle;

	[Token(Token = "0x401811E")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite DisabledLabelCheckmark;

	[Token(Token = "0x401811F")]
	[FieldOffset(Offset = "0x30")]
	public UILabel DisabledLabel;

	[Token(Token = "0x4018120")]
	[FieldOffset(Offset = "0x34")]
	public UIButton HelpeBtn;

	[Token(Token = "0x601700C")]
	[Address(RVA = "0x2BF02E4", Offset = "0x2BF02E4", VA = "0x2BF02E4")]
	public UIRoomToggleBtnTemplateView()
	{
	}

	[Token(Token = "0x601700D")]
	[Address(RVA = "0x2BF02EC", Offset = "0x2BF02EC", VA = "0x2BF02EC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601700E")]
	[Address(RVA = "0x2BF0794", Offset = "0x2BF0794", VA = "0x2BF0794")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
