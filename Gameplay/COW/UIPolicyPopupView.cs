using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200390F")]
public class UIPolicyPopupView : UIBaseView
{
	[Token(Token = "0x4017BCF")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Title;

	[Token(Token = "0x4017BD0")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Content;

	[Token(Token = "0x4017BD1")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel URLLabel;

	[Token(Token = "0x4017BD2")]
	[FieldOffset(Offset = "0x20")]
	public UIButton URLBtn;

	[Token(Token = "0x4017BD3")]
	[FieldOffset(Offset = "0x24")]
	public UIButton OKBtn;

	[Token(Token = "0x4017BD4")]
	[FieldOffset(Offset = "0x28")]
	public UILabel OKTxt;

	[Token(Token = "0x4017BD5")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton CancelBtn;

	[Token(Token = "0x4017BD6")]
	[FieldOffset(Offset = "0x30")]
	public UILabel CancelTxt;

	[Token(Token = "0x4017BD7")]
	[FieldOffset(Offset = "0x34")]
	public UIToggle Check;

	[Token(Token = "0x4017BD8")]
	[FieldOffset(Offset = "0x38")]
	public UILabel Tips;

	[Token(Token = "0x6016ED6")]
	[Address(RVA = "0x2C55B5C", Offset = "0x2C55B5C", VA = "0x2C55B5C")]
	public UIPolicyPopupView()
	{
	}

	[Token(Token = "0x6016ED7")]
	[Address(RVA = "0x2C55B64", Offset = "0x2C55B64", VA = "0x2C55B64", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016ED8")]
	[Address(RVA = "0x2C5606C", Offset = "0x2C5606C", VA = "0x2C5606C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
