using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003626")]
public class UIHudCSShopMysteryBoxOpenView : UIBaseView
{
	[Token(Token = "0x4015B02")]
	[FieldOffset(Offset = "0x14")]
	public UILabel title;

	[Token(Token = "0x4015B03")]
	[FieldOffset(Offset = "0x18")]
	public UIButton bgBtn;

	[Token(Token = "0x4015B04")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton helpBtn;

	[Token(Token = "0x4015B05")]
	[FieldOffset(Offset = "0x20")]
	public UILabel countdown;

	[Token(Token = "0x4015B06")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid grid;

	[Token(Token = "0x4015B07")]
	[FieldOffset(Offset = "0x28")]
	public UIToggleButtonGroup gridToggleGroup;

	[Token(Token = "0x4015B08")]
	[FieldOffset(Offset = "0x2C")]
	public UIHudCSMysteryBoxOptionItemView optionItem;

	[Token(Token = "0x4015B09")]
	[FieldOffset(Offset = "0x30")]
	public GameObject HL;

	[Token(Token = "0x4015B0A")]
	[FieldOffset(Offset = "0x34")]
	public UIButton confirmBtn;

	[Token(Token = "0x601661F")]
	[Address(RVA = "0x2142950", Offset = "0x2142950", VA = "0x2142950")]
	public UIHudCSShopMysteryBoxOpenView()
	{
	}

	[Token(Token = "0x6016620")]
	[Address(RVA = "0x2142958", Offset = "0x2142958", VA = "0x2142958", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016621")]
	[Address(RVA = "0x2142DF4", Offset = "0x2142DF4", VA = "0x2142DF4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
