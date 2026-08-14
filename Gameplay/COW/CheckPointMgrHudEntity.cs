using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C41")]
public class CheckPointMgrHudEntity : _Attribute
{
	[Token(Token = "0x40064FD")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x40064FE")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x40064FF")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x4006500")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x6005D98")]
	[Address(RVA = "0x1726034", Offset = "0x1726034", VA = "0x1726034")]
	public CheckPointMgrHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005D99")]
	[Address(RVA = "0x172614C", Offset = "0x172614C", VA = "0x172614C", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005D9A")]
	[Address(RVA = "0x17261A4", Offset = "0x17261A4", VA = "0x17261A4")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005D9B")]
	[Address(RVA = "0x17262C0", Offset = "0x17262C0", VA = "0x17262C0")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005D9C")]
	[Address(RVA = "0x1726474", Offset = "0x1726474", VA = "0x1726474")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005D9D")]
	[Address(RVA = "0x1726554", Offset = "0x1726554", VA = "0x1726554")]
	public bool OpenState()
	{
		return default(bool);
	}
}
