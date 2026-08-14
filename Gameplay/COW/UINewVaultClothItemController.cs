using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20029EF")]
public class UINewVaultClothItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x40101E3")]
	[FieldOffset(Offset = "0x38")]
	protected UIStandardItemMAXBController m_standardItemCtrl;

	[Token(Token = "0x40101E4")]
	[FieldOffset(Offset = "0x3C")]
	protected UINewVaultCommonItemView m_View;

	[Token(Token = "0x40101E5")]
	[FieldOffset(Offset = "0x40")]
	protected UINewVaultItemViewData m_data;

	[Token(Token = "0x40101E6")]
	[FieldOffset(Offset = "0x44")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x40101E7")]
	[FieldOffset(Offset = "0x48")]
	private UIModelAvatar m_ModelAvatar;

	[Token(Token = "0x40101E8")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_IsItemABReady;

	[Token(Token = "0x40101E9")]
	[FieldOffset(Offset = "0x4D")]
	private bool m_IsLockItem;

	[Token(Token = "0x40101EA")]
	[FieldOffset(Offset = "0x4E")]
	private bool m_IsInvalid;

	[Token(Token = "0x40101EB")]
	[FieldOffset(Offset = "0x4F")]
	private bool m_IsInvalidForAvatar;

	[Token(Token = "0x40101EC")]
	[FieldOffset(Offset = "0x50")]
	private bool m_SkipClothesForAvatar;

	[Token(Token = "0x40101ED")]
	[FieldOffset(Offset = "0x54")]
	private uint m_UseRankLevel;

	[Token(Token = "0x40101EE")]
	[FieldOffset(Offset = "0x58")]
	private bool m_IsReachUseRankLevel;

	[Token(Token = "0x40101EF")]
	[FieldOffset(Offset = "0x5C")]
	private UINewVaultController m_UINewVaultController;

	[Token(Token = "0x40101F0")]
	[FieldOffset(Offset = "0x60")]
	private FrontEndPreviewComponent_NewVault m_FrontEndPreviewComponent;

	[Token(Token = "0x40101F1")]
	[FieldOffset(Offset = "0x64")]
	private InventoryClothShowingInfo m_curClothShowingInfo;

	[Token(Token = "0x40101F2")]
	[FieldOffset(Offset = "0x68")]
	private Item m_curProtoItem;

	[Token(Token = "0x40101F3")]
	[FieldOffset(Offset = "0x6C")]
	private CSSharedItemData m_curCSSharedItemData;

	[Token(Token = "0x6010E4D")]
	[Address(RVA = "0x27B3E94", Offset = "0x27B3E94", VA = "0x27B3E94")]
	public UINewVaultClothItemController()
	{
	}

	[Token(Token = "0x6010E4E")]
	[Address(RVA = "0x27B3EA4", Offset = "0x27B3EA4", VA = "0x27B3EA4")]
	public UINewVaultItemViewData GetData()
	{
		return null;
	}

	[Token(Token = "0x6010E4F")]
	[Address(RVA = "0x27B3EFC", Offset = "0x27B3EFC", VA = "0x27B3EFC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010E50")]
	[Address(RVA = "0x27B3FA4", Offset = "0x27B3FA4", VA = "0x27B3FA4")]
	private void ClearContent()
	{
	}

	[Token(Token = "0x6010E51")]
	[Address(RVA = "0x27B42C4", Offset = "0x27B42C4", VA = "0x27B42C4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010E52")]
	[Address(RVA = "0x27B4770", Offset = "0x27B4770", VA = "0x27B4770")]
	public void SetFrontEndPreviewComponent(FrontEndPreviewComponent_NewVault comp)
	{
	}

	[Token(Token = "0x6010E53")]
	[Address(RVA = "0x27B4868", Offset = "0x27B4868", VA = "0x27B4868")]
	private void ShowNotReachRankUseLevelTips(int rank)
	{
	}

	[Token(Token = "0x6010E54")]
	[Address(RVA = "0x27B4BCC", Offset = "0x27B4BCC", VA = "0x27B4BCC", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x6010E55")]
	[Address(RVA = "0x27B4C54", Offset = "0x27B4C54", VA = "0x27B4C54")]
	public void OnlyShowPreviewItem()
	{
	}

	[Token(Token = "0x6010E56")]
	[Address(RVA = "0x27B5828", Offset = "0x27B5828", VA = "0x27B5828", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x6010E57")]
	[Address(RVA = "0x27B5644", Offset = "0x27B5644", VA = "0x27B5644")]
	private void ClickDefaultClothStyle()
	{
	}

	[Token(Token = "0x6010E58")]
	[Address(RVA = "0x27B5280", Offset = "0x27B5280", VA = "0x27B5280")]
	private void UpdateLocalAvatarCloth(List<uint> checkOptionalIds)
	{
	}

	[Token(Token = "0x6010E59")]
	[Address(RVA = "0x27B6660", Offset = "0x27B6660", VA = "0x27B6660")]
	private void UpdatePreviewClothItem()
	{
	}

	[Token(Token = "0x6010E5A")]
	[Address(RVA = "0x27B6708", Offset = "0x27B6708", VA = "0x27B6708")]
	private void OnSwitchColor(object[] data)
	{
	}

	[Token(Token = "0x6010E5B")]
	[Address(RVA = "0x27B6F78", Offset = "0x27B6F78", VA = "0x27B6F78")]
	public void RefreshABReadyState()
	{
	}

	[Token(Token = "0x6010E5C")]
	[Address(RVA = "0x27B73E0", Offset = "0x27B73E0", VA = "0x27B73E0", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6010E5D")]
	[Address(RVA = "0x27B6904", Offset = "0x27B6904", VA = "0x27B6904")]
	private void RefreshUI()
	{
	}

	[Token(Token = "0x6010E5E")]
	[Address(RVA = "0x27B728C", Offset = "0x27B728C", VA = "0x27B728C")]
	public void RefreshABReady()
	{
	}

	[Token(Token = "0x6010E5F")]
	[Address(RVA = "0x27B7210", Offset = "0x27B7210", VA = "0x27B7210")]
	private void HideIconAndBG()
	{
	}

	[Token(Token = "0x6010E60")]
	[Address(RVA = "0x27B863C", Offset = "0x27B863C", VA = "0x27B863C")]
	private void SetRankingItemIcon()
	{
	}

	[Token(Token = "0x6010E61")]
	[Address(RVA = "0x27B84AC", Offset = "0x27B84AC", VA = "0x27B84AC")]
	private void CheckClothIsInvalid(InventoryClothInfo data)
	{
	}

	[Token(Token = "0x6010E62")]
	[Address(RVA = "0x27B8BF8", Offset = "0x27B8BF8", VA = "0x27B8BF8", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010E63")]
	[Address(RVA = "0x27B8C6C", Offset = "0x27B8C6C", VA = "0x27B8C6C", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010E64")]
	[Address(RVA = "0x27B89C4", Offset = "0x27B89C4", VA = "0x27B89C4")]
	public void RefreshEquipState()
	{
	}

	[Token(Token = "0x6010E65")]
	[Address(RVA = "0x27B8CD0", Offset = "0x27B8CD0", VA = "0x27B8CD0")]
	public void RefreshNewGetState()
	{
	}

	[Token(Token = "0x6010E66")]
	[Address(RVA = "0x27B8E48", Offset = "0x27B8E48", VA = "0x27B8E48")]
	public void RemoteConsoleChangeClother(uint ItemId)
	{
	}

	[Token(Token = "0x6010E67")]
	[Address(RVA = "0x27B9290", Offset = "0x27B9290", VA = "0x27B9290")]
	private Item Test_GetProtoItembyId(uint iid)
	{
		return null;
	}

	[Token(Token = "0x6010E68")]
	[Address(RVA = "0x27B7C3C", Offset = "0x27B7C3C", VA = "0x27B7C3C")]
	public void Test_SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6010E69")]
	[Address(RVA = "0x27B9380", Offset = "0x27B9380", VA = "0x27B9380")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010E6A")]
	[Address(RVA = "0x27B9388", Offset = "0x27B9388", VA = "0x27B9388")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x6010E6B")]
	[Address(RVA = "0x27B9390", Offset = "0x27B9390", VA = "0x27B9390")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}
}
