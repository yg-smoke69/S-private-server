using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C49")]
public class EntityEntity : _Attribute
{
	[Token(Token = "0x4006521")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x4006522")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x4006523")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x6005DCC")]
	[Address(RVA = "0x25389C8", Offset = "0x25389C8", VA = "0x25389C8")]
	public EntityEntity(string entityID)
	{
	}

	[Token(Token = "0x6005DCD")]
	[Address(RVA = "0x2538AE0", Offset = "0x2538AE0", VA = "0x2538AE0", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005DCE")]
	[Address(RVA = "0x2538B38", Offset = "0x2538B38", VA = "0x2538B38")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005DCF")]
	[Address(RVA = "0x2538C50", Offset = "0x2538C50", VA = "0x2538C50")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005DD0")]
	[Address(RVA = "0x2538D8C", Offset = "0x2538D8C", VA = "0x2538D8C")]
	public bool Enable()
	{
		return default(bool);
	}
}
