using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using tcp;

namespace COW;

[Token(Token = "0x2002AE8")]
public class UIRoomListController : UINavigationController, _Attribute, IConvertible
{
	[Token(Token = "0x2002AE9")]
	private class RoomTabInfo
	{
		[Token(Token = "0x4010788")]
		[FieldOffset(Offset = "0x8")]
		public string Key;

		[Token(Token = "0x4010789")]
		[FieldOffset(Offset = "0xC")]
		public Action CB;

		[Token(Token = "0x401078A")]
		[FieldOffset(Offset = "0x10")]
		public Func<bool> ShowCondition;

		[Token(Token = "0x401078B")]
		[FieldOffset(Offset = "0x14")]
		public ERoom.TabType TabType;

		[Token(Token = "0x60119D0")]
		[Address(RVA = "0x23C3684", Offset = "0x23C3684", VA = "0x23C3684")]
		public RoomTabInfo()
		{
		}
	}

	[Token(Token = "0x2002AEA")]
	private enum UGCTagType
	{
		[Token(Token = "0x401078D")]
		TabType_None,
		[Token(Token = "0x401078E")]
		TagType_GameMode,
		[Token(Token = "0x401078F")]
		TagType_Feature
	}

	[Token(Token = "0x2002AEB")]
	private sealed class _003CGameModeGuideCoroutine_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010790")]
		[FieldOffset(Offset = "0x8")]
		internal UIRoomListController _0024this;

