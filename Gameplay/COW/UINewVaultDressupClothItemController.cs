using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20029F9")]
public class UINewVaultDressupClothItemController : UIEasyListItemController
{
	[Token(Token = "0x4010267")]
	[FieldOffset(Offset = "0x38")]
	protected UIStandardItemMAXBController m_standardItemCtrl;

	[Token(Token = "0x4010268")]
	[FieldOffset(Offset = "0x3C")]
	protected UINewVaultCommonItemView m_View;

	[Token(Token = "0x4010269")]
	[FieldOffset(Offset = "0x40")]
	protected UINewVaultItemViewData m_data;

	[Token(Token = "0x401026A")]
	[FieldOffset(Offset = "0x44")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x401026B")]
	[FieldOffset(Offset = "0x48")]
	private UIModelAvatar m_ModelAvatar;

	[Token(Token = "0x401026C")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelDressUp m_ModelDressUp;

	[Token(Token = "0x401026D")]
	[FieldOffset(Offset = "0x50")]
	private object m_Data;

	[Token(Token = "0x401026E")]
	[FieldOffset(Offset = "0x54")]
	private bool m_IsItemABReady;

	[Token(Token = "0x401026F")]
	[FieldOffset(Offset = "0x55")]
	private bool m_IsInvalid;

	[Token(Token = "0x4010270")]
	[FieldOffset(Offset = "0x56")]
	private bool m_IsInvalidForAvatar;

	[Token(Token = "0x4010271")]
	[FieldOffset(Offset = "0x57")]
	private bool m_SkipClothesForAvatar;

	[Token(Token = "0x4010272")]
	[FieldOffset(Offset = "0x58")]
	private uint m_UseRankLevel;

	[Token(Token = "0x4010273")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_IsReachUseRankLevel;

	[Token(Token = "0x4010274")]
	[FieldOffset(Offset = "0x60")]
	private ShowBoostAvatarParams m_ShowBoostAvatarParams;

	[Token(Token = "0x4010275")]
	[FieldOffset(Offset = "0x64")]
	private InventoryClothShowingInfo m_curClothShowingInfo;

	[Token(Token = "0x4010276")]
	[FieldOffset(Offset = "0x68")]
	private Item m_curProtoItem;

	[Token(Token = "0x4010277")]
	[FieldOffset(Offset = "0x6C")]
	private CSSharedItemData m_curCSSharedItemData;

	[Token(Token = "0x6010F24")]
	[Address(RVA = "0x2C1B520", Offset = "0x2C1B520", VA = "0x2C1B520")]
	public UINewVaultDressupClothItemController()
	{
	}

	[Token(Token = "0x6010F25")]
	[Address(RVA = "0x2C1B530", Offset = "0x2C1B530", VA = "0x2C1B530")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010F26")]
	[Address(RVA = "0x2C1B5D8", Offset = "0x2C1B5D8", VA = "0x2C1B5D8")]
	private void ClearContent()
	{
	}

	[Token(Token = "0x6010F27")]
	[Address(RVA = "0x2C1B8F4", Offset = "0x2C1B8F4", VA = "0x2C1B8F4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010F28")]
	[Address(RVA = "0x2C1BD54", Offset = "0x2C1BD54", VA = "0x2C1BD54")]
	private void OnRefreshDownload(object[] data)
	{
	}

	[Token(Token = "0x6010F29")]
	[Address(RVA = "0x2C1BFC8", Offset = "0x2C1BFC8", VA = "0x2C1BFC8")]
	private void RefreshStateSprite()
	{
	}

	[Token(Token = "0x6010F2A")]
	[Address(RVA = "0x2C1C284", Offset = "0x2C1C284", VA = "0x2C1C284")]
	private void OnRefreshCollection(object[] data)
	{
	}

	[Token(Token = "0x6010F2B")]
	[Address(RVA = "0x2C1C2EC", Offset = "0x2C1C2EC", VA = "0x2C1C2EC")]
	private void ShowNotReachRankUseLevelTips(int rank)
	{
	}

	[Token(Token = "0x6010F2C")]
	[Address(RVA = "0x2C1C650", Offset = "0x2C1C650", VA = "0x2C1C650", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x6010F2D")]
	[Address(RVA = "0x2C1C6D8", Offset = "0x2C1C6D8", VA = "0x2C1C6D8", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x6010F2E")]
	[Address(RVA = "0x2C1CABC", Offset = "0x2C1CABC", VA = "0x2C1CABC", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6010F2F")]
	[Address(RVA = "0x2C1D4A8", Offset = "0x2C1D4A8", VA = "0x2C1D4A8")]
	private void RefreshUI()
	{
	}

	[Token(Token = "0x6010F30")]
	[Address(RVA = "0x2C1BF4C", Offset = "0x2C1BF4C", VA = "0x2C1BF4C")]
	private void HideIconAndBG()
	{
	}

	[Token(Token = "0x6010F31")]
	[Address(RVA = "0x2C1DE80", Offset = "0x2C1DE80", VA = "0x2C1DE80")]
	public void RefreshEquipState()
	{
	}

	[Token(Token = "0x6010F32")]
	[Address(RVA = "0x2C1DAF8", Offset = "0x2C1DAF8", VA = "0x2C1DAF8")]
	private void SetRankingItemIcon()
	{
	}

	[Token(Token = "0x6010F33")]
	[Address(RVA = "0x2C1D968", Offset = "0x2C1D968", VA = "0x2C1D968")]
	private void CheckClothIsInvalid(InventoryClothInfo data)
	{
	}

	[Token(Token = "0x6010F34")]
	[Address(RVA = "0x2C1DEE0", Offset = "0x2C1DEE0", VA = "0x2C1DEE0")]
	private void OnSwitchColor(object[] data)
	{
	}

	[Token(Token = "0x6010F35")]
	[Address(RVA = "0x2C1E058", Offset = "0x2C1E058", VA = "0x2C1E058")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010F36")]
	[Address(RVA = "0x2C1E060", Offset = "0x2C1E060", VA = "0x2C1E060")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x6010F37")]
	[Address(RVA = "0x2C1E068", Offset = "0x2C1E068", VA = "0x2C1E068")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}
}
