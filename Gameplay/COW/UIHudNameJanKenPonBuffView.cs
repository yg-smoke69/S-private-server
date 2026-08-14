using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036BC")]
public class UIHudNameJanKenPonBuffView : UIBaseView
{
	[Token(Token = "0x40160FC")]
	[FieldOffset(Offset = "0x14")]
	public GameObject RockSprite;

	[Token(Token = "0x40160FD")]
	[FieldOffset(Offset = "0x18")]
	public GameObject PaperSprite;

	[Token(Token = "0x40160FE")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ScissorsSprite;

	[Token(Token = "0x60167E1")]
	[Address(RVA = "0x1F50B54", Offset = "0x1F50B54", VA = "0x1F50B54")]
	public UIHudNameJanKenPonBuffView()
	{
	}

	[Token(Token = "0x60167E2")]
	[Address(RVA = "0x1F50B5C", Offset = "0x1F50B5C", VA = "0x1F50B5C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167E3")]
	[Address(RVA = "0x1F50DA0", Offset = "0x1F50DA0", VA = "0x1F50DA0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
