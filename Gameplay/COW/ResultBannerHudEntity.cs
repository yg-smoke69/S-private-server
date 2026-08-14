using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C63")]
public class ResultBannerHudEntity : _Attribute
{
	[Token(Token = "0x40065EC")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x40065ED")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x40065EE")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x40065EF")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnLocSwitchChangeEvent;

	[Token(Token = "0x40065F0")]
	[FieldOffset(Offset = "0x18")]
	public Action<int, int> OnResultChangeEvent;

	[Token(Token = "0x40065F1")]
	[FieldOffset(Offset = "0x1C")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x6005ECB")]
	[Address(RVA = "0x240805C", Offset = "0x240805C", VA = "0x240805C")]
	public ResultBannerHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005ECC")]
	[Address(RVA = "0x2408174", Offset = "0x2408174", VA = "0x2408174", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005ECD")]
	[Address(RVA = "0x24081CC", Offset = "0x24081CC", VA = "0x24081CC")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005ECE")]
	[Address(RVA = "0x24082E8", Offset = "0x24082E8", VA = "0x24082E8")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005ECF")]
	[Address(RVA = "0x2408590", Offset = "0x2408590", VA = "0x2408590")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005ED0")]
	[Address(RVA = "0x2408670", Offset = "0x2408670", VA = "0x2408670")]
	public bool LocSwitch()
	{
		return default(bool);
	}

	[Token(Token = "0x6005ED1")]
	[Address(RVA = "0x240874C", Offset = "0x240874C", VA = "0x240874C")]
	public int Result()
	{
		return default(int);
	}

	[Token(Token = "0x6005ED2")]
	[Address(RVA = "0x2408828", Offset = "0x2408828", VA = "0x2408828")]
	public bool OpenState()
	{
		return default(bool);
	}
}
