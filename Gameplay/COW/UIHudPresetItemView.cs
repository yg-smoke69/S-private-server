using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036EA")]
public class UIHudPresetItemView : UIBaseView
{
	[Token(Token = "0x4016307")]
	[FieldOffset(Offset = "0x14")]
	public UISprite primaryWeapon1;

	[Token(Token = "0x4016308")]
	[FieldOffset(Offset = "0x18")]
	public GameObject HL;

	[Token(Token = "0x4016309")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggleButton bgBtn;

	[Token(Token = "0x401630A")]
	[FieldOffset(Offset = "0x20")]
	public UISprite primaryWeapon2;

	[Token(Token = "0x401630B")]
	[FieldOffset(Offset = "0x24")]
	public UISprite meleeWeapon;

	[Token(Token = "0x401630C")]
	[FieldOffset(Offset = "0x28")]
	public UISprite SideWeapon1;

	[Token(Token = "0x401630D")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite SideWeapon2;

	[Token(Token = "0x6016869")]
	[Address(RVA = "0x1FC5D4C", Offset = "0x1FC5D4C", VA = "0x1FC5D4C")]
	public UIHudPresetItemView()
	{
	}

	[Token(Token = "0x601686A")]
	[Address(RVA = "0x1FC5D54", Offset = "0x1FC5D54", VA = "0x1FC5D54", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601686B")]
	[Address(RVA = "0x1FC6130", Offset = "0x1FC6130", VA = "0x1FC6130")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
