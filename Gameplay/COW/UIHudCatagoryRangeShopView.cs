using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003606")]
public class UIHudCatagoryRangeShopView : UIBaseView
{
	[Token(Token = "0x40159F2")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnQuit;

	[Token(Token = "0x40159F3")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnClose;

	[Token(Token = "0x40159F4")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel TitleLabel;

	[Token(Token = "0x40159F5")]
	[FieldOffset(Offset = "0x20")]
	public GameObject TopCatagory;

	[Token(Token = "0x40159F6")]
	[FieldOffset(Offset = "0x24")]
	public UIScrollView CatagoryScrollView;

	[Token(Token = "0x40159F7")]
	[FieldOffset(Offset = "0x28")]
	public UIEasyList Grid;

	[Token(Token = "0x40159F8")]
	[FieldOffset(Offset = "0x2C")]
	public UIScrollView ScrollView;

	[Token(Token = "0x40159F9")]
	[FieldOffset(Offset = "0x30")]
	public UIGrid ItemGrid;

	[Token(Token = "0x40159FA")]
	[FieldOffset(Offset = "0x34")]
	public UIScrollView MaxScrollView;

	[Token(Token = "0x40159FB")]
	[FieldOffset(Offset = "0x38")]
	public UIGrid MaxItemGrid;

	[Token(Token = "0x40159FC")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton purchaseBtn;

	[Token(Token = "0x40159FD")]
	[FieldOffset(Offset = "0x40")]
	public GameObject TokenInfo;

	[Token(Token = "0x40159FE")]
	[FieldOffset(Offset = "0x44")]
	public UISprite Icon;

	[Token(Token = "0x40159FF")]
	[FieldOffset(Offset = "0x48")]
	public UILabel TokenCnt;

	[Token(Token = "0x4015A00")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton HelpBtn;

	[Token(Token = "0x4015A01")]
	[FieldOffset(Offset = "0x50")]
	public UIButton Mask;

	[Token(Token = "0x60165C0")]
	[Address(RVA = "0x2147914", Offset = "0x2147914", VA = "0x2147914")]
	public UIHudCatagoryRangeShopView()
	{
	}

	[Token(Token = "0x60165C1")]
	[Address(RVA = "0x214791C", Offset = "0x214791C", VA = "0x214791C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60165C2")]
	[Address(RVA = "0x214804C", Offset = "0x214804C", VA = "0x214804C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
