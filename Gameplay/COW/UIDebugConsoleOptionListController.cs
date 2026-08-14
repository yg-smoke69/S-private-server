using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20020A5")]
public class UIDebugConsoleOptionListController : UIBaseController, _Attribute
{
	[Token(Token = "0x400CC9F")]
	[FieldOffset(Offset = "0x28")]
	private UIDebugConsoleOptionListView m_View;

	[Token(Token = "0x400CCA0")]
	[FieldOffset(Offset = "0x2C")]
	private Action<string> m_OptionHandler;

	[Token(Token = "0x600A858")]
	[Address(RVA = "0x2D79400", Offset = "0x2D79400", VA = "0x2D79400")]
	public UIDebugConsoleOptionListController()
	{
	}

	[Token(Token = "0x600A859")]
	[Address(RVA = "0x2D79484", Offset = "0x2D79484", VA = "0x2D79484")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A85A")]
	[Address(RVA = "0x2D7952C", Offset = "0x2D7952C", VA = "0x2D7952C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A85B")]
	[Address(RVA = "0x2D79624", Offset = "0x2D79624", VA = "0x2D79624", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600A85C")]
	[Address(RVA = "0x2D79688", Offset = "0x2D79688", VA = "0x2D79688")]
	public void InitData(List<string> options, Action<string> handler)
	{
	}

	[Token(Token = "0x600A85D")]
	[Address(RVA = "0x2D797A4", Offset = "0x2D797A4", VA = "0x2D797A4")]
	public void OnOptionSelect(string option)
	{
	}

	[Token(Token = "0x600A85E")]
	[Address(RVA = "0x2D79864", Offset = "0x2D79864", VA = "0x2D79864", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600A85F")]
	[Address(RVA = "0x2D79978", Offset = "0x2D79978", VA = "0x2D79978", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600A860")]
	[Address(RVA = "0x2D799F4", Offset = "0x2D799F4", VA = "0x2D799F4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A861")]
	[Address(RVA = "0x2D799FC", Offset = "0x2D799FC", VA = "0x2D799FC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
