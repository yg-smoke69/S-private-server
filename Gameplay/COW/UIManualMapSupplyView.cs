using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003884")]
public class UIManualMapSupplyView : UIBaseView
{
	[Token(Token = "0x40174E9")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIManualMapSupply;

	[Token(Token = "0x40174EA")]
	[FieldOffset(Offset = "0x18")]
	public GameObject SupplyItem0;

	[Token(Token = "0x40174EB")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject SupplyItem1;

	[Token(Token = "0x40174EC")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SupplyItem2;

	[Token(Token = "0x40174ED")]
	[FieldOffset(Offset = "0x24")]
	public GameObject SupplyItem3;

	[Token(Token = "0x40174EE")]
	[FieldOffset(Offset = "0x28")]
	public GameObject SupplyItem4;

	[Token(Token = "0x40174EF")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnRightArrow;

	[Token(Token = "0x40174F0")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BtnLeftArrow;

	[Token(Token = "0x40174F1")]
	[FieldOffset(Offset = "0x34")]
	public GameObject RightContent;

	[Token(Token = "0x40174F2")]
	[FieldOffset(Offset = "0x38")]
	public UILabel Title;

	[Token(Token = "0x40174F3")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite Icon;

	[Token(Token = "0x40174F4")]
	[FieldOffset(Offset = "0x40")]
	public UILabel Desc;

	[Token(Token = "0x40174F5")]
	[FieldOffset(Offset = "0x44")]
	public UIButton BtnMore;

	[Token(Token = "0x40174F6")]
	[FieldOffset(Offset = "0x48")]
	public UILabel HintLabel;

	[Token(Token = "0x6016D37")]
	[Address(RVA = "0x2C40CD4", Offset = "0x2C40CD4", VA = "0x2C40CD4")]
	public UIManualMapSupplyView()
	{
	}

	[Token(Token = "0x6016D38")]
	[Address(RVA = "0x2C40CDC", Offset = "0x2C40CDC", VA = "0x2C40CDC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D39")]
	[Address(RVA = "0x2C4131C", Offset = "0x2C4131C", VA = "0x2C4131C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
