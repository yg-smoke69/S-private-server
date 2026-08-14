using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002AAE")]
public class UIRankCardListController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x4010677")]
	[FieldOffset(Offset = "0x48")]
	private UIRankCardListView m_View;

	[Token(Token = "0x4010678")]
	private const int m_UnselectId = 0;

	[Token(Token = "0x4010679")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x401067A")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<RankCardData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x401067B")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<RankCardData> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x601176E")]
	[Address(RVA = "0x1AC4884", Offset = "0x1AC4884", VA = "0x1AC4884")]
	public UIRankCardListController()
	{
	}

	[Token(Token = "0x601176F")]
	[Address(RVA = "0x1AC488C", Offset = "0x1AC488C", VA = "0x1AC488C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011770")]
	[Address(RVA = "0x1AC4930", Offset = "0x1AC4930", VA = "0x1AC4930", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011771")]
	[Address(RVA = "0x1AC4B84", Offset = "0x1AC4B84", VA = "0x1AC4B84", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6011772")]
	[Address(RVA = "0x1AC4BE8", Offset = "0x1AC4BE8", VA = "0x1AC4BE8", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6011773")]
	[Address(RVA = "0x1AC4C4C", Offset = "0x1AC4C4C", VA = "0x1AC4C4C")]
	private void OnNoneUseItemClick()
	{
	}

	[Token(Token = "0x6011774")]
	[Address(RVA = "0x1AC4DE8", Offset = "0x1AC4DE8", VA = "0x1AC4DE8")]
	private void OnItemSelect(object[] data)
	{
	}

	[Token(Token = "0x6011775")]
	[Address(RVA = "0x1AC4F18", Offset = "0x1AC4F18", VA = "0x1AC4F18")]
	public void RefreshRankCardData(int currentSelectedRankCardId)
	{
	}

	[Token(Token = "0x6011776")]
	[Address(RVA = "0x1AC5420", Offset = "0x1AC5420", VA = "0x1AC5420", Slot = "47")]
	private void GCommon_002EIEasyList_002ECloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6011777")]
	[Address(RVA = "0x1AC549C", Offset = "0x1AC549C", VA = "0x1AC549C", Slot = "46")]
	private UIEasyListItemController GCommon_002EIEasyList_002EOpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6011778")]
	[Address(RVA = "0x1AC5594", Offset = "0x1AC5594", VA = "0x1AC5594")]
	private static bool _003CRefreshRankCardData_003Em__0(RankCardData t)
	{
		return default(bool);
	}

	[Token(Token = "0x6011779")]
	[Address(RVA = "0x1AC55C4", Offset = "0x1AC55C4", VA = "0x1AC55C4")]
	private static bool _003CRefreshRankCardData_003Em__1(RankCardData t)
	{
		return default(bool);
	}

	[Token(Token = "0x601177A")]
	[Address(RVA = "0x1AC55F0", Offset = "0x1AC55F0", VA = "0x1AC55F0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601177B")]
	[Address(RVA = "0x1AC55F8", Offset = "0x1AC55F8", VA = "0x1AC55F8")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x601177C")]
	[Address(RVA = "0x1AC5600", Offset = "0x1AC5600", VA = "0x1AC5600")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
