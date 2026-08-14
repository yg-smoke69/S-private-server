using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002213")]
public class UIWeaponMallDetailController : UIMallDetailBaseController, _Attribute, IConvertible
{
	[Token(Token = "0x2002214")]
	private sealed class _003CNavigationToItem_003Ec__AnonStorey0
	{
		[Token(Token = "0x400D51C")]
		[FieldOffset(Offset = "0x8")]
		internal uint mallSubType;

		[Token(Token = "0x400D51D")]
		[FieldOffset(Offset = "0xC")]
		internal uint storeID;

		[Token(Token = "0x600B887")]
		[Address(RVA = "0x1029768", Offset = "0x1029768", VA = "0x1029768")]
		public _003CNavigationToItem_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600B888")]
		[Address(RVA = "0x102B71C", Offset = "0x102B71C", VA = "0x102B71C")]
		internal bool _003C_003Em__0(SubTabInfo temp)
		{
			return default(bool);
		}

		[Token(Token = "0x600B889")]
		[Address(RVA = "0x102B754", Offset = "0x102B754", VA = "0x102B754")]
		internal bool _003C_003Em__1(StoreDesc item)
		{
			return default(bool);
		}

		[Token(Token = "0x600B88A")]
		[Address(RVA = "0x102B78C", Offset = "0x102B78C", VA = "0x102B78C")]
		internal bool _003C_003Em__2(StoreDesc item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400D50E")]
	[FieldOffset(Offset = "0xB8")]
	private List<StoreDesc> m_CurrentDataList;

	[Token(Token = "0x400D50F")]
	[FieldOffset(Offset = "0xBC")]
	private List<PopMenuData> m_WeaponTypeFilterPopMenuList;

	[Token(Token = "0x400D510")]
	[FieldOffset(Offset = "0xC0")]
	private List<PopMenuData> m_WeaponModelFilterPopMenuList;

	[Token(Token = "0x400D511")]
	[FieldOffset(Offset = "0xC4")]
	private UIPopMenuBigController m_WeaponTypeFilterPopMenu;

	[Token(Token = "0x400D512")]
	[FieldOffset(Offset = "0xC8")]
	private UIPopMenuBigController m_WeaponModelFilterPopMenu;

	[Token(Token = "0x400D513")]
	[FieldOffset(Offset = "0xCC")]
	private CollectionDataManager.ECollectionWeaponType m_CurrentFilterWeaponType;

	[Token(Token = "0x400D514")]
	[FieldOffset(Offset = "0xD0")]
	private uint m_CurrentFilterWeaponModel;

	[Token(Token = "0x400D515")]
	[FieldOffset(Offset = "0xD4")]
	private bool m_IsNavigation;

	[Token(Token = "0x400D516")]
	private const uint WEAPONMODELFILTERALL = 0u;

	[Token(Token = "0x400D517")]
	[FieldOffset(Offset = "0xD5")]
	private bool m_PurchaseSuccess;

	[Token(Token = "0x400D518")]
	[FieldOffset(Offset = "0xD8")]
	private Dictionary<uint, Dictionary<uint, List<StoreDesc>>> m_DictWeaponDataSortedByType;

	[Token(Token = "0x400D519")]
	[FieldOffset(Offset = "0xDC")]
	private UICommonGuideController m_GoExchangeGuide;

	[Token(Token = "0x400D51A")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<uint> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400D51B")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<PopMenuData> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600B843")]
	[Address(RVA = "0x10235C4", Offset = "0x10235C4", VA = "0x10235C4")]
	public UIWeaponMallDetailController()
	{
	}

