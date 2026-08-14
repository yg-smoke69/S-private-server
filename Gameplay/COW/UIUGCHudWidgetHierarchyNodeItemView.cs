using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A3A")]
public class UIUGCHudWidgetHierarchyNodeItemView : UIBaseView
{
	[Token(Token = "0x401895F")]
	[FieldOffset(Offset = "0x14")]
	public Transform Root;

	[Token(Token = "0x4018960")]
	[FieldOffset(Offset = "0x18")]
	public UIButton Arrow;

	[Token(Token = "0x4018961")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Icon;

	[Token(Token = "0x4018962")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Label;

	[Token(Token = "0x4018963")]
	[FieldOffset(Offset = "0x24")]
	public UIToggleButton ActivedToggle;

	[Token(Token = "0x4018964")]
	[FieldOffset(Offset = "0x28")]
	public UITable Table;

	[Token(Token = "0x6017254")]
	[Address(RVA = "0x3004D4C", Offset = "0x3004D4C", VA = "0x3004D4C")]
	public UIUGCHudWidgetHierarchyNodeItemView()
	{
	}

	[Token(Token = "0x6017255")]
	[Address(RVA = "0x3004D54", Offset = "0x3004D54", VA = "0x3004D54", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017256")]
	[Address(RVA = "0x30050B4", Offset = "0x30050B4", VA = "0x30050B4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
