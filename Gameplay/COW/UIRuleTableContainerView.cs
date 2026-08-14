using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003986")]
public class UIRuleTableContainerView : UIBaseView
{
	[Token(Token = "0x401817D")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget Self;

	[Token(Token = "0x401817E")]
	[FieldOffset(Offset = "0x18")]
	public UITable CContainer;

	[Token(Token = "0x401817F")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget ContainerTitle;

	[Token(Token = "0x4018180")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Label;

	[Token(Token = "0x4018181")]
	[FieldOffset(Offset = "0x24")]
	public UILabel SubLabel;

	[Token(Token = "0x4018182")]
	[FieldOffset(Offset = "0x28")]
	public UIWidget TitlelessSpace;

	[Token(Token = "0x4018183")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite BG;

	[Token(Token = "0x6017039")]
	[Address(RVA = "0x1424B34", Offset = "0x1424B34", VA = "0x1424B34")]
	public UIRuleTableContainerView()
	{
	}

	[Token(Token = "0x601703A")]
	[Address(RVA = "0x1424B3C", Offset = "0x1424B3C", VA = "0x1424B3C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601703B")]
	[Address(RVA = "0x1424F24", Offset = "0x1424F24", VA = "0x1424F24")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
