using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200356F")]
public class UIGachaExtraListItemView : UIBaseView
{
	[Token(Token = "0x40152D5")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x40152D6")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ItemNormalBgBlackPx;

	[Token(Token = "0x40152D7")]
	[FieldOffset(Offset = "0x1C")]
	public UIProgressBar ItemNormalBgYellowPx;

	[Token(Token = "0x40152D8")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ItemLock;

	[Token(Token = "0x40152D9")]
	[FieldOffset(Offset = "0x24")]
	public UILabel UIItemLabelLocked;

	[Token(Token = "0x40152DA")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ItemMaskUnlock;

	[Token(Token = "0x40152DB")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject TreasureBoxNormal;

	[Token(Token = "0x40152DC")]
	[FieldOffset(Offset = "0x30")]
	public UISprite ItemIconReceived;

	[Token(Token = "0x40152DD")]
	[FieldOffset(Offset = "0x34")]
	public GameObject SingleRewardItemNormal;

	[Token(Token = "0x40152DE")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ItemUnLock;

	[Token(Token = "0x40152DF")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel UIItemLabelUnlock;

	[Token(Token = "0x40152E0")]
	[FieldOffset(Offset = "0x40")]
	public GameObject ItemMaskLock;

	[Token(Token = "0x40152E1")]
	[FieldOffset(Offset = "0x44")]
	public GameObject TreasureBoxSelected;

	[Token(Token = "0x40152E2")]
	[FieldOffset(Offset = "0x48")]
	public UISprite ItemIcon;

	[Token(Token = "0x40152E3")]
	[FieldOffset(Offset = "0x4C")]
	public Animation ItemIconAnim;

	[Token(Token = "0x40152E4")]
	[FieldOffset(Offset = "0x50")]
	public GameObject ItemIconHightLight;

	[Token(Token = "0x40152E5")]
	[FieldOffset(Offset = "0x54")]
	public GameObject SingleRewardItemSelected;

	[Token(Token = "0x60163FD")]
	[Address(RVA = "0x2477F48", Offset = "0x2477F48", VA = "0x2477F48")]
	public UIGachaExtraListItemView()
	{
	}

	[Token(Token = "0x60163FE")]
	[Address(RVA = "0x2477F50", Offset = "0x2477F50", VA = "0x2477F50", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60163FF")]
	[Address(RVA = "0x2478680", Offset = "0x2478680", VA = "0x2478680")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
