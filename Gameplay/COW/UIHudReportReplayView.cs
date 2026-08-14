using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200370C")]
public class UIHudReportReplayView : UIBaseView
{
	[Token(Token = "0x40163B3")]
	[FieldOffset(Offset = "0x14")]
	public Transform Status;

	[Token(Token = "0x40163B4")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelName;

	[Token(Token = "0x40163B5")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite BgSelected;

	[Token(Token = "0x40163B6")]
	[FieldOffset(Offset = "0x20")]
	public UIEasyList ReporterList;

	[Token(Token = "0x40163B7")]
	[FieldOffset(Offset = "0x24")]
	public UIButton SwitchButton;

	[Token(Token = "0x40163B8")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelStatus;

	[Token(Token = "0x40163B9")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Dropdown;

	[Token(Token = "0x40163BA")]
	[FieldOffset(Offset = "0x30")]
	public UIButton Pending;

	[Token(Token = "0x40163BB")]
	[FieldOffset(Offset = "0x34")]
	public UIButton Qualified;

	[Token(Token = "0x40163BC")]
	[FieldOffset(Offset = "0x38")]
	public UIButton Violantion;

	[Token(Token = "0x40163BD")]
	[FieldOffset(Offset = "0x3C")]
	public Transform OffenderMenu;

	[Token(Token = "0x60168CF")]
	[Address(RVA = "0x13ECDE0", Offset = "0x13ECDE0", VA = "0x13ECDE0")]
	public UIHudReportReplayView()
	{
	}

	[Token(Token = "0x60168D0")]
	[Address(RVA = "0x13ECDE8", Offset = "0x13ECDE8", VA = "0x13ECDE8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60168D1")]
	[Address(RVA = "0x13ED2F4", Offset = "0x13ED2F4", VA = "0x13ED2F4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
