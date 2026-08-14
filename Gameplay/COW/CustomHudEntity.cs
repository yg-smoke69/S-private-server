using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C45")]
public class CustomHudEntity : _Attribute
{
	[Token(Token = "0x4006513")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x4006514")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x4006515")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x4006516")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x4006517")]
	[FieldOffset(Offset = "0x18")]
	public Action<int, int> OnPrefabIDChangeEvent;

	[Token(Token = "0x6005DB6")]
	[Address(RVA = "0x1C87634", Offset = "0x1C87634", VA = "0x1C87634")]
	public CustomHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005DB7")]
	[Address(RVA = "0x1C8774C", Offset = "0x1C8774C", VA = "0x1C8774C", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005DB8")]
	[Address(RVA = "0x1C877A4", Offset = "0x1C877A4", VA = "0x1C877A4")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005DB9")]
	[Address(RVA = "0x1C878C4", Offset = "0x1C878C4", VA = "0x1C878C4")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005DBA")]
	[Address(RVA = "0x1C87AF8", Offset = "0x1C87AF8", VA = "0x1C87AF8")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005DBB")]
	[Address(RVA = "0x1C87BD8", Offset = "0x1C87BD8", VA = "0x1C87BD8")]
	public bool OpenState()
	{
		return default(bool);
	}

	[Token(Token = "0x6005DBC")]
	[Address(RVA = "0x1C87CB4", Offset = "0x1C87CB4", VA = "0x1C87CB4")]
	public int PrefabID()
	{
		return default(int);
	}
}
