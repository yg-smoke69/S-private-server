using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038D3")]
public class UINewVaultPortraitBgItemView : UIBaseView
{
	[Token(Token = "0x40178BB")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x40178BC")]
	[FieldOffset(Offset = "0x18")]
	public UISprite stateSprite;

	[Token(Token = "0x40178BD")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel state;

	[Token(Token = "0x40178BE")]
	[FieldOffset(Offset = "0x20")]
	public UISprite validSprite;

	[Token(Token = "0x40178BF")]
	[FieldOffset(Offset = "0x24")]
	public UILabel valid;

	[Token(Token = "0x40178C0")]
	[FieldOffset(Offset = "0x28")]
	public UISprite descSprite;

	[Token(Token = "0x40178C1")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel description;

	[Token(Token = "0x40178C2")]
	[FieldOffset(Offset = "0x30")]
	public UISprite RankIcon;

	[Token(Token = "0x40178C3")]
	[FieldOffset(Offset = "0x34")]
	public UISprite minibgSprite;

	[Token(Token = "0x40178C4")]
	[FieldOffset(Offset = "0x38")]
	public GameObject HL;

	[Token(Token = "0x40178C5")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject WL;

	[Token(Token = "0x40178C6")]
	[FieldOffset(Offset = "0x40")]
	public GameObject TipsGO;

	[Token(Token = "0x40178C7")]
	[FieldOffset(Offset = "0x44")]
	public UILabel TagLabel;

	[Token(Token = "0x40178C8")]
	[FieldOffset(Offset = "0x48")]
	public GameObject img;

	[Token(Token = "0x40178C9")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject fakeBgSprite;

	[Token(Token = "0x40178CA")]
	[FieldOffset(Offset = "0x50")]
	public GameObject gray;

	[Token(Token = "0x40178CB")]
	[FieldOffset(Offset = "0x54")]
	public UIEffectSprite bgSprite;

	[Token(Token = "0x40178CC")]
	[FieldOffset(Offset = "0x58")]
	public GameObject Descargar;

	[Token(Token = "0x6016E22")]
	[Address(RVA = "0x26CA3F4", Offset = "0x26CA3F4", VA = "0x26CA3F4")]
	public UINewVaultPortraitBgItemView()
	{
	}

	[Token(Token = "0x6016E23")]
	[Address(RVA = "0x26CA3FC", Offset = "0x26CA3FC", VA = "0x26CA3FC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E24")]
	[Address(RVA = "0x26CABB0", Offset = "0x26CABB0", VA = "0x26CABB0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
