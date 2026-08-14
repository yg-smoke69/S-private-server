using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A6E")]
public class UIWeaponItemView : UIBaseView
{
	[Token(Token = "0x4018C59")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemButton;

	[Token(Token = "0x4018C5A")]
	[FieldOffset(Offset = "0x18")]
	public UISprite SpriteQualityPlus;

	[Token(Token = "0x4018C5B")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Quality;

	[Token(Token = "0x4018C5C")]
	[FieldOffset(Offset = "0x20")]
	public UISprite QualityBG;

	[Token(Token = "0x4018C5D")]
	[FieldOffset(Offset = "0x24")]
	public GameObject gray;

	[Token(Token = "0x4018C5E")]
	[FieldOffset(Offset = "0x28")]
	public GameObject effectBg;

	[Token(Token = "0x4018C5F")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite VehicleSprite;

	[Token(Token = "0x4018C60")]
	[FieldOffset(Offset = "0x30")]
	public UISprite WeaponSprite;

	[Token(Token = "0x4018C61")]
	[FieldOffset(Offset = "0x34")]
	public GameObject TipsGO;

	[Token(Token = "0x4018C62")]
	[FieldOffset(Offset = "0x38")]
	public UILabel TagLabel;

	[Token(Token = "0x4018C63")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject HL;

	[Token(Token = "0x4018C64")]
	[FieldOffset(Offset = "0x40")]
	public GameObject WL;

	[Token(Token = "0x4018C65")]
	[FieldOffset(Offset = "0x44")]
	public UISprite stateSprite;

	[Token(Token = "0x4018C66")]
	[FieldOffset(Offset = "0x48")]
	public UILabel state;

	[Token(Token = "0x4018C67")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite validSprite;

	[Token(Token = "0x4018C68")]
	[FieldOffset(Offset = "0x50")]
	public UILabel valid;

	[Token(Token = "0x4018C69")]
	[FieldOffset(Offset = "0x54")]
	public UISprite descSprite;

	[Token(Token = "0x4018C6A")]
	[FieldOffset(Offset = "0x58")]
	public UILabel description;

	[Token(Token = "0x4018C6B")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite RankIcon;

	[Token(Token = "0x4018C6C")]
	[FieldOffset(Offset = "0x60")]
	public UISprite Download;

	[Token(Token = "0x4018C6D")]
	[FieldOffset(Offset = "0x64")]
	public UISprite SpriteOrangeQualityPlus;

	[Token(Token = "0x60172F0")]
	[Address(RVA = "0x101F444", Offset = "0x101F444", VA = "0x101F444")]
	public UIWeaponItemView()
	{
	}

	[Token(Token = "0x60172F1")]
	[Address(RVA = "0x101F44C", Offset = "0x101F44C", VA = "0x101F44C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172F2")]
	[Address(RVA = "0x101FD38", Offset = "0x101FD38", VA = "0x101FD38")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
