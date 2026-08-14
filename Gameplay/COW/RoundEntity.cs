using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C64")]
public class RoundEntity : _Attribute
{
	[Token(Token = "0x40065F2")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x40065F3")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x40065F4")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x6005ED3")]
	[Address(RVA = "0x2417790", Offset = "0x2417790", VA = "0x2417790")]
	public RoundEntity(string entityID)
	{
	}

	[Token(Token = "0x6005ED4")]
	[Address(RVA = "0x24178A8", Offset = "0x24178A8", VA = "0x24178A8", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005ED5")]
	[Address(RVA = "0x2417900", Offset = "0x2417900", VA = "0x2417900")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005ED6")]
	[Address(RVA = "0x2417A18", Offset = "0x2417A18", VA = "0x2417A18")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005ED7")]
	[Address(RVA = "0x2417B5C", Offset = "0x2417B5C", VA = "0x2417B5C")]
	public bool Enable()
	{
		return default(bool);
	}
}
