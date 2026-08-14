using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002140")]
public class UIHyperBookContentNavigationController : UIPreviewNavigationController, _Attribute
{
	[Token(Token = "0x2002141")]
	private struct HyperBookContentNavigationData
	{
		[Token(Token = "0x400D0BA")]
		[FieldOffset(Offset = "0x0")]
		public uint BookID;

		[Token(Token = "0x400D0BB")]
		[FieldOffset(Offset = "0x4")]
		public int SortID;

		[Token(Token = "0x400D0BC")]
		[FieldOffset(Offset = "0x8")]
		public bool WaitForOpenAnim;
	}

	[Token(Token = "0x2002142")]
	private sealed class _003CDelayOnShowContentCoroutine_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D0BD")]
		[FieldOffset(Offset = "0x8")]
		internal int selectPageIdx;

		[Token(Token = "0x400D0BE")]
		[FieldOffset(Offset = "0xC")]
		internal UIHyperBookContentNavigationController _0024this;

		[Token(Token = "0x400D0BF")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400D0C0")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400D0C1")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x17001008")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600AF2C")]
			[Address(RVA = "0x2954430", Offset = "0x2954430", VA = "0x2954430", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001009")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600AF2D")]
			[Address(RVA = "0x2954438", Offset = "0x2954438", VA = "0x2954438", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600AF2A")]
		[Address(RVA = "0x2952790", Offset = "0x2952790", VA = "0x2952790")]
		public _003CDelayOnShowContentCoroutine_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600AF2B")]
		[Address(RVA = "0x2954084", Offset = "0x2954084", VA = "0x2954084", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600AF2E")]
		[Address(RVA = "0x2954440", Offset = "0x2954440", VA = "0x2954440", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600AF2F")]
		[Address(RVA = "0x2954454", Offset = "0x2954454", VA = "0x2954454", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002143")]
	private sealed class _003CPlayVFXAndDelayPopupCoroutine_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D0C2")]
		[FieldOffset(Offset = "0x8")]
		internal bool _003CisPreview3DObject_003E__0;

		[Token(Token = "0x400D0C3")]
		[FieldOffset(Offset = "0xC")]
		internal uint bookID;

		[Token(Token = "0x400D0C4")]
		[FieldOffset(Offset = "0x10")]
		internal int pageIdx;

		[Token(Token = "0x400D0C5")]
		[FieldOffset(Offset = "0x14")]
		internal UIHyperBookContentNavigationController _0024this;

		[Token(Token = "0x400D0C6")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x400D0C7")]
		[FieldOffset(Offset = "0x1C")]
		internal bool _0024disposing;

		[Token(Token = "0x400D0C8")]
		[FieldOffset(Offset = "0x20")]
		internal int _0024PC;

		[Token(Token = "0x1700100A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600AF32")]
			[Address(RVA = "0x2954908", Offset = "0x2954908", VA = "0x2954908", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700100B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600AF33")]
			[Address(RVA = "0x2954910", Offset = "0x2954910", VA = "0x2954910", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600AF30")]
		[Address(RVA = "0x2952E38", Offset = "0x2952E38", VA = "0x2952E38")]
		public _003CPlayVFXAndDelayPopupCoroutine_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600AF31")]
		[Address(RVA = "0x29544DC", Offset = "0x29544DC", VA = "0x29544DC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600AF34")]
		[Address(RVA = "0x2954918", Offset = "0x2954918", VA = "0x2954918", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600AF35")]
		[Address(RVA = "0x295492C", Offset = "0x295492C", VA = "0x295492C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002144")]
	private sealed class _003CUnlockSuccessProcedureCoroutine_003Ec__Iterator2 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D0C9")]
		[FieldOffset(Offset = "0x8")]
		internal uint bookID;

		[Token(Token = "0x400D0CA")]
		[FieldOffset(Offset = "0xC")]
		internal int pageIdx;

		[Token(Token = "0x400D0CB")]
		[FieldOffset(Offset = "0x10")]
		internal CollectionBookItemDesc _003CpageDesc_003E__0;

		[Token(Token = "0x400D0CC")]
		[FieldOffset(Offset = "0x14")]
		internal UIHyperBookContentNavigationController _0024this;

		[Token(Token = "0x400D0CD")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x400D0CE")]
		[FieldOffset(Offset = "0x1C")]
		internal bool _0024disposing;

		[Token(Token = "0x400D0CF")]
		[FieldOffset(Offset = "0x20")]
		internal int _0024PC;

		[Token(Token = "0x1700100C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600AF38")]
			[Address(RVA = "0x2955214", Offset = "0x2955214", VA = "0x2955214", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700100D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600AF39")]
			[Address(RVA = "0x295521C", Offset = "0x295521C", VA = "0x295521C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600AF36")]
		[Address(RVA = "0x2952F58", Offset = "0x2952F58", VA = "0x2952F58")]
		public _003CUnlockSuccessProcedureCoroutine_003Ec__Iterator2()
		{
		}

		[Token(Token = "0x600AF37")]
		[Address(RVA = "0x2954DD0", Offset = "0x2954DD0", VA = "0x2954DD0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600AF3A")]
		[Address(RVA = "0x2955224", Offset = "0x2955224", VA = "0x2955224", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600AF3B")]
		[Address(RVA = "0x2955238", Offset = "0x2955238", VA = "0x2955238", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002145")]
	private sealed class _003CUnlockFailProcedureCoroutine_003Ec__Iterator3 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D0D0")]
		[FieldOffset(Offset = "0x8")]
		internal UIHyperBookContentNavigationController _0024this;

		[Token(Token = "0x400D0D1")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400D0D2")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400D0D3")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x1700100E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600AF3E")]
			[Address(RVA = "0x2954D24", Offset = "0x2954D24", VA = "0x2954D24", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700100F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600AF3F")]
			[Address(RVA = "0x2954D2C", Offset = "0x2954D2C", VA = "0x2954D2C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600AF3C")]
		[Address(RVA = "0x295302C", Offset = "0x295302C", VA = "0x295302C")]
		public _003CUnlockFailProcedureCoroutine_003Ec__Iterator3()
		{
		}

		[Token(Token = "0x600AF3D")]
		[Address(RVA = "0x29549B4", Offset = "0x29549B4", VA = "0x29549B4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600AF40")]
		[Address(RVA = "0x2954D34", Offset = "0x2954D34", VA = "0x2954D34", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600AF41")]
		[Address(RVA = "0x2954D48", Offset = "0x2954D48", VA = "0x2954D48", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400D07D")]
	private const string NORMAL_PAGE_DESC_KEY = "T_34_XY_HYPERBOOK_PAGEDEC";

	[Token(Token = "0x400D07E")]
	private const string HIDDEN_PAGE_DESC_KEY = "T_34_XY_HYPERBOOK_HIDDENPAGEDEC";

	[Token(Token = "0x400D07F")]
	private const string HIDDEN_PAGE_HELP_TIPS_KEY = "T_34_XY_HYPERBOOK_HIDDENHELP";

	[Token(Token = "0x400D080")]
	private const string HIDDEN_PAGE_SPIN_CHANCE_KEY = "T_34_XY_HYPERBOOK_BRTIPS";

	[Token(Token = "0x400D081")]
	private const string TOKEN_NOT_SELL_TIPS_KEY = "T_34_XY_HYPERBOOK_TOKENNOTSELL";

	[Token(Token = "0x400D082")]
	private const string NO_GOPOS_CONFIG_KEY = "T_34_XY_HYPERBOOK_NOGOPOS";

	[Token(Token = "0x400D083")]
	private const string PAGE_INDEX_KEY = "T_34_XY_HYPERBOOK_PAGENUM";

	[Token(Token = "0x400D084")]
	private const string GOTO_LOCKED_PAGE_KEY = "T_34_XY_HYPERBOOK_PAGEREQUIRE";

	[Token(Token = "0x400D085")]
	private const string HIDDEN_PAGE_SPIN_NUM_KEY = "T_34_XY_HYPERBOOK_SPINNUM";

	[Token(Token = "0x400D086")]
	private const string UNLOCK_HIDDEN_PAGE_FAIL_KEY = "T_34_XY_HYPERBOOK_UNLOCKFAIL";

	[Token(Token = "0x400D087")]
	private const string UNLOCK_HIDDEN_PAGE_SUCCESS_KEY = "T_34_XY_HYPERBOOK_UNLOCKSUCCESS";

	[Token(Token = "0x400D088")]
	private const string HYPER_BOOK_OUTDATE_TIPS_KEY = "T_34_XY_HYPERBOOK_OUTDATE";

	[Token(Token = "0x400D089")]
	private const string NORMAL_PAGE_BG_NAME = "FF_UI_HyperBook_Brd";

	[Token(Token = "0x400D08A")]
	private const string HIDDEN_PAGE_BG_NAME = "FF_UI_HyperBook_Brd_Hidden";

	[Token(Token = "0x400D08B")]
	private const string UNLOCK_TOKEN_ENOUGH_FORMAT_STR = "{0}/{1}";

	[Token(Token = "0x400D08C")]
	private const string UNLOCK_TOKEN_NOT_ENOUGH_FORMAT_STR = "[FF0032]{0}[-]/{1}";

	[Token(Token = "0x400D08D")]
	private const string CLAIM_GUIDE_KEY = "T_34_XY_HYPERBOOK_GUIDE2";

	[Token(Token = "0x400D08E")]
	private const string Second_PAGE_GUIDE_KEY = "T_34_XY_HYPERBOOK_GUIDE3";

	[Token(Token = "0x400D08F")]
	private const string HIDDEN_PAGE_GUIDE_KEY = "T_34_XY_HYPERBOOK_GUIDE4";

	[Token(Token = "0x400D090")]
	private const string ANIMATOR_TRIGGER_TURN_PREVIOUS = "PreviousPage";

	[Token(Token = "0x400D091")]
	private const string ANIMATOR_TRIGGER_TURN_NEXT = "NextPage";

	[Token(Token = "0x400D092")]
	private const string NAVI_ON_SHOW_ANIM_NAME = "VFX_UIHyperBookContentNavigation_into01";

	[Token(Token = "0x400D093")]
	private const string TURN_PREVIOUS_PAGE_ANIM_EVT_NAME = "TURN_PREVIOUS_PAGE_FINISHED";

	[Token(Token = "0x400D094")]
	private const string TURN_NEXT_PAGE_ANIM_EVT_NAME = "TURN_NEXT_PAGE_FINISHED";

	[Token(Token = "0x400D095")]
	private const string CANNOT_UNLOCK_KEY = "T_31_Q_WINTER_CANNOT_UNLOCK";

	[Token(Token = "0x400D096")]
	private const string IN_DOWNLOADING_KEY = "T_33_XY_VERSIONDOWN_DOWNLOAD";

	[Token(Token = "0x400D097")]
	public const string HIDDEN_PAGE_MASK_DRAW_VFX_NAME = "Draw";

	[Token(Token = "0x400D098")]
	private const float ENTRANCE_BOOK_OPEN_ANIM_TRANSITION = 0.8f;

	[Token(Token = "0x400D099")]
	private const float PARTICLE_GATHERING_ENTITY_OTHERS_VFX_DURATION = 2.1f;

	[Token(Token = "0x400D09A")]
	private const float PARTICLE_GATHERING_VFX_SUCCESS_DURATION = 2.15f;

	[Token(Token = "0x400D09B")]
	private const float PARTICLE_GATHERING_VFX_FAILED_DURATION = 2.5f;

	[Token(Token = "0x400D09C")]
	private const float PAGE_ITEM_RECEIVED_VFX_PLAY_CAMERA_DEPTH = 4f;

	[Token(Token = "0x400D09D")]
	private const float PAGE_ITEM_RECEIVED_VFX_STOP_CAMERA_DEPTH = 2f;

	[Token(Token = "0x400D09E")]
	private const float PREVIEW_ITEM_DESC_HIDE_LOCAL_POS_X = -721.5f;

	[Token(Token = "0x400D09F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Vector3 PREVIEW_ITEM_CAMERA_VFX_OFFSET;

	[Token(Token = "0x400D0A0")]
	[FieldOffset(Offset = "0xC")]
	private static readonly Vector3 PREVIEW_MIX_CAMERA_VFX_OFFSET;

	[Token(Token = "0x400D0A1")]
	[FieldOffset(Offset = "0x7C")]
	private bool m_IsBookPurchasedDuringDisabled;

	[Token(Token = "0x400D0A2")]
	[FieldOffset(Offset = "0x7D")]
	private bool m_IsAllBookModelMatReady;

	[Token(Token = "0x400D0A3")]
	[FieldOffset(Offset = "0x80")]
	private uint m_PreviewBookID;

	[Token(Token = "0x400D0A4")]
	[FieldOffset(Offset = "0x84")]
	private int m_PreviewPageIdx;

	[Token(Token = "0x400D0A5")]
	[FieldOffset(Offset = "0x88")]
	private ResourceID m_HiddenPageMaskVFXResID;

	[Token(Token = "0x400D0A6")]
	[FieldOffset(Offset = "0x8C")]
	private GameObject m_HiddenPageMaskVFX;

	[Token(Token = "0x400D0A7")]
	[FieldOffset(Offset = "0x90")]
	private GameObject m_HiddenPageMaskDrawVFX;

	[Token(Token = "0x400D0A8")]
	[FieldOffset(Offset = "0x94")]
	private GameObject m_ParticleGatheringEntityOthersVFX;

	[Token(Token = "0x400D0A9")]
	[FieldOffset(Offset = "0x98")]
	private Transform m_3DContentRoot;

	[Token(Token = "0x400D0AA")]
	[FieldOffset(Offset = "0x9C")]
	private GameObject m_BookModelContent;

	[Token(Token = "0x400D0AB")]
	[FieldOffset(Offset = "0xA0")]
	private GameObject m_NormalPageBackgroundVFX;

	[Token(Token = "0x400D0AC")]
	[FieldOffset(Offset = "0xA4")]
	private GameObject m_HiddenPageBackgroundVFX;

	[Token(Token = "0x400D0AD")]
	[FieldOffset(Offset = "0xA8")]
	private GameObject m_NormalPageDecorationVFX;

	[Token(Token = "0x400D0AE")]
	[FieldOffset(Offset = "0xAC")]
	private GameObject m_HiddenPageDecorationVFX;

	[Token(Token = "0x400D0AF")]
	[FieldOffset(Offset = "0xB0")]
	private Animator m_BookModelAnimator;

	[Token(Token = "0x400D0B0")]
	[FieldOffset(Offset = "0xB4")]
	private SkinnedMeshRenderer m_BookModelMeshRenderer;

	[Token(Token = "0x400D0B1")]
	[FieldOffset(Offset = "0xB8")]
	private Coroutine m_OnShowContentDisplayCoroutine;

	[Token(Token = "0x400D0B2")]
	[FieldOffset(Offset = "0xBC")]
	private Coroutine m_PlayVFXAndDelayPopupCoroutine;

	[Token(Token = "0x400D0B3")]
	[FieldOffset(Offset = "0xC0")]
	private Coroutine m_UnlockSuccessProcedureCoroutine;

	[Token(Token = "0x400D0B4")]
	[FieldOffset(Offset = "0xC4")]
	private Coroutine m_UnlockFailProcedureCoroutine;

	[Token(Token = "0x400D0B5")]
	[FieldOffset(Offset = "0xC8")]
	private UIHyperBookContentNavigationView m_View;

	[Token(Token = "0x400D0B6")]
	[FieldOffset(Offset = "0xCC")]
	private Material[] m_NormalPageMatArray;

	[Token(Token = "0x400D0B7")]
	[FieldOffset(Offset = "0xD0")]
	private Material[] m_HiddenPageMatArray;

	[Token(Token = "0x400D0B8")]
	[FieldOffset(Offset = "0xD4")]
	private readonly List<UIHyperBookContentPageItemController> m_PageItemCtrlList;

	[Token(Token = "0x400D0B9")]
	[FieldOffset(Offset = "0x18")]
	private static Callback _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x600AED4")]
	[Address(RVA = "0x2945E60", Offset = "0x2945E60", VA = "0x2945E60")]
	public UIHyperBookContentNavigationController()
	{
	}

	[Token(Token = "0x600AED5")]
	[Address(RVA = "0x2945F3C", Offset = "0x2945F3C", VA = "0x2945F3C")]
	public static void Push([Optional] List<object> data)
	{
	}

	[Token(Token = "0x600AED6")]
	[Address(RVA = "0x2946AA8", Offset = "0x2946AA8", VA = "0x2946AA8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AED7")]
	[Address(RVA = "0x2946B50", Offset = "0x2946B50", VA = "0x2946B50", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AED8")]
	[Address(RVA = "0x29477B8", Offset = "0x29477B8", VA = "0x29477B8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600AED9")]
	[Address(RVA = "0x2947AA8", Offset = "0x2947AA8", VA = "0x2947AA8", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600AEDA")]
	[Address(RVA = "0x294BE40", Offset = "0x294BE40", VA = "0x294BE40", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x600AEDB")]
	[Address(RVA = "0x294C150", Offset = "0x294C150", VA = "0x294C150", Slot = "41")]
	protected override void OnHelpButtonClick(object[] param)
	{
	}

	[Token(Token = "0x600AEDC")]
	[Address(RVA = "0x294C790", Offset = "0x294C790", VA = "0x294C790", Slot = "42")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x600AEDD")]
	[Address(RVA = "0x294C800", Offset = "0x294C800", VA = "0x294C800", Slot = "43")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x600AEDE")]
	[Address(RVA = "0x294C858", Offset = "0x294C858", VA = "0x294C858", Slot = "64")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600AEDF")]
	[Address(RVA = "0x294E71C", Offset = "0x294E71C", VA = "0x294E71C", Slot = "65")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600AEE0")]
	[Address(RVA = "0x294CCA0", Offset = "0x294CCA0", VA = "0x294CCA0")]
	private void OnHyperBookPageStateChanged(uint bookID, int pageIdx)
	{
	}

	[Token(Token = "0x600AEE1")]
	[Address(RVA = "0x294CE58", Offset = "0x294CE58", VA = "0x294CE58")]
	private void OnHyperBookNormalPageUnlocked(uint bookID, int pageIdx)
	{
	}

	[Token(Token = "0x600AEE2")]
	[Address(RVA = "0x294D2F0", Offset = "0x294D2F0", VA = "0x294D2F0")]
	private void OnCurrentBookPurchaseSuccess(uint bookID)
	{
	}

	[Token(Token = "0x600AEE3")]
	[Address(RVA = "0x294F198", Offset = "0x294F198", VA = "0x294F198")]
	private void OnAnimEvtOccured(object[] data)
	{
	}

	[Token(Token = "0x600AEE4")]
	[Address(RVA = "0x294F378", Offset = "0x294F378", VA = "0x294F378")]
	private void OnTurnPageAnimEvtOccured(bool nextPage)
	{
	}

	[Token(Token = "0x600AEE5")]
	[Address(RVA = "0x294F8D0", Offset = "0x294F8D0", VA = "0x294F8D0")]
	private void OnCommonRewardWndFinish(object[] data)
	{
	}

	[Token(Token = "0x600AEE6")]
	[Address(RVA = "0x2947598", Offset = "0x2947598", VA = "0x2947598")]
	private void SetupDefaultState()
	{
	}

	[Token(Token = "0x600AEE7")]
	[Address(RVA = "0x294F944", Offset = "0x294F944", VA = "0x294F944")]
	private void ClearBookPageItemList()
	{
	}

	[Token(Token = "0x600AEE8")]
	[Address(RVA = "0x294E7F8", Offset = "0x294E7F8", VA = "0x294E7F8")]
	private void RefreshBookPageItemList()
	{
	}

	[Token(Token = "0x600AEE9")]
	[Address(RVA = "0x294D6A4", Offset = "0x294D6A4", VA = "0x294D6A4")]
	private void RefreshPageDetailsPanel(int pageIdx, CollectionBookItemDesc pageItemDesc)
	{
	}

	[Token(Token = "0x600AEEA")]
	[Address(RVA = "0x294FE6C", Offset = "0x294FE6C", VA = "0x294FE6C")]
	private void RefreshPreviewComponent(int pageIdx, bool isInteraction, CollectionBookItemDesc pageDesc)
	{
	}

	[Token(Token = "0x600AEEB")]
	[Address(RVA = "0x294B4E4", Offset = "0x294B4E4", VA = "0x294B4E4")]
	private void ResetToEnterAnimFirstFrame()
	{
	}

	[Token(Token = "0x600AEEC")]
	[Address(RVA = "0x294AC8C", Offset = "0x294AC8C", VA = "0x294AC8C")]
	private void ResetToEnterAnimLastFrame()
	{
	}

	[Token(Token = "0x600AEED")]
	[Address(RVA = "0x294B948", Offset = "0x294B948", VA = "0x294B948")]
	private void PlayEnterAnim(bool reverse = false)
	{
	}

	[Token(Token = "0x600AEEE")]
	[Address(RVA = "0x2950114", Offset = "0x2950114", VA = "0x2950114")]
	private void PlayTurnPageAnimation(int previousPageIdx, int curPageIdx)
	{
	}

	[Token(Token = "0x600AEEF")]
	[Address(RVA = "0x2950260", Offset = "0x2950260", VA = "0x2950260")]
	private void PlayPreviewChangedVFX()
	{
	}

	[Token(Token = "0x600AEF0")]
	[Address(RVA = "0x2950374", Offset = "0x2950374", VA = "0x2950374")]
	private void RefreshBookModelMeshRenderMaterials(bool isHiddenPage)
	{
	}

	[Token(Token = "0x600AEF1")]
	[Address(RVA = "0x295049C", Offset = "0x295049C", VA = "0x295049C")]
	private void RefreshDecorationVFX(bool isHiddenPage)
	{
	}

	[Token(Token = "0x600AEF2")]
	[Address(RVA = "0x2950590", Offset = "0x2950590", VA = "0x2950590")]
	private void RefreshBackgroundVFX(bool isHiddenPage)
	{
	}

	[Token(Token = "0x600AEF3")]
	[Address(RVA = "0x294B118", Offset = "0x294B118", VA = "0x294B118")]
	private void Refresh3DContent(bool active)
	{
	}

	[Token(Token = "0x600AEF4")]
	[Address(RVA = "0x2950684", Offset = "0x2950684", VA = "0x2950684")]
	private static void OnPageHelpBtnClick()
	{
	}

	[Token(Token = "0x600AEF5")]
	[Address(RVA = "0x29509D8", Offset = "0x29509D8", VA = "0x29509D8")]
	private void OnGotoLockedPageBtnClick()
	{
	}

	[Token(Token = "0x600AEF6")]
	[Address(RVA = "0x2950B20", Offset = "0x2950B20", VA = "0x2950B20")]
	private void OnGotoStoreBtnClick()
	{
	}

	[Token(Token = "0x600AEF7")]
	[Address(RVA = "0x2950E08", Offset = "0x2950E08", VA = "0x2950E08")]
	private void OnFunctionBtnClick()
	{
	}

	[Token(Token = "0x600AEF8")]
	[Address(RVA = "0x2947244", Offset = "0x2947244", VA = "0x2947244")]
	private void AddEventDelegate()
	{
	}

	[Token(Token = "0x600AEF9")]
	[Address(RVA = "0x2946860", Offset = "0x2946860", VA = "0x2946860")]
	private static HyperBookContentNavigationData GetNavigationData(List<object> windowParam)
	{
		return default(HyperBookContentNavigationData);
	}

	[Token(Token = "0x600AEFA")]
	[Address(RVA = "0x29481A0", Offset = "0x29481A0", VA = "0x29481A0")]
	private int GetSelectPageIdxOnShowed(HyperBookContentNavigationData navData, bool isPopBack)
	{
		return default(int);
	}

	[Token(Token = "0x600AEFB")]
	[Address(RVA = "0x294D470", Offset = "0x294D470", VA = "0x294D470")]
	private CollectionBookItemDesc GetPageItemDesc(int pageIdx)
	{
		return null;
	}

	[Token(Token = "0x600AEFC")]
	[Address(RVA = "0x294A9EC", Offset = "0x294A9EC", VA = "0x294A9EC")]
	private void SetPreviewBook(uint bookID)
	{
	}

	[Token(Token = "0x600AEFD")]
	[Address(RVA = "0x294B260", Offset = "0x294B260", VA = "0x294B260")]
	private void SetPreviewPage(int pageIdx, bool isInteraction, bool force = false)
	{
	}

	[Token(Token = "0x600AEFE")]
	[Address(RVA = "0x2951FAC", Offset = "0x2951FAC", VA = "0x2951FAC")]
	private void RefreshPageItemSelectState(int pageIdx)
	{
	}

	[Token(Token = "0x600AEFF")]
	[Address(RVA = "0x294FC6C", Offset = "0x294FC6C", VA = "0x294FC6C")]
	private void HideAllFunctionPanelContent()
	{
	}

	[Token(Token = "0x600AF00")]
	[Address(RVA = "0x29512B0", Offset = "0x29512B0", VA = "0x29512B0")]
	private void OnUnlockTokenNotEnough()
	{
	}

	[Token(Token = "0x600AF01")]
	[Address(RVA = "0x2947EB8", Offset = "0x2947EB8", VA = "0x2947EB8")]
	private bool PopSelfIfCurrentBookPurchased(UINavigationData navigationData)
	{
		return default(bool);
	}

	[Token(Token = "0x600AF02")]
	[Address(RVA = "0x29484D8", Offset = "0x29484D8", VA = "0x29484D8")]
	private void LoadHiddenPageMaskVFX(uint bookID)
	{
	}

	[Token(Token = "0x600AF03")]
	[Address(RVA = "0x2948D50", Offset = "0x2948D50", VA = "0x2948D50")]
	private void LoadBookModelContent(uint bookID)
	{
	}

	[Token(Token = "0x600AF04")]
	[Address(RVA = "0x2949A24", Offset = "0x2949A24", VA = "0x2949A24")]
	private void LoadBookBackgroundVFX(uint bookID)
	{
	}

	[Token(Token = "0x600AF05")]
	[Address(RVA = "0x2949FEC", Offset = "0x2949FEC", VA = "0x2949FEC")]
	private void LoadBookDecorationVFX(uint bookID)
	{
	}

	[Token(Token = "0x600AF06")]
	[Address(RVA = "0x2949378", Offset = "0x2949378", VA = "0x2949378")]
	private void LoadBookModelMaterials(uint bookID)
	{
	}

	[Token(Token = "0x600AF07")]
	[Address(RVA = "0x2946E48", Offset = "0x2946E48", VA = "0x2946E48")]
	private void Load3DContentRoot()
	{
	}

	[Token(Token = "0x600AF08")]
	[Address(RVA = "0x2947024", Offset = "0x2947024", VA = "0x2947024")]
	private void LoadPageItemReceivedVFX()
	{
	}

	[Token(Token = "0x600AF09")]
	[Address(RVA = "0x2947848", Offset = "0x2947848", VA = "0x2947848")]
	private void Destroy3DContentRoot()
	{
	}

	[Token(Token = "0x600AF0A")]
	[Address(RVA = "0x2947988", Offset = "0x2947988", VA = "0x2947988")]
	private void DestroyPageItemReceivedVFX()
	{
	}

	[Token(Token = "0x600AF0B")]
	[Address(RVA = "0x294A5B4", Offset = "0x294A5B4", VA = "0x294A5B4")]
	private void SetupPreviewItemCameraClearFlags()
	{
	}

	[Token(Token = "0x600AF0C")]
	[Address(RVA = "0x2952344", Offset = "0x2952344", VA = "0x2952344")]
	private Camera TryGetContent3DCamera()
	{
		return null;
	}

	[Token(Token = "0x600AF0D")]
	[Address(RVA = "0x294A718", Offset = "0x294A718", VA = "0x294A718")]
	private void RegisterPostEffectExtraCameras()
	{
	}

	[Token(Token = "0x600AF0E")]
	[Address(RVA = "0x294BEB8", Offset = "0x294BEB8", VA = "0x294BEB8")]
	private void UnRegisterPostEffectExtraCameras()
	{
	}

	[Token(Token = "0x600AF0F")]
	[Address(RVA = "0x2952458", Offset = "0x2952458", VA = "0x2952458")]
	private void SetPreviewCameraDepth(float depth)
	{
	}

	[Token(Token = "0x600AF10")]
	[Address(RVA = "0x294F650", Offset = "0x294F650", VA = "0x294F650")]
	private void SetPreviewCameraActive(bool active)
	{
	}

	[Token(Token = "0x600AF11")]
	[Address(RVA = "0x29526A4", Offset = "0x29526A4", VA = "0x29526A4")]
	private IEnumerator DelayOnShowContentCoroutine(int selectPageIdx)
	{
		return null;
	}

	[Token(Token = "0x600AF12")]
	[Address(RVA = "0x294BDA0", Offset = "0x294BDA0", VA = "0x294BDA0")]
	private void DelayOnShowContent(int selectPageIdx)
	{
	}

	[Token(Token = "0x600AF13")]
	[Address(RVA = "0x294EC40", Offset = "0x294EC40", VA = "0x294EC40")]
	private void ShowCommandRewardWndOnReceived(uint bookID, int pageIdx)
	{
	}

	[Token(Token = "0x600AF14")]
	[Address(RVA = "0x2952798", Offset = "0x2952798", VA = "0x2952798")]
	private bool AdjustItemReceivedVFXPos()
	{
		return default(bool);
	}

	[Token(Token = "0x600AF15")]
	[Address(RVA = "0x2952D20", Offset = "0x2952D20", VA = "0x2952D20")]
	private IEnumerator PlayVFXAndDelayPopupCoroutine(uint bookID, int pageIdx)
	{
		return null;
	}

	[Token(Token = "0x600AF16")]
	[Address(RVA = "0x2952E40", Offset = "0x2952E40", VA = "0x2952E40")]
	private IEnumerator UnlockSuccessProcedureCoroutine(uint bookID, int pageIdx)
	{
		return null;
	}

	[Token(Token = "0x600AF17")]
	[Address(RVA = "0x2952F60", Offset = "0x2952F60", VA = "0x2952F60")]
	private IEnumerator UnlockFailProcedureCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600AF18")]
	[Address(RVA = "0x294F0DC", Offset = "0x294F0DC", VA = "0x294F0DC")]
	private void PlayItemReceivedVFXAndDelayPopup(uint bookID, int pageIdx)
	{
	}

	[Token(Token = "0x600AF19")]
	[Address(RVA = "0x294D1A0", Offset = "0x294D1A0", VA = "0x294D1A0")]
	private void StartUnlockSuccessProcedure(uint bookID, int pageIdx)
	{
	}

	[Token(Token = "0x600AF1A")]
	[Address(RVA = "0x294D25C", Offset = "0x294D25C", VA = "0x294D25C")]
	private void StartUnlockFailProcedure()
	{
	}

	[Token(Token = "0x600AF1B")]
	[Address(RVA = "0x2953034", Offset = "0x2953034", VA = "0x2953034")]
	public void NotifyPageItemSelected(int pageIdx)
	{
	}

	[Token(Token = "0x600AF1C")]
	[Address(RVA = "0x2951D40", Offset = "0x2951D40", VA = "0x2951D40")]
	private bool CheckNeedShowFirstPageGuide(uint bookID)
	{
		return default(bool);
	}

	[Token(Token = "0x600AF1D")]
	[Address(RVA = "0x29530B4", Offset = "0x29530B4", VA = "0x29530B4")]
	public void ShowFirstPageClaimGuide()
	{
	}

	[Token(Token = "0x600AF1E")]
	[Address(RVA = "0x29534AC", Offset = "0x29534AC", VA = "0x29534AC")]
	public void ShowSecondPageGuide()
	{
	}

	[Token(Token = "0x600AF1F")]
	[Address(RVA = "0x29538A4", Offset = "0x29538A4", VA = "0x29538A4")]
	public void ShowHiddenPageGuide()
	{
	}

	[Token(Token = "0x600AF20")]
	[Address(RVA = "0x2953C9C", Offset = "0x2953C9C", VA = "0x2953C9C")]
	public void ShowGuideMask()
	{
	}

	[Token(Token = "0x600AF22")]
	[Address(RVA = "0x2953E70", Offset = "0x2953E70", VA = "0x2953E70")]
	private void _003CShowFirstPageClaimGuide_003Em__0()
	{
	}

	[Token(Token = "0x600AF23")]
	[Address(RVA = "0x2953F14", Offset = "0x2953F14", VA = "0x2953F14")]
	private void _003CShowSecondPageGuide_003Em__1()
	{
	}

	[Token(Token = "0x600AF24")]
	[Address(RVA = "0x2953FB8", Offset = "0x2953FB8", VA = "0x2953FB8")]
	private void _003CShowHiddenPageGuide_003Em__2()
	{
	}

	[Token(Token = "0x600AF25")]
	[Address(RVA = "0x295405C", Offset = "0x295405C", VA = "0x295405C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AF26")]
	[Address(RVA = "0x2954064", Offset = "0x2954064", VA = "0x2954064")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600AF27")]
	[Address(RVA = "0x295406C", Offset = "0x295406C", VA = "0x295406C")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600AF28")]
	[Address(RVA = "0x2954074", Offset = "0x2954074", VA = "0x2954074")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x600AF29")]
	[Address(RVA = "0x295407C", Offset = "0x295407C", VA = "0x295407C")]
	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}
}
