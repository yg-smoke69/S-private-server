using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A7C")]
public class UIWeaponSysEntranceView : UIBaseView
{
	[Token(Token = "0x4018D91")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnWeaponSkinUpgrader;

	[Token(Token = "0x4018D92")]
	[FieldOffset(Offset = "0x18")]
	public GameObject UpgraderClickEffect;

	[Token(Token = "0x4018D93")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelWSPName;

	[Token(Token = "0x4018D94")]
	[FieldOffset(Offset = "0x20")]
	public GameObject WSUNotInOpenTime;

	[Token(Token = "0x4018D95")]
	[FieldOffset(Offset = "0x24")]
	public GameObject WSUNewTag;

	[Token(Token = "0x4018D96")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnWeaponSkinEnter;

	[Token(Token = "0x4018D97")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject SkinLobbyClickEffect;

	[Token(Token = "0x601731A")]
	[Address(RVA = "0x1B7BCD0", Offset = "0x1B7BCD0", VA = "0x1B7BCD0")]
	public UIWeaponSysEntranceView()
	{
	}

	[Token(Token = "0x601731B")]
	[Address(RVA = "0x1B7BCD8", Offset = "0x1B7BCD8", VA = "0x1B7BCD8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601731C")]
	[Address(RVA = "0x1B7C090", Offset = "0x1B7C090", VA = "0x1B7C090")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
