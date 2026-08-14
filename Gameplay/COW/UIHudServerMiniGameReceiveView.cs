using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003740")]
public class UIHudServerMiniGameReceiveView : UIBaseView
{
	[Token(Token = "0x4016591")]
	[FieldOffset(Offset = "0x14")]
	public UILabel IgnoreDesc;

	[Token(Token = "0x4016592")]
	[FieldOffset(Offset = "0x18")]
	public UIButton IgnoreToggle;

	[Token(Token = "0x4016593")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject IgnoreCheck;

	[Token(Token = "0x4016594")]
	[FieldOffset(Offset = "0x20")]
	public UILabel InviteDesc;

	[Token(Token = "0x4016595")]
	[FieldOffset(Offset = "0x24")]
	public UILabel UserNameLabel;

	[Token(Token = "0x4016596")]
	[FieldOffset(Offset = "0x28")]
	public UIButton AgreeBtn;

	[Token(Token = "0x4016597")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton DisagreeBtn;

	[Token(Token = "0x4016598")]
	[FieldOffset(Offset = "0x30")]
	public UILabel DisagreeTimeLabel;

	[Token(Token = "0x601696B")]
	[Address(RVA = "0x16B7FDC", Offset = "0x16B7FDC", VA = "0x16B7FDC")]
	public UIHudServerMiniGameReceiveView()
	{
	}

	[Token(Token = "0x601696C")]
	[Address(RVA = "0x16B7FE4", Offset = "0x16B7FE4", VA = "0x16B7FE4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601696D")]
	[Address(RVA = "0x16B8420", Offset = "0x16B8420", VA = "0x16B8420")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
