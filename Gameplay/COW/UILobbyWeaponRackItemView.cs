using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003853")]
public class UILobbyWeaponRackItemView : UIBaseView
{
	[Token(Token = "0x401713C")]
	[FieldOffset(Offset = "0x14")]
	public WeaponRackDragDropItem WeaponRackDragDropItemUILobbyWeaponRackItem;

	[Token(Token = "0x401713D")]
	[FieldOffset(Offset = "0x18")]
	public UIDragDropContainer UIDragDropContainerUILobbyWeaponRackItem;

	[Token(Token = "0x401713E")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton UIButtonUILobbyWeaponRackItem;

	[Token(Token = "0x401713F")]
	[FieldOffset(Offset = "0x20")]
	public GameObject GunRoot;

	[Token(Token = "0x4017140")]
	[FieldOffset(Offset = "0x24")]
	public UISprite GunIcon;

	[Token(Token = "0x4017141")]
	[FieldOffset(Offset = "0x28")]
	public GameObject GrenadeRoot;

	[Token(Token = "0x4017142")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite GrenadeIcon;

	[Token(Token = "0x4017143")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Selected;

	[Token(Token = "0x4017144")]
	[FieldOffset(Offset = "0x34")]
	public UISprite OtherIcon;

	[Token(Token = "0x4017145")]
	[FieldOffset(Offset = "0x38")]
	public UISprite QualityBg;

	[Token(Token = "0x4017146")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite QulityLine;

	[Token(Token = "0x4017147")]
	[FieldOffset(Offset = "0x40")]
	public UISprite SpriteQualityPlus;

	[Token(Token = "0x4017148")]
	[FieldOffset(Offset = "0x44")]
	public UISprite SpriteQualityOrangePlus;

	[Token(Token = "0x4017149")]
	[FieldOffset(Offset = "0x48")]
	public GameObject Equiped;

	[Token(Token = "0x401714A")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject TipsGO;

	[Token(Token = "0x401714B")]
	[FieldOffset(Offset = "0x50")]
	public UILabel TagLabel;

	[Token(Token = "0x401714C")]
	[FieldOffset(Offset = "0x54")]
	public GameObject DownloadRoot;

	[Token(Token = "0x6016CA4")]
	[Address(RVA = "0x21E4184", Offset = "0x21E4184", VA = "0x21E4184")]
	public UILobbyWeaponRackItemView()
	{
	}

	[Token(Token = "0x6016CA5")]
	[Address(RVA = "0x21E418C", Offset = "0x21E418C", VA = "0x21E418C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CA6")]
	[Address(RVA = "0x21E48EC", Offset = "0x21E48EC", VA = "0x21E48EC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
