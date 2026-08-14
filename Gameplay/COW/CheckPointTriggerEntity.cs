using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C42")]
public class CheckPointTriggerEntity : _Attribute
{
	[Token(Token = "0x4006501")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x4006502")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x4006503")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x6005D9E")]
	[Address(RVA = "0x1726630", Offset = "0x1726630", VA = "0x1726630")]
	public CheckPointTriggerEntity(string entityID)
	{
	}

	[Token(Token = "0x6005D9F")]
	[Address(RVA = "0x1726748", Offset = "0x1726748", VA = "0x1726748", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005DA0")]
	[Address(RVA = "0x17267A0", Offset = "0x17267A0", VA = "0x17267A0")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005DA1")]
	[Address(RVA = "0x17268B8", Offset = "0x17268B8", VA = "0x17268B8")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005DA2")]
	[Address(RVA = "0x17269FC", Offset = "0x17269FC", VA = "0x17269FC")]
	public bool Enable()
	{
		return default(bool);
	}
}
