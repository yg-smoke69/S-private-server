using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200357F")]
public class UIGachaLegendaryTempBagPackWndView : UIBaseView
{
	[Token(Token = "0x40153F9")]
	[FieldOffset(Offset = "0x14")]
	public UILabel WonnedNum;

	[Token(Token = "0x40153FA")]
	[FieldOffset(Offset = "0x18")]
	public UIButton GainBtn;

	[Token(Token = "0x40153FB")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel GainLabel;

	[Token(Token = "0x40153FC")]
	[FieldOffset(Offset = "0x20")]
	public UIButton RandomBtn;

	[Token(Token = "0x40153FD")]
	[FieldOffset(Offset = "0x24")]
	public UILabel RandomLabel;

	[Token(Token = "0x40153FE")]
	[FieldOffset(Offset = "0x28")]
	public UILabel RandomTipLabel;

	[Token(Token = "0x40153FF")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel Label;

	[Token(Token = "0x4015400")]
	[FieldOffset(Offset = "0x30")]
	public UIButton QuickSelectBtn;

	[Token(Token = "0x4015401")]
	[FieldOffset(Offset = "0x34")]
	public UILabel QuickSelectLabel;

	[Token(Token = "0x4015402")]
	[FieldOffset(Offset = "0x38")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4015403")]
	[FieldOffset(Offset = "0x3C")]
	public UIEasyList EasyList;

	[Token(Token = "0x4015404")]
	[FieldOffset(Offset = "0x40")]
	public GameObject NoItemLabel;

	[Token(Token = "0x601642D")]
	[Address(RVA = "0x2E6EAB8", Offset = "0x2E6EAB8", VA = "0x2E6EAB8")]
	public UIGachaLegendaryTempBagPackWndView()
	{
	}

	[Token(Token = "0x601642E")]
	[Address(RVA = "0x2E6EAC0", Offset = "0x2E6EAC0", VA = "0x2E6EAC0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601642F")]
	[Address(RVA = "0x2E6F07C", Offset = "0x2E6F07C", VA = "0x2E6F07C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
