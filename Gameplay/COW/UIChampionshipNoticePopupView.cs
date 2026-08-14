using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003416")]
public class UIChampionshipNoticePopupView : UIBaseView
{
	[Token(Token = "0x40141CE")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView CDNScrollView;

	[Token(Token = "0x40141CF")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid CDNGrid;

	[Token(Token = "0x40141D0")]
	[FieldOffset(Offset = "0x1C")]
	public UICenterOnChild UICenterOnChild;

	[Token(Token = "0x40141D1")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid DotGrid;

	[Token(Token = "0x40141D2")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnClose;

	[Token(Token = "0x40141D3")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnLeft;

	[Token(Token = "0x40141D4")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnRight;

	[Token(Token = "0x6015FF6")]
	[Address(RVA = "0x2835390", Offset = "0x2835390", VA = "0x2835390")]
	public UIChampionshipNoticePopupView()
	{
	}

	[Token(Token = "0x6015FF7")]
	[Address(RVA = "0x2835398", Offset = "0x2835398", VA = "0x2835398", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FF8")]
	[Address(RVA = "0x2835780", Offset = "0x2835780", VA = "0x2835780")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
