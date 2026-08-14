using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace ReactUI;

[Token(Token = "0x2000CC7")]
public class UIDropdownListItemController : UIEasyListItemController
{
	[Token(Token = "0x40067C3")]
	[FieldOffset(Offset = "0x38")]
	private int DataIndex;

	[Token(Token = "0x40067C4")]
	[FieldOffset(Offset = "0x3C")]
	private UILabel NameLabel;

	[Token(Token = "0x40067C5")]
	[FieldOffset(Offset = "0x40")]
	private UIButton SelectButton;

	[Token(Token = "0x40067C6")]
	[FieldOffset(Offset = "0x44")]
	private GameObject SelectedFrame;

	[Token(Token = "0x40067C7")]
	[FieldOffset(Offset = "0x48")]
	public UIVariableBindDropdownList Owner;

	[Token(Token = "0x6006136")]
	[Address(RVA = "0x315688C", Offset = "0x315688C", VA = "0x315688C")]
	public UIDropdownListItemController()
	{
	}

	[Token(Token = "0x6006137")]
	[Address(RVA = "0x3156894", Offset = "0x3156894", VA = "0x3156894", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6006138")]
	[Address(RVA = "0x3156DDC", Offset = "0x3156DDC", VA = "0x3156DDC")]
	private void OnSelect(bool selected)
	{
	}

	[Token(Token = "0x6006139")]
	[Address(RVA = "0x31570BC", Offset = "0x31570BC", VA = "0x31570BC")]
	private void OnSelectButtonClick()
	{
	}

	[Token(Token = "0x600613A")]
	[Address(RVA = "0x3157174", Offset = "0x3157174", VA = "0x3157174", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600613B")]
	[Address(RVA = "0x315717C", Offset = "0x315717C", VA = "0x315717C", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}
}
