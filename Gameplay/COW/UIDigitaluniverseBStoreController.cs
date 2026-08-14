using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2001F08")]
internal class UIDigitaluniverseBStoreController : UIBigEventStoreBaseController, _Attribute
{
	[Token(Token = "0x2001F09")]
	public enum ETabType
	{
		[Token(Token = "0x400C354")]
		None,
		[Token(Token = "0x400C355")]
		Store1,
		[Token(Token = "0x400C356")]
		Store2
	}

	[Token(Token = "0x400C346")]
	[FieldOffset(Offset = "0x7C")]
	private UIDigitaluniverseBStoreView m_View;

	[Token(Token = "0x400C347")]
	[FieldOffset(Offset = "0x80")]
	private UIModelDigitaluniverseB m_ModelDigitaluniverseB;

	[Token(Token = "0x400C348")]
	[FieldOffset(Offset = "0x84")]
	private UIModelBigEvent m_ModelBigEvent;

	[Token(Token = "0x400C349")]
	[FieldOffset(Offset = "0x88")]
	private UIDigitaluniverseBTopBtnController m_TopBtnCtrl;

	[Token(Token = "0x400C34A")]
	[FieldOffset(Offset = "0x8C")]
	private List<LimitedEventStore> m_StoreDataList;

	[Token(Token = "0x400C34B")]
	[FieldOffset(Offset = "0x90")]
	private GameObject[] m_RedPointArray;

	[Token(Token = "0x400C34C")]
	[FieldOffset(Offset = "0x94")]
	private UIDigitaluniverseBStoreAwardsWndController m_AwardsWnd;

	[Token(Token = "0x400C34D")]
	[FieldOffset(Offset = "0x98")]
	private UIStandardItemMiniController m_SpecialAwardItem;

	[Token(Token = "0x400C34E")]
	[FieldOffset(Offset = "0x9C")]
	private DigitaluniverseBStoreRecommendDesc m_StoreDesc;

	[Token(Token = "0x400C34F")]
	[FieldOffset(Offset = "0xA0")]
	private uint m_DelayCallID;

	[Token(Token = "0x400C350")]
	[FieldOffset(Offset = "0xA4")]
	private UINavigationUtil.UINavigationFrom m_From;

	[Token(Token = "0x400C351")]
	[FieldOffset(Offset = "0xA8")]
	private ETabType m_StoreTabType;

