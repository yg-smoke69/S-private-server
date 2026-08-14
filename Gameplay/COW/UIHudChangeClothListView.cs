using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200360A")]
public class UIHudChangeClothListView : UIBaseView
{
	[Token(Token = "0x4015A07")]
	[FieldOffset(Offset = "0x14")]
	public UISprite bg;

	[Token(Token = "0x4015A08")]
	[FieldOffset(Offset = "0x18")]
	public UIButton CloseBtn;

	[Token(Token = "0x4015A09")]
	[FieldOffset(Offset = "0x1C")]
	public UIInput SearchInput;

	[Token(Token = "0x4015A0A")]
	[FieldOffset(Offset = "0x20")]
	public UIButton _1PViewBtn;

	[Token(Token = "0x4015A0B")]
	[FieldOffset(Offset = "0x24")]
	public UIButton _3PViewBtn;

	[Token(Token = "0x4015A0C")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid Grid;

	[Token(Token = "0x4015A0D")]
	[FieldOffset(Offset = "0x2C")]
	public UIHudClothItemView ClothItem;

	[Token(Token = "0x60165CC")]
	[Address(RVA = "0x214ABD0", Offset = "0x214ABD0", VA = "0x214ABD0")]
	public UIHudChangeClothListView()
	{
	}

	[Token(Token = "0x60165CD")]
	[Address(RVA = "0x214ABD8", Offset = "0x214ABD8", VA = "0x214ABD8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60165CE")]
	[Address(RVA = "0x214AFC0", Offset = "0x214AFC0", VA = "0x214AFC0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
