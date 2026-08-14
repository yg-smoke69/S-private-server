using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C54")]
public class InternalHudEntity : _Attribute
{
	[Token(Token = "0x4006591")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x4006592")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x4006593")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x6005E52")]
	[Address(RVA = "0x1EDF868", Offset = "0x1EDF868", VA = "0x1EDF868")]
	public InternalHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005E53")]
	[Address(RVA = "0x1EDF980", Offset = "0x1EDF980", VA = "0x1EDF980", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005E54")]
	[Address(RVA = "0x1EDF9D8", Offset = "0x1EDF9D8", VA = "0x1EDF9D8")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005E55")]
	[Address(RVA = "0x1EDFAF0", Offset = "0x1EDFAF0", VA = "0x1EDFAF0")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005E56")]
	[Address(RVA = "0x1EDFC34", Offset = "0x1EDFC34", VA = "0x1EDFC34")]
	public bool Enable()
	{
		return default(bool);
	}
}
