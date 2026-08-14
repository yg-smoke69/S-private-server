using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2001E92")]
internal class UIBigEvent_GlobalProgress_ExchangeStoreController : UINaviPopController, _Attribute, IConvertible
{
	[Token(Token = "0x400C032")]
	[FieldOffset(Offset = "0x70")]
	private UIBigEvent_GlobalProgress_ExchangeStoreView m_View;

	[Token(Token = "0x400C033")]
	[FieldOffset(Offset = "0x74")]
	private UIModelBigEventTemplate m_ModelBigEventTemplate;

	[Token(Token = "0x400C034")]
	[FieldOffset(Offset = "0x78")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x400C035")]
	[FieldOffset(Offset = "0x7C")]
	private EStoreTab m_StoreTab;

	[Token(Token = "0x400C036")]
	[FieldOffset(Offset = "0x80")]
	private Color m_StoreTabNotChoose;

	[Token(Token = "0x400C037")]
	[FieldOffset(Offset = "0x90")]
	private Color m_StoreTabChosen;

	[Token(Token = "0x400C038")]
	[FieldOffset(Offset = "0xA0")]
	private bool m_ClassicStoreLock;

	[Token(Token = "0x400C039")]
	[FieldOffset(Offset = "0xA1")]
	private bool m_SpecialStoreLock;

	[Token(Token = "0x400C03A")]
	[FieldOffset(Offset = "0xA4")]
	private int m_TokenNums;

	[Token(Token = "0x400C03B")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<CustomEventStoreCommodityDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400C03C")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<CustomEventStoreCommodityDesc> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x6009346")]
	[Address(RVA = "0x3020C58", Offset = "0x3020C58", VA = "0x3020C58")]
	public UIBigEvent_GlobalProgress_ExchangeStoreController()
	{
	}

	[Token(Token = "0x6009347")]
	[Address(RVA = "0x3020CC4", Offset = "0x3020CC4", VA = "0x3020CC4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009348")]
	[Address(RVA = "0x3020D6C", Offset = "0x3020D6C", VA = "0x3020D6C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009349")]
	[Address(RVA = "0x3021344", Offset = "0x3021344", VA = "0x3021344", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600934A")]
	[Address(RVA = "0x3021418", Offset = "0x3021418", VA = "0x3021418", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x600934B")]
	[Address(RVA = "0x302147C", Offset = "0x302147C", VA = "0x302147C")]
	private void OnClickRule()
	{
	}

	[Token(Token = "0x600934C")]
	[Address(RVA = "0x30215B0", Offset = "0x30215B0", VA = "0x30215B0")]
	private void OnClickToken()
	{
	}

	[Token(Token = "0x600934D")]
	[Address(RVA = "0x3021720", Offset = "0x3021720", VA = "0x3021720")]
	private void OnClickToggleClassic()
	{
	}

	[Token(Token = "0x600934E")]
	[Address(RVA = "0x30224BC", Offset = "0x30224BC", VA = "0x30224BC")]
	private void OnClickToggleSpecial()
	{
	}

	[Token(Token = "0x600934F")]
	[Address(RVA = "0x302260C", Offset = "0x302260C", VA = "0x302260C")]
	private void OnRedTipsOnOffClick()
	{
	}

	[Token(Token = "0x6009350")]
	[Address(RVA = "0x302127C", Offset = "0x302127C", VA = "0x302127C")]
	private void SetDefaultView()
	{
	}

	[Token(Token = "0x6009351")]
	[Address(RVA = "0x3022A0C", Offset = "0x3022A0C", VA = "0x3022A0C")]
	private void InitView()
	{
	}

	[Token(Token = "0x6009352")]
	[Address(RVA = "0x3022B14", Offset = "0x3022B14", VA = "0x3022B14")]
	private void SetOpenTimeView()
	{
	}

	[Token(Token = "0x6009353")]
	[Address(RVA = "0x3022E48", Offset = "0x3022E48", VA = "0x3022E48")]
	private void SetTokenIconView()
	{
	}

	[Token(Token = "0x6009354")]
	[Address(RVA = "0x302314C", Offset = "0x302314C", VA = "0x302314C")]
	private void SetCDNView()
	{
	}

	[Token(Token = "0x6009355")]
	[Address(RVA = "0x3021A54", Offset = "0x3021A54", VA = "0x3021A54")]
	private void SetStoreItemListView(EStoreTab storeTab)
	{
	}

	[Token(Token = "0x6009356")]
	[Address(RVA = "0x3023748", Offset = "0x3023748", VA = "0x3023748")]
	private void SetTabView()
	{
	}

	[Token(Token = "0x6009357")]
	[Address(RVA = "0x3022288", Offset = "0x3022288", VA = "0x3022288")]
	private void SetExchangeHintView(EStoreTab storeTab)
	{
	}

	[Token(Token = "0x6009358")]
	[Address(RVA = "0x3022444", Offset = "0x3022444", VA = "0x3022444")]
	private void SetTabRedTipsView()
	{
	}

	[Token(Token = "0x6009359")]
	[Address(RVA = "0x3023E30", Offset = "0x3023E30", VA = "0x3023E30", Slot = "45")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600935A")]
	[Address(RVA = "0x3023F28", Offset = "0x3023F28", VA = "0x3023F28", Slot = "46")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600935B")]
	[Address(RVA = "0x3023FA4", Offset = "0x3023FA4", VA = "0x3023FA4", Slot = "43")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600935C")]
	[Address(RVA = "0x30240B8", Offset = "0x30240B8", VA = "0x30240B8", Slot = "44")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600935D")]
	[Address(RVA = "0x302414C", Offset = "0x302414C", VA = "0x302414C")]
	private static int _003CSetStoreItemListView_003Em__0(CustomEventStoreCommodityDesc a, CustomEventStoreCommodityDesc b)
	{
		return default(int);
	}

	[Token(Token = "0x600935E")]
	[Address(RVA = "0x3024194", Offset = "0x3024194", VA = "0x3024194")]
	private static int _003CSetStoreItemListView_003Em__1(CustomEventStoreCommodityDesc a, CustomEventStoreCommodityDesc b)
	{
		return default(int);
	}

	[Token(Token = "0x600935F")]
	[Address(RVA = "0x30241DC", Offset = "0x30241DC", VA = "0x30241DC")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009360")]
	[Address(RVA = "0x30241E4", Offset = "0x30241E4", VA = "0x30241E4")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x6009361")]
	[Address(RVA = "0x30241EC", Offset = "0x30241EC", VA = "0x30241EC")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}
}
