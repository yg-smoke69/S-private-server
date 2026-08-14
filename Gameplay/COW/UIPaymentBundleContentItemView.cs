using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038E1")]
public class UIPaymentBundleContentItemView : UIBaseView
{
	[Token(Token = "0x401799A")]
	[FieldOffset(Offset = "0x14")]
	public BaseItemView ItemView;

	[Token(Token = "0x401799B")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ClickButton;

	[Token(Token = "0x401799C")]
	[FieldOffset(Offset = "0x1C")]
	public UIDragScrollView DragScrollView;

	[Token(Token = "0x401799D")]
	[FieldOffset(Offset = "0x20")]
	public UISprite QualityBG;

	[Token(Token = "0x401799E")]
	[FieldOffset(Offset = "0x24")]
	public UISprite IconSprite;

	[Token(Token = "0x401799F")]
	[FieldOffset(Offset = "0x28")]
	public UILabel NameLabel;

	[Token(Token = "0x40179A0")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel AmountLabel;

	[Token(Token = "0x40179A1")]
	[FieldOffset(Offset = "0x30")]
	public UISprite Quality;

	[Token(Token = "0x40179A2")]
	[FieldOffset(Offset = "0x34")]
	public UISprite SpriteQualityPlus;

	[Token(Token = "0x40179A3")]
	[FieldOffset(Offset = "0x38")]
	public UISprite SpriteOrangeQualityPlus;

	[Token(Token = "0x6016E4C")]
	[Address(RVA = "0x286A930", Offset = "0x286A930", VA = "0x286A930")]
	public UIPaymentBundleContentItemView()
	{
	}

	[Token(Token = "0x6016E4D")]
	[Address(RVA = "0x286A938", Offset = "0x286A938", VA = "0x286A938", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E4E")]
	[Address(RVA = "0x286AE40", Offset = "0x286AE40", VA = "0x286AE40")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
