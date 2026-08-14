using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038F8")]
public class UIPaymentTabItemView : UIBaseView
{
	[Token(Token = "0x4017AD0")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Button;

	[Token(Token = "0x4017AD1")]
	[FieldOffset(Offset = "0x18")]
	public UISprite NoteSprite;

	[Token(Token = "0x4017AD2")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel NoteLabel;

	[Token(Token = "0x4017AD3")]
	[FieldOffset(Offset = "0x20")]
	public UISprite RedDot;

	[Token(Token = "0x4017AD4")]
	[FieldOffset(Offset = "0x24")]
	public UILabel NormalLabel;

	[Token(Token = "0x4017AD5")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid SubTypeGrid;

	[Token(Token = "0x4017AD6")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject SubTabArrow;

	[Token(Token = "0x4017AD7")]
	[FieldOffset(Offset = "0x30")]
	public UISprite ArrowDown;

	[Token(Token = "0x4017AD8")]
	[FieldOffset(Offset = "0x34")]
	public UISprite ArrowUp;

	[Token(Token = "0x4017AD9")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Selected;

	[Token(Token = "0x4017ADA")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite SelectedSprite;

	[Token(Token = "0x4017ADB")]
	[FieldOffset(Offset = "0x40")]
	public UILabel SelectedLabel;

	[Token(Token = "0x4017ADC")]
	[FieldOffset(Offset = "0x44")]
	public GameObject UnFolded;

	[Token(Token = "0x4017ADD")]
	[FieldOffset(Offset = "0x48")]
	public UILabel UnFoldedLabel;

	[Token(Token = "0x4017ADE")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite SubTabBg;

	[Token(Token = "0x4017ADF")]
	[FieldOffset(Offset = "0x50")]
	public Animation Anim;

	[Token(Token = "0x6016E91")]
	[Address(RVA = "0x23DB950", Offset = "0x23DB950", VA = "0x23DB950")]
	public UIPaymentTabItemView()
	{
	}

	[Token(Token = "0x6016E92")]
	[Address(RVA = "0x23DB958", Offset = "0x23DB958", VA = "0x23DB958", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E93")]
	[Address(RVA = "0x23DC07C", Offset = "0x23DC07C", VA = "0x23DC07C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
