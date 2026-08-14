using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C68")]
public class SingleLeaderboardHudEntity : _Attribute
{
	[Token(Token = "0x400661C")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x400661D")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x400661E")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x400661F")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x4006620")]
	[FieldOffset(Offset = "0x18")]
	public Action<List<object>, List<object>> OnPlayersChangeEvent;

	[Token(Token = "0x4006621")]
	[FieldOffset(Offset = "0x1C")]
	public Action<List<object>, List<object>> OnPlayerRanksChangeEvent;

	[Token(Token = "0x4006622")]
	[FieldOffset(Offset = "0x20")]
	public Action<List<object>, List<object>> OnPlayerScoreTypesChangeEvent;

	[Token(Token = "0x6005F05")]
	[Address(RVA = "0x20EF37C", Offset = "0x20EF37C", VA = "0x20EF37C")]
	public SingleLeaderboardHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005F06")]
	[Address(RVA = "0x20EF494", Offset = "0x20EF494", VA = "0x20EF494", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005F07")]
	[Address(RVA = "0x20EF4EC", Offset = "0x20EF4EC", VA = "0x20EF4EC")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005F08")]
	[Address(RVA = "0x20EF610", Offset = "0x20EF610", VA = "0x20EF610")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005F09")]
	[Address(RVA = "0x20EFBB4", Offset = "0x20EFBB4", VA = "0x20EFBB4")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F0A")]
	[Address(RVA = "0x20EFC94", Offset = "0x20EFC94", VA = "0x20EFC94")]
	public bool OpenState()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F0B")]
	[Address(RVA = "0x20EFD70", Offset = "0x20EFD70", VA = "0x20EFD70")]
	public List<object> Players()
	{
		return null;
	}

	[Token(Token = "0x6005F0C")]
	[Address(RVA = "0x20EFE4C", Offset = "0x20EFE4C", VA = "0x20EFE4C")]
	public List<object> PlayerRanks()
	{
		return null;
	}

	[Token(Token = "0x6005F0D")]
	[Address(RVA = "0x20EFF28", Offset = "0x20EFF28", VA = "0x20EFF28")]
	public List<object> PlayerScoreTypes()
	{
		return null;
	}
}
