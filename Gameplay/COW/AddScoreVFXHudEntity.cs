using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C3F")]
public class AddScoreVFXHudEntity : _Attribute
{
	[Token(Token = "0x40064F5")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x40064F6")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x40064F7")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x40064F8")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x40064F9")]
	[FieldOffset(Offset = "0x18")]
	public Action<int, int> OnScoreNumChangeEvent;

	[Token(Token = "0x6005D8C")]
	[Address(RVA = "0x14C233C", Offset = "0x14C233C", VA = "0x14C233C")]
	public AddScoreVFXHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005D8D")]
	[Address(RVA = "0x14C2454", Offset = "0x14C2454", VA = "0x14C2454", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005D8E")]
	[Address(RVA = "0x14C24AC", Offset = "0x14C24AC", VA = "0x14C24AC")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005D8F")]
	[Address(RVA = "0x14C25CC", Offset = "0x14C25CC", VA = "0x14C25CC")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005D90")]
	[Address(RVA = "0x14C2800", Offset = "0x14C2800", VA = "0x14C2800")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005D91")]
	[Address(RVA = "0x14C28E0", Offset = "0x14C28E0", VA = "0x14C28E0")]
	public bool OpenState()
	{
		return default(bool);
	}

	[Token(Token = "0x6005D92")]
	[Address(RVA = "0x14C29BC", Offset = "0x14C29BC", VA = "0x14C29BC")]
	public int ScoreNum()
	{
		return default(int);
	}
}
