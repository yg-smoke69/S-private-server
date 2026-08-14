using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C66")]
public class RoundResultShowTimeHudEntity : _Attribute
{
	[Token(Token = "0x40065FD")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x40065FE")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x40065FF")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x4006600")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x4006601")]
	[FieldOffset(Offset = "0x18")]
	public Action<int, int> OnShowTimeTypeChangeEvent;

	[Token(Token = "0x4006602")]
	[FieldOffset(Offset = "0x1C")]
	public Action<bool, bool> OnShowTwoTeamScoreChangeEvent;

	[Token(Token = "0x4006603")]
	[FieldOffset(Offset = "0x20")]
	public Action<int, int> OnLeftTeamScoreChangeEvent;

	[Token(Token = "0x4006604")]
	[FieldOffset(Offset = "0x24")]
	public Action<int, int> OnRightTeamScoreChangeEvent;

	[Token(Token = "0x4006605")]
	[FieldOffset(Offset = "0x28")]
	public Action<int, int> OnPhaseEndTimeChangeEvent;

	[Token(Token = "0x6005EE2")]
	[Address(RVA = "0x2418950", Offset = "0x2418950", VA = "0x2418950")]
	public RoundResultShowTimeHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005EE3")]
	[Address(RVA = "0x2418A68", Offset = "0x2418A68", VA = "0x2418A68", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005EE4")]
	[Address(RVA = "0x2418AC0", Offset = "0x2418AC0", VA = "0x2418AC0")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005EE5")]
	[Address(RVA = "0x2418BE4", Offset = "0x2418BE4", VA = "0x2418BE4")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005EE6")]
	[Address(RVA = "0x2418FC0", Offset = "0x2418FC0", VA = "0x2418FC0")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005EE7")]
	[Address(RVA = "0x24190A0", Offset = "0x24190A0", VA = "0x24190A0")]
	public bool OpenState()
	{
		return default(bool);
	}

	[Token(Token = "0x6005EE8")]
	[Address(RVA = "0x241917C", Offset = "0x241917C", VA = "0x241917C")]
	public int ShowTimeType()
	{
		return default(int);
	}

	[Token(Token = "0x6005EE9")]
	[Address(RVA = "0x2419258", Offset = "0x2419258", VA = "0x2419258")]
	public bool ShowTwoTeamScore()
	{
		return default(bool);
	}

	[Token(Token = "0x6005EEA")]
	[Address(RVA = "0x2419334", Offset = "0x2419334", VA = "0x2419334")]
	public int LeftTeamScore()
	{
		return default(int);
	}

	[Token(Token = "0x6005EEB")]
	[Address(RVA = "0x2419410", Offset = "0x2419410", VA = "0x2419410")]
	public int RightTeamScore()
	{
		return default(int);
	}

	[Token(Token = "0x6005EEC")]
	[Address(RVA = "0x24194EC", Offset = "0x24194EC", VA = "0x24194EC")]
	public int PhaseEndTime()
	{
		return default(int);
	}
}
