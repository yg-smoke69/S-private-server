using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C55")]
public class KillOrGodZoneTriggerEntity : _Attribute
{
	[Token(Token = "0x4006594")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x4006595")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x4006596")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x6005E57")]
	[Address(RVA = "0x1EE8A48", Offset = "0x1EE8A48", VA = "0x1EE8A48")]
	public KillOrGodZoneTriggerEntity(string entityID)
	{
	}

	[Token(Token = "0x6005E58")]
	[Address(RVA = "0x1EE8B60", Offset = "0x1EE8B60", VA = "0x1EE8B60", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005E59")]
	[Address(RVA = "0x1EE8BB8", Offset = "0x1EE8BB8", VA = "0x1EE8BB8")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005E5A")]
	[Address(RVA = "0x1EE8CD0", Offset = "0x1EE8CD0", VA = "0x1EE8CD0")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005E5B")]
	[Address(RVA = "0x1EE8E14", Offset = "0x1EE8E14", VA = "0x1EE8E14")]
	public bool Enable()
	{
		return default(bool);
	}
}
