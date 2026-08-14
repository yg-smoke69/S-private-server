using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C53")]
public class IconNotificationHudEntity : _Attribute
{
	[Token(Token = "0x400658A")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x400658B")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x400658C")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x400658D")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x400658E")]
	[FieldOffset(Offset = "0x18")]
	public Action<string, string> OnIconSpriteNameChangeEvent;

	[Token(Token = "0x400658F")]
	[FieldOffset(Offset = "0x1C")]
	public Action<string, string> OnBgIconSpriteNameChangeEvent;

	[Token(Token = "0x4006590")]
	[FieldOffset(Offset = "0x20")]
	public Action<string, string> OnDescriptionChangeEvent;

	[Token(Token = "0x6005E49")]
	[Address(RVA = "0x2C70908", Offset = "0x2C70908", VA = "0x2C70908")]
	public IconNotificationHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005E4A")]
	[Address(RVA = "0x2C70A20", Offset = "0x2C70A20", VA = "0x2C70A20", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005E4B")]
	[Address(RVA = "0x2C70A78", Offset = "0x2C70A78", VA = "0x2C70A78")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005E4C")]
	[Address(RVA = "0x2C70B9C", Offset = "0x2C70B9C", VA = "0x2C70B9C")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005E4D")]
	[Address(RVA = "0x2C71134", Offset = "0x2C71134", VA = "0x2C71134")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E4E")]
	[Address(RVA = "0x2C71214", Offset = "0x2C71214", VA = "0x2C71214")]
	public bool OpenState()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E4F")]
	[Address(RVA = "0x2C712F0", Offset = "0x2C712F0", VA = "0x2C712F0")]
	public string IconSpriteName()
	{
		return null;
	}

	[Token(Token = "0x6005E50")]
	[Address(RVA = "0x2C713CC", Offset = "0x2C713CC", VA = "0x2C713CC")]
	public string BgIconSpriteName()
	{
		return null;
	}

	[Token(Token = "0x6005E51")]
	[Address(RVA = "0x2C714A8", Offset = "0x2C714A8", VA = "0x2C714A8")]
	public string Description()
	{
		return null;
	}
}
