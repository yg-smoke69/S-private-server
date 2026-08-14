using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C67")]
public class RoundTransitionHudEntity : _Attribute
{
	[Token(Token = "0x4006606")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x4006607")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x4006608")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x4006609")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x400660A")]
	[FieldOffset(Offset = "0x18")]
	public Action<int, int> OnTransitionStageChangeEvent;

	[Token(Token = "0x400660B")]
	[FieldOffset(Offset = "0x1C")]
	public Action<int, int> OnLeftTeamScoreChangeEvent;

	[Token(Token = "0x400660C")]
	[FieldOffset(Offset = "0x20")]
	public Action<int, int> OnRightTeamScoreChangeEvent;

	[Token(Token = "0x400660D")]
	[FieldOffset(Offset = "0x24")]
	public Action<string, string> OnLeftTeamNameChangeEvent;

	[Token(Token = "0x400660E")]
	[FieldOffset(Offset = "0x28")]
	public Action<string, string> OnRightTeamNameChangeEvent;

	[Token(Token = "0x400660F")]
	[FieldOffset(Offset = "0x2C")]
	public Action<string, string> OnLeftIconSpriteNameChangeEvent;

	[Token(Token = "0x4006610")]
	[FieldOffset(Offset = "0x30")]
	public Action<string, string> OnRightIconSpriteNameChangeEvent;

	[Token(Token = "0x4006611")]
	[FieldOffset(Offset = "0x34")]
	public Action<int, int> OnResultTypeChangeEvent;

	[Token(Token = "0x4006612")]
	[FieldOffset(Offset = "0x38")]
	public Action<string, string> OnWinLocChangeEvent;

	[Token(Token = "0x4006613")]
	[FieldOffset(Offset = "0x3C")]
	public Action<string, string> OnLoseLocChangeEvent;

	[Token(Token = "0x4006614")]
	[FieldOffset(Offset = "0x40")]
	public Action<string, string> OnRoundIncomeTitleChangeEvent;

	[Token(Token = "0x4006615")]
	[FieldOffset(Offset = "0x44")]
	public Action<int, int> OnRoundIncomeChangeEvent;

	[Token(Token = "0x4006616")]
	[FieldOffset(Offset = "0x48")]
	public Action<List<object>, List<object>> OnRoundIncomeDetailTitleListChangeEvent;

	[Token(Token = "0x4006617")]
	[FieldOffset(Offset = "0x4C")]
	public Action<List<object>, List<object>> OnRoundIncomeDetailListChangeEvent;

	[Token(Token = "0x4006618")]
	[FieldOffset(Offset = "0x50")]
	public Action<string, string> OnMVPChangeEvent;

	[Token(Token = "0x4006619")]
	[FieldOffset(Offset = "0x54")]
	public Action<int, int> OnNextRoundIndexChangeEvent;

	[Token(Token = "0x400661A")]
	[FieldOffset(Offset = "0x58")]
	public Action<bool, bool> OnIsMatchPointChangeEvent;

	[Token(Token = "0x400661B")]
	[FieldOffset(Offset = "0x5C")]
	public Action<bool, bool> OnIsLastRoundChangeEvent;

	[Token(Token = "0x6005EED")]
	[Address(RVA = "0x24195C8", Offset = "0x24195C8", VA = "0x24195C8")]
	public RoundTransitionHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005EEE")]
	[Address(RVA = "0x24196E0", Offset = "0x24196E0", VA = "0x24196E0", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005EEF")]
	[Address(RVA = "0x2419738", Offset = "0x2419738", VA = "0x2419738")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005EF0")]
	[Address(RVA = "0x2419854", Offset = "0x2419854", VA = "0x2419854")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005EF1")]
	[Address(RVA = "0x241A9F4", Offset = "0x241A9F4", VA = "0x241A9F4")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005EF2")]
	[Address(RVA = "0x241AAD4", Offset = "0x241AAD4", VA = "0x241AAD4")]
	public bool OpenState()
	{
		return default(bool);
	}

	[Token(Token = "0x6005EF3")]
	[Address(RVA = "0x241ABB0", Offset = "0x241ABB0", VA = "0x241ABB0")]
	public int TransitionStage()
	{
		return default(int);
	}

	[Token(Token = "0x6005EF4")]
	[Address(RVA = "0x241AC8C", Offset = "0x241AC8C", VA = "0x241AC8C")]
	public int LeftTeamScore()
	{
		return default(int);
	}

	[Token(Token = "0x6005EF5")]
	[Address(RVA = "0x241AD68", Offset = "0x241AD68", VA = "0x241AD68")]
	public int RightTeamScore()
	{
		return default(int);
	}

	[Token(Token = "0x6005EF6")]
	[Address(RVA = "0x241AE44", Offset = "0x241AE44", VA = "0x241AE44")]
	public string LeftTeamName()
	{
		return null;
	}

	[Token(Token = "0x6005EF7")]
	[Address(RVA = "0x241AF20", Offset = "0x241AF20", VA = "0x241AF20")]
	public string RightTeamName()
	{
		return null;
	}

	[Token(Token = "0x6005EF8")]
	[Address(RVA = "0x241AFFC", Offset = "0x241AFFC", VA = "0x241AFFC")]
	public string LeftIconSpriteName()
	{
		return null;
	}

	[Token(Token = "0x6005EF9")]
	[Address(RVA = "0x241B0D8", Offset = "0x241B0D8", VA = "0x241B0D8")]
	public string RightIconSpriteName()
	{
		return null;
	}

	[Token(Token = "0x6005EFA")]
	[Address(RVA = "0x241B1B4", Offset = "0x241B1B4", VA = "0x241B1B4")]
	public int ResultType()
	{
		return default(int);
	}

	[Token(Token = "0x6005EFB")]
	[Address(RVA = "0x241B290", Offset = "0x241B290", VA = "0x241B290")]
	public string WinLoc()
	{
		return null;
	}

	[Token(Token = "0x6005EFC")]
	[Address(RVA = "0x241B36C", Offset = "0x241B36C", VA = "0x241B36C")]
	public string LoseLoc()
	{
		return null;
	}

	[Token(Token = "0x6005EFD")]
	[Address(RVA = "0x241B448", Offset = "0x241B448", VA = "0x241B448")]
	public string RoundIncomeTitle()
	{
		return null;
	}

	[Token(Token = "0x6005EFE")]
	[Address(RVA = "0x241B524", Offset = "0x241B524", VA = "0x241B524")]
	public int RoundIncome()
	{
		return default(int);
	}

	[Token(Token = "0x6005EFF")]
	[Address(RVA = "0x241B600", Offset = "0x241B600", VA = "0x241B600")]
	public List<object> RoundIncomeDetailTitleList()
	{
		return null;
	}

	[Token(Token = "0x6005F00")]
	[Address(RVA = "0x241B6DC", Offset = "0x241B6DC", VA = "0x241B6DC")]
	public List<object> RoundIncomeDetailList()
	{
		return null;
	}

	[Token(Token = "0x6005F01")]
	[Address(RVA = "0x241B7B8", Offset = "0x241B7B8", VA = "0x241B7B8")]
	public string MVP()
	{
		return null;
	}

	[Token(Token = "0x6005F02")]
	[Address(RVA = "0x241B894", Offset = "0x241B894", VA = "0x241B894")]
	public int NextRoundIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6005F03")]
	[Address(RVA = "0x241B970", Offset = "0x241B970", VA = "0x241B970")]
	public bool IsMatchPoint()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F04")]
	[Address(RVA = "0x241BA4C", Offset = "0x241BA4C", VA = "0x241BA4C")]
	public bool IsLastRound()
	{
		return default(bool);
	}
}
