using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C4A")]
public class FactionInfoHudEntity : _Attribute
{
	[Token(Token = "0x4006524")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x4006525")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x4006526")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x4006527")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x4006528")]
	[FieldOffset(Offset = "0x18")]
	public Action<int, int> OnLeftTeammateAliveCountChangeEvent;

	[Token(Token = "0x4006529")]
	[FieldOffset(Offset = "0x1C")]
	public Action<int, int> OnRightTeammateAliveCountChangeEvent;

	[Token(Token = "0x400652A")]
	[FieldOffset(Offset = "0x20")]
	public Action<int, int> OnLeftBgColorChangeEvent;

	[Token(Token = "0x400652B")]
	[FieldOffset(Offset = "0x24")]
	public Action<int, int> OnRightBgColorChangeEvent;

	[Token(Token = "0x400652C")]
	[FieldOffset(Offset = "0x28")]
	public Action<string, string> OnLeftIconSpriteNameChangeEvent;

	[Token(Token = "0x400652D")]
	[FieldOffset(Offset = "0x2C")]
	public Action<string, string> OnRightIconSpriteNameChangeEvent;

	[Token(Token = "0x6005DD1")]
	[Address(RVA = "0xDE3820", Offset = "0xDE3820", VA = "0xDE3820")]
	public FactionInfoHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005DD2")]
	[Address(RVA = "0xDE3938", Offset = "0xDE3938", VA = "0xDE3938", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005DD3")]
	[Address(RVA = "0xDE3990", Offset = "0xDE3990", VA = "0xDE3990")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005DD4")]
	[Address(RVA = "0xDE3AB4", Offset = "0xDE3AB4", VA = "0xDE3AB4")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005DD5")]
	[Address(RVA = "0xDE40B8", Offset = "0xDE40B8", VA = "0xDE40B8")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005DD6")]
	[Address(RVA = "0xDE4198", Offset = "0xDE4198", VA = "0xDE4198")]
	public bool OpenState()
	{
		return default(bool);
	}

	[Token(Token = "0x6005DD7")]
	[Address(RVA = "0xDE4274", Offset = "0xDE4274", VA = "0xDE4274")]
	public int LeftTeammateAliveCount()
	{
		return default(int);
	}

	[Token(Token = "0x6005DD8")]
	[Address(RVA = "0xDE4350", Offset = "0xDE4350", VA = "0xDE4350")]
	public int RightTeammateAliveCount()
	{
		return default(int);
	}

	[Token(Token = "0x6005DD9")]
	[Address(RVA = "0xDE442C", Offset = "0xDE442C", VA = "0xDE442C")]
	public int LeftBgColor()
	{
		return default(int);
	}

	[Token(Token = "0x6005DDA")]
	[Address(RVA = "0xDE4508", Offset = "0xDE4508", VA = "0xDE4508")]
	public int RightBgColor()
	{
		return default(int);
	}

	[Token(Token = "0x6005DDB")]
	[Address(RVA = "0xDE45E4", Offset = "0xDE45E4", VA = "0xDE45E4")]
	public string LeftIconSpriteName()
	{
		return null;
	}

	[Token(Token = "0x6005DDC")]
	[Address(RVA = "0xDE46C0", Offset = "0xDE46C0", VA = "0xDE46C0")]
	public string RightIconSpriteName()
	{
		return null;
	}
}
