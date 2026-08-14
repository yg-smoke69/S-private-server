using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A5F")]
public class UIVeteranRewardsItemView : UIBaseView
{
	[Token(Token = "0x4018B9E")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIVeteranRewardsItem;

	[Token(Token = "0x4018B9F")]
	[FieldOffset(Offset = "0x18")]
	public GameObject NormalContainer_Effect;

	[Token(Token = "0x4018BA0")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject SpecialContainer_Effect;

	[Token(Token = "0x4018BA1")]
	[FieldOffset(Offset = "0x20")]
	public UILabel DayCountLabel;

	[Token(Token = "0x4018BA2")]
	[FieldOffset(Offset = "0x24")]
	public GameObject NormalContainer;

	[Token(Token = "0x4018BA3")]
	[FieldOffset(Offset = "0x28")]
	public UILabel ItemCount;

	[Token(Token = "0x4018BA4")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel ItemNameLabel_Normal;

	[Token(Token = "0x4018BA5")]
	[FieldOffset(Offset = "0x30")]
	public UISprite ItemNormalBG;

	[Token(Token = "0x4018BA6")]
	[FieldOffset(Offset = "0x34")]
	public UISprite Quality;

	[Token(Token = "0x4018BA7")]
	[FieldOffset(Offset = "0x38")]
	public BaseItemView2 ItemIconContainer;

	[Token(Token = "0x4018BA8")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject ReceivedHintNormal;

	[Token(Token = "0x4018BA9")]
	[FieldOffset(Offset = "0x40")]
	public GameObject SpecialContainer;

	[Token(Token = "0x4018BAA")]
	[FieldOffset(Offset = "0x44")]
	public UILabel ItemCountSpecial;

	[Token(Token = "0x4018BAB")]
	[FieldOffset(Offset = "0x48")]
	public GameObject ReceivedHintSpecial;

	[Token(Token = "0x4018BAC")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite ItemSpecialBG;

	[Token(Token = "0x4018BAD")]
	[FieldOffset(Offset = "0x50")]
	public UISprite SpecialQuality;

	[Token(Token = "0x4018BAE")]
	[FieldOffset(Offset = "0x54")]
	public UISprite SpriteSpecialQualityPlus;

	[Token(Token = "0x4018BAF")]
	[FieldOffset(Offset = "0x58")]
	public BaseItemView ItemIconContainer_Special;

	[Token(Token = "0x4018BB0")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel ItemNameLabel_Special;

	[Token(Token = "0x4018BB1")]
	[FieldOffset(Offset = "0x60")]
	public UILabel TimeLabel;

	[Token(Token = "0x4018BB2")]
	[FieldOffset(Offset = "0x64")]
	public UISprite SpriteSpecialQualityOrangePlus;

	[Token(Token = "0x4018BB3")]
	[FieldOffset(Offset = "0x68")]
	public UISprite SpriteQualityPlus;

	[Token(Token = "0x4018BB4")]
	[FieldOffset(Offset = "0x6C")]
	public UISprite SpriteQualityOrangePlus;

	[Token(Token = "0x60172C3")]
	[Address(RVA = "0x2CC09FC", Offset = "0x2CC09FC", VA = "0x2CC09FC")]
	public UIVeteranRewardsItemView()
	{
	}

	[Token(Token = "0x60172C4")]
	[Address(RVA = "0x2CC0A04", Offset = "0x2CC0A04", VA = "0x2CC0A04", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172C5")]
	[Address(RVA = "0x2CC13A4", Offset = "0x2CC13A4", VA = "0x2CC13A4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
