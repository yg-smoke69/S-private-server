using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002616")]
public class UIForgeController : UIPreviewNavigationController, _Attribute, IConvertible
{
	[Token(Token = "0x2002617")]
	private sealed class _003CNavigationToItem_003Ec__AnonStorey0
	{
		[Token(Token = "0x400EB2A")]
		[FieldOffset(Offset = "0x8")]
		internal uint itemId;

		[Token(Token = "0x600E19D")]
		[Address(RVA = "0x1B6715C", Offset = "0x1B6715C", VA = "0x1B6715C")]
		public _003CNavigationToItem_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600E19E")]
		[Address(RVA = "0x1B67774", Offset = "0x1B67774", VA = "0x1B67774")]
		internal bool _003C_003Em__0(ChestSpecialExchangeDesc item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400EB14")]
	[FieldOffset(Offset = "0x7C")]
	private UIForgeView m_View;

	[Token(Token = "0x400EB15")]
	[FieldOffset(Offset = "0x80")]
	private UINavigationData m_LastNavigationData;

	[Token(Token = "0x400EB16")]
	[FieldOffset(Offset = "0x84")]
	private uint m_NavToggleType;

	[Token(Token = "0x400EB17")]
	[FieldOffset(Offset = "0x88")]
	private uint m_NavItemId;

	[Token(Token = "0x400EB18")]
	[FieldOffset(Offset = "0x8C")]
	private Dictionary<uint, UIToggleButton> m_ToggleDict;

	[Token(Token = "0x400EB19")]
	[FieldOffset(Offset = "0x90")]
	private List<ChestSpecialExchangeDesc> m_CurrentDataList;

	[Token(Token = "0x400EB1A")]
	[FieldOffset(Offset = "0x94")]
	private uint m_CurrentTab;

	[Token(Token = "0x400EB1B")]
	[FieldOffset(Offset = "0x98")]
	private bool m_ForgeDataInitialized;

	[Token(Token = "0x400EB1C")]
	[FieldOffset(Offset = "0x99")]
	private bool m_NavigationDataInitialized;

	[Token(Token = "0x400EB1D")]
	[FieldOffset(Offset = "0x9A")]
	private bool m_IsSelectedFirstToggleOnInit;

	[Token(Token = "0x400EB1E")]
	[FieldOffset(Offset = "0x9C")]
	private List<UISprite> m_NotEnoughMaterial;

	[Token(Token = "0x400EB1F")]
	[FieldOffset(Offset = "0xA0")]
	private uint m_SelectedId;

	[Token(Token = "0x400EB20")]
	[FieldOffset(Offset = "0xA4")]
	private uint m_SelectedItemId;

	[Token(Token = "0x400EB21")]
	[FieldOffset(Offset = "0xA8")]
	private bool m_HaveEnoughMaterial;

	[Token(Token = "0x400EB22")]
	private const uint MATERIAL_LABEL_RED = 4281150975u;

	[Token(Token = "0x400EB23")]
	private const uint EXCHANGE_LABEL_GREY = 2139062271u;

	[Token(Token = "0x400EB24")]
	[FieldOffset(Offset = "0xA9")]
	private bool m_ItemCanExchange;

	[Token(Token = "0x400EB25")]
	[FieldOffset(Offset = "0xAC")]
	private UIRoot m_UIRoot;

	[Token(Token = "0x400EB26")]
	[FieldOffset(Offset = "0xB0")]
	private UIModelGacha m_ModelGacha;

	[Token(Token = "0x400EB27")]
	[FieldOffset(Offset = "0xB4")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x400EB28")]
	[FieldOffset(Offset = "0xB8")]
	private UIModelMall m_ModelMall;

	[Token(Token = "0x400EB29")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<uint> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600E175")]
	[Address(RVA = "0x1B61B60", Offset = "0x1B61B60", VA = "0x1B61B60")]
	public UIForgeController()
	{
	}

	[Token(Token = "0x600E176")]
	[Address(RVA = "0x1B61C28", Offset = "0x1B61C28", VA = "0x1B61C28")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E177")]
	[Address(RVA = "0x1B61CD0", Offset = "0x1B61CD0", VA = "0x1B61CD0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E178")]
	[Address(RVA = "0x1B622F0", Offset = "0x1B622F0", VA = "0x1B622F0")]
	private void InitMaterialDict()
	{
	}

	[Token(Token = "0x600E179")]
	[Address(RVA = "0x1B62440", Offset = "0x1B62440", VA = "0x1B62440")]
	private void OnExchangeBtnClick()
	{
	}

	[Token(Token = "0x600E17A")]
	[Address(RVA = "0x1B62EF8", Offset = "0x1B62EF8", VA = "0x1B62EF8")]
	private void OnMaterial1BtnClick(object[] data)
	{
	}

	[Token(Token = "0x600E17B")]
	[Address(RVA = "0x1B63330", Offset = "0x1B63330", VA = "0x1B63330")]
	private void OnMaterial2BtnClick(object[] data)
	{
	}

	[Token(Token = "0x600E17C")]
	[Address(RVA = "0x1B62FF8", Offset = "0x1B62FF8", VA = "0x1B62FF8")]
	private void ShowMaterialDesc(Vector3 pos, int index)
	{
	}

	[Token(Token = "0x600E17D")]
	[Address(RVA = "0x1B63430", Offset = "0x1B63430", VA = "0x1B63430")]
	private void OnItemSelected(object[] data)
	{
	}

	[Token(Token = "0x600E17E")]
	[Address(RVA = "0x1B63548", Offset = "0x1B63548", VA = "0x1B63548")]
	private void RefreshItemView(uint id)
	{
	}

	[Token(Token = "0x600E17F")]
	[Address(RVA = "0x1B6449C", Offset = "0x1B6449C", VA = "0x1B6449C")]
	private void OnRefreshForgeItem(object[] data)
	{
	}

	[Token(Token = "0x600E180")]
	[Address(RVA = "0x1B63888", Offset = "0x1B63888", VA = "0x1B63888")]
	private void RefreshMaterialView(ChestSpecialExchangeDesc desc)
	{
	}

	[Token(Token = "0x600E181")]
	[Address(RVA = "0x1B64640", Offset = "0x1B64640", VA = "0x1B64640", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600E182")]
	[Address(RVA = "0x1B64890", Offset = "0x1B64890", VA = "0x1B64890")]
	private void InitNavigationData(UINavigationData navigationData)
	{
	}

	[Token(Token = "0x600E183")]
	[Address(RVA = "0x1B6530C", Offset = "0x1B6530C", VA = "0x1B6530C", Slot = "36")]
	protected override void OnSendShowTimeEvent(ref string eventLogKey, ref EventLogger.EventPageDetentionTime eventLog)
	{
	}

	[Token(Token = "0x600E184")]
	[Address(RVA = "0x1B65498", Offset = "0x1B65498", VA = "0x1B65498", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E185")]
	[Address(RVA = "0x1B657F8", Offset = "0x1B657F8", VA = "0x1B657F8", Slot = "65")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E186")]
	[Address(RVA = "0x1B658B0", Offset = "0x1B658B0", VA = "0x1B658B0", Slot = "64")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E187")]
	[Address(RVA = "0x1B650E4", Offset = "0x1B650E4", VA = "0x1B650E4")]
	private void HighlightCurrent()
	{
	}

	[Token(Token = "0x600E188")]
	[Address(RVA = "0x1B65E9C", Offset = "0x1B65E9C", VA = "0x1B65E9C", Slot = "37")]
	protected override bool NeedWaitDataReady()
	{
		return default(bool);
	}

	[Token(Token = "0x600E189")]
	[Address(RVA = "0x1B65C24", Offset = "0x1B65C24", VA = "0x1B65C24")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600E18A")]
	[Address(RVA = "0x1B65EF4", Offset = "0x1B65EF4", VA = "0x1B65EF4")]
	private void InitToggles()
	{
	}

	[Token(Token = "0x600E18B")]
	[Address(RVA = "0x1B66C5C", Offset = "0x1B66C5C", VA = "0x1B66C5C")]
	private void OnTabToggleSelected()
	{
	}

	[Token(Token = "0x600E18C")]
	[Address(RVA = "0x1B65D0C", Offset = "0x1B65D0C", VA = "0x1B65D0C")]
	private void RefreshViewData(List<ChestSpecialExchangeDesc> dataList, bool needSort = true)
	{
	}

	[Token(Token = "0x600E18D")]
	[Address(RVA = "0x1B66FE8", Offset = "0x1B66FE8", VA = "0x1B66FE8", Slot = "66")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600E18E")]
	[Address(RVA = "0x1B670E0", Offset = "0x1B670E0", VA = "0x1B670E0", Slot = "67")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600E18F")]
	[Address(RVA = "0x1B64AE8", Offset = "0x1B64AE8", VA = "0x1B64AE8")]
	private void NavigationToItem(uint tabType, uint itemId)
	{
	}

	[Token(Token = "0x600E190")]
	[Address(RVA = "0x1B67164", Offset = "0x1B67164", VA = "0x1B67164")]
	private int SortItem(ChestSpecialExchangeDesc x, ChestSpecialExchangeDesc y)
	{
		return default(int);
	}

	[Token(Token = "0x600E191")]
	[Address(RVA = "0x1B645A8", Offset = "0x1B645A8", VA = "0x1B645A8")]
	private bool CheckItemCanPurchase(uint limited_purchase_times, uint purchase_times)
	{
		return default(bool);
	}

	[Token(Token = "0x600E192")]
	[Address(RVA = "0x1B675C8", Offset = "0x1B675C8", VA = "0x1B675C8", Slot = "38")]
	public override EFrontendBGMType GetBGMType()
	{
		return default(EFrontendBGMType);
	}

	[Token(Token = "0x600E193")]
	[Address(RVA = "0x1B67620", Offset = "0x1B67620", VA = "0x1B67620", Slot = "42")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x600E194")]
	[Address(RVA = "0x1B67690", Offset = "0x1B67690", VA = "0x1B67690", Slot = "43")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x600E195")]
	[Address(RVA = "0x1B676E8", Offset = "0x1B676E8", VA = "0x1B676E8")]
	private bool _003CHighlightCurrent_003Em__0(ChestSpecialExchangeDesc item)
	{
		return default(bool);
	}

	[Token(Token = "0x600E196")]
	[Address(RVA = "0x1B67720", Offset = "0x1B67720", VA = "0x1B67720")]
	private static int _003CInitToggles_003Em__1(uint a, uint b)
	{
		return default(int);
	}

	[Token(Token = "0x600E197")]
	[Address(RVA = "0x1B67744", Offset = "0x1B67744", VA = "0x1B67744")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E198")]
	[Address(RVA = "0x1B6774C", Offset = "0x1B6774C", VA = "0x1B6774C")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600E199")]
	[Address(RVA = "0x1B67754", Offset = "0x1B67754", VA = "0x1B67754")]
	public void _003C_003EiFixBaseProxy_OnSendShowTimeEvent(ref string P0, ref EventLogger.EventPageDetentionTime P1)
	{
	}

	[Token(Token = "0x600E19A")]
	[Address(RVA = "0x1B6775C", Offset = "0x1B6775C", VA = "0x1B6775C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600E19B")]
	[Address(RVA = "0x1B67764", Offset = "0x1B67764", VA = "0x1B67764")]
	public bool _003C_003EiFixBaseProxy_NeedWaitDataReady()
	{
		return default(bool);
	}

	[Token(Token = "0x600E19C")]
	[Address(RVA = "0x1B6776C", Offset = "0x1B6776C", VA = "0x1B6776C")]
	public EFrontendBGMType _003C_003EiFixBaseProxy_GetBGMType()
	{
		return default(EFrontendBGMType);
	}
}
