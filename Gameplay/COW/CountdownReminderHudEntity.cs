using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C44")]
public class CountdownReminderHudEntity : _Attribute
{
	[Token(Token = "0x400650B")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x400650C")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x400650D")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x400650E")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x400650F")]
	[FieldOffset(Offset = "0x18")]
	public Action<int, int> OnDurationTimeSChangeEvent;

	[Token(Token = "0x4006510")]
	[FieldOffset(Offset = "0x1C")]
	public Action<string, string> OnDescriptionChangeEvent;

	[Token(Token = "0x4006511")]
	[FieldOffset(Offset = "0x20")]
	public Action<int, int> OnCountDownBaseTimeSChangeEvent;

	[Token(Token = "0x4006512")]
	[FieldOffset(Offset = "0x24")]
	public Action<List<object>, List<object>> OnDescriptionParamsChangeEvent;

	[Token(Token = "0x6005DAC")]
	[Address(RVA = "0x1C81018", Offset = "0x1C81018", VA = "0x1C81018")]
	public CountdownReminderHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005DAD")]
	[Address(RVA = "0x1C81130", Offset = "0x1C81130", VA = "0x1C81130", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005DAE")]
	[Address(RVA = "0x1C81188", Offset = "0x1C81188", VA = "0x1C81188")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005DAF")]
	[Address(RVA = "0x1C812B0", Offset = "0x1C812B0", VA = "0x1C812B0")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005DB0")]
	[Address(RVA = "0x1C817F8", Offset = "0x1C817F8", VA = "0x1C817F8")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005DB1")]
	[Address(RVA = "0x1C818D8", Offset = "0x1C818D8", VA = "0x1C818D8")]
	public bool OpenState()
	{
		return default(bool);
	}

	[Token(Token = "0x6005DB2")]
	[Address(RVA = "0x1C819B4", Offset = "0x1C819B4", VA = "0x1C819B4")]
	public int DurationTimeS()
	{
		return default(int);
	}

	[Token(Token = "0x6005DB3")]
	[Address(RVA = "0x1C81A90", Offset = "0x1C81A90", VA = "0x1C81A90")]
	public string Description()
	{
		return null;
	}

	[Token(Token = "0x6005DB4")]
	[Address(RVA = "0x1C81B6C", Offset = "0x1C81B6C", VA = "0x1C81B6C")]
	public int CountDownBaseTimeS()
	{
		return default(int);
	}

	[Token(Token = "0x6005DB5")]
	[Address(RVA = "0x1C81C48", Offset = "0x1C81C48", VA = "0x1C81C48")]
	public List<object> DescriptionParams()
	{
		return null;
	}
}
