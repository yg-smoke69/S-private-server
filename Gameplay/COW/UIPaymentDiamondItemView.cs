using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038E7")]
public class UIPaymentDiamondItemView : UIBaseView
{
	[Token(Token = "0x40179FF")]
	[FieldOffset(Offset = "0x14")]
	public GameObject CurrentSprite;

	[Token(Token = "0x4017A00")]
	[FieldOffset(Offset = "0x18")]
	public Transform EffectRoot;

	[Token(Token = "0x4017A01")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Background;

	[Token(Token = "0x4017A02")]
	[FieldOffset(Offset = "0x20")]
	public UISprite BackLine1;

	[Token(Token = "0x4017A03")]
	[FieldOffset(Offset = "0x24")]
	public UISprite BackLine2;

	[Token(Token = "0x4017A04")]
	[FieldOffset(Offset = "0x28")]
	public UISprite Triangle;

	[Token(Token = "0x4017A05")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite Point1;

	[Token(Token = "0x4017A06")]
	[FieldOffset(Offset = "0x30")]
	public UISprite Point2;

	[Token(Token = "0x4017A07")]
	[FieldOffset(Offset = "0x34")]
	public UISprite Point3;

	[Token(Token = "0x4017A08")]
	[FieldOffset(Offset = "0x38")]
	public UISprite Point4;

	[Token(Token = "0x4017A09")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton BuyButton;

	[Token(Token = "0x4017A0A")]
	[FieldOffset(Offset = "0x40")]
	public GameObject CanBuy;

	[Token(Token = "0x4017A0B")]
	[FieldOffset(Offset = "0x44")]
	public GameObject CantBuy;

	[Token(Token = "0x4017A0C")]
	[FieldOffset(Offset = "0x48")]
	public UILabel OldPrice;

	[Token(Token = "0x4017A0D")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel NewPrice;

	[Token(Token = "0x4017A0E")]
	[FieldOffset(Offset = "0x50")]
	public UILabel DiscountLabel;

	[Token(Token = "0x4017A0F")]
	[FieldOffset(Offset = "0x54")]
	public UILabel OffLabel;

	[Token(Token = "0x6016E5E")]
	[Address(RVA = "0x2886F78", Offset = "0x2886F78", VA = "0x2886F78")]
	public UIPaymentDiamondItemView()
	{
	}

	[Token(Token = "0x6016E5F")]
	[Address(RVA = "0x2886F80", Offset = "0x2886F80", VA = "0x2886F80", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E60")]
	[Address(RVA = "0x28876DC", Offset = "0x28876DC", VA = "0x28876DC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
