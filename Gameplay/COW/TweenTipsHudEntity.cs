using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C6F")]
public class TweenTipsHudEntity : _Attribute
{
	[Token(Token = "0x400664C")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x400664D")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x400664E")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x400664F")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnLocSwitchChangeEvent;

	[Token(Token = "0x4006650")]
	[FieldOffset(Offset = "0x18")]
	public Action<int, int> OnEventTipsTypeChangeEvent;

	[Token(Token = "0x4006651")]
	[FieldOffset(Offset = "0x1C")]
	public Action<string, string> OnDescriptionChangeEvent;

	[Token(Token = "0x4006652")]
	[FieldOffset(Offset = "0x20")]
	public Action<List<object>, List<object>> OnParamsChangeEvent;

	[Token(Token = "0x6005F43")]
	[Address(RVA = "0x2336A30", Offset = "0x2336A30", VA = "0x2336A30")]
	public TweenTipsHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005F44")]
	[Address(RVA = "0x2336D20", Offset = "0x2336D20", VA = "0x2336D20", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005F45")]
	[Address(RVA = "0x2336D78", Offset = "0x2336D78", VA = "0x2336D78")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005F46")]
	[Address(RVA = "0x2337074", Offset = "0x2337074", VA = "0x2337074")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005F47")]
	[Address(RVA = "0x2337558", Offset = "0x2337558", VA = "0x2337558")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F48")]
	[Address(RVA = "0x2337638", Offset = "0x2337638", VA = "0x2337638")]
	public bool LocSwitch()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F49")]
	[Address(RVA = "0x2337714", Offset = "0x2337714", VA = "0x2337714")]
	public int EventTipsType()
	{
		return default(int);
	}

	[Token(Token = "0x6005F4A")]
	[Address(RVA = "0x23377F0", Offset = "0x23377F0", VA = "0x23377F0")]
	public string Description()
	{
		return null;
	}

	[Token(Token = "0x6005F4B")]
	[Address(RVA = "0x23378CC", Offset = "0x23378CC", VA = "0x23378CC")]
	public List<object> Params()
	{
		return null;
	}
}
