using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C77")]
public class ZombieLevelHudEntity : _Attribute
{
	[Token(Token = "0x4006693")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x4006694")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x4006695")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x4006696")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x4006697")]
	[FieldOffset(Offset = "0x18")]
	public Action<int, int> OnTotalLevelChangeEvent;

	[Token(Token = "0x4006698")]
	[FieldOffset(Offset = "0x1C")]
	public Action<int, int> OnLevelChangeEvent;

	[Token(Token = "0x6005F9A")]
	[Address(RVA = "0x2307310", Offset = "0x2307310", VA = "0x2307310")]
	public ZombieLevelHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005F9B")]
	[Address(RVA = "0x2307428", Offset = "0x2307428", VA = "0x2307428", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005F9C")]
	[Address(RVA = "0x2307480", Offset = "0x2307480", VA = "0x2307480")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005F9D")]
	[Address(RVA = "0x230759C", Offset = "0x230759C", VA = "0x230759C")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005F9E")]
	[Address(RVA = "0x230783C", Offset = "0x230783C", VA = "0x230783C")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F9F")]
	[Address(RVA = "0x230791C", Offset = "0x230791C", VA = "0x230791C")]
	public bool OpenState()
	{
		return default(bool);
	}

	[Token(Token = "0x6005FA0")]
	[Address(RVA = "0x23079F8", Offset = "0x23079F8", VA = "0x23079F8")]
	public int TotalLevel()
	{
		return default(int);
	}

	[Token(Token = "0x6005FA1")]
	[Address(RVA = "0x2307AD4", Offset = "0x2307AD4", VA = "0x2307AD4")]
	public int Level()
	{
		return default(int);
	}
}
