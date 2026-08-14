using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200358E")]
public class UIGachaLimitItemView : UIBaseView
{
	[Token(Token = "0x40154F4")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UIGachaLimitItem;

	[Token(Token = "0x40154F5")]
	[FieldOffset(Offset = "0x18")]
	public GameObject GameObjectItemInfoContainer;

	[Token(Token = "0x40154F6")]
	[FieldOffset(Offset = "0x1C")]
	public BaseItemView BaseItemViewItemInfoContainer;

	[Token(Token = "0x40154F7")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SelectedBG;

	[Token(Token = "0x40154F8")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ItemContainer;

	[Token(Token = "0x40154F9")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ObtainedSprite;

	[Token(Token = "0x40154FA")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject LimitTimeLabel;

	[Token(Token = "0x40154FB")]
	[FieldOffset(Offset = "0x30")]
	public UILabel DropUpLabel;

	[Token(Token = "0x40154FC")]
	[FieldOffset(Offset = "0x34")]
	public GameObject AlreadyOwnSprite;

	[Token(Token = "0x40154FD")]
	[FieldOffset(Offset = "0x38")]
	public UIButton BtnTip;

	[Token(Token = "0x40154FE")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite QualityBG;

	[Token(Token = "0x40154FF")]
	[FieldOffset(Offset = "0x40")]
	public UISprite SpritePurplePlus;

	[Token(Token = "0x4015500")]
	[FieldOffset(Offset = "0x44")]
	public UISprite Quality;

	[Token(Token = "0x4015501")]
	[FieldOffset(Offset = "0x48")]
	public GameObject FlickerEffect;

	[Token(Token = "0x4015502")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject SecondVFX;

	[Token(Token = "0x4015503")]
	[FieldOffset(Offset = "0x50")]
	public GameObject FirstVFX;

	[Token(Token = "0x4015504")]
	[FieldOffset(Offset = "0x54")]
	public GameObject ThirdVFX;

	[Token(Token = "0x4015505")]
	[FieldOffset(Offset = "0x58")]
	public UIButton ChooseContainer;

	[Token(Token = "0x4015506")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject ChooseState;

	[Token(Token = "0x4015507")]
	[FieldOffset(Offset = "0x60")]
	public Animation RemoveContainer;

	[Token(Token = "0x4015508")]
	[FieldOffset(Offset = "0x64")]
	public GameObject VfxRemove;

	[Token(Token = "0x4015509")]
	[FieldOffset(Offset = "0x68")]
	public GameObject SpriteOrangePlus;

	[Token(Token = "0x601645A")]
	[Address(RVA = "0x2A15E34", Offset = "0x2A15E34", VA = "0x2A15E34")]
	public UIGachaLimitItemView()
	{
	}

	[Token(Token = "0x601645B")]
	[Address(RVA = "0x2A15E3C", Offset = "0x2A15E3C", VA = "0x2A15E3C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601645C")]
	[Address(RVA = "0x2A16728", Offset = "0x2A16728", VA = "0x2A16728")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
