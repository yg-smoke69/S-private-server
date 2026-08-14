using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200264A")]
public class UIGachaLegendaryTempBagPackWndController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x400EC7B")]
	[FieldOffset(Offset = "0x48")]
	private UIGachaLegendaryTempBagPackWndView m_View;

	[Token(Token = "0x400EC7C")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_QuickSelect;

	[Token(Token = "0x400EC7D")]
	[FieldOffset(Offset = "0x50")]
	private int m_ItemToChangeNum;

	[Token(Token = "0x400EC7E")]
	[FieldOffset(Offset = "0x54")]
	private UIModelGacha m_Model;

	[Token(Token = "0x400EC7F")]
	[FieldOffset(Offset = "0x58")]
	private uint m_GachaID;

	[Token(Token = "0x400EC80")]
	[FieldOffset(Offset = "0x5C")]
	private List<uint> m_CurrentItemsInTempBag;

	[Token(Token = "0x400EC81")]
	[FieldOffset(Offset = "0x60")]
	public List<UIGachaLegendaryTempBagPackItemState> m_States;

	[Token(Token = "0x600E46A")]
	[Address(RVA = "0x2E6B690", Offset = "0x2E6B690", VA = "0x2E6B690")]
	public UIGachaLegendaryTempBagPackWndController()
	{
	}

	[Token(Token = "0x600E46B")]
	[Address(RVA = "0x2E6B760", Offset = "0x2E6B760", VA = "0x2E6B760")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E46C")]
	[Address(RVA = "0x2E6B804", Offset = "0x2E6B804", VA = "0x2E6B804", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E46D")]
	[Address(RVA = "0x2E6BC74", Offset = "0x2E6BC74", VA = "0x2E6BC74", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E46E")]
	[Address(RVA = "0x2E6BE1C", Offset = "0x2E6BE1C", VA = "0x2E6BE1C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600E46F")]
	[Address(RVA = "0x2E6BEA4", Offset = "0x2E6BEA4", VA = "0x2E6BEA4", Slot = "31")]
	public override string Rule()
	{
		return null;
	}

	[Token(Token = "0x600E470")]
	[Address(RVA = "0x2E6BFC8", Offset = "0x2E6BFC8", VA = "0x2E6BFC8")]
	public void SetViewData(uint GachaID, List<uint> itemsInTempBag)
	{
	}

	[Token(Token = "0x600E471")]
	[Address(RVA = "0x2E6C3F8", Offset = "0x2E6C3F8", VA = "0x2E6C3F8")]
	public void SetNoItemInBagState()
	{
	}

	[Token(Token = "0x600E472")]
	[Address(RVA = "0x2E6C95C", Offset = "0x2E6C95C", VA = "0x2E6C95C")]
	public void ClearAllSelectToggle()
	{
	}

	[Token(Token = "0x600E473")]
	[Address(RVA = "0x2E69730", Offset = "0x2E69730", VA = "0x2E69730")]
	public void OnToggleSelected()
	{
	}

	[Token(Token = "0x600E474")]
	[Address(RVA = "0x2E6CBD4", Offset = "0x2E6CBD4", VA = "0x2E6CBD4")]
	private void OnQuickSelectItemBtnClick()
	{
	}

	[Token(Token = "0x600E475")]
	[Address(RVA = "0x2E6D69C", Offset = "0x2E6D69C", VA = "0x2E6D69C")]
	private void OnRandomClick()
	{
	}

	[Token(Token = "0x600E476")]
	[Address(RVA = "0x2E6DC98", Offset = "0x2E6DC98", VA = "0x2E6DC98")]
	private List<uint> AdjustStateList(List<uint> SelectedItems)
	{
		return null;
	}

	[Token(Token = "0x600E477")]
	[Address(RVA = "0x2E6DE64", Offset = "0x2E6DE64", VA = "0x2E6DE64")]
	private void OnGainClick()
	{
	}

	[Token(Token = "0x600E478")]
	[Address(RVA = "0x2E6C5E8", Offset = "0x2E6C5E8", VA = "0x2E6C5E8")]
	private void RefreshGridView(List<uint> dataList)
	{
	}

	[Token(Token = "0x600E479")]
	[Address(RVA = "0x2E6E478", Offset = "0x2E6E478", VA = "0x2E6E478", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600E47A")]
	[Address(RVA = "0x2E6E570", Offset = "0x2E6E570", VA = "0x2E6E570", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600E47B")]
	[Address(RVA = "0x2E6E5EC", Offset = "0x2E6E5EC", VA = "0x2E6E5EC")]
	private void RefreshBagItems()
	{
	}

	[Token(Token = "0x600E47C")]
	[Address(RVA = "0x2E6E7B4", Offset = "0x2E6E7B4", VA = "0x2E6E7B4", Slot = "49")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E47D")]
	[Address(RVA = "0x2E6E86C", Offset = "0x2E6E86C", VA = "0x2E6E86C", Slot = "48")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E47E")]
	[Address(RVA = "0x2E6EA98", Offset = "0x2E6EA98", VA = "0x2E6EA98")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E47F")]
	[Address(RVA = "0x2E6EAA0", Offset = "0x2E6EAA0", VA = "0x2E6EAA0")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E480")]
	[Address(RVA = "0x2E6EAA8", Offset = "0x2E6EAA8", VA = "0x2E6EAA8")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600E481")]
	[Address(RVA = "0x2E6EAB0", Offset = "0x2E6EAB0", VA = "0x2E6EAB0")]
	public string _003C_003EiFixBaseProxy_Rule()
	{
		return null;
	}
}
