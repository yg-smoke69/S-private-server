using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C40")]
public class BotGeneratorEntity : _Attribute
{
	[Token(Token = "0x40064FA")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x40064FB")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x40064FC")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x6005D93")]
	[Address(RVA = "0x180D2A4", Offset = "0x180D2A4", VA = "0x180D2A4")]
	public BotGeneratorEntity(string entityID)
	{
	}

	[Token(Token = "0x6005D94")]
	[Address(RVA = "0x180D3BC", Offset = "0x180D3BC", VA = "0x180D3BC", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005D95")]
	[Address(RVA = "0x180D414", Offset = "0x180D414", VA = "0x180D414")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005D96")]
	[Address(RVA = "0x180D52C", Offset = "0x180D52C", VA = "0x180D52C")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005D97")]
	[Address(RVA = "0x180D670", Offset = "0x180D670", VA = "0x180D670")]
	public bool Enable()
	{
		return default(bool);
	}
}
