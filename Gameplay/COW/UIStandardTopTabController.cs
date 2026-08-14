using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20023C9")]
public class UIStandardTopTabController : UIBaseController, _Attribute
{
	[Token(Token = "0x400DE96")]
	[FieldOffset(Offset = "0x28")]
	private UIStandardTopTabView m_View;

	[Token(Token = "0x400DE97")]
	[FieldOffset(Offset = "0x2C")]
	public Action<int> onItemClick;

	[Token(Token = "0x400DE98")]
	[FieldOffset(Offset = "0x30")]
	private int count;

	[Token(Token = "0x600C9CA")]
	[Address(RVA = "0x2004D64", Offset = "0x2004D64", VA = "0x2004D64")]
	public UIStandardTopTabController()
	{
	}

	[Token(Token = "0x600C9CB")]
	[Address(RVA = "0x2004DE8", Offset = "0x2004DE8", VA = "0x2004DE8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C9CC")]
	[Address(RVA = "0x2004E90", Offset = "0x2004E90", VA = "0x2004E90", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C9CD")]
	public void RefreshEasyList<DataType>(List<DataType> dataList)
	{
	}

	[Token(Token = "0x600C9CE")]
	[Address(RVA = "0x20053E0", Offset = "0x20053E0", VA = "0x20053E0")]
	public void OnItemClick(int index)
	{
	}

	[Token(Token = "0x600C9CF")]
	[Address(RVA = "0x20054A0", Offset = "0x20054A0", VA = "0x20054A0", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600C9D0")]
	[Address(RVA = "0x200551C", Offset = "0x200551C", VA = "0x200551C", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600C9D1")]
	[Address(RVA = "0x20056A8", Offset = "0x20056A8", VA = "0x20056A8")]
	public UIButton GetBtnClose()
	{
		return null;
	}

	[Token(Token = "0x600C9D2")]
	[Address(RVA = "0x2005718", Offset = "0x2005718", VA = "0x2005718")]
	public void UpdatePanelDepth(int newDepth)
	{
	}

	[Token(Token = "0x600C9D3")]
	[Address(RVA = "0x2005900", Offset = "0x2005900", VA = "0x2005900")]
	public int GetPanelDepth()
	{
		return default(int);
	}

	[Token(Token = "0x600C9D4")]
	[Address(RVA = "0x200598C", Offset = "0x200598C", VA = "0x200598C")]
	public UIStandardTopTabItemController GetTabItemControllerByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x600C9D5")]
	[Address(RVA = "0x2005A84", Offset = "0x2005A84", VA = "0x2005A84")]
	public void SelectTabItemByIndex(int index)
	{
	}

	[Token(Token = "0x600C9D6")]
	[Address(RVA = "0x2005B20", Offset = "0x2005B20", VA = "0x2005B20")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
