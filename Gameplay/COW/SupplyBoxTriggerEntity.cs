using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C6A")]
public class SupplyBoxTriggerEntity : _Attribute
{
	[Token(Token = "0x4006626")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x4006627")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x4006628")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x4006629")]
	[FieldOffset(Offset = "0x14")]
	public Action<int, int> OnModelChangeEvent;

	[Token(Token = "0x6005F13")]
	[Address(RVA = "0x2891928", Offset = "0x2891928", VA = "0x2891928")]
	public SupplyBoxTriggerEntity(string entityID)
	{
	}

	[Token(Token = "0x6005F14")]
	[Address(RVA = "0x2891A40", Offset = "0x2891A40", VA = "0x2891A40", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005F15")]
	[Address(RVA = "0x2891A98", Offset = "0x2891A98", VA = "0x2891A98")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005F16")]
	[Address(RVA = "0x2891BB4", Offset = "0x2891BB4", VA = "0x2891BB4")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005F17")]
	[Address(RVA = "0x2891D78", Offset = "0x2891D78", VA = "0x2891D78")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F18")]
	[Address(RVA = "0x2891E58", Offset = "0x2891E58", VA = "0x2891E58")]
	public int Model()
	{
		return default(int);
	}
}
