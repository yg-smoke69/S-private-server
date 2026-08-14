using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200358A")]
public class UIGachaLimitChestSelectRewardItemView : UIBaseView
{
	[Token(Token = "0x40154A1")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UIGachaLimitChestSelectRewardItem;

	[Token(Token = "0x40154A2")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ItemInfoContainer;

	[Token(Token = "0x40154A3")]
	[FieldOffset(Offset = "0x1C")]
	public BaseItemView BaseInfoView;

	[Token(Token = "0x40154A4")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SelectedBG;

	[Token(Token = "0x40154A5")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ItemContainer;

	[Token(Token = "0x40154A6")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ObtainedSprite;

	[Token(Token = "0x40154A7")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject LimitTimeLabel;

	[Token(Token = "0x40154A8")]
	[FieldOffset(Offset = "0x30")]
	public UILabel DropUpLabel;

	[Token(Token = "0x40154A9")]
	[FieldOffset(Offset = "0x34")]
	public GameObject AlreadyOwnSprite;

	[Token(Token = "0x40154AA")]
	[FieldOffset(Offset = "0x38")]
	public UIButton BtnTip;

	[Token(Token = "0x40154AB")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite QualityBG;

	[Token(Token = "0x40154AC")]
	[FieldOffset(Offset = "0x40")]
	public UISprite SpritePurplePlus;

	[Token(Token = "0x40154AD")]
	[FieldOffset(Offset = "0x44")]
	public UISprite Quality;

	[Token(Token = "0x40154AE")]
	[FieldOffset(Offset = "0x48")]
	public GameObject FlickerEffect;

	[Token(Token = "0x40154AF")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject SecondVFX;

	[Token(Token = "0x40154B0")]
	[FieldOffset(Offset = "0x50")]
	public GameObject FirstVFX;

	[Token(Token = "0x40154B1")]
	[FieldOffset(Offset = "0x54")]
	public GameObject ThirdVFX;

	[Token(Token = "0x40154B2")]
	[FieldOffset(Offset = "0x58")]
	public UIButton ChooseContainer;

	[Token(Token = "0x40154B3")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject ChooseState;

	[Token(Token = "0x40154B4")]
	[FieldOffset(Offset = "0x60")]
	public Animation RemoveContainer;

	[Token(Token = "0x40154B5")]
	[FieldOffset(Offset = "0x64")]
	public GameObject VfxRemove;

	[Token(Token = "0x40154B6")]
	[FieldOffset(Offset = "0x68")]
	public UISprite SpriteOrangePlus;

	[Token(Token = "0x601644E")]
	[Address(RVA = "0x2E86238", Offset = "0x2E86238", VA = "0x2E86238")]
	public UIGachaLimitChestSelectRewardItemView()
	{
	}

	[Token(Token = "0x601644F")]
	[Address(RVA = "0x2E86240", Offset = "0x2E86240", VA = "0x2E86240", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016450")]
	[Address(RVA = "0x2E86B38", Offset = "0x2E86B38", VA = "0x2E86B38")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
