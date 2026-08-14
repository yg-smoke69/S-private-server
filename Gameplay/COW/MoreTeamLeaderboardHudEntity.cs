using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C59")]
public class MoreTeamLeaderboardHudEntity : _Attribute
{
	[Token(Token = "0x40065A5")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x40065A6")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x40065A7")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x40065A8")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x40065A9")]
	[FieldOffset(Offset = "0x18")]
	public Action<List<object>, List<object>> OnTeamIndexsChangeEvent;

	[Token(Token = "0x40065AA")]
	[FieldOffset(Offset = "0x1C")]
	public Action<List<object>, List<object>> OnTeamRanksChangeEvent;

	[Token(Token = "0x40065AB")]
	[FieldOffset(Offset = "0x20")]
	public Action<List<object>, List<object>> OnTeamScoresChangeEvent;

	[Token(Token = "0x40065AC")]
	[FieldOffset(Offset = "0x24")]
	public Action<List<object>, List<object>> OnTeamColorsChangeEvent;

	[Token(Token = "0x40065AD")]
	[FieldOffset(Offset = "0x28")]
	public Action<List<object>, List<object>> OnPlayerScoreTypesChangeEvent;

	[Token(Token = "0x6005E70")]
	[Address(RVA = "0x228EEA8", Offset = "0x228EEA8", VA = "0x228EEA8")]
	public MoreTeamLeaderboardHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005E71")]
	[Address(RVA = "0x228EFC0", Offset = "0x228EFC0", VA = "0x228EFC0", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005E72")]
	[Address(RVA = "0x228F018", Offset = "0x228F018", VA = "0x228F018")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005E73")]
	[Address(RVA = "0x228F13C", Offset = "0x228F13C", VA = "0x228F13C")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005E74")]
	[Address(RVA = "0x228F960", Offset = "0x228F960", VA = "0x228F960")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E75")]
	[Address(RVA = "0x228FA40", Offset = "0x228FA40", VA = "0x228FA40")]
	public bool OpenState()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E76")]
	[Address(RVA = "0x228FB1C", Offset = "0x228FB1C", VA = "0x228FB1C")]
	public List<object> TeamIndexs()
	{
		return null;
	}

	[Token(Token = "0x6005E77")]
	[Address(RVA = "0x228FBF8", Offset = "0x228FBF8", VA = "0x228FBF8")]
	public List<object> TeamRanks()
	{
		return null;
	}

	[Token(Token = "0x6005E78")]
	[Address(RVA = "0x228FCD4", Offset = "0x228FCD4", VA = "0x228FCD4")]
	public List<object> TeamScores()
	{
		return null;
	}

	[Token(Token = "0x6005E79")]
	[Address(RVA = "0x228FDB0", Offset = "0x228FDB0", VA = "0x228FDB0")]
	public List<object> TeamColors()
	{
		return null;
	}

	[Token(Token = "0x6005E7A")]
	[Address(RVA = "0x228FE8C", Offset = "0x228FE8C", VA = "0x228FE8C")]
	public List<object> PlayerScoreTypes()
	{
		return null;
	}
}
