using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039EF")]
public class UIStandardItemMiniView : UIBaseView
{
	[Token(Token = "0x401867E")]
	[FieldOffset(Offset = "0x14")]
	public TweenScale ItemTween;

	[Token(Token = "0x401867F")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ItemBtn;

	[Token(Token = "0x4018680")]
	[FieldOffset(Offset = "0x1C")]
	public UIDragScrollView ItemDragView;

	[Token(Token = "0x4018681")]
	[FieldOffset(Offset = "0x20")]
	public BaseItemView2 RewardItem;

	[Token(Token = "0x4018682")]
	[FieldOffset(Offset = "0x24")]
	public UISprite QualityBG;

	[Token(Token = "0x4018683")]
	[FieldOffset(Offset = "0x28")]
	public UISprite SpriteQualityPlus;

	[Token(Token = "0x4018684")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite QualityNameBG01;

	[Token(Token = "0x4018685")]
	[FieldOffset(Offset = "0x30")]
	public UISprite Icon;

	[Token(Token = "0x4018686")]
	[FieldOffset(Offset = "0x34")]
	public UILabel LimitLabel;

	[Token(Token = "0x4018687")]
	[FieldOffset(Offset = "0x38")]
	public UILabel QuantityLabel;

	[Token(Token = "0x4018688")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject LimitedTitle;

	[Token(Token = "0x4018689")]
	[FieldOffset(Offset = "0x40")]
	public GameObject ClaimedTitle;

	[Token(Token = "0x401868A")]
	[FieldOffset(Offset = "0x44")]
	public GameObject LadderGotTitle;

	[Token(Token = "0x401868B")]
	[FieldOffset(Offset = "0x48")]
	public GameObject OwnedTitle;

	[Token(Token = "0x401868C")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject Descargar;

	[Token(Token = "0x401868D")]
	[FieldOffset(Offset = "0x50")]
	public GameObject GreyBg;

	[Token(Token = "0x401868E")]
	[FieldOffset(Offset = "0x54")]
	public GameObject HighLightBG;

	[Token(Token = "0x401868F")]
	[FieldOffset(Offset = "0x58")]
	public UILabel CanNotEquipTitle;

	[Token(Token = "0x4018690")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite SpriteOrangeQualityPlus;

	[Token(Token = "0x6017173")]
	[Address(RVA = "0x206E0B8", Offset = "0x206E0B8", VA = "0x206E0B8")]
	public UIStandardItemMiniView()
	{
	}

	[Token(Token = "0x6017174")]
	[Address(RVA = "0x206E0C0", Offset = "0x206E0C0", VA = "0x206E0C0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017175")]
	[Address(RVA = "0x206E8D4", Offset = "0x206E8D4", VA = "0x206E8D4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
