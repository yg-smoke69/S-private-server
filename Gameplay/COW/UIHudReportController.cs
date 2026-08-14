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

[Token(Token = "0x200282E")]
internal class UIHudReportController : UIPopupWindowController
{
	[Token(Token = "0x200282F")]
	private sealed class _003CInitToggle_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400F803")]
		[FieldOffset(Offset = "0x8")]
		internal UIHudReportController _0024this;

		[Token(Token = "0x400F804")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400F805")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400F806")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170011F2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600FA9E")]
			[Address(RVA = "0x13EBF90", Offset = "0x13EBF90", VA = "0x13EBF90", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011F3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600FA9F")]
			[Address(RVA = "0x13EBF98", Offset = "0x13EBF98", VA = "0x13EBF98", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600FA9C")]
		[Address(RVA = "0x13E6864", Offset = "0x13E6864", VA = "0x13E6864")]
		public _003CInitToggle_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600FA9D")]
		[Address(RVA = "0x13EBEAC", Offset = "0x13EBEAC", VA = "0x13EBEAC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600FAA0")]
		[Address(RVA = "0x13EBFA0", Offset = "0x13EBFA0", VA = "0x13EBFA0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600FAA1")]
		[Address(RVA = "0x13EBFB4", Offset = "0x13EBFB4", VA = "0x13EBFB4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002830")]
	private sealed class _003CSetUIData_003Ec__AnonStorey1
	{
		[Token(Token = "0x400F807")]
		[FieldOffset(Offset = "0x8")]
		internal ulong userId;

		[Token(Token = "0x600FAA2")]
		[Address(RVA = "0x13E96E4", Offset = "0x13E96E4", VA = "0x13E96E4")]
		public _003CSetUIData_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600FAA3")]
		[Address(RVA = "0x13EC03C", Offset = "0x13EC03C", VA = "0x13EC03C")]
		internal bool _003C_003Em__0(CandidateReporteeData item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400F7EE")]
	[FieldOffset(Offset = "0x48")]
	private UIHudReportView m_View;

	[Token(Token = "0x400F7EF")]
	[FieldOffset(Offset = "0x50")]
	private ulong m_ReporteeUserId;

	[Token(Token = "0x400F7F0")]
	[FieldOffset(Offset = "0x58")]
	private IHAAMHPPLMG m_ReporteePlayerId;

	[Token(Token = "0x400F7F1")]
	[FieldOffset(Offset = "0x70")]
	private string m_NickName;

	[Token(Token = "0x400F7F2")]
	[FieldOffset(Offset = "0x74")]
	private CandidateReporteeType m_ReporteeType;

	[Token(Token = "0x400F7F3")]
	[FieldOffset(Offset = "0x78")]
	private uint m_ReportReason;

	[Token(Token = "0x400F7F4")]
	[FieldOffset(Offset = "0x7C")]
	private List<UIHudReportMainReasonToggleController> m_MainReasonCtrlList;

	[Token(Token = "0x400F7F5")]
	[FieldOffset(Offset = "0x80")]
	private Dictionary<uint, List<UIHudReportSubReasonToggleController>> m_SubReasonCtrlDic;

	[Token(Token = "0x400F7F6")]
	[FieldOffset(Offset = "0x84")]
	private Dictionary<uint, List<uint>> m_ReasonDic;

	[Token(Token = "0x400F7F7")]
	[FieldOffset(Offset = "0x88")]
	private List<uint> m_SubReason;

	[Token(Token = "0x400F7F8")]
	[FieldOffset(Offset = "0x8C")]
	private UIToggleButtonGroup m_MainReasonToggleGroup;

	[Token(Token = "0x400F7F9")]
	[FieldOffset(Offset = "0x90")]
	private Vector3 m_BeginPosOfScrollView;

	[Token(Token = "0x400F7FA")]
	[FieldOffset(Offset = "0x9C")]
	private UIPopMenuSmallControler m_PopMenu;

	[Token(Token = "0x400F7FB")]
	[FieldOffset(Offset = "0xA0")]
	private List<PopMenuData> m_PopMenuList;

	[Token(Token = "0x400F7FC")]
	[FieldOffset(Offset = "0xA4")]
	private List<CandidateReporteeData> m_ReporteeList;

	[Token(Token = "0x400F7FD")]
	[FieldOffset(Offset = "0xA8")]
	private MatchStats m_MatchStats;

	[Token(Token = "0x400F7FE")]
	[FieldOffset(Offset = "0xB0")]
	private ulong m_MatchID;

	[Token(Token = "0x400F7FF")]
	[FieldOffset(Offset = "0xB8")]
	private bool m_InGame;

	[Token(Token = "0x400F800")]
	[FieldOffset(Offset = "0x0")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400F801")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<uint, ECreditScore.ReportType> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400F802")]
	[FieldOffset(Offset = "0x8")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x600FA80")]
	[Address(RVA = "0x13E6028", Offset = "0x13E6028", VA = "0x13E6028")]
	public UIHudReportController()
	{
	}

	[Token(Token = "0x600FA81")]
	[Address(RVA = "0x13E6208", Offset = "0x13E6208", VA = "0x13E6208")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FA82")]
	[Address(RVA = "0x13E62B0", Offset = "0x13E62B0", VA = "0x13E62B0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FA83")]
	[Address(RVA = "0x13E671C", Offset = "0x13E671C", VA = "0x13E671C", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600FA84")]
	[Address(RVA = "0x13E6798", Offset = "0x13E6798", VA = "0x13E6798")]
	private IEnumerator InitToggle()
	{
		return null;
	}

	[Token(Token = "0x600FA85")]
	[Address(RVA = "0x13E686C", Offset = "0x13E686C", VA = "0x13E686C")]
	private void IniteMainToggleGroup()
	{
	}

	[Token(Token = "0x600FA86")]
	[Address(RVA = "0x13E6FE8", Offset = "0x13E6FE8", VA = "0x13E6FE8")]
	private UIHudReportMainReasonToggleController OpenNewMainReasonController(ReportReason reason, UIHudReportMainReasonLineController lineCtrl)
	{
		return null;
	}

	[Token(Token = "0x600FA87")]
	[Address(RVA = "0x13E75C8", Offset = "0x13E75C8", VA = "0x13E75C8")]
	public void SetMatchData(MatchStats matchStats)
	{
	}

	[Token(Token = "0x600FA88")]
	[Address(RVA = "0x13E7628", Offset = "0x13E7628", VA = "0x13E7628")]
	private UIHudReportSubReasonToggleController OpenNewSubReasonController(ReportType subReason, UIHudReportMainReasonToggleController mainCtrl)
	{
		return null;
	}

	[Token(Token = "0x600FA89")]
	[Address(RVA = "0x13E7B44", Offset = "0x13E7B44", VA = "0x13E7B44")]
	private void GetSubReason()
	{
	}

	[Token(Token = "0x600FA8A")]
	[Address(RVA = "0x13E7FF0", Offset = "0x13E7FF0", VA = "0x13E7FF0")]
	private void MainReasonToggleSelected(object[] param)
	{
	}

	[Token(Token = "0x600FA8B")]
	[Address(RVA = "0x13E8458", Offset = "0x13E8458", VA = "0x13E8458")]
	private void InitSubReasonCtrl()
	{
	}

	[Token(Token = "0x600FA8C")]
	[Address(RVA = "0x13E8C4C", Offset = "0x13E8C4C", VA = "0x13E8C4C")]
	private void InitPos()
	{
	}

	[Token(Token = "0x600FA8D")]
	[Address(RVA = "0x13E8EAC", Offset = "0x13E8EAC", VA = "0x13E8EAC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600FA8E")]
	[Address(RVA = "0x13E8FE0", Offset = "0x13E8FE0", VA = "0x13E8FE0")]
	public void SetUIData(ulong userId, string name, IHAAMHPPLMG playerID, List<CandidateReporteeData> datas, uint gameMode, uint matchMode, uint groupMode, ulong matchID, bool InGame)
	{
	}

	[Token(Token = "0x600FA8F")]
	[Address(RVA = "0x13EA604", Offset = "0x13EA604", VA = "0x13EA604")]
	private void OnBtnConfirmClick()
	{
	}

	[Token(Token = "0x600FA90")]
	[Address(RVA = "0x13EB7D4", Offset = "0x13EB7D4", VA = "0x13EB7D4")]
	private void OnBtnConfrimSuccess()
	{
	}

	[Token(Token = "0x600FA91")]
	[Address(RVA = "0x13EB838", Offset = "0x13EB838", VA = "0x13EB838")]
	private void OnBtnCancelClick()
	{
	}

	[Token(Token = "0x600FA92")]
	[Address(RVA = "0x13E96EC", Offset = "0x13E96EC", VA = "0x13E96EC")]
	private void InitReasons(uint gameMode, uint matchMode, uint groupMode)
	{
	}

	[Token(Token = "0x600FA93")]
	[Address(RVA = "0x13EB954", Offset = "0x13EB954", VA = "0x13EB954")]
	private void GeneratePopList()
	{
	}

	[Token(Token = "0x600FA94")]
	[Address(RVA = "0x13EBCA8", Offset = "0x13EBCA8", VA = "0x13EBCA8")]
	private void UpdateUIData(object data)
	{
	}

	[Token(Token = "0x600FA95")]
	[Address(RVA = "0x13EA3E0", Offset = "0x13EA3E0", VA = "0x13EA3E0")]
	private string GetPrefix(CandidateReporteeType type)
	{
		return null;
	}

	[Token(Token = "0x600FA96")]
	[Address(RVA = "0x13EBE88", Offset = "0x13EBE88", VA = "0x13EBE88")]
	private static void _003COnBtnConfirmClick_003Em__0(HttpErrorCode errCode, object obj)
	{
	}

	[Token(Token = "0x600FA97")]
	[Address(RVA = "0x13EBE8C", Offset = "0x13EBE8C", VA = "0x13EBE8C")]
	private static ECreditScore.ReportType _003COnBtnConfirmClick_003Em__1(uint item)
	{
		return default(ECreditScore.ReportType);
	}

	[Token(Token = "0x600FA98")]
	[Address(RVA = "0x13EBE90", Offset = "0x13EBE90", VA = "0x13EBE90")]
	private static void _003COnBtnConfirmClick_003Em__2(HttpErrorCode errCode, object obj)
	{
	}

	[Token(Token = "0x600FA99")]
	[Address(RVA = "0x13EBE94", Offset = "0x13EBE94", VA = "0x13EBE94")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FA9A")]
	[Address(RVA = "0x13EBE9C", Offset = "0x13EBE9C", VA = "0x13EBE9C")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600FA9B")]
	[Address(RVA = "0x13EBEA4", Offset = "0x13EBEA4", VA = "0x13EBEA4")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
