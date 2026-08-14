using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C74")]
public class TwoTeamRoundScoreBannerHudEntity : _Attribute
{
	[Token(Token = "0x400667B")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x400667C")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x400667D")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x400667E")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnLocSwitchChangeEvent;

	[Token(Token = "0x400667F")]
	[FieldOffset(Offset = "0x18")]
	public Action<int, int> OnRoundNumChangeEvent;

	[Token(Token = "0x4006680")]
	[FieldOffset(Offset = "0x1C")]
	public Action<int, int> OnLeftTeamIndexChangeEvent;

	[Token(Token = "0x4006681")]
	[FieldOffset(Offset = "0x20")]
	public Action<string, string> OnLeftTeamNameChangeEvent;

	[Token(Token = "0x4006682")]
	[FieldOffset(Offset = "0x24")]
	public Action<int, int> OnLeftTeamScoreChangeEvent;

	[Token(Token = "0x4006683")]
	[FieldOffset(Offset = "0x28")]
	public Action<string, string> OnRightTeamNameChangeEvent;

	[Token(Token = "0x4006684")]
	[FieldOffset(Offset = "0x2C")]
	public Action<int, int> OnRightTeamScoreChangeEvent;

	[Token(Token = "0x4006685")]
	[FieldOffset(Offset = "0x30")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x6005F7C")]
	[Address(RVA = "0x233CD70", Offset = "0x233CD70", VA = "0x233CD70")]
	public TwoTeamRoundScoreBannerHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005F7D")]
	[Address(RVA = "0x233CE80", Offset = "0x233CE80", VA = "0x233CE80", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005F7E")]
	[Address(RVA = "0x233CED8", Offset = "0x233CED8", VA = "0x233CED8")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005F7F")]
	[Address(RVA = "0x233CFFC", Offset = "0x233CFFC", VA = "0x233CFFC")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005F80")]
	[Address(RVA = "0x233D66C", Offset = "0x233D66C", VA = "0x233D66C")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F81")]
	[Address(RVA = "0x233D74C", Offset = "0x233D74C", VA = "0x233D74C")]
	public bool LocSwitch()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F82")]
	[Address(RVA = "0x233D828", Offset = "0x233D828", VA = "0x233D828")]
	public int RoundNum()
	{
		return default(int);
	}

	[Token(Token = "0x6005F83")]
	[Address(RVA = "0x233D904", Offset = "0x233D904", VA = "0x233D904")]
	public int LeftTeamIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6005F84")]
	[Address(RVA = "0x233D9E0", Offset = "0x233D9E0", VA = "0x233D9E0")]
	public string LeftTeamName()
	{
		return null;
	}

	[Token(Token = "0x6005F85")]
	[Address(RVA = "0x233DABC", Offset = "0x233DABC", VA = "0x233DABC")]
	public int LeftTeamScore()
	{
		return default(int);
	}

	[Token(Token = "0x6005F86")]
	[Address(RVA = "0x233DB98", Offset = "0x233DB98", VA = "0x233DB98")]
	public string RightTeamName()
	{
		return null;
	}

	[Token(Token = "0x6005F87")]
	[Address(RVA = "0x233DC74", Offset = "0x233DC74", VA = "0x233DC74")]
	public int RightTeamScore()
	{
		return default(int);
	}

	[Token(Token = "0x6005F88")]
	[Address(RVA = "0x233DD50", Offset = "0x233DD50", VA = "0x233DD50")]
	public bool OpenState()
	{
		return default(bool);
	}
}
