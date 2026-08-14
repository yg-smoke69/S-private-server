using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022CD")]
public class UIHudReaperEquipSetSelectionController : UIPopupWindowController
{
	[Token(Token = "0x400D976")]
	[FieldOffset(Offset = "0x48")]
	private UIEquipSetSelectionView m_View;

	[Token(Token = "0x400D977")]
	[FieldOffset(Offset = "0x4C")]
	private UIEquipSetItemController m_SelectSetUI;

	[Token(Token = "0x400D978")]
	[FieldOffset(Offset = "0x50")]
	private List<UIEquipSetItemController> m_SetItemUIs;

	[Token(Token = "0x400D979")]
	[FieldOffset(Offset = "0x54")]
	private UITimeLabelHelper m_EndTime;

	[Token(Token = "0x600BFB8")]
	[Address(RVA = "0x1FD9CF0", Offset = "0x1FD9CF0", VA = "0x1FD9CF0")]
	public UIHudReaperEquipSetSelectionController()
	{
	}

	[Token(Token = "0x600BFB9")]
	[Address(RVA = "0x1FD9CF8", Offset = "0x1FD9CF8", VA = "0x1FD9CF8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BFBA")]
	[Address(RVA = "0x1FD9D9C", Offset = "0x1FD9D9C", VA = "0x1FD9D9C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BFBB")]
	[Address(RVA = "0x1FDA8F8", Offset = "0x1FDA8F8", VA = "0x1FDA8F8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600BFBC")]
	[Address(RVA = "0x1FDA57C", Offset = "0x1FDA57C", VA = "0x1FDA57C")]
	private int GetEquipSetUIIndex(uint equipSetID)
	{
		return default(int);
	}

	[Token(Token = "0x600BFBD")]
	[Address(RVA = "0x1FDA754", Offset = "0x1FDA754", VA = "0x1FDA754")]
	private void OnSelectItem(int index)
	{
	}

	[Token(Token = "0x600BFBE")]
	[Address(RVA = "0x1FDA95C", Offset = "0x1FDA95C", VA = "0x1FDA95C")]
	private void OnConfirm()
	{
	}

	[Token(Token = "0x600BFBF")]
	[Address(RVA = "0x1FDAAB8", Offset = "0x1FDAAB8", VA = "0x1FDAAB8")]
	private void Update()
	{
	}

	[Token(Token = "0x600BFC0")]
	[Address(RVA = "0x1FDAB58", Offset = "0x1FDAB58", VA = "0x1FDAB58")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BFC1")]
	[Address(RVA = "0x1FDAB60", Offset = "0x1FDAB60", VA = "0x1FDAB60")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
