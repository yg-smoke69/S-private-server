using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20021C2")]
public class UIGiftMallDetailController : UIMallDetailBaseController, _Attribute
{
	[Token(Token = "0x20021C3")]
	private sealed class _003CNavigationToItem_003Ec__AnonStorey0
	{
		[Token(Token = "0x400D346")]
		[FieldOffset(Offset = "0x8")]
		internal uint mallSubType;

		[Token(Token = "0x400D347")]
		[FieldOffset(Offset = "0xC")]
		internal uint storeID;

		[Token(Token = "0x600B4A1")]
		[Address(RVA = "0x1CF259C", Offset = "0x1CF259C", VA = "0x1CF259C")]
		public _003CNavigationToItem_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600B4A2")]
		[Address(RVA = "0x1CF3C74", Offset = "0x1CF3C74", VA = "0x1CF3C74")]
		internal bool _003C_003Em__0(SubTabInfo temp)
		{
			return default(bool);
		}

		[Token(Token = "0x600B4A3")]
		[Address(RVA = "0x1CF3CAC", Offset = "0x1CF3CAC", VA = "0x1CF3CAC")]
		internal bool _003C_003Em__1(GiftItem item)
		{
			return default(bool);
		}

		[Token(Token = "0x600B4A4")]
		[Address(RVA = "0x1CF3CE4", Offset = "0x1CF3CE4", VA = "0x1CF3CE4")]
		internal bool _003C_003Em__2(GiftItem item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20021C4")]
	private sealed class _003CGenderSelectionList_003Ec__AnonStorey1
	{
		[Token(Token = "0x400D348")]
		[FieldOffset(Offset = "0x8")]
		internal EClothGenderType genderType;

		[Token(Token = "0x400D349")]
		[FieldOffset(Offset = "0xC")]
		internal UIGiftMallDetailController _0024this;

		[Token(Token = "0x600B4A5")]
		[Address(RVA = "0x1CF31F4", Offset = "0x1CF31F4", VA = "0x1CF31F4")]
		public _003CGenderSelectionList_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600B4A6")]
		[Address(RVA = "0x1CF3C20", Offset = "0x1CF3C20", VA = "0x1CF3C20")]
		internal bool _003C_003Em__0(GiftItem giftItem)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400D340")]
	[FieldOffset(Offset = "0xB8")]
	public UIMallGiftController m_GiftCtrl;

	[Token(Token = "0x400D341")]
	[FieldOffset(Offset = "0xBC")]
	private List<GiftItem> m_CurrentDataList;

	[Token(Token = "0x400D342")]
	private const uint COINDIAMONDRATIO = 50u;

	[Token(Token = "0x400D343")]
	private const string GIFTRANKLASTCRECORDRANKID = "MALL_GIFTRANK_RANKID";

	[Token(Token = "0x400D344")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<SubTabInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400D345")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<UINavigationUtil.UINavigationMallTabType, uint> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600B455")]
	[Address(RVA = "0x1CECF08", Offset = "0x1CECF08", VA = "0x1CECF08")]
	public UIGiftMallDetailController()
	{
	}

	[Token(Token = "0x600B456")]
	[Address(RVA = "0x1CECFC0", Offset = "0x1CECFC0", VA = "0x1CECFC0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B457")]
	[Address(RVA = "0x1CED064", Offset = "0x1CED064", VA = "0x1CED064", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B458")]
	[Address(RVA = "0x1CEDFCC", Offset = "0x1CEDFCC", VA = "0x1CEDFCC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B459")]
	[Address(RVA = "0x1CEE100", Offset = "0x1CEE100", VA = "0x1CEE100", Slot = "53")]
	public override void HideItemEffect()
	{
	}

	[Token(Token = "0x600B45A")]
	[Address(RVA = "0x1CEDA04", Offset = "0x1CEDA04", VA = "0x1CEDA04")]
	private void InitMallTypeHandle()
	{
	}

	[Token(Token = "0x600B45B")]
	[Address(RVA = "0x1CEDE9C", Offset = "0x1CEDE9C", VA = "0x1CEDE9C")]
	private void InitSpecialViewHandle()
	{
	}

	[Token(Token = "0x600B45C")]
	[Address(RVA = "0x1CEE348", Offset = "0x1CEE348", VA = "0x1CEE348")]
	private void OnGiftPanelClose(object[] data)
	{
	}

	[Token(Token = "0x600B45D")]
	[Address(RVA = "0x1CEED68", Offset = "0x1CEED68", VA = "0x1CEED68")]
	private void OnUpdateBuyVoucher(object[] data)
	{
	}

	[Token(Token = "0x600B45E")]
	[Address(RVA = "0x1CEEFA4", Offset = "0x1CEEFA4", VA = "0x1CEEFA4", Slot = "66")]
	public override void OnHairUpdate(object[] data)
	{
	}

	[Token(Token = "0x600B45F")]
	[Address(RVA = "0x1CEF190", Offset = "0x1CEF190", VA = "0x1CEF190")]
	private void OnGiftRankBtnClick()
	{
	}

	[Token(Token = "0x600B460")]
	[Address(RVA = "0x1CEF6C0", Offset = "0x1CEF6C0", VA = "0x1CEF6C0")]
	private void OpenGiftLeaderBoardWnd()
	{
	}

	[Token(Token = "0x600B461")]
	[Address(RVA = "0x1CEF574", Offset = "0x1CEF574", VA = "0x1CEF574")]
	private bool IsGiftLeaderBoardOver()
	{
		return default(bool);
	}

	[Token(Token = "0x600B462")]
	[Address(RVA = "0x1CEF7D0", Offset = "0x1CEF7D0", VA = "0x1CEF7D0", Slot = "31")]
	protected override void InitBuyBtnStyle()
	{
	}

	[Token(Token = "0x600B463")]
	[Address(RVA = "0x1CEF9E0", Offset = "0x1CEF9E0", VA = "0x1CEF9E0")]
	private void SendGift()
	{
	}

	[Token(Token = "0x600B464")]
	[Address(RVA = "0x1CEFE28", Offset = "0x1CEFE28", VA = "0x1CEFE28", Slot = "55")]
	protected override void OnSubToggleClick()
	{
	}

	[Token(Token = "0x600B465")]
	[Address(RVA = "0x1CF0A3C", Offset = "0x1CF0A3C", VA = "0x1CF0A3C", Slot = "58")]
	public override void OnItemSelected(object[] data)
	{
	}

	[Token(Token = "0x600B466")]
	[Address(RVA = "0x1CEEDD4", Offset = "0x1CEEDD4", VA = "0x1CEEDD4")]
	private void RefreshItemView(uint commodityID)
	{
	}

	[Token(Token = "0x600B467")]
	[Address(RVA = "0x1CEE838", Offset = "0x1CEE838", VA = "0x1CEE838")]
	private void SetGiftRewardDesc(uint commodityID)
	{
	}

	[Token(Token = "0x600B468")]
	[Address(RVA = "0x1CF0B84", Offset = "0x1CF0B84", VA = "0x1CF0B84")]
	private void SetMoneyBtnData(GiftItem giftItem)
	{
	}

	[Token(Token = "0x600B469")]
	[Address(RVA = "0x1CF08BC", Offset = "0x1CF08BC", VA = "0x1CF08BC")]
	private void RefreshViewData(List<GiftItem> dataList, bool needResort = true)
	{
	}

	[Token(Token = "0x600B46A")]
	[Address(RVA = "0x1CF0BF8", Offset = "0x1CF0BF8", VA = "0x1CF0BF8", Slot = "59")]
	public override void InitMallView()
	{
	}

	[Token(Token = "0x600B46B")]
	[Address(RVA = "0x1CF0F58", Offset = "0x1CF0F58", VA = "0x1CF0F58", Slot = "60")]
	public override void RefreshMallView()
	{
	}

	[Token(Token = "0x600B46C")]
	[Address(RVA = "0x1CF0FC4", Offset = "0x1CF0FC4", VA = "0x1CF0FC4", Slot = "65")]
	public override void HighLightSelectedItem()
	{
	}

	[Token(Token = "0x600B46D")]
	[Address(RVA = "0x1CF0C70", Offset = "0x1CF0C70", VA = "0x1CF0C70")]
	private void UpdateTabs()
	{
	}

	[Token(Token = "0x600B46E")]
	[Address(RVA = "0x1CF1104", Offset = "0x1CF1104", VA = "0x1CF1104", Slot = "71")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600B46F")]
	[Address(RVA = "0x1CF11FC", Offset = "0x1CF11FC", VA = "0x1CF11FC", Slot = "72")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600B470")]
	[Address(RVA = "0x1CF1278", Offset = "0x1CF1278", VA = "0x1CF1278", Slot = "42")]
	protected override void OnBundleToggleSelected()
	{
	}

	[Token(Token = "0x600B471")]
	[Address(RVA = "0x1CF13EC", Offset = "0x1CF13EC", VA = "0x1CF13EC", Slot = "43")]
	protected override void OnAvatarToggleSelected()
	{
	}

	[Token(Token = "0x600B472")]
	[Address(RVA = "0x1CF1560", Offset = "0x1CF1560", VA = "0x1CF1560", Slot = "44")]
	protected override void OnCustomizeToggleSelected()
	{
	}

	[Token(Token = "0x600B473")]
	[Address(RVA = "0x1CF1764", Offset = "0x1CF1764", VA = "0x1CF1764", Slot = "45")]
	protected override void OnPropsToggleSelected()
	{
	}

	[Token(Token = "0x600B474")]
	[Address(RVA = "0x1CF18D8", Offset = "0x1CF18D8", VA = "0x1CF18D8", Slot = "46")]
	protected override void OnCallSignToggleSelected()
	{
	}

	[Token(Token = "0x600B475")]
	[Address(RVA = "0x1CF1A4C", Offset = "0x1CF1A4C", VA = "0x1CF1A4C", Slot = "48")]
	protected override void OnPetToggleSelected()
	{
	}

	[Token(Token = "0x600B476")]
	[Address(RVA = "0x1CF1BC0", Offset = "0x1CF1BC0", VA = "0x1CF1BC0", Slot = "56")]
	protected override void ResetUIStateOnToggleSelected()
	{
	}

	[Token(Token = "0x600B477")]
	[Address(RVA = "0x1CF1DD4", Offset = "0x1CF1DD4", VA = "0x1CF1DD4", Slot = "62")]
	public override void NavigationToItem(uint mallTabType, uint mallSubType, uint storeID)
	{
	}

	[Token(Token = "0x600B478")]
	[Address(RVA = "0x1CF25A4", Offset = "0x1CF25A4", VA = "0x1CF25A4", Slot = "38")]
	public override bool OverwriteBackButtonLogic()
	{
		return default(bool);
	}

	[Token(Token = "0x600B479")]
	[Address(RVA = "0x1CF26B4", Offset = "0x1CF26B4", VA = "0x1CF26B4")]
	private void OnAllClothToggleClick()
	{
	}

	[Token(Token = "0x600B47A")]
	[Address(RVA = "0x1CF2948", Offset = "0x1CF2948", VA = "0x1CF2948")]
	private void OnCommomClothToggleClick()
	{
	}

	[Token(Token = "0x600B47B")]
	[Address(RVA = "0x1CF2C78", Offset = "0x1CF2C78", VA = "0x1CF2C78")]
	private void OnMaleClothToggleClick()
	{
	}

	[Token(Token = "0x600B47C")]
	[Address(RVA = "0x1CF2E44", Offset = "0x1CF2E44", VA = "0x1CF2E44")]
	private void OnFemaleClothToggleClick()
	{
	}

	[Token(Token = "0x600B47D")]
	[Address(RVA = "0x1CF2B14", Offset = "0x1CF2B14", VA = "0x1CF2B14")]
	private void RefreshClothViewByGender(EClothGenderType genderType)
	{
	}

	[Token(Token = "0x600B47E")]
	[Address(RVA = "0x1CF3010", Offset = "0x1CF3010", VA = "0x1CF3010")]
	private List<GiftItem> GenderSelectionList(EClothGenderType genderType)
	{
		return null;
	}

	[Token(Token = "0x600B47F")]
	[Address(RVA = "0x1CF31FC", Offset = "0x1CF31FC", VA = "0x1CF31FC", Slot = "52")]
	protected override void RefreshCurrentTabView(UINavigationUtil.UINavigationMallTabType mallTabType)
	{
	}

	[Token(Token = "0x600B480")]
	[Address(RVA = "0x1CF338C", Offset = "0x1CF338C", VA = "0x1CF338C", Slot = "63")]
	public override void RefreshCurrentMallView(bool clickItem)
	{
	}

	[Token(Token = "0x600B481")]
	[Address(RVA = "0x1CF3428", Offset = "0x1CF3428", VA = "0x1CF3428", Slot = "64")]
	public override UIEasyList GetCurrentMallEasyList()
	{
		return null;
	}

	[Token(Token = "0x600B482")]
	[Address(RVA = "0x1CF3498", Offset = "0x1CF3498", VA = "0x1CF3498", Slot = "37")]
	public override void ResetCurrentMall()
	{
	}

	[Token(Token = "0x600B483")]
	[Address(RVA = "0x1CF35AC", Offset = "0x1CF35AC", VA = "0x1CF35AC", Slot = "36")]
	public override void HighlightCurrent()
	{
	}

	[Token(Token = "0x600B484")]
	[Address(RVA = "0x1CF37C8", Offset = "0x1CF37C8", VA = "0x1CF37C8")]
	public void RefreshCurrentEasyListItemABState()
	{
	}

	[Token(Token = "0x600B485")]
	[Address(RVA = "0x1CF3970", Offset = "0x1CF3970", VA = "0x1CF3970")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600B486")]
	[Address(RVA = "0x1CF3A9C", Offset = "0x1CF3A9C", VA = "0x1CF3A9C")]
	private static bool _003COnSubToggleClick_003Em__1(SubTabInfo temp)
	{
		return default(bool);
	}

	[Token(Token = "0x600B487")]
	[Address(RVA = "0x1CF3ADC", Offset = "0x1CF3ADC", VA = "0x1CF3ADC")]
	private static uint _003CUpdateTabs_003Em__2(UINavigationUtil.UINavigationMallTabType type)
	{
		return default(uint);
	}

	[Token(Token = "0x600B488")]
	[Address(RVA = "0x1CF3AE0", Offset = "0x1CF3AE0", VA = "0x1CF3AE0")]
	private bool _003CHighlightCurrent_003Em__3(GiftItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x600B489")]
	[Address(RVA = "0x1CF3B18", Offset = "0x1CF3B18", VA = "0x1CF3B18")]
	private bool _003CHighlightCurrent_003Em__4(GiftItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x600B48A")]
	[Address(RVA = "0x1CF3B50", Offset = "0x1CF3B50", VA = "0x1CF3B50")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B48B")]
	[Address(RVA = "0x1CF3B58", Offset = "0x1CF3B58", VA = "0x1CF3B58")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600B48C")]
	[Address(RVA = "0x1CF3B60", Offset = "0x1CF3B60", VA = "0x1CF3B60")]
	public void _003C_003EiFixBaseProxy_HideItemEffect()
	{
	}

	[Token(Token = "0x600B48D")]
	[Address(RVA = "0x1CF3B68", Offset = "0x1CF3B68", VA = "0x1CF3B68")]
	public void _003C_003EiFixBaseProxy_OnHairUpdate(object[] P0)
	{
	}

	[Token(Token = "0x600B48E")]
	[Address(RVA = "0x1CF3B70", Offset = "0x1CF3B70", VA = "0x1CF3B70")]
	public void _003C_003EiFixBaseProxy_InitBuyBtnStyle()
	{
	}

	[Token(Token = "0x600B48F")]
	[Address(RVA = "0x1CF3B78", Offset = "0x1CF3B78", VA = "0x1CF3B78")]
	public void _003C_003EiFixBaseProxy_OnSubToggleClick()
	{
	}

	[Token(Token = "0x600B490")]
	[Address(RVA = "0x1CF3B80", Offset = "0x1CF3B80", VA = "0x1CF3B80")]
	public void _003C_003EiFixBaseProxy_OnItemSelected(object[] P0)
	{
	}

	[Token(Token = "0x600B491")]
	[Address(RVA = "0x1CF3B88", Offset = "0x1CF3B88", VA = "0x1CF3B88")]
	public void _003C_003EiFixBaseProxy_InitMallView()
	{
	}

	[Token(Token = "0x600B492")]
	[Address(RVA = "0x1CF3B90", Offset = "0x1CF3B90", VA = "0x1CF3B90")]
	public void _003C_003EiFixBaseProxy_RefreshMallView()
	{
	}

	[Token(Token = "0x600B493")]
	[Address(RVA = "0x1CF3B98", Offset = "0x1CF3B98", VA = "0x1CF3B98")]
	public void _003C_003EiFixBaseProxy_HighLightSelectedItem()
	{
	}

	[Token(Token = "0x600B494")]
	[Address(RVA = "0x1CF3BA0", Offset = "0x1CF3BA0", VA = "0x1CF3BA0")]
	public void _003C_003EiFixBaseProxy_OnBundleToggleSelected()
	{
	}

	[Token(Token = "0x600B495")]
	[Address(RVA = "0x1CF3BA8", Offset = "0x1CF3BA8", VA = "0x1CF3BA8")]
	public void _003C_003EiFixBaseProxy_OnAvatarToggleSelected()
	{
	}

	[Token(Token = "0x600B496")]
	[Address(RVA = "0x1CF3BB0", Offset = "0x1CF3BB0", VA = "0x1CF3BB0")]
	public void _003C_003EiFixBaseProxy_OnCustomizeToggleSelected()
	{
	}

	[Token(Token = "0x600B497")]
	[Address(RVA = "0x1CF3BB8", Offset = "0x1CF3BB8", VA = "0x1CF3BB8")]
	public void _003C_003EiFixBaseProxy_OnPropsToggleSelected()
	{
	}

	[Token(Token = "0x600B498")]
	[Address(RVA = "0x1CF3BC0", Offset = "0x1CF3BC0", VA = "0x1CF3BC0")]
	public void _003C_003EiFixBaseProxy_OnCallSignToggleSelected()
	{
	}

	[Token(Token = "0x600B499")]
	[Address(RVA = "0x1CF3BC8", Offset = "0x1CF3BC8", VA = "0x1CF3BC8")]
	public void _003C_003EiFixBaseProxy_OnPetToggleSelected()
	{
	}

	[Token(Token = "0x600B49A")]
	[Address(RVA = "0x1CF3BD0", Offset = "0x1CF3BD0", VA = "0x1CF3BD0")]
	public void _003C_003EiFixBaseProxy_ResetUIStateOnToggleSelected()
	{
	}

	[Token(Token = "0x600B49B")]
	[Address(RVA = "0x1CF3BD8", Offset = "0x1CF3BD8", VA = "0x1CF3BD8")]
	public void _003C_003EiFixBaseProxy_NavigationToItem(uint P0, uint P1, uint P2)
	{
	}

	[Token(Token = "0x600B49C")]
	[Address(RVA = "0x1CF3BF8", Offset = "0x1CF3BF8", VA = "0x1CF3BF8")]
	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return default(bool);
	}

	[Token(Token = "0x600B49D")]
	[Address(RVA = "0x1CF3C00", Offset = "0x1CF3C00", VA = "0x1CF3C00")]
	public void _003C_003EiFixBaseProxy_RefreshCurrentTabView(UINavigationUtil.UINavigationMallTabType P0)
	{
	}

	[Token(Token = "0x600B49E")]
	[Address(RVA = "0x1CF3C08", Offset = "0x1CF3C08", VA = "0x1CF3C08")]
	public UIEasyList _003C_003EiFixBaseProxy_GetCurrentMallEasyList()
	{
		return null;
	}

	[Token(Token = "0x600B49F")]
	[Address(RVA = "0x1CF3C10", Offset = "0x1CF3C10", VA = "0x1CF3C10")]
	public void _003C_003EiFixBaseProxy_ResetCurrentMall()
	{
	}

	[Token(Token = "0x600B4A0")]
	[Address(RVA = "0x1CF3C18", Offset = "0x1CF3C18", VA = "0x1CF3C18")]
	public void _003C_003EiFixBaseProxy_HighlightCurrent()
	{
	}
}
