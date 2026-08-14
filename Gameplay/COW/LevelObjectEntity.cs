using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C57")]
public class LevelObjectEntity : _Attribute
{
	[Token(Token = "0x400659B")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x400659C")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x400659D")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x6005E62")]
	[Address(RVA = "0xEBE5C0", Offset = "0xEBE5C0", VA = "0xEBE5C0")]
	public LevelObjectEntity(string entityID)
	{
	}

	[Token(Token = "0x6005E63")]
	[Address(RVA = "0xEBE6D8", Offset = "0xEBE6D8", VA = "0xEBE6D8", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005E64")]
	[Address(RVA = "0xEBE730", Offset = "0xEBE730", VA = "0xEBE730")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005E65")]
	[Address(RVA = "0xEBE848", Offset = "0xEBE848", VA = "0xEBE848")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005E66")]
	[Address(RVA = "0xEBE98C", Offset = "0xEBE98C", VA = "0xEBE98C")]
	public bool Enable()
	{
		return default(bool);
	}
}
