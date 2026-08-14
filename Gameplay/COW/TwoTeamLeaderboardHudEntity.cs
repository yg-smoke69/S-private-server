using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C71")]
public class TwoTeamLeaderboardHudEntity : _Attribute
{
	[Token(Token = "0x400665C")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x400665D")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x400665E")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x400665F")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x4006660")]
	[FieldOffset(Offset = "0x18")]
	public Action<int, int> OnLeftTeamIndexChangeEvent;

	[Token(Token = "0x4006661")]
	[FieldOffset(Offset = "0x1C")]
	public Action<int, int> OnRightTeamIndexChangeEvent;

	[Token(Token = "0x4006662")]
	[FieldOffset(Offset = "0x20")]
	public Action<int, int> OnLeftTeamScoreChangeEvent;

	[Token(Token = "0x4006663")]
	[FieldOffset(Offset = "0x24")]
	public Action<int, int> OnRightTeamScoreChangeEvent;

	[Token(Token = "0x4006664")]
	[FieldOffset(Offset = "0x28")]
	public Action<List<object>, List<object>> OnPlayerScoreTypesChangeEvent;

	[Token(Token = "0x6005F57")]
	[Address(RVA = "0x2339E9C", Offset = "0x2339E9C", VA = "0x2339E9C")]
	public TwoTeamLeaderboardHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005F58")]
	[Address(RVA = "0x2339FAC", Offset = "0x2339FAC", VA = "0x2339FAC", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005F59")]
	[Address(RVA = "0x233A004", Offset = "0x233A004", VA = "0x233A004")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005F5A")]
	[Address(RVA = "0x233A120", Offset = "0x233A120", VA = "0x233A120")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005F5B")]
	[Address(RVA = "0x233A5EC", Offset = "0x233A5EC", VA = "0x233A5EC")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F5C")]
	[Address(RVA = "0x233A6CC", Offset = "0x233A6CC", VA = "0x233A6CC")]
	public bool OpenState()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F5D")]
	[Address(RVA = "0x233A7A8", Offset = "0x233A7A8", VA = "0x233A7A8")]
	public int LeftTeamIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6005F5E")]
	[Address(RVA = "0x233A884", Offset = "0x233A884", VA = "0x233A884")]
	public int RightTeamIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6005F5F")]
	[Address(RVA = "0x233A960", Offset = "0x233A960", VA = "0x233A960")]
	public int LeftTeamScore()
	{
		return default(int);
	}

	[Token(Token = "0x6005F60")]
	[Address(RVA = "0x233AA3C", Offset = "0x233AA3C", VA = "0x233AA3C")]
	public int RightTeamScore()
	{
		return default(int);
	}

	[Token(Token = "0x6005F61")]
	[Address(RVA = "0x233AB18", Offset = "0x233AB18", VA = "0x233AB18")]
	public List<object> PlayerScoreTypes()
	{
		return null;
	}
}
