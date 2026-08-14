using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C48")]
public class EndPointTriggerEntity : _Attribute
{
	[Token(Token = "0x400651E")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x400651F")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x4006520")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x6005DC7")]
	[Address(RVA = "0x25364E8", Offset = "0x25364E8", VA = "0x25364E8")]
	public EndPointTriggerEntity(string entityID)
	{
	}

	[Token(Token = "0x6005DC8")]
	[Address(RVA = "0x2536600", Offset = "0x2536600", VA = "0x2536600", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005DC9")]
	[Address(RVA = "0x2536658", Offset = "0x2536658", VA = "0x2536658")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005DCA")]
	[Address(RVA = "0x2536770", Offset = "0x2536770", VA = "0x2536770")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005DCB")]
	[Address(RVA = "0x25368B4", Offset = "0x25368B4", VA = "0x25368B4")]
	public bool Enable()
	{
		return default(bool);
	}
}
