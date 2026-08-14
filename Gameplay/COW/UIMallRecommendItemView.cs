using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003877")]
public class UIMallRecommendItemView : UIBaseView
{
	[Token(Token = "0x40173F2")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x40173F3")]
	[FieldOffset(Offset = "0x18")]
	public BaseItemView2 BaseItemInfo;

	[Token(Token = "0x40173F4")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject HighLightBG;

	[Token(Token = "0x40173F5")]
	[FieldOffset(Offset = "0x20")]
	public UISprite QualityBG;

	[Token(Token = "0x40173F6")]
	[FieldOffset(Offset = "0x24")]
	public UISprite SpriteQualityPlus;

	[Token(Token = "0x40173F7")]
	[FieldOffset(Offset = "0x28")]
	public UISprite Quality;

	[Token(Token = "0x40173F8")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject BGBlack;

	[Token(Token = "0x40173F9")]
	[FieldOffset(Offset = "0x30")]
	public GameObject BGWhite;

	[Token(Token = "0x40173FA")]
	[FieldOffset(Offset = "0x34")]
	public GameObject UniquedTitle;

	[Token(Token = "0x40173FB")]
	[FieldOffset(Offset = "0x38")]
	public GameObject SellOutTitle;

	[Token(Token = "0x40173FC")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel DiscountLabel;

	[Token(Token = "0x40173FD")]
	[FieldOffset(Offset = "0x40")]
	public UISprite SpriteQualityOrangePlus;

	[Token(Token = "0x6016D10")]
	[Address(RVA = "0x226ABA8", Offset = "0x226ABA8", VA = "0x226ABA8")]
	public UIMallRecommendItemView()
	{
	}

	[Token(Token = "0x6016D11")]
	[Address(RVA = "0x226ABB0", Offset = "0x226ABB0", VA = "0x226ABB0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D12")]
	[Address(RVA = "0x226B13C", Offset = "0x226B13C", VA = "0x226B13C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
