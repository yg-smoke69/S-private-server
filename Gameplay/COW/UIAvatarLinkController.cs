using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20024AE")]
public class UIAvatarLinkController : UIPreviewNavigationController, _Attribute, IConvertible
{
	[Token(Token = "0x20024AF")]
	private struct UICommonGuideData
	{
		[Token(Token = "0x400E375")]
		[FieldOffset(Offset = "0x0")]
		public string PlayerPrefKey;

		[Token(Token = "0x400E376")]
		[FieldOffset(Offset = "0x4")]
		public CommonGuideSetting Setting;

		[Token(Token = "0x400E377")]
		[FieldOffset(Offset = "0x8")]
		public UIButton FinishGuideBtn;

		[Token(Token = "0x400E378")]
		[FieldOffset(Offset = "0xC")]
		public UIWidget GuidingWidget;

		[Token(Token = "0x400E379")]
		[FieldOffset(Offset = "0x10")]
		public Side Side;
	}

	[Token(Token = "0x20024B0")]
	private sealed class _003CDelayHideBubblePanel_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400E37A")]
		[FieldOffset(Offset = "0x8")]
		internal float _003Cseconds_003E__0;

		[Token(Token = "0x400E37B")]
		[FieldOffset(Offset = "0xC")]
		internal UIAvatarLinkController _0024this;

