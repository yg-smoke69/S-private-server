using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;
using tcp;

namespace COW;

[Token(Token = "0x2002936")]
public class UILobbyNewRightBottomController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002937")]
	private sealed class _003CCloseGroupModePanel_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400FE2A")]
		[FieldOffset(Offset = "0x8")]
		internal float seconds;

		[Token(Token = "0x400FE2B")]
		[FieldOffset(Offset = "0xC")]
		internal UILobbyNewRightBottomController _0024this;

		[Token(Token = "0x400FE2C")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400FE2D")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400FE2E")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x17001246")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6010756")]
			[Address(RVA = "0x1CA2484", Offset = "0x1CA2484", VA = "0x1CA2484", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001247")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6010757")]
			[Address(RVA = "0x1CA248C", Offset = "0x1CA248C", VA = "0x1CA248C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6010754")]
		[Address(RVA = "0x1CA2368", Offset = "0x1CA2368", VA = "0x1CA2368")]
		public _003CCloseGroupModePanel_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6010755")]
		[Address(RVA = "0x1CA2370", Offset = "0x1CA2370", VA = "0x1CA2370", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6010758")]
		[Address(RVA = "0x1CA2494", Offset = "0x1CA2494", VA = "0x1CA2494", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6010759")]
		[Address(RVA = "0x1CA24A8", Offset = "0x1CA24A8", VA = "0x1CA24A8", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002938")]
	private sealed class _003CCloseMapModePanel_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400FE2F")]
		[FieldOffset(Offset = "0x8")]
		internal float seconds;

		[Token(Token = "0x400FE30")]
		[FieldOffset(Offset = "0xC")]
		internal UILobbyNewRightBottomController _0024this;

		[Token(Token = "0x400FE31")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400FE32")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400FE33")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x17001248")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x601075C")]
			[Address(RVA = "0x1CA264C", Offset = "0x1CA264C", VA = "0x1CA264C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001249")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601075D")]
			[Address(RVA = "0x1CA2654", Offset = "0x1CA2654", VA = "0x1CA2654", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x601075A")]
		[Address(RVA = "0x1CA2530", Offset = "0x1CA2530", VA = "0x1CA2530")]
		public _003CCloseMapModePanel_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x601075B")]
		[Address(RVA = "0x1CA2538", Offset = "0x1CA2538", VA = "0x1CA2538", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601075E")]
		[Address(RVA = "0x1CA265C", Offset = "0x1CA265C", VA = "0x1CA265C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601075F")]
		[Address(RVA = "0x1CA2670", Offset = "0x1CA2670", VA = "0x1CA2670", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002939")]
	private sealed class _003CRefreshBonusEventInfo_003Ec__AnonStorey2
	{
		[Token(Token = "0x400FE34")]
		[FieldOffset(Offset = "0x8")]
		internal MapModeData mapModeData;

		[Token(Token = "0x400FE35")]
		[FieldOffset(Offset = "0xC")]
		internal HHDIPHFOBFO groupMode;

		[Token(Token = "0x400FE36")]
		[FieldOffset(Offset = "0x10")]
		internal UILobbyNewRightBottomController _0024this;

		[Token(Token = "0x6010760")]
		[Address(RVA = "0x1CA2728", Offset = "0x1CA2728", VA = "0x1CA2728")]
		public _003CRefreshBonusEventInfo_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6010761")]
		[Address(RVA = "0x1CA2730", Offset = "0x1CA2730", VA = "0x1CA2730")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x200293A")]
	private sealed class _003CCheckPlayerLimitsAndAutoSelectGroupMode_003Ec__AnonStorey4
	{
		[Token(Token = "0x400FE37")]
		[FieldOffset(Offset = "0x8")]
		internal MapModeData cachedMap;

		[Token(Token = "0x400FE38")]
		[FieldOffset(Offset = "0xC")]
		internal UILobbyNewRightBottomController _0024this;

		[Token(Token = "0x6010762")]
		[Address(RVA = "0x1CA2360", Offset = "0x1CA2360", VA = "0x1CA2360")]
		public _003CCheckPlayerLimitsAndAutoSelectGroupMode_003Ec__AnonStorey4()
		{
		}
	}

	[Token(Token = "0x200293B")]
	private sealed class _003CCheckPlayerLimitsAndAutoSelectGroupMode_003Ec__AnonStorey3
	{
		[Token(Token = "0x400FE39")]
		[FieldOffset(Offset = "0x8")]
		internal List<uint> playerLimitList;

		[Token(Token = "0x400FE3A")]
		[FieldOffset(Offset = "0xC")]
		internal _003CCheckPlayerLimitsAndAutoSelectGroupMode_003Ec__AnonStorey4 _003C_003Ef__ref_00244;

		[Token(Token = "0x6010763")]
		[Address(RVA = "0x1CA1D30", Offset = "0x1CA1D30", VA = "0x1CA1D30")]
		public _003CCheckPlayerLimitsAndAutoSelectGroupMode_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6010764")]
		[Address(RVA = "0x1CA1D38", Offset = "0x1CA1D38", VA = "0x1CA1D38")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x200293C")]
	private sealed class _003CRefreshOptionalMapResDownloader_003Ec__AnonStorey5
	{
		[Token(Token = "0x400FE3B")]
		[FieldOffset(Offset = "0x8")]
		internal ResDownloadType resType;

		[Token(Token = "0x400FE3C")]
		[FieldOffset(Offset = "0xC")]
		internal UILobbyNewRightBottomController _0024this;

		[Token(Token = "0x6010765")]
		[Address(RVA = "0x1CA2768", Offset = "0x1CA2768", VA = "0x1CA2768")]
		public _003CRefreshOptionalMapResDownloader_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6010766")]
		[Address(RVA = "0x1CA2770", Offset = "0x1CA2770", VA = "0x1CA2770")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x200293D")]
	private sealed class _003CGetAlternativePeriodicMapData_003Ec__AnonStorey6
	{
		[Token(Token = "0x400FE3D")]
		[FieldOffset(Offset = "0x8")]
		internal uint mapID;

		[Token(Token = "0x6010767")]
		[Address(RVA = "0x1CA26F8", Offset = "0x1CA26F8", VA = "0x1CA26F8")]
		public _003CGetAlternativePeriodicMapData_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x6010768")]
		[Address(RVA = "0x1CA2700", Offset = "0x1CA2700", VA = "0x1CA2700")]
		internal bool _003C_003Em__0(uint t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400FE06")]
	[FieldOffset(Offset = "0x28")]
	private UILobbyNewRightBottomView m_View;

	[Token(Token = "0x400FE07")]
	private const string TEAM_MODE_TIPS = "team_mode_tips";

	[Token(Token = "0x400FE08")]
	private const string MAP_MODE_TIPS = "map_mode_tips";

	[Token(Token = "0x400FE09")]
	private const string MAP_MODE_WTA_TIPS = "map_mode_wta_tips";

	[Token(Token = "0x400FE0A")]
	public const string GAME_MODE_WEB_TUTORIAL = "game_mode_web_tutorial";

	[Token(Token = "0x400FE0B")]
	[FieldOffset(Offset = "0x2C")]
	public MapModeData m_SelectedMapData;

	[Token(Token = "0x400FE0C")]
	[FieldOffset(Offset = "0x30")]
	private bool m_RetryMapData;

	[Token(Token = "0x400FE0D")]
	[FieldOffset(Offset = "0x34")]
	private uint m_StartGameCoolDownResumeDelayID;

	[Token(Token = "0x400FE0E")]
	[FieldOffset(Offset = "0x38")]
	private uint m_DelayCallOpenInviteBox;

	[Token(Token = "0x400FE0F")]
	[FieldOffset(Offset = "0x3C")]
	private BitArrayBoolean m_GroupModeSelectEnable;

	[Token(Token = "0x400FE10")]
	[FieldOffset(Offset = "0x40")]
	private BitArrayBoolean m_InviteBtnEnable;

	[Token(Token = "0x400FE11")]
	[FieldOffset(Offset = "0x44")]
	public HHDIPHFOBFO m_GroupMode;

	[Token(Token = "0x400FE12")]
	[FieldOffset(Offset = "0x48")]
	private HHDIPHFOBFO m_CachedGroupMode;

	[Token(Token = "0x400FE13")]
	[FieldOffset(Offset = "0x4C")]
	private EMapDifficulty m_PveMapDifficulty;

	[Token(Token = "0x400FE14")]
	[FieldOffset(Offset = "0x50")]
	private bool m_IsCurrentMapModeIsPeriodicMapMode;

	[Token(Token = "0x400FE15")]
	[FieldOffset(Offset = "0x51")]
	private bool m_FirstOpenModesPanel;

	[Token(Token = "0x400FE16")]
	[FieldOffset(Offset = "0x52")]
	private bool m_NeedShowFirstGuideMatchGuide;

	[Token(Token = "0x400FE17")]
	[FieldOffset(Offset = "0x54")]
	private uint m_DelayCallForBonusBtn;

	[Token(Token = "0x400FE18")]
	private const uint GroupModeSelectNormalLogic = 1u;

	[Token(Token = "0x400FE19")]
	private const uint GroupModeSelectUGCLogic = 2u;

	[Token(Token = "0x400FE1A")]
	private const uint InviteButtonNormalLogic = 1u;

	[Token(Token = "0x400FE1B")]
	private const uint InviteButtonUGCLogic = 2u;

	[Token(Token = "0x400FE1C")]
	[FieldOffset(Offset = "0x58")]
	private Action m_OnAfterCreateGroupSuccess;

	[Token(Token = "0x400FE1D")]
	[FieldOffset(Offset = "0x5C")]
	private UIModelUser m_ModelUser;

	[Token(Token = "0x400FE1E")]
	[FieldOffset(Offset = "0x60")]
	private UIModelMapOpeningInfo m_ModelMap;

	[Token(Token = "0x400FE1F")]
	[FieldOffset(Offset = "0x64")]
	private UIModelPeriodicLadderMatch m_UIModelPeriodicLadderMatch;

	[Token(Token = "0x400FE20")]
	[FieldOffset(Offset = "0x68")]
	private UIModelGroup m_ModelGroup;

	[Token(Token = "0x400FE21")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelCustomRoom m_ModelCustomRoom;

	[Token(Token = "0x400FE22")]
	[FieldOffset(Offset = "0x70")]
	private UILobbyGroupNewController m_GroupCtrl;

	[Token(Token = "0x400FE23")]
	[FieldOffset(Offset = "0x74")]
	private UIInviteGroupBoxController m_InviteBox;

	[Token(Token = "0x400FE24")]
	[FieldOffset(Offset = "0x78")]
	private UINewDownloadInfoController m_OptionalMapResDownloader;

	[Token(Token = "0x400FE25")]
	[FieldOffset(Offset = "0x7C")]
	private bool m_IsInClanWarTeam;

	[Token(Token = "0x400FE26")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<MapModeData, uint> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400FE27")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<MapModeData, uint> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400FE28")]
	[FieldOffset(Offset = "0x8")]
	private static Action _003C_003Ef__am_0024cache2;

	[Token(Token = "0x400FE29")]
	[FieldOffset(Offset = "0xC")]
	private static Converter<MapModeData, uint> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x17001239")]
	public GameObject LoadOutContainer
	{
		[Token(Token = "0x60106E6")]
		[Address(RVA = "0x1FA0B40", Offset = "0x1FA0B40", VA = "0x1FA0B40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700123A")]
	public UIButton UIButtonBtnEnterGameSG
	{
		[Token(Token = "0x60106E7")]
		[Address(RVA = "0x1FA0BCC", Offset = "0x1FA0BCC", VA = "0x1FA0BCC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700123B")]
	public UIWidget WidgetBtnStart
	{
		[Token(Token = "0x60106E8")]
		[Address(RVA = "0x1FA0C3C", Offset = "0x1FA0C3C", VA = "0x1FA0C3C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700123C")]
	public UIWidget mapModeBtnBg
	{
		[Token(Token = "0x60106E9")]
		[Address(RVA = "0x1FA0CAC", Offset = "0x1FA0CAC", VA = "0x1FA0CAC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700123D")]
	public UIWidget LoadoutGuideWidget
	{
		[Token(Token = "0x60106EA")]
		[Address(RVA = "0x1FA0D1C", Offset = "0x1FA0D1C", VA = "0x1FA0D1C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700123E")]
	public UIWidget UIWidgetBtnEnterGameSG
	{
		[Token(Token = "0x60106EB")]
		[Address(RVA = "0x1FA0D8C", Offset = "0x1FA0D8C", VA = "0x1FA0D8C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700123F")]
	public UIWidget CSGuideWidget
	{
		[Token(Token = "0x60106EC")]
		[Address(RVA = "0x1FA0DFC", Offset = "0x1FA0DFC", VA = "0x1FA0DFC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001240")]
	public UIWidget IAPBundleContainer
	{
		[Token(Token = "0x60106ED")]
		[Address(RVA = "0x1FA0E6C", Offset = "0x1FA0E6C", VA = "0x1FA0E6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001241")]
	public UIButton UIButtonmapModeBtn
	{
		[Token(Token = "0x60106EE")]
		[Address(RVA = "0x1FA0EDC", Offset = "0x1FA0EDC", VA = "0x1FA0EDC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001242")]
	public GameObject MapModeTipsAnim
	{
		[Token(Token = "0x60106EF")]
		[Address(RVA = "0x1FA0F4C", Offset = "0x1FA0F4C", VA = "0x1FA0F4C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001243")]
	public UICountDownLabel IAPBundleCountdownLabel
	{
		[Token(Token = "0x60106F0")]
		[Address(RVA = "0x1FA0FBC", Offset = "0x1FA0FBC", VA = "0x1FA0FBC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001244")]
	public UIButton BtnBundleChoose1From3
	{
		[Token(Token = "0x60106F1")]
		[Address(RVA = "0x1FA102C", Offset = "0x1FA102C", VA = "0x1FA102C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001245")]
	public UIButton BtnBundleWeb
	{
		[Token(Token = "0x60106F2")]
		[Address(RVA = "0x1FA109C", Offset = "0x1FA109C", VA = "0x1FA109C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60106E4")]
	[Address(RVA = "0x1FA0974", Offset = "0x1FA0974", VA = "0x1FA0974")]
	public UILobbyNewRightBottomController()
	{
	}

	[Token(Token = "0x60106E5")]
	[Address(RVA = "0x1FA0A98", Offset = "0x1FA0A98", VA = "0x1FA0A98")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60106F3")]
	[Address(RVA = "0x1FA110C", Offset = "0x1FA110C", VA = "0x1FA110C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60106F4")]
	[Address(RVA = "0x1FA39A4", Offset = "0x1FA39A4", VA = "0x1FA39A4")]
	private void Update()
	{
	}

	[Token(Token = "0x60106F5")]
	[Address(RVA = "0x1FA3AC4", Offset = "0x1FA3AC4", VA = "0x1FA3AC4")]
	private void OnBtnLoginClick()
	{
	}

	[Token(Token = "0x60106F6")]
	[Address(RVA = "0x1FA54F4", Offset = "0x1FA54F4", VA = "0x1FA54F4")]
	private void OnBtnBundleWebClick()
	{
	}

	[Token(Token = "0x60106F7")]
	[Address(RVA = "0x1FA56B0", Offset = "0x1FA56B0", VA = "0x1FA56B0")]
	private void OnBtnBundleChoose1From3Click()
	{
	}

	[Token(Token = "0x60106F8")]
	[Address(RVA = "0x1FA58AC", Offset = "0x1FA58AC", VA = "0x1FA58AC")]
	private void OnBtnBonusEventClick()
	{
	}

	[Token(Token = "0x60106F9")]
	[Address(RVA = "0x1FA5B08", Offset = "0x1FA5B08", VA = "0x1FA5B08")]
	public void InviteBtnClick()
	{
	}

	[Token(Token = "0x60106FA")]
	[Address(RVA = "0x1FA5C14", Offset = "0x1FA5C14", VA = "0x1FA5C14")]
	private void OnTeamModeBtnClick()
	{
	}

	[Token(Token = "0x60106FB")]
	[Address(RVA = "0x1FA6B48", Offset = "0x1FA6B48", VA = "0x1FA6B48")]
	private void OnMapModeBtnClick()
	{
	}

	[Token(Token = "0x60106FC")]
	[Address(RVA = "0x1FA74B8", Offset = "0x1FA74B8", VA = "0x1FA74B8")]
	private void OnPentaBtnClick()
	{
	}

	[Token(Token = "0x60106FD")]
	[Address(RVA = "0x1FA8718", Offset = "0x1FA8718", VA = "0x1FA8718")]
	private void OnSquardBtnClick()
	{
	}

	[Token(Token = "0x60106FE")]
	[Address(RVA = "0x1FA8780", Offset = "0x1FA8780", VA = "0x1FA8780")]
	private void OnDuoBtnClick()
	{
	}

	[Token(Token = "0x60106FF")]
	[Address(RVA = "0x1FA87E8", Offset = "0x1FA87E8", VA = "0x1FA87E8")]
	private void OnSoloBtnClick()
	{
	}

	[Token(Token = "0x6010700")]
	[Address(RVA = "0x1FA8850", Offset = "0x1FA8850", VA = "0x1FA8850")]
	private void OnResDownloaderClick(ResDownloadType resType)
	{
	}

	[Token(Token = "0x6010701")]
	[Address(RVA = "0x1FA8980", Offset = "0x1FA8980", VA = "0x1FA8980")]
	private IEnumerator CloseGroupModePanel(float seconds)
	{
		return null;
	}

	[Token(Token = "0x6010702")]
	[Address(RVA = "0x1FA8A7C", Offset = "0x1FA8A7C", VA = "0x1FA8A7C")]
	private void CloseGroupModePanel()
	{
	}

	[Token(Token = "0x6010703")]
	[Address(RVA = "0x1FA8B6C", Offset = "0x1FA8B6C", VA = "0x1FA8B6C")]
	private void UpdateSelectedGroupModeUI()
	{
	}

	[Token(Token = "0x6010704")]
	[Address(RVA = "0x1FA91D0", Offset = "0x1FA91D0", VA = "0x1FA91D0")]
	private void UpdateSelectedMapModeUI()
	{
	}

	[Token(Token = "0x6010705")]
	[Address(RVA = "0x1FAB5D0", Offset = "0x1FAB5D0", VA = "0x1FAB5D0")]
	private void RefreshPVEUI()
	{
	}

	[Token(Token = "0x6010706")]
	[Address(RVA = "0x1FA7520", Offset = "0x1FA7520", VA = "0x1FA7520")]
	private void ChangeGroupMode(HHDIPHFOBFO mode, EGroup.CreateFromType fromType = EGroup.CreateFromType.CreateFromType_OWNSELF)
	{
	}

	[Token(Token = "0x6010707")]
	[Address(RVA = "0x1FAD484", Offset = "0x1FAD484", VA = "0x1FAD484")]
	private void SetDefaultMode()
	{
	}

	[Token(Token = "0x6010708")]
	[Address(RVA = "0x1FADF4C", Offset = "0x1FADF4C", VA = "0x1FADF4C")]
	private void ShowMapModetip(object[] data)
	{
	}

	[Token(Token = "0x6010709")]
	[Address(RVA = "0x1FA64F0", Offset = "0x1FA64F0", VA = "0x1FA64F0")]
	private void RefreshTeamModesPanel()
	{
	}

	[Token(Token = "0x601070A")]
	[Address(RVA = "0x1FAE060", Offset = "0x1FAE060", VA = "0x1FAE060")]
	private void ChangeGroupMode(object[] args)
	{
	}

	[Token(Token = "0x601070B")]
	[Address(RVA = "0x1FAD368", Offset = "0x1FAD368", VA = "0x1FAD368")]
	private void RevertGroupMode(HHDIPHFOBFO mode)
	{
	}

	[Token(Token = "0x601070C")]
	[Address(RVA = "0x1FAE22C", Offset = "0x1FAE22C", VA = "0x1FAE22C")]
	private bool ChangeMapMode(MapModeData mapData)
	{
		return default(bool);
	}

	[Token(Token = "0x601070D")]
	[Address(RVA = "0x1FB057C", Offset = "0x1FB057C", VA = "0x1FB057C")]
	private void AutoSelectGroup()
	{
	}

	[Token(Token = "0x601070E")]
	[Address(RVA = "0x1FADB98", Offset = "0x1FADB98", VA = "0x1FADB98")]
	private void RevertMapMode(MapModeData mapData)
	{
	}

	[Token(Token = "0x601070F")]
	[Address(RVA = "0x1FB0838", Offset = "0x1FB0838", VA = "0x1FB0838")]
	private IEnumerator CloseMapModePanel(float seconds)
	{
		return null;
	}

	[Token(Token = "0x6010710")]
	[Address(RVA = "0x1FB0934", Offset = "0x1FB0934", VA = "0x1FB0934")]
	private void CloseMapModePanel()
	{
	}

	[Token(Token = "0x6010711")]
	[Address(RVA = "0x1FB0AE0", Offset = "0x1FB0AE0", VA = "0x1FB0AE0")]
	private void CloseModeSelectionPanels(object[] data)
	{
	}

	[Token(Token = "0x6010712")]
	[Address(RVA = "0x1FB0E94", Offset = "0x1FB0E94", VA = "0x1FB0E94")]
	private void OpenGroupUI()
	{
	}

	[Token(Token = "0x6010713")]
	[Address(RVA = "0x1FB13A8", Offset = "0x1FB13A8", VA = "0x1FB13A8")]
	public Vector3 GetInviteBoxScale()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6010714")]
	[Address(RVA = "0x1FB1524", Offset = "0x1FB1524", VA = "0x1FB1524")]
	public Vector3 GetInviteBoxCenterPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6010715")]
	[Address(RVA = "0x1FA3020", Offset = "0x1FA3020", VA = "0x1FA3020")]
	private void CheckAndStartFirstGuideMatch()
	{
	}

	[Token(Token = "0x6010716")]
	[Address(RVA = "0x1FAB800", Offset = "0x1FAB800", VA = "0x1FAB800")]
	public void RefreshBonusEventInfo(MapModeData mapModeData, HHDIPHFOBFO groupMode)
	{
	}

	[Token(Token = "0x6010717")]
	[Address(RVA = "0x1FAC28C", Offset = "0x1FAC28C", VA = "0x1FAC28C")]
	private void RefreshGroupModeByUGCMap()
	{
	}

	[Token(Token = "0x6010718")]
	[Address(RVA = "0x1FA278C", Offset = "0x1FA278C", VA = "0x1FA278C")]
	private void RefreshGameLobbyEnterStyle(object[] data)
	{
	}

	[Token(Token = "0x6010719")]
	[Address(RVA = "0x1FB1B70", Offset = "0x1FB1B70", VA = "0x1FB1B70")]
	public void RefreshCachedUISelectedData(object[] data)
	{
	}

	[Token(Token = "0x601071A")]
	[Address(RVA = "0x1FACDEC", Offset = "0x1FACDEC", VA = "0x1FACDEC")]
	private bool QuitToSolo()
	{
		return default(bool);
	}

	[Token(Token = "0x601071B")]
	[Address(RVA = "0x1FACFA0", Offset = "0x1FACFA0", VA = "0x1FACFA0")]
	private bool CheckGroupMode()
	{
		return default(bool);
	}

	[Token(Token = "0x601071C")]
	[Address(RVA = "0x1FA492C", Offset = "0x1FA492C", VA = "0x1FA492C")]
	private bool CheckPlayerLimits(HHDIPHFOBFO groupMode, bool showTips = true)
	{
		return default(bool);
	}

	[Token(Token = "0x601071D")]
	[Address(RVA = "0x1FAFE40", Offset = "0x1FAFE40", VA = "0x1FAFE40")]
	private bool CheckPlayerLimitsAndAutoSelectGroupMode(HHDIPHFOBFO groupMode)
	{
		return default(bool);
	}

	[Token(Token = "0x601071E")]
	[Address(RVA = "0x1FAD788", Offset = "0x1FAD788", VA = "0x1FAD788")]
	private bool IsSoloSupported(MapModeData mapData, bool showTips = true)
	{
		return default(bool);
	}

	[Token(Token = "0x601071F")]
	[Address(RVA = "0x1FB1F7C", Offset = "0x1FB1F7C", VA = "0x1FB1F7C")]
	public void RefreshLoadoutContainer()
	{
	}

	[Token(Token = "0x6010720")]
	[Address(RVA = "0x1FA627C", Offset = "0x1FA627C", VA = "0x1FA627C")]
	private bool CheckMapAvailability()
	{
		return default(bool);
	}

	[Token(Token = "0x6010721")]
	[Address(RVA = "0x1FB2038", Offset = "0x1FB2038", VA = "0x1FB2038")]
	private void OnEndMatchMaking(object[] data)
	{
	}

	[Token(Token = "0x6010722")]
	[Address(RVA = "0x1FA2EE4", Offset = "0x1FA2EE4", VA = "0x1FA2EE4")]
	private void SetOverMaskShow(bool show)
	{
	}

	[Token(Token = "0x6010723")]
	[Address(RVA = "0x1FA330C", Offset = "0x1FA330C", VA = "0x1FA330C")]
	private void CheckAndStartSinglePlayerForceTutorialGame()
	{
	}

	[Token(Token = "0x6010724")]
	[Address(RVA = "0x1FA4C0C", Offset = "0x1FA4C0C", VA = "0x1FA4C0C")]
	private void StartSoloMatchmaking(object[] data)
	{
	}

	[Token(Token = "0x6010725")]
	[Address(RVA = "0x1FB20A4", Offset = "0x1FB20A4", VA = "0x1FB20A4")]
	public void OnInviteClick(object[] data)
	{
	}

	[Token(Token = "0x6010726")]
	[Address(RVA = "0x1FB23E0", Offset = "0x1FB23E0", VA = "0x1FB23E0")]
	public void CloseInviteBoxWithUIEffect(object[] data)
	{
	}

	[Token(Token = "0x6010727")]
	[Address(RVA = "0x1FB24E4", Offset = "0x1FB24E4", VA = "0x1FB24E4")]
	public void CloseInviteBoxWithOutUIEffect(object[] data)
	{
	}

	[Token(Token = "0x6010728")]
	[Address(RVA = "0x1FABD28", Offset = "0x1FABD28", VA = "0x1FABD28")]
	private void ShowGameModeWebTutorial(MapModeData mapData)
	{
	}

	[Token(Token = "0x6010729")]
	[Address(RVA = "0x1FADD10", Offset = "0x1FADD10", VA = "0x1FADD10")]
	private void EnableModeSelectionButtons(bool v)
	{
	}

	[Token(Token = "0x601072A")]
	[Address(RVA = "0x1FB25F0", Offset = "0x1FB25F0", VA = "0x1FB25F0")]
	private void OnMatchmakingHide(object[] data)
	{
	}

	[Token(Token = "0x601072B")]
	[Address(RVA = "0x1FB27CC", Offset = "0x1FB27CC", VA = "0x1FB27CC")]
	private void OnMatchmakingShow(object[] data)
	{
	}

	[Token(Token = "0x601072C")]
	[Address(RVA = "0x1FAC544", Offset = "0x1FAC544", VA = "0x1FAC544")]
	private void RefreshOptionalMapResDownloader(object[] data)
	{
	}

	[Token(Token = "0x601072D")]
	[Address(RVA = "0x1FB2E94", Offset = "0x1FB2E94", VA = "0x1FB2E94")]
	private void OnOnPveDifficultyChanged(object[] param)
	{
	}

	[Token(Token = "0x601072E")]
	[Address(RVA = "0x1FB3060", Offset = "0x1FB3060", VA = "0x1FB3060")]
	private void OnMapModeSelected(object[] param)
	{
	}

	[Token(Token = "0x601072F")]
	[Address(RVA = "0x1FB15DC", Offset = "0x1FB15DC", VA = "0x1FB15DC")]
	public void StartFirstGuideMatchmakingSolo(bool isTutorialBr)
	{
	}

	[Token(Token = "0x6010730")]
	[Address(RVA = "0x1FB3F00", Offset = "0x1FB3F00", VA = "0x1FB3F00")]
	private void OptionalDownloadStateChange()
	{
	}

	[Token(Token = "0x6010731")]
	[Address(RVA = "0x1FB4094", Offset = "0x1FB4094", VA = "0x1FB4094")]
	private void OnEnterClanWarTeam(object[] data)
	{
	}

	[Token(Token = "0x6010732")]
	[Address(RVA = "0x1FB4234", Offset = "0x1FB4234", VA = "0x1FB4234")]
	private void OnExitClanWarTeam(object[] data)
	{
	}

	[Token(Token = "0x6010733")]
	[Address(RVA = "0x1FB441C", Offset = "0x1FB441C", VA = "0x1FB441C")]
	private void OnCupMatchLockingTeam(object[] data)
	{
	}

	[Token(Token = "0x6010734")]
	[Address(RVA = "0x1FB44F4", Offset = "0x1FB44F4", VA = "0x1FB44F4")]
	private void OnGroupQuit(object[] param)
	{
	}

	[Token(Token = "0x6010735")]
	[Address(RVA = "0x1FB4834", Offset = "0x1FB4834", VA = "0x1FB4834")]
	private bool CheckIsMapAvailabe()
	{
		return default(bool);
	}

	[Token(Token = "0x6010736")]
	[Address(RVA = "0x1FB2DAC", Offset = "0x1FB2DAC", VA = "0x1FB2DAC")]
	private void RefreshStartBtnColor()
	{
	}

	[Token(Token = "0x6010737")]
	[Address(RVA = "0x1FB2A20", Offset = "0x1FB2A20", VA = "0x1FB2A20")]
	private MapModeData GetAlternativePeriodicMapData()
	{
		return null;
	}

	[Token(Token = "0x6010738")]
	[Address(RVA = "0x1FB4A30", Offset = "0x1FB4A30", VA = "0x1FB4A30")]
	public void NewbieMatchGameGuide(object[] args)
	{
	}

	[Token(Token = "0x6010739")]
	[Address(RVA = "0x1FB4DCC", Offset = "0x1FB4DCC", VA = "0x1FB4DCC")]
	private void OnGroupCreateSuccess(object[] param)
	{
	}

	[Token(Token = "0x601073A")]
	[Address(RVA = "0x1FB4F30", Offset = "0x1FB4F30", VA = "0x1FB4F30")]
	private void OnJoinNtf(object[] data)
	{
	}

	[Token(Token = "0x601073B")]
	[Address(RVA = "0x1FB5618", Offset = "0x1FB5618", VA = "0x1FB5618")]
	private void OnGroupInfoSync(object[] data)
	{
	}

	[Token(Token = "0x601073C")]
	[Address(RVA = "0x1FB5A08", Offset = "0x1FB5A08", VA = "0x1FB5A08")]
	private void OnGroupChangeGroupModeNtf(object[] data)
	{
	}

	[Token(Token = "0x601073D")]
	[Address(RVA = "0x1FB5C5C", Offset = "0x1FB5C5C", VA = "0x1FB5C5C")]
	private void OnCreateGroupFail(object[] data)
	{
	}

	[Token(Token = "0x601073E")]
	[Address(RVA = "0x1FB5CE4", Offset = "0x1FB5CE4", VA = "0x1FB5CE4")]
	public void RefreshRightBottomGroupModeUI()
	{
	}

	[Token(Token = "0x601073F")]
	[Address(RVA = "0x1FB5E9C", Offset = "0x1FB5E9C", VA = "0x1FB5E9C")]
	private void OnRoomOpen(object[] param)
	{
	}

	[Token(Token = "0x6010740")]
	[Address(RVA = "0x1FB5F0C", Offset = "0x1FB5F0C", VA = "0x1FB5F0C")]
	private void OnWorkShopMapSelected(object[] data)
	{
	}

	[Token(Token = "0x6010741")]
	[Address(RVA = "0x1FB5F98", Offset = "0x1FB5F98", VA = "0x1FB5F98")]
	private void OnWorkshopRequestInfo(object[] data)
	{
	}

	[Token(Token = "0x6010742")]
	[Address(RVA = "0x1FB6188", Offset = "0x1FB6188", VA = "0x1FB6188")]
	public void RefreshIAPBundleActivityState()
	{
	}

	[Token(Token = "0x6010743")]
	[Address(RVA = "0x1FB6798", Offset = "0x1FB6798", VA = "0x1FB6798", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6010744")]
	[Address(RVA = "0x1FB6B10", Offset = "0x1FB6B10", VA = "0x1FB6B10")]
	public void PlayTweenPosition()
	{
	}

	[Token(Token = "0x6010745")]
	[Address(RVA = "0x1FB6BD0", Offset = "0x1FB6BD0", VA = "0x1FB6BD0")]
	public void ResetTweenPosition()
	{
	}

	[Token(Token = "0x6010746")]
	[Address(RVA = "0x1FB6CE8", Offset = "0x1FB6CE8", VA = "0x1FB6CE8", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010747")]
	[Address(RVA = "0x1FB6DE8", Offset = "0x1FB6DE8", VA = "0x1FB6DE8", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010748")]
	[Address(RVA = "0x1FB7644", Offset = "0x1FB7644", VA = "0x1FB7644")]
	private void _003COnBtnLoginClick_003Em__0()
	{
	}

	[Token(Token = "0x6010749")]
	[Address(RVA = "0x1FB7690", Offset = "0x1FB7690", VA = "0x1FB7690")]
	private static uint _003CChangeGroupMode_003Em__1(MapModeData x)
	{
		return default(uint);
	}

	[Token(Token = "0x601074A")]
	[Address(RVA = "0x1FB76B4", Offset = "0x1FB76B4", VA = "0x1FB76B4")]
	private static uint _003CChangeMapMode_003Em__2(MapModeData x)
	{
		return default(uint);
	}

	[Token(Token = "0x601074B")]
	[Address(RVA = "0x1FB76D8", Offset = "0x1FB76D8", VA = "0x1FB76D8")]
	private void _003COpenGroupUI_003Em__3()
	{
	}

	[Token(Token = "0x601074C")]
	[Address(RVA = "0x1FB78F0", Offset = "0x1FB78F0", VA = "0x1FB78F0")]
	private void _003CCheckAndStartFirstGuideMatch_003Em__4()
	{
	}

	[Token(Token = "0x601074D")]
	[Address(RVA = "0x1FB78F8", Offset = "0x1FB78F8", VA = "0x1FB78F8")]
	private static void _003CCheckPlayerLimitsAndAutoSelectGroupMode_003Em__5()
	{
	}

	[Token(Token = "0x601074E")]
	[Address(RVA = "0x1FB78FC", Offset = "0x1FB78FC", VA = "0x1FB78FC")]
	private void _003CCheckAndStartSinglePlayerForceTutorialGame_003Em__6()
	{
	}

	[Token(Token = "0x601074F")]
	[Address(RVA = "0x1FB7904", Offset = "0x1FB7904", VA = "0x1FB7904")]
	private static uint _003CStartSoloMatchmaking_003Em__7(MapModeData x)
	{
		return default(uint);
	}

	[Token(Token = "0x6010750")]
	[Address(RVA = "0x1FB7928", Offset = "0x1FB7928", VA = "0x1FB7928")]
	private void _003CNewbieMatchGameGuide_003Em__8()
	{
	}

	[Token(Token = "0x6010751")]
	[Address(RVA = "0x1FB7A54", Offset = "0x1FB7A54", VA = "0x1FB7A54")]
	private void _003CRefreshIAPBundleActivityState_003Em__9()
	{
	}

	[Token(Token = "0x6010752")]
	[Address(RVA = "0x1FB7AC4", Offset = "0x1FB7AC4", VA = "0x1FB7AC4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010753")]
	[Address(RVA = "0x1FB7ACC", Offset = "0x1FB7ACC", VA = "0x1FB7ACC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