		[Token(Token = "0x4010791")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4010792")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4010793")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170012DD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60119D3")]
			[Address(RVA = "0x23CC454", Offset = "0x23CC454", VA = "0x23CC454", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012DE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60119D4")]
			[Address(RVA = "0x23CC45C", Offset = "0x23CC45C", VA = "0x23CC45C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60119D1")]
		[Address(RVA = "0x23C368C", Offset = "0x23C368C", VA = "0x23C368C")]
		public _003CGameModeGuideCoroutine_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x60119D2")]
		[Address(RVA = "0x23CC334", Offset = "0x23CC334", VA = "0x23CC334", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60119D5")]
		[Address(RVA = "0x23CC464", Offset = "0x23CC464", VA = "0x23CC464", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60119D6")]
		[Address(RVA = "0x23CC478", Offset = "0x23CC478", VA = "0x23CC478", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002AEC")]
	private sealed class _003CGetTabIndexByTabType_003Ec__AnonStorey1
	{
		[Token(Token = "0x4010794")]
		[FieldOffset(Offset = "0x8")]
		internal ERoom.TabType tabType;

		[Token(Token = "0x60119D7")]
		[Address(RVA = "0x23C72D4", Offset = "0x23C72D4", VA = "0x23C72D4")]
		public _003CGetTabIndexByTabType_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60119D8")]
		[Address(RVA = "0x23CC500", Offset = "0x23CC500", VA = "0x23CC500")]
		internal bool _003C_003Em__0(StandardTabItemViewData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002AED")]
	private sealed class _003CShowFreeRoomCardGuide_003Ec__AnonStorey2
	{
		[Token(Token = "0x4010795")]
		[FieldOffset(Offset = "0x8")]
		internal string guideKey;

		[Token(Token = "0x60119D9")]
		[Address(RVA = "0x23C917C", Offset = "0x23C917C", VA = "0x23C917C")]
		public _003CShowFreeRoomCardGuide_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x60119DA")]
		[Address(RVA = "0x23CC58C", Offset = "0x23CC58C", VA = "0x23CC58C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x401076E")]
	private const int COOLDOWN_SECONDS = 30;

	[Token(Token = "0x401076F")]
	[FieldOffset(Offset = "0x68")]
	private CountDownConfig config;

	[Token(Token = "0x4010770")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelMall m_ModelMall;

	[Token(Token = "0x4010771")]
	[FieldOffset(Offset = "0x70")]
	private UIModelCustomRoom m_ModelCustomRoom;

	[Token(Token = "0x4010772")]
	[FieldOffset(Offset = "0x74")]
	private UIRoomListView m_View;

	[Token(Token = "0x4010773")]
	[FieldOffset(Offset = "0x78")]
	private ERoom.TabType m_RoomTabType;

	[Token(Token = "0x4010774")]
	[FieldOffset(Offset = "0x7C")]
	private bool m_HasLeagueRequested;

	[Token(Token = "0x4010775")]
	[FieldOffset(Offset = "0x7D")]
	private bool m_HasRushingPetsRequested;

	[Token(Token = "0x4010776")]
	[FieldOffset(Offset = "0x7E")]
	private bool m_HasWereWolvesRequested;

	[Token(Token = "0x4010777")]
	[FieldOffset(Offset = "0x7F")]
	private bool m_HasWorkshopRequested;

	[Token(Token = "0x4010778")]
	[FieldOffset(Offset = "0x80")]
	private UIRoomModeSelectPopupWindowController m_RoomModeSelectPopupWindowController;

	[Token(Token = "0x4010779")]
	[FieldOffset(Offset = "0x84")]
	private UIRoomCardListController m_RoomCardCtrl;

	[Token(Token = "0x401077A")]
	[FieldOffset(Offset = "0x88")]
	private bool m_IsRefreshCountDown;

	[Token(Token = "0x401077B")]
	[FieldOffset(Offset = "0x89")]
	private bool m_PlayedItemTweenAnim;

	[Token(Token = "0x401077C")]
	[FieldOffset(Offset = "0x8C")]
	private UIPopMenuSmallControler m_GroupPopMenuCtrl;

	[Token(Token = "0x401077D")]
	[FieldOffset(Offset = "0x90")]
	private UIPopMenuSmallControler m_ModePopMenuCtrl;

	[Token(Token = "0x401077E")]
	[FieldOffset(Offset = "0x94")]
	protected List<PopMenuData> m_PopMenuDataList;

	[Token(Token = "0x401077F")]
	[FieldOffset(Offset = "0x98")]
	private RoomBasicInfo m_CurrentQuickJoinRoomInfo;

	[Token(Token = "0x4010780")]
	[FieldOffset(Offset = "0x9C")]
	private List<FRoomModeSelectData> m_RoomModeSelectDatas;

	[Token(Token = "0x4010781")]
	[FieldOffset(Offset = "0xA0")]
	private UIStandardDrawerTabController m_DrawerTabCtrl;

	[Token(Token = "0x4010782")]
	[FieldOffset(Offset = "0xA4")]
	private List<RoomTabInfo> m_RoomTabInfoList;

	[Token(Token = "0x4010783")]
	[FieldOffset(Offset = "0xA8")]
	private List<StandardTabItemViewData> m_StandatdTabDataList;

	[Token(Token = "0x4010784")]
	[FieldOffset(Offset = "0xAC")]
	protected List<ResourceID> m_WereWolvesNeedDownloadRes;

	[Token(Token = "0x4010785")]
	[FieldOffset(Offset = "0xB0")]
	protected List<ResourceID> m_RushingPetsNeedDownloadRes;

	[Token(Token = "0x4010786")]
	[FieldOffset(Offset = "0x0")]
	private static Func<bool> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4010787")]
	[FieldOffset(Offset = "0x4")]
	private static Func<bool> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x170012DC")]
	private List<FRoomModeSelectData> RoomModeSelectDatas
	{
		[Token(Token = "0x6011994")]
		[Address(RVA = "0x23C1094", Offset = "0x23C1094", VA = "0x23C1094")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6011993")]
	[Address(RVA = "0x23C0EFC", Offset = "0x23C0EFC", VA = "0x23C0EFC")]
	public UIRoomListController()
	{
	}

	[Token(Token = "0x6011995")]
	[Address(RVA = "0x23C116C", Offset = "0x23C116C", VA = "0x23C116C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011996")]
	[Address(RVA = "0x23C1210", Offset = "0x23C1210", VA = "0x23C1210", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011997")]
	[Address(RVA = "0x23C1C34", Offset = "0x23C1C34", VA = "0x23C1C34", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6011998")]
	[Address(RVA = "0x23C26EC", Offset = "0x23C26EC", VA = "0x23C26EC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011999")]
	[Address(RVA = "0x23C289C", Offset = "0x23C289C", VA = "0x23C289C", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x601199A")]
	[Address(RVA = "0x23C3338", Offset = "0x23C3338", VA = "0x23C3338", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x601199B")]
	[Address(RVA = "0x23C35F0", Offset = "0x23C35F0", VA = "0x23C35F0")]
	private ERoom.TabType ChangeRoomType2TabType(ERoom.Type roomType)
	{
		return default(ERoom.TabType);
	}

	[Token(Token = "0x601199C")]
	[Address(RVA = "0x23C1D54", Offset = "0x23C1D54", VA = "0x23C1D54")]
	private void InitTabInfo()
	{
	}

	[Token(Token = "0x601199D")]
	[Address(RVA = "0x23C208C", Offset = "0x23C208C", VA = "0x23C208C")]
	private void CreateTabs()
	{
	}

	[Token(Token = "0x601199E")]
	[Address(RVA = "0x23C1B68", Offset = "0x23C1B68", VA = "0x23C1B68")]
	private IEnumerator GameModeGuideCoroutine()
	{
		return null;
	}

	[Token(Token = "0x601199F")]
	[Address(RVA = "0x23C33DC", Offset = "0x23C33DC", VA = "0x23C33DC")]
	private void HideGameModeGuide()
	{
	}

	[Token(Token = "0x60119A0")]
	[Address(RVA = "0x23C3694", Offset = "0x23C3694", VA = "0x23C3694")]
	private void OnInputChanged()
	{
	}

	[Token(Token = "0x60119A1")]
	[Address(RVA = "0x23C37A4", Offset = "0x23C37A4", VA = "0x23C37A4")]
	private void OnBtnInputClear()
	{
	}

	[Token(Token = "0x60119A2")]
	[Address(RVA = "0x23C38B4", Offset = "0x23C38B4", VA = "0x23C38B4")]
	private uint GetFirstValidMapConfigByMode(uint modeId)
	{
		return default(uint);
	}

	[Token(Token = "0x60119A3")]
	[Address(RVA = "0x23C3A6C", Offset = "0x23C3A6C", VA = "0x23C3A6C")]
	private void GenerateGameModeMenuData()
	{
	}

	[Token(Token = "0x60119A4")]
	[Address(RVA = "0x23C4770", Offset = "0x23C4770", VA = "0x23C4770")]
	private void GenerateGroupMenuData()
	{
	}

	[Token(Token = "0x60119A5")]
	[Address(RVA = "0x23C571C", Offset = "0x23C571C", VA = "0x23C571C")]
	private void OnModeSelected(object obj)
	{
	}

	[Token(Token = "0x60119A6")]
	[Address(RVA = "0x23C5C98", Offset = "0x23C5C98", VA = "0x23C5C98")]
	private void OnGroupSelected(object obj)
	{
	}

	[Token(Token = "0x60119A7")]
	[Address(RVA = "0x23C5D78", Offset = "0x23C5D78", VA = "0x23C5D78")]
	private void OnBtnQuickJoin()
	{
	}

	[Token(Token = "0x60119A8")]
	[Address(RVA = "0x23C6D10", Offset = "0x23C6D10", VA = "0x23C6D10")]
	public void SearchRoomById(ERoom.Type roomType, string roomId)
	{
	}

	[Token(Token = "0x60119A9")]
	[Address(RVA = "0x23C7190", Offset = "0x23C7190", VA = "0x23C7190")]
	private int GetTabIndexByTabType(ERoom.TabType tabType)
	{
		return default(int);
	}

	[Token(Token = "0x60119AA")]
	[Address(RVA = "0x23C6DF4", Offset = "0x23C6DF4", VA = "0x23C6DF4")]
	private void SelectTabByRoomTabType(ERoom.TabType tabType)
	{
	}

	[Token(Token = "0x60119AB")]
	[Address(RVA = "0x23C72DC", Offset = "0x23C72DC", VA = "0x23C72DC")]
	private void SelectCasual()
	{
	}

	[Token(Token = "0x60119AC")]
	[Address(RVA = "0x23C7430", Offset = "0x23C7430", VA = "0x23C7430")]
	private void SelectLeagueNormal()
	{
	}

	[Token(Token = "0x60119AD")]
	[Address(RVA = "0x23C74EC", Offset = "0x23C74EC", VA = "0x23C74EC")]
	private void SelectWereWolvesRoom()
	{
	}

	[Token(Token = "0x60119AE")]
	[Address(RVA = "0x23C75A8", Offset = "0x23C75A8", VA = "0x23C75A8")]
	private void SelectMyRoom()
	{
	}

	[Token(Token = "0x60119AF")]
	[Address(RVA = "0x23C760C", Offset = "0x23C760C", VA = "0x23C760C")]
	private void SelectWorkshopRoom()
	{
	}

	[Token(Token = "0x60119B0")]
	[Address(RVA = "0x23C7794", Offset = "0x23C7794", VA = "0x23C7794")]
	private void SelectRushingPetsRoom()
	{
	}

	[Token(Token = "0x60119B1")]
	[Address(RVA = "0x23C6E8C", Offset = "0x23C6E8C", VA = "0x23C6E8C")]
	private void OnBtnRoomSearch()
	{
	}

	[Token(Token = "0x60119B2")]
	[Address(RVA = "0x23C7340", Offset = "0x23C7340", VA = "0x23C7340")]
	private void OnRoomToggleSelect(ERoom.TabType roomType)
	{
	}

	[Token(Token = "0x60119B3")]
	[Address(RVA = "0x23C7E6C", Offset = "0x23C7E6C", VA = "0x23C7E6C")]
	private void UpdatePopMenu()
	{
	}

	[Token(Token = "0x60119B4")]
	[Address(RVA = "0x23C57FC", Offset = "0x23C57FC", VA = "0x23C57FC")]
	private void RefreshRoomListByModeAndGroup()
	{
	}

	[Token(Token = "0x60119B5")]
	[Address(RVA = "0x23C8754", Offset = "0x23C8754", VA = "0x23C8754")]
	private void ShowFreeRoomCardGuide()
	{
	}

	[Token(Token = "0x60119B6")]
	[Address(RVA = "0x23C8BF8", Offset = "0x23C8BF8", VA = "0x23C8BF8")]
	private void ShowFreeRoomCardRefreshTips()
	{
	}

	[Token(Token = "0x60119B7")]
	[Address(RVA = "0x23C9184", Offset = "0x23C9184", VA = "0x23C9184")]
	private void OnBtnRoomRefresh()
	{
	}

	[Token(Token = "0x60119B8")]
	[Address(RVA = "0x23C96F0", Offset = "0x23C96F0", VA = "0x23C96F0")]
	private void OnBtnRoomCreate()
	{
	}

	[Token(Token = "0x60119B9")]
	[Address(RVA = "0x23CA170", Offset = "0x23CA170", VA = "0x23CA170")]
	private void TryToCreateWereWolvesRoom()
	{
	}

	[Token(Token = "0x60119BA")]
	[Address(RVA = "0x23CA7A0", Offset = "0x23CA7A0", VA = "0x23CA7A0")]
	private void TryToCreateRushingPetsRoom()
	{
	}

	[Token(Token = "0x60119BB")]
	[Address(RVA = "0x23CADD0", Offset = "0x23CADD0", VA = "0x23CADD0")]
	private void OnSelectModeApply()
	{
	}

	[Token(Token = "0x60119BC")]
	[Address(RVA = "0x23CAE38", Offset = "0x23CAE38", VA = "0x23CAE38")]
	private void InitGameModePopMenuData()
	{
	}

	[Token(Token = "0x60119BD")]
	[Address(RVA = "0x23CB348", Offset = "0x23CB348", VA = "0x23CB348")]
	private void RecordJoinFailRoom(object[] param)
	{
	}

	[Token(Token = "0x60119BE")]
	[Address(RVA = "0x23CB424", Offset = "0x23CB424", VA = "0x23CB424")]
	private void UpdateBatchRoom(object[] param)
	{
	}

	[Token(Token = "0x60119BF")]
	[Address(RVA = "0x23C2B6C", Offset = "0x23C2B6C", VA = "0x23C2B6C")]
	private void UpdateRoomCard()
	{
	}

	[Token(Token = "0x60119C0")]
	[Address(RVA = "0x23C7BAC", Offset = "0x23C7BAC", VA = "0x23C7BAC")]
	private void UpdateCreateRoomBtn()
	{
	}

	[Token(Token = "0x60119C1")]
	[Address(RVA = "0x23C7850", Offset = "0x23C7850", VA = "0x23C7850")]
	private void RefreshRoomList(List<RoomBasicInfo> roomList)
	{
	}

	[Token(Token = "0x60119C2")]
	[Address(RVA = "0x23CB9A0", Offset = "0x23CB9A0", VA = "0x23CB9A0")]
	private void OnCountDownStarted()
	{
	}

	[Token(Token = "0x60119C3")]
	[Address(RVA = "0x23CBB70", Offset = "0x23CBB70", VA = "0x23CBB70")]
	private void OnCountDownUpdate()
	{
	}

	[Token(Token = "0x60119C4")]
	[Address(RVA = "0x23C3168", Offset = "0x23C3168", VA = "0x23C3168")]
	private void OnCountDownFinished()
	{
	}

	[Token(Token = "0x60119C5")]
	[Address(RVA = "0x23CBE54", Offset = "0x23CBE54", VA = "0x23CBE54", Slot = "42")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60119C6")]
	[Address(RVA = "0x23CBFB8", Offset = "0x23CBFB8", VA = "0x23CBFB8", Slot = "43")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60119C7")]
	[Address(RVA = "0x23CC094", Offset = "0x23CC094", VA = "0x23CC094", Slot = "44")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60119C8")]
	[Address(RVA = "0x23CC280", Offset = "0x23CC280", VA = "0x23CC280", Slot = "45")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x60119C9")]
	[Address(RVA = "0x23CC2FC", Offset = "0x23CC2FC", VA = "0x23CC2FC")]
	private static bool _003CInitTabInfo_003Em__0()
	{
		return default(bool);
	}

	[Token(Token = "0x60119CA")]
	[Address(RVA = "0x23CC304", Offset = "0x23CC304", VA = "0x23CC304")]
	private static bool _003CInitTabInfo_003Em__1()
	{
		return default(bool);
	}

	[Token(Token = "0x60119CB")]
	[Address(RVA = "0x23CC30C", Offset = "0x23CC30C", VA = "0x23CC30C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60119CC")]
	[Address(RVA = "0x23CC314", Offset = "0x23CC314", VA = "0x23CC314")]
	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x60119CD")]
	[Address(RVA = "0x23CC31C", Offset = "0x23CC31C", VA = "0x23CC31C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60119CE")]
	[Address(RVA = "0x23CC324", Offset = "0x23CC324", VA = "0x23CC324")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x60119CF")]
	[Address(RVA = "0x23CC32C", Offset = "0x23CC32C", VA = "0x23CC32C")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}
}
