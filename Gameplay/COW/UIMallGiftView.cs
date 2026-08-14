using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003872")]
public class UIMallGiftView : UIBaseView
{
	[Token(Token = "0x4017369")]
	[FieldOffset(Offset = "0x14")]
	public Transform UIMallGift;

	[Token(Token = "0x401736A")]
	[FieldOffset(Offset = "0x18")]
	public UITable Table;

	[Token(Token = "0x401736B")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel SelectNum;

	[Token(Token = "0x401736C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Diamond;

	[Token(Token = "0x401736D")]
	[FieldOffset(Offset = "0x24")]
	public UILabel DiamondPrice;

	[Token(Token = "0x401736E")]
	[FieldOffset(Offset = "0x28")]
	public GameObject OR;

	[Token(Token = "0x401736F")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Gold;

	[Token(Token = "0x4017370")]
	[FieldOffset(Offset = "0x30")]
	public UILabel GoldPrice;

	[Token(Token = "0x4017371")]
	[FieldOffset(Offset = "0x34")]
	public GameObject SelectFriendPanel;

	[Token(Token = "0x4017372")]
	[FieldOffset(Offset = "0x38")]
	public UIInput SearchInput;

	[Token(Token = "0x4017373")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton SearchBtn;

	[Token(Token = "0x4017374")]
	[FieldOffset(Offset = "0x40")]
	public UIToggleButton FriendBtn;

	[Token(Token = "0x4017375")]
	[FieldOffset(Offset = "0x44")]
	public UIToggleButton ClanFriendBtn;

	[Token(Token = "0x4017376")]
	[FieldOffset(Offset = "0x48")]
	public UIToggleButton AllSelectBtn;

	[Token(Token = "0x4017377")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton NextBtn;

	[Token(Token = "0x4017378")]
	[FieldOffset(Offset = "0x50")]
	public UIEasyList Grid;

	[Token(Token = "0x4017379")]
	[FieldOffset(Offset = "0x54")]
	public UILabel Tips;

	[Token(Token = "0x401737A")]
	[FieldOffset(Offset = "0x58")]
	public UIButton RuleButton;

	[Token(Token = "0x401737B")]
	[FieldOffset(Offset = "0x5C")]
	public Transform SelectPanelTablePos;

	[Token(Token = "0x401737C")]
	[FieldOffset(Offset = "0x60")]
	public GameObject GiveGiftPanel;

	[Token(Token = "0x401737D")]
	[FieldOffset(Offset = "0x64")]
	public UILabel ReceiversNum;

	[Token(Token = "0x401737E")]
	[FieldOffset(Offset = "0x68")]
	public GameObject CallSignList;

	[Token(Token = "0x401737F")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject CallsingPanel;

	[Token(Token = "0x4017380")]
	[FieldOffset(Offset = "0x70")]
	public UIEasyList NameListGrid;

	[Token(Token = "0x4017381")]
	[FieldOffset(Offset = "0x74")]
	public UIGrid ReceiverCallsignGrid;

	[Token(Token = "0x4017382")]
	[FieldOffset(Offset = "0x78")]
	public UIButton ShowReceiverListBtn;

	[Token(Token = "0x4017383")]
	[FieldOffset(Offset = "0x7C")]
	public UIInput MessageInput;

	[Token(Token = "0x4017384")]
	[FieldOffset(Offset = "0x80")]
	public UIButton SendBtn;

	[Token(Token = "0x4017385")]
	[FieldOffset(Offset = "0x84")]
	public Transform GivePanelTablePos;

	[Token(Token = "0x6016D01")]
	[Address(RVA = "0x225E028", Offset = "0x225E028", VA = "0x225E028")]
	public UIMallGiftView()
	{
	}

	[Token(Token = "0x6016D02")]
	[Address(RVA = "0x225E030", Offset = "0x225E030", VA = "0x225E030", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D03")]
	[Address(RVA = "0x225EB8C", Offset = "0x225EB8C", VA = "0x225EB8C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
