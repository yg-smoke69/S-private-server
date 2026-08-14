using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033FF")]
public class UIBigLuckyBagListView : UIBaseView
{
	[Token(Token = "0x401405A")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget widget;

	[Token(Token = "0x401405B")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LuckyBagInfoMessage;

	[Token(Token = "0x401405C")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid Grid;

	[Token(Token = "0x401405D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SelectedBg;

	[Token(Token = "0x6015FB1")]
	[Address(RVA = "0x10C2B7C", Offset = "0x10C2B7C", VA = "0x10C2B7C")]
	public UIBigLuckyBagListView()
	{
	}

	[Token(Token = "0x6015FB2")]
	[Address(RVA = "0x10C2B84", Offset = "0x10C2B84", VA = "0x10C2B84", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FB3")]
	[Address(RVA = "0x10C2E40", Offset = "0x10C2E40", VA = "0x10C2E40")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
