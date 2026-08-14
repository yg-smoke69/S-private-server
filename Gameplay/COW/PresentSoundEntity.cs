using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C61")]
public class PresentSoundEntity : _Attribute
{
	[Token(Token = "0x40065DE")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x40065DF")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x40065E0")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x40065E1")]
	[FieldOffset(Offset = "0x14")]
	public Action<string, string> OnSoundTypeChangeEvent;

	[Token(Token = "0x40065E2")]
	[FieldOffset(Offset = "0x18")]
	public Action<string, string> OnFollowTargetChangeEvent;

	[Token(Token = "0x6005EB9")]
	[Address(RVA = "0x1C0FF14", Offset = "0x1C0FF14", VA = "0x1C0FF14")]
	public PresentSoundEntity(string entityID)
	{
	}

	[Token(Token = "0x6005EBA")]
	[Address(RVA = "0x1C1002C", Offset = "0x1C1002C", VA = "0x1C1002C", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005EBB")]
	[Address(RVA = "0x1C10084", Offset = "0x1C10084", VA = "0x1C10084")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005EBC")]
	[Address(RVA = "0x1C101A4", Offset = "0x1C101A4", VA = "0x1C101A4")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005EBD")]
	[Address(RVA = "0x1C10584", Offset = "0x1C10584", VA = "0x1C10584")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005EBE")]
	[Address(RVA = "0x1C10664", Offset = "0x1C10664", VA = "0x1C10664")]
	public string SoundType()
	{
		return null;
	}

	[Token(Token = "0x6005EBF")]
	[Address(RVA = "0x1C10740", Offset = "0x1C10740", VA = "0x1C10740")]
	public string FollowTarget()
	{
		return null;
	}
}
