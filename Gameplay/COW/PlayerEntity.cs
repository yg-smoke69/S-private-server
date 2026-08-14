using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C5E")]
public class PlayerEntity : _Attribute
{
	[Token(Token = "0x40065C9")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x40065CA")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x40065CB")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x6005E9E")]
	[Address(RVA = "0x1C08A38", Offset = "0x1C08A38", VA = "0x1C08A38")]
	public PlayerEntity(string entityID)
	{
	}

	[Token(Token = "0x6005E9F")]
	[Address(RVA = "0x1C08B50", Offset = "0x1C08B50", VA = "0x1C08B50", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005EA0")]
	[Address(RVA = "0x1C08BA8", Offset = "0x1C08BA8", VA = "0x1C08BA8")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005EA1")]
	[Address(RVA = "0x1C08CC0", Offset = "0x1C08CC0", VA = "0x1C08CC0")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005EA2")]
	[Address(RVA = "0x1C08E04", Offset = "0x1C08E04", VA = "0x1C08E04")]
	public bool Enable()
	{
		return default(bool);
	}
}
