using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003531")]
public class UIFeedPetView : UIBaseView
{
	[Token(Token = "0x4015034")]
	[FieldOffset(Offset = "0x14")]
	public GameObject line;

	[Token(Token = "0x4015035")]
	[FieldOffset(Offset = "0x18")]
	public UIButton CloseBtn;

	[Token(Token = "0x4015036")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite ItemIcon;

	[Token(Token = "0x4015037")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ItemNameLabel;

	[Token(Token = "0x4015038")]
	[FieldOffset(Offset = "0x24")]
	public UILabel FeedPetLabel;

	[Token(Token = "0x4015039")]
	[FieldOffset(Offset = "0x28")]
	public UISprite quality;

	[Token(Token = "0x401503A")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton PurchaseBtn;

	[Token(Token = "0x401503B")]
	[FieldOffset(Offset = "0x30")]
	public GameObject GoldIcon;

	[Token(Token = "0x401503C")]
	[FieldOffset(Offset = "0x34")]
	public GameObject DiamondIcon;

	[Token(Token = "0x401503D")]
	[FieldOffset(Offset = "0x38")]
	public UILabel FeedPetCountLabel;

	[Token(Token = "0x401503E")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite MoneyBgSprite;

	[Token(Token = "0x401503F")]
	[FieldOffset(Offset = "0x40")]
	public GameObject ModifyNumContainer;

	[Token(Token = "0x4015040")]
	[FieldOffset(Offset = "0x44")]
	public UIButton PlusBtn;

	[Token(Token = "0x4015041")]
	[FieldOffset(Offset = "0x48")]
	public UILabel CountLabel;

	[Token(Token = "0x4015042")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton MinusBtn;

	[Token(Token = "0x4015043")]
	[FieldOffset(Offset = "0x50")]
	public UIButton MaxBtn;

	[Token(Token = "0x4015044")]
	[FieldOffset(Offset = "0x54")]
	public UILabel Label;

	[Token(Token = "0x6016343")]
	[Address(RVA = "0x1DBD2EC", Offset = "0x1DBD2EC", VA = "0x1DBD2EC")]
	public UIFeedPetView()
	{
	}

	[Token(Token = "0x6016344")]
	[Address(RVA = "0x1DBD2F4", Offset = "0x1DBD2F4", VA = "0x1DBD2F4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016345")]
	[Address(RVA = "0x1DBDA6C", Offset = "0x1DBDA6C", VA = "0x1DBDA6C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
