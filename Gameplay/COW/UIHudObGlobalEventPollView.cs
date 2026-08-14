using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036C8")]
public class UIHudObGlobalEventPollView : UIBaseView
{
	[Token(Token = "0x40161B7")]
	[FieldOffset(Offset = "0x14")]
	public TweenPosition tweenPos;

	[Token(Token = "0x40161B8")]
	[FieldOffset(Offset = "0x18")]
	public GameObject PollContainer;

	[Token(Token = "0x40161B9")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel descMaxCount;

	[Token(Token = "0x40161BA")]
	[FieldOffset(Offset = "0x20")]
	public UILabel descEffectTime;

	[Token(Token = "0x40161BB")]
	[FieldOffset(Offset = "0x24")]
	public UIScrollView pollScrollview;

	[Token(Token = "0x40161BC")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid checkBoxGrid;

	[Token(Token = "0x40161BD")]
	[FieldOffset(Offset = "0x2C")]
	public UICheckBoxButtonGroup checkBoxGroup;

	[Token(Token = "0x40161BE")]
	[FieldOffset(Offset = "0x30")]
	public UICheckboxButton eventCheckBoxBtn;

	[Token(Token = "0x40161BF")]
	[FieldOffset(Offset = "0x34")]
	public UIGrid toggleGrid;

	[Token(Token = "0x40161C0")]
	[FieldOffset(Offset = "0x38")]
	public UIToggleButtonGroup pollToggleGroup;

	[Token(Token = "0x40161C1")]
	[FieldOffset(Offset = "0x3C")]
	public UIToggleButton eventToggleBtn;

	[Token(Token = "0x40161C2")]
	[FieldOffset(Offset = "0x40")]
	public UIButton btnConfirm;

	[Token(Token = "0x40161C3")]
	[FieldOffset(Offset = "0x44")]
	public GameObject ResultContainer;

	[Token(Token = "0x40161C4")]
	[FieldOffset(Offset = "0x48")]
	public UIScrollView resultScrollview;

	[Token(Token = "0x40161C5")]
	[FieldOffset(Offset = "0x4C")]
	public UIGrid resultGrid;

	[Token(Token = "0x40161C6")]
	[FieldOffset(Offset = "0x50")]
	public GameObject resultItem;

	[Token(Token = "0x40161C7")]
	[FieldOffset(Offset = "0x54")]
	public UIButton btnClose;

	[Token(Token = "0x40161C8")]
	[FieldOffset(Offset = "0x58")]
	public UIButton btnClosePC;

	[Token(Token = "0x6016805")]
	[Address(RVA = "0x182CA58", Offset = "0x182CA58", VA = "0x182CA58")]
	public UIHudObGlobalEventPollView()
	{
	}

	[Token(Token = "0x6016806")]
	[Address(RVA = "0x182CA60", Offset = "0x182CA60", VA = "0x182CA60", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016807")]
	[Address(RVA = "0x182D244", Offset = "0x182D244", VA = "0x182D244")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
