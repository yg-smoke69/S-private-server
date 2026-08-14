using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002507")]
public class UIChatBlockListController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400E5E6")]
	[FieldOffset(Offset = "0x48")]
	private UIChatBlockListView m_View;

	[Token(Token = "0x400E5E7")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelChat m_Model;

	[Token(Token = "0x600D6A3")]
	[Address(RVA = "0x262B674", Offset = "0x262B674", VA = "0x262B674")]
	public UIChatBlockListController()
	{
	}

	[Token(Token = "0x600D6A4")]
	[Address(RVA = "0x262B67C", Offset = "0x262B67C", VA = "0x262B67C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D6A5")]
	[Address(RVA = "0x262BA6C", Offset = "0x262BA6C", VA = "0x262BA6C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D6A6")]
	[Address(RVA = "0x262BBA0", Offset = "0x262BBA0", VA = "0x262BBA0")]
	private void RefreshBlockList(object[] data)
	{
	}

	[Token(Token = "0x600D6A7")]
	[Address(RVA = "0x262BD8C", Offset = "0x262BD8C", VA = "0x262BD8C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D6A8")]
	[Address(RVA = "0x262BE30", Offset = "0x262BE30", VA = "0x262BE30", Slot = "47")]
	private void GCommon_002EIEasyList_002ECloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600D6A9")]
	[Address(RVA = "0x262BEAC", Offset = "0x262BEAC", VA = "0x262BEAC", Slot = "46")]
	private UIEasyListItemController GCommon_002EIEasyList_002EOpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600D6AA")]
	[Address(RVA = "0x262BFA4", Offset = "0x262BFA4", VA = "0x262BFA4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D6AB")]
	[Address(RVA = "0x262BFAC", Offset = "0x262BFAC", VA = "0x262BFAC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
