using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033D8")]
public class UIAvatarSkillSlotView : UIBaseView
{
	[Token(Token = "0x4013E91")]
	[FieldOffset(Offset = "0x14")]
	public AvatarSelectionSkillSlot SlotScript;

	[Token(Token = "0x4013E92")]
	[FieldOffset(Offset = "0x18")]
	public UIButton SlotBtn;

	[Token(Token = "0x4013E93")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject SelectedHL;

	[Token(Token = "0x4013E94")]
	[FieldOffset(Offset = "0x20")]
	public GameObject NormalBG_G;

	[Token(Token = "0x4013E95")]
	[FieldOffset(Offset = "0x24")]
	public GameObject NormalBG_Y;

	[Token(Token = "0x4013E96")]
	[FieldOffset(Offset = "0x28")]
	public GameObject NormalBG_R;

	[Token(Token = "0x4013E97")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject NormalBG_N;

	[Token(Token = "0x4013E98")]
	[FieldOffset(Offset = "0x30")]
	public GameObject lv_bg;

	[Token(Token = "0x4013E99")]
	[FieldOffset(Offset = "0x34")]
	public UILabel LvLabel;

	[Token(Token = "0x4013E9A")]
	[FieldOffset(Offset = "0x38")]
	public GameObject lv_bg2;

	[Token(Token = "0x4013E9B")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel LvLabel2;

	[Token(Token = "0x4013E9C")]
	[FieldOffset(Offset = "0x40")]
	public GameObject lv_bg3;

	[Token(Token = "0x4013E9D")]
	[FieldOffset(Offset = "0x44")]
	public UILabel LvLabel3;

	[Token(Token = "0x4013E9E")]
	[FieldOffset(Offset = "0x48")]
	public GameObject Empty;

	[Token(Token = "0x4013E9F")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject VFX_Boarder;

	[Token(Token = "0x4013EA0")]
	[FieldOffset(Offset = "0x50")]
	public GameObject LockGo;

	[Token(Token = "0x4013EA1")]
	[FieldOffset(Offset = "0x54")]
	public GameObject lockSprite;

	[Token(Token = "0x4013EA2")]
	[FieldOffset(Offset = "0x58")]
	public GameObject unlockAnim;

	[Token(Token = "0x4013EA3")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject newSlotTip;

	[Token(Token = "0x4013EA4")]
	[FieldOffset(Offset = "0x60")]
	public GameObject ActiveSkillLock;

	[Token(Token = "0x4013EA5")]
	[FieldOffset(Offset = "0x64")]
	public GameObject RedTips;

	[Token(Token = "0x4013EA6")]
	[FieldOffset(Offset = "0x68")]
	public GameObject SpeicalGo;

	[Token(Token = "0x4013EA7")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject FreeUnlock;

	[Token(Token = "0x6015F3E")]
	[Address(RVA = "0x2F9EC50", Offset = "0x2F9EC50", VA = "0x2F9EC50")]
	public UIAvatarSkillSlotView()
	{
	}

	[Token(Token = "0x6015F3F")]
	[Address(RVA = "0x2F9EC58", Offset = "0x2F9EC58", VA = "0x2F9EC58", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F40")]
	[Address(RVA = "0x2F9F568", Offset = "0x2F9F568", VA = "0x2F9F568")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
