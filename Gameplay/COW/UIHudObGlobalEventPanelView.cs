using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036C6")]
public class UIHudObGlobalEventPanelView : UIBaseView
{
	[Token(Token = "0x4016184")]
	[FieldOffset(Offset = "0x14")]
	public TweenPosition tweenPos;

	[Token(Token = "0x4016185")]
	[FieldOffset(Offset = "0x18")]
	public UILabel description;

	[Token(Token = "0x4016186")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView Scrollview;

	[Token(Token = "0x4016187")]
	[FieldOffset(Offset = "0x20")]
	public UITable table;

	[Token(Token = "0x4016188")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid eventsGrid;

	[Token(Token = "0x4016189")]
	[FieldOffset(Offset = "0x28")]
	public UICheckBoxButtonGroup checkBoxButtonGroup;

	[Token(Token = "0x401618A")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject eventItem;

	[Token(Token = "0x401618B")]
	[FieldOffset(Offset = "0x30")]
	public UICheckboxButton eventBtn;

	[Token(Token = "0x401618C")]
	[FieldOffset(Offset = "0x34")]
	public UICheckboxButton eventBtn2;

	[Token(Token = "0x401618D")]
	[FieldOffset(Offset = "0x38")]
	public UICheckboxButton pollcheckBox;

	[Token(Token = "0x401618E")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton tipsBtn;

	[Token(Token = "0x401618F")]
	[FieldOffset(Offset = "0x40")]
	public UITable poll;

	[Token(Token = "0x4016190")]
	[FieldOffset(Offset = "0x44")]
	public GameObject pollToggles;

	[Token(Token = "0x4016191")]
	[FieldOffset(Offset = "0x48")]
	public UIToggleButton singleToggle;

	[Token(Token = "0x4016192")]
	[FieldOffset(Offset = "0x4C")]
	public UIToggleButton multipleToggle;

	[Token(Token = "0x4016193")]
	[FieldOffset(Offset = "0x50")]
	public GameObject a2multipleOptionsContainer;

	[Token(Token = "0x4016194")]
	[FieldOffset(Offset = "0x54")]
	public UIToggleButton multiOption1;

	[Token(Token = "0x4016195")]
	[FieldOffset(Offset = "0x58")]
	public UILabel multiOption1Label;

	[Token(Token = "0x4016196")]
	[FieldOffset(Offset = "0x5C")]
	public UIToggleButton multiOption2;

	[Token(Token = "0x4016197")]
	[FieldOffset(Offset = "0x60")]
	public UILabel multiOption2Label;

	[Token(Token = "0x4016198")]
	[FieldOffset(Offset = "0x64")]
	public UILabel countdown;

	[Token(Token = "0x4016199")]
	[FieldOffset(Offset = "0x68")]
	public UIToggleButton time1;

	[Token(Token = "0x401619A")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel time1Label;

	[Token(Token = "0x401619B")]
	[FieldOffset(Offset = "0x70")]
	public UIToggleButton time2;

	[Token(Token = "0x401619C")]
	[FieldOffset(Offset = "0x74")]
	public UILabel time2Label;

	[Token(Token = "0x401619D")]
	[FieldOffset(Offset = "0x78")]
	public UILabel noPollDescription;

	[Token(Token = "0x401619E")]
	[FieldOffset(Offset = "0x7C")]
	public UIButton btnConfirm;

	[Token(Token = "0x401619F")]
	[FieldOffset(Offset = "0x80")]
	public UIButton btnClose;

	[Token(Token = "0x40161A0")]
	[FieldOffset(Offset = "0x84")]
	public UIButton btnClosePC;

	[Token(Token = "0x40161A1")]
	[FieldOffset(Offset = "0x88")]
	public UILabel executeCD;

	[Token(Token = "0x40161A2")]
	[FieldOffset(Offset = "0x8C")]
	public UIToggleButtonGroup JumpToggles;

	[Token(Token = "0x40161A3")]
	[FieldOffset(Offset = "0x90")]
	public UIToggleButtonGroup MoveToggles;

	[Token(Token = "0x40161A4")]
	[FieldOffset(Offset = "0x94")]
	public UIToggleButton TwoToggle;

	[Token(Token = "0x40161A5")]
	[FieldOffset(Offset = "0x98")]
	public UILabel TwoLabel;

	[Token(Token = "0x40161A6")]
	[FieldOffset(Offset = "0x9C")]
	public UIToggleButton FourToggle;

	[Token(Token = "0x40161A7")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel FourLabel;

	[Token(Token = "0x40161A8")]
	[FieldOffset(Offset = "0xA4")]
	public UIToggleButton MoveOneToggle;

	[Token(Token = "0x40161A9")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel MoveOneLabel;

	[Token(Token = "0x40161AA")]
	[FieldOffset(Offset = "0xAC")]
	public UIToggleButton MoveTwoToggle;

	[Token(Token = "0x40161AB")]
	[FieldOffset(Offset = "0xB0")]
	public UILabel MoveTwoLabel;

	[Token(Token = "0x40161AC")]
	[FieldOffset(Offset = "0xB4")]
	public UIToggleButton MoveThreeToggle;

	[Token(Token = "0x40161AD")]
	[FieldOffset(Offset = "0xB8")]
	public UILabel MoveThreeLabel;

	[Token(Token = "0x40161AE")]
	[FieldOffset(Offset = "0xBC")]
	public UILabel JumpLabel;

	[Token(Token = "0x40161AF")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel MoveLabel;

	[Token(Token = "0x40161B0")]
	[FieldOffset(Offset = "0xC4")]
	public UICheckboxButton JumpCheckBox;

	[Token(Token = "0x40161B1")]
	[FieldOffset(Offset = "0xC8")]
	public UICheckboxButton MoveCheckBox;

	[Token(Token = "0x40161B2")]
	[FieldOffset(Offset = "0xCC")]
	public GameObject JumpContainer2;

	[Token(Token = "0x40161B3")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject MoveContainer2;

	[Token(Token = "0x60167FF")]
	[Address(RVA = "0x1F63000", Offset = "0x1F63000", VA = "0x1F63000")]
	public UIHudObGlobalEventPanelView()
	{
	}

	[Token(Token = "0x6016800")]
	[Address(RVA = "0x1F63008", Offset = "0x1F63008", VA = "0x1F63008", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016801")]
	[Address(RVA = "0x1F64314", Offset = "0x1F64314", VA = "0x1F64314")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
