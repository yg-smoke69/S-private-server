using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200356B")]
public class UIGachaDrawResultView : UIBaseView
{
	[Token(Token = "0x401529C")]
	[FieldOffset(Offset = "0x14")]
	public GameObject BGOrangeSplashVFX;

	[Token(Token = "0x401529D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject BGPurpleSplashVFX;

	[Token(Token = "0x401529E")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject BGBlueSplashVFX;

	[Token(Token = "0x401529F")]
	[FieldOffset(Offset = "0x20")]
	public GameObject RewardPermanentVFX;

	[Token(Token = "0x40152A0")]
	[FieldOffset(Offset = "0x24")]
	public GameObject RewardOrangeVFX;

	[Token(Token = "0x40152A1")]
	[FieldOffset(Offset = "0x28")]
	public GameObject RewardPurpleVFX;

	[Token(Token = "0x40152A2")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject RewardBlueVFX;

	[Token(Token = "0x40152A3")]
	[FieldOffset(Offset = "0x30")]
	public Transform StartPos;

	[Token(Token = "0x40152A4")]
	[FieldOffset(Offset = "0x34")]
	public TweenPosition TweenPosTemplate;

	[Token(Token = "0x40152A5")]
	[FieldOffset(Offset = "0x38")]
	public TweenPosition OEndTweenPos0;

	[Token(Token = "0x40152A6")]
	[FieldOffset(Offset = "0x3C")]
	public TweenPosition FEndTweenPos0;

	[Token(Token = "0x40152A7")]
	[FieldOffset(Offset = "0x40")]
	public TweenPosition FEndTweenPos1;

	[Token(Token = "0x40152A8")]
	[FieldOffset(Offset = "0x44")]
	public TweenPosition FEndTweenPos2;

	[Token(Token = "0x40152A9")]
	[FieldOffset(Offset = "0x48")]
	public TweenPosition FEndTweenPos3;

	[Token(Token = "0x40152AA")]
	[FieldOffset(Offset = "0x4C")]
	public TweenPosition FEndTweenPos4;

	[Token(Token = "0x40152AB")]
	[FieldOffset(Offset = "0x50")]
	public TweenPosition TEndTweenPos0;

	[Token(Token = "0x40152AC")]
	[FieldOffset(Offset = "0x54")]
	public TweenPosition TEndTweenPos1;

	[Token(Token = "0x40152AD")]
	[FieldOffset(Offset = "0x58")]
	public TweenPosition TEndTweenPos2;

	[Token(Token = "0x40152AE")]
	[FieldOffset(Offset = "0x5C")]
	public TweenPosition TEndTweenPos3;

	[Token(Token = "0x40152AF")]
	[FieldOffset(Offset = "0x60")]
	public TweenPosition TEndTweenPos4;

	[Token(Token = "0x40152B0")]
	[FieldOffset(Offset = "0x64")]
	public TweenPosition TEndTweenPos5;

	[Token(Token = "0x40152B1")]
	[FieldOffset(Offset = "0x68")]
	public TweenPosition TEndTweenPos6;

	[Token(Token = "0x40152B2")]
	[FieldOffset(Offset = "0x6C")]
	public TweenPosition TEndTweenPos7;

	[Token(Token = "0x40152B3")]
	[FieldOffset(Offset = "0x70")]
	public TweenPosition TEndTweenPos8;

	[Token(Token = "0x40152B4")]
	[FieldOffset(Offset = "0x74")]
	public TweenPosition TEndTweenPos9;

	[Token(Token = "0x40152B5")]
	[FieldOffset(Offset = "0x78")]
	public TweenPosition TEndTweenPos10;

	[Token(Token = "0x40152B6")]
	[FieldOffset(Offset = "0x7C")]
	public UIGrid BtnGroup;

	[Token(Token = "0x40152B7")]
	[FieldOffset(Offset = "0x80")]
	public UIButton RepurchaseBtn;

	[Token(Token = "0x40152B8")]
	[FieldOffset(Offset = "0x84")]
	public UILabel RepurchaseLabel;

	[Token(Token = "0x40152B9")]
	[FieldOffset(Offset = "0x88")]
	public UILabel FreeLabel;

	[Token(Token = "0x40152BA")]
	[FieldOffset(Offset = "0x8C")]
	public UISprite CurrencySprite;

	[Token(Token = "0x40152BB")]
	[FieldOffset(Offset = "0x90")]
	public UILabel CurrencyCountLabel;

	[Token(Token = "0x40152BC")]
	[FieldOffset(Offset = "0x94")]
	public UIButton OKBtn;

	[Token(Token = "0x40152BD")]
	[FieldOffset(Offset = "0x98")]
	public UIButton OpenBtn;

	[Token(Token = "0x40152BE")]
	[FieldOffset(Offset = "0x9C")]
	public UIButton FastEquipBtn;

	[Token(Token = "0x60163F1")]
	[Address(RVA = "0x24726B4", Offset = "0x24726B4", VA = "0x24726B4")]
	public UIGachaDrawResultView()
	{
	}

	[Token(Token = "0x60163F2")]
	[Address(RVA = "0x24726BC", Offset = "0x24726BC", VA = "0x24726BC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60163F3")]
	[Address(RVA = "0x24734A8", Offset = "0x24734A8", VA = "0x24734A8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
