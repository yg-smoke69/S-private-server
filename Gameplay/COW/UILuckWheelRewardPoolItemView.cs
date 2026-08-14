using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200385B")]
public class UILuckWheelRewardPoolItemView : UIBaseView
{
	[Token(Token = "0x40171C0")]
	[FieldOffset(Offset = "0x14")]
	public Animation Animation;

	[Token(Token = "0x40171C1")]
	[FieldOffset(Offset = "0x18")]
	public Transform RewardItem;

	[Token(Token = "0x40171C2")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BuyBtn;

	[Token(Token = "0x40171C3")]
	[FieldOffset(Offset = "0x20")]
	public UISprite BuyBntSprite;

	[Token(Token = "0x40171C4")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Discount;

	[Token(Token = "0x40171C5")]
	[FieldOffset(Offset = "0x28")]
	public UILabel DiscountPrice;

	[Token(Token = "0x40171C6")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite DiscountCoinIcon;

	[Token(Token = "0x40171C7")]
	[FieldOffset(Offset = "0x30")]
	public UILabel OriginPrice;

	[Token(Token = "0x40171C8")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Normal;

	[Token(Token = "0x40171C9")]
	[FieldOffset(Offset = "0x38")]
	public UILabel NormalPrice;

	[Token(Token = "0x40171CA")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite NormalCoinIcon;

	[Token(Token = "0x40171CB")]
	[FieldOffset(Offset = "0x40")]
	public UILabel BuyLabel;

	[Token(Token = "0x40171CC")]
	[FieldOffset(Offset = "0x44")]
	public GameObject VFX;

	[Token(Token = "0x6016CBC")]
	[Address(RVA = "0x21FB7D8", Offset = "0x21FB7D8", VA = "0x21FB7D8")]
	public UILuckWheelRewardPoolItemView()
	{
	}

	[Token(Token = "0x6016CBD")]
	[Address(RVA = "0x21FB7E0", Offset = "0x21FB7E0", VA = "0x21FB7E0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CBE")]
	[Address(RVA = "0x21FBDBC", Offset = "0x21FBDBC", VA = "0x21FBDBC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
