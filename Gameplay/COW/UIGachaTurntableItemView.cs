using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200359D")]
public class UIGachaTurntableItemView : UIBaseView
{
	[Token(Token = "0x4015606")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UIGachaTurntableItem;

	[Token(Token = "0x4015607")]
	[FieldOffset(Offset = "0x18")]
	public TweenAlpha AnimAlpha;

	[Token(Token = "0x4015608")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ItemInfoContainer;

	[Token(Token = "0x4015609")]
	[FieldOffset(Offset = "0x20")]
	public BaseItemView BaseInfoView;

	[Token(Token = "0x401560A")]
	[FieldOffset(Offset = "0x24")]
	public TweenScale AnimScale;

	[Token(Token = "0x401560B")]
	[FieldOffset(Offset = "0x28")]
	public UISprite SelectedBG;

	[Token(Token = "0x401560C")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnTip;

	[Token(Token = "0x401560D")]
	[FieldOffset(Offset = "0x30")]
	public UISprite QualityBG;

	[Token(Token = "0x401560E")]
	[FieldOffset(Offset = "0x34")]
	public UISprite SpriteQualityPlus;

	[Token(Token = "0x401560F")]
	[FieldOffset(Offset = "0x38")]
	public UISprite Quality;

	[Token(Token = "0x4015610")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject ObtainedSprite;

	[Token(Token = "0x4015611")]
	[FieldOffset(Offset = "0x40")]
	public GameObject LimitTimeLabel;

	[Token(Token = "0x4015612")]
	[FieldOffset(Offset = "0x44")]
	public UILabel DropUpLabel;

	[Token(Token = "0x4015613")]
	[FieldOffset(Offset = "0x48")]
	public GameObject FlickerEffect;

	[Token(Token = "0x4015614")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject SeniorVFX;

	[Token(Token = "0x4015615")]
	[FieldOffset(Offset = "0x50")]
	public GameObject JuniorVFX;

	[Token(Token = "0x4015616")]
	[FieldOffset(Offset = "0x54")]
	public UISprite SpriteOrangeQualityPlus;

	[Token(Token = "0x6016487")]
	[Address(RVA = "0x2E9A33C", Offset = "0x2E9A33C", VA = "0x2E9A33C")]
	public UIGachaTurntableItemView()
	{
	}

	[Token(Token = "0x6016488")]
	[Address(RVA = "0x2E9A344", Offset = "0x2E9A344", VA = "0x2E9A344", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016489")]
	[Address(RVA = "0x2E9AA98", Offset = "0x2E9AA98", VA = "0x2E9AA98")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
