using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C52")]
public class HudWidgetEntity : _Attribute
{
	[Token(Token = "0x4006587")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x4006588")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x4006589")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x6005E44")]
	[Address(RVA = "0x2C6EC24", Offset = "0x2C6EC24", VA = "0x2C6EC24")]
	public HudWidgetEntity(string entityID)
	{
	}

	[Token(Token = "0x6005E45")]
	[Address(RVA = "0x2C6ED3C", Offset = "0x2C6ED3C", VA = "0x2C6ED3C", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005E46")]
	[Address(RVA = "0x2C6ED94", Offset = "0x2C6ED94", VA = "0x2C6ED94")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005E47")]
	[Address(RVA = "0x2C6EEAC", Offset = "0x2C6EEAC", VA = "0x2C6EEAC")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005E48")]
	[Address(RVA = "0x2C6EFF0", Offset = "0x2C6EFF0", VA = "0x2C6EFF0")]
	public bool Enable()
	{
		return default(bool);
	}
}
