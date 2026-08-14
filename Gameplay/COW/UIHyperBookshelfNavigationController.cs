using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002149")]
public class UIHyperBookshelfNavigationController : UINavigationController, _Attribute
{
	[Token(Token = "0x200214A")]
	private sealed class _003CDelayAdjustScrollViewPivot_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D10C")]
		[FieldOffset(Offset = "0x8")]
		internal UIScrollView _003Csw_003E__0;

		[Token(Token = "0x400D10D")]
		[FieldOffset(Offset = "0xC")]
		internal float _003CextendWidth_003E__0;

		[Token(Token = "0x400D10E")]
		[FieldOffset(Offset = "0x10")]
		internal float _003CclipWidth_003E__0;

		[Token(Token = "0x400D10F")]
		[FieldOffset(Offset = "0x14")]
		internal UIHyperBookshelfNavigationController _0024this;

		[Token(Token = "0x400D110")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x400D111")]
		[FieldOffset(Offset = "0x1C")]
		internal bool _0024disposing;

		[Token(Token = "0x400D112")]
		[FieldOffset(Offset = "0x20")]
		internal int _0024PC;

		[Token(Token = "0x17001015")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600AFA5")]
			[Address(RVA = "0xD37250", Offset = "0xD37250", VA = "0xD37250", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001016")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600AFA6")]
			[Address(RVA = "0xD37258", Offset = "0xD37258", VA = "0xD37258", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600AFA3")]
		[Address(RVA = "0xD36F90", Offset = "0xD36F90", VA = "0xD36F90")]
		public _003CDelayAdjustScrollViewPivot_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600AFA4")]
		[Address(RVA = "0xD36F98", Offset = "0xD36F98", VA = "0xD36F98", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600AFA7")]
		[Address(RVA = "0xD37260", Offset = "0xD37260", VA = "0xD37260", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600AFA8")]
		[Address(RVA = "0xD37274", Offset = "0xD37274", VA = "0xD37274", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200214B")]
	private sealed class _003CEntranceBookOpenCoroutine_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D113")]
		[FieldOffset(Offset = "0x8")]
		internal uint bookID;

		[Token(Token = "0x400D114")]
		[FieldOffset(Offset = "0xC")]
		internal CollectionBookStoreShowData _003CshowData_003E__0;

		[Token(Token = "0x400D115")]
		[FieldOffset(Offset = "0x10")]
		internal GameObject _003CbookOpenVfx_003E__0;

		[Token(Token = "0x400D116")]
		[FieldOffset(Offset = "0x14")]
		internal GameObject entranceGo;

		[Token(Token = "0x400D117")]
		[FieldOffset(Offset = "0x18")]
		internal Vector3 _003CentranceLocalPos_003E__0;

		[Token(Token = "0x400D118")]
		[FieldOffset(Offset = "0x24")]
		internal Vector3 _003CoffsetPos_003E__0;

		[Token(Token = "0x400D119")]
		[FieldOffset(Offset = "0x30")]
		internal Vector3 _003CtargetLocalPos_003E__0;

		[Token(Token = "0x400D11A")]
		[FieldOffset(Offset = "0x3C")]
		internal Vector3 _003CfinalLocalPos_003E__0;

		[Token(Token = "0x400D11B")]
		[FieldOffset(Offset = "0x48")]
		internal UIHyperBookshelfNavigationController _0024this;

		[Token(Token = "0x400D11C")]
		[FieldOffset(Offset = "0x4C")]
		internal object _0024current;

		[Token(Token = "0x400D11D")]
		[FieldOffset(Offset = "0x50")]
		internal bool _0024disposing;

		[Token(Token = "0x400D11E")]
		[FieldOffset(Offset = "0x54")]
		internal int _0024PC;

		[Token(Token = "0x17001017")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600AFAB")]
			[Address(RVA = "0xD386D8", Offset = "0xD386D8", VA = "0xD386D8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001018")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600AFAC")]
			[Address(RVA = "0xD386E0", Offset = "0xD386E0", VA = "0xD386E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600AFA9")]
		[Address(RVA = "0xD376F0", Offset = "0xD376F0", VA = "0xD376F0")]
		public _003CEntranceBookOpenCoroutine_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600AFAA")]
		[Address(RVA = "0xD376F8", Offset = "0xD376F8", VA = "0xD376F8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600AFAD")]
		[Address(RVA = "0xD386E8", Offset = "0xD386E8", VA = "0xD386E8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600AFAE")]
		[Address(RVA = "0xD386FC", Offset = "0xD386FC", VA = "0xD386FC", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200214C")]
	private sealed class _003CDelayShowGuideMask_003Ec__Iterator2 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D11F")]
		[FieldOffset(Offset = "0x8")]
		internal UIHyperBookshelfNavigationController _0024this;

		[Token(Token = "0x400D120")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400D121")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400D122")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17001019")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600AFB1")]
			[Address(RVA = "0xD37644", Offset = "0xD37644", VA = "0xD37644", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700101A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600AFB2")]
			[Address(RVA = "0xD3764C", Offset = "0xD3764C", VA = "0xD3764C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600AFAF")]
		[Address(RVA = "0xD372FC", Offset = "0xD372FC", VA = "0xD372FC")]
		public _003CDelayShowGuideMask_003Ec__Iterator2()
		{
		}

		[Token(Token = "0x600AFB0")]
		[Address(RVA = "0xD37304", Offset = "0xD37304", VA = "0xD37304", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600AFB3")]
		[Address(RVA = "0xD37654", Offset = "0xD37654", VA = "0xD37654", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600AFB4")]
		[Address(RVA = "0xD37668", Offset = "0xD37668", VA = "0xD37668", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400D0FA")]
	public const float ENTRANCE_BOOK_SHAKE_ANIM_DURATION = 1f;

	[Token(Token = "0x400D0FB")]
	public const float ENTRANCE_BOOK_OPEN_ANIM_DURATION = 1.1f;

	[Token(Token = "0x400D0FC")]
	public const string NAVIGATION_HELP_TIPS_KEY = "T_34_XY_HYPERBOOK_HELP";

	[Token(Token = "0x400D0FD")]
	private const string NAVIGATION_TITLE_KEY = "T_34_XY_HYPERBOOK_SYS";

	[Token(Token = "0x400D0FE")]
	private const string GUIDE_BOOK_ENTRANCE_KEY = "T_34_XY_HYPERBOOK_SYS";

	[Token(Token = "0x400D0FF")]
	private const float ENTRANCE_BOOK_OPEN_TWEEN_OFFSET_Y = 130f;

	[Token(Token = "0x400D100")]
	[FieldOffset(Offset = "0x68")]
	private bool m_IsFirstShowed;

	[Token(Token = "0x400D101")]
	[FieldOffset(Offset = "0x69")]
	private bool m_IsUnlockAnimPlaying;

	[Token(Token = "0x400D102")]
	[FieldOffset(Offset = "0x6C")]
	private float m_ShowMaskDuration;

	[Token(Token = "0x400D103")]
	[FieldOffset(Offset = "0x70")]
	private uint m_DelayCallID;

	[Token(Token = "0x400D104")]
	[FieldOffset(Offset = "0x74")]
	private UIHyperBookshelfNavigationView m_View;

	[Token(Token = "0x400D105")]
	[FieldOffset(Offset = "0x78")]
	private Coroutine m_ScrollViewResetPositionCoroutine;

	[Token(Token = "0x400D106")]
	[FieldOffset(Offset = "0x7C")]
	private Coroutine m_ShowAndHideMaskCoroutine;

	[Token(Token = "0x400D107")]
	[FieldOffset(Offset = "0x80")]
	private Coroutine m_EntranceBookOpenCoroutine;

	[Token(Token = "0x400D108")]
	[FieldOffset(Offset = "0x84")]
	private GameObject m_EntranceBookOpenVFX;

	[Token(Token = "0x400D109")]
	[FieldOffset(Offset = "0x88")]
	private GameObject m_EntranceBookOpenBgVFX;

	[Token(Token = "0x400D10A")]
	[FieldOffset(Offset = "0x8C")]
	private GameObject m_EntranceBookOpenBurstVFX;

	[Token(Token = "0x400D10B")]
	[FieldOffset(Offset = "0x90")]
	private readonly List<UIHyperBookEntranceController> m_EntranceCtrlList;

	[Token(Token = "0x600AF85")]
	[Address(RVA = "0x295EDCC", Offset = "0x295EDCC", VA = "0x295EDCC")]
	public UIHyperBookshelfNavigationController()
	{
	}

	[Token(Token = "0x600AF86")]
	[Address(RVA = "0x295EE8C", Offset = "0x295EE8C", VA = "0x295EE8C")]
	public static void Push([Optional] List<object> data)
	{
	}

	[Token(Token = "0x600AF87")]
	[Address(RVA = "0x295F540", Offset = "0x295F540", VA = "0x295F540")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AF88")]
	[Address(RVA = "0x295F5E8", Offset = "0x295F5E8", VA = "0x295F5E8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AF89")]
	[Address(RVA = "0x295FF6C", Offset = "0x295FF6C", VA = "0x295FF6C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600AF8A")]
	[Address(RVA = "0x29603CC", Offset = "0x29603CC", VA = "0x29603CC", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600AF8B")]
	[Address(RVA = "0x29608D4", Offset = "0x29608D4", VA = "0x29608D4", Slot = "41")]
	protected override void OnHelpButtonClick(object[] param)
	{
	}

	[Token(Token = "0x600AF8C")]
	[Address(RVA = "0x2960B38", Offset = "0x2960B38", VA = "0x2960B38", Slot = "42")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600AF8D")]
	[Address(RVA = "0x2960D00", Offset = "0x2960D00", VA = "0x2960D00", Slot = "43")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600AF8E")]
	[Address(RVA = "0x2960BF0", Offset = "0x2960BF0", VA = "0x2960BF0")]
	private void OnHyperBookInfoRefresh()
	{
	}

	[Token(Token = "0x600AF8F")]
	[Address(RVA = "0x295F7B4", Offset = "0x295F7B4", VA = "0x295F7B4")]
	private void PrepareBookEntrances()
	{
	}

	[Token(Token = "0x600AF90")]
	[Address(RVA = "0x29606CC", Offset = "0x29606CC", VA = "0x29606CC")]
	private void RefreshBookEntrances(bool isFirstEntered)
	{
	}

	[Token(Token = "0x600AF91")]
	[Address(RVA = "0x2960638", Offset = "0x2960638", VA = "0x2960638")]
	private void StartDelayAdjustScrollViewPivot()
	{
	}

	[Token(Token = "0x600AF92")]
	[Address(RVA = "0x2960E28", Offset = "0x2960E28", VA = "0x2960E28")]
	private IEnumerator DelayAdjustScrollViewPivot()
	{
		return null;
	}

	[Token(Token = "0x600AF93")]
	[Address(RVA = "0x2960EF4", Offset = "0x2960EF4", VA = "0x2960EF4")]
	private void StartEntranceBookOpenCoroutine(uint bookID, GameObject entranceGo)
	{
	}

	[Token(Token = "0x600AF94")]
	[Address(RVA = "0x2960FB0", Offset = "0x2960FB0", VA = "0x2960FB0")]
	private IEnumerator EntranceBookOpenCoroutine(uint bookID, GameObject entranceGo)
	{
		return null;
	}

	[Token(Token = "0x600AF95")]
	[Address(RVA = "0x29610C8", Offset = "0x29610C8", VA = "0x29610C8")]
	private void OnEntranceBookOpenFinished()
	{
	}

	[Token(Token = "0x600AF96")]
	[Address(RVA = "0x295E3C4", Offset = "0x295E3C4", VA = "0x295E3C4")]
	public void ShowGuide(UIWidget entranceWidget, uint bookID)
	{
	}

	[Token(Token = "0x600AF97")]
	[Address(RVA = "0x2960D94", Offset = "0x2960D94", VA = "0x2960D94")]
	private void StartDelayShowGuideMask()
	{
	}

	[Token(Token = "0x600AF98")]
	[Address(RVA = "0x2961228", Offset = "0x2961228", VA = "0x2961228")]
	private IEnumerator DelayShowGuideMask()
	{
		return null;
	}

	[Token(Token = "0x600AF99")]
	[Address(RVA = "0x2960064", Offset = "0x2960064", VA = "0x2960064")]
	private void TryStopDelayCall()
	{
	}

	[Token(Token = "0x600AF9A")]
	[Address(RVA = "0x2960174", Offset = "0x2960174", VA = "0x2960174")]
	private void DestroyAllRuntimeResource()
	{
	}

	[Token(Token = "0x600AF9B")]
	[Address(RVA = "0x295FA94", Offset = "0x295FA94", VA = "0x295FA94")]
	private void LoadEntranceBookOpenBgVFX()
	{
	}

	[Token(Token = "0x600AF9C")]
	[Address(RVA = "0x295FD00", Offset = "0x295FD00", VA = "0x295FD00")]
	private void LoadEntranceBookOpenBurstVFX()
	{
	}

	[Token(Token = "0x600AF9D")]
	[Address(RVA = "0x295BD04", Offset = "0x295BD04", VA = "0x295BD04")]
	public void OnHyperBookEntranceEnter(uint bookID, GameObject entranceGo)
	{
	}

	[Token(Token = "0x600AF9E")]
	[Address(RVA = "0x29612F4", Offset = "0x29612F4", VA = "0x29612F4")]
	private void _003CShowGuide_003Em__0()
	{
	}

	[Token(Token = "0x600AF9F")]
	[Address(RVA = "0x29613B8", Offset = "0x29613B8", VA = "0x29613B8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AFA0")]
	[Address(RVA = "0x29613C0", Offset = "0x29613C0", VA = "0x29613C0")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600AFA1")]
	[Address(RVA = "0x29613C8", Offset = "0x29613C8", VA = "0x29613C8")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600AFA2")]
	[Address(RVA = "0x29613D0", Offset = "0x29613D0", VA = "0x29613D0")]
	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}
}
