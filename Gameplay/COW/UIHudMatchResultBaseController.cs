using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002244")]
internal class UIHudMatchResultBaseController : UIHudResultShowBaseController
{
	[Token(Token = "0x2002245")]
	private sealed class _003CDelayCallFakeThumUpForBRTutorial_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D68A")]
		[FieldOffset(Offset = "0x8")]
		internal List<ulong> AIPlayerIDs;

		[Token(Token = "0x400D68B")]
		[FieldOffset(Offset = "0xC")]
		internal int _003Ccount_003E__0;

		[Token(Token = "0x400D68C")]
		[FieldOffset(Offset = "0x10")]
		internal int _003Ci_003E__1;

		[Token(Token = "0x400D68D")]
		[FieldOffset(Offset = "0x14")]
		internal int nums;

		[Token(Token = "0x400D68E")]
		[FieldOffset(Offset = "0x18")]
		internal int _003CAIPlayerIdIndex_003E__2;

		[Token(Token = "0x400D68F")]
		[FieldOffset(Offset = "0x1C")]
		internal object _0024current;

		[Token(Token = "0x400D690")]
		[FieldOffset(Offset = "0x20")]
		internal bool _0024disposing;

		[Token(Token = "0x400D691")]
		[FieldOffset(Offset = "0x24")]
		internal int _0024PC;

