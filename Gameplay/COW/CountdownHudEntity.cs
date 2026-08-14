using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C43")]
public class CountdownHudEntity : _Attribute
{
	[Token(Token = "0x4006504")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x4006505")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x4006506")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x4006507")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x4006508")]
	[FieldOffset(Offset = "0x18")]
	public Action<int, int> OnDurationChangeEvent;

	[Token(Token = "0x4006509")]
	[FieldOffset(Offset = "0x1C")]
	public Action<int, int> OnBaseTimeChangeEvent;

	[Token(Token = "0x400650A")]
	[FieldOffset(Offset = "0x20")]
	public Action<int, int> OnUpdateTypeChangeEvent;

	[Token(Token = "0x6005DA3")]
	[Address(RVA = "0x1C8062C", Offset = "0x1C8062C", VA = "0x1C8062C")]
	public CountdownHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005DA4")]
	[Address(RVA = "0x1C80744", Offset = "0x1C80744", VA = "0x1C80744", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005DA5")]
	[Address(RVA = "0x1C8079C", Offset = "0x1C8079C", VA = "0x1C8079C")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005DA6")]
	[Address(RVA = "0x1C808C0", Offset = "0x1C808C0", VA = "0x1C808C0")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005DA7")]
	[Address(RVA = "0x1C80BC8", Offset = "0x1C80BC8", VA = "0x1C80BC8")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005DA8")]
	[Address(RVA = "0x1C80CA8", Offset = "0x1C80CA8", VA = "0x1C80CA8")]
	public bool OpenState()
	{
		return default(bool);
	}

	[Token(Token = "0x6005DA9")]
	[Address(RVA = "0x1C80D84", Offset = "0x1C80D84", VA = "0x1C80D84")]
	public int Duration()
	{
		return default(int);
	}

	[Token(Token = "0x6005DAA")]
	[Address(RVA = "0x1C80E60", Offset = "0x1C80E60", VA = "0x1C80E60")]
	public int BaseTime()
	{
		return default(int);
	}

	[Token(Token = "0x6005DAB")]
	[Address(RVA = "0x1C80F3C", Offset = "0x1C80F3C", VA = "0x1C80F3C")]
	public int UpdateType()
	{
		return default(int);
	}
}
