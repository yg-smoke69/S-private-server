using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A30")]
public class UIUGCHudWidgetAttributeCustomAdaptView : UIBaseView
{
	[Token(Token = "0x4018930")]
	[FieldOffset(Offset = "0x14")]
	public UIDropdown HorizontalDropdown;

	[Token(Token = "0x4018931")]
	[FieldOffset(Offset = "0x18")]
	public UIDropdown VerticalDropdown;

	[Token(Token = "0x4018932")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Bottom;

	[Token(Token = "0x4018933")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Default_Bottom;

	[Token(Token = "0x4018934")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Top;

	[Token(Token = "0x4018935")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Default_Top;

	[Token(Token = "0x4018936")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Left;

	[Token(Token = "0x4018937")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Default_Left;

	[Token(Token = "0x4018938")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Right;

	[Token(Token = "0x4018939")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Default_Right;

	[Token(Token = "0x401893A")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Default_Center;

	[Token(Token = "0x401893B")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Both_Center;

	[Token(Token = "0x6017236")]
	[Address(RVA = "0x2FF5ED4", Offset = "0x2FF5ED4", VA = "0x2FF5ED4")]
	public UIUGCHudWidgetAttributeCustomAdaptView()
	{
	}

	[Token(Token = "0x6017237")]
	[Address(RVA = "0x2FF5EDC", Offset = "0x2FF5EDC", VA = "0x2FF5EDC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017238")]
	[Address(RVA = "0x2FF642C", Offset = "0x2FF642C", VA = "0x2FF642C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
