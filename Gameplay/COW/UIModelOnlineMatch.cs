using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20031AB")]
public class UIModelOnlineMatch : UIBaseModel
{
	[Token(Token = "0x4012E42")]
	[FieldOffset(Offset = "0xC")]
	private OnlineMatch m_HighestPriorityOnlineMatch;

	[Token(Token = "0x4012E43")]
	[FieldOffset(Offset = "0x10")]
	private bool m_SetHighestPriorityOnlineMatch;

	[Token(Token = "0x4012E44")]
	[FieldOffset(Offset = "0x14")]
	private List<OnlineMatch> m_OnlineMatchList;

	[Token(Token = "0x4012E45")]
	public const uint PropID_AllOnlineMatchInfoReady = 2u;

	[Token(Token = "0x4012E46")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<OnlineMatch> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6014E20")]
	[Address(RVA = "0x2B0B998", Offset = "0x2B0B998", VA = "0x2B0B998")]
	public UIModelOnlineMatch()
	{
	}

	[Token(Token = "0x6014E21")]
	[Address(RVA = "0x2B0BA50", Offset = "0x2B0BA50", VA = "0x2B0BA50", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6014E22")]
	[Address(RVA = "0x2B0BAA8", Offset = "0x2B0BAA8", VA = "0x2B0BAA8")]
	public void InitOnlineMatchList()
	{
	}

	[Token(Token = "0x6014E23")]
	[Address(RVA = "0x2B0BD5C", Offset = "0x2B0BD5C", VA = "0x2B0BD5C", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6014E24")]
	[Address(RVA = "0x2B0BE58", Offset = "0x2B0BE58", VA = "0x2B0BE58")]
	public OnlineMatchEntranceState GetEntranceBtnState()
	{
		return default(OnlineMatchEntranceState);
	}

	[Token(Token = "0x6014E25")]
	[Address(RVA = "0x2B0C13C", Offset = "0x2B0C13C", VA = "0x2B0C13C")]
	public bool IsCupMatchEntranceActivated()
	{
		return default(bool);
	}

	[Token(Token = "0x6014E26")]
	[Address(RVA = "0x2B0BF88", Offset = "0x2B0BF88", VA = "0x2B0BF88")]
	public bool SetHighestPriorityMatchType()
	{
		return default(bool);
	}

	[Token(Token = "0x6014E27")]
	[Address(RVA = "0x2B0C2D4", Offset = "0x2B0C2D4", VA = "0x2B0C2D4")]
	public void SetEntranceWarmUpState()
	{
	}

	[Token(Token = "0x6014E28")]
	[Address(RVA = "0x2B0C3EC", Offset = "0x2B0C3EC", VA = "0x2B0C3EC")]
	public bool AllProtocalReady()
	{
		return default(bool);
	}

	[Token(Token = "0x6014E29")]
	[Address(RVA = "0x2B0C620", Offset = "0x2B0C620", VA = "0x2B0C620")]
	public void MatchProtocalReady()
	{
	}

	[Token(Token = "0x6014E2A")]
	[Address(RVA = "0x2B0C788", Offset = "0x2B0C788", VA = "0x2B0C788")]
	public bool CanShowEntranceCountDown()
	{
		return default(bool);
	}

	[Token(Token = "0x6014E2B")]
	[Address(RVA = "0x2B0C8A8", Offset = "0x2B0C8A8", VA = "0x2B0C8A8")]
	public ulong GetCountDownTime()
	{
		return default(ulong);
	}

	[Token(Token = "0x6014E2C")]
	[Address(RVA = "0x2B0C9CC", Offset = "0x2B0C9CC", VA = "0x2B0C9CC")]
	public void SetLobbyEntranceWarmUpPlayerPrefs()
	{
	}

	[Token(Token = "0x6014E2D")]
	[Address(RVA = "0x2B0CBE4", Offset = "0x2B0CBE4", VA = "0x2B0CBE4")]
	public void SetLobbyEntranceMatchOpenPlayerPrefs()
	{
	}

	[Token(Token = "0x6014E2E")]
	[Address(RVA = "0x2B0CDFC", Offset = "0x2B0CDFC", VA = "0x2B0CDFC")]
	private static int _003CSetHighestPriorityMatchType_003Em__0(OnlineMatch a, OnlineMatch b)
	{
		return default(int);
	}

	[Token(Token = "0x6014E2F")]
	[Address(RVA = "0x2B0D28C", Offset = "0x2B0D28C", VA = "0x2B0D28C")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
