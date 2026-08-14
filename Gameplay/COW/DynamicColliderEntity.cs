using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C47")]
public class DynamicColliderEntity : _Attribute
{
	[Token(Token = "0x400651B")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x400651C")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x400651D")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x6005DC2")]
	[Address(RVA = "0x1C983E4", Offset = "0x1C983E4", VA = "0x1C983E4")]
	public DynamicColliderEntity(string entityID)
	{
	}

	[Token(Token = "0x6005DC3")]
	[Address(RVA = "0x1C984FC", Offset = "0x1C984FC", VA = "0x1C984FC", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005DC4")]
	[Address(RVA = "0x1C98554", Offset = "0x1C98554", VA = "0x1C98554")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005DC5")]
	[Address(RVA = "0x1C9866C", Offset = "0x1C9866C", VA = "0x1C9866C")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005DC6")]
	[Address(RVA = "0x1C987B0", Offset = "0x1C987B0", VA = "0x1C987B0")]
	public bool Enable()
	{
		return default(bool);
	}
}
