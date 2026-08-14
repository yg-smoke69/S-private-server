using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002A41")]
public class UIPaymentTabItemController : UIBaseController, _Attribute
{
	[Token(Token = "0x40103C8")]
	[FieldOffset(Offset = "0x0")]
	private static Color selectArrowColor;

	[Token(Token = "0x40103C9")]
	[FieldOffset(Offset = "0x10")]
	private static Color unselectArrowColor;

	[Token(Token = "0x40103CA")]
	[FieldOffset(Offset = "0x28")]
	private UIPaymentTabItemView m_View;

	[Token(Token = "0x40103CB")]
	[FieldOffset(Offset = "0x2C")]
	private List<UIPaymentSubTabItemController> m_SubTabList;

	[Token(Token = "0x40103CC")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsFolded;

	[Token(Token = "0x40103CD")]
	[FieldOffset(Offset = "0x31")]
	private bool m_IsSelected;

	[Token(Token = "0x40103CE")]
	[FieldOffset(Offset = "0x34")]
	private UIPaymentController.Tab m_Tab;

	[Token(Token = "0x40103CF")]
	[FieldOffset(Offset = "0x38")]
	private UIPaymentController.TabInfo m_TabInfo;

	[Token(Token = "0x601124C")]
	[Address(RVA = "0x29EDA88", Offset = "0x29EDA88", VA = "0x29EDA88")]
	public UIPaymentTabItemController()
	{
	}

	[Token(Token = "0x601124D")]
	[Address(RVA = "0x29EDB48", Offset = "0x29EDB48", VA = "0x29EDB48")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601124E")]
	[Address(RVA = "0x29EDBF0", Offset = "0x29EDBF0", VA = "0x29EDBF0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601124F")]
	[Address(RVA = "0x29EE310", Offset = "0x29EE310", VA = "0x29EE310", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011250")]
	[Address(RVA = "0x29EE4E4", Offset = "0x29EE4E4", VA = "0x29EE4E4")]
	public void SetData(UIPaymentController.Tab tab, UIPaymentController.TabInfo info)
	{
	}

	[Token(Token = "0x6011251")]
	[Address(RVA = "0x29EEB60", Offset = "0x29EEB60", VA = "0x29EEB60")]
	private void CreateSubTab(UIPaymentController.Tab tab)
	{
	}

	[Token(Token = "0x6011252")]
	[Address(RVA = "0x29EDEF0", Offset = "0x29EDEF0", VA = "0x29EDEF0")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x6011253")]
	[Address(RVA = "0x29EFAC4", Offset = "0x29EFAC4", VA = "0x29EFAC4")]
	public void SelectSubTab(int subTabIndex)
	{
	}

	[Token(Token = "0x6011254")]
	[Address(RVA = "0x29EEA88", Offset = "0x29EEA88", VA = "0x29EEA88")]
	private void SetRedDot(ETipsType type, int num)
	{
	}

	[Token(Token = "0x6011255")]
	[Address(RVA = "0x29EFBA8", Offset = "0x29EFBA8", VA = "0x29EFBA8")]
	private void OnButtonClick()
	{
	}

	[Token(Token = "0x6011256")]
	[Address(RVA = "0x29EF348", Offset = "0x29EF348", VA = "0x29EF348")]
	private void RefreshSubTabView()
	{
	}

	[Token(Token = "0x6011257")]
	[Address(RVA = "0x29EF714", Offset = "0x29EF714", VA = "0x29EF714")]
	private void OnTabUnSelected()
	{
	}

	[Token(Token = "0x6011258")]
	[Address(RVA = "0x29F0248", Offset = "0x29F0248", VA = "0x29F0248", Slot = "31")]
	private void COW_002EITipsDelegate_002EOnTipsDataChange(ETipsType type, int num)
	{
	}

	[Token(Token = "0x6011259")]
	[Address(RVA = "0x29DEB60", Offset = "0x29DEB60", VA = "0x29DEB60")]
	public void OnSubTabClick(int subIndex)
	{
	}

	[Token(Token = "0x601125B")]
	[Address(RVA = "0x29F03C4", Offset = "0x29F03C4", VA = "0x29F03C4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601125C")]
	[Address(RVA = "0x29F03CC", Offset = "0x29F03CC", VA = "0x29F03CC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
