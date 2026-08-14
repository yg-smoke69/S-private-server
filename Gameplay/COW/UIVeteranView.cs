using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A67")]
public class UIVeteranView : UIBaseView
{
	[Token(Token = "0x4018C26")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ContentBG;

	[Token(Token = "0x4018C27")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ContentBGWide;

	[Token(Token = "0x4018C28")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggleButtonGroup TopTabGroup;

	[Token(Token = "0x4018C29")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid Tabs;

	[Token(Token = "0x4018C2A")]
	[FieldOffset(Offset = "0x24")]
	public UIToggleButton TopTabTemplate;

	[Token(Token = "0x4018C2B")]
	[FieldOffset(Offset = "0x28")]
	public GameObject SigninRedDot;

	[Token(Token = "0x4018C2C")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton Close;

	[Token(Token = "0x4018C2D")]
	[FieldOffset(Offset = "0x30")]
	public UICountDownLabel RefreshLabel;

	[Token(Token = "0x60172DB")]
	[Address(RVA = "0x1016A80", Offset = "0x1016A80", VA = "0x1016A80")]
	public UIVeteranView()
	{
	}

	[Token(Token = "0x60172DC")]
	[Address(RVA = "0x1016A88", Offset = "0x1016A88", VA = "0x1016A88", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172DD")]
	[Address(RVA = "0x1016EAC", Offset = "0x1016EAC", VA = "0x1016EAC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
