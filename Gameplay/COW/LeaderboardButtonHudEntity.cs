using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C56")]
public class LeaderboardButtonHudEntity : _Attribute
{
	[Token(Token = "0x4006597")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x4006598")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x4006599")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x400659A")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x6005E5C")]
	[Address(RVA = "0x1EF9670", Offset = "0x1EF9670", VA = "0x1EF9670")]
	public LeaderboardButtonHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005E5D")]
	[Address(RVA = "0x1EF9788", Offset = "0x1EF9788", VA = "0x1EF9788", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005E5E")]
	[Address(RVA = "0x1EF97E0", Offset = "0x1EF97E0", VA = "0x1EF97E0")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005E5F")]
	[Address(RVA = "0x1EF98FC", Offset = "0x1EF98FC", VA = "0x1EF98FC")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005E60")]
	[Address(RVA = "0x1EF9AB0", Offset = "0x1EF9AB0", VA = "0x1EF9AB0")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E61")]
	[Address(RVA = "0x1EF9B90", Offset = "0x1EF9B90", VA = "0x1EF9B90")]
	public bool OpenState()
	{
		return default(bool);
	}
}
