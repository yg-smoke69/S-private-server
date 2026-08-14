using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200260A")]
public class UIEquipSetSelectionController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400EADF")]
	[FieldOffset(Offset = "0x48")]
	private UIEquipSetSelectionView m_View;

	[Token(Token = "0x400EAE0")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelLinkActivity m_Model;

	[Token(Token = "0x400EAE1")]
	[FieldOffset(Offset = "0x50")]
	private bool m_ModelRegistered;

	[Token(Token = "0x400EAE2")]
	[FieldOffset(Offset = "0x54")]
	private UITimeLabelHelper m_TimeHelper;

	[Token(Token = "0x400EAE3")]
	[FieldOffset(Offset = "0x58")]
	private List<UIEquipSetItemController> m_Items;

	[Token(Token = "0x400EAE4")]
	[FieldOffset(Offset = "0x5C")]
	private int m_SelectedIndex;

	[Token(Token = "0x400EAE5")]
	[FieldOffset(Offset = "0x60")]
	private bool m_InGame;

	[Token(Token = "0x400EAE6")]
	[FieldOffset(Offset = "0x64")]
	private int m_SetId;

	[Token(Token = "0x600E0E0")]
	[Address(RVA = "0x19D8544", Offset = "0x19D8544", VA = "0x19D8544")]
	public UIEquipSetSelectionController()
	{
	}

	[Token(Token = "0x600E0E1")]
	[Address(RVA = "0x19D8558", Offset = "0x19D8558", VA = "0x19D8558")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E0E2")]
	[Address(RVA = "0x19D85FC", Offset = "0x19D85FC", VA = "0x19D85FC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E0E3")]
	[Address(RVA = "0x19D892C", Offset = "0x19D892C", VA = "0x19D892C", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600E0E4")]
	[Address(RVA = "0x19D8B50", Offset = "0x19D8B50", VA = "0x19D8B50", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600E0E5")]
	[Address(RVA = "0x19D8BEC", Offset = "0x19D8BEC", VA = "0x19D8BEC")]
	private void SetUIData(int setId)
	{
	}

	[Token(Token = "0x600E0E6")]
	[Address(RVA = "0x19D950C", Offset = "0x19D950C", VA = "0x19D950C", Slot = "48")]
	protected virtual UIEquipSetItemController OpenChildContainer(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600E0E7")]
	[Address(RVA = "0x19D9158", Offset = "0x19D9158", VA = "0x19D9158")]
	private void SetLastTime(DateTime start, DateTime end)
	{
	}

	[Token(Token = "0x600E0E8")]
	[Address(RVA = "0x19D9604", Offset = "0x19D9604", VA = "0x19D9604")]
	public void ShowLobbyWindow()
	{
	}

	[Token(Token = "0x600E0E9")]
	[Address(RVA = "0x19D9748", Offset = "0x19D9748", VA = "0x19D9748")]
	public void ShowInGameWindow(int index, float secs)
	{
	}

	[Token(Token = "0x600E0EA")]
	[Address(RVA = "0x19D9680", Offset = "0x19D9680", VA = "0x19D9680")]
	private void InitUIDataAndShow(bool lobby)
	{
	}

	[Token(Token = "0x600E0EB")]
	[Address(RVA = "0x19D9B84", Offset = "0x19D9B84", VA = "0x19D9B84")]
	private void SetUIDataAndShow()
	{
	}

	[Token(Token = "0x600E0EC")]
	[Address(RVA = "0x19D8844", Offset = "0x19D8844", VA = "0x19D8844")]
	private void ShowContent(bool inGame, bool lobby)
	{
	}

	[Token(Token = "0x600E0ED")]
	[Address(RVA = "0x19D9A40", Offset = "0x19D9A40", VA = "0x19D9A40")]
	private void RequestEquipSets()
	{
	}

	[Token(Token = "0x600E0EE")]
	[Address(RVA = "0x19D9C28", Offset = "0x19D9C28", VA = "0x19D9C28", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E0EF")]
	[Address(RVA = "0x19D9C8C", Offset = "0x19D9C8C", VA = "0x19D9C8C", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E0F0")]
	[Address(RVA = "0x19D99B0", Offset = "0x19D99B0", VA = "0x19D99B0")]
	private void SelectItem(int index)
	{
	}

	[Token(Token = "0x600E0F1")]
	[Address(RVA = "0x19D9D1C", Offset = "0x19D9D1C", VA = "0x19D9D1C")]
	private void HighLightIndex(int index, bool hightlight)
	{
	}

	[Token(Token = "0x600E0F2")]
	[Address(RVA = "0x19D9E54", Offset = "0x19D9E54", VA = "0x19D9E54")]
	private void OnClickConfirm()
	{
	}

	[Token(Token = "0x600E0F3")]
	[Address(RVA = "0x19D9FFC", Offset = "0x19D9FFC", VA = "0x19D9FFC", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E0F4")]
	[Address(RVA = "0x19D89B0", Offset = "0x19D89B0", VA = "0x19D89B0")]
	private void EnableInventory(bool enable)
	{
	}

	[Token(Token = "0x600E0F5")]
	[Address(RVA = "0x19DA078", Offset = "0x19DA078", VA = "0x19DA078")]
	private void Update()
	{
	}

	[Token(Token = "0x600E0F6")]
	[Address(RVA = "0x19DA11C", Offset = "0x19DA11C", VA = "0x19DA11C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E0F7")]
	[Address(RVA = "0x19DA124", Offset = "0x19DA124", VA = "0x19DA124")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600E0F8")]
	[Address(RVA = "0x19DA12C", Offset = "0x19DA12C", VA = "0x19DA12C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600E0F9")]
	[Address(RVA = "0x19DA134", Offset = "0x19DA134", VA = "0x19DA134")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
