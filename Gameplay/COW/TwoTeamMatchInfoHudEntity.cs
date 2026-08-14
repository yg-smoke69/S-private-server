using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C72")]
public class TwoTeamMatchInfoHudEntity : _Attribute
{
	[Token(Token = "0x4006665")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x4006666")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x4006667")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x4006668")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x4006669")]
	[FieldOffset(Offset = "0x18")]
	public Action<bool, bool> OnShowTeamScoreChangeEvent;

	[Token(Token = "0x400666A")]
	[FieldOffset(Offset = "0x1C")]
	public Action<int, int> OnLeftTeamScoreChangeEvent;

	[Token(Token = "0x400666B")]
	[FieldOffset(Offset = "0x20")]
	public Action<int, int> OnRightTeamScoreChangeEvent;

	[Token(Token = "0x400666C")]
	[FieldOffset(Offset = "0x24")]
	public Action<bool, bool> OnShowTeammateStateChangeEvent;

	[Token(Token = "0x400666D")]
	[FieldOffset(Offset = "0x28")]
	public Action<List<object>, List<object>> OnLeftTeammateStateArrayChangeEvent;

	[Token(Token = "0x400666E")]
	[FieldOffset(Offset = "0x2C")]
	public Action<List<object>, List<object>> OnRightTeammateStateArrayChangeEvent;

	[Token(Token = "0x400666F")]
	[FieldOffset(Offset = "0x30")]
	public Action<int, int> OnLeftTeammateFlagCountChangeEvent;

	[Token(Token = "0x4006670")]
	[FieldOffset(Offset = "0x34")]
	public Action<int, int> OnRightTeammateFlagCountChangeEvent;

	[Token(Token = "0x6005F62")]
	[Address(RVA = "0x233ABF4", Offset = "0x233ABF4", VA = "0x233ABF4")]
	public TwoTeamMatchInfoHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005F63")]
	[Address(RVA = "0x233AD04", Offset = "0x233AD04", VA = "0x233AD04", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005F64")]
	[Address(RVA = "0x233AD5C", Offset = "0x233AD5C", VA = "0x233AD5C")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005F65")]
	[Address(RVA = "0x233AE84", Offset = "0x233AE84", VA = "0x233AE84")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005F66")]
	[Address(RVA = "0x233B568", Offset = "0x233B568", VA = "0x233B568")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F67")]
	[Address(RVA = "0x233B648", Offset = "0x233B648", VA = "0x233B648")]
	public bool OpenState()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F68")]
	[Address(RVA = "0x233B724", Offset = "0x233B724", VA = "0x233B724")]
	public bool ShowTeamScore()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F69")]
	[Address(RVA = "0x233B800", Offset = "0x233B800", VA = "0x233B800")]
	public int LeftTeamScore()
	{
		return default(int);
	}

	[Token(Token = "0x6005F6A")]
	[Address(RVA = "0x233B8DC", Offset = "0x233B8DC", VA = "0x233B8DC")]
	public int RightTeamScore()
	{
		return default(int);
	}

	[Token(Token = "0x6005F6B")]
	[Address(RVA = "0x233B9B8", Offset = "0x233B9B8", VA = "0x233B9B8")]
	public bool ShowTeammateState()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F6C")]
	[Address(RVA = "0x233BA94", Offset = "0x233BA94", VA = "0x233BA94")]
	public List<object> LeftTeammateStateArray()
	{
		return null;
	}

	[Token(Token = "0x6005F6D")]
	[Address(RVA = "0x233BB70", Offset = "0x233BB70", VA = "0x233BB70")]
	public List<object> RightTeammateStateArray()
	{
		return null;
	}

	[Token(Token = "0x6005F6E")]
	[Address(RVA = "0x233BC4C", Offset = "0x233BC4C", VA = "0x233BC4C")]
	public int LeftTeammateFlagCount()
	{
		return default(int);
	}

	[Token(Token = "0x6005F6F")]
	[Address(RVA = "0x233BD28", Offset = "0x233BD28", VA = "0x233BD28")]
	public int RightTeammateFlagCount()
	{
		return default(int);
	}
}
