using GCommon;
using Il2CppDummyDll;

namespace ReactUI;

[Token(Token = "0x2000CD4")]
public class UIBindItemListItemController : UIEasyListItemController
{
	[Token(Token = "0x400680E")]
	[FieldOffset(Offset = "0x38")]
	private int DataIndex;

	[Token(Token = "0x400680F")]
	[FieldOffset(Offset = "0x3C")]
	public UIVariableBindItemList Owner;

	[Token(Token = "0x6006176")]
	[Address(RVA = "0x3156520", Offset = "0x3156520", VA = "0x3156520")]
	public UIBindItemListItemController()
	{
	}

	[Token(Token = "0x6006177")]
	[Address(RVA = "0x3156528", Offset = "0x3156528", VA = "0x3156528", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6006178")]
	[Address(RVA = "0x3156530", Offset = "0x3156530", VA = "0x3156530")]
	private void OnSelect(bool selected)
	{
	}

	[Token(Token = "0x6006179")]
	[Address(RVA = "0x31567C4", Offset = "0x31567C4", VA = "0x31567C4")]
	private void OnSelectButtonClick()
	{
	}

	[Token(Token = "0x600617A")]
	[Address(RVA = "0x315687C", Offset = "0x315687C", VA = "0x315687C", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600617B")]
	[Address(RVA = "0x3156884", Offset = "0x3156884", VA = "0x3156884", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}
}
