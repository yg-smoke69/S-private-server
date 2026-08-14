using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20025B0")]
internal class UICreateRoomController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x20025B1")]
	private sealed class _003CSelectDropListItem_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E95C")]
		[FieldOffset(Offset = "0x8")]
		internal uint drop;

		[Token(Token = "0x600DD47")]
		[Address(RVA = "0x2730720", Offset = "0x2730720", VA = "0x2730720")]
		public _003CSelectDropListItem_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600DD48")]
		[Address(RVA = "0x2730728", Offset = "0x2730728", VA = "0x2730728")]
		internal bool _003C_003Em__0(UIRoomDropListItemController i)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20025B2")]
	private sealed class _003CShowNormalConfirmPop_003Ec__AnonStorey1
	{
		[Token(Token = "0x400E95D")]
		[FieldOffset(Offset = "0x8")]
		internal RoomParams param;

		[Token(Token = "0x400E95E")]
		[FieldOffset(Offset = "0xC")]
		internal UICreateRoomController _0024this;

		[Token(Token = "0x600DD49")]
		[Address(RVA = "0x273076C", Offset = "0x273076C", VA = "0x273076C")]
		public _003CShowNormalConfirmPop_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600DD4A")]
		[Address(RVA = "0x2730774", Offset = "0x2730774", VA = "0x2730774")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400E905")]
	[FieldOffset(Offset = "0x48")]
	protected UICreateRoomView m_View;

	[Token(Token = "0x400E906")]
	[FieldOffset(Offset = "0x4C")]
	protected RoomCreateRuleDataManager m_DataManager;

	[Token(Token = "0x400E907")]
	[FieldOffset(Offset = "0x50")]
	protected UIModelCustomRoom m_CustomRoomModel;

	[Token(Token = "0x400E908")]
	[FieldOffset(Offset = "0x54")]
	protected List<PopMenuData> m_DataList;

	[Token(Token = "0x400E909")]
	[FieldOffset(Offset = "0x58")]
	protected uint m_MapConfigId;

	[Token(Token = "0x400E90A")]
	[FieldOffset(Offset = "0x5C")]
	protected string m_Name;

	[Token(Token = "0x400E90B")]
	[FieldOffset(Offset = "0x60")]
	protected string m_Code;

	[Token(Token = "0x400E90C")]
	[FieldOffset(Offset = "0x64")]
	protected uint m_GroupMode;

	[Token(Token = "0x400E90D")]
	[FieldOffset(Offset = "0x68")]
	protected uint m_MemberNum;

	[Token(Token = "0x400E90E")]
	[FieldOffset(Offset = "0x6C")]
	protected uint m_SpectatorNum;

	[Token(Token = "0x400E90F")]
	[FieldOffset(Offset = "0x70")]
	protected string m_Hp;

	[Token(Token = "0x400E910")]
	[FieldOffset(Offset = "0x74")]
	protected string m_Ep;

	[Token(Token = "0x400E911")]
	[FieldOffset(Offset = "0x78")]
	protected string m_Speed;

	[Token(Token = "0x400E912")]
	[FieldOffset(Offset = "0x7C")]
	protected string m_JumpHeght;

	[Token(Token = "0x400E913")]
	[FieldOffset(Offset = "0x80")]
	protected uint m_ReviveSwitch;

	[Token(Token = "0x400E914")]
	[FieldOffset(Offset = "0x84")]
	protected string m_CSTotalRound;

	[Token(Token = "0x400E915")]
	[FieldOffset(Offset = "0x88")]
	protected string m_CSInitCoin;

	[Token(Token = "0x400E916")]
	[FieldOffset(Offset = "0x8C")]
	protected string m_FightClubTotalRound;

	[Token(Token = "0x400E917")]
	[FieldOffset(Offset = "0x90")]
	protected bool m_OBEnabled;

	[Token(Token = "0x400E918")]
	[FieldOffset(Offset = "0x94")]
	protected uint m_CurMatchStartBuffKey;

	[Token(Token = "0x400E919")]
	[FieldOffset(Offset = "0x98")]
	protected bool m_EmulatorCheck;

	[Token(Token = "0x400E91A")]
	[FieldOffset(Offset = "0x9C")]
	protected uint m_VisualStyle;

	[Token(Token = "0x400E91B")]
	[FieldOffset(Offset = "0xA0")]
	protected uint m_RoomSetting;

	[Token(Token = "0x400E91C")]
	[FieldOffset(Offset = "0xA4")]
	protected uint m_RoomSetting2;

	[Token(Token = "0x400E91D")]
	[FieldOffset(Offset = "0xA8")]
	protected bool m_RoleCheck;

	[Token(Token = "0x400E91E")]
	[FieldOffset(Offset = "0xAC")]
	protected int m_ScoreVisible;

	[Token(Token = "0x400E91F")]
	[FieldOffset(Offset = "0xB0")]
	protected UIStandardTabController m_TabCtrl;

	[Token(Token = "0x400E920")]
	[FieldOffset(Offset = "0xB4")]
	protected UIRoomToggleBtnTemplateController m_WeatherCtrl;

	[Token(Token = "0x400E921")]
	[FieldOffset(Offset = "0xB8")]
	protected UIRoomToggleBtnTemplateController m_LimitedAmmoCtrl;

	[Token(Token = "0x400E922")]
	[FieldOffset(Offset = "0xBC")]
	protected UIRoomToggleBtnTemplateController m_FallDamageCtrl;

	[Token(Token = "0x400E923")]
	[FieldOffset(Offset = "0xC0")]
	protected UIRoomToggleBtnTemplateController m_AutoRevivalCtrl;

	[Token(Token = "0x400E924")]
	[FieldOffset(Offset = "0xC4")]
	protected UIRoomToggleBtnTemplateController m_LoadoutCtrl;

	[Token(Token = "0x400E925")]
	[FieldOffset(Offset = "0xC8")]
	protected UIRoomToggleBtnTemplateController m_AirdropCtrl;

	[Token(Token = "0x400E926")]
	[FieldOffset(Offset = "0xCC")]
	protected UIRoomToggleBtnTemplateController m_SaveZoneSpeedCtrl;

	[Token(Token = "0x400E927")]
	[FieldOffset(Offset = "0xD0")]
	protected UIRoomToggleBtnTemplateController m_SkillCtrl;

	[Token(Token = "0x400E928")]
	[FieldOffset(Offset = "0xD4")]
	protected UIRoomToggleBtnTemplateController m_VehicleCtrl;

	[Token(Token = "0x400E929")]
	[FieldOffset(Offset = "0xD8")]
	protected UIRoomToggleBtnTemplateController m_SaveZoneDamageCtrl;

	[Token(Token = "0x400E92A")]
	[FieldOffset(Offset = "0xDC")]
	protected UIRoomToggleBtnTemplateController m_UAVCtrl;

	[Token(Token = "0x400E92B")]
	[FieldOffset(Offset = "0xE0")]
	protected UIRoomToggleBtnTemplateController m_BombCtrl;

	[Token(Token = "0x400E92C")]
	[FieldOffset(Offset = "0xE4")]
	protected UIRoomToggleBtnTemplateController m_ReplayCtrl;

	[Token(Token = "0x400E92D")]
	[FieldOffset(Offset = "0xE8")]
	protected UIRoomToggleBtnTemplateController m_EmulatorCtrl;

	[Token(Token = "0x400E92E")]
	[FieldOffset(Offset = "0xEC")]
	protected UIRoomToggleBtnTemplateController m_ZeppelinCtrl;

	[Token(Token = "0x400E92F")]
	[FieldOffset(Offset = "0xF0")]
	protected UIRoomToggleBtnTemplateController m_HideClothCtrl;

	[Token(Token = "0x400E930")]
	[FieldOffset(Offset = "0xF4")]
	protected UIRoomToggleBtnTemplateController m_FriendlyFireCtrl;

	[Token(Token = "0x400E931")]
	[FieldOffset(Offset = "0xF8")]
	protected UIRoomToggleBtnTemplateController m_HideHudCtrl;

	[Token(Token = "0x400E932")]
	[FieldOffset(Offset = "0xFC")]
	protected UIRoomToggleBtnTemplateController m_RoomInGameChatCtrl;

	[Token(Token = "0x400E933")]
	[FieldOffset(Offset = "0x100")]
	protected UIRoomToggleBtnTemplateController m_ShopFlowCtrl;

	[Token(Token = "0x400E934")]
	[FieldOffset(Offset = "0x104")]
	protected UIRoomToggleBtnTemplateController m_UseRandomMapCtrl;

	[Token(Token = "0x400E935")]
	[FieldOffset(Offset = "0x108")]
	protected UIRoomToggleBtnTemplateController m_AuxAimCtrl;

	[Token(Token = "0x400E936")]
	[FieldOffset(Offset = "0x10C")]
	protected UIRoomToggleBtnTemplateController m_GameMissionCtrl;

	[Token(Token = "0x400E937")]
	[FieldOffset(Offset = "0x110")]
	protected UIRoomDropListTemplateController m_MembersCtrl;

	[Token(Token = "0x400E938")]
	[FieldOffset(Offset = "0x114")]
	protected UIRoomDropListTemplateController m_SpectatorsCtrl;

	[Token(Token = "0x400E939")]
	[FieldOffset(Offset = "0x118")]
	protected UIRoomDropListTemplateController m_HPCtrl;

	[Token(Token = "0x400E93A")]
	[FieldOffset(Offset = "0x11C")]
	protected UIRoomDropListTemplateController m_EPCtrl;

	[Token(Token = "0x400E93B")]
	[FieldOffset(Offset = "0x120")]
	protected UIRoomDropListTemplateController m_SpeedCtrl;

	[Token(Token = "0x400E93C")]
	[FieldOffset(Offset = "0x124")]
	protected UIRoomDropListTemplateController m_JumpHeghtCtrl;

	[Token(Token = "0x400E93D")]
	[FieldOffset(Offset = "0x128")]
	protected UIRoomDropListTemplateController m_ReviveSwitchCtrl;

	[Token(Token = "0x400E93E")]
	[FieldOffset(Offset = "0x12C")]
	protected UIRoomDropListTemplateController m_MatchStartBuffCtrl;

	[Token(Token = "0x400E93F")]
	[FieldOffset(Offset = "0x130")]
	protected UIRoomDropListTemplateController m_CSTotalRoundCtrl;

	[Token(Token = "0x400E940")]
	[FieldOffset(Offset = "0x134")]
	protected UIRoomDropListTemplateController m_CSInitCoinCtrl;

	[Token(Token = "0x400E941")]
	[FieldOffset(Offset = "0x138")]
	protected UIRoomDropListTemplateController m_FightClubTotalRoundCtrl;

	[Token(Token = "0x400E942")]
	[FieldOffset(Offset = "0x13C")]
	protected UIPopMenuSmallControler m_SelectModePopMenuSmallCtrl;

	[Token(Token = "0x400E943")]
	[FieldOffset(Offset = "0x140")]
	protected UIRoomCardListController m_RoomCardCtrl;

	[Token(Token = "0x400E944")]
	[FieldOffset(Offset = "0x144")]
	protected uint m_RoomType;

	[Token(Token = "0x400E945")]
	[FieldOffset(Offset = "0x148")]
	protected UIRoomToggleBtnTemplateController m_PowerGunCtrl;

	[Token(Token = "0x400E946")]
	[FieldOffset(Offset = "0x14C")]
	protected UICreateRoomSettingCSAdController m_SettingCSAdCtrl;

	[Token(Token = "0x400E947")]
	protected const int ROOM_CODE_MAX_LENGTH = 10;

	[Token(Token = "0x400E948")]
	protected const uint ESPORTS_DROP_ID = 9u;

	[Token(Token = "0x400E949")]
	protected const uint RANDOM_ROOM_DROP_ID = 10u;

	[Token(Token = "0x400E94A")]
	protected const float GAME_SETTING_PLAYER_MEMBER_POPMENU_OFFEST = 276f;

	[Token(Token = "0x400E94B")]
	protected const float GAME_SETTING_DROP_LIST_GRID_POPMENU_OFFSET = 189f;

	[Token(Token = "0x400E94C")]
	protected const float GAME_SETTING_CS_GRID_POPMENU_OFFSET = 189f;

	[Token(Token = "0x400E94D")]
	[FieldOffset(Offset = "0x150")]
	protected bool m_IsSettingController;

	[Token(Token = "0x400E94E")]
	[FieldOffset(Offset = "0x154")]
	protected Color disableColor;

	[Token(Token = "0x400E94F")]
	[FieldOffset(Offset = "0x164")]
	protected List<uint> m_MapIdList;

	[Token(Token = "0x400E950")]
	[FieldOffset(Offset = "0x168")]
	private List<UICreateRoomMapItem> m_MapItemList;

	[Token(Token = "0x400E951")]
	[FieldOffset(Offset = "0x16C")]
	private List<StandardTabItemViewData> m_tabs;

	[Token(Token = "0x400E952")]
	[FieldOffset(Offset = "0x170")]
	private bool m_CheatCodeInit;

	[Token(Token = "0x400E953")]
	[FieldOffset(Offset = "0x171")]
	private bool m_PowerGunShow;

	[Token(Token = "0x400E954")]
	[FieldOffset(Offset = "0x174")]
	private UIModelOptionalDownload m_ModelOptionalDownload;

	[Token(Token = "0x400E955")]
	[FieldOffset(Offset = "0x178")]
	private List<UIRoomDropListItemController> m_RoomDropListItems;

	[Token(Token = "0x400E956")]
	[FieldOffset(Offset = "0x17C")]
	private bool m_IsSettingRoomInit;

	[Token(Token = "0x400E957")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<DropListConfigInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400E958")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<DropListConfigInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400E959")]
	[FieldOffset(Offset = "0x8")]
	private static Comparison<DropListConfigInfo> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x400E95A")]
	[FieldOffset(Offset = "0xC")]
	private static Predicate<DropListConfigInfo> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x400E95B")]
	[FieldOffset(Offset = "0x10")]
	private static Action<string> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x1700114C")]
	protected List<UICreateRoomMapItem> MapItemList
	{
		[Token(Token = "0x600DCA0")]
		[Address(RVA = "0x1EC6E80", Offset = "0x1EC6E80", VA = "0x1EC6E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600DC9F")]
	[Address(RVA = "0x1EC6D64", Offset = "0x1EC6D64", VA = "0x1EC6D64")]
	public UICreateRoomController()
	{
	}

	[Token(Token = "0x600DCA1")]
	[Address(RVA = "0x1EC6F58", Offset = "0x1EC6F58", VA = "0x1EC6F58")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DCA2")]
	[Address(RVA = "0x1EC6FFC", Offset = "0x1EC6FFC", VA = "0x1EC6FFC", Slot = "9")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600DCA3")]
	[Address(RVA = "0x1EC706C", Offset = "0x1EC706C", VA = "0x1EC706C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DCA4")]
	[Address(RVA = "0x1EC9230", Offset = "0x1EC9230", VA = "0x1EC9230", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600DCA5")]
	[Address(RVA = "0x1EC9670", Offset = "0x1EC9670", VA = "0x1EC9670", Slot = "48")]
	protected virtual void InitPopMenus()
	{
	}

	[Token(Token = "0x600DCA6")]
	[Address(RVA = "0x1ECA6B0", Offset = "0x1ECA6B0", VA = "0x1ECA6B0", Slot = "39")]
	protected override void OnInitDepth()
	{
	}

	[Token(Token = "0x600DCA7")]
	[Address(RVA = "0x1EC7FD4", Offset = "0x1EC7FD4", VA = "0x1EC7FD4")]
	private void InitStandardTabs()
	{
	}

	[Token(Token = "0x600DCA8")]
	[Address(RVA = "0x1ECA93C", Offset = "0x1ECA93C", VA = "0x1ECA93C", Slot = "49")]
	protected virtual void InitToggleBtns()
	{
	}

	[Token(Token = "0x600DCA9")]
	[Address(RVA = "0x1EC9050", Offset = "0x1EC9050", VA = "0x1EC9050")]
	protected void RefreshRoomCard()
	{
	}

	[Token(Token = "0x600DCAA")]
	[Address(RVA = "0x1ECE540", Offset = "0x1ECE540", VA = "0x1ECE540")]
	protected EInventory.ItemSubType GetCurrentRoomCardType()
	{
		return default(EInventory.ItemSubType);
	}

	[Token(Token = "0x600DCAB")]
	[Address(RVA = "0x1ECE6A4", Offset = "0x1ECE6A4", VA = "0x1ECE6A4")]
	private void InitRegionSwitch()
	{
	}

	[Token(Token = "0x600DCAC")]
	[Address(RVA = "0x1ECEB50", Offset = "0x1ECEB50", VA = "0x1ECEB50")]
	private void SetTogglesStatus()
	{
	}

	[Token(Token = "0x600DCAD")]
	[Address(RVA = "0x1ECE230", Offset = "0x1ECE230", VA = "0x1ECE230")]
	private void RefreshGameMissionToggleStatus()
	{
	}

	[Token(Token = "0x600DCAE")]
	[Address(RVA = "0x1ECF1A8", Offset = "0x1ECF1A8", VA = "0x1ECF1A8", Slot = "50")]
	protected virtual void CalMapConfig()
	{
	}

	[Token(Token = "0x600DCAF")]
	[Address(RVA = "0x1EC85A8", Offset = "0x1EC85A8", VA = "0x1EC85A8")]
	private void InitUIContents()
	{
	}

	[Token(Token = "0x600DCB0")]
	[Address(RVA = "0x1ED10B0", Offset = "0x1ED10B0", VA = "0x1ED10B0")]
	private void OnSelectMap(UIToggleButton button)
	{
	}

	[Token(Token = "0x600DCB1")]
	[Address(RVA = "0x1ED13F0", Offset = "0x1ED13F0", VA = "0x1ED13F0")]
	protected void OnSoloToggleClick()
	{
	}

	[Token(Token = "0x600DCB2")]
	[Address(RVA = "0x1ED14C0", Offset = "0x1ED14C0", VA = "0x1ED14C0")]
	protected void OnDuoToggleClick()
	{
	}

	[Token(Token = "0x600DCB3")]
	[Address(RVA = "0x1ED1524", Offset = "0x1ED1524", VA = "0x1ED1524")]
	protected void OnQuadToggleClick()
	{
	}

	[Token(Token = "0x600DCB4")]
	[Address(RVA = "0x1ED1588", Offset = "0x1ED1588", VA = "0x1ED1588")]
	protected void OnPentaToggleClick()
	{
	}

	[Token(Token = "0x600DCB5")]
	[Address(RVA = "0x1ED15EC", Offset = "0x1ED15EC", VA = "0x1ED15EC")]
	protected void OnHexaToggleClick()
	{
	}

	[Token(Token = "0x600DCB6")]
	[Address(RVA = "0x1ED1454", Offset = "0x1ED1454", VA = "0x1ED1454")]
	protected void OnGroupModeToggleClick(uint groupMode)
	{
	}

	[Token(Token = "0x600DCB7")]
	[Address(RVA = "0x1ED19AC", Offset = "0x1ED19AC", VA = "0x1ED19AC")]
	protected void OnBtnLeagueNormalRoomClick()
	{
	}

	[Token(Token = "0x600DCB8")]
	[Address(RVA = "0x1ED1A14", Offset = "0x1ED1A14", VA = "0x1ED1A14")]
	protected void OnBtnCasualRoomClick()
	{
	}

	[Token(Token = "0x600DCB9")]
	[Address(RVA = "0x1ED1A7C", Offset = "0x1ED1A7C", VA = "0x1ED1A7C")]
	protected void OnBtnBatchRoomClick()
	{
	}

	[Token(Token = "0x600DCBA")]
	[Address(RVA = "0x1ED1AE4", Offset = "0x1ED1AE4", VA = "0x1ED1AE4")]
	private void OnRoomSettingClick()
	{
	}

	[Token(Token = "0x600DCBB")]
	[Address(RVA = "0x1ED2010", Offset = "0x1ED2010", VA = "0x1ED2010")]
	private void OnGameSettingClick()
	{
	}

	[Token(Token = "0x600DCBC")]
	[Address(RVA = "0x1ED2494", Offset = "0x1ED2494", VA = "0x1ED2494")]
	private void OnOBSettingClick()
	{
	}

	[Token(Token = "0x600DCBD")]
	[Address(RVA = "0x1ED2738", Offset = "0x1ED2738", VA = "0x1ED2738")]
	private void OnCSAdSettingClick()
	{
	}

	[Token(Token = "0x600DCBE")]
	[Address(RVA = "0x1ED1D88", Offset = "0x1ED1D88", VA = "0x1ED1D88")]
	private void ShowUnAvaliblePanelIfNeeded()
	{
	}

	[Token(Token = "0x600DCBF")]
	[Address(RVA = "0x1ED2A20", Offset = "0x1ED2A20", VA = "0x1ED2A20")]
	private UIToggleButton GetGroupModeToggleBtn(uint groupMode)
	{
		return null;
	}

	[Token(Token = "0x600DCC0")]
	[Address(RVA = "0x1ED01CC", Offset = "0x1ED01CC", VA = "0x1ED01CC")]
	protected void SetFirstValidGroupMode()
	{
	}

	[Token(Token = "0x600DCC1")]
	[Address(RVA = "0x1ED1650", Offset = "0x1ED1650", VA = "0x1ED1650")]
	protected void SetValidMenuData()
	{
	}

	[Token(Token = "0x600DCC2")]
	[Address(RVA = "0x1ED2B40", Offset = "0x1ED2B40", VA = "0x1ED2B40")]
	private void RefreshGameSettingInfo()
	{
	}

	[Token(Token = "0x600DCC3")]
	[Address(RVA = "0x1EC9884", Offset = "0x1EC9884", VA = "0x1EC9884")]
	protected void RefreshGameDropInfo(bool selectDefault = true)
	{
	}

	[Token(Token = "0x600DCC4")]
	[Address(RVA = "0x1ECFB10", Offset = "0x1ECFB10", VA = "0x1ECFB10")]
	protected void RepositionAllSettings()
	{
	}

	[Token(Token = "0x600DCC5")]
	[Address(RVA = "0x1ECFDE0", Offset = "0x1ECFDE0", VA = "0x1ECFDE0")]
	protected void SetGameModeSpecificUI()
	{
	}

	[Token(Token = "0x600DCC6")]
	[Address(RVA = "0x1ED3218", Offset = "0x1ED3218", VA = "0x1ED3218")]
	private void UpdateBtnGrid()
	{
	}

	[Token(Token = "0x600DCC7")]
	[Address(RVA = "0x1ED3720", Offset = "0x1ED3720", VA = "0x1ED3720")]
	private List<PopMenuData> GenerateMembersMenuData()
	{
		return null;
	}

	[Token(Token = "0x600DCC8")]
	[Address(RVA = "0x1ED3A54", Offset = "0x1ED3A54", VA = "0x1ED3A54")]
	private void OnMemberSelected(object obj)
	{
	}

	[Token(Token = "0x600DCC9")]
	[Address(RVA = "0x1ED3D1C", Offset = "0x1ED3D1C", VA = "0x1ED3D1C")]
	private List<PopMenuData> GenerateSpectatorsMenuData()
	{
		return null;
	}

	[Token(Token = "0x600DCCA")]
	[Address(RVA = "0x1ED4050", Offset = "0x1ED4050", VA = "0x1ED4050")]
	private void OnSpectatorSelected(object obj)
	{
	}

	[Token(Token = "0x600DCCB")]
	[Address(RVA = "0x1ED42E0", Offset = "0x1ED42E0", VA = "0x1ED42E0")]
	private List<PopMenuData> GenerateHPMenuData()
	{
		return null;
	}

	[Token(Token = "0x600DCCC")]
	[Address(RVA = "0x1ED4648", Offset = "0x1ED4648", VA = "0x1ED4648")]
	private void OnHPSelected(object obj)
	{
	}

	[Token(Token = "0x600DCCD")]
	[Address(RVA = "0x1ED4808", Offset = "0x1ED4808", VA = "0x1ED4808")]
	private List<PopMenuData> GenerateEPMenuData()
	{
		return null;
	}

	[Token(Token = "0x600DCCE")]
	[Address(RVA = "0x1ED4B70", Offset = "0x1ED4B70", VA = "0x1ED4B70")]
	private void OnEPSelected(object obj)
	{
	}

	[Token(Token = "0x600DCCF")]
	[Address(RVA = "0x1ED4D30", Offset = "0x1ED4D30", VA = "0x1ED4D30")]
	private List<PopMenuData> GenerateSpeedMenuData()
	{
		return null;
	}

	[Token(Token = "0x600DCD0")]
	[Address(RVA = "0x1ED5098", Offset = "0x1ED5098", VA = "0x1ED5098")]
	private void OnSpeedSelected(object obj)
	{
	}

	[Token(Token = "0x600DCD1")]
	[Address(RVA = "0x1ED5258", Offset = "0x1ED5258", VA = "0x1ED5258")]
	private List<PopMenuData> GenerateJumpHeightMenuData()
	{
		return null;
	}

	[Token(Token = "0x600DCD2")]
	[Address(RVA = "0x1ED55C0", Offset = "0x1ED55C0", VA = "0x1ED55C0")]
	private void OnJumpHeightSelected(object obj)
	{
	}

	[Token(Token = "0x600DCD3")]
	[Address(RVA = "0x1ED5780", Offset = "0x1ED5780", VA = "0x1ED5780")]
	private List<PopMenuData> GenerateReviveMenuData()
	{
		return null;
	}

	[Token(Token = "0x600DCD4")]
	[Address(RVA = "0x1ED5B3C", Offset = "0x1ED5B3C", VA = "0x1ED5B3C")]
	private void OnReviveSelected(object data)
	{
	}

	[Token(Token = "0x600DCD5")]
	[Address(RVA = "0x1ED5D50", Offset = "0x1ED5D50", VA = "0x1ED5D50")]
	private List<PopMenuData> GenerateMatchStartBuffData()
	{
		return null;
	}

	[Token(Token = "0x600DCD6")]
	[Address(RVA = "0x1ED610C", Offset = "0x1ED610C", VA = "0x1ED610C")]
	private void OnMatchStartBuffDSelected(object data)
	{
	}

	[Token(Token = "0x600DCD7")]
	[Address(RVA = "0x1ED6168", Offset = "0x1ED6168", VA = "0x1ED6168")]
	private void InitAutoRevivalSetStates(DropListConfigInfo info)
	{
	}

	[Token(Token = "0x600DCD8")]
	[Address(RVA = "0x1ED5CFC", Offset = "0x1ED5CFC", VA = "0x1ED5CFC")]
	public void AutoRevivalSetStates()
	{
	}

	[Token(Token = "0x600DCD9")]
	[Address(RVA = "0x1ED35D0", Offset = "0x1ED35D0", VA = "0x1ED35D0")]
	public void RefreshADCSRelatedInfo(object[] data)
	{
	}

	[Token(Token = "0x600DCDA")]
	[Address(RVA = "0x1ED61C4", Offset = "0x1ED61C4", VA = "0x1ED61C4")]
	private List<PopMenuData> GenerateFightClubRoundNumMenuData()
	{
		return null;
	}

	[Token(Token = "0x600DCDB")]
	[Address(RVA = "0x1ED652C", Offset = "0x1ED652C", VA = "0x1ED652C")]
	private void OnFightClubRoundNumSelected(object obj)
	{
	}

	[Token(Token = "0x600DCDC")]
	[Address(RVA = "0x1ED66EC", Offset = "0x1ED66EC", VA = "0x1ED66EC")]
	private List<PopMenuData> GenerateRoundNumMenuData()
	{
		return null;
	}

	[Token(Token = "0x600DCDD")]
	[Address(RVA = "0x1ED6A54", Offset = "0x1ED6A54", VA = "0x1ED6A54")]
	private void OnRoundNumSelected(object obj)
	{
	}

	[Token(Token = "0x600DCDE")]
	[Address(RVA = "0x1ED6C14", Offset = "0x1ED6C14", VA = "0x1ED6C14")]
	private List<PopMenuData> GenerateInitCoinMenuData()
	{
		return null;
	}

	[Token(Token = "0x600DCDF")]
	[Address(RVA = "0x1ED6F7C", Offset = "0x1ED6F7C", VA = "0x1ED6F7C")]
	private void OnInitCoinSelected(object obj)
	{
	}

	[Token(Token = "0x600DCE0")]
	[Address(RVA = "0x1ED713C", Offset = "0x1ED713C", VA = "0x1ED713C")]
	protected void GenerateGameModeMenuData()
	{
	}

	[Token(Token = "0x600DCE1")]
	[Address(RVA = "0x1ECA600", Offset = "0x1ECA600", VA = "0x1ECA600")]
	protected void RefreshHelpBtn()
	{
	}

	[Token(Token = "0x600DCE2")]
	[Address(RVA = "0x1ED75C4", Offset = "0x1ED75C4", VA = "0x1ED75C4")]
	protected void OnModeSelected(object obj)
	{
	}

	[Token(Token = "0x600DCE3")]
	[Address(RVA = "0x1ECF4D4", Offset = "0x1ECF4D4", VA = "0x1ECF4D4")]
	protected void RefreshMapGridView()
	{
	}

	[Token(Token = "0x600DCE4")]
	[Address(RVA = "0x1ED7DD8", Offset = "0x1ED7DD8", VA = "0x1ED7DD8")]
	protected void UpdateRoomMapItemDownloadStatus(uint mapID, uint gameMode, UICreateRoomMapItem item)
	{
	}

	[Token(Token = "0x600DCE5")]
	[Address(RVA = "0x1ED8200", Offset = "0x1ED8200", VA = "0x1ED8200")]
	private void OnMapDownloadClick(uint configID, string mapName)
	{
	}

	[Token(Token = "0x600DCE6")]
	[Address(RVA = "0x1ED864C", Offset = "0x1ED864C", VA = "0x1ED864C")]
	protected void OnMapToggleSelect(uint configID)
	{
	}

	[Token(Token = "0x600DCE7")]
	[Address(RVA = "0x1ED870C", Offset = "0x1ED870C", VA = "0x1ED870C")]
	protected void OnMapItemClick()
	{
	}

	[Token(Token = "0x600DCE8")]
	[Address(RVA = "0x1ED86B8", Offset = "0x1ED86B8", VA = "0x1ED86B8")]
	private void ProcessWeatherOnMapSelected()
	{
	}

	[Token(Token = "0x600DCE9")]
	[Address(RVA = "0x1ED7C60", Offset = "0x1ED7C60", VA = "0x1ED7C60")]
	protected uint SetFirstValidMapByMode(uint modeId)
	{
		return default(uint);
	}

	[Token(Token = "0x600DCEA")]
	[Address(RVA = "0x1ED8760", Offset = "0x1ED8760", VA = "0x1ED8760")]
	protected void SelectDropListItem(uint drop, bool isInit)
	{
	}

	[Token(Token = "0x600DCEB")]
	[Address(RVA = "0x1ED8ACC", Offset = "0x1ED8ACC", VA = "0x1ED8ACC")]
	protected void OnDropListItemSelected(object[] param)
	{
	}

	[Token(Token = "0x600DCEC")]
	[Address(RVA = "0x1ED8F78", Offset = "0x1ED8F78", VA = "0x1ED8F78")]
	protected void InitOtherSettingsByDrop(DropListConfigInfo info)
	{
	}

	[Token(Token = "0x600DCED")]
	[Address(RVA = "0x1ED9224", Offset = "0x1ED9224", VA = "0x1ED9224")]
	protected void OnBtnConfirm()
	{
	}

	[Token(Token = "0x600DCEE")]
	[Address(RVA = "0x1EDB04C", Offset = "0x1EDB04C", VA = "0x1EDB04C")]
	private void OnHelpBtnCLick()
	{
	}

	[Token(Token = "0x600DCEF")]
	[Address(RVA = "0x1EDAA70", Offset = "0x1EDAA70", VA = "0x1EDAA70")]
	private void ShowNormalConfirmPop()
	{
	}

	[Token(Token = "0x600DCF0")]
	[Address(RVA = "0x1EDB1BC", Offset = "0x1EDB1BC", VA = "0x1EDB1BC")]
	private void CloseUI(object[] data)
	{
	}

	[Token(Token = "0x600DCF1")]
	[Address(RVA = "0x1EDB228", Offset = "0x1EDB228", VA = "0x1EDB228")]
	private void OnBtnClose()
	{
	}

	[Token(Token = "0x600DCF2")]
	[Address(RVA = "0x1EDB28C", Offset = "0x1EDB28C", VA = "0x1EDB28C")]
	private void OnBtnReset()
	{
	}

	[Token(Token = "0x600DCF3")]
	[Address(RVA = "0x1ECE020", Offset = "0x1ECE020", VA = "0x1ECE020")]
	private bool IsRoomSettingsTrue(ECustomRoomSetting setting)
	{
		return default(bool);
	}

	[Token(Token = "0x600DCF4")]
	[Address(RVA = "0x1ECE100", Offset = "0x1ECE100", VA = "0x1ECE100")]
	private void SetRoomSetting(ECustomRoomSetting setting, bool value)
	{
	}

	[Token(Token = "0x600DCF5")]
	[Address(RVA = "0x1EDB4B0", Offset = "0x1EDB4B0", VA = "0x1EDB4B0")]
	private void SetRoomSetting(uint setting, bool value)
	{
	}

	[Token(Token = "0x600DCF6")]
	[Address(RVA = "0x1EDB548", Offset = "0x1EDB548", VA = "0x1EDB548")]
	private bool IsRoomSettingsTrue(uint setting)
	{
		return default(bool);
	}

	[Token(Token = "0x600DCF7")]
	[Address(RVA = "0x1ED30E8", Offset = "0x1ED30E8", VA = "0x1ED30E8")]
	protected void SetRoomSettingValue(ECustomRoomSetting start, ECustomRoomSetting end, uint value)
	{
	}

	[Token(Token = "0x600DCF8")]
	[Address(RVA = "0x1EDB5B8", Offset = "0x1EDB5B8", VA = "0x1EDB5B8")]
	protected uint GetRoomSettingValue(ECustomRoomSetting start, ECustomRoomSetting end)
	{
		return default(uint);
	}

	[Token(Token = "0x600DCF9")]
	[Address(RVA = "0x1ECE090", Offset = "0x1ECE090", VA = "0x1ECE090")]
	private bool IsRoomSettings2True(ECustomRoomSetting2 setting)
	{
		return default(bool);
	}

	[Token(Token = "0x600DCFA")]
	[Address(RVA = "0x1ECE198", Offset = "0x1ECE198", VA = "0x1ECE198")]
	private void SetRoomSetting2(ECustomRoomSetting2 setting, bool value)
	{
	}

	[Token(Token = "0x600DCFB")]
	[Address(RVA = "0x1EDB660", Offset = "0x1EDB660", VA = "0x1EDB660")]
	private void SetRoomSetting2(uint setting, bool value)
	{
	}

	[Token(Token = "0x600DCFC")]
	[Address(RVA = "0x1EDB6F8", Offset = "0x1EDB6F8", VA = "0x1EDB6F8")]
	private bool IsRoomSettings2True(uint setting)
	{
		return default(bool);
	}

	[Token(Token = "0x600DCFD")]
	[Address(RVA = "0x1ED00B0", Offset = "0x1ED00B0", VA = "0x1ED00B0")]
	private void SetInGameChatEnableOnRoomTypeChange()
	{
	}

	[Token(Token = "0x600DCFE")]
	[Address(RVA = "0x1EDB768", Offset = "0x1EDB768", VA = "0x1EDB768")]
	protected uint GetPosByRoomSetting2Value(ECustomRoomSetting2 value)
	{
		return default(uint);
	}

	[Token(Token = "0x600DCFF")]
	[Address(RVA = "0x1EDB7E4", Offset = "0x1EDB7E4", VA = "0x1EDB7E4")]
	protected void SetRoomSetting2ByPos(uint bitPos, bool isAdd)
	{
	}

	[Token(Token = "0x600DD00")]
	[Address(RVA = "0x1ED3180", Offset = "0x1ED3180", VA = "0x1ED3180")]
	protected void SetRoomSetting2Value(ECustomRoomSetting2 start, ECustomRoomSetting2 end, uint value)
	{
	}

	[Token(Token = "0x600DD01")]
	[Address(RVA = "0x1EDB87C", Offset = "0x1EDB87C", VA = "0x1EDB87C")]
	protected uint GetRoomSetting2Value(ECustomRoomSetting2 start, ECustomRoomSetting2 end)
	{
		return default(uint);
	}

	[Token(Token = "0x600DD02")]
	[Address(RVA = "0x1EDB924", Offset = "0x1EDB924", VA = "0x1EDB924", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600DD03")]
	[Address(RVA = "0x1EDBA1C", Offset = "0x1EDBA1C", VA = "0x1EDBA1C", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600DD04")]
	[Address(RVA = "0x1EDBAD4", Offset = "0x1EDBAD4", VA = "0x1EDBAD4")]
	private void _003CInitToggleBtns_003Em__0()
	{
	}

	[Token(Token = "0x600DD05")]
	[Address(RVA = "0x1EDBAE0", Offset = "0x1EDBAE0", VA = "0x1EDBAE0")]
	private void _003CInitToggleBtns_003Em__1()
	{
	}

	[Token(Token = "0x600DD06")]
	[Address(RVA = "0x1EDBAEC", Offset = "0x1EDBAEC", VA = "0x1EDBAEC")]
	private void _003CInitToggleBtns_003Em__2()
	{
	}

	[Token(Token = "0x600DD07")]
	[Address(RVA = "0x1EDBAF8", Offset = "0x1EDBAF8", VA = "0x1EDBAF8")]
	private void _003CInitToggleBtns_003Em__3()
	{
	}

	[Token(Token = "0x600DD08")]
	[Address(RVA = "0x1EDBB04", Offset = "0x1EDBB04", VA = "0x1EDBB04")]
	private void _003CInitToggleBtns_003Em__4()
	{
	}

	[Token(Token = "0x600DD09")]
	[Address(RVA = "0x1EDBB10", Offset = "0x1EDBB10", VA = "0x1EDBB10")]
	private void _003CInitToggleBtns_003Em__5()
	{
	}

	[Token(Token = "0x600DD0A")]
	[Address(RVA = "0x1EDBB1C", Offset = "0x1EDBB1C", VA = "0x1EDBB1C")]
	private void _003CInitToggleBtns_003Em__6()
	{
	}

	[Token(Token = "0x600DD0B")]
	[Address(RVA = "0x1EDBB28", Offset = "0x1EDBB28", VA = "0x1EDBB28")]
	private void _003CInitToggleBtns_003Em__7()
	{
	}

	[Token(Token = "0x600DD0C")]
	[Address(RVA = "0x1EDBB34", Offset = "0x1EDBB34", VA = "0x1EDBB34")]
	private void _003CInitToggleBtns_003Em__8()
	{
	}

	[Token(Token = "0x600DD0D")]
	[Address(RVA = "0x1EDBB40", Offset = "0x1EDBB40", VA = "0x1EDBB40")]
	private void _003CInitToggleBtns_003Em__9()
	{
	}

	[Token(Token = "0x600DD0E")]
	[Address(RVA = "0x1EDBB4C", Offset = "0x1EDBB4C", VA = "0x1EDBB4C")]
	private void _003CInitToggleBtns_003Em__A()
	{
	}

	[Token(Token = "0x600DD0F")]
	[Address(RVA = "0x1EDBB58", Offset = "0x1EDBB58", VA = "0x1EDBB58")]
	private void _003CInitToggleBtns_003Em__B()
	{
	}

	[Token(Token = "0x600DD10")]
	[Address(RVA = "0x1EDBB64", Offset = "0x1EDBB64", VA = "0x1EDBB64")]
	private void _003CInitToggleBtns_003Em__C()
	{
	}

	[Token(Token = "0x600DD11")]
	[Address(RVA = "0x1EDBB70", Offset = "0x1EDBB70", VA = "0x1EDBB70")]
	private void _003CInitToggleBtns_003Em__D()
	{
	}

	[Token(Token = "0x600DD12")]
	[Address(RVA = "0x1EDBB7C", Offset = "0x1EDBB7C", VA = "0x1EDBB7C")]
	private void _003CInitToggleBtns_003Em__E()
	{
	}

	[Token(Token = "0x600DD13")]
	[Address(RVA = "0x1EDBB88", Offset = "0x1EDBB88", VA = "0x1EDBB88")]
	private void _003CInitToggleBtns_003Em__F()
	{
	}

	[Token(Token = "0x600DD14")]
	[Address(RVA = "0x1EDBB94", Offset = "0x1EDBB94", VA = "0x1EDBB94")]
	private void _003CInitToggleBtns_003Em__10()
	{
	}

	[Token(Token = "0x600DD15")]
	[Address(RVA = "0x1EDBBA0", Offset = "0x1EDBBA0", VA = "0x1EDBBA0")]
	private void _003CInitToggleBtns_003Em__11()
	{
	}

	[Token(Token = "0x600DD16")]
	[Address(RVA = "0x1EDBBAC", Offset = "0x1EDBBAC", VA = "0x1EDBBAC")]
	private void _003CInitToggleBtns_003Em__12()
	{
	}

	[Token(Token = "0x600DD17")]
	[Address(RVA = "0x1EDBBB8", Offset = "0x1EDBBB8", VA = "0x1EDBBB8")]
	private void _003CInitToggleBtns_003Em__13()
	{
	}

	[Token(Token = "0x600DD18")]
	[Address(RVA = "0x1EDBBC4", Offset = "0x1EDBBC4", VA = "0x1EDBBC4")]
	private void _003CInitToggleBtns_003Em__14()
	{
	}

	[Token(Token = "0x600DD19")]
	[Address(RVA = "0x1EDBBD0", Offset = "0x1EDBBD0", VA = "0x1EDBBD0")]
	private void _003CInitToggleBtns_003Em__15()
	{
	}

	[Token(Token = "0x600DD1A")]
	[Address(RVA = "0x1EDBBDC", Offset = "0x1EDBBDC", VA = "0x1EDBBDC")]
	private void _003CInitToggleBtns_003Em__16()
	{
	}

	[Token(Token = "0x600DD1B")]
	[Address(RVA = "0x1EDBBE8", Offset = "0x1EDBBE8", VA = "0x1EDBBE8")]
	private void _003CInitToggleBtns_003Em__17()
	{
	}

	[Token(Token = "0x600DD1C")]
	[Address(RVA = "0x1EDBBF4", Offset = "0x1EDBBF4", VA = "0x1EDBBF4")]
	private void _003CInitToggleBtns_003Em__18()
	{
	}

	[Token(Token = "0x600DD1D")]
	[Address(RVA = "0x1EDBC00", Offset = "0x1EDBC00", VA = "0x1EDBC00")]
	private void _003CInitToggleBtns_003Em__19()
	{
	}

	[Token(Token = "0x600DD1E")]
	[Address(RVA = "0x1EDBC0C", Offset = "0x1EDBC0C", VA = "0x1EDBC0C")]
	private void _003CInitToggleBtns_003Em__1A()
	{
	}

	[Token(Token = "0x600DD1F")]
	[Address(RVA = "0x1EDBC18", Offset = "0x1EDBC18", VA = "0x1EDBC18")]
	private void _003CInitToggleBtns_003Em__1B()
	{
	}

	[Token(Token = "0x600DD20")]
	[Address(RVA = "0x1EDBC24", Offset = "0x1EDBC24", VA = "0x1EDBC24")]
	private void _003CInitToggleBtns_003Em__1C()
	{
	}

	[Token(Token = "0x600DD21")]
	[Address(RVA = "0x1EDBC30", Offset = "0x1EDBC30", VA = "0x1EDBC30")]
	private void _003CInitToggleBtns_003Em__1D()
	{
	}

	[Token(Token = "0x600DD22")]
	[Address(RVA = "0x1EDBC3C", Offset = "0x1EDBC3C", VA = "0x1EDBC3C")]
	private void _003CInitToggleBtns_003Em__1E()
	{
	}

	[Token(Token = "0x600DD23")]
	[Address(RVA = "0x1EDBC48", Offset = "0x1EDBC48", VA = "0x1EDBC48")]
	private void _003CInitToggleBtns_003Em__1F()
	{
	}

	[Token(Token = "0x600DD24")]
	[Address(RVA = "0x1EDBC54", Offset = "0x1EDBC54", VA = "0x1EDBC54")]
	private void _003CInitToggleBtns_003Em__20()
	{
	}

	[Token(Token = "0x600DD25")]
	[Address(RVA = "0x1EDBC60", Offset = "0x1EDBC60", VA = "0x1EDBC60")]
	private void _003CInitToggleBtns_003Em__21()
	{
	}

	[Token(Token = "0x600DD26")]
	[Address(RVA = "0x1EDBC6C", Offset = "0x1EDBC6C", VA = "0x1EDBC6C")]
	private void _003CInitToggleBtns_003Em__22()
	{
	}

	[Token(Token = "0x600DD27")]
	[Address(RVA = "0x1EDBC78", Offset = "0x1EDBC78", VA = "0x1EDBC78")]
	private void _003CInitToggleBtns_003Em__23()
	{
	}

	[Token(Token = "0x600DD28")]
	[Address(RVA = "0x1EDBC84", Offset = "0x1EDBC84", VA = "0x1EDBC84")]
	private void _003CInitToggleBtns_003Em__24()
	{
	}

	[Token(Token = "0x600DD29")]
	[Address(RVA = "0x1EDBC90", Offset = "0x1EDBC90", VA = "0x1EDBC90")]
	private void _003CInitToggleBtns_003Em__25()
	{
	}

	[Token(Token = "0x600DD2A")]
	[Address(RVA = "0x1EDBC9C", Offset = "0x1EDBC9C", VA = "0x1EDBC9C")]
	private void _003CInitToggleBtns_003Em__26()
	{
	}

	[Token(Token = "0x600DD2B")]
	[Address(RVA = "0x1EDBCA8", Offset = "0x1EDBCA8", VA = "0x1EDBCA8")]
	private void _003CInitToggleBtns_003Em__27()
	{
	}

	[Token(Token = "0x600DD2C")]
	[Address(RVA = "0x1EDBCB4", Offset = "0x1EDBCB4", VA = "0x1EDBCB4")]
	private void _003CInitToggleBtns_003Em__28()
	{
	}

	[Token(Token = "0x600DD2D")]
	[Address(RVA = "0x1EDBCC0", Offset = "0x1EDBCC0", VA = "0x1EDBCC0")]
	private void _003CInitToggleBtns_003Em__29()
	{
	}

	[Token(Token = "0x600DD2E")]
	[Address(RVA = "0x1EDBCCC", Offset = "0x1EDBCCC", VA = "0x1EDBCCC")]
	private void _003CInitToggleBtns_003Em__2A()
	{
	}

	[Token(Token = "0x600DD2F")]
	[Address(RVA = "0x1EDBCD8", Offset = "0x1EDBCD8", VA = "0x1EDBCD8")]
	private void _003CInitToggleBtns_003Em__2B()
	{
	}

	[Token(Token = "0x600DD30")]
	[Address(RVA = "0x1EDBCE4", Offset = "0x1EDBCE4", VA = "0x1EDBCE4")]
	private void _003CInitToggleBtns_003Em__2C()
	{
	}

	[Token(Token = "0x600DD31")]
	[Address(RVA = "0x1EDBCF0", Offset = "0x1EDBCF0", VA = "0x1EDBCF0")]
	private void _003CInitToggleBtns_003Em__2D()
	{
	}

	[Token(Token = "0x600DD32")]
	[Address(RVA = "0x1EDBCFC", Offset = "0x1EDBCFC", VA = "0x1EDBCFC")]
	private void _003CInitToggleBtns_003Em__2E()
	{
	}

	[Token(Token = "0x600DD33")]
	[Address(RVA = "0x1EDBD08", Offset = "0x1EDBD08", VA = "0x1EDBD08")]
	private void _003CInitToggleBtns_003Em__2F()
	{
	}

	[Token(Token = "0x600DD34")]
	[Address(RVA = "0x1EDBD14", Offset = "0x1EDBD14", VA = "0x1EDBD14")]
	private void _003CInitToggleBtns_003Em__30()
	{
	}

	[Token(Token = "0x600DD35")]
	[Address(RVA = "0x1EDBD20", Offset = "0x1EDBD20", VA = "0x1EDBD20")]
	private void _003CInitToggleBtns_003Em__31()
	{
	}

	[Token(Token = "0x600DD36")]
	[Address(RVA = "0x1EDBD2C", Offset = "0x1EDBD2C", VA = "0x1EDBD2C")]
	private void _003CInitToggleBtns_003Em__32()
	{
	}

	[Token(Token = "0x600DD37")]
	[Address(RVA = "0x1EDBD38", Offset = "0x1EDBD38", VA = "0x1EDBD38")]
	private void _003CInitToggleBtns_003Em__33()
	{
	}

	[Token(Token = "0x600DD38")]
	[Address(RVA = "0x1EDBD44", Offset = "0x1EDBD44", VA = "0x1EDBD44")]
	private void _003CInitToggleBtns_003Em__34()
	{
	}

	[Token(Token = "0x600DD39")]
	[Address(RVA = "0x1EDBD50", Offset = "0x1EDBD50", VA = "0x1EDBD50")]
	private void _003CInitToggleBtns_003Em__35()
	{
	}

	[Token(Token = "0x600DD3A")]
	[Address(RVA = "0x1EDBD5C", Offset = "0x1EDBD5C", VA = "0x1EDBD5C")]
	private static int _003CRefreshGameDropInfo_003Em__36(DropListConfigInfo a, DropListConfigInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x600DD3B")]
	[Address(RVA = "0x1EDBDC8", Offset = "0x1EDBDC8", VA = "0x1EDBDC8")]
	private static int _003CRefreshGameDropInfo_003Em__37(DropListConfigInfo a, DropListConfigInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x600DD3C")]
	[Address(RVA = "0x1EDBE34", Offset = "0x1EDBE34", VA = "0x1EDBE34")]
	private static int _003CRefreshGameDropInfo_003Em__38(DropListConfigInfo a, DropListConfigInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x600DD3D")]
	[Address(RVA = "0x1EDBE7C", Offset = "0x1EDBE7C", VA = "0x1EDBE7C")]
	private bool _003CRefreshGameDropInfo_003Em__39(StandardTabItemViewData t)
	{
		return default(bool);
	}

	[Token(Token = "0x600DD3E")]
	[Address(RVA = "0x1EDBF28", Offset = "0x1EDBF28", VA = "0x1EDBF28")]
	private static bool _003CRefreshGameDropInfo_003Em__3A(DropListConfigInfo a)
	{
		return default(bool);
	}

	[Token(Token = "0x600DD3F")]
	[Address(RVA = "0x1EDBF58", Offset = "0x1EDBF58", VA = "0x1EDBF58")]
	private static void _003COnBtnConfirm_003Em__3B(string s)
	{
	}

	[Token(Token = "0x600DD40")]
	[Address(RVA = "0x1EDC1A0", Offset = "0x1EDC1A0", VA = "0x1EDC1A0")]
	private void _003COnBtnConfirm_003Em__3C()
	{
	}

	[Token(Token = "0x600DD41")]
	[Address(RVA = "0x1EDC1A4", Offset = "0x1EDC1A4", VA = "0x1EDC1A4")]
	private void _003CShowNormalConfirmPop_003Em__3D()
	{
	}

	[Token(Token = "0x600DD42")]
	[Address(RVA = "0x1EDC7C8", Offset = "0x1EDC7C8", VA = "0x1EDC7C8")]
	private void _003COnBtnReset_003Em__3E()
	{
	}

	[Token(Token = "0x600DD43")]
	[Address(RVA = "0x1EDC8E8", Offset = "0x1EDC8E8", VA = "0x1EDC8E8")]
	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	[Token(Token = "0x600DD44")]
	[Address(RVA = "0x1EDC8F0", Offset = "0x1EDC8F0", VA = "0x1EDC8F0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DD45")]
	[Address(RVA = "0x1EDC8F8", Offset = "0x1EDC8F8", VA = "0x1EDC8F8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600DD46")]
	[Address(RVA = "0x1EDC900", Offset = "0x1EDC900", VA = "0x1EDC900")]
	public void _003C_003EiFixBaseProxy_OnInitDepth()
	{
	}
}
