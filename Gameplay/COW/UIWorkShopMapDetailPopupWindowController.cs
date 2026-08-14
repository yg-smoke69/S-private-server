using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002C27")]
internal class UIWorkShopMapDetailPopupWindowController : UIPopupWindowController
{
	[Token(Token = "0x4010DA3")]
	[FieldOffset(Offset = "0x48")]
	private UIWorkShopMapDetailPopupWindowView m_View;

	[Token(Token = "0x4010DA4")]
	[FieldOffset(Offset = "0x4C")]
	private int m_CurItemIdx;

	[Token(Token = "0x4010DA5")]
	[FieldOffset(Offset = "0x50")]
	private List<UISprite> m_LightDot;

	[Token(Token = "0x4010DA6")]
	[FieldOffset(Offset = "0x54")]
	private List<UIWorkshopMapItemController> m_WorkShopMapItems;

	[Token(Token = "0x6012633")]
	[Address(RVA = "0x1B8FED0", Offset = "0x1B8FED0", VA = "0x1B8FED0")]
	public UIWorkShopMapDetailPopupWindowController()
	{
	}

	[Token(Token = "0x6012634")]
	[Address(RVA = "0x1B8FF90", Offset = "0x1B8FF90", VA = "0x1B8FF90")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012635")]
	[Address(RVA = "0x1B90038", Offset = "0x1B90038", VA = "0x1B90038", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012636")]
	[Address(RVA = "0x1B90404", Offset = "0x1B90404", VA = "0x1B90404", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6012637")]
	[Address(RVA = "0x1B90468", Offset = "0x1B90468", VA = "0x1B90468", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6012638")]
	[Address(RVA = "0x1B904CC", Offset = "0x1B904CC", VA = "0x1B904CC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6012639")]
	[Address(RVA = "0x1B90530", Offset = "0x1B90530", VA = "0x1B90530")]
	public void SetViewData(uint mapID, string cdnUrl, byte[] bitMapData, byte[] iconMapData, [Optional] Action itemClickCallBack)
	{
	}

	[Token(Token = "0x601263A")]
	[Address(RVA = "0x1B912C8", Offset = "0x1B912C8", VA = "0x1B912C8")]
	private void OnCenterChild(GameObject centerGo)
	{
	}

	[Token(Token = "0x601263B")]
	[Address(RVA = "0x1B91444", Offset = "0x1B91444", VA = "0x1B91444")]
	private void OnLeftBtn()
	{
	}

	[Token(Token = "0x601263C")]
	[Address(RVA = "0x1B915F0", Offset = "0x1B915F0", VA = "0x1B915F0")]
	private void OnRightBtn()
	{
	}

	[Token(Token = "0x601263D")]
	[Address(RVA = "0x1B90F48", Offset = "0x1B90F48", VA = "0x1B90F48")]
	private void RefreshDot()
	{
	}

	[Token(Token = "0x601263E")]
	[Address(RVA = "0x1B917D0", Offset = "0x1B917D0", VA = "0x1B917D0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601263F")]
	[Address(RVA = "0x1B917D8", Offset = "0x1B917D8", VA = "0x1B917D8")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x6012640")]
	[Address(RVA = "0x1B917E0", Offset = "0x1B917E0", VA = "0x1B917E0")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6012641")]
	[Address(RVA = "0x1B917E8", Offset = "0x1B917E8", VA = "0x1B917E8")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
