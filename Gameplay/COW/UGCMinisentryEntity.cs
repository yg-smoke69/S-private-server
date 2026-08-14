using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C76")]
public class UGCMinisentryEntity : _Attribute
{
	[Token(Token = "0x4006690")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x4006691")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x4006692")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x6005F95")]
	[Address(RVA = "0x29F2B60", Offset = "0x29F2B60", VA = "0x29F2B60")]
	public UGCMinisentryEntity(string entityID)
	{
	}

	[Token(Token = "0x6005F96")]
	[Address(RVA = "0x29F2C78", Offset = "0x29F2C78", VA = "0x29F2C78", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005F97")]
	[Address(RVA = "0x29F2CD0", Offset = "0x29F2CD0", VA = "0x29F2CD0")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005F98")]
	[Address(RVA = "0x29F2DE8", Offset = "0x29F2DE8", VA = "0x29F2DE8")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005F99")]
	[Address(RVA = "0x29F2F2C", Offset = "0x29F2F2C", VA = "0x29F2F2C")]
	public bool Enable()
	{
		return default(bool);
	}
}
