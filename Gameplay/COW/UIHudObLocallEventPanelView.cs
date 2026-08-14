using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036CA")]
public class UIHudObLocallEventPanelView : UIBaseView
{
	[Token(Token = "0x40161CA")]
	[FieldOffset(Offset = "0x14")]
	public TweenAlpha tweenAlpha;

	[Token(Token = "0x40161CB")]
	[FieldOffset(Offset = "0x18")]
	public TweenPosition tweenPos;

	[Token(Token = "0x40161CC")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject eventContainer;

	[Token(Token = "0x40161CD")]
	[FieldOffset(Offset = "0x20")]
	public GameObject PCbg;

	[Token(Token = "0x40161CE")]
	[FieldOffset(Offset = "0x24")]
	public GameObject bg;

	[Token(Token = "0x40161CF")]
	[FieldOffset(Offset = "0x28")]
	public UILabel description;

	[Token(Token = "0x40161D0")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel countDownLabel;

	[Token(Token = "0x40161D1")]
	[FieldOffset(Offset = "0x30")]
	public UIScrollView Scrollview;

	[Token(Token = "0x40161D2")]
	[FieldOffset(Offset = "0x34")]
	public UIGrid eventsGrid;

	[Token(Token = "0x40161D3")]
	[FieldOffset(Offset = "0x38")]
	public UIToggleButtonGroup toggleBtnGroup;

	[Token(Token = "0x40161D4")]
	[FieldOffset(Offset = "0x3C")]
	public UIToggleButton eToggle;

	[Token(Token = "0x40161D5")]
	[FieldOffset(Offset = "0x40")]
	public UIButton btnCloseRight;

	[Token(Token = "0x40161D6")]
	[FieldOffset(Offset = "0x44")]
	public UIButton btnCloseLeft;

	[Token(Token = "0x40161D7")]
	[FieldOffset(Offset = "0x48")]
	public GameObject bottomBtns;

	[Token(Token = "0x40161D8")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject PCbottomBtns;

	[Token(Token = "0x601680B")]
	[Address(RVA = "0x1830218", Offset = "0x1830218", VA = "0x1830218")]
	public UIHudObLocallEventPanelView()
	{
	}

	[Token(Token = "0x601680C")]
	[Address(RVA = "0x1830220", Offset = "0x1830220", VA = "0x1830220", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601680D")]
	[Address(RVA = "0x18308CC", Offset = "0x18308CC", VA = "0x18308CC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
