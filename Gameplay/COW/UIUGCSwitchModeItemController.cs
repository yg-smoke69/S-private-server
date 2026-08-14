using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002BC5")]
internal class UIUGCSwitchModeItemController : UIEasyListItemController
{
	[Token(Token = "0x4010B7D")]
	[FieldOffset(Offset = "0x38")]
	private UIUGCSwitchModeItemView m_View;

	[Token(Token = "0x4010B7E")]
	[FieldOffset(Offset = "0x3C")]
	private WorkshopCreateNewConfigData m_ConfigData;

	[Token(Token = "0x6012193")]
	[Address(RVA = "0xF42CF4", Offset = "0xF42CF4", VA = "0xF42CF4")]
	public UIUGCSwitchModeItemController()
	{
	}

	[Token(Token = "0x6012194")]
	[Address(RVA = "0xF42CFC", Offset = "0xF42CFC", VA = "0xF42CFC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012195")]
	[Address(RVA = "0xF42DA4", Offset = "0xF42DA4", VA = "0xF42DA4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012196")]
	[Address(RVA = "0xF42F00", Offset = "0xF42F00", VA = "0xF42F00", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6012197")]
	[Address(RVA = "0xF43384", Offset = "0xF43384", VA = "0xF43384", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x6012198")]
	[Address(RVA = "0xF43570", Offset = "0xF43570", VA = "0xF43570", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x6012199")]
	[Address(RVA = "0xF43644", Offset = "0xF43644", VA = "0xF43644")]
	private void _003CSetViewData_003Em__0()
	{
	}

	[Token(Token = "0x601219A")]
	[Address(RVA = "0xF43720", Offset = "0xF43720", VA = "0xF43720")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601219B")]
	[Address(RVA = "0xF43728", Offset = "0xF43728", VA = "0xF43728")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x601219C")]
	[Address(RVA = "0xF43730", Offset = "0xF43730", VA = "0xF43730")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
