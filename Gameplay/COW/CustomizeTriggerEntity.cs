using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C46")]
public class CustomizeTriggerEntity : _Attribute
{
	[Token(Token = "0x4006518")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x4006519")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x400651A")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x6005DBD")]
	[Address(RVA = "0x1C88930", Offset = "0x1C88930", VA = "0x1C88930")]
	public CustomizeTriggerEntity(string entityID)
	{
	}

	[Token(Token = "0x6005DBE")]
	[Address(RVA = "0x1C88A48", Offset = "0x1C88A48", VA = "0x1C88A48", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005DBF")]
	[Address(RVA = "0x1C88AA0", Offset = "0x1C88AA0", VA = "0x1C88AA0")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005DC0")]
	[Address(RVA = "0x1C88BB8", Offset = "0x1C88BB8", VA = "0x1C88BB8")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005DC1")]
	[Address(RVA = "0x1C88CFC", Offset = "0x1C88CFC", VA = "0x1C88CFC")]
	public bool Enable()
	{
		return default(bool);
	}
}
