using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200370A")]
public class UIHudReportMainReasonToggleView : UIBaseView
{
	[Token(Token = "0x40163A5")]
	[FieldOffset(Offset = "0x14")]
	public UIToggleButton Toggle;

	[Token(Token = "0x40163A6")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Label;

	[Token(Token = "0x40163A7")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite MainBg;

	[Token(Token = "0x40163A8")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SubContainer;

	[Token(Token = "0x40163A9")]
	[FieldOffset(Offset = "0x24")]
	public UISprite SubBg;

	[Token(Token = "0x40163AA")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid SubGrid;

	[Token(Token = "0x40163AB")]
	[FieldOffset(Offset = "0x2C")]
	public UIWidget UIHudReportMainReasonToggle;

	[Token(Token = "0x40163AC")]
	[FieldOffset(Offset = "0x30")]
	public UILabel labelDesc;

	[Token(Token = "0x60168C9")]
	[Address(RVA = "0x13EC614", Offset = "0x13EC614", VA = "0x13EC614")]
	public UIHudReportMainReasonToggleView()
	{
	}

	[Token(Token = "0x60168CA")]
	[Address(RVA = "0x13EC61C", Offset = "0x13EC61C", VA = "0x13EC61C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60168CB")]
	[Address(RVA = "0x13ECA58", Offset = "0x13ECA58", VA = "0x13ECA58")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
