using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002A07")]
public class UINewVaultSecondTabController : UIBaseController, _Attribute
{
	[Token(Token = "0x40102A9")]
	[FieldOffset(Offset = "0x28")]
	private UINewVaultSecondTabView m_View;

	[Token(Token = "0x40102AA")]
	[FieldOffset(Offset = "0x2C")]
	private int count;

	[Token(Token = "0x6010FBE")]
	[Address(RVA = "0x26CC328", Offset = "0x26CC328", VA = "0x26CC328")]
	public UINewVaultSecondTabController()
	{
	}

	[Token(Token = "0x6010FBF")]
	[Address(RVA = "0x26CC3AC", Offset = "0x26CC3AC", VA = "0x26CC3AC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010FC0")]
	[Address(RVA = "0x26CC454", Offset = "0x26CC454", VA = "0x26CC454", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010FC1")]
	[Address(RVA = "0x26CC584", Offset = "0x26CC584", VA = "0x26CC584")]
	public void RefreshEasyList(List<UINewVaultSecondTabItemViewData> datas)
	{
	}

	[Token(Token = "0x6010FC2")]
	[Address(RVA = "0x26CC690", Offset = "0x26CC690", VA = "0x26CC690", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6010FC3")]
	[Address(RVA = "0x26CC7E0", Offset = "0x26CC7E0", VA = "0x26CC7E0", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6010FC4")]
	[Address(RVA = "0x26CC85C", Offset = "0x26CC85C", VA = "0x26CC85C")]
	public UINewVaultSecondTabItemController GetTabItemControllerByIndex(int index, bool needScroll = true)
	{
		return null;
	}

	[Token(Token = "0x6010FC5")]
	[Address(RVA = "0x26CC960", Offset = "0x26CC960", VA = "0x26CC960")]
	public UIEasyListItemController[] GetAllTabItemCtrl()
	{
		return null;
	}

	[Token(Token = "0x6010FC6")]
	[Address(RVA = "0x26CC9EC", Offset = "0x26CC9EC", VA = "0x26CC9EC")]
	public void SelectTabItemByIndex(int index)
	{
	}

	[Token(Token = "0x6010FC7")]
	[Address(RVA = "0x26CCA88", Offset = "0x26CCA88", VA = "0x26CCA88")]
	public UIWidget GetAllTabWidget()
	{
		return null;
	}

	[Token(Token = "0x6010FC8")]
	[Address(RVA = "0x26CCAF8", Offset = "0x26CCAF8", VA = "0x26CCAF8")]
	public void UpdatePanelDepth(int newDepth)
	{
	}

	[Token(Token = "0x6010FC9")]
	[Address(RVA = "0x26CCC30", Offset = "0x26CCC30", VA = "0x26CCC30")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
