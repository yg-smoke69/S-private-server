using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20025DD")]
public class UIDressUpVaultSecondTabController : UIBaseController, _Attribute
{
	[Token(Token = "0x400EA10")]
	[FieldOffset(Offset = "0x28")]
	private UINewVaultSecondTabView m_View;

	[Token(Token = "0x400EA11")]
	[FieldOffset(Offset = "0x2C")]
	private int count;

	[Token(Token = "0x600DEE0")]
	[Address(RVA = "0x2B9E6DC", Offset = "0x2B9E6DC", VA = "0x2B9E6DC")]
	public UIDressUpVaultSecondTabController()
	{
	}

	[Token(Token = "0x600DEE1")]
	[Address(RVA = "0x2B9E760", Offset = "0x2B9E760", VA = "0x2B9E760")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DEE2")]
	[Address(RVA = "0x2B9E808", Offset = "0x2B9E808", VA = "0x2B9E808", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DEE3")]
	[Address(RVA = "0x2B9E938", Offset = "0x2B9E938", VA = "0x2B9E938")]
	public void RefreshEasyList(List<UINewVaultSecondTabItemViewData> datas)
	{
	}

	[Token(Token = "0x600DEE4")]
	[Address(RVA = "0x2B9EA44", Offset = "0x2B9EA44", VA = "0x2B9EA44", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600DEE5")]
	[Address(RVA = "0x2B9EB94", Offset = "0x2B9EB94", VA = "0x2B9EB94", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600DEE6")]
	[Address(RVA = "0x2B9EC10", Offset = "0x2B9EC10", VA = "0x2B9EC10")]
	public UIDressUpSecondTabItemController GetTabItemControllerByIndex(int index, bool needScroll = true)
	{
		return null;
	}

	[Token(Token = "0x600DEE7")]
	[Address(RVA = "0x2B9ED14", Offset = "0x2B9ED14", VA = "0x2B9ED14")]
	public UIEasyListItemController[] GetAllTabItemCtrl()
	{
		return null;
	}

	[Token(Token = "0x600DEE8")]
	[Address(RVA = "0x2B9EDA0", Offset = "0x2B9EDA0", VA = "0x2B9EDA0")]
	public void SelectTabItemByIndex(int index)
	{
	}

	[Token(Token = "0x600DEE9")]
	[Address(RVA = "0x2B9EE3C", Offset = "0x2B9EE3C", VA = "0x2B9EE3C")]
	public UIWidget GetAllTabWidget()
	{
		return null;
	}

	[Token(Token = "0x600DEEA")]
	[Address(RVA = "0x2B9EEAC", Offset = "0x2B9EEAC", VA = "0x2B9EEAC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
