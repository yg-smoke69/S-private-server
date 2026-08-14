using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x20027DF")]
public class UIHudObGlobalEventPollController : UIBaseController
{
	[Token(Token = "0x20027E0")]
	private struct PollResultItem
	{
		[Token(Token = "0x400F638")]
		[FieldOffset(Offset = "0x0")]
		public UILabel eventName;

		[Token(Token = "0x400F639")]
		[FieldOffset(Offset = "0x4")]
		public UILabel eventRatio;

		[Token(Token = "0x400F63A")]
		[FieldOffset(Offset = "0x8")]
		public UILabel eventCount;

		[Token(Token = "0x400F63B")]
		[FieldOffset(Offset = "0xC")]
		public UIProgressBar progressBar;

		[Token(Token = "0x400F63C")]
		[FieldOffset(Offset = "0x10")]
		public GameObject item;
	}

	[Token(Token = "0x20027E1")]
	private struct GlobalEventToggleItem
	{
		[Token(Token = "0x400F63D")]
		[FieldOffset(Offset = "0x0")]
		public uint eventID;

		[Token(Token = "0x400F63E")]
		[FieldOffset(Offset = "0x4")]
		public UILabel name;

		[Token(Token = "0x400F63F")]
		[FieldOffset(Offset = "0x8")]
		public UIToggleButton toggle;
	}

	[Token(Token = "0x400F62F")]
	[FieldOffset(Offset = "0x28")]
	private UIHudObGlobalEventPollView m_View;

	[Token(Token = "0x400F630")]
	[FieldOffset(Offset = "0x2C")]
	private LDAFPHICDJJ m_GameEventMgr;

	[Token(Token = "0x400F631")]
	[FieldOffset(Offset = "0x30")]
	private List<UIHudObGlobalEventPanelController.GlobalEventItem> m_OpenedCheckBox;

	[Token(Token = "0x400F632")]
	[FieldOffset(Offset = "0x34")]
	private List<GlobalEventToggleItem> m_OpenedToggleBtns;

	[Token(Token = "0x400F633")]
	[FieldOffset(Offset = "0x38")]
	private List<PollResultItem> m_OpenedPollResults;

	[Token(Token = "0x400F634")]
	[FieldOffset(Offset = "0x3C")]
	private List<byte> m_EventIdListSelected;

	[Token(Token = "0x400F635")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<EventDelegate> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400F636")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<EventDelegate> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400F637")]
	[FieldOffset(Offset = "0x8")]
	private static Comparison<FFKKHGEMNAN> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x600F728")]
	[Address(RVA = "0x1F6431C", Offset = "0x1F6431C", VA = "0x1F6431C")]
	public UIHudObGlobalEventPollController()
	{
	}

	[Token(Token = "0x600F729")]
	[Address(RVA = "0x1F64470", Offset = "0x1F64470", VA = "0x1F64470")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F72A")]
	[Address(RVA = "0x1F64518", Offset = "0x1F64518", VA = "0x1F64518", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F72B")]
	[Address(RVA = "0x1F64B2C", Offset = "0x1F64B2C", VA = "0x1F64B2C", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F72C")]
	[Address(RVA = "0x1F64878", Offset = "0x1F64878", VA = "0x1F64878")]
	private void SetUIData()
	{
	}

	[Token(Token = "0x600F72D")]
	[Address(RVA = "0x1F659A0", Offset = "0x1F659A0", VA = "0x1F659A0")]
	public void SetPollData()
	{
	}

	[Token(Token = "0x600F72E")]
	[Address(RVA = "0x1F67834", Offset = "0x1F67834", VA = "0x1F67834")]
	private void OnEventCheckBoxClick(object obj, int idx)
	{
	}

	[Token(Token = "0x600F72F")]
	[Address(RVA = "0x1F679C0", Offset = "0x1F679C0", VA = "0x1F679C0")]
	private void OnEventToggleClick(object obj, int idx)
	{
	}

	[Token(Token = "0x600F730")]
	[Address(RVA = "0x1F67728", Offset = "0x1F67728", VA = "0x1F67728")]
	private void RefreshConfirmBtn()
	{
	}

	[Token(Token = "0x600F731")]
	[Address(RVA = "0x1F64C20", Offset = "0x1F64C20", VA = "0x1F64C20")]
	public void SetResultData()
	{
	}

	[Token(Token = "0x600F732")]
	[Address(RVA = "0x1F67AF4", Offset = "0x1F67AF4", VA = "0x1F67AF4")]
	private void OnPollNtf(object[] data)
	{
	}

	[Token(Token = "0x600F733")]
	[Address(RVA = "0x1F67B5C", Offset = "0x1F67B5C", VA = "0x1F67B5C")]
	private void OnConfirm()
	{
	}

	[Token(Token = "0x600F734")]
	[Address(RVA = "0x1F68000", Offset = "0x1F68000", VA = "0x1F68000")]
	private void OnClose()
	{
	}

	[Token(Token = "0x600F735")]
	[Address(RVA = "0x1F6806C", Offset = "0x1F6806C", VA = "0x1F6806C")]
	private static bool _003CSetPollData_003Em__0(EventDelegate d)
	{
		return default(bool);
	}

	[Token(Token = "0x600F736")]
	[Address(RVA = "0x1F68120", Offset = "0x1F68120", VA = "0x1F68120")]
	private static bool _003CSetPollData_003Em__1(EventDelegate d)
	{
		return default(bool);
	}

	[Token(Token = "0x600F737")]
	[Address(RVA = "0x1F681D4", Offset = "0x1F681D4", VA = "0x1F681D4")]
	private static int _003CSetResultData_003Em__2(FFKKHGEMNAN a, FFKKHGEMNAN b)
	{
		return default(int);
	}

	[Token(Token = "0x600F738")]
	[Address(RVA = "0x1F68220", Offset = "0x1F68220", VA = "0x1F68220")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F739")]
	[Address(RVA = "0x1F68228", Offset = "0x1F68228", VA = "0x1F68228")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
