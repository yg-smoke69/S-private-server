using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A0F")]
public class UITreasureBoxOpenWndView : UIBaseView
{
	[Token(Token = "0x4018832")]
	[FieldOffset(Offset = "0x14")]
	public BaseItemView BaseItemView;

	[Token(Token = "0x4018833")]
	[FieldOffset(Offset = "0x18")]
	public Transform StandardItemContainer;

	[Token(Token = "0x4018834")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel ItemNameLabel;

	[Token(Token = "0x4018835")]
	[FieldOffset(Offset = "0x20")]
	public UIButton OpenOneBtn;

	[Token(Token = "0x4018836")]
	[FieldOffset(Offset = "0x24")]
	public UILabel OpenOneLabel;

	[Token(Token = "0x4018837")]
	[FieldOffset(Offset = "0x28")]
	public UILabel CurrentCnt;

	[Token(Token = "0x4018838")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel MaxCnt;

	[Token(Token = "0x4018839")]
	[FieldOffset(Offset = "0x30")]
	public UIButton PlusBtn;

	[Token(Token = "0x401883A")]
	[FieldOffset(Offset = "0x34")]
	public UISprite PlusSprite1;

	[Token(Token = "0x401883B")]
	[FieldOffset(Offset = "0x38")]
	public UISprite PlusSprite2;

	[Token(Token = "0x401883C")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton MinusBtn;

	[Token(Token = "0x401883D")]
	[FieldOffset(Offset = "0x40")]
	public UISprite MinusSprite;

	[Token(Token = "0x401883E")]
	[FieldOffset(Offset = "0x44")]
	public UISlider Slider;

	[Token(Token = "0x60171D3")]
	[Address(RVA = "0x1C2D6A8", Offset = "0x1C2D6A8", VA = "0x1C2D6A8")]
	public UITreasureBoxOpenWndView()
	{
	}

	[Token(Token = "0x60171D4")]
	[Address(RVA = "0x1C2D6B0", Offset = "0x1C2D6B0", VA = "0x1C2D6B0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171D5")]
	[Address(RVA = "0x1C2DCB0", Offset = "0x1C2DCB0", VA = "0x1C2DCB0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
