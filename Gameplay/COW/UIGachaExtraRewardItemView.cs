using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003572")]
public class UIGachaExtraRewardItemView : UIBaseView
{
	[Token(Token = "0x40152F2")]
	[FieldOffset(Offset = "0x14")]
	public TweenScale ItemTween;

	[Token(Token = "0x40152F3")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ItemBtn;

	[Token(Token = "0x40152F4")]
	[FieldOffset(Offset = "0x1C")]
	public UIDragScrollView ItemDragView;

	[Token(Token = "0x40152F5")]
	[FieldOffset(Offset = "0x20")]
	public BaseItemView RewardItem;

	[Token(Token = "0x40152F6")]
	[FieldOffset(Offset = "0x24")]
	public UISprite QualityBG;

	[Token(Token = "0x40152F7")]
	[FieldOffset(Offset = "0x28")]
	public UISprite SpriteQualityPlus;

	[Token(Token = "0x40152F8")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite QualityNameBG01;

	[Token(Token = "0x40152F9")]
	[FieldOffset(Offset = "0x30")]
	public GameObject IconGroup;

	[Token(Token = "0x40152FA")]
	[FieldOffset(Offset = "0x34")]
	public UISprite Sprite_Debris;

	[Token(Token = "0x40152FB")]
	[FieldOffset(Offset = "0x38")]
	public UISprite VoucherIcon;

	[Token(Token = "0x40152FC")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel LimitLabel;

	[Token(Token = "0x40152FD")]
	[FieldOffset(Offset = "0x40")]
	public UILabel QuantityLabel;

	[Token(Token = "0x40152FE")]
	[FieldOffset(Offset = "0x44")]
	public GameObject LimitedTitle;

	[Token(Token = "0x40152FF")]
	[FieldOffset(Offset = "0x48")]
	public GameObject ClaimedTitle;

	[Token(Token = "0x4015300")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject LadderGotTitle;

	[Token(Token = "0x4015301")]
	[FieldOffset(Offset = "0x50")]
	public GameObject OwnedTitle;

	[Token(Token = "0x4015302")]
	[FieldOffset(Offset = "0x54")]
	public GameObject Descargar;

	[Token(Token = "0x4015303")]
	[FieldOffset(Offset = "0x58")]
	public GameObject GreyBg;

	[Token(Token = "0x4015304")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject HighLightBG;

	[Token(Token = "0x4015305")]
	[FieldOffset(Offset = "0x60")]
	public UISprite SpriteOrangeQualityPlus;

	[Token(Token = "0x6016406")]
	[Address(RVA = "0x247B7C0", Offset = "0x247B7C0", VA = "0x247B7C0")]
	public UIGachaExtraRewardItemView()
	{
	}

	[Token(Token = "0x6016407")]
	[Address(RVA = "0x247B7C8", Offset = "0x247B7C8", VA = "0x247B7C8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016408")]
	[Address(RVA = "0x247C030", Offset = "0x247C030", VA = "0x247C030")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
