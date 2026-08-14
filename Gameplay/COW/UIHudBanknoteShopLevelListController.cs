using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026E5")]
internal class UIHudBanknoteShopLevelListController : UIBaseController
{
	[Token(Token = "0x400F041")]
	[FieldOffset(Offset = "0x28")]
	private UIHudBanknoteShopLevelListView m_View;

	[Token(Token = "0x400F042")]
	[FieldOffset(Offset = "0x2C")]
	private UIOneLevelEquipList m_equipView;

	[Token(Token = "0x400F043")]
	[FieldOffset(Offset = "0x30")]
	private List<UIHudBanknoteShopItemController> m_ItemList;

	[Token(Token = "0x400F044")]
	[FieldOffset(Offset = "0x34")]
	private int m_SelectedIndex;

	[Token(Token = "0x170011AB")]
	public int SelectedIndex
	{
		[Token(Token = "0x600EBBB")]
		[Address(RVA = "0x171EDBC", Offset = "0x171EDBC", VA = "0x171EDBC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600EBBA")]
	[Address(RVA = "0x171ED38", Offset = "0x171ED38", VA = "0x171ED38")]
	public UIHudBanknoteShopLevelListController()
	{
	}

	[Token(Token = "0x600EBBC")]
	[Address(RVA = "0x171EE14", Offset = "0x171EE14", VA = "0x171EE14", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EBBD")]
	[Address(RVA = "0x171EF0C", Offset = "0x171EF0C", VA = "0x171EF0C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EBBE")]
	[Address(RVA = "0x171EFB0", Offset = "0x171EFB0", VA = "0x171EFB0")]
	public void InitItems(List<uint> items, int level, bool isMaxLevel, int OneLevelSetCount)
	{
	}

	[Token(Token = "0x600EBBF")]
	[Address(RVA = "0x171F520", Offset = "0x171F520", VA = "0x171F520")]
	public void InitOneItem(int itemid, int index)
	{
	}

	[Token(Token = "0x600EBC0")]
	[Address(RVA = "0x171F764", Offset = "0x171F764", VA = "0x171F764")]
	public void OnItemSelected(int selectedIndex)
	{
	}

	[Token(Token = "0x600EBC1")]
	[Address(RVA = "0x171F7D0", Offset = "0x171F7D0", VA = "0x171F7D0")]
	public void RefreshItemsSelectedState()
	{
	}

	[Token(Token = "0x600EBC2")]
	[Address(RVA = "0x171F9A0", Offset = "0x171F9A0", VA = "0x171F9A0")]
	public void UpdateUnlockInfo(bool isUnlocked, int unlockItemIndex)
	{
	}

	[Token(Token = "0x600EBC3")]
	[Address(RVA = "0x171FB20", Offset = "0x171FB20", VA = "0x171FB20")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
