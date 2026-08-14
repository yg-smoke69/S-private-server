using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C78")]
public class ZombieVFXHudEntity : _Attribute
{
	[Token(Token = "0x4006699")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x400669A")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x400669B")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x400669C")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x6005FA2")]
	[Address(RVA = "0x2307BB0", Offset = "0x2307BB0", VA = "0x2307BB0")]
	public ZombieVFXHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005FA3")]
	[Address(RVA = "0x2307CC8", Offset = "0x2307CC8", VA = "0x2307CC8", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005FA4")]
	[Address(RVA = "0x2307D20", Offset = "0x2307D20", VA = "0x2307D20")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005FA5")]
	[Address(RVA = "0x2307E3C", Offset = "0x2307E3C", VA = "0x2307E3C")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005FA6")]
	[Address(RVA = "0x2307FF0", Offset = "0x2307FF0", VA = "0x2307FF0")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005FA7")]
	[Address(RVA = "0x23080D0", Offset = "0x23080D0", VA = "0x23080D0")]
	public bool OpenState()
	{
		return default(bool);
	}
}
