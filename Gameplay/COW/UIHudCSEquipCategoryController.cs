using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200203E")]
internal class UIHudCSEquipCategoryController : UIBaseController
{
	[Token(Token = "0x200203F")]
	private sealed class _003CSetMysteryBoxUI_003Ec__AnonStorey0
	{
		[Token(Token = "0x400CA35")]
		[FieldOffset(Offset = "0x8")]
		internal List<uint> qualityList;

		[Token(Token = "0x600A3C8")]
		[Address(RVA = "0x1F02788", Offset = "0x1F02788", VA = "0x1F02788")]
		public _003CSetMysteryBoxUI_003Ec__AnonStorey0()
		{
		}
	}

	[Token(Token = "0x2002040")]
	private sealed class _003CSetMysteryBoxUI_003Ec__AnonStorey1
	{
		[Token(Token = "0x400CA36")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x400CA37")]
		[FieldOffset(Offset = "0xC")]
		internal _003CSetMysteryBoxUI_003Ec__AnonStorey0 _003C_003Ef__ref_00240;

		[Token(Token = "0x600A3C9")]
		[Address(RVA = "0x1F02790", Offset = "0x1F02790", VA = "0x1F02790")]
		public _003CSetMysteryBoxUI_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600A3CA")]
		[Address(RVA = "0x1F02B14", Offset = "0x1F02B14", VA = "0x1F02B14")]
		internal bool _003C_003Em__0(CSShopItemData item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400CA2B")]
	[FieldOffset(Offset = "0x28")]
	private UIHudInGameShopCategoryView m_View;

	[Token(Token = "0x400CA2C")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudCSEquipItemController m_FirstItem;

	[Token(Token = "0x400CA2D")]
	[FieldOffset(Offset = "0x30")]
	private uint m_Filter;

	[Token(Token = "0x400CA2E")]
	[FieldOffset(Offset = "0x34")]
	private List<CSShopItemData> m_MysteryBoxItemDataList;

	[Token(Token = "0x400CA2F")]
	[FieldOffset(Offset = "0x38")]
	private List<UIHudCSEquipItemController> m_ChildMysteryBoxController;

	[Token(Token = "0x400CA30")]
	[FieldOffset(Offset = "0x3C")]
	private List<UIToggleButton> m_ToggleList;

	[Token(Token = "0x400CA31")]
	[FieldOffset(Offset = "0x40")]
	private bool m_UIDirty;

	[Token(Token = "0x400CA32")]
	[FieldOffset(Offset = "0x44")]
	private uint m_TopQuality;

	[Token(Token = "0x400CA33")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<uint, UIHudCSEquipItemController> m_itemMap;

	[Token(Token = "0x400CA34")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<uint> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17000FD6")]
	public UIHudCSEquipItemController FirstItem
	{
		[Token(Token = "0x600A3BC")]
		[Address(RVA = "0x1EFFD38", Offset = "0x1EFFD38", VA = "0x1EFFD38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A3BA")]
	[Address(RVA = "0x1EFFB8C", Offset = "0x1EFFB8C", VA = "0x1EFFB8C")]
	public UIHudCSEquipCategoryController()
	{
	}

	[Token(Token = "0x600A3BB")]
	[Address(RVA = "0x1EFFCE0", Offset = "0x1EFFCE0", VA = "0x1EFFCE0")]
	public uint Filter()
	{
		return default(uint);
	}

	[Token(Token = "0x600A3BD")]
	[Address(RVA = "0x1EFFD90", Offset = "0x1EFFD90", VA = "0x1EFFD90")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A3BE")]
	[Address(RVA = "0x1EFFE38", Offset = "0x1EFFE38", VA = "0x1EFFE38", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A3BF")]
	[Address(RVA = "0x1EFFEF4", Offset = "0x1EFFEF4", VA = "0x1EFFEF4")]
	public void SetUIData(uint filter, List<CSShopItemData> itemList)
	{
	}

	[Token(Token = "0x600A3C0")]
	[Address(RVA = "0x1F01EBC", Offset = "0x1F01EBC", VA = "0x1F01EBC")]
	public void RefreshUIData(uint filter, List<CSShopItemData> itemList, bool isPurchaseRefresh = false)
	{
	}

	[Token(Token = "0x600A3C1")]
	[Address(RVA = "0x1F02284", Offset = "0x1F02284", VA = "0x1F02284", Slot = "31")]
	protected virtual UIHudCSEquipItemController CreateItem(Transform container)
	{
		return null;
	}

	[Token(Token = "0x600A3C2")]
	[Address(RVA = "0x1F004B0", Offset = "0x1F004B0", VA = "0x1F004B0")]
	private void SetFilterLabel(uint filter)
	{
	}

	[Token(Token = "0x600A3C3")]
	[Address(RVA = "0x1F0237C", Offset = "0x1F0237C", VA = "0x1F0237C")]
	public void SetBombUIData(uint filter, List<TDMLikeShopConfigData> dataList)
	{
	}

	[Token(Token = "0x600A3C4")]
	[Address(RVA = "0x1F01568", Offset = "0x1F01568", VA = "0x1F01568")]
	private bool SetMysteryBoxUI()
	{
		return default(bool);
	}

	[Token(Token = "0x600A3C5")]
	[Address(RVA = "0x1F02808", Offset = "0x1F02808", VA = "0x1F02808")]
	public bool UpdateMysteryBoxUI()
	{
		return default(bool);
	}

	[Token(Token = "0x600A3C6")]
	[Address(RVA = "0x1F02AE4", Offset = "0x1F02AE4", VA = "0x1F02AE4")]
	private static int _003CSetMysteryBoxUI_003Em__0(uint a, uint b)
	{
		return default(int);
	}

	[Token(Token = "0x600A3C7")]
	[Address(RVA = "0x1F02B0C", Offset = "0x1F02B0C", VA = "0x1F02B0C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
