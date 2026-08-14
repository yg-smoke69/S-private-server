using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003676")]
public class UIHudInGameShopCategoryView : UIBaseView
{
	[Token(Token = "0x4015DD5")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget widget;

	[Token(Token = "0x4015DD6")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid ItemsGrid;

	[Token(Token = "0x4015DD7")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggleButtonGroup toggleGroup;

	[Token(Token = "0x4015DD8")]
	[FieldOffset(Offset = "0x20")]
	public UILabel CategoryName;

	[Token(Token = "0x601670F")]
	[Address(RVA = "0x229C0E8", Offset = "0x229C0E8", VA = "0x229C0E8")]
	public UIHudInGameShopCategoryView()
	{
	}

	[Token(Token = "0x6016710")]
	[Address(RVA = "0x229C0F0", Offset = "0x229C0F0", VA = "0x229C0F0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016711")]
	[Address(RVA = "0x229C3B8", Offset = "0x229C3B8", VA = "0x229C3B8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
