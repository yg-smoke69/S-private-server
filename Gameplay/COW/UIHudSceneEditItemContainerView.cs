using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003730")]
public class UIHudSceneEditItemContainerView : UIBaseView
{
	[Token(Token = "0x40164DA")]
	[FieldOffset(Offset = "0x14")]
	public UISprite ItemSprite;

	[Token(Token = "0x40164DB")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Highlight;

	[Token(Token = "0x40164DC")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton ItemButton;

	[Token(Token = "0x40164DD")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ForbiddenSprite;

	[Token(Token = "0x40164DE")]
	[FieldOffset(Offset = "0x24")]
	public GameObject NewObj;

	[Token(Token = "0x40164DF")]
	[FieldOffset(Offset = "0x28")]
	public GameObject MustModeSprite;

	[Token(Token = "0x601693B")]
	[Address(RVA = "0x24D65BC", Offset = "0x24D65BC", VA = "0x24D65BC")]
	public UIHudSceneEditItemContainerView()
	{
	}

	[Token(Token = "0x601693C")]
	[Address(RVA = "0x24D65C4", Offset = "0x24D65C4", VA = "0x24D65C4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601693D")]
	[Address(RVA = "0x24D691C", Offset = "0x24D691C", VA = "0x24D691C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
