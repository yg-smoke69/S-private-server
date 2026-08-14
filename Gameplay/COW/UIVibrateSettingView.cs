using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A69")]
public class UIVibrateSettingView : UIBaseView
{
	[Token(Token = "0x4018C30")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView SettingScrollView;

	[Token(Token = "0x4018C31")]
	[FieldOffset(Offset = "0x18")]
	public UITable GroupTable;

	[Token(Token = "0x4018C32")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid Gloable_Container;

	[Token(Token = "0x4018C33")]
	[FieldOffset(Offset = "0x20")]
	public UISettingToggleBtnGroup Gloable_MainSwitch;

	[Token(Token = "0x4018C34")]
	[FieldOffset(Offset = "0x24")]
	public GameObject VisibleVoiceGroup;

	[Token(Token = "0x4018C35")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid VisibleVoice_Container;

	[Token(Token = "0x4018C36")]
	[FieldOffset(Offset = "0x2C")]
	public UISettingToggleBtnGroup VisibleVoice_PowerSet;

	[Token(Token = "0x4018C37")]
	[FieldOffset(Offset = "0x30")]
	public UISettingToggleBtnGroup VisibleVoice_FootStep;

	[Token(Token = "0x4018C38")]
	[FieldOffset(Offset = "0x34")]
	public UISettingToggleBtnGroup VisibleVoice_GunFire;

	[Token(Token = "0x4018C39")]
	[FieldOffset(Offset = "0x38")]
	public UIButton VisibleVoice_GunFireHint;

	[Token(Token = "0x4018C3A")]
	[FieldOffset(Offset = "0x3C")]
	public UISettingToggleBtnGroup VisibleVoice_CarSound;

	[Token(Token = "0x4018C3B")]
	[FieldOffset(Offset = "0x40")]
	public UIButton VisibleVoice_CarSoundHint;

	[Token(Token = "0x4018C3C")]
	[FieldOffset(Offset = "0x44")]
	public GameObject CharacterGroup;

	[Token(Token = "0x4018C3D")]
	[FieldOffset(Offset = "0x48")]
	public UIGrid Character_Container;

	[Token(Token = "0x4018C3E")]
	[FieldOffset(Offset = "0x4C")]
	public UISettingToggleBtnGroup Character_PowerSet;

	[Token(Token = "0x4018C3F")]
	[FieldOffset(Offset = "0x50")]
	public UISettingToggleBtnGroup Character_Hurt;

	[Token(Token = "0x4018C40")]
	[FieldOffset(Offset = "0x54")]
	public GameObject WeaponGroup;

	[Token(Token = "0x4018C41")]
	[FieldOffset(Offset = "0x58")]
	public UIGrid Weapon_Container;

	[Token(Token = "0x4018C42")]
	[FieldOffset(Offset = "0x5C")]
	public UISettingToggleBtnGroup Weapon_PowerSet;

	[Token(Token = "0x4018C43")]
	[FieldOffset(Offset = "0x60")]
	public UISettingToggleBtnGroup Weapon_AutoWeapon;

	[Token(Token = "0x4018C44")]
	[FieldOffset(Offset = "0x64")]
	public UISettingToggleBtnGroup Weapon_HalfAutoWeapon;

	[Token(Token = "0x4018C45")]
	[FieldOffset(Offset = "0x68")]
	public UISettingToggleBtnGroup Weapon_BlotWeapon;

	[Token(Token = "0x4018C46")]
	[FieldOffset(Offset = "0x6C")]
	public UISettingToggleBtnGroup Weapon_MeleeWeapon;

	[Token(Token = "0x4018C47")]
	[FieldOffset(Offset = "0x70")]
	public UISettingToggleBtnGroup Weapon_OtherWeapon;

	[Token(Token = "0x4018C48")]
	[FieldOffset(Offset = "0x74")]
	public GameObject VehicleGroup;

	[Token(Token = "0x4018C49")]
	[FieldOffset(Offset = "0x78")]
	public UIGrid Vehicle_Container;

	[Token(Token = "0x4018C4A")]
	[FieldOffset(Offset = "0x7C")]
	public UISettingToggleBtnGroup Vehicle_PowerSet;

	[Token(Token = "0x4018C4B")]
	[FieldOffset(Offset = "0x80")]
	public UISettingToggleBtnGroup Vehicle_Drive;

	[Token(Token = "0x4018C4C")]
	[FieldOffset(Offset = "0x84")]
	public UISettingToggleBtnGroup Vehicle_OnHurt;

	[Token(Token = "0x4018C4D")]
	[FieldOffset(Offset = "0x88")]
	public UISettingToggleBtnGroup Vehicle_Crash;

	[Token(Token = "0x4018C4E")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel OpenTip;

	[Token(Token = "0x60172E1")]
	[Address(RVA = "0x1018C8C", Offset = "0x1018C8C", VA = "0x1018C8C")]
	public UIVibrateSettingView()
	{
	}

	[Token(Token = "0x60172E2")]
	[Address(RVA = "0x1018C94", Offset = "0x1018C94", VA = "0x1018C94", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172E3")]
	[Address(RVA = "0x101994C", Offset = "0x101994C", VA = "0x101994C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
