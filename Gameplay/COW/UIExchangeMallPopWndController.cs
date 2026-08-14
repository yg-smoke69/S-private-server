using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20021B7")]
public class UIExchangeMallPopWndController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400D307")]
	[FieldOffset(Offset = "0x48")]
	private UIExchangeMallPopWndView m_View;

	[Token(Token = "0x400D308")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelMall m_ModelMall;

	[Token(Token = "0x400D309")]
	[FieldOffset(Offset = "0x50")]
	private uint m_CurrencyId;

	[Token(Token = "0x400D30A")]
	[FieldOffset(Offset = "0x54")]
	private uint m_CommodityId;

	[Token(Token = "0x400D30B")]
	private const uint CURRENCY_BTN_GREY = 2139062271u;

	[Token(Token = "0x400D30C")]
	private const uint CURRENCY_LABEL_GREY = 2139062271u;

	[Token(Token = "0x400D30D")]
	[FieldOffset(Offset = "0x58")]
	private List<ExchangeStoreItemDesc> m_CurrentDataList;

	[Token(Token = "0x600B3DC")]
	[Address(RVA = "0x19E6BE4", Offset = "0x19E6BE4", VA = "0x19E6BE4")]
	public UIExchangeMallPopWndController()
	{
	}

	[Token(Token = "0x600B3DD")]
	[Address(RVA = "0x19E6BEC", Offset = "0x19E6BEC", VA = "0x19E6BEC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B3DE")]
	[Address(RVA = "0x19E6C94", Offset = "0x19E6C94", VA = "0x19E6C94", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B3DF")]
	[Address(RVA = "0x19E6F98", Offset = "0x19E6F98", VA = "0x19E6F98", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B3E0")]
	[Address(RVA = "0x19E7128", Offset = "0x19E7128", VA = "0x19E7128")]
	public void SetViewData(uint currencyId, string titleKey)
	{
	}

	[Token(Token = "0x600B3E1")]
	[Address(RVA = "0x19E7390", Offset = "0x19E7390", VA = "0x19E7390")]
	private void RefreshViewData(bool needResort = true)
	{
	}

	[Token(Token = "0x600B3E2")]
	[Address(RVA = "0x19E77AC", Offset = "0x19E77AC", VA = "0x19E77AC")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600B3E3")]
	[Address(RVA = "0x19E7840", Offset = "0x19E7840", VA = "0x19E7840")]
	private void OnRewardWndClose(object[] data)
	{
	}

	[Token(Token = "0x600B3E4")]
	[Address(RVA = "0x19E7520", Offset = "0x19E7520", VA = "0x19E7520")]
	private void RefreshExchangeNum()
	{
	}

	[Token(Token = "0x600B3E5")]
	[Address(RVA = "0x19E7AE8", Offset = "0x19E7AE8", VA = "0x19E7AE8")]
	private void OnExchangeItemSelect(object[] data)
	{
	}

	[Token(Token = "0x600B3E6")]
	[Address(RVA = "0x19E7BD8", Offset = "0x19E7BD8", VA = "0x19E7BD8")]
	private void RefreshItemView(uint commodityID)
	{
	}

	[Token(Token = "0x600B3E7")]
	[Address(RVA = "0x19E801C", Offset = "0x19E801C", VA = "0x19E801C")]
	private void SetMoneyBtnData(ExchangeStoreItemDesc exchangeItemDesc)
	{
	}

	[Token(Token = "0x600B3E8")]
	[Address(RVA = "0x19E8314", Offset = "0x19E8314", VA = "0x19E8314")]
	private void MoneyBtnColorGrey()
	{
	}

	[Token(Token = "0x600B3E9")]
	[Address(RVA = "0x19E847C", Offset = "0x19E847C", VA = "0x19E847C")]
	private void MoneyBtnColorReset()
	{
	}

	[Token(Token = "0x600B3EA")]
	[Address(RVA = "0x19E85D0", Offset = "0x19E85D0", VA = "0x19E85D0")]
	private void OnBtnExchangeClick()
	{
	}

	[Token(Token = "0x600B3EB")]
	[Address(RVA = "0x19E8BEC", Offset = "0x19E8BEC", VA = "0x19E8BEC", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600B3EC")]
	[Address(RVA = "0x19E8CE4", Offset = "0x19E8CE4", VA = "0x19E8CE4", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600B3ED")]
	[Address(RVA = "0x19E8D60", Offset = "0x19E8D60", VA = "0x19E8D60")]
	private bool _003COnRewardWndClose_003Em__0(ExchangeStoreItemDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x600B3EE")]
	[Address(RVA = "0x19E8D98", Offset = "0x19E8D98", VA = "0x19E8D98")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B3EF")]
	[Address(RVA = "0x19E8DA0", Offset = "0x19E8DA0", VA = "0x19E8DA0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
