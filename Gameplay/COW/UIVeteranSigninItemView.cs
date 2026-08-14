using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A61")]
public class UIVeteranSigninItemView : UIBaseView
{
	[Token(Token = "0x4018BBC")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIVeteranSigninItem;

	[Token(Token = "0x4018BBD")]
	[FieldOffset(Offset = "0x18")]
	public GameObject NormalContainer_Effect;

	[Token(Token = "0x4018BBE")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject SpecialContainer_Effect;

	[Token(Token = "0x4018BBF")]
	[FieldOffset(Offset = "0x20")]
	public UILabel DayCountLabel;

	[Token(Token = "0x4018BC0")]
	[FieldOffset(Offset = "0x24")]
	public Transform ItemInfoContainer;

	[Token(Token = "0x4018BC1")]
	[FieldOffset(Offset = "0x28")]
	public UILabel ItemTimeLeft;

	[Token(Token = "0x4018BC2")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject NormalContainer;

	[Token(Token = "0x4018BC3")]
	[FieldOffset(Offset = "0x30")]
	public UILabel ItemCount;

	[Token(Token = "0x4018BC4")]
	[FieldOffset(Offset = "0x34")]
	public UILabel ItemNameLabel_Normal;

	[Token(Token = "0x4018BC5")]
	[FieldOffset(Offset = "0x38")]
	public UISprite ItemNormalBG;

	[Token(Token = "0x4018BC6")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite SpriteQualityPlus;

	[Token(Token = "0x4018BC7")]
	[FieldOffset(Offset = "0x40")]
	public UISprite Quality;

	[Token(Token = "0x4018BC8")]
	[FieldOffset(Offset = "0x44")]
	public BaseItemView2 ItemIconContainer;

	[Token(Token = "0x4018BC9")]
	[FieldOffset(Offset = "0x48")]
	public GameObject ReceivedHintNormal;

	[Token(Token = "0x4018BCA")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject SpecialContainer;

	[Token(Token = "0x4018BCB")]
	[FieldOffset(Offset = "0x50")]
	public UILabel ItemCountSpecial;

	[Token(Token = "0x4018BCC")]
	[FieldOffset(Offset = "0x54")]
	public GameObject ReceivedHintSpecial;

	[Token(Token = "0x4018BCD")]
	[FieldOffset(Offset = "0x58")]
	public UISprite ItemSpecialBG;

	[Token(Token = "0x4018BCE")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite SpecialQuality;

	[Token(Token = "0x4018BCF")]
	[FieldOffset(Offset = "0x60")]
	public UISprite SpriteSpecialQualityPlus;

	[Token(Token = "0x4018BD0")]
	[FieldOffset(Offset = "0x64")]
	public BaseItemView ItemIconContainer_Special;

	[Token(Token = "0x4018BD1")]
	[FieldOffset(Offset = "0x68")]
	public UILabel ItemNameLabel_Special;

	[Token(Token = "0x4018BD2")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject SpriteSpecialQualityOrangePlus;

	[Token(Token = "0x4018BD3")]
	[FieldOffset(Offset = "0x70")]
	public GameObject SpriteQualityOrangePlus;

	[Token(Token = "0x60172C9")]
	[Address(RVA = "0x2CC4C10", Offset = "0x2CC4C10", VA = "0x2CC4C10")]
	public UIVeteranSigninItemView()
	{
	}

	[Token(Token = "0x60172CA")]
	[Address(RVA = "0x2CC4C18", Offset = "0x2CC4C18", VA = "0x2CC4C18", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172CB")]
	[Address(RVA = "0x2CC55D8", Offset = "0x2CC55D8", VA = "0x2CC55D8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
