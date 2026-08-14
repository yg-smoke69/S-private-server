using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20029BE")]
public class UIMemberShipItemController : UIBaseController, _Attribute, IConvertible
{
	[Token(Token = "0x40100DF")]
	private const string PRICE_TEMPLATE = "${0}";

	[Token(Token = "0x40100E0")]
	[FieldOffset(Offset = "0x28")]
	private EVipCard.VipCardType m_MemberShipType;

	[Token(Token = "0x40100E1")]
	[FieldOffset(Offset = "0x2C")]
	private ClientMemberShipCardData m_ClientMemberShipCardData;

	[Token(Token = "0x40100E2")]
	[FieldOffset(Offset = "0x30")]
	private UIMemberShipItemView m_View;

	[Token(Token = "0x40100E3")]
	[FieldOffset(Offset = "0x34")]
	private UIModelMemberShip m_Model;

	[Token(Token = "0x40100E4")]
	[FieldOffset(Offset = "0x38")]
	private bool m_PreferSubscription;

	[Token(Token = "0x40100E5")]
	[FieldOffset(Offset = "0x3C")]
	private List<UIStandardItemMiniController> m_MiniContollers;

	[Token(Token = "0x40100E6")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<AwardDesc, BaseItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6010C71")]
	[Address(RVA = "0x269C884", Offset = "0x269C884", VA = "0x269C884")]
	public UIMemberShipItemController()
	{
	}

	[Token(Token = "0x6010C72")]
	[Address(RVA = "0x269C944", Offset = "0x269C944", VA = "0x269C944")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010C73")]
	[Address(RVA = "0x269C9E8", Offset = "0x269C9E8", VA = "0x269C9E8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010C74")]
	[Address(RVA = "0x269D0A0", Offset = "0x269D0A0", VA = "0x269D0A0", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6010C75")]
	[Address(RVA = "0x269D128", Offset = "0x269D128", VA = "0x269D128")]
	private void InitView()
	{
	}

	[Token(Token = "0x6010C76")]
	[Address(RVA = "0x269D2D0", Offset = "0x269D2D0", VA = "0x269D2D0")]
	public void SetViewData(EVipCard.VipCardType vipType)
	{
	}

	[Token(Token = "0x6010C77")]
	[Address(RVA = "0x269D568", Offset = "0x269D568", VA = "0x269D568")]
	private void RefreshDefaultSubscription()
	{
	}

	[Token(Token = "0x6010C78")]
	[Address(RVA = "0x269ECF0", Offset = "0x269ECF0", VA = "0x269ECF0")]
	private void SetStaticData()
	{
	}

	[Token(Token = "0x6010C79")]
	[Address(RVA = "0x269F778", Offset = "0x269F778", VA = "0x269F778")]
	public void RefreshShowReward()
	{
	}

	[Token(Token = "0x6010C7A")]
	[Address(RVA = "0x269FA08", Offset = "0x269FA08", VA = "0x269FA08")]
	private void OnSubscriptionToggleBoxClick()
	{
	}

	[Token(Token = "0x6010C7B")]
	[Address(RVA = "0x269E7C4", Offset = "0x269E7C4", VA = "0x269E7C4")]
	private void UpdatePurchaseButton()
	{
	}

	[Token(Token = "0x6010C7C")]
	[Address(RVA = "0x269FA84", Offset = "0x269FA84", VA = "0x269FA84")]
	private void OnCountDownFinished()
	{
	}

	[Token(Token = "0x6010C7D")]
	[Address(RVA = "0x269D3D8", Offset = "0x269D3D8", VA = "0x269D3D8")]
	private void RefreshWeekCardView()
	{
	}

	[Token(Token = "0x6010C7E")]
	[Address(RVA = "0x269D4A0", Offset = "0x269D4A0", VA = "0x269D4A0")]
	private void RefreshMonthCardView()
	{
	}

	[Token(Token = "0x6010C7F")]
	[Address(RVA = "0x269DE68", Offset = "0x269DE68", VA = "0x269DE68")]
	private void UpdateSubscription()
	{
	}

	[Token(Token = "0x6010C80")]
	[Address(RVA = "0x269CEDC", Offset = "0x269CEDC", VA = "0x269CEDC")]
	private void SyncSubscriptionToggleStatus()
	{
	}

	[Token(Token = "0x6010C81")]
	[Address(RVA = "0x269CF98", Offset = "0x269CF98", VA = "0x269CF98")]
	private void RefreshPurchaseBtnByPackageType()
	{
	}

	[Token(Token = "0x6010C82")]
	[Address(RVA = "0x269D5F8", Offset = "0x269D5F8", VA = "0x269D5F8")]
	private void RefreshPrice()
	{
	}

	[Token(Token = "0x6010C83")]
	[Address(RVA = "0x269E650", Offset = "0x269E650", VA = "0x269E650")]
	private void UpdateSubscriptionBonus()
	{
	}

	[Token(Token = "0x6010C84")]
	[Address(RVA = "0x269FBC4", Offset = "0x269FBC4", VA = "0x269FBC4")]
	private bool IsInGracePeriod()
	{
		return default(bool);
	}

	[Token(Token = "0x6010C85")]
	[Address(RVA = "0x269FD50", Offset = "0x269FD50", VA = "0x269FD50")]
	private bool OnHold()
	{
		return default(bool);
	}

	[Token(Token = "0x6010C86")]
	[Address(RVA = "0x269FEDC", Offset = "0x269FEDC", VA = "0x269FEDC")]
	private void OnSubscriptionHintButtonClick()
	{
	}

	[Token(Token = "0x6010C87")]
	[Address(RVA = "0x26A01C8", Offset = "0x26A01C8", VA = "0x26A01C8")]
	private void OnBtnPurchaseClick()
	{
	}

	[Token(Token = "0x6010C88")]
	[Address(RVA = "0x26A0A14", Offset = "0x26A0A14", VA = "0x26A0A14")]
	private void OnBtnThirdPartyPurchaseClick()
	{
	}

	[Token(Token = "0x6010C89")]
	[Address(RVA = "0x26A08DC", Offset = "0x26A08DC", VA = "0x26A08DC")]
	private void GotoSubscription()
	{
	}

	[Token(Token = "0x6010C8A")]
	[Address(RVA = "0x26A0BB0", Offset = "0x26A0BB0", VA = "0x26A0BB0")]
	private void OnGracePeriodButtonClick()
	{
	}

	[Token(Token = "0x6010C8B")]
	[Address(RVA = "0x26A0CB4", Offset = "0x26A0CB4", VA = "0x26A0CB4")]
	private void OnFixOnHoldButtonClick()
	{
	}

	[Token(Token = "0x6010C8C")]
	[Address(RVA = "0x26A0DB8", Offset = "0x26A0DB8", VA = "0x26A0DB8")]
	private void OnTotalValueTipButtonClick()
	{
	}

	[Token(Token = "0x6010C8D")]
	[Address(RVA = "0x26A1120", Offset = "0x26A1120", VA = "0x26A1120", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6010C8E")]
	[Address(RVA = "0x26A128C", Offset = "0x26A128C", VA = "0x26A128C", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6010C8F")]
	[Address(RVA = "0x26A1308", Offset = "0x26A1308", VA = "0x26A1308", Slot = "33")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010C90")]
	[Address(RVA = "0x26A1530", Offset = "0x26A1530", VA = "0x26A1530", Slot = "34")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010C91")]
	[Address(RVA = "0x26A15C4", Offset = "0x26A15C4", VA = "0x26A15C4")]
	private static BaseItemInfo _003CRefreshShowReward_003Em__0(AwardDesc item)
	{
		return null;
	}

	[Token(Token = "0x6010C92")]
	[Address(RVA = "0x26A1648", Offset = "0x26A1648", VA = "0x26A1648")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010C93")]
	[Address(RVA = "0x26A1650", Offset = "0x26A1650", VA = "0x26A1650")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
