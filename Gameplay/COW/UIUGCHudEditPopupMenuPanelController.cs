using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200242A")]
public class UIUGCHudEditPopupMenuPanelController : UIPopupWindowController
{
	[Token(Token = "0x200242B")]
	public class MenuItemData
	{
		[Token(Token = "0x400E123")]
		[FieldOffset(Offset = "0x8")]
		public string text;

		[Token(Token = "0x400E124")]
		[FieldOffset(Offset = "0xC")]
		public Action callback;

		[Token(Token = "0x600CCFE")]
		[Address(RVA = "0x2FE9618", Offset = "0x2FE9618", VA = "0x2FE9618")]
		public MenuItemData(string text, Action callback)
		{
		}
	}

	[Token(Token = "0x200242C")]
	private sealed class _003CInitMenuItem_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E125")]
		[FieldOffset(Offset = "0x8")]
		internal MenuItemData itemData;

		[Token(Token = "0x400E126")]
		[FieldOffset(Offset = "0xC")]
		internal UIUGCHudEditPopupMenuPanelController _0024this;

		[Token(Token = "0x600CCFF")]
		[Address(RVA = "0x2FEDBF4", Offset = "0x2FEDBF4", VA = "0x2FEDBF4")]
		public _003CInitMenuItem_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600CD00")]
		[Address(RVA = "0x2FEDC0C", Offset = "0x2FEDC0C", VA = "0x2FEDC0C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400E11F")]
	private const int DEFAULT_WIDTH = 180;

	[Token(Token = "0x400E120")]
	[FieldOffset(Offset = "0x48")]
	private UIUGCHudEditPopupMenuPanelView m_View;

	[Token(Token = "0x400E121")]
	[FieldOffset(Offset = "0x4C")]
	private int m_ItemHeight;

	[Token(Token = "0x400E122")]
	[FieldOffset(Offset = "0x50")]
	private Vector2 m_Padding;

	[Token(Token = "0x600CCF4")]
	[Address(RVA = "0x2FED0D4", Offset = "0x2FED0D4", VA = "0x2FED0D4")]
	public UIUGCHudEditPopupMenuPanelController()
	{
	}

	[Token(Token = "0x600CCF5")]
	[Address(RVA = "0x2FED180", Offset = "0x2FED180", VA = "0x2FED180")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CCF6")]
	[Address(RVA = "0x2FED224", Offset = "0x2FED224", VA = "0x2FED224", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CCF7")]
	[Address(RVA = "0x2FED500", Offset = "0x2FED500", VA = "0x2FED500", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x600CCF8")]
	[Address(RVA = "0x2FEB60C", Offset = "0x2FEB60C", VA = "0x2FEB60C")]
	public void SetMenus(Vector3 position, MenuItemData[] itemDatas)
	{
	}

	[Token(Token = "0x600CCF9")]
	[Address(RVA = "0x2FED558", Offset = "0x2FED558", VA = "0x2FED558")]
	public void SetWidth(int width)
	{
	}

	[Token(Token = "0x600CCFA")]
	[Address(RVA = "0x2FED5F0", Offset = "0x2FED5F0", VA = "0x2FED5F0")]
	private void InitMenuItems(MenuItemData[] itemDatas)
	{
	}

	[Token(Token = "0x600CCFB")]
	[Address(RVA = "0x2FED934", Offset = "0x2FED934", VA = "0x2FED934")]
	private void InitMenuItem(GameObject item, MenuItemData itemData)
	{
	}

	[Token(Token = "0x600CCFC")]
	[Address(RVA = "0x2FEDBFC", Offset = "0x2FEDBFC", VA = "0x2FEDBFC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CCFD")]
	[Address(RVA = "0x2FEDC04", Offset = "0x2FEDC04", VA = "0x2FEDC04")]
	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return default(bool);
	}
}
