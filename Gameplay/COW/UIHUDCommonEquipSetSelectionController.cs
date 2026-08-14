using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200270D")]
public class UIHUDCommonEquipSetSelectionController : UIPopupWindowController
{
	[Token(Token = "0x400F102")]
	[FieldOffset(Offset = "0x48")]
	private UIEquipSetSelectionView m_View;

	[Token(Token = "0x400F103")]
	[FieldOffset(Offset = "0x4C")]
	private int m_SelectedIndex;

	[Token(Token = "0x400F104")]
	[FieldOffset(Offset = "0x50")]
	private List<UIEquipSetItemController> m_SetItemUIs;

	[Token(Token = "0x400F105")]
	[FieldOffset(Offset = "0x54")]
	private UITimeLabelHelper m_EndTime;

	[Token(Token = "0x600ED48")]
	[Address(RVA = "0x1677264", Offset = "0x1677264", VA = "0x1677264")]
	public UIHUDCommonEquipSetSelectionController()
	{
	}

	[Token(Token = "0x600ED49")]
	[Address(RVA = "0x167726C", Offset = "0x167726C", VA = "0x167726C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600ED4A")]
	[Address(RVA = "0x1677310", Offset = "0x1677310", VA = "0x1677310", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600ED4B")]
	[Address(RVA = "0x1677928", Offset = "0x1677928", VA = "0x1677928")]
	public void ShowWindow(int defalutIndex, float showTime)
	{
	}

	[Token(Token = "0x600ED4C")]
	[Address(RVA = "0x16778A4", Offset = "0x16778A4", VA = "0x16778A4")]
	private void OnSelectItem(int index)
	{
	}

	[Token(Token = "0x600ED4D")]
	[Address(RVA = "0x1677B90", Offset = "0x1677B90", VA = "0x1677B90")]
	private void HighLightIndex(int index, bool hightlight)
	{
	}

	[Token(Token = "0x600ED4E")]
	[Address(RVA = "0x1677CCC", Offset = "0x1677CCC", VA = "0x1677CCC")]
	private void OnConfirm()
	{
	}

	[Token(Token = "0x600ED4F")]
	[Address(RVA = "0x1677DCC", Offset = "0x1677DCC", VA = "0x1677DCC")]
	private void Update()
	{
	}

	[Token(Token = "0x600ED50")]
	[Address(RVA = "0x1677E6C", Offset = "0x1677E6C", VA = "0x1677E6C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
