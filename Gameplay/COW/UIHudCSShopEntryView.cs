using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003625")]
public class UIHudCSShopEntryView : UIBaseView
{
	[Token(Token = "0x4015AFE")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnShop;

	[Token(Token = "0x4015AFF")]
	[FieldOffset(Offset = "0x18")]
	public UISprite SpriteBg;

	[Token(Token = "0x4015B00")]
	[FieldOffset(Offset = "0x1C")]
	public ParticleSystem FlashEffect;

	[Token(Token = "0x4015B01")]
	[FieldOffset(Offset = "0x20")]
	public GameObject AskPurchaseTip;

	[Token(Token = "0x601661C")]
	[Address(RVA = "0x2140FC4", Offset = "0x2140FC4", VA = "0x2140FC4")]
	public UIHudCSShopEntryView()
	{
	}

	[Token(Token = "0x601661D")]
	[Address(RVA = "0x2140FCC", Offset = "0x2140FCC", VA = "0x2140FCC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601661E")]
	[Address(RVA = "0x2141288", Offset = "0x2141288", VA = "0x2141288")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
