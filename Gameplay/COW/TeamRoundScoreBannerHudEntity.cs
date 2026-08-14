using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C6D")]
public class TeamRoundScoreBannerHudEntity : _Attribute
{
	[Token(Token = "0x4006639")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x400663A")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x400663B")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x400663C")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x400663D")]
	[FieldOffset(Offset = "0x18")]
	public Action<bool, bool> OnLocSwitchChangeEvent;

	[Token(Token = "0x400663E")]
	[FieldOffset(Offset = "0x1C")]
	public Action<string, string> OnFirstScoreTitleLocKeyChangeEvent;

	[Token(Token = "0x400663F")]
	[FieldOffset(Offset = "0x20")]
	public Action<string, string> OnFirstScoreValueLocKeyChangeEvent;

	[Token(Token = "0x4006640")]
	[FieldOffset(Offset = "0x24")]
	public Action<List<object>, List<object>> OnFirstScoreValueLocKey_ParamsChangeEvent;

	[Token(Token = "0x4006641")]
	[FieldOffset(Offset = "0x28")]
	public Action<string, string> OnSecondScoreTitleLocKeyChangeEvent;

	[Token(Token = "0x4006642")]
	[FieldOffset(Offset = "0x2C")]
	public Action<string, string> OnSecondScoreValueLocKeyChangeEvent;

	[Token(Token = "0x4006643")]
	[FieldOffset(Offset = "0x30")]
	public Action<List<object>, List<object>> OnSecondScoreValueLocKey_ParamsChangeEvent;

	[Token(Token = "0x6005F2C")]
	[Address(RVA = "0x289F010", Offset = "0x289F010", VA = "0x289F010")]
	public TeamRoundScoreBannerHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005F2D")]
	[Address(RVA = "0x289F128", Offset = "0x289F128", VA = "0x289F128", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005F2E")]
	[Address(RVA = "0x289F180", Offset = "0x289F180", VA = "0x289F180")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005F2F")]
	[Address(RVA = "0x289F2AC", Offset = "0x289F2AC", VA = "0x289F2AC")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005F30")]
	[Address(RVA = "0x289FC7C", Offset = "0x289FC7C", VA = "0x289FC7C")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F31")]
	[Address(RVA = "0x289FD5C", Offset = "0x289FD5C", VA = "0x289FD5C")]
	public bool OpenState()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F32")]
	[Address(RVA = "0x289FE38", Offset = "0x289FE38", VA = "0x289FE38")]
	public bool LocSwitch()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F33")]
	[Address(RVA = "0x289FF14", Offset = "0x289FF14", VA = "0x289FF14")]
	public string FirstScoreTitleLocKey()
	{
		return null;
	}

	[Token(Token = "0x6005F34")]
	[Address(RVA = "0x289FFF0", Offset = "0x289FFF0", VA = "0x289FFF0")]
	public string FirstScoreValueLocKey()
	{
		return null;
	}

	[Token(Token = "0x6005F35")]
	[Address(RVA = "0x28A00CC", Offset = "0x28A00CC", VA = "0x28A00CC")]
	public List<object> FirstScoreValueLocKey_Params()
	{
		return null;
	}

	[Token(Token = "0x6005F36")]
	[Address(RVA = "0x28A01A8", Offset = "0x28A01A8", VA = "0x28A01A8")]
	public string SecondScoreTitleLocKey()
	{
		return null;
	}

	[Token(Token = "0x6005F37")]
	[Address(RVA = "0x28A0284", Offset = "0x28A0284", VA = "0x28A0284")]
	public string SecondScoreValueLocKey()
	{
		return null;
	}

	[Token(Token = "0x6005F38")]
	[Address(RVA = "0x28A0360", Offset = "0x28A0360", VA = "0x28A0360")]
	public List<object> SecondScoreValueLocKey_Params()
	{
		return null;
	}
}
