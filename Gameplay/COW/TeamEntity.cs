using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C6B")]
public class TeamEntity : _Attribute
{
	[Token(Token = "0x400662A")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x400662B")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x400662C")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x6005F19")]
	[Address(RVA = "0x289D808", Offset = "0x289D808", VA = "0x289D808")]
	public TeamEntity(string entityID)
	{
	}

	[Token(Token = "0x6005F1A")]
	[Address(RVA = "0x289D920", Offset = "0x289D920", VA = "0x289D920", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005F1B")]
	[Address(RVA = "0x289D978", Offset = "0x289D978", VA = "0x289D978")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005F1C")]
	[Address(RVA = "0x289DA90", Offset = "0x289DA90", VA = "0x289DA90")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005F1D")]
	[Address(RVA = "0x289DBD4", Offset = "0x289DBD4", VA = "0x289DBD4")]
	public bool Enable()
	{
		return default(bool);
	}
}