	[Token(Token = "0x600B844")]
	[Address(RVA = "0x1023704", Offset = "0x1023704", VA = "0x1023704")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B845")]
	[Address(RVA = "0x10237A8", Offset = "0x10237A8", VA = "0x10237A8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B846")]
	[Address(RVA = "0x10243F8", Offset = "0x10243F8", VA = "0x10243F8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B847")]
	[Address(RVA = "0x1024528", Offset = "0x1024528", VA = "0x1024528", Slot = "31")]
	protected override void InitBuyBtnStyle()
	{
	}

	[Token(Token = "0x600B848")]
	[Address(RVA = "0x10251CC", Offset = "0x10251CC", VA = "0x10251CC")]
	private void OnBuyBtnClick()
	{
	}

	[Token(Token = "0x600B849")]
	[Address(RVA = "0x102565C", Offset = "0x102565C", VA = "0x102565C")]
	private void RefreshViewData(List<StoreDesc> dataList, bool needResort = true)
	{
	}

	[Token(Token = "0x600B84A")]
	[Address(RVA = "0x102579C", Offset = "0x102579C", VA = "0x102579C", Slot = "59")]
	public override void InitMallView()
	{
	}

	[Token(Token = "0x600B84B")]
	[Address(RVA = "0x1025990", Offset = "0x1025990", VA = "0x1025990", Slot = "60")]
	public override void RefreshMallView()
	{
	}

	[Token(Token = "0x600B84C")]
	[Address(RVA = "0x1025808", Offset = "0x1025808", VA = "0x1025808")]
	private void UpdateTabs()
	{
	}

	[Token(Token = "0x600B84D")]
	[Address(RVA = "0x10259FC", Offset = "0x10259FC", VA = "0x10259FC")]
	private void GenerateWeaponTypeFilterData()
	{
	}

	[Token(Token = "0x600B84E")]
	[Address(RVA = "0x1026048", Offset = "0x1026048", VA = "0x1026048")]
	private void GenerateWeaponModelFilterData()
	{
	}

	[Token(Token = "0x600B84F")]
	[Address(RVA = "0x1026784", Offset = "0x1026784", VA = "0x1026784")]
	private void ConductFilterByWeaponType(object data)
	{
	}

	[Token(Token = "0x600B850")]
	[Address(RVA = "0x1026B7C", Offset = "0x1026B7C", VA = "0x1026B7C", Slot = "35")]
	protected override bool CanFindStoreItem(uint storeID)
	{
		return default(bool);
	}

	[Token(Token = "0x600B851")]
	[Address(RVA = "0x1026C08", Offset = "0x1026C08", VA = "0x1026C08")]
	private void UpdateWeaponTypeFilterInfo()
	{
	}

	[Token(Token = "0x600B852")]
	[Address(RVA = "0x1027080", Offset = "0x1027080", VA = "0x1027080")]
	private void UpdateWeaponModelFilterInfo()
	{
	}

	[Token(Token = "0x600B853")]
	[Address(RVA = "0x1027488", Offset = "0x1027488", VA = "0x1027488")]
	private void ConductFilterByWeaponId(object data)
	{
	}

	[Token(Token = "0x600B854")]
	[Address(RVA = "0x10268C4", Offset = "0x10268C4", VA = "0x10268C4")]
	private void RefreshCurrentFilterWeaponType(CollectionDataManager.ECollectionWeaponType selectType)
	{
	}

	[Token(Token = "0x600B855")]
	[Address(RVA = "0x1026964", Offset = "0x1026964", VA = "0x1026964")]
	private void RefreshCurrentFilterWeaponModel(uint selectModel)
	{
	}

	[Token(Token = "0x600B856")]
	[Address(RVA = "0x10241C4", Offset = "0x10241C4", VA = "0x10241C4")]
	private void ResetFilter(bool showTips = false)
	{
	}

	[Token(Token = "0x600B857")]
	[Address(RVA = "0x10275B4", Offset = "0x10275B4", VA = "0x10275B4", Slot = "71")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600B858")]
	[Address(RVA = "0x10276AC", Offset = "0x10276AC", VA = "0x10276AC", Slot = "72")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600B859")]
	[Address(RVA = "0x1027728", Offset = "0x1027728", VA = "0x1027728", Slot = "53")]
	public override void HideItemEffect()
	{
	}

	[Token(Token = "0x600B85A")]
	[Address(RVA = "0x10278E4", Offset = "0x10278E4", VA = "0x10278E4", Slot = "36")]
	public override void HighlightCurrent()
	{
	}

	[Token(Token = "0x600B85B")]
	[Address(RVA = "0x1027AB0", Offset = "0x1027AB0", VA = "0x1027AB0")]
	private void OnWeaponToggleSelectedNotOverride()
	{
	}

	[Token(Token = "0x600B85C")]
	[Address(RVA = "0x1028440", Offset = "0x1028440", VA = "0x1028440", Slot = "39")]
	protected override void AddMallToggleClickEvent()
	{
	}

	[Token(Token = "0x600B85D")]
	[Address(RVA = "0x10286AC", Offset = "0x10286AC", VA = "0x10286AC", Slot = "57")]
	protected override string GetMallTabName(uint type)
	{
		return null;
	}

	[Token(Token = "0x600B85E")]
	[Address(RVA = "0x1028734", Offset = "0x1028734", VA = "0x1028734", Slot = "56")]
	protected override void ResetUIStateOnToggleSelected()
	{
	}

	[Token(Token = "0x600B85F")]
	[Address(RVA = "0x10287F0", Offset = "0x10287F0", VA = "0x10287F0")]
	public void ConductFilter(CollectionDataManager.ECollectionWeaponType weaponType, uint weaponId)
	{
	}

	[Token(Token = "0x600B860")]
	[Address(RVA = "0x1028BFC", Offset = "0x1028BFC", VA = "0x1028BFC")]
	private bool CheckCanFilterByWeaponType(CollectionDataManager.ECollectionWeaponType weaponType)
	{
		return default(bool);
	}

	[Token(Token = "0x600B861")]
	[Address(RVA = "0x1028DF8", Offset = "0x1028DF8", VA = "0x1028DF8")]
	private bool CheckCanFilterByWeaponId(uint weaponId)
	{
		return default(bool);
	}

	[Token(Token = "0x600B862")]
	[Address(RVA = "0x1028FF4", Offset = "0x1028FF4", VA = "0x1028FF4", Slot = "62")]
	public override void NavigationToItem(uint mallTabType, uint mallSubType, uint storeID)
	{
	}

	[Token(Token = "0x600B863")]
	[Address(RVA = "0x1029770", Offset = "0x1029770", VA = "0x1029770", Slot = "67")]
	public override void ShowMall()
	{
	}

	[Token(Token = "0x600B864")]
	[Address(RVA = "0x10297D4", Offset = "0x10297D4", VA = "0x10297D4", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600B865")]
	[Address(RVA = "0x1029838", Offset = "0x1029838", VA = "0x1029838", Slot = "74")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600B866")]
	[Address(RVA = "0x10298CC", Offset = "0x10298CC", VA = "0x10298CC", Slot = "73")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600B867")]
	[Address(RVA = "0x10299C0", Offset = "0x10299C0", VA = "0x10299C0", Slot = "63")]
	public override void RefreshCurrentMallView(bool clickItem)
	{
	}

	[Token(Token = "0x600B868")]
	[Address(RVA = "0x10269D0", Offset = "0x10269D0", VA = "0x10269D0")]
	private void RefreshDataListByFilter()
	{
	}

	[Token(Token = "0x600B869")]
	[Address(RVA = "0x1029A4C", Offset = "0x1029A4C", VA = "0x1029A4C", Slot = "58")]
	public override void OnItemSelected(object[] data)
	{
	}

	[Token(Token = "0x600B86A")]
	[Address(RVA = "0x1029B94", Offset = "0x1029B94", VA = "0x1029B94")]
	private void RefreshItemView(uint storeID)
	{
	}

	[Token(Token = "0x600B86B")]
	[Address(RVA = "0x102A2CC", Offset = "0x102A2CC", VA = "0x102A2CC")]
	private void RefreshBtnGoExchangeState()
	{
	}

	[Token(Token = "0x600B86C")]
	[Address(RVA = "0x102A854", Offset = "0x102A854", VA = "0x102A854")]
	public bool IsBtnGoExchangeStateActive()
	{
		return default(bool);
	}

	[Token(Token = "0x600B86D")]
	[Address(RVA = "0x102A8E0", Offset = "0x102A8E0", VA = "0x102A8E0")]
	public void OnBtnGoExchangeClick()
	{
	}

	[Token(Token = "0x600B86E")]
	[Address(RVA = "0x102ACC8", Offset = "0x102ACC8", VA = "0x102ACC8")]
	private void OnGoToDiscountBtnClick()
	{
	}

	[Token(Token = "0x600B86F")]
	[Address(RVA = "0x102AD64", Offset = "0x102AD64", VA = "0x102AD64", Slot = "69")]
	protected override void OnCommonWndFinish(object[] data)
	{
	}

	[Token(Token = "0x600B870")]
	[Address(RVA = "0x102AE48", Offset = "0x102AE48", VA = "0x102AE48")]
	private void ShowOfferPurchase()
	{
	}

	[Token(Token = "0x600B871")]
	[Address(RVA = "0x1027E98", Offset = "0x1027E98", VA = "0x1027E98")]
	private void RefreshCurrentTabFilterDict()
	{
	}

	[Token(Token = "0x600B872")]
	[Address(RVA = "0x102AFD8", Offset = "0x102AFD8", VA = "0x102AFD8")]
	private void AddWeaponToSortedDict(uint itemID, StoreDesc storeDesc)
	{
	}

	[Token(Token = "0x600B873")]
	[Address(RVA = "0x102B458", Offset = "0x102B458", VA = "0x102B458")]
	private static int _003CGenerateWeaponTypeFilterData_003Em__0(uint a, uint b)
	{
		return default(int);
	}

	[Token(Token = "0x600B874")]
	[Address(RVA = "0x102B54C", Offset = "0x102B54C", VA = "0x102B54C")]
	private static int _003CGenerateWeaponModelFilterData_003Em__1(PopMenuData a, PopMenuData b)
	{
		return default(int);
	}

	[Token(Token = "0x600B875")]
	[Address(RVA = "0x102B614", Offset = "0x102B614", VA = "0x102B614")]
	private bool _003CHighlightCurrent_003Em__2(StoreDesc item)
	{
		return default(bool);
	}

	[Token(Token = "0x600B876")]
	[Address(RVA = "0x102B64C", Offset = "0x102B64C", VA = "0x102B64C")]
	private bool _003CHighlightCurrent_003Em__3(StoreDesc item)
	{
		return default(bool);
	}

	[Token(Token = "0x600B877")]
	[Address(RVA = "0x102B684", Offset = "0x102B684", VA = "0x102B684")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B878")]
	[Address(RVA = "0x102B68C", Offset = "0x102B68C", VA = "0x102B68C")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600B879")]
	[Address(RVA = "0x102B694", Offset = "0x102B694", VA = "0x102B694")]
	public void _003C_003EiFixBaseProxy_InitBuyBtnStyle()
	{
	}

	[Token(Token = "0x600B87A")]
	[Address(RVA = "0x102B69C", Offset = "0x102B69C", VA = "0x102B69C")]
	public void _003C_003EiFixBaseProxy_InitMallView()
	{
	}

	[Token(Token = "0x600B87B")]
	[Address(RVA = "0x102B6A4", Offset = "0x102B6A4", VA = "0x102B6A4")]
	public void _003C_003EiFixBaseProxy_RefreshMallView()
	{
	}

	[Token(Token = "0x600B87C")]
	[Address(RVA = "0x102B6AC", Offset = "0x102B6AC", VA = "0x102B6AC")]
	public bool _003C_003EiFixBaseProxy_CanFindStoreItem(uint P0)
	{
		return default(bool);
	}

	[Token(Token = "0x600B87D")]
	[Address(RVA = "0x102B6B4", Offset = "0x102B6B4", VA = "0x102B6B4")]
	public void _003C_003EiFixBaseProxy_HideItemEffect()
	{
	}

	[Token(Token = "0x600B87E")]
	[Address(RVA = "0x102B6BC", Offset = "0x102B6BC", VA = "0x102B6BC")]
	public void _003C_003EiFixBaseProxy_HighlightCurrent()
	{
	}

	[Token(Token = "0x600B87F")]
	[Address(RVA = "0x102B6C4", Offset = "0x102B6C4", VA = "0x102B6C4")]
	public void _003C_003EiFixBaseProxy_AddMallToggleClickEvent()
	{
	}

	[Token(Token = "0x600B880")]
	[Address(RVA = "0x102B6CC", Offset = "0x102B6CC", VA = "0x102B6CC")]
	public string _003C_003EiFixBaseProxy_GetMallTabName(uint P0)
	{
		return null;
	}

	[Token(Token = "0x600B881")]
	[Address(RVA = "0x102B6D4", Offset = "0x102B6D4", VA = "0x102B6D4")]
	public void _003C_003EiFixBaseProxy_ResetUIStateOnToggleSelected()
	{
	}

	[Token(Token = "0x600B882")]
	[Address(RVA = "0x102B6DC", Offset = "0x102B6DC", VA = "0x102B6DC")]
	public void _003C_003EiFixBaseProxy_NavigationToItem(uint P0, uint P1, uint P2)
	{
	}

	[Token(Token = "0x600B883")]
	[Address(RVA = "0x102B6FC", Offset = "0x102B6FC", VA = "0x102B6FC")]
	public void _003C_003EiFixBaseProxy_ShowMall()
	{
	}

	[Token(Token = "0x600B884")]
	[Address(RVA = "0x102B704", Offset = "0x102B704", VA = "0x102B704")]
	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600B885")]
	[Address(RVA = "0x102B70C", Offset = "0x102B70C", VA = "0x102B70C")]
	public void _003C_003EiFixBaseProxy_OnItemSelected(object[] P0)
	{
	}

	[Token(Token = "0x600B886")]
	[Address(RVA = "0x102B714", Offset = "0x102B714", VA = "0x102B714")]
	public void _003C_003EiFixBaseProxy_OnCommonWndFinish(object[] P0)
	{
	}
}
