using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200339E")]
public class UIAccountPopupWindowView : UIBaseView
{
	[Token(Token = "0x4013B1C")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnClose;

	[Token(Token = "0x4013B1D")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TitleLabel;

	[Token(Token = "0x4013B1E")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel RegionLabel;

	[Token(Token = "0x4013B1F")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelIdentifier;

	[Token(Token = "0x4013B20")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelPassword;

	[Token(Token = "0x4013B21")]
	[FieldOffset(Offset = "0x28")]
	public UIInput InputPassword;

	[Token(Token = "0x4013B22")]
	[FieldOffset(Offset = "0x2C")]
	public UIInput InputIdentifier;

	[Token(Token = "0x4013B23")]
	[FieldOffset(Offset = "0x30")]
	public UILabel MessageLabel;

	[Token(Token = "0x4013B24")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnLeft;

	[Token(Token = "0x4013B25")]
	[FieldOffset(Offset = "0x38")]
	public UILabel LeftLabel;

	[Token(Token = "0x4013B26")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton BtnRight;

	[Token(Token = "0x4013B27")]
	[FieldOffset(Offset = "0x40")]
	public UILabel RightLabel;

	[Token(Token = "0x4013B28")]
	[FieldOffset(Offset = "0x44")]
	public UIToggle PasswardToggle;

	[Token(Token = "0x6015E90")]
	[Address(RVA = "0x2A0032C", Offset = "0x2A0032C", VA = "0x2A0032C")]
	public UIAccountPopupWindowView()
	{
	}

	[Token(Token = "0x6015E91")]
	[Address(RVA = "0x2A00334", Offset = "0x2A00334", VA = "0x2A00334", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E92")]
	[Address(RVA = "0x2A0095C", Offset = "0x2A0095C", VA = "0x2A0095C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
