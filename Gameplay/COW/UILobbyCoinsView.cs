using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200383C")]
public class UILobbyCoinsView : UIBaseView
{
	[Token(Token = "0x4016F0D")]
	[FieldOffset(Offset = "0x14")]
	public UIButton btnCoin;

	[Token(Token = "0x4016F0E")]
	[FieldOffset(Offset = "0x18")]
	public UILabel coinCount;

	[Token(Token = "0x4016F0F")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel addCoinCount;

	[Token(Token = "0x4016F10")]
	[FieldOffset(Offset = "0x20")]
	public UILabel diamondCount;

	[Token(Token = "0x4016F11")]
	[FieldOffset(Offset = "0x24")]
	public UIButton btnDiamond;

	[Token(Token = "0x4016F12")]
	[FieldOffset(Offset = "0x28")]
	public UISprite PaymentNewRedDotSprite;

	[Token(Token = "0x4016F13")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton btnEnergy;

	[Token(Token = "0x4016F14")]
	[FieldOffset(Offset = "0x30")]
	public UILabel energyCount;

	[Token(Token = "0x4016F15")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnRebateCard;

	[Token(Token = "0x4016F16")]
	[FieldOffset(Offset = "0x38")]
	public GameObject RebateCardSprites;

	[Token(Token = "0x4016F17")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject RedeemableEffect;

	[Token(Token = "0x4016F18")]
	[FieldOffset(Offset = "0x40")]
	public UISprite RedDotSprite;

	[Token(Token = "0x4016F19")]
	[FieldOffset(Offset = "0x44")]
	public UISprite WeekCardIcon;

	[Token(Token = "0x4016F1A")]
	[FieldOffset(Offset = "0x48")]
	public GameObject flowLight_W;

	[Token(Token = "0x4016F1B")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite MonthCardIcon;

	[Token(Token = "0x4016F1C")]
	[FieldOffset(Offset = "0x50")]
	public GameObject flowLight_M;

	[Token(Token = "0x4016F1D")]
	[FieldOffset(Offset = "0x54")]
	public UISprite BothCardsIcon;

	[Token(Token = "0x4016F1E")]
	[FieldOffset(Offset = "0x58")]
	public GameObject flowLight_S;

	[Token(Token = "0x4016F1F")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite NoCardIcon;

	[Token(Token = "0x4016F20")]
	[FieldOffset(Offset = "0x60")]
	public GameObject flowLight_Null;

	[Token(Token = "0x4016F21")]
	[FieldOffset(Offset = "0x64")]
	public GameObject RebateCardNewSprite;

	[Token(Token = "0x4016F22")]
	[FieldOffset(Offset = "0x68")]
	public GameObject RebateCardEffect;

	[Token(Token = "0x6016C5F")]
	[Address(RVA = "0xD9C7C4", Offset = "0xD9C7C4", VA = "0xD9C7C4")]
	public UILobbyCoinsView()
	{
	}

	[Token(Token = "0x6016C60")]
	[Address(RVA = "0xD9C7CC", Offset = "0xD9C7CC", VA = "0xD9C7CC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C61")]
	[Address(RVA = "0xD9D0F4", Offset = "0xD9D0F4", VA = "0xD9D0F4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
