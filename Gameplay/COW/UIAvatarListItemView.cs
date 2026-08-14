using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033CF")]
public class UIAvatarListItemView : UIBaseView
{
	[Token(Token = "0x4013D49")]
	[FieldOffset(Offset = "0x14")]
	public UIButton AvatarBtn;

	[Token(Token = "0x4013D4A")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Tips;

	[Token(Token = "0x4013D4B")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject SelectedBorder;

	[Token(Token = "0x4013D4C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SelectedObject;

	[Token(Token = "0x4013D4D")]
	[FieldOffset(Offset = "0x24")]
	public UILabel SelectedNameLabel;

	[Token(Token = "0x4013D4E")]
	[FieldOffset(Offset = "0x28")]
	public GameObject UnSelectedObject;

	[Token(Token = "0x4013D4F")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel UnSelectedNameLabel;

	[Token(Token = "0x4013D50")]
	[FieldOffset(Offset = "0x30")]
	public GameObject LockedObject;

	[Token(Token = "0x4013D51")]
	[FieldOffset(Offset = "0x34")]
	public GameObject UnLockedObject;

	[Token(Token = "0x4013D52")]
	[FieldOffset(Offset = "0x38")]
	public AvatarSelectionSkillSlot SkillSlotContainer;

	[Token(Token = "0x4013D53")]
	[FieldOffset(Offset = "0x3C")]
	public UIGrid SkillGrid;

	[Token(Token = "0x4013D54")]
	[FieldOffset(Offset = "0x40")]
	public Transform SlotPos_1;

	[Token(Token = "0x4013D55")]
	[FieldOffset(Offset = "0x44")]
	public UIAvatarSkillSlotMono AvatarSkillSlotMono1;

	[Token(Token = "0x4013D56")]
	[FieldOffset(Offset = "0x48")]
	public Transform SlotPos_2;

	[Token(Token = "0x4013D57")]
	[FieldOffset(Offset = "0x4C")]
	public UIAvatarSkillSlotMono AvatarSkillSlotMono2;

	[Token(Token = "0x4013D58")]
	[FieldOffset(Offset = "0x50")]
	public Transform SlotPos_3;

	[Token(Token = "0x4013D59")]
	[FieldOffset(Offset = "0x54")]
	public UIAvatarSkillSlotMono AvatarSkillSlotMono3;

	[Token(Token = "0x4013D5A")]
	[FieldOffset(Offset = "0x58")]
	public Transform SlotPos_4;

	[Token(Token = "0x4013D5B")]
	[FieldOffset(Offset = "0x5C")]
	public UIAvatarSkillSlotMono AvatarSkillSlotMono4;

	[Token(Token = "0x4013D5C")]
	[FieldOffset(Offset = "0x60")]
	public UISprite AvatarImage;

	[Token(Token = "0x4013D5D")]
	[FieldOffset(Offset = "0x64")]
	public UISprite IPTag;

	[Token(Token = "0x4013D5E")]
	[FieldOffset(Offset = "0x68")]
	public UISprite AwakenIconGray;

	[Token(Token = "0x4013D5F")]
	[FieldOffset(Offset = "0x6C")]
	public UISprite AwakenIconNormal;

	[Token(Token = "0x4013D60")]
	[FieldOffset(Offset = "0x70")]
	public UILabel AvatarLevel;

	[Token(Token = "0x4013D61")]
	[FieldOffset(Offset = "0x74")]
	public GameObject ExpireIcon;

	[Token(Token = "0x4013D62")]
	[FieldOffset(Offset = "0x78")]
	public GameObject VFX_awaken;

	[Token(Token = "0x4013D63")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject NewTips;

	[Token(Token = "0x4013D64")]
	[FieldOffset(Offset = "0x80")]
	public GameObject DownloadInfo;

	[Token(Token = "0x4013D65")]
	[FieldOffset(Offset = "0x84")]
	public GameObject LoveNode;

	[Token(Token = "0x4013D66")]
	[FieldOffset(Offset = "0x88")]
	public UIGrid AvatarGrid;

	[Token(Token = "0x4013D67")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject VFX_SetLove;

	[Token(Token = "0x6015F23")]
	[Address(RVA = "0x2B52960", Offset = "0x2B52960", VA = "0x2B52960")]
	public UIAvatarListItemView()
	{
	}

	[Token(Token = "0x6015F24")]
	[Address(RVA = "0x2B52968", Offset = "0x2B52968", VA = "0x2B52968", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F25")]
	[Address(RVA = "0x2B53520", Offset = "0x2B53520", VA = "0x2B53520")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