		[Token(Token = "0x17001069")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600BA54")]
			[Address(RVA = "0x19AD1C8", Offset = "0x19AD1C8", VA = "0x19AD1C8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700106A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BA55")]
			[Address(RVA = "0x19AD1D0", Offset = "0x19AD1D0", VA = "0x19AD1D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BA52")]
		[Address(RVA = "0x19ACE80", Offset = "0x19ACE80", VA = "0x19ACE80")]
		public _003CDelayCallFakeThumUpForBRTutorial_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600BA53")]
		[Address(RVA = "0x19ACE88", Offset = "0x19ACE88", VA = "0x19ACE88", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BA56")]
		[Address(RVA = "0x19AD1D8", Offset = "0x19AD1D8", VA = "0x19AD1D8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600BA57")]
		[Address(RVA = "0x19AD1EC", Offset = "0x19AD1EC", VA = "0x19AD1EC", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002246")]
	private sealed class _003CDelayCallFakeThumUpForCSTutorial_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D692")]
		[FieldOffset(Offset = "0x8")]
		internal List<ulong> AIPlayerIDs;

		[Token(Token = "0x400D693")]
		[FieldOffset(Offset = "0xC")]
		internal int _003Ccount_003E__0;

		[Token(Token = "0x400D694")]
		[FieldOffset(Offset = "0x10")]
		internal int _003Ci_003E__1;

		[Token(Token = "0x400D695")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x400D696")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x400D697")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x1700106B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600BA5A")]
			[Address(RVA = "0x19AD5B4", Offset = "0x19AD5B4", VA = "0x19AD5B4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700106C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BA5B")]
			[Address(RVA = "0x19AD5BC", Offset = "0x19AD5BC", VA = "0x19AD5BC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BA58")]
		[Address(RVA = "0x19AD274", Offset = "0x19AD274", VA = "0x19AD274")]
		public _003CDelayCallFakeThumUpForCSTutorial_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600BA59")]
		[Address(RVA = "0x19AD27C", Offset = "0x19AD27C", VA = "0x19AD27C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BA5C")]
		[Address(RVA = "0x19AD5C4", Offset = "0x19AD5C4", VA = "0x19AD5C4", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600BA5D")]
		[Address(RVA = "0x19AD5D8", Offset = "0x19AD5D8", VA = "0x19AD5D8", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002247")]
	private sealed class _003CMatchStatsValidationForUGC_003Ec__AnonStorey2
	{
		[Token(Token = "0x400D698")]
		[FieldOffset(Offset = "0x8")]
		internal UGCMatchStats ugcMatchStates;

		[Token(Token = "0x400D699")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudMatchResultBaseController _0024this;

		[Token(Token = "0x600BA5E")]
		[Address(RVA = "0x19AD660", Offset = "0x19AD660", VA = "0x19AD660")]
		public _003CMatchStatsValidationForUGC_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x600BA5F")]
		[Address(RVA = "0x19AD668", Offset = "0x19AD668", VA = "0x19AD668")]
		internal bool _003C_003Em__0(UGCTeamStats item)
		{
			return default(bool);
		}

		[Token(Token = "0x600BA60")]
		[Address(RVA = "0x19AD6E4", Offset = "0x19AD6E4", VA = "0x19AD6E4")]
		internal bool _003C_003Em__1(UGCPlayerStats item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400D62B")]
	protected const string ANIM_PARAM_BOOL_OPEN = "open";

	[Token(Token = "0x400D62C")]
	protected const string ANIM_PARAM_TRIGGER_CLOSE = "close";

	[Token(Token = "0x400D62D")]
	protected const string ANIM_PARAM_BOOL_DETAIL = "detail";

	[Token(Token = "0x400D62E")]
	private const int AUTO_SHOW_DETAIL_COUNTDOWN = 20;

	[Token(Token = "0x400D62F")]
	private const int AUTO_RETURN_LOBBY_COUNTDOWN = 30;

	[Token(Token = "0x400D630")]
	private const int DETAIL_BUTTON_CLICK_INTERVAL = 1;

	[Token(Token = "0x400D631")]
	public const int MAX_AVATAR_COUNT = 4;

	[Token(Token = "0x400D632")]
	public const int MAX_PENTA_AVATAR_COUNT = 5;

	[Token(Token = "0x400D633")]
	public const string RESULT_DATA_BTN_ICON = "UI_Result_Data_icon";

	[Token(Token = "0x400D634")]
	public const string RESULT_OVERVIEW_BTN_ICON = "UI_Result_Overview_icon";

	[Token(Token = "0x400D635")]
	[FieldOffset(Offset = "0x70")]
	protected EMatchResultPageType m_PageType;

	[Token(Token = "0x400D636")]
	[FieldOffset(Offset = "0x74")]
	private float m_CountDownTime;

	[Token(Token = "0x400D637")]
	[FieldOffset(Offset = "0x78")]
	private float m_CurrentDetailClickTime;

	[Token(Token = "0x400D638")]
	[FieldOffset(Offset = "0x7C")]
	private bool m_NoFoundMatchResult;

	[Token(Token = "0x400D639")]
	[FieldOffset(Offset = "0x7D")]
	private bool m_IsShowUIData;

	[Token(Token = "0x400D63A")]
	[FieldOffset(Offset = "0x7E")]
	private bool m_HasShowDetailUI;

	[Token(Token = "0x400D63B")]
	[FieldOffset(Offset = "0x7F")]
	private bool m_IsShowDetailUI;

	[Token(Token = "0x400D63C")]
	[FieldOffset(Offset = "0x80")]
	private bool m_DataBtnLog;

	[Token(Token = "0x400D63D")]
	[FieldOffset(Offset = "0x81")]
	private bool m_HasPopedAddFriendTips;

	[Token(Token = "0x400D63E")]
	[FieldOffset(Offset = "0x82")]
	private bool m_IsLastUGCMatchResultNotify;

	[Token(Token = "0x400D63F")]
	[FieldOffset(Offset = "0x84")]
	private TeammateStats m_MVPPlayerData;

	[Token(Token = "0x400D640")]
	[FieldOffset(Offset = "0x88")]
	protected bool m_BiaoqianState;

	[Token(Token = "0x400D641")]
	[FieldOffset(Offset = "0x8C")]
	private List<int> m_InfoTypeList;

	[Token(Token = "0x400D642")]
	[FieldOffset(Offset = "0x90")]
	private List<int> m_InfoTypeListData;

	[Token(Token = "0x400D643")]
	[FieldOffset(Offset = "0x94")]
	protected int[] InfoTypeForUGC;

	[Token(Token = "0x400D644")]
	[FieldOffset(Offset = "0x98")]
	private List<UIHudMatchResultItemBaseController> m_ItemCtrlList;

	[Token(Token = "0x400D645")]
	[FieldOffset(Offset = "0x9C")]
	protected Dictionary<ulong, ExtraPlayerDataForMatchResult> m_PlayerMatchResultDataMap;

	[Token(Token = "0x400D646")]
	[FieldOffset(Offset = "0xA0")]
	protected Dictionary<string, ExtraPlayerDataForMatchResult> m_ExtraMatchResultDatasForBot;

	[Token(Token = "0x400D647")]
	[FieldOffset(Offset = "0xA4")]
	private bool m_IsShowFastSendGift;

	[Token(Token = "0x400D648")]
	[FieldOffset(Offset = "0xA5")]
	private bool m_IsShowClanPopWnd;

	[Token(Token = "0x400D649")]
	[FieldOffset(Offset = "0xA6")]
	private bool m_HasWatchRewardVideo;

	[Token(Token = "0x400D64A")]
	[FieldOffset(Offset = "0xA7")]
	private bool m_IsSubscribeWorkshop;

	[Token(Token = "0x400D64B")]
	[FieldOffset(Offset = "0xA8")]
	private EMatchResultIsWin _003CIsWin_003Ek__BackingField;

	[Token(Token = "0x400D64C")]
	[FieldOffset(Offset = "0xAC")]
	private UIHudMatchResultStateMachine m_StateMachine;

	[Token(Token = "0x400D64D")]
	[FieldOffset(Offset = "0xB0")]
	private Camera m_ResultBGCamera;

	[Token(Token = "0x400D64E")]
	[FieldOffset(Offset = "0xB4")]
	private Camera m_ResultAvatarCamera;

	[Token(Token = "0x400D64F")]
	[FieldOffset(Offset = "0xB8")]
	private UIMaleAvatar m_MVPAvatar;

	[Token(Token = "0x400D650")]
	[FieldOffset(Offset = "0xBC")]
	protected UIBaseView BaseView;

	[Token(Token = "0x400D651")]
	[FieldOffset(Offset = "0xC0")]
	protected Transform BaseRewardRoot;

	[Token(Token = "0x400D652")]
	[FieldOffset(Offset = "0xC4")]
	protected Transform BaseCallSignContainer;

	[Token(Token = "0x400D653")]
	[FieldOffset(Offset = "0xC8")]
	protected UILabel GameModeTxt;

	[Token(Token = "0x400D654")]
	[FieldOffset(Offset = "0xCC")]
	protected UILabel GameMapTxt;

	[Token(Token = "0x400D655")]
	[FieldOffset(Offset = "0xD0")]
	protected UILabel TxtModeLeftCorner;

	[Token(Token = "0x400D656")]
	[FieldOffset(Offset = "0xD4")]
	protected UILabel TxtMapLeftCorner;

	[Token(Token = "0x400D657")]
	[FieldOffset(Offset = "0xD8")]
	protected Animator MatchResultAni;

	[Token(Token = "0x400D658")]
	[FieldOffset(Offset = "0xDC")]
	protected GameObject BiaoQianOB;

	[Token(Token = "0x400D659")]
	[FieldOffset(Offset = "0xE0")]
	private GameObject m_ShareInfoContainer;

	[Token(Token = "0x400D65A")]
	[FieldOffset(Offset = "0xE4")]
	protected GameObject LeftCorner;

	[Token(Token = "0x400D65B")]
	[FieldOffset(Offset = "0xE8")]
	protected GameObject RightCorner;

	[Token(Token = "0x400D65C")]
	[FieldOffset(Offset = "0xEC")]
	protected Transform m_ProfileFormationTran;

	[Token(Token = "0x400D65D")]
	[FieldOffset(Offset = "0xF0")]
	private UIButton m_ShareBtn;

	[Token(Token = "0x400D65E")]
	[FieldOffset(Offset = "0xF4")]
	private UITable m_BottomLeftTable;

	[Token(Token = "0x400D65F")]
	[FieldOffset(Offset = "0xF8")]
	private UIButton m_DetailBtn;

	[Token(Token = "0x400D660")]
	[FieldOffset(Offset = "0xFC")]
	private UIButton m_DataBtn;

	[Token(Token = "0x400D661")]
	[FieldOffset(Offset = "0x100")]
	private UIButton m_NextBtn;

	[Token(Token = "0x400D662")]
	[FieldOffset(Offset = "0x104")]
	protected UIButton m_ReplayBtn;

	[Token(Token = "0x400D663")]
	[FieldOffset(Offset = "0x108")]
	private UILabel m_ReplayTips;

	[Token(Token = "0x400D664")]
	[FieldOffset(Offset = "0x10C")]
	protected GameObject WorkShopGo;

	[Token(Token = "0x400D665")]
	[FieldOffset(Offset = "0x110")]
	protected UILabel NextBtnTime;

	[Token(Token = "0x400D666")]
	[FieldOffset(Offset = "0x114")]
	protected UILabel NextBtnLabel;

	[Token(Token = "0x400D667")]
	[FieldOffset(Offset = "0x118")]
	protected UILabel ResultDesc;

	[Token(Token = "0x400D668")]
	[FieldOffset(Offset = "0x11C")]
	protected UIWidget Biaoqian1;

	[Token(Token = "0x400D669")]
	[FieldOffset(Offset = "0x120")]
	protected UIWidget Biaoqian2;

	[Token(Token = "0x400D66A")]
	[FieldOffset(Offset = "0x124")]
	protected UIWidget Biaoqian3;

	[Token(Token = "0x400D66B")]
	[FieldOffset(Offset = "0x128")]
	protected UIWidget Biaoqian4;

	[Token(Token = "0x400D66C")]
	[FieldOffset(Offset = "0x12C")]
	protected UIWidget BiaoqianPlaceHolder;

	[Token(Token = "0x400D66D")]
	[FieldOffset(Offset = "0x130")]
	protected UIWidget Biaoqian1Share1;

	[Token(Token = "0x400D66E")]
	[FieldOffset(Offset = "0x134")]
	protected UIWidget Biaoqian1Share2;

	[Token(Token = "0x400D66F")]
	[FieldOffset(Offset = "0x138")]
	protected UIWidget Biaoqian1Share3;

	[Token(Token = "0x400D670")]
	[FieldOffset(Offset = "0x13C")]
	protected UIWidget Biaoqian1Share4;

	[Token(Token = "0x400D671")]
	[FieldOffset(Offset = "0x140")]
	protected UIGrid RewardBtnGrid;

	[Token(Token = "0x400D672")]
	[FieldOffset(Offset = "0x144")]
	private UIButton m_FastSendGiftBtn;

	[Token(Token = "0x400D673")]
	[FieldOffset(Offset = "0x148")]
	private UIButton m_VideoGiftBtn;

	[Token(Token = "0x400D674")]
	[FieldOffset(Offset = "0x14C")]
	private UIHudMatchResultLikePopupController likectrl;

	[Token(Token = "0x400D675")]
	[FieldOffset(Offset = "0x150")]
	private bool m_LikeSwitch;

	[Token(Token = "0x400D676")]
	[FieldOffset(Offset = "0x154")]
	private float m_likeInterval;

	[Token(Token = "0x400D677")]
	[FieldOffset(Offset = "0x158")]
	private float m_likeTimeSendStamp;

	[Token(Token = "0x400D678")]
	[FieldOffset(Offset = "0x15C")]
	private float m_showTimeStamp;

	[Token(Token = "0x400D679")]
	[FieldOffset(Offset = "0x160")]
	private float m_showTimeInterval;

	[Token(Token = "0x400D67A")]
	[FieldOffset(Offset = "0x164")]
	private List<ulong> m_ShowlikeAccountIds;

	[Token(Token = "0x400D67B")]
	[FieldOffset(Offset = "0x168")]
	private List<ulong> m_likeAccountIds;

	[Token(Token = "0x400D67C")]
	[FieldOffset(Offset = "0x16C")]
	private List<ulong> m_allAccountIds;

	[Token(Token = "0x400D67D")]
	[FieldOffset(Offset = "0x170")]
	private uint m_showlikesLimit;

	[Token(Token = "0x400D67E")]
	[FieldOffset(Offset = "0x174")]
	private uint showlikesLimitConfig;

	[Token(Token = "0x400D67F")]
	[FieldOffset(Offset = "0x178")]
	private ulong m_localPlayerID;

	[Token(Token = "0x400D680")]
	[FieldOffset(Offset = "0x180")]
	protected bool isTeamMode;

	[Token(Token = "0x400D681")]
	private const string Team_COLOR = "2993FFFF";

	[Token(Token = "0x400D682")]
	private const string Oppo_COLOR = "DD6C2EFF";

	[Token(Token = "0x400D683")]
	private const string Normal_COLOR = "FFBA00FF";

	[Token(Token = "0x400D684")]
	[FieldOffset(Offset = "0x184")]
	private UIHudMatchResultBaseRewardController m_UIBaseReward;

	[Token(Token = "0x400D685")]
	[FieldOffset(Offset = "0x188")]
	private UIHudMatchResultWorkShopPanelController m_WorkShopCtrl;

	[Token(Token = "0x400D686")]
	[FieldOffset(Offset = "0x0")]
	private static Func<PlayerData, AvatarProfileInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400D687")]
	[FieldOffset(Offset = "0x4")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400D688")]
	[FieldOffset(Offset = "0x8")]
	private static Predicate<uint> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x400D689")]
	[FieldOffset(Offset = "0xC")]
	private static Converter<TeammateStats, FriendInfo> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x17001058")]
	public bool HasPopedAddFriendTips
	{
		[Token(Token = "0x600B9DC")]
		[Address(RVA = "0x1004374", Offset = "0x1004374", VA = "0x1004374")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B9DD")]
		[Address(RVA = "0x10043CC", Offset = "0x10043CC", VA = "0x10043CC")]
		set
		{
		}
	}

	[Token(Token = "0x17001059")]
	public TeammateStats MVPPlayerData
	{
		[Token(Token = "0x600B9DE")]
		[Address(RVA = "0x100442C", Offset = "0x100442C", VA = "0x100442C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600B9DF")]
		[Address(RVA = "0x1004484", Offset = "0x1004484", VA = "0x1004484")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700105A")]
	protected List<int> InfoTypeList
	{
		[Token(Token = "0x600B9E0")]
		[Address(RVA = "0x10045D4", Offset = "0x10045D4", VA = "0x10045D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700105B")]
	protected List<int> InfoTypeListData
	{
		[Token(Token = "0x600B9E1")]
		[Address(RVA = "0x10046AC", Offset = "0x10046AC", VA = "0x10046AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700105C")]
	protected List<UIHudMatchResultItemBaseController> ItemCtrlList
	{
		[Token(Token = "0x600B9E3")]
		[Address(RVA = "0x10047FC", Offset = "0x10047FC", VA = "0x10047FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700105D")]
	protected Dictionary<ulong, ExtraPlayerDataForMatchResult> ExtraPlayerDataMap
	{
		[Token(Token = "0x600B9E4")]
		[Address(RVA = "0x10048D4", Offset = "0x10048D4", VA = "0x10048D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700105E")]
	protected EMatchResultIsWin IsWin
	{
		[Token(Token = "0x600B9E5")]
		[Address(RVA = "0x10049AC", Offset = "0x10049AC", VA = "0x10049AC")]
		get
		{
			return default(EMatchResultIsWin);
		}
		[Token(Token = "0x600B9E6")]
		[Address(RVA = "0x10049B4", Offset = "0x10049B4", VA = "0x10049B4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700105F")]
	protected GameObject ShareInfoContainer
	{
		[Token(Token = "0x600B9E7")]
		[Address(RVA = "0x10049BC", Offset = "0x10049BC", VA = "0x10049BC")]
		set
		{
		}
	}

	[Token(Token = "0x17001060")]
	protected UIButton ShareBtn
	{
		[Token(Token = "0x600B9E8")]
		[Address(RVA = "0x1004A40", Offset = "0x1004A40", VA = "0x1004A40")]
		set
		{
		}
	}

	[Token(Token = "0x17001061")]
	protected UITable BottomLeftTable
	{
		[Token(Token = "0x600B9E9")]
		[Address(RVA = "0x1004AB4", Offset = "0x1004AB4", VA = "0x1004AB4")]
		set
		{
		}
	}

	[Token(Token = "0x17001062")]
	protected UIButton DetailBtn
	{
		[Token(Token = "0x600B9EA")]
		[Address(RVA = "0x1004B3C", Offset = "0x1004B3C", VA = "0x1004B3C")]
		set
		{
		}
	}

	[Token(Token = "0x17001063")]
	protected UIButton DataBtn
	{
		[Token(Token = "0x600B9EB")]
		[Address(RVA = "0x1004C64", Offset = "0x1004C64", VA = "0x1004C64")]
		set
		{
		}
	}

	[Token(Token = "0x17001064")]
	protected UIButton NextBtn
	{
		[Token(Token = "0x600B9EC")]
		[Address(RVA = "0x1004DCC", Offset = "0x1004DCC", VA = "0x1004DCC")]
		set
		{
		}
	}

	[Token(Token = "0x17001065")]
	protected UIButton ReplayBtn
	{
		[Token(Token = "0x600B9ED")]
		[Address(RVA = "0x1004EF4", Offset = "0x1004EF4", VA = "0x1004EF4")]
		set
		{
		}
	}

	[Token(Token = "0x17001066")]
	protected UILabel ReplayTips
	{
		[Token(Token = "0x600B9EE")]
		[Address(RVA = "0x1004F94", Offset = "0x1004F94", VA = "0x1004F94")]
		set
		{
		}
	}

	[Token(Token = "0x17001067")]
	protected UIButton FastSendGiftBtn
	{
		[Token(Token = "0x600B9EF")]
		[Address(RVA = "0x1005184", Offset = "0x1005184", VA = "0x1005184")]
		set
		{
		}
	}

	[Token(Token = "0x17001068")]
	protected UIButton VideoGiftBtn
	{
		[Token(Token = "0x600B9F0")]
		[Address(RVA = "0x10052AC", Offset = "0x10052AC", VA = "0x10052AC")]
		set
		{
		}
	}

	[Token(Token = "0x600B9DB")]
	[Address(RVA = "0x1004258", Offset = "0x1004258", VA = "0x1004258")]
	public UIHudMatchResultBaseController()
	{
	}

	[Token(Token = "0x600B9E2")]
	[Address(RVA = "0x1004784", Offset = "0x1004784", VA = "0x1004784")]
	public List<int> GetCurrentInfoTypeList()
	{
		return null;
	}

	[Token(Token = "0x600B9F1")]
	[Address(RVA = "0x10053D4", Offset = "0x10053D4", VA = "0x10053D4")]
	public void Update()
	{
	}

	[Token(Token = "0x600B9F2")]
	[Address(RVA = "0x1006BE4", Offset = "0x1006BE4", VA = "0x1006BE4")]
	public void GenerateMatchResultForSpectator()
	{
	}

	[Token(Token = "0x600B9F3")]
	[Address(RVA = "0x10073FC", Offset = "0x10073FC", VA = "0x10073FC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B9F4")]
	[Address(RVA = "0x1007C80", Offset = "0x1007C80", VA = "0x1007C80", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600B9F5")]
	[Address(RVA = "0x1007994", Offset = "0x1007994", VA = "0x1007994")]
	private void InitLikeInfo()
	{
	}

	[Token(Token = "0x600B9F6")]
	[Address(RVA = "0x10080C4", Offset = "0x10080C4", VA = "0x10080C4", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600B9F7")]
	[Address(RVA = "0x100918C", Offset = "0x100918C", VA = "0x100918C", Slot = "33")]
	protected sealed override void OnMatchStatsChange(MatchStats stats, MatchIncome income)
	{
	}

	[Token(Token = "0x600B9F8")]
	[Address(RVA = "0x1009300", Offset = "0x1009300", VA = "0x1009300", Slot = "38")]
	public sealed override void CreateProfileCallSign(AvatarProfileInfo data, int index)
	{
	}

	[Token(Token = "0x600B9F9")]
	[Address(RVA = "0x1009948", Offset = "0x1009948", VA = "0x1009948", Slot = "40")]
	protected sealed override void PrepareShowAvatarData(out List<PlayerData> avatarData, out List<AvatarProfileInfo> profileData)
	{
	}

	[Token(Token = "0x600B9FA")]
	[Address(RVA = "0x100A588", Offset = "0x100A588", VA = "0x100A588")]
	private void PrepareShowAvatarDataInternal(out List<PlayerData> avatarData, out List<AvatarProfileInfo> profileData)
	{
	}

	[Token(Token = "0x600B9FB")]
	[Address(RVA = "0x1009A60", Offset = "0x1009A60", VA = "0x1009A60")]
	private void PrepareShowAvatarDataInternalForUGC(out List<PlayerData> avatarData, out List<AvatarProfileInfo> profileData)
	{
	}

	[Token(Token = "0x600B9FC")]
	[Address(RVA = "0x100AAC0", Offset = "0x100AAC0", VA = "0x100AAC0", Slot = "37")]
	protected sealed override void ReturnToLobby()
	{
	}

	[Token(Token = "0x600B9FD")]
	[Address(RVA = "0x100B480", Offset = "0x100B480", VA = "0x100B480", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x600B9FE")]
	[Address(RVA = "0x100BD30", Offset = "0x100BD30", VA = "0x100BD30", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x600B9FF")]
	[Address(RVA = "0x100C644", Offset = "0x100C644", VA = "0x100C644")]
	protected void RepositionRewardBtnGrid()
	{
	}

	[Token(Token = "0x600BA00")]
	[Address(RVA = "0x100C748", Offset = "0x100C748", VA = "0x100C748")]
	public static TeamTotalStats CalcTeamTotalStatsInfo(List<TeammateStats> players)
	{
		return default(TeamTotalStats);
	}

	[Token(Token = "0x600BA01")]
	[Address(RVA = "0x100C984", Offset = "0x100C984", VA = "0x100C984")]
	protected void UpdateFakeLike(uint rank, uint kills = 0u)
	{
	}

	[Token(Token = "0x600BA02")]
	[Address(RVA = "0x100CB48", Offset = "0x100CB48", VA = "0x100CB48")]
	private IEnumerator DelayCallFakeThumUpForBRTutorial(int nums, List<ulong> AIPlayerIDs)
	{
		return null;
	}

	[Token(Token = "0x600BA03")]
	[Address(RVA = "0x100CC4C", Offset = "0x100CC4C", VA = "0x100CC4C")]
	private IEnumerator DelayCallFakeThumUpForCSTutorial(List<ulong> AIPlayerIDs)
	{
		return null;
	}

	[Token(Token = "0x600BA04")]
	[Address(RVA = "0x100CD20", Offset = "0x100CD20", VA = "0x100CD20")]
	protected void UpdateInfoTitle(UILabel infoTxt, int index)
	{
	}

	[Token(Token = "0x600BA05")]
	[Address(RVA = "0x100DDAC", Offset = "0x100DDAC", VA = "0x100DDAC")]
	protected void UpdateInfoTitle(UISprite infoSprite, int index)
	{
	}

	[Token(Token = "0x600BA06")]
	[Address(RVA = "0x100E454", Offset = "0x100E454", VA = "0x100E454")]
	public void UpdateInfoTitleForUGC(UILabel label, int index)
	{
	}

	[Token(Token = "0x600BA07")]
	protected T OpenPlayerItemUI<T>(Transform parent, TeammateStats data, bool single) where T : UIHudMatchResultItemBaseController
	{
		return null;
	}

	[Token(Token = "0x600BA08")]
	public T OpenPlayerItemUI<T>(Transform parent, UGCPlayerStats stats, bool single) where T : UIHudMatchResultItemBaseController
	{
		return null;
	}

	[Token(Token = "0x600BA09")]
	[Address(RVA = "0x100E5F4", Offset = "0x100E5F4", VA = "0x100E5F4")]
	protected void FillTeammateStatsToPlayerData(TeammateStats stats, PlayerData player)
	{
	}

	[Token(Token = "0x600BA0A")]
	[Address(RVA = "0x100E75C", Offset = "0x100E75C", VA = "0x100E75C")]
	protected void FillMatchStatsToPlayerData(MatchStats stats, PlayerData player)
	{
	}

	[Token(Token = "0x600BA0B")]
	[Address(RVA = "0x100E8BC", Offset = "0x100E8BC", VA = "0x100E8BC")]
	protected ExtraPlayerDataForMatchResult GetExtraPlayerDataForMatchResult(ulong accountID)
	{
		return null;
	}

	[Token(Token = "0x600BA0C")]
	[Address(RVA = "0x100E9D0", Offset = "0x100E9D0", VA = "0x100E9D0")]
	private void SetMapAndModeInfo()
	{
	}

	[Token(Token = "0x600BA0D")]
	[Address(RVA = "0x10054F4", Offset = "0x10054F4", VA = "0x10054F4")]
	private bool CanUpdateCountDown()
	{
		return default(bool);
	}

	[Token(Token = "0x600BA0E")]
	[Address(RVA = "0x100F2D4", Offset = "0x100F2D4", VA = "0x100F2D4")]
	private void CreateExtraPlayerDataForAllPlayers(MatchStats stats)
	{
	}

	[Token(Token = "0x600BA0F")]
	[Address(RVA = "0x10085B0", Offset = "0x10085B0", VA = "0x10085B0")]
	protected void ShowMatchResultUIData(MatchIncome income, MatchStats stats)
	{
	}

	[Token(Token = "0x600BA10")]
	[Address(RVA = "0x1010C98", Offset = "0x1010C98", VA = "0x1010C98")]
	private void ShowBiaoqianWindow(MatchIncome income, MatchStats stats)
	{
	}

	[Token(Token = "0x600BA11")]
	[Address(RVA = "0x1011A68", Offset = "0x1011A68", VA = "0x1011A68")]
	private void OnStateMachineFinish()
	{
	}

	[Token(Token = "0x600BA12")]
	[Address(RVA = "0x10120A4", Offset = "0x10120A4", VA = "0x10120A4")]
	private void CheckAndPopFriendRecommand()
	{
	}

	[Token(Token = "0x600BA13")]
	[Address(RVA = "0x101253C", Offset = "0x101253C", VA = "0x101253C")]
	private PlayerData GetCanRecommonedData()
	{
		return null;
	}

	[Token(Token = "0x600BA14")]
	[Address(RVA = "0x1005670", Offset = "0x1005670", VA = "0x1005670")]
	private void OnClickNextBtn()
	{
	}

	[Token(Token = "0x600BA15")]
	[Address(RVA = "0x1012CF8", Offset = "0x1012CF8", VA = "0x1012CF8")]
	private void OnClickReplayBtn()
	{
	}

	[Token(Token = "0x600BA16")]
	[Address(RVA = "0x1013564", Offset = "0x1013564", VA = "0x1013564")]
	private void OnClickDetailsBtn()
	{
	}

	[Token(Token = "0x600BA17")]
	[Address(RVA = "0x1013954", Offset = "0x1013954", VA = "0x1013954")]
	private void OnClickDataBtn()
	{
	}

	[Token(Token = "0x600BA18")]
	[Address(RVA = "0x1013BA4", Offset = "0x1013BA4", VA = "0x1013BA4")]
	private void OnClickFastSendGiftBtn()
	{
	}

	[Token(Token = "0x600BA19")]
	[Address(RVA = "0x1013DE0", Offset = "0x1013DE0", VA = "0x1013DE0")]
	private void OnClickVideoGiftBtn()
	{
	}

	[Token(Token = "0x600BA1A")]
	[Address(RVA = "0x1011E60", Offset = "0x1011E60", VA = "0x1011E60")]
	private void ShowAvatarInfoUI()
	{
	}

	[Token(Token = "0x600BA1B")]
	[Address(RVA = "0x10145B8", Offset = "0x10145B8", VA = "0x10145B8", Slot = "41")]
	protected virtual bool GetDataBtnVisibility()
	{
		return default(bool);
	}

	[Token(Token = "0x600BA1C")]
	[Address(RVA = "0x10128DC", Offset = "0x10128DC", VA = "0x10128DC")]
	protected void ShowDetailUI()
	{
	}

	[Token(Token = "0x600BA1D")]
	[Address(RVA = "0x10136E4", Offset = "0x10136E4", VA = "0x10136E4")]
	protected void HideDetailUI()
	{
	}

	[Token(Token = "0x600BA1E")]
	[Address(RVA = "0x101089C", Offset = "0x101089C", VA = "0x101089C")]
	private void CheckNeedShowRewardBtn()
	{
	}

	[Token(Token = "0x600BA1F")]
	[Address(RVA = "0x10146AC", Offset = "0x10146AC", VA = "0x10146AC")]
	private void OnWatchVideoSuccess(object[] param)
	{
	}

	[Token(Token = "0x600BA20")]
	[Address(RVA = "0x1014760", Offset = "0x1014760", VA = "0x1014760")]
	private void OnFastSendGiftPanelClose(object[] data)
	{
	}

	[Token(Token = "0x600BA21")]
	[Address(RVA = "0x10147C4", Offset = "0x10147C4", VA = "0x10147C4")]
	private void ShowClanMatchResult(object[] data)
	{
	}

	[Token(Token = "0x600BA22")]
	[Address(RVA = "0x1014934", Offset = "0x1014934", VA = "0x1014934")]
	public void SetTimeCutDown(object[] data)
	{
	}

	[Token(Token = "0x600BA23")]
	[Address(RVA = "0x1014998", Offset = "0x1014998", VA = "0x1014998", Slot = "42")]
	protected virtual void SetResultDescTextByRank(MatchStats stats)
	{
	}

	[Token(Token = "0x600BA24")]
	[Address(RVA = "0x100FC84", Offset = "0x100FC84", VA = "0x100FC84")]
	private void AddExtraPlayerDataForMatchResult(ulong accountID, ulong localPlayerID, bool isFriend = false, string region = "", string nickName = "")
	{
	}

	[Token(Token = "0x600BA25")]
	[Address(RVA = "0x10083B0", Offset = "0x10083B0", VA = "0x10083B0")]
	private void OnMatchResultNoResultFound(object[] data)
	{
	}

	[Token(Token = "0x600BA26")]
	[Address(RVA = "0x1014F74", Offset = "0x1014F74", VA = "0x1014F74")]
	private void OnMatchResultLikeCountChange(object[] data)
	{
	}

	[Token(Token = "0x600BA27")]
	[Address(RVA = "0x1005AD0", Offset = "0x1005AD0", VA = "0x1005AD0")]
	private void SendLikeAccountIds()
	{
	}

	[Token(Token = "0x600BA28")]
	[Address(RVA = "0x10151B0", Offset = "0x10151B0", VA = "0x10151B0")]
	private void OnMatchResultFakeLikeRec(object[] data)
	{
	}

	[Token(Token = "0x600BA29")]
	[Address(RVA = "0x1015460", Offset = "0x1015460", VA = "0x1015460")]
	private void OnMatchResultLikeRec(object[] data)
	{
	}

	[Token(Token = "0x600BA2A")]
	[Address(RVA = "0x100643C", Offset = "0x100643C", VA = "0x100643C")]
	private void ShowLikeListPopup()
	{
	}

	[Token(Token = "0x600BA2B")]
	[Address(RVA = "0x1015910", Offset = "0x1015910", VA = "0x1015910")]
	private void ShowLikePopup(string msg)
	{
	}

	[Token(Token = "0x600BA2C")]
	[Address(RVA = "0x1011640", Offset = "0x1011640", VA = "0x1011640")]
	private void CreateMVPAvatarInMatchResult(List<PlayerData> players, bool win)
	{
	}

	[Token(Token = "0x600BA2D")]
	[Address(RVA = "0x1010438", Offset = "0x1010438", VA = "0x1010438")]
	private bool MatchStatsValidationForUGC()
	{
		return default(bool);
	}

	[Token(Token = "0x600BA2E")]
	[Address(RVA = "0x1015AA4", Offset = "0x1015AA4", VA = "0x1015AA4", Slot = "43")]
	protected virtual int SortPlayerData(PlayerData player1, PlayerData player2)
	{
		return default(int);
	}

	[Token(Token = "0x600BA2F")]
	[Address(RVA = "0x1015B6C", Offset = "0x1015B6C", VA = "0x1015B6C", Slot = "44")]
	protected virtual int SortTeammateData(TeammateStats player1, TeammateStats player2)
	{
		return default(int);
	}

	[Token(Token = "0x600BA30")]
	[Address(RVA = "0x1015C34", Offset = "0x1015C34", VA = "0x1015C34", Slot = "45")]
	protected virtual int[] GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x600BA31")]
	[Address(RVA = "0x1015C8C", Offset = "0x1015C8C", VA = "0x1015C8C", Slot = "46")]
	protected virtual int[] GetInfoTypesData()
	{
		return null;
	}

	[Token(Token = "0x600BA32")]
	[Address(RVA = "0x1010798", Offset = "0x1010798", VA = "0x1010798")]
	protected int[] GetInfoTypesForUGC(UGCMatchStats stats)
	{
		return null;
	}

	[Token(Token = "0x600BA33")]
	[Address(RVA = "0x1015D5C", Offset = "0x1015D5C", VA = "0x1015D5C", Slot = "47")]
	protected virtual void OnChangePageType()
	{
	}

	[Token(Token = "0x600BA34")]
	[Address(RVA = "0x1015E88", Offset = "0x1015E88", VA = "0x1015E88", Slot = "48")]
	protected virtual void RefreshDetailUI(MatchStats stats)
	{
	}

	[Token(Token = "0x600BA35")]
	[Address(RVA = "0x1015EE4", Offset = "0x1015EE4", VA = "0x1015EE4", Slot = "49")]
	protected virtual void OnShowDetailUI(bool show)
	{
	}

	[Token(Token = "0x600BA36")]
	[Address(RVA = "0x1015F40", Offset = "0x1015F40", VA = "0x1015F40", Slot = "50")]
	protected virtual void OnShowAvatarInfoUI()
	{
	}

	[Token(Token = "0x600BA37")]
	[Address(RVA = "0x1015F94", Offset = "0x1015F94", VA = "0x1015F94", Slot = "51")]
	protected virtual void OnUpdate(float delta)
	{
	}

	[Token(Token = "0x600BA38")]
	[Address(RVA = "0x1015FF0", Offset = "0x1015FF0", VA = "0x1015FF0", Slot = "52")]
	protected virtual List<PlayerData> CreateShowAvatarPlayerData()
	{
		return null;
	}

	[Token(Token = "0x600BA39")]
	[Address(RVA = "0x10165F4", Offset = "0x10165F4", VA = "0x10165F4", Slot = "53")]
	protected virtual EMatchResultIsWin CheckIsWin(MatchStats stats)
	{
		return default(EMatchResultIsWin);
	}

	[Token(Token = "0x600BA3A")]
	[Address(RVA = "0x1010808", Offset = "0x1010808", VA = "0x1010808")]
	protected EMatchResultIsWin CheckIsWinForUGC(MatchStats stats)
	{
		return default(EMatchResultIsWin);
	}

	[Token(Token = "0x600BA3B")]
	[Address(RVA = "0x1016674", Offset = "0x1016674", VA = "0x1016674", Slot = "54")]
	protected virtual bool CheckIsWinTeamPlayerForSpectator(IHAAMHPPLMG playerID)
	{
		return default(bool);
	}

	[Token(Token = "0x600BA3C")]
	[Address(RVA = "0x101670C", Offset = "0x101670C", VA = "0x101670C", Slot = "55")]
	protected virtual void OnFixMatchInfoForLanguage()
	{
	}

	[Token(Token = "0x600BA3D")]
	[Address(RVA = "0x1016760", Offset = "0x1016760", VA = "0x1016760", Slot = "56")]
	protected virtual bool IsNeedShowAvatar()
	{
		return default(bool);
	}

	[Token(Token = "0x600BA3E")]
	[Address(RVA = "0x100DF2C", Offset = "0x100DF2C", VA = "0x100DF2C")]
	public static string SetMatchResultPlayerInfoString(UISprite sprite, EMatchResultPlayerInfoType type)
	{
		return null;
	}

	[Token(Token = "0x600BA3F")]
	[Address(RVA = "0x100CEA0", Offset = "0x100CEA0", VA = "0x100CEA0")]
	public static string SetMatchResultPlayerInfoString(UILabel label, EMatchResultPlayerInfoType type)
	{
		return null;
	}

	[Token(Token = "0x600BA40")]
	[Address(RVA = "0x10167B8", Offset = "0x10167B8", VA = "0x10167B8")]
	private void _003COnUIOpen_003Em__0(bool res)
	{
	}

	[Token(Token = "0x600BA41")]
	[Address(RVA = "0x10167C0", Offset = "0x10167C0", VA = "0x10167C0")]
	private bool _003CPrepareShowAvatarDataInternal_003Em__1(PlayerData item)
	{
		return default(bool);
	}

	[Token(Token = "0x600BA42")]
	[Address(RVA = "0x1016814", Offset = "0x1016814", VA = "0x1016814")]
	private static AvatarProfileInfo _003CPrepareShowAvatarDataInternal_003Em__2(PlayerData x)
	{
		return null;
	}

	[Token(Token = "0x600BA43")]
	[Address(RVA = "0x1016888", Offset = "0x1016888", VA = "0x1016888")]
	private bool _003CPrepareShowAvatarDataInternalForUGC_003Em__3(UGCTeamStats item)
	{
		return default(bool);
	}

	[Token(Token = "0x600BA44")]
	[Address(RVA = "0x10168F0", Offset = "0x10168F0", VA = "0x10168F0")]
	private bool _003CPrepareShowAvatarDataInternalForUGC_003Em__4(UGCPlayerStats x)
	{
		return default(bool);
	}

	[Token(Token = "0x600BA45")]
	[Address(RVA = "0x1016958", Offset = "0x1016958", VA = "0x1016958")]
	private bool _003CPrepareShowAvatarDataInternalForUGC_003Em__5(PlayerData item)
	{
		return default(bool);
	}

	[Token(Token = "0x600BA46")]
	[Address(RVA = "0x10169C0", Offset = "0x10169C0", VA = "0x10169C0")]
	private static void _003CReturnToLobby_003Em__6(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x600BA47")]
	[Address(RVA = "0x10169C4", Offset = "0x10169C4", VA = "0x10169C4")]
	private static bool _003CCheckAndPopFriendRecommand_003Em__7(uint type)
	{
		return default(bool);
	}

	[Token(Token = "0x600BA48")]
	[Address(RVA = "0x10169D0", Offset = "0x10169D0", VA = "0x10169D0")]
	private static FriendInfo _003COnClickFastSendGiftBtn_003Em__8(TeammateStats teamMate)
	{
		return null;
	}

	[Token(Token = "0x600BA49")]
	[Address(RVA = "0x10169D8", Offset = "0x10169D8", VA = "0x10169D8")]
	private bool _003CSetResultDescTextByRank_003Em__9(UGCTeamStats item)
	{
		return default(bool);
	}

	[Token(Token = "0x600BA4A")]
	[Address(RVA = "0x1016A40", Offset = "0x1016A40", VA = "0x1016A40")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600BA4B")]
	[Address(RVA = "0x1016A48", Offset = "0x1016A48", VA = "0x1016A48")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BA4C")]
	[Address(RVA = "0x1016A50", Offset = "0x1016A50", VA = "0x1016A50")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600BA4D")]
	[Address(RVA = "0x1016A58", Offset = "0x1016A58", VA = "0x1016A58")]
	public void _003C_003EiFixBaseProxy_OnMatchStatsChange(MatchStats P0, MatchIncome P1)
	{
	}

	[Token(Token = "0x600BA4E")]
	[Address(RVA = "0x1016A60", Offset = "0x1016A60", VA = "0x1016A60")]
	public void _003C_003EiFixBaseProxy_PrepareShowAvatarData(out List<PlayerData> P0, out List<AvatarProfileInfo> P1)
	{
	}

	[Token(Token = "0x600BA4F")]
	[Address(RVA = "0x1016A68", Offset = "0x1016A68", VA = "0x1016A68")]
	public void _003C_003EiFixBaseProxy_ReturnToLobby()
	{
	}

	[Token(Token = "0x600BA50")]
	[Address(RVA = "0x1016A70", Offset = "0x1016A70", VA = "0x1016A70")]
	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x600BA51")]
	[Address(RVA = "0x1016A78", Offset = "0x1016A78", VA = "0x1016A78")]
	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
