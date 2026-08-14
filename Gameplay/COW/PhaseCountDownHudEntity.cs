using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C5C")]
public class PhaseCountDownHudEntity : _Attribute
{
	[Token(Token = "0x40065C0")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x40065C1")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x40065C2")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x40065C3")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x40065C4")]
	[FieldOffset(Offset = "0x18")]
	public Action<int, int> OnBaseTimeSChangeEvent;

	[Token(Token = "0x40065C5")]
	[FieldOffset(Offset = "0x1C")]
	public Action<int, int> OnDurationTimeSChangeEvent;

	[Token(Token = "0x6005E91")]
	[Address(RVA = "0x1C015B0", Offset = "0x1C015B0", VA = "0x1C015B0")]
	public PhaseCountDownHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005E92")]
	[Address(RVA = "0x1C016C8", Offset = "0x1C016C8", VA = "0x1C016C8", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005E93")]
	[Address(RVA = "0x1C01720", Offset = "0x1C01720", VA = "0x1C01720")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005E94")]
	[Address(RVA = "0x1C0183C", Offset = "0x1C0183C", VA = "0x1C0183C")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005E95")]
	[Address(RVA = "0x1C01ADC", Offset = "0x1C01ADC", VA = "0x1C01ADC")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E96")]
	[Address(RVA = "0x1C01BBC", Offset = "0x1C01BBC", VA = "0x1C01BBC")]
	public bool OpenState()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E97")]
	[Address(RVA = "0x1C01C98", Offset = "0x1C01C98", VA = "0x1C01C98")]
	public int BaseTimeS()
	{
		return default(int);
	}

	[Token(Token = "0x6005E98")]
	[Address(RVA = "0x1C01D74", Offset = "0x1C01D74", VA = "0x1C01D74")]
	public int DurationTimeS()
	{
		return default(int);
	}
}
