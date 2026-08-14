using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002528")]
public class UIClanApplyListController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x400E66A")]
	[FieldOffset(Offset = "0x48")]
	private UIClanApplyListView m_View;

	[Token(Token = "0x600D813")]
	[Address(RVA = "0x2F20160", Offset = "0x2F20160", VA = "0x2F20160")]
	public UIClanApplyListController()
	{
	}

	[Token(Token = "0x600D814")]
	[Address(RVA = "0x2F20168", Offset = "0x2F20168", VA = "0x2F20168")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D815")]
	[Address(RVA = "0x2F2020C", Offset = "0x2F2020C", VA = "0x2F2020C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D816")]
	[Address(RVA = "0x2F203F4", Offset = "0x2F203F4", VA = "0x2F203F4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D817")]
	[Address(RVA = "0x2F20558", Offset = "0x2F20558", VA = "0x2F20558", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D818")]
	private void RefreshViewData<DataType>(List<DataType> memberList)
	{
	}

	[Token(Token = "0x600D819")]
	[Address(RVA = "0x2F206EC", Offset = "0x2F206EC", VA = "0x2F206EC", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D81A")]
	[Address(RVA = "0x2F20780", Offset = "0x2F20780", VA = "0x2F20780", Slot = "48")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600D81B")]
	[Address(RVA = "0x2F20878", Offset = "0x2F20878", VA = "0x2F20878", Slot = "49")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600D81C")]
	[Address(RVA = "0x2F208F4", Offset = "0x2F208F4", VA = "0x2F208F4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D81D")]
	[Address(RVA = "0x2F208FC", Offset = "0x2F208FC", VA = "0x2F208FC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
