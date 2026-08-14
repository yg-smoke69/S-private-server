using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C6E")]
public class TimeTweenTipsHudEntity : _Attribute
{
	[Token(Token = "0x4006644")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x4006645")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x4006646")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x4006647")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x4006648")]
	[FieldOffset(Offset = "0x18")]
	public Action<bool, bool> OnLocSwitchChangeEvent;

	[Token(Token = "0x4006649")]
	[FieldOffset(Offset = "0x1C")]
	public Action<string, string> OnDescriptionChangeEvent;

	[Token(Token = "0x400664A")]
	[FieldOffset(Offset = "0x20")]
	public Action<int, int> OnCountDownBaseTimeSChangeEvent;

	[Token(Token = "0x400664B")]
	[FieldOffset(Offset = "0x24")]
	public Action<int, int> OnDurationTimeSChangeEvent;

	[Token(Token = "0x6005F39")]
	[Address(RVA = "0x28A64A4", Offset = "0x28A64A4", VA = "0x28A64A4")]
	public TimeTweenTipsHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005F3A")]
	[Address(RVA = "0x28A65BC", Offset = "0x28A65BC", VA = "0x28A65BC", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005F3B")]
	[Address(RVA = "0x28A6614", Offset = "0x28A6614", VA = "0x28A6614")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005F3C")]
	[Address(RVA = "0x28A673C", Offset = "0x28A673C", VA = "0x28A673C")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005F3D")]
	[Address(RVA = "0x28A6BA8", Offset = "0x28A6BA8", VA = "0x28A6BA8")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F3E")]
	[Address(RVA = "0x28A6C88", Offset = "0x28A6C88", VA = "0x28A6C88")]
	public bool OpenState()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F3F")]
	[Address(RVA = "0x28A6D64", Offset = "0x28A6D64", VA = "0x28A6D64")]
	public bool LocSwitch()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F40")]
	[Address(RVA = "0x28A6E40", Offset = "0x28A6E40", VA = "0x28A6E40")]
	public string Description()
	{
		return null;
	}

	[Token(Token = "0x6005F41")]
	[Address(RVA = "0x28A6F1C", Offset = "0x28A6F1C", VA = "0x28A6F1C")]
	public int CountDownBaseTimeS()
	{
		return default(int);
	}

	[Token(Token = "0x6005F42")]
	[Address(RVA = "0x28A6FF8", Offset = "0x28A6FF8", VA = "0x28A6FF8")]
	public int DurationTimeS()
	{
		return default(int);
	}
}
