using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036DD")]
public class UIHudPickupListItemView : UIBaseView
{
	[Token(Token = "0x4016277")]
	[FieldOffset(Offset = "0x14")]
	public GameObject light_mask;

	[Token(Token = "0x4016278")]
	[FieldOffset(Offset = "0x18")]
	public UITexture Texture;

	[Token(Token = "0x4016279")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelCount;

	[Token(Token = "0x401627A")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnItemAction;

	[Token(Token = "0x401627B")]
	[FieldOffset(Offset = "0x24")]
	public UILabel ItemName;

	[Token(Token = "0x401627C")]
	[FieldOffset(Offset = "0x28")]
	public UIEventListener BtnEventListener;

	[Token(Token = "0x401627D")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite SpriteItemIcon;

	[Token(Token = "0x401627E")]
	[FieldOffset(Offset = "0x30")]
	public UISprite SpriteBackground;

	[Token(Token = "0x401627F")]
	[FieldOffset(Offset = "0x34")]
	public GameObject StateIconGO;

	[Token(Token = "0x4016280")]
	[FieldOffset(Offset = "0x38")]
	public UISprite StateIcon;

	[Token(Token = "0x4016281")]
	[FieldOffset(Offset = "0x3C")]
	public UIProgressBar EquipmentDurabilityLostRateMask;

	[Token(Token = "0x4016282")]
	[FieldOffset(Offset = "0x40")]
	public GameObject AutoPickupMask;

	[Token(Token = "0x4016283")]
	[FieldOffset(Offset = "0x44")]
	public GameObject BountyIcon;

	[Token(Token = "0x4016284")]
	[FieldOffset(Offset = "0x48")]
	public GameObject BountyOtherIcon;

	[Token(Token = "0x6016842")]
	[Address(RVA = "0x185BAB4", Offset = "0x185BAB4", VA = "0x185BAB4")]
	public UIHudPickupListItemView()
	{
	}

	[Token(Token = "0x6016843")]
	[Address(RVA = "0x185BABC", Offset = "0x185BABC", VA = "0x185BABC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016844")]
	[Address(RVA = "0x185C108", Offset = "0x185C108", VA = "0x185C108")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
