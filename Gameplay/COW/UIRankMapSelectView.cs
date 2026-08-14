using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003945")]
public class UIRankMapSelectView : UIBaseView
{
	[Token(Token = "0x4017F74")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel UIRankMapSelect;

	[Token(Token = "0x4017F75")]
	[FieldOffset(Offset = "0x18")]
	public UIToggleButton ModeBtn;

	[Token(Token = "0x4017F76")]
	[FieldOffset(Offset = "0x1C")]
	public UIEasyList MapList;

	[Token(Token = "0x4017F77")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Bottom;

	[Token(Token = "0x4017F78")]
	[FieldOffset(Offset = "0x24")]
	public UILabel MapInfos;

	[Token(Token = "0x4017F79")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ExtraPoint;

	[Token(Token = "0x4017F7A")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel RPLabel;

	[Token(Token = "0x4017F7B")]
	[FieldOffset(Offset = "0x30")]
	public UIButton ConfirmButton;

	[Token(Token = "0x6016F76")]
	[Address(RVA = "0x1ACF5EC", Offset = "0x1ACF5EC", VA = "0x1ACF5EC")]
	public UIRankMapSelectView()
	{
	}

	[Token(Token = "0x6016F77")]
	[Address(RVA = "0x1ACF5F4", Offset = "0x1ACF5F4", VA = "0x1ACF5F4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F78")]
	[Address(RVA = "0x1ACFA24", Offset = "0x1ACFA24", VA = "0x1ACFA24")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
