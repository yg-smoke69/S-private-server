using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A6C")]
public class UIPopMenuController : UIBaseController
{
	[Token(Token = "0x40104A4")]
	[FieldOffset(Offset = "0x28")]
	private UIPopMenuView m_View;

	[Token(Token = "0x40104A5")]
	[FieldOffset(Offset = "0x2C")]
	public PopMenuDelegate onPopMenuClose;

	[Token(Token = "0x601142D")]
	[Address(RVA = "0x2C5C0A0", Offset = "0x2C5C0A0", VA = "0x2C5C0A0")]
	public UIPopMenuController()
	{
	}

	[Token(Token = "0x601142E")]
	[Address(RVA = "0x2C5C124", Offset = "0x2C5C124", VA = "0x2C5C124")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601142F")]
	[Address(RVA = "0x2C5C1C8", Offset = "0x2C5C1C8", VA = "0x2C5C1C8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011430")]
	[Address(RVA = "0x2C5C3B8", Offset = "0x2C5C3B8", VA = "0x2C5C3B8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011431")]
	[Address(RVA = "0x2C5C4EC", Offset = "0x2C5C4EC", VA = "0x2C5C4EC")]
	public void SetPopMenu(List<PopMenuData> dataList, int CellWidth, int CellHeight, int PanelMaxHeight, float itemLocalPositionX, Alignment labelAlignment, Pivot labelPivot)
	{
	}

	[Token(Token = "0x6011432")]
	public void SetCustomizePopMenu<T>(List<PopMenuData> dataList, int CellWidth, int CellHeight, int PanelMaxHeight, bool showBg = true, bool showCustomizedBg = true, bool setSize = false) where T : UIPopMenuItemBaseController
	{
	}

	[Token(Token = "0x6011433")]
	public void SetCustomizePopMenu<T>(List<PopMenuData> dataList, int CellWidth, int CellHeight, int PanelMaxHeight, float itemLocalPositionX, Alignment labelAlignment, Pivot labelPivot, bool showBg = true, bool showCustomizedBg = true) where T : UIPopMenuItemBaseController
	{
	}

	[Token(Token = "0x6011434")]
	[Address(RVA = "0x2C5CDDC", Offset = "0x2C5CDDC", VA = "0x2C5CDDC")]
	private void UpdateViewUI()
	{
	}

	[Token(Token = "0x6011435")]
	[Address(RVA = "0x2C5CE30", Offset = "0x2C5CE30", VA = "0x2C5CE30")]
	public void SetPopMenuDepth(int d)
	{
	}

	[Token(Token = "0x6011436")]
	[Address(RVA = "0x2C5CF20", Offset = "0x2C5CF20", VA = "0x2C5CF20")]
	private void OnMaskClick()
	{
	}

	[Token(Token = "0x6011437")]
	[Address(RVA = "0x2C5CF84", Offset = "0x2C5CF84", VA = "0x2C5CF84")]
	private void OnClickeMenuItem(object[] data)
	{
	}

	[Token(Token = "0x6011438")]
	[Address(RVA = "0x2C5CFF0", Offset = "0x2C5CFF0", VA = "0x2C5CFF0", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6011439")]
	[Address(RVA = "0x2C5D074", Offset = "0x2C5D074", VA = "0x2C5D074")]
	public void DisableMask()
	{
	}

	[Token(Token = "0x601143A")]
	[Address(RVA = "0x2C5D124", Offset = "0x2C5D124", VA = "0x2C5D124")]
	public void ResetMutilPopMenuItemState()
	{
	}

	[Token(Token = "0x601143B")]
	[Address(RVA = "0x2C5D25C", Offset = "0x2C5D25C", VA = "0x2C5D25C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601143C")]
	[Address(RVA = "0x2C5D264", Offset = "0x2C5D264", VA = "0x2C5D264")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x601143D")]
	[Address(RVA = "0x2C5D26C", Offset = "0x2C5D26C", VA = "0x2C5D26C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
