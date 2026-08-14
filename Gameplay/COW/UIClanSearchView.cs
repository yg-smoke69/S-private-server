using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003458")]
public class UIClanSearchView : UIBaseView
{
	[Token(Token = "0x4014509")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Content;

	[Token(Token = "0x401450A")]
	[FieldOffset(Offset = "0x18")]
	public UIButton LeftBtn;

	[Token(Token = "0x401450B")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite LeftSprite;

	[Token(Token = "0x401450C")]
	[FieldOffset(Offset = "0x20")]
	public UIButton RightBtn;

	[Token(Token = "0x401450D")]
	[FieldOffset(Offset = "0x24")]
	public UISprite RightSprite;

	[Token(Token = "0x401450E")]
	[FieldOffset(Offset = "0x28")]
	public UILabel SlogonLabel;

	[Token(Token = "0x401450F")]
	[FieldOffset(Offset = "0x2C")]
	public UIScrollView ListScrollView;

	[Token(Token = "0x4014510")]
	[FieldOffset(Offset = "0x30")]
	public UIEasyList ListGrid;

	[Token(Token = "0x4014511")]
	[FieldOffset(Offset = "0x34")]
	public UILabel Result;

	[Token(Token = "0x4014512")]
	[FieldOffset(Offset = "0x38")]
	public GameObject SearchBarContainer;

	[Token(Token = "0x4014513")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton RefreshBtn;

	[Token(Token = "0x4014514")]
	[FieldOffset(Offset = "0x40")]
	public GameObject CDBg;

	[Token(Token = "0x4014515")]
	[FieldOffset(Offset = "0x44")]
	public UICountDownLabel CountDownTxt;

	[Token(Token = "0x4014516")]
	[FieldOffset(Offset = "0x48")]
	public GameObject CDSprite;

	[Token(Token = "0x4014517")]
	[FieldOffset(Offset = "0x4C")]
	public UIInput SearchInput;

	[Token(Token = "0x4014518")]
	[FieldOffset(Offset = "0x50")]
	public UIButton SearchBtn;

	[Token(Token = "0x4014519")]
	[FieldOffset(Offset = "0x54")]
	public UISprite SearchBtnSprite;

	[Token(Token = "0x401451A")]
	[FieldOffset(Offset = "0x58")]
	public UIButton ClearBtn;

	[Token(Token = "0x401451B")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton FilterBtn;

	[Token(Token = "0x401451C")]
	[FieldOffset(Offset = "0x60")]
	public UILabel FilterCDLabel;

	[Token(Token = "0x401451D")]
	[FieldOffset(Offset = "0x64")]
	public UISprite FilterBG;

	[Token(Token = "0x401451E")]
	[FieldOffset(Offset = "0x68")]
	public UILabel FilterLabel;

	[Token(Token = "0x401451F")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject FilterIcon;

	[Token(Token = "0x4014520")]
	[FieldOffset(Offset = "0x70")]
	public UIButton ClanCreate;

	[Token(Token = "0x60160BC")]
	[Address(RVA = "0x2B49618", Offset = "0x2B49618", VA = "0x2B49618")]
	public UIClanSearchView()
	{
	}

	[Token(Token = "0x60160BD")]
	[Address(RVA = "0x2B49620", Offset = "0x2B49620", VA = "0x2B49620", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160BE")]
	[Address(RVA = "0x2B4A02C", Offset = "0x2B4A02C", VA = "0x2B4A02C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
