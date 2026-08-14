using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200385F")]
public class UILuckyWheelPreviewRewardPoolItemView : UIBaseView
{
	[Token(Token = "0x4017205")]
	[FieldOffset(Offset = "0x14")]
	public TweenScale ItemTween;

	[Token(Token = "0x4017206")]
	[FieldOffset(Offset = "0x18")]
	public Animation Animation;

	[Token(Token = "0x4017207")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite IPTag;

	[Token(Token = "0x4017208")]
	[FieldOffset(Offset = "0x20")]
	public UIButton ItemBtn;

	[Token(Token = "0x4017209")]
	[FieldOffset(Offset = "0x24")]
	public UIDragScrollView ItemDragView;

	[Token(Token = "0x401720A")]
	[FieldOffset(Offset = "0x28")]
	public GameObject HotFlag;

	[Token(Token = "0x401720B")]
	[FieldOffset(Offset = "0x2C")]
	public BaseItemView RewardItem;

	[Token(Token = "0x401720C")]
	[FieldOffset(Offset = "0x30")]
	public UISprite QualityBG;

	[Token(Token = "0x401720D")]
	[FieldOffset(Offset = "0x34")]
	public UISprite QualityNameBG01;

	[Token(Token = "0x401720E")]
	[FieldOffset(Offset = "0x38")]
	public GameObject IconGroup;

	[Token(Token = "0x401720F")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite Sprite_Debris;

	[Token(Token = "0x4017210")]
	[FieldOffset(Offset = "0x40")]
	public UISprite VoucherIcon;

	[Token(Token = "0x4017211")]
	[FieldOffset(Offset = "0x44")]
	public UILabel LimitLabel;

	[Token(Token = "0x4017212")]
	[FieldOffset(Offset = "0x48")]
	public UILabel QuantityLabel;

	[Token(Token = "0x4017213")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject OwnedTitle;

	[Token(Token = "0x4017214")]
	[FieldOffset(Offset = "0x50")]
	public GameObject BuyedFlag;

	[Token(Token = "0x4017215")]
	[FieldOffset(Offset = "0x54")]
	public GameObject Descargar;

	[Token(Token = "0x4017216")]
	[FieldOffset(Offset = "0x58")]
	public GameObject GreyBg;

	[Token(Token = "0x4017217")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject HighLightBG;

	[Token(Token = "0x4017218")]
	[FieldOffset(Offset = "0x60")]
	public UILabel DiscountLabel;

	[Token(Token = "0x6016CC8")]
	[Address(RVA = "0x18CCA60", Offset = "0x18CCA60", VA = "0x18CCA60")]
	public UILuckyWheelPreviewRewardPoolItemView()
	{
	}

	[Token(Token = "0x6016CC9")]
	[Address(RVA = "0x18CCA68", Offset = "0x18CCA68", VA = "0x18CCA68", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CCA")]
	[Address(RVA = "0x18CD2DC", Offset = "0x18CD2DC", VA = "0x18CD2DC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