	[Token(Token = "0x400C352")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60097E6")]
	[Address(RVA = "0x2F1B3A8", Offset = "0x2F1B3A8", VA = "0x2F1B3A8")]
	public UIDigitaluniverseBStoreController()
	{
	}

	[Token(Token = "0x60097E7")]
	[Address(RVA = "0x2F1B3B8", Offset = "0x2F1B3B8", VA = "0x2F1B3B8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60097E8")]
	[Address(RVA = "0x2F1B460", Offset = "0x2F1B460", VA = "0x2F1B460", Slot = "44")]
	public override EActivity.SubType GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x60097E9")]
	[Address(RVA = "0x2F1B4B8", Offset = "0x2F1B4B8", VA = "0x2F1B4B8", Slot = "43")]
	public override ELimitedEvent.EventID GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x60097EA")]
	[Address(RVA = "0x2F1B510", Offset = "0x2F1B510", VA = "0x2F1B510", Slot = "45")]
	public override UIModelBigEvent.EBigEventEntranceID GetEntranceId()
	{
		return default(UIModelBigEvent.EBigEventEntranceID);
	}

	[Token(Token = "0x60097EB")]
	[Address(RVA = "0x2F1B568", Offset = "0x2F1B568", VA = "0x2F1B568")]
	private ELimitedEvent.StoreType GetStoreId()
	{
		return default(ELimitedEvent.StoreType);
	}

	[Token(Token = "0x60097EC")]
	[Address(RVA = "0x2F1B5C0", Offset = "0x2F1B5C0", VA = "0x2F1B5C0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60097ED")]
	[Address(RVA = "0x2F1BF50", Offset = "0x2F1BF50", VA = "0x2F1BF50", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x60097EE")]
	[Address(RVA = "0x2F1CE5C", Offset = "0x2F1CE5C", VA = "0x2F1CE5C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60097EF")]
	[Address(RVA = "0x2F1CF70", Offset = "0x2F1CF70", VA = "0x2F1CF70", Slot = "48")]
	public override UIBigEventStoreItemBaseController GetStoreItemController()
	{
		return null;
	}

	[Token(Token = "0x60097F0")]
	[Address(RVA = "0x2F1BFE4", Offset = "0x2F1BFE4", VA = "0x2F1BFE4")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x60097F1")]
	[Address(RVA = "0x2F1D814", Offset = "0x2F1D814", VA = "0x2F1D814")]
	private void OnBtnGoToClick()
	{
	}

	[Token(Token = "0x60097F2")]
	[Address(RVA = "0x2F1D92C", Offset = "0x2F1D92C", VA = "0x2F1D92C")]
	private void OnBtnRewardPreviewClick()
	{
	}

	[Token(Token = "0x60097F3")]
	[Address(RVA = "0x2F1DAFC", Offset = "0x2F1DAFC", VA = "0x2F1DAFC")]
	private void GotoDoor(object[] data)
	{
	}

	[Token(Token = "0x60097F4")]
	[Address(RVA = "0x2F1D090", Offset = "0x2F1D090", VA = "0x2F1D090")]
	private void OnTopTabSelect(ETabType tabType, bool isForce = false)
	{
	}

	[Token(Token = "0x60097F5")]
	[Address(RVA = "0x2F1DDFC", Offset = "0x2F1DDFC", VA = "0x2F1DDFC")]
	private void OnBtnSwitchRedPointClick()
	{
	}

	[Token(Token = "0x60097F6")]
	[Address(RVA = "0x2F1DF9C", Offset = "0x2F1DF9C", VA = "0x2F1DF9C")]
	private void OnBtnRuleClick()
	{
	}

	[Token(Token = "0x60097F7")]
	[Address(RVA = "0x2F1E190", Offset = "0x2F1E190", VA = "0x2F1E190", Slot = "50")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60097F8")]
	[Address(RVA = "0x2F1E248", Offset = "0x2F1E248", VA = "0x2F1E248", Slot = "49")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60097F9")]
	[Address(RVA = "0x2F1E798", Offset = "0x2F1E798", VA = "0x2F1E798")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x60097FA")]
	[Address(RVA = "0x2F1E7A4", Offset = "0x2F1E7A4", VA = "0x2F1E7A4")]
	private void _003COnUIInit_003Em__1()
	{
	}

	[Token(Token = "0x60097FB")]
	[Address(RVA = "0x2F1E7B0", Offset = "0x2F1E7B0", VA = "0x2F1E7B0")]
	private void _003CRefreshView_003Em__2()
	{
	}

	[Token(Token = "0x60097FC")]
	[Address(RVA = "0x2F1E814", Offset = "0x2F1E814", VA = "0x2F1E814")]
	private static CommonRewardItemInfo _003COnDataChanged_003Em__3(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x60097FD")]
	[Address(RVA = "0x2F1E81C", Offset = "0x2F1E81C", VA = "0x2F1E81C")]
	public EActivity.SubType _003C_003EiFixBaseProxy_GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x60097FE")]
	[Address(RVA = "0x2F1E824", Offset = "0x2F1E824", VA = "0x2F1E824")]
	public ELimitedEvent.EventID _003C_003EiFixBaseProxy_GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x60097FF")]
	[Address(RVA = "0x2F1E82C", Offset = "0x2F1E82C", VA = "0x2F1E82C")]
	public UIModelBigEvent.EBigEventEntranceID _003C_003EiFixBaseProxy_GetEntranceId()
	{
		return default(UIModelBigEvent.EBigEventEntranceID);
	}

	[Token(Token = "0x6009800")]
	[Address(RVA = "0x2F1E834", Offset = "0x2F1E834", VA = "0x2F1E834")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009801")]
	[Address(RVA = "0x2F1E83C", Offset = "0x2F1E83C", VA = "0x2F1E83C")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x6009802")]
	[Address(RVA = "0x2F1E844", Offset = "0x2F1E844", VA = "0x2F1E844")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6009803")]
	[Address(RVA = "0x2F1E84C", Offset = "0x2F1E84C", VA = "0x2F1E84C")]
	public UIBigEventStoreItemBaseController _003C_003EiFixBaseProxy_GetStoreItemController()
	{
		return null;
	}
}
