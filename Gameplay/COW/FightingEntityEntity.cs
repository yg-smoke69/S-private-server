using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C4B")]
public class FightingEntityEntity : _Attribute
{
	[Token(Token = "0x400652E")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x400652F")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x4006530")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x6005DDD")]
	[Address(RVA = "0xDE59E0", Offset = "0xDE59E0", VA = "0xDE59E0")]
	public FightingEntityEntity(string entityID)
	{
	}

	[Token(Token = "0x6005DDE")]
	[Address(RVA = "0xDE5AF8", Offset = "0xDE5AF8", VA = "0xDE5AF8", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005DDF")]
	[Address(RVA = "0xDE5B50", Offset = "0xDE5B50", VA = "0xDE5B50")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005DE0")]
	[Address(RVA = "0xDE5C68", Offset = "0xDE5C68", VA = "0xDE5C68")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005DE1")]
	[Address(RVA = "0xDE5DAC", Offset = "0xDE5DAC", VA = "0xDE5DAC")]
	public bool Enable()
	{
		return default(bool);
	}
}
