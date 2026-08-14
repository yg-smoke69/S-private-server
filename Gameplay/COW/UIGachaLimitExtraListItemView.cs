using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200358D")]
public class UIGachaLimitExtraListItemView : UIBaseView
{
	[Token(Token = "0x40154E0")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget RootViewWidget;

	[Token(Token = "0x40154E1")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ItemBtn;

	[Token(Token = "0x40154E2")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ItemNormalBgYellowPx;

	[Token(Token = "0x40154E3")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ItemNormalBgBlackPx;

	[Token(Token = "0x40154E4")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ItemLock;

	[Token(Token = "0x40154E5")]
	[FieldOffset(Offset = "0x28")]
	public GameObject TreasureBoxNormal;

	[Token(Token = "0x40154E6")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ItemMaskUnlock;

	[Token(Token = "0x40154E7")]
	[FieldOffset(Offset = "0x30")]
	public UILabel UIItemLabelLocked;

	[Token(Token = "0x40154E8")]
	[FieldOffset(Offset = "0x34")]
	public UISprite ItemIconReceived;

	[Token(Token = "0x40154E9")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ItemIconVfx;

	[Token(Token = "0x40154EA")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject SingleRewardItemNormal;

	[Token(Token = "0x40154EB")]
	[FieldOffset(Offset = "0x40")]
	public GameObject ItemUnLock;

	[Token(Token = "0x40154EC")]
	[FieldOffset(Offset = "0x44")]
	public GameObject TreasureBoxSelected;

	[Token(Token = "0x40154ED")]
	[FieldOffset(Offset = "0x48")]
	public GameObject ItemMaskLock;

	[Token(Token = "0x40154EE")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel UIItemLabelUnlock;

	[Token(Token = "0x40154EF")]
	[FieldOffset(Offset = "0x50")]
	public UISprite ItemIcon;

	[Token(Token = "0x40154F0")]
	[FieldOffset(Offset = "0x54")]
	public Animation ItemIconAnim;

	[Token(Token = "0x40154F1")]
	[FieldOffset(Offset = "0x58")]
	public GameObject ItemIconHightLight;

	[Token(Token = "0x40154F2")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject SingleRewardItemSelected;

	[Token(Token = "0x40154F3")]
	[FieldOffset(Offset = "0x60")]
	public GameObject GainEffect;

	[Token(Token = "0x6016457")]
	[Address(RVA = "0x2A133FC", Offset = "0x2A133FC", VA = "0x2A133FC")]
	public UIGachaLimitExtraListItemView()
	{
	}

	[Token(Token = "0x6016458")]
	[Address(RVA = "0x2A13404", Offset = "0x2A13404", VA = "0x2A13404", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016459")]
	[Address(RVA = "0x2A13C30", Offset = "0x2A13C30", VA = "0x2A13C30")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
