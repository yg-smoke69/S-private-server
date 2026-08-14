using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2001F42")]
internal class UIFFWS03StoreController : UIBigEventStoreBaseController, _Attribute
{
	[Token(Token = "0x2001F43")]
	public enum ETabType
	{
		[Token(Token = "0x400C4A1")]
		None,
		[Token(Token = "0x400C4A2")]
		Store1,
		[Token(Token = "0x400C4A3")]
		Store2
	}

	[Token(Token = "0x400C498")]
	[FieldOffset(Offset = "0x7C")]
	private UIFFWS03StoreView m_View;

	[Token(Token = "0x400C499")]
	[FieldOffset(Offset = "0x80")]
	private List<LimitedEventStore> m_StoreDataList;

	[Token(Token = "0x400C49A")]
	[FieldOffset(Offset = "0x84")]
	private UIModelBigEvent m_ModelBigEvent;

	[Token(Token = "0x400C49B")]
	[FieldOffset(Offset = "0x88")]
	private UIModelFFWS03 m_ModelFFWS03;

	[Token(Token = "0x400C49C")]
	[FieldOffset(Offset = "0x8C")]
	private UIFFWS03TopBtnController m_TopBtnCtrl;

	[Token(Token = "0x400C49D")]
	[FieldOffset(Offset = "0x90")]
	private GameObject[] m_RedPointArray;

	[Token(Token = "0x400C49E")]
	[FieldOffset(Offset = "0x94")]
	private ETabType m_StoreTabType;

	[Token(Token = "0x400C49F")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6009A55")]
	[Address(RVA = "0x1DB0C84", Offset = "0x1DB0C84", VA = "0x1DB0C84")]
	public UIFFWS03StoreController()
	{
	}

	[Token(Token = "0x6009A56")]
	[Address(RVA = "0x1DB0C8C", Offset = "0x1DB0C8C", VA = "0x1DB0C8C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009A57")]
	[Address(RVA = "0x1DB0D34", Offset = "0x1DB0D34", VA = "0x1DB0D34", Slot = "43")]
	public override ELimitedEvent.EventID GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x6009A58")]
	[Address(RVA = "0x1DB0D8C", Offset = "0x1DB0D8C", VA = "0x1DB0D8C", Slot = "45")]
	public override UIModelBigEvent.EBigEventEntranceID GetEntranceId()
	{
		return default(UIModelBigEvent.EBigEventEntranceID);
	}

	[Token(Token = "0x6009A59")]
	[Address(RVA = "0x1DB0DE4", Offset = "0x1DB0DE4", VA = "0x1DB0DE4", Slot = "48")]
	public override UIBigEventStoreItemBaseController GetStoreItemController()
	{
		return null;
	}

	[Token(Token = "0x6009A5A")]
	[Address(RVA = "0x1DB0F04", Offset = "0x1DB0F04", VA = "0x1DB0F04", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009A5B")]
	[Address(RVA = "0x1DB19A0", Offset = "0x1DB19A0", VA = "0x1DB19A0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6009A5C")]
	[Address(RVA = "0x1DB1A4C", Offset = "0x1DB1A4C", VA = "0x1DB1A4C")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x6009A5D")]
	[Address(RVA = "0x1DB25A0", Offset = "0x1DB25A0", VA = "0x1DB25A0")]
	private void OnBtnSwitchRedPointClick()
	{
	}

	[Token(Token = "0x6009A5E")]
	[Address(RVA = "0x1DB26E8", Offset = "0x1DB26E8", VA = "0x1DB26E8")]
	private void OnBtnRuleClick()
	{
	}

	[Token(Token = "0x6009A5F")]
	[Address(RVA = "0x1DB2020", Offset = "0x1DB2020", VA = "0x1DB2020")]
	private void OnTopTabSelect(ETabType tabType, bool isForce = false)
	{
	}

	[Token(Token = "0x6009A60")]
	[Address(RVA = "0x1DB2820", Offset = "0x1DB2820", VA = "0x1DB2820", Slot = "49")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6009A61")]
	[Address(RVA = "0x1DB2CC8", Offset = "0x1DB2CC8", VA = "0x1DB2CC8", Slot = "50")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6009A62")]
	[Address(RVA = "0x1DB2D80", Offset = "0x1DB2D80", VA = "0x1DB2D80")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x6009A63")]
	[Address(RVA = "0x1DB2D8C", Offset = "0x1DB2D8C", VA = "0x1DB2D8C")]
	private void _003COnUIInit_003Em__1()
	{
	}

	[Token(Token = "0x6009A64")]
	[Address(RVA = "0x1DB2D98", Offset = "0x1DB2D98", VA = "0x1DB2D98")]
	private void _003CRefreshView_003Em__2()
	{
	}

	[Token(Token = "0x6009A65")]
	[Address(RVA = "0x1DB2DFC", Offset = "0x1DB2DFC", VA = "0x1DB2DFC")]
	private static CommonRewardItemInfo _003COnDataChanged_003Em__3(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x6009A66")]
	[Address(RVA = "0x1DB2E04", Offset = "0x1DB2E04", VA = "0x1DB2E04")]
	public ELimitedEvent.EventID _003C_003EiFixBaseProxy_GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x6009A67")]
	[Address(RVA = "0x1DB2E0C", Offset = "0x1DB2E0C", VA = "0x1DB2E0C")]
	public UIModelBigEvent.EBigEventEntranceID _003C_003EiFixBaseProxy_GetEntranceId()
	{
		return default(UIModelBigEvent.EBigEventEntranceID);
	}

	[Token(Token = "0x6009A68")]
	[Address(RVA = "0x1DB2E14", Offset = "0x1DB2E14", VA = "0x1DB2E14")]
	public UIBigEventStoreItemBaseController _003C_003EiFixBaseProxy_GetStoreItemController()
	{
		return null;
	}

	[Token(Token = "0x6009A69")]
	[Address(RVA = "0x1DB2E1C", Offset = "0x1DB2E1C", VA = "0x1DB2E1C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009A6A")]
	[Address(RVA = "0x1DB2E24", Offset = "0x1DB2E24", VA = "0x1DB2E24")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
