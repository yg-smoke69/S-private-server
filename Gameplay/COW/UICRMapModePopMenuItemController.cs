using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20025BE")]
public class UICRMapModePopMenuItemController : UIPopMenuItemBaseController
{
	[Token(Token = "0x400E990")]
	[FieldOffset(Offset = "0x2C")]
	private UICRMapModePopMenuItemView m_View;

	[Token(Token = "0x400E991")]
	[FieldOffset(Offset = "0x30")]
	private PopMenuData m_Data;

	[Token(Token = "0x600DD99")]
	[Address(RVA = "0x1452214", Offset = "0x1452214", VA = "0x1452214")]
	public UICRMapModePopMenuItemController()
	{
	}

	[Token(Token = "0x600DD9A")]
	[Address(RVA = "0x145221C", Offset = "0x145221C", VA = "0x145221C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DD9B")]
	[Address(RVA = "0x14522C0", Offset = "0x14522C0", VA = "0x14522C0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DD9C")]
	[Address(RVA = "0x145241C", Offset = "0x145241C", VA = "0x145241C", Slot = "33")]
	public override void SetItemData(PopMenuData data, int CellWidth, int CellHeight, float itemLocalPositionX, Alignment labelAlignment, Pivot labelPivot)
	{
	}

	[Token(Token = "0x600DD9D")]
	[Address(RVA = "0x14526E8", Offset = "0x14526E8", VA = "0x14526E8")]
	private void SetSelectedState(bool selected)
	{
	}

	[Token(Token = "0x600DD9E")]
	[Address(RVA = "0x1452850", Offset = "0x1452850", VA = "0x1452850")]
	private void SetDownloadState(object data)
	{
	}

	[Token(Token = "0x600DD9F")]
	[Address(RVA = "0x1452B58", Offset = "0x1452B58", VA = "0x1452B58")]
	private void OnPopMenuItemClick()
	{
	}

	[Token(Token = "0x600DDA0")]
	[Address(RVA = "0x1452CE8", Offset = "0x1452CE8", VA = "0x1452CE8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DDA1")]
	[Address(RVA = "0x1452CF0", Offset = "0x1452CF0", VA = "0x1452CF0")]
	public void _003C_003EiFixBaseProxy_SetItemData(PopMenuData P0, int P1, int P2, float P3, Alignment P4, Pivot P5)
	{
	}
}
