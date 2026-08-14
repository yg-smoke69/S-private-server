using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036FB")]
public class UIHUDRangeShopView : UIBaseView
{
	[Token(Token = "0x401635B")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnQuit;

	[Token(Token = "0x401635C")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnClose;

	[Token(Token = "0x401635D")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject TitleLabel;

	[Token(Token = "0x401635E")]
	[FieldOffset(Offset = "0x20")]
	public UIScrollView ScrollView;

	[Token(Token = "0x401635F")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid ItemGrid;

	[Token(Token = "0x4016360")]
	[FieldOffset(Offset = "0x28")]
	public UIButton purchaseBtn;

	[Token(Token = "0x4016361")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton Mask;

	[Token(Token = "0x601689C")]
	[Address(RVA = "0x1687094", Offset = "0x1687094", VA = "0x1687094")]
	public UIHUDRangeShopView()
	{
	}

	[Token(Token = "0x601689D")]
	[Address(RVA = "0x168709C", Offset = "0x168709C", VA = "0x168709C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601689E")]
	[Address(RVA = "0x1687478", Offset = "0x1687478", VA = "0x1687478")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
