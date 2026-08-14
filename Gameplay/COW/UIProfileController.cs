using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002A8B")]
public class UIProfileController : UINavigationController, _Attribute, IConvertible
{
	[Token(Token = "0x2002A8C")]
	private sealed class _003CCreateTab_003Ec__AnonStorey1
	{
		[Token(Token = "0x401059B")]
		[FieldOffset(Offset = "0x8")]
		internal StandardTabItemViewData creditTabData;

		[Token(Token = "0x401059C")]
		[FieldOffset(Offset = "0xC")]
		internal string creditRedPointKey;

		[Token(Token = "0x401059D")]
		[FieldOffset(Offset = "0x10")]
		internal UIProfileController _0024this;

		[Token(Token = "0x60115E2")]
		[Address(RVA = "0x16CF668", Offset = "0x16CF668", VA = "0x16CF668")]
		public _003CCreateTab_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60115E3")]
		[Address(RVA = "0x16CF670", Offset = "0x16CF670", VA = "0x16CF670")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002A8D")]
	private sealed class _003CRefreshAvatar_003Ec__AnonStorey2
	{
		[Token(Token = "0x401059E")]
		[FieldOffset(Offset = "0x8")]
		internal UIMaleAvatar localavatar;

		[Token(Token = "0x401059F")]
		[FieldOffset(Offset = "0xC")]
		internal uint groupAnimID;

		[Token(Token = "0x40105A0")]
		[FieldOffset(Offset = "0x10")]
		internal UIProfileController _0024this;

		[Token(Token = "0x60115E4")]
		[Address(RVA = "0x16D0268", Offset = "0x16D0268", VA = "0x16D0268")]
		public _003CRefreshAvatar_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x60115E5")]
		[Address(RVA = "0x16D0270", Offset = "0x16D0270", VA = "0x16D0270")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002A8E")]
	private sealed class _003CCoPlayGroupAnim_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x40105A1")]
		[FieldOffset(Offset = "0x8")]
		internal int _003CwaitedFrames_003E__0;

		[Token(Token = "0x40105A2")]
		[FieldOffset(Offset = "0xC")]
		internal UIMaleAvatar localAvatar;

		[Token(Token = "0x40105A3")]
		[FieldOffset(Offset = "0x10")]
		internal ResourceID groupAnimID;

		[Token(Token = "0x40105A4")]
		[FieldOffset(Offset = "0x14")]
		internal UIProfileController _0024this;

		[Token(Token = "0x40105A5")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x40105A6")]
		[FieldOffset(Offset = "0x1C")]
		internal bool _0024disposing;

		[Token(Token = "0x40105A7")]
		[FieldOffset(Offset = "0x20")]
		internal int _0024PC;

		[Token(Token = "0x170012C9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60115E8")]
			[Address(RVA = "0x16CF5BC", Offset = "0x16CF5BC", VA = "0x16CF5BC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012CA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60115E9")]
			[Address(RVA = "0x16CF5C4", Offset = "0x16CF5C4", VA = "0x16CF5C4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60115E6")]
		[Address(RVA = "0x16CF340", Offset = "0x16CF340", VA = "0x16CF340")]
		public _003CCoPlayGroupAnim_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x60115E7")]
		[Address(RVA = "0x16CF348", Offset = "0x16CF348", VA = "0x16CF348", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60115EA")]
		[Address(RVA = "0x16CF5CC", Offset = "0x16CF5CC", VA = "0x16CF5CC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60115EB")]
		[Address(RVA = "0x16CF5E0", Offset = "0x16CF5E0", VA = "0x16CF5E0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002A8F")]
	private sealed class _003COnReplayRecordClick_003Ec__AnonStorey3
	{
		[Token(Token = "0x40105A8")]
		[FieldOffset(Offset = "0x8")]
		internal ulong matchID;

		[Token(Token = "0x60115EC")]
		[Address(RVA = "0x16D0220", Offset = "0x16D0220", VA = "0x16D0220")]
		public _003COnReplayRecordClick_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x60115ED")]
		[Address(RVA = "0x16D0228", Offset = "0x16D0228", VA = "0x16D0228")]
		internal bool _003C_003Em__0(MatchRecordPersonal v)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4010542")]
	[FieldOffset(Offset = "0x68")]
	private UIProfileViewExt m_View;

	[Token(Token = "0x4010543")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelProfile m_Model;

	[Token(Token = "0x4010544")]
	[FieldOffset(Offset = "0x70")]
	private UIModelCSLadderMatch m_CsLaddermodel;

	[Token(Token = "0x4010545")]
	[FieldOffset(Offset = "0x74")]
	private UIModelPeriodicLadderMatch m_PeriodicLaddermodel;

	[Token(Token = "0x4010546")]
	[FieldOffset(Offset = "0x78")]
	private List<UIHistoryTeammateController> m_HistoryTeammate;

	[Token(Token = "0x4010547")]
	[FieldOffset(Offset = "0x7C")]
	private List<BasicEPInfo> m_AllEpList;

	[Token(Token = "0x4010548")]
	[FieldOffset(Offset = "0x80")]
	private List<uint> m_GameModeListShowKDRatio;

	[Token(Token = "0x4010549")]
	[FieldOffset(Offset = "0x84")]
	private ProfileFullTab m_ChooseTab;

	[Token(Token = "0x401054A")]
	private const int m_FightTypeAll = 3;

	[Token(Token = "0x401054B")]
	private const int m_TrendALL = 3;

	[Token(Token = "0x401054C")]
	private const int SHOW_EP_LIMIT = 5;

	[Token(Token = "0x401054D")]
	private const int m_HistoryFullEpAll = 9;

	[Token(Token = "0x401054E")]
	private const int m_ClothPreviewAll = 7;

	[Token(Token = "0x401054F")]
	public const string LADDER_MATCH = "TXT_OB5_HISTORY_RANK";

	[Token(Token = "0x4010550")]
	public const string CASUAL_MATCH = "TXT_OB5_HISTORY_CASUAL";

	[Token(Token = "0x4010551")]
	public const string ROOM_MATCH = "TXT_OB7_ZJS_CUSTOM_TITLE";

	[Token(Token = "0x4010552")]
	public const uint POSITIVE_DELTA_COLOR = 4284678115u;

	[Token(Token = "0x4010553")]
	public const uint NEGATIVE_DELTA_COLOR = 4294912512u;

	[Token(Token = "0x4010554")]
	public const int RankLeadBoardSize = 100;

	[Token(Token = "0x4010555")]
	[FieldOffset(Offset = "0x88")]
	private ulong m_AccoutId;

	[Token(Token = "0x4010556")]
	[FieldOffset(Offset = "0x90")]
	private int[] m_EwardrobeTypeList;

	[Token(Token = "0x4010557")]
	[FieldOffset(Offset = "0x94")]
	private List<UIProfileFightDataItemController> m_ProfileFightDataListController;

	[Token(Token = "0x4010558")]
	[FieldOffset(Offset = "0x98")]
	private List<UIClothPreviewItemController> m_UIClothPreviewListControler;

	[Token(Token = "0x4010559")]
	[FieldOffset(Offset = "0x9C")]
	private List<UIProfileEPAwardItemController> m_ProfileEPAwardListController;

	[Token(Token = "0x401055A")]
	[FieldOffset(Offset = "0xA0")]
	private UIProfileFightDataItemController m_CurrentShowFightDataController;

	[Token(Token = "0x401055B")]
	[FieldOffset(Offset = "0xA4")]
	private UIProfileFightDataItemController m_PeriodicFightDataController;

	[Token(Token = "0x401055C")]
	[FieldOffset(Offset = "0xA8")]
	private UIprofileEpsmallController[] m_EPCtrlList;

	[Token(Token = "0x401055D")]
	[FieldOffset(Offset = "0xAC")]
	private uint[] m_DefaultClothes;

	[Token(Token = "0x401055E")]
	[FieldOffset(Offset = "0xB0")]
	private float m_ScreenshotbgoriginWidth;

	[Token(Token = "0x401055F")]
	[FieldOffset(Offset = "0xB4")]
	private float m_ScreenshotlineoriginWidth;

	[Token(Token = "0x4010560")]
	[FieldOffset(Offset = "0xB8")]
	private UINavigationUtil.UINavagationProfileType m_profileType;

	[Token(Token = "0x4010561")]
	[FieldOffset(Offset = "0xBC")]
	private UIButton m_LastButton;

	[Token(Token = "0x4010562")]
	[FieldOffset(Offset = "0xC0")]
	private ELive.FollowerType m_CurrentType;

	[Token(Token = "0x4010563")]
	[FieldOffset(Offset = "0xC4")]
	private BaseItemInfo m_PinItemInfo;

	[Token(Token = "0x4010564")]
	[FieldOffset(Offset = "0xC8")]
	private List<GameObject> m_StarList;

	[Token(Token = "0x4010565")]
	[FieldOffset(Offset = "0xCC")]
	private List<GameObject> m_BlackStarList;

	[Token(Token = "0x4010566")]
	[FieldOffset(Offset = "0xD0")]
	private UIEmoteShowPanelController m_EmotePanelController;

	[Token(Token = "0x4010567")]
	[FieldOffset(Offset = "0xD4")]
	private UIProfileCreditController m_CreditController;

	[Token(Token = "0x4010568")]
	[FieldOffset(Offset = "0xD8")]
	private UIStandardDrawerTabController m_TabCtrl;

	[Token(Token = "0x4010569")]
	[FieldOffset(Offset = "0xDC")]
	private bool m_BtnSettingState;

	[Token(Token = "0x401056A")]
	[FieldOffset(Offset = "0xDD")]
	private bool m_BtnMarryState;

	[Token(Token = "0x401056B")]
	[FieldOffset(Offset = "0xDE")]
	private bool m_BtnStreamingState;

	[Token(Token = "0x401056C")]
	[FieldOffset(Offset = "0xDF")]
	private bool m_BtnAddfriendState;

	[Token(Token = "0x401056D")]
	[FieldOffset(Offset = "0xE0")]
	private bool m_BtnShareBtnState;

	[Token(Token = "0x401056E")]
	[FieldOffset(Offset = "0xE1")]
	private bool m_BtnCreditState;

	[Token(Token = "0x401056F")]
	[FieldOffset(Offset = "0xE2")]
	private bool m_FightBrMenuState;

	[Token(Token = "0x4010570")]
	[FieldOffset(Offset = "0xE3")]
	private bool m_FightCsMenuState;

	[Token(Token = "0x4010571")]
	[FieldOffset(Offset = "0xE4")]
	private bool m_Deslabel1State;

	[Token(Token = "0x4010572")]
	[FieldOffset(Offset = "0xE5")]
	private bool m_ProfileNodeALlShareState;

	[Token(Token = "0x4010573")]
	[FieldOffset(Offset = "0xE6")]
	private bool m_ProfileNodeRulteState;

	[Token(Token = "0x4010574")]
	[FieldOffset(Offset = "0xE7")]
	private bool isShowMarry;

	[Token(Token = "0x4010575")]
	[FieldOffset(Offset = "0xE8")]
	private bool isFromBoard;

	[Token(Token = "0x4010576")]
	[FieldOffset(Offset = "0xEC")]
	private UIPopMenuSmallControler m_ModeCsMenu;

	[Token(Token = "0x4010577")]
	[FieldOffset(Offset = "0xF0")]
	private UIPopMenuSmallControler m_ModeBrMenu;

	[Token(Token = "0x4010578")]
	[FieldOffset(Offset = "0xF4")]
	private string m_SelectBr;

	[Token(Token = "0x4010579")]
	[FieldOffset(Offset = "0xF8")]
	private string m_SelectCS;

	[Token(Token = "0x401057A")]
	[FieldOffset(Offset = "0xFC")]
	private List<PopMenuData> m_ModeBRMenuList;

	[Token(Token = "0x401057B")]
	[FieldOffset(Offset = "0x100")]
	private List<PopMenuData> m_ModeCSMenuList;

	[Token(Token = "0x401057C")]
	[FieldOffset(Offset = "0x104")]
	private List<string> m_ModeStrBRMenuList;

	[Token(Token = "0x401057D")]
	[FieldOffset(Offset = "0x108")]
	private List<string> m_ModeStrCSMenuList;

	[Token(Token = "0x401057E")]
	[FieldOffset(Offset = "0x10C")]
	private List<UIProfileTagSmallController> m_SocialBiaoqianList;

	[Token(Token = "0x401057F")]
	[FieldOffset(Offset = "0x110")]
	private List<UIProfileTagSmallController> m_BattleBiaoqianList;

	[Token(Token = "0x4010580")]
	[FieldOffset(Offset = "0x114")]
	private string m_Selectedhuoyue;

	[Token(Token = "0x4010581")]
	[FieldOffset(Offset = "0x118")]
	private string m_SelectOnline;

	[Token(Token = "0x4010582")]
	[FieldOffset(Offset = "0x11C")]
	private string m_SelectModeLikes;

	[Token(Token = "0x4010583")]
	[FieldOffset(Offset = "0x120")]
	private MatchRecordPersonal m_MatchData;

	[Token(Token = "0x4010584")]
	[FieldOffset(Offset = "0x124")]
	private string[] HistoryProfileItemAnimationArr;

	[Token(Token = "0x4010585")]
	[FieldOffset(Offset = "0x128")]
	private List<Transform> HistoryProfileItemTranform;

	[Token(Token = "0x4010586")]
	[FieldOffset(Offset = "0x12C")]
	private Vector3 clonePos;

	[Token(Token = "0x4010587")]
	[FieldOffset(Offset = "0x138")]
	private bool m_HasPlayedProfileEnterTeamAnimtion;

	[Token(Token = "0x4010588")]
	[FieldOffset(Offset = "0x139")]
	private bool m_PlayCommonVfx;

	[Token(Token = "0x4010589")]
	[FieldOffset(Offset = "0x13A")]
	private bool m_PlayCsVfx;

	[Token(Token = "0x401058A")]
	[FieldOffset(Offset = "0x13B")]
	private bool m_IsUserSelf;

	[Token(Token = "0x401058B")]
	[FieldOffset(Offset = "0x140")]
	private ulong m_UserAccountId;

	[Token(Token = "0x401058C")]
	[FieldOffset(Offset = "0x148")]
	private string m_DefaultSignature;

	[Token(Token = "0x401058D")]
	[FieldOffset(Offset = "0x150")]
	private ulong m_ClickReplayMatchID;

	[Token(Token = "0x401058E")]
	[FieldOffset(Offset = "0x158")]
	private IEnumerator m_PlayGroupAnimCor;

	[Token(Token = "0x401058F")]
	[FieldOffset(Offset = "0x15C")]
	private Action m_GroupAnimPlay;

	[Token(Token = "0x4010590")]
	[FieldOffset(Offset = "0x160")]
	private bool m_FirstEnter;

	[Token(Token = "0x4010591")]
	[FieldOffset(Offset = "0x164")]
	private Vector3 currentlegpos;

	[Token(Token = "0x4010592")]
	[FieldOffset(Offset = "0x170")]
	private GameObject m_GroundShadow;

	[Token(Token = "0x4010593")]
	[FieldOffset(Offset = "0x0")]
	private static List<string> UI3DOBJECT_NAMES;

	[Token(Token = "0x4010594")]
	[FieldOffset(Offset = "0x174")]
	private UIUtils.ScreenshotType m_CurrentScreenshotType;

	[Token(Token = "0x4010595")]
	[FieldOffset(Offset = "0x178")]
	private GameObject m_CacheHeroicBREffect;

	[Token(Token = "0x4010596")]
	[FieldOffset(Offset = "0x17C")]
	private GameObject m_CacheHeroicCSEffect;

	[Token(Token = "0x4010597")]
	[FieldOffset(Offset = "0x180")]
	private readonly Vector2 heroicEffectPos;

	[Token(Token = "0x4010598")]
	[FieldOffset(Offset = "0x188")]
	private readonly Vector2 heroicEffectScale;

	[Token(Token = "0x4010599")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<MatchRecordPersonal> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x401059A")]
	[FieldOffset(Offset = "0x8")]
	private static Predicate<MatchRecordPersonal> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x6011543")]
	[Address(RVA = "0xF13430", Offset = "0xF13430", VA = "0xF13430")]
	public UIProfileController()
	{
	}

	[Token(Token = "0x6011544")]
	[Address(RVA = "0xF13F08", Offset = "0xF13F08", VA = "0xF13F08")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011545")]
	[Address(RVA = "0xF13FAC", Offset = "0xF13FAC", VA = "0xF13FAC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011546")]
	[Address(RVA = "0xF18A50", Offset = "0xF18A50", VA = "0xF18A50", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6011547")]
	[Address(RVA = "0xF18AEC", Offset = "0xF18AEC", VA = "0xF18AEC")]
	private void OnHistoryDetailClick()
	{
	}

	[Token(Token = "0x6011548")]
	[Address(RVA = "0xF18F78", Offset = "0xF18F78", VA = "0xF18F78")]
	private void GenerateModeBrMenu()
	{
	}

	[Token(Token = "0x6011549")]
	[Address(RVA = "0xF19358", Offset = "0xF19358", VA = "0xF19358")]
	private void OnModeBrMenuSelect(object obj)
	{
	}

	[Token(Token = "0x601154A")]
	[Address(RVA = "0xF193B4", Offset = "0xF193B4", VA = "0xF193B4")]
	private void GenerateModeCSMenu()
	{
	}

	[Token(Token = "0x601154B")]
	[Address(RVA = "0xF19794", Offset = "0xF19794", VA = "0xF19794")]
	private void OnModeCSMenuSelect(object obj)
	{
	}

	[Token(Token = "0x601154C")]
	[Address(RVA = "0xF19E84", Offset = "0xF19E84", VA = "0xF19E84", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x601154D")]
	[Address(RVA = "0xF1A7A4", Offset = "0xF1A7A4", VA = "0xF1A7A4", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x601154E")]
	[Address(RVA = "0xF1C5A8", Offset = "0xF1C5A8", VA = "0xF1C5A8")]
	private void SetReplayTabVisible()
	{
	}

	[Token(Token = "0x601154F")]
	[Address(RVA = "0xF1C730", Offset = "0xF1C730", VA = "0xF1C730")]
	private void SetCreditInfoTabVisible()
	{
	}

	[Token(Token = "0x6011550")]
	[Address(RVA = "0xF1CE5C", Offset = "0xF1CE5C", VA = "0xF1CE5C")]
	private void TrySendLangr(AccountPersonalShowInfo info)
	{
	}

	[Token(Token = "0x6011551")]
	[Address(RVA = "0xF1C94C", Offset = "0xF1C94C", VA = "0xF1C94C")]
	private void TryShowSettingGuide()
	{
	}

	[Token(Token = "0x6011552")]
	[Address(RVA = "0xF1D1C0", Offset = "0xF1D1C0", VA = "0xF1D1C0")]
	private void TryShowNodeFullRuleWnd()
	{
	}

	[Token(Token = "0x6011553")]
	[Address(RVA = "0xF1D368", Offset = "0xF1D368", VA = "0xF1D368")]
	private void OnEpFullClick()
	{
	}

	[Token(Token = "0x6011554")]
	[Address(RVA = "0xF1D430", Offset = "0xF1D430", VA = "0xF1D430")]
	private void OnEpBriefClick()
	{
	}

	[Token(Token = "0x6011555")]
	[Address(RVA = "0xF1D5AC", Offset = "0xF1D5AC", VA = "0xF1D5AC")]
	private void OnBtnPinClick()
	{
	}

	[Token(Token = "0x6011556")]
	[Address(RVA = "0xF1D71C", Offset = "0xF1D71C", VA = "0xF1D71C")]
	private void OnBtnEPDocumentClick()
	{
	}

	[Token(Token = "0x6011557")]
	[Address(RVA = "0xF1D8C4", Offset = "0xF1D8C4", VA = "0xF1D8C4", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x6011558")]
	[Address(RVA = "0xF1E0B0", Offset = "0xF1E0B0", VA = "0xF1E0B0", Slot = "36")]
	protected override void OnSendShowTimeEvent(ref string eventLogKey, ref EventLogger.EventPageDetentionTime eventLog)
	{
	}

	[Token(Token = "0x6011559")]
	[Address(RVA = "0xF1800C", Offset = "0xF1800C", VA = "0xF1800C")]
	private void InitEPAwardUIList()
	{
	}

	[Token(Token = "0x601155A")]
	[Address(RVA = "0xF1E204", Offset = "0xF1E204", VA = "0xF1E204")]
	private void RefreshProfileNodeUI(object[] data)
	{
	}

	[Token(Token = "0x601155B")]
	[Address(RVA = "0xF1E2FC", Offset = "0xF1E2FC", VA = "0xF1E2FC")]
	private void RefreshSelectedCloth(object[] data)
	{
	}

	[Token(Token = "0x601155C")]
	[Address(RVA = "0xF1CD58", Offset = "0xF1CD58", VA = "0xF1CD58")]
	private void ChooseFirstTab()
	{
	}

	[Token(Token = "0x601155D")]
	[Address(RVA = "0xF1E4A0", Offset = "0xF1E4A0", VA = "0xF1E4A0")]
	private void OnNodeRuleBtnClick()
	{
	}

	[Token(Token = "0x601155E")]
	[Address(RVA = "0xF1E73C", Offset = "0xF1E73C", VA = "0xF1E73C")]
	private void OnProfileNodeAllShare()
	{
	}

	[Token(Token = "0x601155F")]
	[Address(RVA = "0xF1ED94", Offset = "0xF1ED94", VA = "0xF1ED94")]
	private void OnProfileNodeHistoryShare()
	{
	}

	[Token(Token = "0x6011560")]
	[Address(RVA = "0xF1F114", Offset = "0xF1F114", VA = "0xF1F114")]
	private void OnPortraitCloseupBtnClick()
	{
	}

	[Token(Token = "0x6011561")]
	[Address(RVA = "0xF1F2DC", Offset = "0xF1F2DC", VA = "0xF1F2DC")]
	private void OnHeroicMarkBRIconBtnClick()
	{
	}

	[Token(Token = "0x6011562")]
	[Address(RVA = "0xF1F438", Offset = "0xF1F438", VA = "0xF1F438")]
	private void OnHeroicMarkCSIconBtnClick()
	{
	}

	[Token(Token = "0x6011563")]
	[Address(RVA = "0xF1F594", Offset = "0xF1F594", VA = "0xF1F594", Slot = "39")]
	public override List<string> GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	[Token(Token = "0x6011564")]
	[Address(RVA = "0xF1F66C", Offset = "0xF1F66C", VA = "0xF1F66C")]
	private void SetRuleBtnPos()
	{
	}

	[Token(Token = "0x6011565")]
	[Address(RVA = "0xF18198", Offset = "0xF18198", VA = "0xF18198")]
	private void CreateTab()
	{
	}

	[Token(Token = "0x6011566")]
	[Address(RVA = "0xF17E8C", Offset = "0xF17E8C", VA = "0xF17E8C")]
	private void SetProfileFightDataVisible(ProfileFullTab profileFullTab)
	{
	}

	[Token(Token = "0x6011567")]
	[Address(RVA = "0xF1F8EC", Offset = "0xF1F8EC", VA = "0xF1F8EC")]
	private void ShowCsNodeALLbtn()
	{
	}

	[Token(Token = "0x6011568")]
	[Address(RVA = "0xF1FA4C", Offset = "0xF1FA4C", VA = "0xF1FA4C")]
	private void RefreshCsInfo(object[] data)
	{
	}

	[Token(Token = "0x6011569")]
	[Address(RVA = "0xF20E40", Offset = "0xF20E40", VA = "0xF20E40")]
	private void OnShowAvatarEmotePanel(object[] data)
	{
	}

	[Token(Token = "0x601156A")]
	[Address(RVA = "0xF215B0", Offset = "0xF215B0", VA = "0xF215B0")]
	private void OnUpdateLegPos(object[] data)
	{
	}

	[Token(Token = "0x601156B")]
	[Address(RVA = "0xF21744", Offset = "0xF21744", VA = "0xF21744")]
	private void OnCloseEmotePanel(object[] data)
	{
	}

	[Token(Token = "0x601156C")]
	[Address(RVA = "0xF21848", Offset = "0xF21848", VA = "0xF21848")]
	private void RefreshProfileFightListVfxState(bool show, int index)
	{
	}

	[Token(Token = "0x601156D")]
	[Address(RVA = "0xF21AA8", Offset = "0xF21AA8", VA = "0xF21AA8")]
	private void ShowDetailDataPanelAnimation(object[] data)
	{
	}

	[Token(Token = "0x601156E")]
	[Address(RVA = "0xF21EB8", Offset = "0xF21EB8", VA = "0xF21EB8", Slot = "37")]
	protected override bool NeedWaitDataReady()
	{
		return default(bool);
	}

	[Token(Token = "0x601156F")]
	[Address(RVA = "0xF21F10", Offset = "0xF21F10", VA = "0xF21F10", Slot = "42")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011570")]
	[Address(RVA = "0xF22320", Offset = "0xF22320", VA = "0xF22320")]
	private void ShowPersonalProfile(uint type)
	{
	}

	[Token(Token = "0x6011571")]
	[Address(RVA = "0xF27D48", Offset = "0xF27D48", VA = "0xF27D48")]
	private void RefreshItemDescText(object[] data)
	{
	}

	[Token(Token = "0x6011572")]
	[Address(RVA = "0xF2803C", Offset = "0xF2803C", VA = "0xF2803C")]
	private void OnBtnOpenClanDetail()
	{
	}

	[Token(Token = "0x6011573")]
	[Address(RVA = "0xF281CC", Offset = "0xF281CC", VA = "0xF281CC")]
	private void ShowBrLadder(int rank, uint peakRankPos, bool isSelf, UILabel go, UISprite spr)
	{
	}

	[Token(Token = "0x6011574")]
	[Address(RVA = "0xF287A8", Offset = "0xF287A8", VA = "0xF287A8")]
	private void ShowBrRankInfo()
	{
	}

	[Token(Token = "0x6011575")]
	[Address(RVA = "0xF1FAB4", Offset = "0xF1FAB4", VA = "0xF1FAB4")]
	private void ShowCsCurrentRankInfo()
	{
	}

	[Token(Token = "0x6011576")]
	[Address(RVA = "0xF290A4", Offset = "0xF290A4", VA = "0xF290A4")]
	private void onSeasonBrBtnClick()
	{
	}

	[Token(Token = "0x6011577")]
	[Address(RVA = "0xF290F8", Offset = "0xF290F8", VA = "0xF290F8")]
	private void onSeasonCSBtnClick()
	{
	}

	[Token(Token = "0x6011578")]
	[Address(RVA = "0xF2914C", Offset = "0xF2914C", VA = "0xF2914C")]
	private void OnAddFriend()
	{
	}

	[Token(Token = "0x6011579")]
	[Address(RVA = "0xF1EF0C", Offset = "0xF1EF0C", VA = "0xF1EF0C")]
	private void SendShareBtnClickLog()
	{
	}

	[Token(Token = "0x601157A")]
	[Address(RVA = "0xF2963C", Offset = "0xF2963C", VA = "0xF2963C")]
	private void ShowPersonalSetting()
	{
	}

	[Token(Token = "0x601157B")]
	[Address(RVA = "0xF2988C", Offset = "0xF2988C", VA = "0xF2988C")]
	private void SetDefaultLangr()
	{
	}

	[Token(Token = "0x601157C")]
	[Address(RVA = "0xF299EC", Offset = "0xF299EC", VA = "0xF299EC")]
	private void ShowCreditIcon()
	{
	}

	[Token(Token = "0x601157D")]
	[Address(RVA = "0xF25448", Offset = "0xF25448", VA = "0xF25448")]
	private void ShowMarryInfo()
	{
	}

	[Token(Token = "0x601157E")]
	[Address(RVA = "0xF23148", Offset = "0xF23148", VA = "0xF23148")]
	private void ShowPersonalBoard()
	{
	}

	[Token(Token = "0x601157F")]
	[Address(RVA = "0xF2A8EC", Offset = "0xF2A8EC", VA = "0xF2A8EC")]
	private void RefreshSocialProfile()
	{
	}

	[Token(Token = "0x6011580")]
	[Address(RVA = "0xF25BB0", Offset = "0xF25BB0", VA = "0xF25BB0")]
	private void RefreshBattleTagProfile()
	{
	}

	[Token(Token = "0x6011581")]
	[Address(RVA = "0xF28E68", Offset = "0xF28E68", VA = "0xF28E68")]
	private void RefreshHeroicLevel(int rank, int rankPoint, uint peakRankPos)
	{
	}

	[Token(Token = "0x6011582")]
	[Address(RVA = "0xF29048", Offset = "0xF29048", VA = "0xF29048")]
	private void RefreshHeroicMaxLevel(int rankPoint)
	{
	}

	[Token(Token = "0x6011583")]
	[Address(RVA = "0xF267C4", Offset = "0xF267C4", VA = "0xF267C4")]
	private void ShowPersonalAvatar()
	{
	}

	[Token(Token = "0x6011584")]
	[Address(RVA = "0xF1C2F8", Offset = "0xF1C2F8", VA = "0xF1C2F8")]
	private void RefreshPet(PetInfo info)
	{
	}

	[Token(Token = "0x6011585")]
	[Address(RVA = "0xF1B450", Offset = "0xF1B450", VA = "0xF1B450")]
	private void RefreshAvatar(AccountPersonalShowInfo info)
	{
	}

	[Token(Token = "0x6011586")]
	[Address(RVA = "0xF2B83C", Offset = "0xF2B83C", VA = "0xF2B83C")]
	private IEnumerator CoPlayGroupAnim(UIMaleAvatar localAvatar, ResourceID groupAnimID)
	{
		return null;
	}

	[Token(Token = "0x6011587")]
	[Address(RVA = "0xF1DF10", Offset = "0xF1DF10", VA = "0xF1DF10")]
	private void SetAvatarPos(bool inputEnable, bool resetRotation)
	{
	}

	[Token(Token = "0x6011588")]
	[Address(RVA = "0xF29C34", Offset = "0xF29C34", VA = "0xF29C34")]
	private void InItClothTabUI()
	{
	}

	[Token(Token = "0x6011589")]
	[Address(RVA = "0xF2B21C", Offset = "0xF2B21C", VA = "0xF2B21C")]
	private void UpdateClothTabUI(uint[] itemids)
	{
	}

	[Token(Token = "0x601158A")]
	[Address(RVA = "0xF2A270", Offset = "0xF2A270", VA = "0xF2A270")]
	private void UpdateEpAwardUIList(List<BasicEPInfo> historyinfo)
	{
	}

	[Token(Token = "0x601158B")]
	[Address(RVA = "0xF29D9C", Offset = "0xF29D9C", VA = "0xF29D9C")]
	public void UpdateHeadPic(uint iid)
	{
	}

	[Token(Token = "0x601158C")]
	[Address(RVA = "0xF2BC44", Offset = "0xF2BC44", VA = "0xF2BC44")]
	public void UpdateHeadPic(HeadPicData data)
	{
	}

	[Token(Token = "0x601158D")]
	[Address(RVA = "0xF2A05C", Offset = "0xF2A05C", VA = "0xF2A05C")]
	public void UpdatePin(uint pinId)
	{
	}

	[Token(Token = "0x601158E")]
	[Address(RVA = "0xF29F44", Offset = "0xF29F44", VA = "0xF29F44")]
	public void UpdateBanner(uint bannerId)
	{
	}

	[Token(Token = "0x601158F")]
	[Address(RVA = "0xF2BDC8", Offset = "0xF2BDC8", VA = "0xF2BDC8")]
	public void UpdateBanner(BannerData bannerData, bool isBrief = false)
	{
	}

	[Token(Token = "0x6011590")]
	[Address(RVA = "0xF17BF4", Offset = "0xF17BF4", VA = "0xF17BF4")]
	private void RefreshUserInfo()
	{
	}

	[Token(Token = "0x6011591")]
	[Address(RVA = "0xF2C028", Offset = "0xF2C028", VA = "0xF2C028")]
	private void UpdateHeadshot()
	{
	}

	[Token(Token = "0x6011592")]
	[Address(RVA = "0xF2C2E0", Offset = "0xF2C2E0", VA = "0xF2C2E0", Slot = "43")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011593")]
	[Address(RVA = "0xF2C428", Offset = "0xF2C428", VA = "0xF2C428")]
	private void OnReplayRecordClick(object[] data)
	{
	}

	[Token(Token = "0x6011594")]
	[Address(RVA = "0xF2C820", Offset = "0xF2C820", VA = "0xF2C820")]
	private void OnHistoryRecordClick(object[] data)
	{
	}

	[Token(Token = "0x6011595")]
	[Address(RVA = "0xF2FE2C", Offset = "0xF2FE2C", VA = "0xF2FE2C")]
	private void SetUGCHistoryData(UGCMatchStats stats)
	{
	}

	[Token(Token = "0x6011596")]
	[Address(RVA = "0xF301C8", Offset = "0xF301C8", VA = "0xF301C8")]
	private void SetUGCHistoryDataItem(int index, UILabel label, UILabel value, int[] scoreType, int[] score, int ugcTemplateId)
	{
	}

	[Token(Token = "0x6011597")]
	[Address(RVA = "0xF30478", Offset = "0xF30478", VA = "0xF30478")]
	private void SetUGCHistoryTeammatesData(UGCMatchStats stats)
	{
	}

	[Token(Token = "0x6011598")]
	[Address(RVA = "0xF27960", Offset = "0xF27960", VA = "0xF27960")]
	private void RefreshTeammateFriendBtnShow()
	{
	}

	[Token(Token = "0x6011599")]
	[Address(RVA = "0xF2280C", Offset = "0xF2280C", VA = "0xF2280C")]
	private void ShowHistoryRecord()
	{
	}

	[Token(Token = "0x601159A")]
	[Address(RVA = "0xF30A40", Offset = "0xF30A40", VA = "0xF30A40")]
	public void ShowRankHistory(UINavigationUtil.UINavagationProfileType _profileType = UINavigationUtil.UINavagationProfileType.ProfileDefault)
	{
	}

	[Token(Token = "0x601159B")]
	[Address(RVA = "0xF30ACC", Offset = "0xF30ACC", VA = "0xF30ACC")]
	public void ShowCredit(UINavigationUtil.UINavagationProfileType _profileType = UINavigationUtil.UINavagationProfileType.ProfileDefault)
	{
	}

	[Token(Token = "0x601159C")]
	[Address(RVA = "0xF17840", Offset = "0xF17840", VA = "0xF17840")]
	private void CloseAllNode()
	{
	}

	[Token(Token = "0x601159D")]
	[Address(RVA = "0xF30B58", Offset = "0xF30B58", VA = "0xF30B58")]
	private void _ShowRankHistory()
	{
	}

	[Token(Token = "0x601159E")]
	[Address(RVA = "0xF30C38", Offset = "0xF30C38", VA = "0xF30C38", Slot = "44")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x601159F")]
	[Address(RVA = "0xF30D30", Offset = "0xF30D30", VA = "0xF30D30", Slot = "45")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x60115A0")]
	[Address(RVA = "0xF30DAC", Offset = "0xF30DAC", VA = "0xF30DAC", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x60115A1")]
	[Address(RVA = "0xF32368", Offset = "0xF32368", VA = "0xF32368")]
	private void RestoreBtnState()
	{
	}

	[Token(Token = "0x60115A2")]
	[Address(RVA = "0xF32578", Offset = "0xF32578", VA = "0xF32578")]
	private void RestoreBtnState2()
	{
	}

	[Token(Token = "0x60115A3")]
	[Address(RVA = "0xF32888", Offset = "0xF32888", VA = "0xF32888")]
	private void ResetBtnState2()
	{
	}

	[Token(Token = "0x60115A4")]
	[Address(RVA = "0xF329A8", Offset = "0xF329A8", VA = "0xF329A8")]
	private void ResetBtnState()
	{
	}

	[Token(Token = "0x60115A5")]
	[Address(RVA = "0xF32788", Offset = "0xF32788", VA = "0xF32788")]
	public void SaveAvatarPos()
	{
	}

	[Token(Token = "0x60115A6")]
	[Address(RVA = "0xF2B62C", Offset = "0xF2B62C", VA = "0xF2B62C")]
	private void ShowOrHideAvatar(bool flag)
	{
	}

	[Token(Token = "0x60115A7")]
	[Address(RVA = "0xF32BF4", Offset = "0xF32BF4", VA = "0xF32BF4", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x60115A8")]
	[Address(RVA = "0xF335F4", Offset = "0xF335F4", VA = "0xF335F4")]
	private void OnShareBtnClick()
	{
	}

	[Token(Token = "0x60115A9")]
	[Address(RVA = "0xF3376C", Offset = "0xF3376C", VA = "0xF3376C")]
	private void OnTeamModeBtnClick()
	{
	}

	[Token(Token = "0x60115AA")]
	[Address(RVA = "0xF337C0", Offset = "0xF337C0", VA = "0xF337C0")]
	private void OnTotalBtnClick()
	{
	}

	[Token(Token = "0x60115AB")]
	[Address(RVA = "0xF33A38", Offset = "0xF33A38", VA = "0xF33A38")]
	private void OnCasualBtnClick()
	{
	}

	[Token(Token = "0x60115AC")]
	[Address(RVA = "0xF33BC4", Offset = "0xF33BC4", VA = "0xF33BC4")]
	private void SetDefaultClick()
	{
	}

	[Token(Token = "0x60115AD")]
	[Address(RVA = "0xF19A48", Offset = "0xF19A48", VA = "0xF19A48")]
	private void OnCsLifeClick()
	{
	}

	[Token(Token = "0x60115AE")]
	[Address(RVA = "0xF19BB0", Offset = "0xF19BB0", VA = "0xF19BB0")]
	private void OnCsBtnClick()
	{
	}

	[Token(Token = "0x60115AF")]
	[Address(RVA = "0xF19D1C", Offset = "0xF19D1C", VA = "0xF19D1C")]
	private void OnRankCsBtnClick()
	{
	}

	[Token(Token = "0x60115B0")]
	[Address(RVA = "0xF33C28", Offset = "0xF33C28", VA = "0xF33C28")]
	private void ShowPeriodicRankModeData(object[] param)
	{
	}

	[Token(Token = "0x60115B1")]
	[Address(RVA = "0xF27A8C", Offset = "0xF27A8C", VA = "0xF27A8C")]
	private void ShowCSRankModeData(uint matchmode)
	{
	}

	[Token(Token = "0x60115B2")]
	[Address(RVA = "0xF33D8C", Offset = "0xF33D8C", VA = "0xF33D8C")]
	private void OnRankBtnClick()
	{
	}

	[Token(Token = "0x60115B3")]
	[Address(RVA = "0xF33F18", Offset = "0xF33F18", VA = "0xF33F18")]
	private void OnCopyBtnClick()
	{
	}

	[Token(Token = "0x60115B4")]
	[Address(RVA = "0xF3394C", Offset = "0xF3394C", VA = "0xF3394C")]
	private void RefreshProfileTeamModestate(int type)
	{
	}

	[Token(Token = "0x60115B5")]
	[Address(RVA = "0xF2B954", Offset = "0xF2B954", VA = "0xF2B954")]
	private void OnShowClothesTab(uint itemid)
	{
	}

	[Token(Token = "0x60115B6")]
	[Address(RVA = "0xF341C8", Offset = "0xF341C8", VA = "0xF341C8")]
	private void OnBtnChangeNameClick()
	{
	}

	[Token(Token = "0x60115B7")]
	[Address(RVA = "0xF34324", Offset = "0xF34324", VA = "0xF34324")]
	private void OnInputFieldGetFocus()
	{
	}

	[Token(Token = "0x60115B8")]
	[Address(RVA = "0xF344B4", Offset = "0xF344B4", VA = "0xF344B4")]
	private void OnInputFieldLostFocus()
	{
	}

	[Token(Token = "0x60115B9")]
	[Address(RVA = "0xF348D4", Offset = "0xF348D4", VA = "0xF348D4")]
	private void OnEpBtnClick()
	{
	}

	[Token(Token = "0x60115BA")]
	[Address(RVA = "0xF34964", Offset = "0xF34964", VA = "0xF34964")]
	private void OnLikeBtnClick()
	{
	}

	[Token(Token = "0x60115BB")]
	[Address(RVA = "0xF349F4", Offset = "0xF349F4", VA = "0xF349F4")]
	private void OnEPHelperMaskBtnClick()
	{
	}

	[Token(Token = "0x60115BC")]
	[Address(RVA = "0xF34A84", Offset = "0xF34A84", VA = "0xF34A84")]
	private void OnCreditIconClick()
	{
	}

	[Token(Token = "0x60115BD")]
	[Address(RVA = "0xF34CE0", Offset = "0xF34CE0", VA = "0xF34CE0")]
	private void OnLikeHelperMaskBtnClick()
	{
	}

	[Token(Token = "0x60115BE")]
	[Address(RVA = "0xF33F88", Offset = "0xF33F88", VA = "0xF33F88")]
	private void CopyToClipBoard(ulong uid)
	{
	}

	[Token(Token = "0x60115BF")]
	[Address(RVA = "0xF34D70", Offset = "0xF34D70", VA = "0xF34D70")]
	public bool IsUserSelf()
	{
		return default(bool);
	}

	[Token(Token = "0x60115C0")]
	[Address(RVA = "0xF34DC8", Offset = "0xF34DC8", VA = "0xF34DC8")]
	public ulong GetAccountId()
	{
		return default(ulong);
	}

	[Token(Token = "0x60115C1")]
	[Address(RVA = "0xF300FC", Offset = "0xF300FC", VA = "0xF300FC")]
	private bool ShowKDRatio(uint gameMode)
	{
		return default(bool);
	}

	[Token(Token = "0x60115C2")]
	[Address(RVA = "0xF2FD9C", Offset = "0xF2FD9C", VA = "0xF2FD9C")]
	private bool IsClanWar(uint matchMode, uint gameMode)
	{
		return default(bool);
	}

	[Token(Token = "0x60115C3")]
	[Address(RVA = "0xF21C5C", Offset = "0xF21C5C", VA = "0xF21C5C")]
	private void PlayAnimByAnimClip(int index)
	{
	}

	[Token(Token = "0x60115C4")]
	[Address(RVA = "0xF17210", Offset = "0xF17210", VA = "0xF17210")]
	private void InitAnimState()
	{
	}

	[Token(Token = "0x60115C5")]
	[Address(RVA = "0xF176D4", Offset = "0xF176D4", VA = "0xF176D4")]
	private void InitProfileGridTransform()
	{
	}

	[Token(Token = "0x60115C6")]
	[Address(RVA = "0xF34E28", Offset = "0xF34E28", VA = "0xF34E28")]
	private void ResetProfileState()
	{
	}

	[Token(Token = "0x60115C7")]
	[Address(RVA = "0xF35008", Offset = "0xF35008", VA = "0xF35008")]
	private void OnEnterProfileSettingTabLoadingInfo(object[] data)
	{
	}

	[Token(Token = "0x60115C8")]
	[Address(RVA = "0xF1C8B8", Offset = "0xF1C8B8", VA = "0xF1C8B8")]
	private void GetPlayerHeroicMarkInfo()
	{
	}

	[Token(Token = "0x60115C9")]
	[Address(RVA = "0xF26884", Offset = "0xF26884", VA = "0xF26884")]
	private void RefreshHeroicMarkInfo()
	{
	}

	[Token(Token = "0x60115CB")]
	[Address(RVA = "0xF351E0", Offset = "0xF351E0", VA = "0xF351E0")]
	private void _003COnUIInit_003Em__0(bool flag)
	{
	}

	[Token(Token = "0x60115CC")]
	[Address(RVA = "0xF35394", Offset = "0xF35394", VA = "0xF35394")]
	private void _003COnUIInit_003Em__1(bool flag)
	{
	}

	[Token(Token = "0x60115CD")]
	[Address(RVA = "0xF35548", Offset = "0xF35548", VA = "0xF35548")]
	private void _003COnUIInit_003Em__2(bool flag)
	{
	}

	[Token(Token = "0x60115CE")]
	[Address(RVA = "0xF356C8", Offset = "0xF356C8", VA = "0xF356C8")]
	private void _003COnUIInit_003Em__3(bool flag)
	{
	}

	[Token(Token = "0x60115CF")]
	[Address(RVA = "0xF35848", Offset = "0xF35848", VA = "0xF35848")]
	private void _003COnUIInit_003Em__4(bool flag)
	{
	}

	[Token(Token = "0x60115D0")]
	[Address(RVA = "0xF359C8", Offset = "0xF359C8", VA = "0xF359C8")]
	private void _003COnUIInit_003Em__5(bool flag)
	{
	}

	[Token(Token = "0x60115D1")]
	[Address(RVA = "0xF35FCC", Offset = "0xF35FCC", VA = "0xF35FCC")]
	private void _003CCreateTab_003Em__6()
	{
	}

	[Token(Token = "0x60115D2")]
	[Address(RVA = "0xF36278", Offset = "0xF36278", VA = "0xF36278")]
	private void _003CCreateTab_003Em__7()
	{
	}

	[Token(Token = "0x60115D3")]
	[Address(RVA = "0xF36610", Offset = "0xF36610", VA = "0xF36610")]
	private void _003CCreateTab_003Em__8()
	{
	}

	[Token(Token = "0x60115D4")]
	[Address(RVA = "0xF368C0", Offset = "0xF368C0", VA = "0xF368C0")]
	private void _003CCreateTab_003Em__9()
	{
	}

	[Token(Token = "0x60115D5")]
	[Address(RVA = "0xF36AC0", Offset = "0xF36AC0", VA = "0xF36AC0")]
	private static bool _003CShowHistoryRecord_003Em__A(MatchRecordPersonal item)
	{
		return default(bool);
	}

	[Token(Token = "0x60115D6")]
	[Address(RVA = "0xF36AF0", Offset = "0xF36AF0", VA = "0xF36AF0")]
	private static bool _003CShowHistoryRecord_003Em__B(MatchRecordPersonal item)
	{
		return default(bool);
	}

	[Token(Token = "0x60115D7")]
	[Address(RVA = "0xF36B20", Offset = "0xF36B20", VA = "0xF36B20")]
	private bool _003CShowHistoryRecord_003Em__C(MatchRecordPersonal v)
	{
		return default(bool);
	}

	[Token(Token = "0x60115D8")]
	[Address(RVA = "0xF36B64", Offset = "0xF36B64", VA = "0xF36B64")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60115D9")]
	[Address(RVA = "0xF36B6C", Offset = "0xF36B6C", VA = "0xF36B6C")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x60115DA")]
	[Address(RVA = "0xF36B74", Offset = "0xF36B74", VA = "0xF36B74")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60115DB")]
	[Address(RVA = "0xF36B7C", Offset = "0xF36B7C", VA = "0xF36B7C")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x60115DC")]
	[Address(RVA = "0xF36B84", Offset = "0xF36B84", VA = "0xF36B84")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x60115DD")]
	[Address(RVA = "0xF36B8C", Offset = "0xF36B8C", VA = "0xF36B8C")]
	public void _003C_003EiFixBaseProxy_OnSendShowTimeEvent(ref string P0, ref EventLogger.EventPageDetentionTime P1)
	{
	}

	[Token(Token = "0x60115DE")]
	[Address(RVA = "0xF36B94", Offset = "0xF36B94", VA = "0xF36B94")]
	public List<string> _003C_003EiFixBaseProxy_GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	[Token(Token = "0x60115DF")]
	[Address(RVA = "0xF36B9C", Offset = "0xF36B9C", VA = "0xF36B9C")]
	public bool _003C_003EiFixBaseProxy_NeedWaitDataReady()
	{
		return default(bool);
	}

	[Token(Token = "0x60115E0")]
	[Address(RVA = "0xF36BA4", Offset = "0xF36BA4", VA = "0xF36BA4")]
	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x60115E1")]
	[Address(RVA = "0xF36BAC", Offset = "0xF36BAC", VA = "0xF36BAC")]
	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
