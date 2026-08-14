using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003611")]
public class UIHudCombineWeaponView : UIBaseView
{
	[Token(Token = "0x4015A27")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnCombine;

	[Token(Token = "0x4015A28")]
	[FieldOffset(Offset = "0x18")]
	public GameObject SpriteCombine;

	[Token(Token = "0x4015A29")]
	[FieldOffset(Offset = "0x1C")]
	public Transform iconEmotion;

	[Token(Token = "0x4015A2A")]
	[FieldOffset(Offset = "0x20")]
	public UISprite iconWidget;

	[Token(Token = "0x4015A2B")]
	[FieldOffset(Offset = "0x24")]
	public GameObject SpriteDissolve;

	[Token(Token = "0x60165E2")]
	[Address(RVA = "0x135D774", Offset = "0x135D774", VA = "0x135D774")]
	public UIHudCombineWeaponView()
	{
	}

	[Token(Token = "0x60165E3")]
	[Address(RVA = "0x135D77C", Offset = "0x135D77C", VA = "0x135D77C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60165E4")]
	[Address(RVA = "0x135DA64", Offset = "0x135DA64", VA = "0x135DA64")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
