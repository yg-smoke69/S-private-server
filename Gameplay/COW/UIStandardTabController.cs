using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20023C2")]
public class UIStandardTabController : UIBaseController, _Attribute
{
	[Token(Token = "0x400DE7F")]
	[FieldOffset(Offset = "0x28")]
	protected UIStandardTabView m_View;

	[Token(Token = "0x400DE80")]
	[FieldOffset(Offset = "0x2C")]
	public Action<int> onItemClick;

	[Token(Token = "0x400DE81")]
	[FieldOffset(Offset = "0x30")]
	protected int count;

	[Token(Token = "0x600C97F")]
	[Address(RVA = "0x2062828", Offset = "0x2062828", VA = "0x2062828")]
	public UIStandardTabController()
	{
	}

	[Token(Token = "0x600C980")]
	[Address(RVA = "0x2070AE4", Offset = "0x2070AE4", VA = "0x2070AE4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C981")]
	[Address(RVA = "0x2062A9C", Offset = "0x2062A9C", VA = "0x2062A9C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C982")]
	public void RefreshEasyList<DataType>(List<DataType> dataList)
	{
	}

	[Token(Token = "0x600C983")]
	[Address(RVA = "0x2070B8C", Offset = "0x2070B8C", VA = "0x2070B8C", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600C984")]
	[Address(RVA = "0x2063560", Offset = "0x2063560", VA = "0x2063560", Slot = "33")]
	public virtual UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600C985")]
	[Address(RVA = "0x2070C08", Offset = "0x2070C08", VA = "0x2070C08", Slot = "34")]
	protected virtual UIStandardTabItemController CreateTabItem(Transform container)
	{
		return null;
	}

	[Token(Token = "0x600C986")]
	[Address(RVA = "0x2070D00", Offset = "0x2070D00", VA = "0x2070D00")]
	public void UpdateBgState(bool value)
	{
	}

	[Token(Token = "0x600C987")]
	[Address(RVA = "0x2070DB8", Offset = "0x2070DB8", VA = "0x2070DB8")]
	public void OnItemClick(int index)
	{
	}

	[Token(Token = "0x600C988")]
	[Address(RVA = "0x2070E78", Offset = "0x2070E78", VA = "0x2070E78")]
	public void UpdatePanelDepth(int newDepth)
	{
	}

	[Token(Token = "0x600C989")]
	[Address(RVA = "0x2070FB0", Offset = "0x2070FB0", VA = "0x2070FB0")]
	public UIStandardTabItemController GetTabItemControllerByIndex(int index, bool needScroll = true)
	{
		return null;
	}

	[Token(Token = "0x600C98A")]
	[Address(RVA = "0x20710B4", Offset = "0x20710B4", VA = "0x20710B4")]
	public void SelectTabItemByIndex(int index)
	{
	}

	[Token(Token = "0x600C98B")]
	[Address(RVA = "0x2071150", Offset = "0x2071150", VA = "0x2071150")]
	public void UnSelectTabItemByIndex(int index)
	{
	}

	[Token(Token = "0x600C98C")]
	[Address(RVA = "0x20711EC", Offset = "0x20711EC", VA = "0x20711EC")]
	public UIEasyListItemController[] GetAllEasyListItemCtrls()
	{
		return null;
	}

	[Token(Token = "0x600C98D")]
	[Address(RVA = "0x2071278", Offset = "0x2071278", VA = "0x2071278")]
	public UIWidget GetAllTabWidget()
	{
		return null;
	}

	[Token(Token = "0x600C98E")]
	[Address(RVA = "0x2071340", Offset = "0x2071340", VA = "0x2071340")]
	public void CloseAllTabWidget()
	{
	}

	[Token(Token = "0x600C98F")]
	[Address(RVA = "0x20713F0", Offset = "0x20713F0", VA = "0x20713F0")]
	public void ResetAllTabItemAnimations()
	{
	}

	[Token(Token = "0x600C990")]
	[Address(RVA = "0x20715BC", Offset = "0x20715BC", VA = "0x20715BC")]
	public UIButton GetItemButtonByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x600C991")]
	[Address(RVA = "0x20717D4", Offset = "0x20717D4", VA = "0x20717D4")]
	public UIWidget GetItemWidgetByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x600C992")]
	[Address(RVA = "0x20719EC", Offset = "0x20719EC", VA = "0x20719EC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
