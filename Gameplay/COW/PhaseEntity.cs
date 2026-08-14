using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C5D")]
public class PhaseEntity : _Attribute
{
	[Token(Token = "0x40065C6")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x40065C7")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x40065C8")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x6005E99")]
	[Address(RVA = "0x1C01E50", Offset = "0x1C01E50", VA = "0x1C01E50")]
	public PhaseEntity(string entityID)
	{
	}

	[Token(Token = "0x6005E9A")]
	[Address(RVA = "0x1C01F68", Offset = "0x1C01F68", VA = "0x1C01F68", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005E9B")]
	[Address(RVA = "0x1C01FC0", Offset = "0x1C01FC0", VA = "0x1C01FC0")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005E9C")]
	[Address(RVA = "0x1C020D8", Offset = "0x1C020D8", VA = "0x1C020D8")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005E9D")]
	[Address(RVA = "0x1C0221C", Offset = "0x1C0221C", VA = "0x1C0221C")]
	public bool Enable()
	{
		return default(bool);
	}
}