		[Token(Token = "0x400E37C")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400E37D")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400E37E")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x17001127")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600D263")]
			[Address(RVA = "0x2A962BC", Offset = "0x2A962BC", VA = "0x2A962BC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001128")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600D264")]
			[Address(RVA = "0x2A962C4", Offset = "0x2A962C4", VA = "0x2A962C4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600D261")]
		[Address(RVA = "0x2A91B20", Offset = "0x2A91B20", VA = "0x2A91B20")]
		public _003CDelayHideBubblePanel_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600D262")]
		[Address(RVA = "0x2A9617C", Offset = "0x2A9617C", VA = "0x2A9617C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600D265")]
		[Address(RVA = "0x2A962CC", Offset = "0x2A962CC", VA = "0x2A962CC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600D266")]
		[Address(RVA = "0x2A962E0", Offset = "0x2A962E0", VA = "0x2A962E0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20024B1")]
	private sealed class _003CMoveRightPanelOnExpandCollapse_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400E37F")]
		[FieldOffset(Offset = "0x8")]
		internal Vector3 _003CtoPos_003E__0;

		[Token(Token = "0x400E380")]
		[FieldOffset(Offset = "0x14")]
		internal UIAvatarLinkController _0024this;

		[Token(Token = "0x400E381")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x400E382")]
		[FieldOffset(Offset = "0x1C")]
		internal bool _0024disposing;

		[Token(Token = "0x400E383")]
		[FieldOffset(Offset = "0x20")]
		internal int _0024PC;

		[Token(Token = "0x17001129")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600D269")]
			[Address(RVA = "0x2A965DC", Offset = "0x2A965DC", VA = "0x2A965DC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700112A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600D26A")]
			[Address(RVA = "0x2A965E4", Offset = "0x2A965E4", VA = "0x2A965E4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600D267")]
		[Address(RVA = "0x2A91BF4", Offset = "0x2A91BF4", VA = "0x2A91BF4")]
		public _003CMoveRightPanelOnExpandCollapse_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600D268")]
		[Address(RVA = "0x2A96368", Offset = "0x2A96368", VA = "0x2A96368", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600D26B")]
		[Address(RVA = "0x2A965EC", Offset = "0x2A965EC", VA = "0x2A965EC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600D26C")]
		[Address(RVA = "0x2A96600", Offset = "0x2A96600", VA = "0x2A96600", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20024B2")]
	private sealed class _003CPlayProgressChangedByDonateVFX_003Ec__Iterator2 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400E384")]
		[FieldOffset(Offset = "0x8")]
		internal Vector3 _003CfromPos_003E__0;

		[Token(Token = "0x400E385")]
		[FieldOffset(Offset = "0x14")]
		internal Vector3 _003CtoPos_003E__0;

		[Token(Token = "0x400E386")]
		[FieldOffset(Offset = "0x20")]
		internal uint _003CsavedProgress_003E__0;

		[Token(Token = "0x400E387")]
		[FieldOffset(Offset = "0x24")]
		internal uint _003CsavedTarget_003E__0;

		[Token(Token = "0x400E388")]
		[FieldOffset(Offset = "0x28")]
		internal float _003CsavedProgressValue_003E__0;

		[Token(Token = "0x400E389")]
		[FieldOffset(Offset = "0x2C")]
		internal float _003Clast_003E__0;

		[Token(Token = "0x400E38A")]
		[FieldOffset(Offset = "0x30")]
		internal uint oldValue;

		[Token(Token = "0x400E38B")]
		[FieldOffset(Offset = "0x34")]
		internal float _003CbaseValueF_003E__0;

		[Token(Token = "0x400E38C")]
		[FieldOffset(Offset = "0x38")]
		internal float _003CbaseValueUniF_003E__0;

		[Token(Token = "0x400E38D")]
		[FieldOffset(Offset = "0x3C")]
		internal uint newValue;

		[Token(Token = "0x400E38E")]
		[FieldOffset(Offset = "0x40")]
		internal float _003Cincrement_003E__0;

		[Token(Token = "0x400E38F")]
		[FieldOffset(Offset = "0x44")]
		internal float _003CincrementUni_003E__0;

		[Token(Token = "0x400E390")]
		[FieldOffset(Offset = "0x48")]
		internal float _003Cpercent_003E__1;

		[Token(Token = "0x400E391")]
		[FieldOffset(Offset = "0x4C")]
		internal int _003Cprogress_003E__1;

		[Token(Token = "0x400E392")]
		[FieldOffset(Offset = "0x50")]
		internal UIAvatarLinkController _0024this;

		[Token(Token = "0x400E393")]
		[FieldOffset(Offset = "0x54")]
		internal object _0024current;

		[Token(Token = "0x400E394")]
		[FieldOffset(Offset = "0x58")]
		internal bool _0024disposing;

		[Token(Token = "0x400E395")]
		[FieldOffset(Offset = "0x5C")]
		internal int _0024PC;

		[Token(Token = "0x1700112B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600D26F")]
			[Address(RVA = "0x2A97C08", Offset = "0x2A97C08", VA = "0x2A97C08", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700112C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600D270")]
			[Address(RVA = "0x2A97C10", Offset = "0x2A97C10", VA = "0x2A97C10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600D26D")]
		[Address(RVA = "0x2A91D14", Offset = "0x2A91D14", VA = "0x2A91D14")]
		public _003CPlayProgressChangedByDonateVFX_003Ec__Iterator2()
		{
		}

		[Token(Token = "0x600D26E")]
		[Address(RVA = "0x2A970EC", Offset = "0x2A970EC", VA = "0x2A970EC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600D271")]
		[Address(RVA = "0x2A97C18", Offset = "0x2A97C18", VA = "0x2A97C18", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600D272")]
		[Address(RVA = "0x2A97C2C", Offset = "0x2A97C2C", VA = "0x2A97C2C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20024B3")]
	private sealed class _003COnNavigationShowSequence_003Ec__Iterator3 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400E396")]
		[FieldOffset(Offset = "0x8")]
		internal Vector3 _003CstartupPos_003E__0;

		[Token(Token = "0x400E397")]
		[FieldOffset(Offset = "0x14")]
		internal float _003Cduration_003E__0;

		[Token(Token = "0x400E398")]
		[FieldOffset(Offset = "0x18")]
		internal bool _003CisBubbleShown_003E__0;

		[Token(Token = "0x400E399")]
		[FieldOffset(Offset = "0x1C")]
		internal UIAvatarLinkController _0024this;

		[Token(Token = "0x400E39A")]
		[FieldOffset(Offset = "0x20")]
		internal object _0024current;

		[Token(Token = "0x400E39B")]
		[FieldOffset(Offset = "0x24")]
		internal bool _0024disposing;

		[Token(Token = "0x400E39C")]
		[FieldOffset(Offset = "0x28")]
		internal int _0024PC;

		[Token(Token = "0x1700112D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600D275")]
			[Address(RVA = "0x2A97040", Offset = "0x2A97040", VA = "0x2A97040", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700112E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600D276")]
			[Address(RVA = "0x2A97048", Offset = "0x2A97048", VA = "0x2A97048", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600D273")]
		[Address(RVA = "0x2A91DE8", Offset = "0x2A91DE8", VA = "0x2A91DE8")]
		public _003COnNavigationShowSequence_003Ec__Iterator3()
		{
		}

		[Token(Token = "0x600D274")]
		[Address(RVA = "0x2A96688", Offset = "0x2A96688", VA = "0x2A96688", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600D277")]
		[Address(RVA = "0x2A97050", Offset = "0x2A97050", VA = "0x2A97050", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600D278")]
		[Address(RVA = "0x2A97064", Offset = "0x2A97064", VA = "0x2A97064", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400E342")]
	private const string GUIDE_LIST_KEY_STEP2 = "UIAvatarLinkGuide_Step2";

	[Token(Token = "0x400E343")]
	private const string GUIDE_LIST_KEY_STEP3 = "UIAvatarLinkGuide_Step3";

	[Token(Token = "0x400E344")]
	private const string GUIDE_LIST_KEY_STEP4 = "UIAvatarLinkGuide_Step4";

	[Token(Token = "0x400E345")]
	public const string NAVIGATION_TITLE_KEY = "T_33_LC_LINK_TITLE";

	[Token(Token = "0x400E346")]
	private const string ACTIVE_SKILL_TYPE_KEY = "T_22_A_SKILL_A";

	[Token(Token = "0x400E347")]
	private const string PASSIVE_SKILL_TYPE_KEY = "T_22_A_SKILL_P";

	[Token(Token = "0x400E348")]
	private const string SYSTEM_HELP_TIPS_KEY = "T_33_LC_LINK_HELP";

	[Token(Token = "0x400E349")]
	private const string LINKED_ACQUISITION_HELP_TIPS_KEY = "T_33_LC_LINK_NUMBER_HELP";

	[Token(Token = "0x400E34A")]
	private const string NOT_LINKED_ACQUISITION_HELP_TIPS_KEY = "T_33_LC_LINK_NUMBER_HELP2";

	[Token(Token = "0x400E34B")]
	private const string NORMAL_LINK_BTN_KEY = "T_33_LC_LINK_LINKBUTTON";

	[Token(Token = "0x400E34C")]
	private const string RELINK_BTN_KEY = "T_33_LC_LINK_RELINKBUTTON";

	[Token(Token = "0x400E34D")]
	private const string RECEIVE_BTN_KEY = "T_33_LC_LINK_RECEIVEBUTTON";

	[Token(Token = "0x400E34E")]
	private const string DONATE_LIMIT_KEY = "T_33_LC_LINK_EXCHANGE_QUANTITY";

	[Token(Token = "0x400E34F")]
	private const string LINK_POPUP_CONTENT_KEY = "T_33_LC_LINK_SELECT";

	[Token(Token = "0x400E350")]
	private const string RELINK_POPUP_CONTENT_KEY = "T_33_LC_LINK_RESELECT";

	[Token(Token = "0x400E351")]
	private const string DONATE_POPUP_CONTENT_KEY = "T_33_LC_LINK_EXCHANGE_HINT";

	[Token(Token = "0x400E352")]
	private const string COMMON_POPUP_TITLE_KEY = "T_20_P_CONFIRM_TITLE";

	[Token(Token = "0x400E353")]
	private const string LINK_PROGRESS_FORMAT_STR = "[808080][FFBA00]{0}[-]/{1}[-]";

	[Token(Token = "0x400E354")]
	private const string LINK_ZERO_PROGRESS_FORMAT_STR = "[808080]{0}/{1}[-]";

	[Token(Token = "0x400E355")]
	private const string DAILY_PLAY_GAME_NO_COMPLETED_LINK_STR = "[808080]{0}/{1}[-]";

	[Token(Token = "0x400E356")]
	private const string DAILY_PLAY_GAME_COMPLETED_LINK_STR = "[808080][1dd894]{0}[-]/{1}[-]";

	[Token(Token = "0x400E357")]
	private const int LINK_WITH_EMPTY_FONT_SIZE = 35;

	[Token(Token = "0x400E358")]
	private const int LINK_WITH_AVATAR_FONT_SIZE = 60;

	[Token(Token = "0x400E359")]
	private const float AVATAR_MODEL_SCALE_FACTOR = 0.82f;

	[Token(Token = "0x400E35A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Color ActiveSkillColor;

	[Token(Token = "0x400E35B")]
	[FieldOffset(Offset = "0x10")]
	private static readonly Color PassiveSkillColor;

	[Token(Token = "0x400E35C")]
	[FieldOffset(Offset = "0x20")]
	private static readonly Vector3 AvatarModelPosOnSelectPanelCollapse;

	[Token(Token = "0x400E35D")]
	[FieldOffset(Offset = "0x2C")]
	private static readonly Vector3 AvatarModelPosOnSelectPanelExpand;

	[Token(Token = "0x400E35E")]
	[FieldOffset(Offset = "0x38")]
	private static readonly List<string> NeedShow3DObjectList;

	[Token(Token = "0x400E35F")]
	[FieldOffset(Offset = "0x7C")]
	private UIAvatarLinkView m_View;

	[Token(Token = "0x400E360")]
	[FieldOffset(Offset = "0x80")]
	private UIAvatarSkillSlotController m_AvatarSkillSlotController;

	[Token(Token = "0x400E361")]
	[FieldOffset(Offset = "0x84")]
	private UINewDownloadInfoController m_DownloadInfoController;

	[Token(Token = "0x400E362")]
	[FieldOffset(Offset = "0x88")]
	private uint m_CurrentPreviewAvatarID;

	[Token(Token = "0x400E363")]
	[FieldOffset(Offset = "0x8C")]
	private int m_ShownLinkedBubbleIdx;

	[Token(Token = "0x400E364")]
	[FieldOffset(Offset = "0x90")]
	private bool m_IsLinkSelectPanelExpand;

	[Token(Token = "0x400E365")]
	[FieldOffset(Offset = "0x91")]
	private bool m_IsLinkBubbleShown;

	[Token(Token = "0x400E366")]
	[FieldOffset(Offset = "0x98")]
	private ulong m_LatestBubbleClickCooldownEndTime;

	[Token(Token = "0x400E367")]
	[FieldOffset(Offset = "0xA0")]
	private AvatarSkillData m_CurrentPreviewSkillData;

	[Token(Token = "0x400E368")]
	[FieldOffset(Offset = "0xA4")]
	private CSSharedAvatarData m_CurrentPreviewAvatarData;

	[Token(Token = "0x400E369")]
	[FieldOffset(Offset = "0xA8")]
	private LinkProfile m_CurrentPreviewLinkProfile;

	[Token(Token = "0x400E36A")]
	[FieldOffset(Offset = "0xAC")]
	private Coroutine m_DelayHideBubblePanelCoroutine;

	[Token(Token = "0x400E36B")]
	[FieldOffset(Offset = "0xB0")]
	private Coroutine m_ProgressChangedByDonateCoroutine;

	[Token(Token = "0x400E36C")]
	[FieldOffset(Offset = "0xB4")]
	private Coroutine m_OnNavigationShowSequenceCoroutine;

	[Token(Token = "0x400E36D")]
	[FieldOffset(Offset = "0xB8")]
	private Coroutine m_MoveRightPanelOnExpandCollapseCoroutine;

	[Token(Token = "0x400E36E")]
	[FieldOffset(Offset = "0xBC")]
	private LinkBubbleData[] m_LinkedBubbleContentKeyArray;

	[Token(Token = "0x400E36F")]
	[FieldOffset(Offset = "0xC0")]
	private readonly Queue<UICommonGuideData> m_GuideDataQueue;

	[Token(Token = "0x400E370")]
	[FieldOffset(Offset = "0xC4")]
	private uint m_DelayExecuteGuidance;

	[Token(Token = "0x400E371")]
	[FieldOffset(Offset = "0xC8")]
	public float trailVFXPlayLength;

	[Token(Token = "0x400E372")]
	[FieldOffset(Offset = "0xCC")]
	public float trailVFXWaitLength;

	[Token(Token = "0x400E373")]
	[FieldOffset(Offset = "0xD0")]
	public float increaseVFXPlayLength;

	[Token(Token = "0x400E374")]
	[FieldOffset(Offset = "0x3C")]
	private static Predicate<AvatarSuit> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17001124")]
	private bool IsPreviewEmpty
	{
		[Token(Token = "0x600D20A")]
		[Address(RVA = "0x2A88654", Offset = "0x2A88654", VA = "0x2A88654")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001125")]
	private bool IsPreviewAvatarHasSkill
	{
		[Token(Token = "0x600D20B")]
		[Address(RVA = "0x2A886C0", Offset = "0x2A886C0", VA = "0x2A886C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001126")]
	private bool IsPreviewLinked
	{
		[Token(Token = "0x600D20C")]
		[Address(RVA = "0x2A88724", Offset = "0x2A88724", VA = "0x2A88724")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600D209")]
	[Address(RVA = "0x2A885AC", Offset = "0x2A885AC", VA = "0x2A885AC")]
	public UIAvatarLinkController()
	{
	}

	[Token(Token = "0x600D20D")]
	[Address(RVA = "0x2A88868", Offset = "0x2A88868", VA = "0x2A88868")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D20E")]
	[Address(RVA = "0x2A88910", Offset = "0x2A88910", VA = "0x2A88910")]
	public static void PushAvatarLinkNavigation([Optional] List<object> param)
	{
	}

	[Token(Token = "0x600D20F")]
	[Address(RVA = "0x2A88D3C", Offset = "0x2A88D3C", VA = "0x2A88D3C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D210")]
	[Address(RVA = "0x2A8A778", Offset = "0x2A8A778", VA = "0x2A8A778", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600D211")]
	[Address(RVA = "0x2A8AF9C", Offset = "0x2A8AF9C", VA = "0x2A8AF9C", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x600D212")]
	[Address(RVA = "0x2A8B11C", Offset = "0x2A8B11C", VA = "0x2A8B11C", Slot = "39")]
	public override List<string> GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	[Token(Token = "0x600D213")]
	[Address(RVA = "0x2A8B1F4", Offset = "0x2A8B1F4", VA = "0x2A8B1F4", Slot = "41")]
	protected override void OnHelpButtonClick(object[] param)
	{
	}

	[Token(Token = "0x600D214")]
	[Address(RVA = "0x2A8B980", Offset = "0x2A8B980", VA = "0x2A8B980", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D215")]
	[Address(RVA = "0x2A8BAC8", Offset = "0x2A8BAC8", VA = "0x2A8BAC8", Slot = "64")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D216")]
	[Address(RVA = "0x2A8C3A8", Offset = "0x2A8C3A8", VA = "0x2A8C3A8", Slot = "65")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D217")]
	[Address(RVA = "0x2A8BE74", Offset = "0x2A8BE74", VA = "0x2A8BE74")]
	private void OnLinkedAvatarProgressChanged(uint avatarID, uint oldValue, uint newValue)
	{
	}

	[Token(Token = "0x600D218")]
	[Address(RVA = "0x2A8DDB4", Offset = "0x2A8DDB4", VA = "0x2A8DDB4")]
	private void OnTouchAvatar(object[] data)
	{
	}

	[Token(Token = "0x600D219")]
	[Address(RVA = "0x2A8C1E4", Offset = "0x2A8C1E4", VA = "0x2A8C1E4")]
	private void OnNotifyAssetRefresh()
	{
	}

	[Token(Token = "0x600D21A")]
	[Address(RVA = "0x2A8E2CC", Offset = "0x2A8E2CC", VA = "0x2A8E2CC", Slot = "66")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600D21B")]
	[Address(RVA = "0x2A8E3C4", Offset = "0x2A8E3C4", VA = "0x2A8E3C4", Slot = "67")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600D21C")]
	[Address(RVA = "0x2A8E440", Offset = "0x2A8E440", VA = "0x2A8E440")]
	public void OnItemControllerNotify(uint avatarID, bool force = false)
	{
	}

	[Token(Token = "0x600D21D")]
	[Address(RVA = "0x2A8E4D0", Offset = "0x2A8E4D0", VA = "0x2A8E4D0")]
	private void OnExpandCollapseSelectPanel(bool expand)
	{
	}

	[Token(Token = "0x600D21E")]
	[Address(RVA = "0x2A8AE28", Offset = "0x2A8AE28", VA = "0x2A8AE28")]
	private bool ExpandCollapseSelectPanel(bool expand, bool force = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600D21F")]
	[Address(RVA = "0x2A8F334", Offset = "0x2A8F334", VA = "0x2A8F334")]
	private void OnPreviewAvatar()
	{
	}

	[Token(Token = "0x600D220")]
	[Address(RVA = "0x2A901CC", Offset = "0x2A901CC", VA = "0x2A901CC")]
	private void SetPreviewAvatarEmpty()
	{
	}

	[Token(Token = "0x600D221")]
	[Address(RVA = "0x2A8AB14", Offset = "0x2A8AB14", VA = "0x2A8AB14")]
	private bool SetCurrentPreviewAvatar(uint avatarID, bool force = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600D222")]
	[Address(RVA = "0x2A909A8", Offset = "0x2A909A8", VA = "0x2A909A8")]
	private void SetLinkProgressLabel(uint progress, uint target)
	{
	}

	[Token(Token = "0x600D223")]
	[Address(RVA = "0x2A90EA0", Offset = "0x2A90EA0", VA = "0x2A90EA0")]
	private string GetNextCurLinkedBubbleKey()
	{
		return null;
	}

	[Token(Token = "0x600D224")]
	[Address(RVA = "0x2A8D8D8", Offset = "0x2A8D8D8", VA = "0x2A8D8D8")]
	private void PrepareCurLinkedBubbleArray()
	{
	}

	[Token(Token = "0x600D225")]
	[Address(RVA = "0x2A8AA7C", Offset = "0x2A8AA7C", VA = "0x2A8AA7C")]
	private void PrepareAvatarModelPreview(Vector3 position)
	{
	}

	[Token(Token = "0x600D226")]
	[Address(RVA = "0x2A8EE98", Offset = "0x2A8EE98", VA = "0x2A8EE98")]
	private void MovePreviewModelOnExpandCollapse(bool expand)
	{
	}

	[Token(Token = "0x600D227")]
	[Address(RVA = "0x2A9104C", Offset = "0x2A9104C", VA = "0x2A9104C")]
	private void RefreshPreviewModelOnChanged()
	{
	}

	[Token(Token = "0x600D228")]
	[Address(RVA = "0x2A8E124", Offset = "0x2A8E124", VA = "0x2A8E124")]
	private void RefreshPreviewModelAnim()
	{
	}

	[Token(Token = "0x600D229")]
	[Address(RVA = "0x2A915F4", Offset = "0x2A915F4", VA = "0x2A915F4")]
	private void RefreshAvatarSkillPanelOnChanged()
	{
	}

	[Token(Token = "0x600D22A")]
	[Address(RVA = "0x2A8F794", Offset = "0x2A8F794", VA = "0x2A8F794")]
	private void RefreshCenterPanelOrModelNotEmpty()
	{
	}

	[Token(Token = "0x600D22B")]
	[Address(RVA = "0x2A89108", Offset = "0x2A89108", VA = "0x2A89108")]
	private void SetupDefaultStateOnInit()
	{
	}

	[Token(Token = "0x600D22C")]
	[Address(RVA = "0x2A91944", Offset = "0x2A91944", VA = "0x2A91944")]
	private void CleanupLinkedAvatarBubble()
	{
	}

	[Token(Token = "0x600D22D")]
	[Address(RVA = "0x2A8DAA0", Offset = "0x2A8DAA0", VA = "0x2A8DAA0")]
	private bool ShowLinkedAvatarBubble()
	{
		return default(bool);
	}

	[Token(Token = "0x600D22E")]
	[Address(RVA = "0x2A8B028", Offset = "0x2A8B028", VA = "0x2A8B028")]
	private void HideLinkedAvatarBubble()
	{
	}

	[Token(Token = "0x600D22F")]
	[Address(RVA = "0x2A91A54", Offset = "0x2A91A54", VA = "0x2A91A54")]
	private IEnumerator DelayHideBubblePanel()
	{
		return null;
	}

	[Token(Token = "0x600D230")]
	[Address(RVA = "0x2A8F3BC", Offset = "0x2A8F3BC", VA = "0x2A8F3BC")]
	private void RefreshDownloadCtrlNotEmpty()
	{
	}

	[Token(Token = "0x600D231")]
	[Address(RVA = "0x2A90478", Offset = "0x2A90478", VA = "0x2A90478")]
	private void RefreshNoLinkedPanel()
	{
	}

	[Token(Token = "0x600D232")]
	[Address(RVA = "0x2A8FB54", Offset = "0x2A8FB54", VA = "0x2A8FB54")]
	private void RefreshProgressPanelNotEmpty()
	{
	}

	[Token(Token = "0x600D233")]
	[Address(RVA = "0x2A8FD10", Offset = "0x2A8FD10", VA = "0x2A8FD10")]
	private void RefreshSkillPanelContent()
	{
	}

	[Token(Token = "0x600D234")]
	[Address(RVA = "0x2A8C460", Offset = "0x2A8C460", VA = "0x2A8C460")]
	private void RefreshAcquisitionPanelNotEmpty()
	{
	}

	[Token(Token = "0x600D235")]
	[Address(RVA = "0x2A90B2C", Offset = "0x2A90B2C", VA = "0x2A90B2C")]
	private void RefreshAcquisitionPanelEmpty()
	{
	}

	[Token(Token = "0x600D236")]
	[Address(RVA = "0x2A8CE68", Offset = "0x2A8CE68", VA = "0x2A8CE68")]
	private void RefreshActionPanelNotEmpty()
	{
	}

	[Token(Token = "0x600D237")]
	[Address(RVA = "0x2A8EB8C", Offset = "0x2A8EB8C", VA = "0x2A8EB8C")]
	private void RefreshExpandCollapseIcon(bool expand)
	{
	}

	[Token(Token = "0x600D238")]
	[Address(RVA = "0x2A8ECE4", Offset = "0x2A8ECE4", VA = "0x2A8ECE4")]
	private bool RefreshBubbleOnExpandCollapse(bool expand)
	{
		return default(bool);
	}

	[Token(Token = "0x600D239")]
	[Address(RVA = "0x2A8E66C", Offset = "0x2A8E66C", VA = "0x2A8E66C")]
	private void RefreshLinkInfoListAndPreview()
	{
	}

	[Token(Token = "0x600D23A")]
	[Address(RVA = "0x2A8A210", Offset = "0x2A8A210", VA = "0x2A8A210")]
	private void RefreshLinkInfoListTitle()
	{
	}

	[Token(Token = "0x600D23B")]
	[Address(RVA = "0x2A8D4F4", Offset = "0x2A8D4F4", VA = "0x2A8D4F4")]
	private void ToggleAcquisitionAndSkillPanel()
	{
	}

	[Token(Token = "0x600D23C")]
	[Address(RVA = "0x2A8D698", Offset = "0x2A8D698", VA = "0x2A8D698")]
	private void ToggleActionPanel()
	{
	}

	[Token(Token = "0x600D23D")]
	[Address(RVA = "0x2A8ED6C", Offset = "0x2A8ED6C", VA = "0x2A8ED6C")]
	private void MoveCenterPanelOnExpandCollapse(bool expand)
	{
	}

	[Token(Token = "0x600D23E")]
	[Address(RVA = "0x2A8EE04", Offset = "0x2A8EE04", VA = "0x2A8EE04")]
	private void StartMoveRightPanelOnExpandCollapseCoroutine()
	{
	}

	[Token(Token = "0x600D23F")]
	[Address(RVA = "0x2A91B28", Offset = "0x2A91B28", VA = "0x2A91B28")]
	private IEnumerator MoveRightPanelOnExpandCollapse()
	{
		return null;
	}

	[Token(Token = "0x600D240")]
	[Address(RVA = "0x2A89F24", Offset = "0x2A89F24", VA = "0x2A89F24")]
	private void SetupAcquisitionCountdown()
	{
	}

	[Token(Token = "0x600D241")]
	[Address(RVA = "0x2A8D81C", Offset = "0x2A8D81C", VA = "0x2A8D81C")]
	private void StartProgressChangedByDonateCoroutine(uint oldValue, uint newValue)
	{
	}

	[Token(Token = "0x600D242")]
	[Address(RVA = "0x2A91BFC", Offset = "0x2A91BFC", VA = "0x2A91BFC")]
	private IEnumerator PlayProgressChangedByDonateVFX(uint oldValue, uint newValue)
	{
		return null;
	}

	[Token(Token = "0x600D243")]
	[Address(RVA = "0x2A8AF08", Offset = "0x2A8AF08", VA = "0x2A8AF08")]
	private void StartOnNavigationShowCoroutine()
	{
	}

	[Token(Token = "0x600D244")]
	[Address(RVA = "0x2A91D1C", Offset = "0x2A91D1C", VA = "0x2A91D1C")]
	private IEnumerator OnNavigationShowSequence()
	{
		return null;
	}

	[Token(Token = "0x600D245")]
	[Address(RVA = "0x2A892D0", Offset = "0x2A892D0", VA = "0x2A892D0")]
	private void AddEventDelegates()
	{
	}

	[Token(Token = "0x600D246")]
	[Address(RVA = "0x2A91DF0", Offset = "0x2A91DF0", VA = "0x2A91DF0")]
	private void OnAcquisitionHelpBtnClick()
	{
	}

	[Token(Token = "0x600D247")]
	[Address(RVA = "0x2A926BC", Offset = "0x2A926BC", VA = "0x2A926BC")]
	private void OnPlayGameBtnClick()
	{
	}

	[Token(Token = "0x600D248")]
	[Address(RVA = "0x2A92D04", Offset = "0x2A92D04", VA = "0x2A92D04")]
	private void OnDonateBtnClick()
	{
	}

	[Token(Token = "0x600D249")]
	[Address(RVA = "0x2A93538", Offset = "0x2A93538", VA = "0x2A93538")]
	private void OnSkillHelpBtnClick()
	{
	}

	[Token(Token = "0x600D24A")]
	[Address(RVA = "0x2A937C4", Offset = "0x2A937C4", VA = "0x2A937C4")]
	private void OnActionBtnClick()
	{
	}

	[Token(Token = "0x600D24B")]
	[Address(RVA = "0x2A94128", Offset = "0x2A94128", VA = "0x2A94128")]
	private void OnDisabledActionBtnClick()
	{
	}

	[Token(Token = "0x600D24C")]
	[Address(RVA = "0x2A946D4", Offset = "0x2A946D4", VA = "0x2A946D4")]
	private void OnExpandCollapseBtnClick()
	{
	}

	[Token(Token = "0x600D24D")]
	[Address(RVA = "0x2A94858", Offset = "0x2A94858", VA = "0x2A94858")]
	private void OnNoLinkedBtnClick()
	{
	}

	[Token(Token = "0x600D24E")]
	[Address(RVA = "0x2A949D0", Offset = "0x2A949D0", VA = "0x2A949D0")]
	private void OnDownloadCommonClick()
	{
	}

	[Token(Token = "0x600D24F")]
	[Address(RVA = "0x2A95148", Offset = "0x2A95148", VA = "0x2A95148")]
	private void OnProgressValueChanged()
	{
	}

	[Token(Token = "0x600D250")]
	[Address(RVA = "0x2A897A4", Offset = "0x2A897A4", VA = "0x2A897A4")]
	private void SetGuideQueueData()
	{
	}

	[Token(Token = "0x600D251")]
	[Address(RVA = "0x2A8F14C", Offset = "0x2A8F14C", VA = "0x2A8F14C")]
	private void TryExecuteGuidePeek()
	{
	}

	[Token(Token = "0x600D252")]
	[Address(RVA = "0x2A95380", Offset = "0x2A95380", VA = "0x2A95380")]
	private void DelayCallExecuteGuidePeek()
	{
	}

	[Token(Token = "0x600D253")]
	[Address(RVA = "0x2A9554C", Offset = "0x2A9554C", VA = "0x2A9554C")]
	private void ExecuteGuidePeek()
	{
	}

	[Token(Token = "0x600D254")]
	[Address(RVA = "0x2A95834", Offset = "0x2A95834", VA = "0x2A95834")]
	private void PopAndExecuteNext()
	{
	}

	[Token(Token = "0x600D255")]
	[Address(RVA = "0x2A95BF8", Offset = "0x2A95BF8", VA = "0x2A95BF8", Slot = "42")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x600D256")]
	[Address(RVA = "0x2A95C68", Offset = "0x2A95C68", VA = "0x2A95C68", Slot = "43")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x600D258")]
	[Address(RVA = "0x2A95EB0", Offset = "0x2A95EB0", VA = "0x2A95EB0")]
	private static bool _003CRefreshPreviewModelOnChanged_003Em__0(AvatarSuit suit)
	{
		return default(bool);
	}

	[Token(Token = "0x600D259")]
	[Address(RVA = "0x2A95ED4", Offset = "0x2A95ED4", VA = "0x2A95ED4")]
	private bool _003CRefreshLinkInfoListAndPreview_003Em__1(LinkProfile profile)
	{
		return default(bool);
	}

	[Token(Token = "0x600D25A")]
	[Address(RVA = "0x2A95F0C", Offset = "0x2A95F0C", VA = "0x2A95F0C")]
	private void _003COnActionBtnClick_003Em__2()
	{
	}

	[Token(Token = "0x600D25B")]
	[Address(RVA = "0x2A9614C", Offset = "0x2A9614C", VA = "0x2A9614C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D25C")]
	[Address(RVA = "0x2A96154", Offset = "0x2A96154", VA = "0x2A96154")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600D25D")]
	[Address(RVA = "0x2A9615C", Offset = "0x2A9615C", VA = "0x2A9615C")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x600D25E")]
	[Address(RVA = "0x2A96164", Offset = "0x2A96164", VA = "0x2A96164")]
	public List<string> _003C_003EiFixBaseProxy_GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	[Token(Token = "0x600D25F")]
	[Address(RVA = "0x2A9616C", Offset = "0x2A9616C", VA = "0x2A9616C")]
	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}

	[Token(Token = "0x600D260")]
	[Address(RVA = "0x2A96174", Offset = "0x2A96174", VA = "0x2A96174")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
