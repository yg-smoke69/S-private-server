using System;
using System.Collections.Generic;
using System.Text;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200282A")]
public class UIHudReplayCtrlController : UIBaseController
{
	[Token(Token = "0x400F7CC")]
	[FieldOffset(Offset = "0x28")]
	private UIHudReplayCtrlView m_View;

	[Token(Token = "0x400F7CD")]
	[FieldOffset(Offset = "0x2C")]
	private MobileReplayManager m_ReplayMgr;

	[Token(Token = "0x400F7CE")]
	[FieldOffset(Offset = "0x30")]
	private StringBuilder m_StrBuilder;

	[Token(Token = "0x400F7CF")]
	[FieldOffset(Offset = "0x38")]
	private TimeSpan m_TimeSpan;

	[Token(Token = "0x400F7D0")]
	[FieldOffset(Offset = "0x40")]
	private string m_TotalTime;

	[Token(Token = "0x400F7D1")]
	[FieldOffset(Offset = "0x44")]
	private uint m_TickCount;

	[Token(Token = "0x400F7D2")]
	[FieldOffset(Offset = "0x48")]
	private readonly List<uint> REPLAY_EVENT_LIST;

	[Token(Token = "0x400F7D3")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_NeedUpdateProgress;

	[Token(Token = "0x400F7D4")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 m_TopLeftPos;

	[Token(Token = "0x400F7D5")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 m_TopRightPos;

	[Token(Token = "0x400F7D6")]
	[FieldOffset(Offset = "0x68")]
	private bool m_Show;

	[Token(Token = "0x400F7D7")]
	[FieldOffset(Offset = "0x6C")]
	private uint m_DelayCallID;

	[Token(Token = "0x400F7D8")]
	[FieldOffset(Offset = "0x70")]
	private uint m_HighlightVFXDelayCall;

	[Token(Token = "0x600FA60")]
	[Address(RVA = "0x13E10D8", Offset = "0x13E10D8", VA = "0x13E10D8")]
	public UIHudReplayCtrlController()
	{
	}

	[Token(Token = "0x600FA61")]
	[Address(RVA = "0x13E1238", Offset = "0x13E1238", VA = "0x13E1238")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FA62")]
	[Address(RVA = "0x13E12E0", Offset = "0x13E12E0", VA = "0x13E12E0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FA63")]
	[Address(RVA = "0x13E2A84", Offset = "0x13E2A84", VA = "0x13E2A84", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FA64")]
	[Address(RVA = "0x13E2C74", Offset = "0x13E2C74", VA = "0x13E2C74")]
	private void OnPlayClcik()
	{
	}

	[Token(Token = "0x600FA65")]
	[Address(RVA = "0x13E2300", Offset = "0x13E2300", VA = "0x13E2300")]
	private void InitGameEvent()
	{
	}

	[Token(Token = "0x600FA66")]
	[Address(RVA = "0x13E2DA0", Offset = "0x13E2DA0", VA = "0x13E2DA0")]
	private void OnPauseClcik()
	{
	}

	[Token(Token = "0x600FA67")]
	[Address(RVA = "0x13E2ED4", Offset = "0x13E2ED4", VA = "0x13E2ED4")]
	private void OnMinusSpeed()
	{
	}

	[Token(Token = "0x600FA68")]
	[Address(RVA = "0x13E2F58", Offset = "0x13E2F58", VA = "0x13E2F58")]
	private void OnPlusSpeed()
	{
	}

	[Token(Token = "0x600FA69")]
	[Address(RVA = "0x13E2FDC", Offset = "0x13E2FDC", VA = "0x13E2FDC")]
	private void OnExitClick()
	{
	}

	[Token(Token = "0x600FA6A")]
	[Address(RVA = "0x13E3280", Offset = "0x13E3280", VA = "0x13E3280")]
	private void OnJumpClick()
	{
	}

	[Token(Token = "0x600FA6B")]
	[Address(RVA = "0x13E34D0", Offset = "0x13E34D0", VA = "0x13E34D0")]
	private void OnToggleClick()
	{
	}

	[Token(Token = "0x600FA6C")]
	[Address(RVA = "0x13E2790", Offset = "0x13E2790", VA = "0x13E2790")]
	private void SetHighlightUI()
	{
	}

	[Token(Token = "0x600FA6D")]
	[Address(RVA = "0x13E39E4", Offset = "0x13E39E4", VA = "0x13E39E4")]
	private void OnHighlightClick()
	{
	}

	[Token(Token = "0x600FA6E")]
	[Address(RVA = "0x13E41D4", Offset = "0x13E41D4", VA = "0x13E41D4")]
	private void OnNoHighlightClick()
	{
	}

	[Token(Token = "0x600FA6F")]
	[Address(RVA = "0x13E43D4", Offset = "0x13E43D4", VA = "0x13E43D4")]
	private void OnReplayBtnClick()
	{
	}

	[Token(Token = "0x600FA70")]
	[Address(RVA = "0x13E4578", Offset = "0x13E4578", VA = "0x13E4578")]
	private void OnOverlookCamBtnClick()
	{
	}

	[Token(Token = "0x600FA71")]
	[Address(RVA = "0x13E3E6C", Offset = "0x13E3E6C", VA = "0x13E3E6C")]
	private void OnNormalCamBtnClick()
	{
	}

	[Token(Token = "0x600FA72")]
	[Address(RVA = "0x13E4AD4", Offset = "0x13E4AD4", VA = "0x13E4AD4")]
	private void OnMusicBtnChange()
	{
	}

	[Token(Token = "0x600FA73")]
	[Address(RVA = "0x13E4B60", Offset = "0x13E4B60", VA = "0x13E4B60")]
	private void OnChange()
	{
	}

	[Token(Token = "0x600FA74")]
	[Address(RVA = "0x13E292C", Offset = "0x13E292C", VA = "0x13E292C")]
	private void StartHide()
	{
	}

	[Token(Token = "0x600FA75")]
	[Address(RVA = "0x13E4E74", Offset = "0x13E4E74", VA = "0x13E4E74")]
	private void OnPlaySpeedChanged(object[] data)
	{
	}

	[Token(Token = "0x600FA76")]
	[Address(RVA = "0x13E3580", Offset = "0x13E3580", VA = "0x13E3580")]
	private void OnStartHighlightVFX(object[] data)
	{
	}

	[Token(Token = "0x600FA77")]
	[Address(RVA = "0x13E4FC0", Offset = "0x13E4FC0", VA = "0x13E4FC0")]
	private void Update()
	{
	}

	[Token(Token = "0x600FA78")]
	[Address(RVA = "0x13E531C", Offset = "0x13E531C", VA = "0x13E531C")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600FA79")]
	[Address(RVA = "0x13E5328", Offset = "0x13E5328", VA = "0x13E5328")]
	private void _003CStartHide_003Em__1()
	{
	}

	[Token(Token = "0x600FA7A")]
	[Address(RVA = "0x13E5378", Offset = "0x13E5378", VA = "0x13E5378")]
	private void _003COnStartHighlightVFX_003Em__2()
	{
	}

	[Token(Token = "0x600FA7B")]
	[Address(RVA = "0x13E545C", Offset = "0x13E545C", VA = "0x13E545C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FA7C")]
	[Address(RVA = "0x13E5464", Offset = "0x13E5464", VA = "0x13E5464")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
