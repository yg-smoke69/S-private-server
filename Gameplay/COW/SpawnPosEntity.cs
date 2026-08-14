using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C69")]
public class SpawnPosEntity : _Attribute
{
	[Token(Token = "0x4006623")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x4006624")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x4006625")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x6005F0E")]
	[Address(RVA = "0x20FBAD0", Offset = "0x20FBAD0", VA = "0x20FBAD0")]
	public SpawnPosEntity(string entityID)
	{
	}

	[Token(Token = "0x6005F0F")]
	[Address(RVA = "0x20FBBE8", Offset = "0x20FBBE8", VA = "0x20FBBE8", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005F10")]
	[Address(RVA = "0x20FBC40", Offset = "0x20FBC40", VA = "0x20FBC40")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005F11")]
	[Address(RVA = "0x20FBD58", Offset = "0x20FBD58", VA = "0x20FBD58")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005F12")]
	[Address(RVA = "0x20FBE9C", Offset = "0x20FBE9C", VA = "0x20FBE9C")]
	public bool Enable()
	{
		return default(bool);
	}
}
