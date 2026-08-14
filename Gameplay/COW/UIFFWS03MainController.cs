using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001F3D")]
internal class UIFFWS03MainController : UIBigEventMainBaseController
{
	[Token(Token = "0x2001F3E")]
	private sealed class _003CEnterAnimCoroutine_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C494")]
		[FieldOffset(Offset = "0x8")]
		internal UIFFWS03MainController _0024this;

		[Token(Token = "0x400C495")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400C496")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400C497")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17000F91")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6009A3D")]
			[Address(RVA = "0x19EF294", Offset = "0x19EF294", VA = "0x19EF294", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F92")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009A3E")]
			[Address(RVA = "0x19EF29C", Offset = "0x19EF29C", VA = "0x19EF29C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009A3B")]
		[Address(RVA = "0x19EDFB0", Offset = "0x19EDFB0", VA = "0x19EDFB0")]
		public _003CEnterAnimCoroutine_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6009A3C")]
		[Address(RVA = "0x19EEFA4", Offset = "0x19EEFA4", VA = "0x19EEFA4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009A3F")]
		[Address(RVA = "0x19EF2A4", Offset = "0x19EF2A4", VA = "0x19EF2A4", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6009A40")]
		[Address(RVA = "0x19EF2B8", Offset = "0x19EF2B8", VA = "0x19EF2B8", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400C48A")]
	[FieldOffset(Offset = "0xA0")]
	private UIFFWS03MainView m_View;

	[Token(Token = "0x400C48B")]
	[FieldOffset(Offset = "0xA4")]
	private UIModelFFWS03 m_ModelFFWS03;

	[Token(Token = "0x400C48C")]
	[FieldOffset(Offset = "0xA8")]
	private UIBigEventTopBtnBaseController m_TopBtnCtrl;

	[Token(Token = "0x400C48D")]
	private const string m_GuessGuideKey = "FFWS03GuideKey_";

	[Token(Token = "0x400C48E")]
	private const string m_TeamShowKey = "FFWS03TeamShowKey_";

	[Token(Token = "0x400C48F")]
	private const string m_AutoShowChampionKey = "FFWS03AutoShowChampionKey_";

	[Token(Token = "0x400C490")]
	private const string m_AutoShowWarmUpKey = "FFWS03AutoShowWarmUpKey_";

	[Token(Token = "0x400C491")]
	[FieldOffset(Offset = "0xAC")]
	private bool m_AutoShowChampion;

	[Token(Token = "0x400C492")]
	[FieldOffset(Offset = "0xB0")]
	private UICommonGuideController m_GuessGuideCtrl;

	[Token(Token = "0x400C493")]
	[FieldOffset(Offset = "0xB4")]
	private UIFFWS03WarmUpController m_WarmUpCtrl;

	[Token(Token = "0x6009A1C")]
	[Address(RVA = "0x19EBE90", Offset = "0x19EBE90", VA = "0x19EBE90")]
	public UIFFWS03MainController()
	{
	}

	[Token(Token = "0x6009A1D")]
	[Address(RVA = "0x19EBE98", Offset = "0x19EBE98", VA = "0x19EBE98")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009A1E")]
	[Address(RVA = "0x19EBF40", Offset = "0x19EBF40", VA = "0x19EBF40", Slot = "44")]
	public override EActivity.SubType GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x6009A1F")]
	[Address(RVA = "0x19EBF98", Offset = "0x19EBF98", VA = "0x19EBF98", Slot = "43")]
	public override ELimitedEvent.EventID GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x6009A20")]
	[Address(RVA = "0x19EBFF0", Offset = "0x19EBFF0", VA = "0x19EBFF0", Slot = "49")]
	public override string GetEntranceOverStateTipKey()
	{
		return null;
	}

	[Token(Token = "0x6009A21")]
	[Address(RVA = "0x19EC094", Offset = "0x19EC094", VA = "0x19EC094", Slot = "51")]
	public override UIBigEventPeakDayWndBaseController GetPeakDayWndCtrl()
	{
		return null;
	}

	[Token(Token = "0x6009A22")]
	[Address(RVA = "0x19EC1A4", Offset = "0x19EC1A4", VA = "0x19EC1A4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009A23")]
	[Address(RVA = "0x19ED378", Offset = "0x19ED378", VA = "0x19ED378", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x6009A24")]
	[Address(RVA = "0x19ED60C", Offset = "0x19ED60C", VA = "0x19ED60C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6009A25")]
	[Address(RVA = "0x19ED694", Offset = "0x19ED694", VA = "0x19ED694", Slot = "54")]
	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6009A26")]
	[Address(RVA = "0x19ED738", Offset = "0x19ED738", VA = "0x19ED738", Slot = "53")]
	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6009A27")]
	[Address(RVA = "0x19ED90C", Offset = "0x19ED90C", VA = "0x19ED90C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6009A28")]
	[Address(RVA = "0x19EDE54", Offset = "0x19EDE54", VA = "0x19EDE54")]
	private void OnWarmUpClose()
	{
	}

	[Token(Token = "0x6009A29")]
	[Address(RVA = "0x19EDEE4", Offset = "0x19EDEE4", VA = "0x19EDEE4")]
	private IEnumerator EnterAnimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6009A2A")]
	[Address(RVA = "0x19EDFB8", Offset = "0x19EDFB8", VA = "0x19EDFB8")]
	private void OnBtnRuleClick()
	{
	}

	[Token(Token = "0x6009A2B")]
	[Address(RVA = "0x19EE0F0", Offset = "0x19EE0F0", VA = "0x19EE0F0")]
	private void OnPlayNormalClickSound()
	{
	}

	[Token(Token = "0x6009A2C")]
	[Address(RVA = "0x19EE144", Offset = "0x19EE144", VA = "0x19EE144")]
	private void OnBtnManagerClick()
	{
	}

	[Token(Token = "0x6009A2D")]
	[Address(RVA = "0x19EE198", Offset = "0x19EE198", VA = "0x19EE198")]
	private void OnBtnGuessClick()
	{
	}

	[Token(Token = "0x6009A2E")]
	[Address(RVA = "0x19EE408", Offset = "0x19EE408", VA = "0x19EE408")]
	public void RefreshBtnTipState()
	{
	}

	[Token(Token = "0x6009A2F")]
	[Address(RVA = "0x19EDB14", Offset = "0x19EDB14", VA = "0x19EDB14")]
	private void OnBtnCupClick()
	{
	}

	[Token(Token = "0x6009A30")]
	[Address(RVA = "0x19EEC84", Offset = "0x19EEC84", VA = "0x19EEC84", Slot = "52")]
	public override void RefreshView()
	{
	}

	[Token(Token = "0x6009A31")]
	[Address(RVA = "0x19EEF3C", Offset = "0x19EEF3C", VA = "0x19EEF3C")]
	public EActivity.SubType _003C_003EiFixBaseProxy_GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x6009A32")]
	[Address(RVA = "0x19EEF44", Offset = "0x19EEF44", VA = "0x19EEF44")]
	public ELimitedEvent.EventID _003C_003EiFixBaseProxy_GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x6009A33")]
	[Address(RVA = "0x19EEF4C", Offset = "0x19EEF4C", VA = "0x19EEF4C")]
	public string _003C_003EiFixBaseProxy_GetEntranceOverStateTipKey()
	{
		return null;
	}

	[Token(Token = "0x6009A34")]
	[Address(RVA = "0x19EEF54", Offset = "0x19EEF54", VA = "0x19EEF54")]
	public UIBigEventPeakDayWndBaseController _003C_003EiFixBaseProxy_GetPeakDayWndCtrl()
	{
		return null;
	}

	[Token(Token = "0x6009A35")]
	[Address(RVA = "0x19EEF5C", Offset = "0x19EEF5C", VA = "0x19EEF5C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009A36")]
	[Address(RVA = "0x19EEF64", Offset = "0x19EEF64", VA = "0x19EEF64")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x6009A37")]
	[Address(RVA = "0x19EEF6C", Offset = "0x19EEF6C", VA = "0x19EEF6C")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6009A38")]
	[Address(RVA = "0x19EEF74", Offset = "0x19EEF74", VA = "0x19EEF74")]
	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return default(uint);
	}

	[Token(Token = "0x6009A39")]
	[Address(RVA = "0x19EEF7C", Offset = "0x19EEF7C", VA = "0x19EEF7C")]
	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}

	[Token(Token = "0x6009A3A")]
	[Address(RVA = "0x19EEF9C", Offset = "0x19EEF9C", VA = "0x19EEF9C")]
	public void _003C_003EiFixBaseProxy_RefreshView()
	{
	}
}
