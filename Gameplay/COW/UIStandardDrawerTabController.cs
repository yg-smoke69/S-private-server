using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20023B7")]
public class UIStandardDrawerTabController : UIBaseController
{
	[Token(Token = "0x400DE55")]
	[FieldOffset(Offset = "0x28")]
	private UIStandardDrawerTabView m_View;

	[Token(Token = "0x400DE56")]
	[FieldOffset(Offset = "0x2C")]
	private List<UIStandardTabItemController> mainTabList;

	[Token(Token = "0x400DE57")]
	[FieldOffset(Offset = "0x30")]
	private int maxMainTabItemIndex;

	[Token(Token = "0x400DE58")]
	[FieldOffset(Offset = "0x34")]
	private int curMainTabItemIndex;

	[Token(Token = "0x600C8F6")]
	[Address(RVA = "0x2064B74", Offset = "0x2064B74", VA = "0x2064B74")]
	public UIStandardDrawerTabController()
	{
	}

	[Token(Token = "0x600C8F7")]
	[Address(RVA = "0x2064BF8", Offset = "0x2064BF8", VA = "0x2064BF8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C8F8")]
	[Address(RVA = "0x2064CA0", Offset = "0x2064CA0", VA = "0x2064CA0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C8F9")]
	[Address(RVA = "0x2064DD0", Offset = "0x2064DD0", VA = "0x2064DD0")]
	public void CreateTabByData(StandardTabItemViewData mainTabData, List<StandardSubTabItemViewData> subTabDataist)
	{
	}

	[Token(Token = "0x600C8FA")]
	[Address(RVA = "0x2064FF0", Offset = "0x2064FF0", VA = "0x2064FF0", Slot = "31")]
	protected virtual UIStandardTabItemController CreateTabItem(Transform container)
	{
		return null;
	}

	[Token(Token = "0x600C8FB")]
	[Address(RVA = "0x20650E8", Offset = "0x20650E8", VA = "0x20650E8")]
	public void SelectSubTabByIndex(int mainTabIndex, int subTabIndex)
	{
	}

	[Token(Token = "0x600C8FC")]
	[Address(RVA = "0x2065628", Offset = "0x2065628", VA = "0x2065628")]
	private void UpdateScrollViewState()
	{
	}

	[Token(Token = "0x600C8FD")]
	[Address(RVA = "0x2065854", Offset = "0x2065854", VA = "0x2065854")]
	public void ReposTab()
	{
	}

	[Token(Token = "0x600C8FE")]
	[Address(RVA = "0x2065520", Offset = "0x2065520", VA = "0x2065520")]
	public UIStandardTabItemController GetTabItemControllerByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x600C8FF")]
	[Address(RVA = "0x20658E8", Offset = "0x20658E8", VA = "0x20658E8")]
	public uint GetScrollviewPanelDepth()
	{
		return default(uint);
	}

	[Token(Token = "0x600C900")]
	[Address(RVA = "0x2065224", Offset = "0x2065224", VA = "0x2065224")]
	public void SelectMainTabByIndex(int index, bool isDrawerOpen = false)
	{
	}

	[Token(Token = "0x600C901")]
	[Address(RVA = "0x2065A84", Offset = "0x2065A84", VA = "0x2065A84")]
	public int GetCurTabItemIndex()
	{
		return default(int);
	}

	[Token(Token = "0x600C902")]
	[Address(RVA = "0x2065ADC", Offset = "0x2065ADC", VA = "0x2065ADC")]
	public bool IsMainTabNoSubTabItem(int mainTabIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x600C903")]
	[Address(RVA = "0x2065BC8", Offset = "0x2065BC8", VA = "0x2065BC8")]
	public void SetGuideContainerPos(Vector3 pos)
	{
	}

	[Token(Token = "0x600C904")]
	[Address(RVA = "0x2065CA8", Offset = "0x2065CA8", VA = "0x2065CA8")]
	public UIWidget GetGuideWidght()
	{
		return null;
	}

	[Token(Token = "0x600C905")]
	[Address(RVA = "0x2065D18", Offset = "0x2065D18", VA = "0x2065D18")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
