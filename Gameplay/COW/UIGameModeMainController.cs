using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20026A6")]
public class UIGameModeMainController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x20026A7")]
	private sealed class _003CCorShowCSGuide_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400EE8C")]
		[FieldOffset(Offset = "0x8")]
		internal Vector3 _003Cw2sPos_003E__1;

		[Token(Token = "0x400EE8D")]
		[FieldOffset(Offset = "0x14")]
		internal float _003CtarX_003E__1;

		[Token(Token = "0x400EE8E")]
		[FieldOffset(Offset = "0x18")]
		internal float _003Cf_003E__1;

		[Token(Token = "0x400EE8F")]
		[FieldOffset(Offset = "0x1C")]
		internal UIWidget _003Cwidget_003E__0;

		[Token(Token = "0x400EE90")]
		[FieldOffset(Offset = "0x20")]
		internal string _003Ckey_003E__0;

		[Token(Token = "0x400EE91")]
		[FieldOffset(Offset = "0x24")]
		internal List<EventDelegate> _003Cact_003E__0;

		[Token(Token = "0x400EE92")]
		[FieldOffset(Offset = "0x28")]
		internal CommonGuideSetting _003Csetting_003E__0;

		[Token(Token = "0x400EE93")]
		[FieldOffset(Offset = "0x2C")]
		internal UIPanel[] _003Cpanels_003E__0;

		[Token(Token = "0x400EE94")]
		[FieldOffset(Offset = "0x30")]
		internal int _003Cdep_003E__0;

		[Token(Token = "0x400EE95")]
		[FieldOffset(Offset = "0x34")]
		internal UIGameModeMainController _0024this;

		[Token(Token = "0x400EE96")]
		[FieldOffset(Offset = "0x38")]
		internal object _0024current;

		[Token(Token = "0x400EE97")]
		[FieldOffset(Offset = "0x3C")]
		internal bool _0024disposing;

		[Token(Token = "0x400EE98")]
		[FieldOffset(Offset = "0x40")]
		internal int _0024PC;

		[Token(Token = "0x17001196")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600E8DB")]
			[Address(RVA = "0x218553C", Offset = "0x218553C", VA = "0x218553C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001197")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600E8DC")]
			[Address(RVA = "0x2185544", Offset = "0x2185544", VA = "0x2185544", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600E8D9")]
		[Address(RVA = "0x217EA88", Offset = "0x217EA88", VA = "0x217EA88")]
		public _003CCorShowCSGuide_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600E8DA")]
		[Address(RVA = "0x2184C84", Offset = "0x2184C84", VA = "0x2184C84", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600E8DD")]
		[Address(RVA = "0x218554C", Offset = "0x218554C", VA = "0x218554C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600E8DE")]
		[Address(RVA = "0x2185560", Offset = "0x2185560", VA = "0x2185560", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20026A8")]
	private sealed class _003CRefreshScrollPos_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400EE99")]
		[FieldOffset(Offset = "0x8")]
		internal float _003Ctempx_003E__0;

		[Token(Token = "0x400EE9A")]
		[FieldOffset(Offset = "0xC")]
		internal Vector4 _003CbaseClipRegion_003E__0;

		[Token(Token = "0x400EE9B")]
		[FieldOffset(Offset = "0x1C")]
		internal UIGameModeMainController _0024this;

		[Token(Token = "0x400EE9C")]
		[FieldOffset(Offset = "0x20")]
		internal object _0024current;

		[Token(Token = "0x400EE9D")]
		[FieldOffset(Offset = "0x24")]
		internal bool _0024disposing;

		[Token(Token = "0x400EE9E")]
		[FieldOffset(Offset = "0x28")]
		internal int _0024PC;

		[Token(Token = "0x17001198")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600E8E1")]
			[Address(RVA = "0x2187104", Offset = "0x2187104", VA = "0x2187104", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001199")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600E8E2")]
			[Address(RVA = "0x218710C", Offset = "0x218710C", VA = "0x218710C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600E8DF")]
		[Address(RVA = "0x2182954", Offset = "0x2182954", VA = "0x2182954")]
		public _003CRefreshScrollPos_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600E8E0")]
		[Address(RVA = "0x2186CEC", Offset = "0x2186CEC", VA = "0x2186CEC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600E8E3")]
		[Address(RVA = "0x2187114", Offset = "0x2187114", VA = "0x2187114", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600E8E4")]
		[Address(RVA = "0x2187128", Offset = "0x2187128", VA = "0x2187128", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20026A9")]
	private sealed class _003CRefineItemPos_003Ec__Iterator2 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400EE9F")]
		[FieldOffset(Offset = "0x8")]
		internal int _003CwaitFrame_003E__0;

		[Token(Token = "0x400EEA0")]
		[FieldOffset(Offset = "0xC")]
		internal int _003CdeltaX_003E__0;

		[Token(Token = "0x400EEA1")]
		[FieldOffset(Offset = "0x10")]
		internal UIGameModeMainController _0024this;

		[Token(Token = "0x400EEA2")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x400EEA3")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x400EEA4")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x1700119A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600E8E7")]
			[Address(RVA = "0x2186C40", Offset = "0x2186C40", VA = "0x2186C40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700119B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600E8E8")]
			[Address(RVA = "0x2186C48", Offset = "0x2186C48", VA = "0x2186C48", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600E8E5")]
		[Address(RVA = "0x218295C", Offset = "0x218295C", VA = "0x218295C")]
		public _003CRefineItemPos_003Ec__Iterator2()
		{
		}

		[Token(Token = "0x600E8E6")]
		[Address(RVA = "0x21855E8", Offset = "0x21855E8", VA = "0x21855E8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600E8E9")]
		[Address(RVA = "0x2186C50", Offset = "0x2186C50", VA = "0x2186C50", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600E8EA")]
		[Address(RVA = "0x2186C64", Offset = "0x2186C64", VA = "0x2186C64", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400EE61")]
	[FieldOffset(Offset = "0x48")]
	private UIGameModeMainView m_View;

	[Token(Token = "0x400EE62")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelMapOpeningInfo m_ModelMap;

	[Token(Token = "0x400EE63")]
	[FieldOffset(Offset = "0x50")]
	private bool m_DataInit;

	[Token(Token = "0x400EE64")]
	[FieldOffset(Offset = "0x54")]
	private float m_CellSpacing;

	[Token(Token = "0x400EE65")]
	[FieldOffset(Offset = "0x58")]
	private float m_RankItemWidth;

	[Token(Token = "0x400EE66")]
	[FieldOffset(Offset = "0x5C")]
	private float m_ClassicItemWidth;

	[Token(Token = "0x400EE67")]
	[FieldOffset(Offset = "0x60")]
	private float m_CSRankItemWidth;

	[Token(Token = "0x400EE68")]
	[FieldOffset(Offset = "0x64")]
	private float m_MediumItemWidth;

	[Token(Token = "0x400EE69")]
	[FieldOffset(Offset = "0x68")]
	private float m_CasualItemWidth;

	[Token(Token = "0x400EE6A")]
	[FieldOffset(Offset = "0x6C")]
	private UICommonGuideController m_RankGuideCtrl;

	[Token(Token = "0x400EE6B")]
	[FieldOffset(Offset = "0x70")]
	private UIWidget m_RankWidget;

	[Token(Token = "0x400EE6C")]
	[FieldOffset(Offset = "0x74")]
	private UIModelUser m_ModelUser;

	[Token(Token = "0x400EE6D")]
	[FieldOffset(Offset = "0x78")]
	private int m_CasualItemCount;

	[Token(Token = "0x400EE6E")]
	[FieldOffset(Offset = "0x7C")]
	private float m_ScrollViewPanelWidth;

	[Token(Token = "0x400EE6F")]
	[FieldOffset(Offset = "0x80")]
	private float m_TotalViewItemWidth;

	[Token(Token = "0x400EE70")]
	[FieldOffset(Offset = "0x84")]
	private UIGameModeRankItemController m_RankItemController;

	[Token(Token = "0x400EE71")]
	[FieldOffset(Offset = "0x88")]
	private UIGameModeCSRankItemController m_CsRankItemController;

	[Token(Token = "0x400EE72")]
	[FieldOffset(Offset = "0x8C")]
	private UIRankMapSelectController m_RankMapSelectController;

	[Token(Token = "0x400EE73")]
	[FieldOffset(Offset = "0x90")]
	private UIPeriodicRankMapSelectController m_PeriodicRankMapSelectController;

	[Token(Token = "0x400EE74")]
	[FieldOffset(Offset = "0x94")]
	private UIGameModePeriodicRankInfoController m_PeriodicRankInfoCtrl;

	[Token(Token = "0x400EE75")]
	private const string NewRankPlayer = "NEWRANKPLAYER";

	[Token(Token = "0x400EE76")]
	[FieldOffset(Offset = "0x98")]
	private bool m_IsGuest;

	[Token(Token = "0x400EE77")]
	[FieldOffset(Offset = "0x9C")]
	private string TRAINING_GUIDE;

	[Token(Token = "0x400EE78")]
	[FieldOffset(Offset = "0xA0")]
	private bool m_isEnoughLevel;

	[Token(Token = "0x400EE79")]
	[FieldOffset(Offset = "0xA4")]
	private Vector3 m_PosOfBegin;

	[Token(Token = "0x400EE7A")]
	[FieldOffset(Offset = "0xB0")]
	private bool m_isCsRankEnoughLevel;

	[Token(Token = "0x400EE7B")]
	[FieldOffset(Offset = "0xB1")]
	private bool m_isBrRankEnoughLevel;

	[Token(Token = "0x400EE7C")]
	[FieldOffset(Offset = "0xB4")]
	private UIModelPeriodicLadderMatch m_ModelPeriodicLadderMatch;

	[Token(Token = "0x400EE7D")]
	[FieldOffset(Offset = "0xB8")]
	private UIModelOptionalDownload m_ModelDownload;

	[Token(Token = "0x400EE7E")]
	[FieldOffset(Offset = "0xBC")]
	private UINewDownloadInfoController m_trainDownloadCtrl;

	[Token(Token = "0x400EE7F")]
	[FieldOffset(Offset = "0xC0")]
	private UINewDownloadInfoController m_UGCDownloadCtrl;

	[Token(Token = "0x400EE80")]
	[FieldOffset(Offset = "0xC4")]
	private UIGameModeBaseItemController m_csGuideItemRenderer;

	[Token(Token = "0x400EE81")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject m_csGuideGo;

	[Token(Token = "0x400EE82")]
	[FieldOffset(Offset = "0xCC")]
	public float m_fGuideOffset;

	[Token(Token = "0x400EE83")]
	[FieldOffset(Offset = "0xD0")]
	private Coroutine m_csGuideCoroutine;

	[Token(Token = "0x400EE84")]
	[FieldOffset(Offset = "0xD4")]
	private bool m_bIsCSGuideCloseAni;

	[Token(Token = "0x400EE85")]
	[FieldOffset(Offset = "0xD5")]
	private bool m_bIsShowCSGuide;

	[Token(Token = "0x400EE86")]
	private const uint m_BermudaMapId = 1u;

	[Token(Token = "0x400EE87")]
	[FieldOffset(Offset = "0xD8")]
	private UICommonGuideController m_guideCtrl;

	[Token(Token = "0x400EE88")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<MapModeData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400EE89")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<MapModeData> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400EE8A")]
	[FieldOffset(Offset = "0x8")]
	private static Predicate<MapModeData> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x400EE8B")]
	[FieldOffset(Offset = "0xC")]
	private static Action _003C_003Ef__am_0024cache3;

	[Token(Token = "0x600E8AE")]
	[Address(RVA = "0x217D8C0", Offset = "0x217D8C0", VA = "0x217D8C0")]
	public UIGameModeMainController()
	{
	}

	[Token(Token = "0x600E8AF")]
	[Address(RVA = "0x217D978", Offset = "0x217D978", VA = "0x217D978")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E8B0")]
	[Address(RVA = "0x217DA20", Offset = "0x217DA20", VA = "0x217DA20", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E8B1")]
	[Address(RVA = "0x217E18C", Offset = "0x217E18C", VA = "0x217E18C")]
	private void ShowRankGuide()
	{
	}

	[Token(Token = "0x600E8B2")]
	[Address(RVA = "0x217E6F0", Offset = "0x217E6F0", VA = "0x217E6F0")]
	public void CloseRankGuide()
	{
	}

	[Token(Token = "0x600E8B3")]
	[Address(RVA = "0x217E7EC", Offset = "0x217E7EC", VA = "0x217E7EC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600E8B4")]
	[Address(RVA = "0x217E888", Offset = "0x217E888", VA = "0x217E888")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600E8B5")]
	[Address(RVA = "0x217E920", Offset = "0x217E920", VA = "0x217E920")]
	public void ShowCSGuide()
	{
	}

	[Token(Token = "0x600E8B6")]
	[Address(RVA = "0x217E9BC", Offset = "0x217E9BC", VA = "0x217E9BC")]
	private IEnumerator CorShowCSGuide()
	{
		return null;
	}

	[Token(Token = "0x600E8B7")]
	[Address(RVA = "0x217EA90", Offset = "0x217EA90", VA = "0x217EA90")]
	public void SetUIData()
	{
	}

	[Token(Token = "0x600E8B8")]
	[Address(RVA = "0x2181F54", Offset = "0x2181F54", VA = "0x2181F54")]
	private bool MapInitTwice()
	{
		return default(bool);
	}

	[Token(Token = "0x600E8B9")]
	[Address(RVA = "0x2181E40", Offset = "0x2181E40", VA = "0x2181E40")]
	private void RefreshPeriodicRankMode()
	{
	}

	[Token(Token = "0x600E8BA")]
	[Address(RVA = "0x21820E0", Offset = "0x21820E0", VA = "0x21820E0")]
	public int GetModelLimitLevel(uint gameMode, uint matchMode)
	{
		return default(int);
	}

	[Token(Token = "0x600E8BB")]
	[Address(RVA = "0x2181B48", Offset = "0x2181B48", VA = "0x2181B48")]
	public void UpdateRankItemLockInfo()
	{
	}

	[Token(Token = "0x600E8BC")]
	[Address(RVA = "0x2181CA8", Offset = "0x2181CA8", VA = "0x2181CA8")]
	private IEnumerator RefreshScrollPos()
	{
		return null;
	}

	[Token(Token = "0x600E8BD")]
	[Address(RVA = "0x2181D74", Offset = "0x2181D74", VA = "0x2181D74")]
	private IEnumerator RefineItemPos()
	{
		return null;
	}

	[Token(Token = "0x600E8BE")]
	[Address(RVA = "0x2182964", Offset = "0x2182964", VA = "0x2182964", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600E8BF")]
	[Address(RVA = "0x2182EE4", Offset = "0x2182EE4", VA = "0x2182EE4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E8C0")]
	[Address(RVA = "0x2183154", Offset = "0x2183154", VA = "0x2183154")]
	private int customSort(Transform t1, Transform t2)
	{
		return default(int);
	}

	[Token(Token = "0x600E8C1")]
	[Address(RVA = "0x2183294", Offset = "0x2183294", VA = "0x2183294")]
	private void OnCustomRoomClick()
	{
	}

	[Token(Token = "0x600E8C2")]
	[Address(RVA = "0x218392C", Offset = "0x218392C", VA = "0x218392C")]
	private void OnTrainingClick2()
	{
	}

	[Token(Token = "0x600E8C3")]
	[Address(RVA = "0x2183980", Offset = "0x2183980", VA = "0x2183980")]
	private void OnTrainingClick()
	{
	}

	[Token(Token = "0x600E8C4")]
	[Address(RVA = "0x2183DA8", Offset = "0x2183DA8", VA = "0x2183DA8")]
	private void OnSceneEditClick()
	{
	}

	[Token(Token = "0x600E8C5")]
	[Address(RVA = "0x2184224", Offset = "0x2184224", VA = "0x2184224")]
	private void OnSceneEditHelpClick()
	{
	}

	[Token(Token = "0x600E8C6")]
	[Address(RVA = "0x21838C0", Offset = "0x21838C0", VA = "0x21838C0")]
	private void OnLeaveBtnClick()
	{
	}

	[Token(Token = "0x600E8C7")]
	[Address(RVA = "0x21843C0", Offset = "0x21843C0", VA = "0x21843C0", Slot = "40")]
	public override bool ClosedByEsc()
	{
		return default(bool);
	}

	[Token(Token = "0x600E8C8")]
	[Address(RVA = "0x2184424", Offset = "0x2184424", VA = "0x2184424", Slot = "41")]
	public override bool IgnoreEsc()
	{
		return default(bool);
	}

	[Token(Token = "0x600E8C9")]
	[Address(RVA = "0x21844BC", Offset = "0x21844BC", VA = "0x21844BC")]
	private void OnServerConfirmed(object[] data)
	{
	}

	[Token(Token = "0x600E8CA")]
	[Address(RVA = "0x21845BC", Offset = "0x21845BC", VA = "0x21845BC", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E8CB")]
	[Address(RVA = "0x2184698", Offset = "0x2184698", VA = "0x2184698", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E8CC")]
	public T OpenChild<T>(Transform parent, [Optional] Vector3 localPosition, EUIAnchor anchor = EUIAnchor.None) where T : UIBaseController
	{
		return null;
	}

	[Token(Token = "0x600E8CD")]
	[Address(RVA = "0x2184794", Offset = "0x2184794", VA = "0x2184794")]
	public int GetScrollViewPanelDepth()
	{
		return default(int);
	}

	[Token(Token = "0x600E8CE")]
	[Address(RVA = "0x2184840", Offset = "0x2184840", VA = "0x2184840")]
	private void OnOpenPeriodicRankMapSelector(object[] data)
	{
	}

	[Token(Token = "0x600E8CF")]
	[Address(RVA = "0x218489C", Offset = "0x218489C", VA = "0x218489C")]
	private void OnOpenRankMapSelector(object[] data)
	{
	}

	[Token(Token = "0x600E8D0")]
	[Address(RVA = "0x21849C4", Offset = "0x21849C4", VA = "0x21849C4")]
	private static bool _003CSetUIData_003Em__0(MapModeData x)
	{
		return default(bool);
	}

	[Token(Token = "0x600E8D1")]
	[Address(RVA = "0x21849F0", Offset = "0x21849F0", VA = "0x21849F0")]
	private static bool _003CSetUIData_003Em__1(MapModeData x)
	{
		return default(bool);
	}

	[Token(Token = "0x600E8D2")]
	[Address(RVA = "0x2184A1C", Offset = "0x2184A1C", VA = "0x2184A1C")]
	private static bool _003CSetUIData_003Em__2(MapModeData x)
	{
		return default(bool);
	}

	[Token(Token = "0x600E8D3")]
	[Address(RVA = "0x2184A48", Offset = "0x2184A48", VA = "0x2184A48")]
	private static void _003COnSceneEditClick_003Em__3()
	{
	}

	[Token(Token = "0x600E8D4")]
	[Address(RVA = "0x2184C5C", Offset = "0x2184C5C", VA = "0x2184C5C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E8D5")]
	[Address(RVA = "0x2184C64", Offset = "0x2184C64", VA = "0x2184C64")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600E8D6")]
	[Address(RVA = "0x2184C6C", Offset = "0x2184C6C", VA = "0x2184C6C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600E8D7")]
	[Address(RVA = "0x2184C74", Offset = "0x2184C74", VA = "0x2184C74")]
	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return default(bool);
	}

	[Token(Token = "0x600E8D8")]
	[Address(RVA = "0x2184C7C", Offset = "0x2184C7C", VA = "0x2184C7C")]
	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return default(bool);
	}
}
