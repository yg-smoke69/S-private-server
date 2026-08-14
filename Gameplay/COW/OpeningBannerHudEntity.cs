using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C5B")]
public class OpeningBannerHudEntity : _Attribute
{
	[Token(Token = "0x40065B7")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x40065B8")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x40065B9")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x40065BA")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x40065BB")]
	[FieldOffset(Offset = "0x18")]
	public Action<string, string> OnIconSpriteNameChangeEvent;

	[Token(Token = "0x40065BC")]
	[FieldOffset(Offset = "0x1C")]
	public Action<int, int> OnThemeColorChangeEvent;

	[Token(Token = "0x40065BD")]
	[FieldOffset(Offset = "0x20")]
	public Action<bool, bool> OnLocSwitchChangeEvent;

	[Token(Token = "0x40065BE")]
	[FieldOffset(Offset = "0x24")]
	public Action<string, string> OnTitleTextChangeEvent;

	[Token(Token = "0x40065BF")]
	[FieldOffset(Offset = "0x28")]
	public Action<string, string> OnDescTextChangeEvent;

	[Token(Token = "0x6005E86")]
	[Address(RVA = "0x28C6244", Offset = "0x28C6244", VA = "0x28C6244")]
	public OpeningBannerHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005E87")]
	[Address(RVA = "0x28C635C", Offset = "0x28C635C", VA = "0x28C635C", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005E88")]
	[Address(RVA = "0x28C63B4", Offset = "0x28C63B4", VA = "0x28C63B4")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005E89")]
	[Address(RVA = "0x28C64D8", Offset = "0x28C64D8", VA = "0x28C64D8")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005E8A")]
	[Address(RVA = "0x28C6B58", Offset = "0x28C6B58", VA = "0x28C6B58")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E8B")]
	[Address(RVA = "0x28C6C38", Offset = "0x28C6C38", VA = "0x28C6C38")]
	public bool OpenState()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E8C")]
	[Address(RVA = "0x28C6D14", Offset = "0x28C6D14", VA = "0x28C6D14")]
	public string IconSpriteName()
	{
		return null;
	}

	[Token(Token = "0x6005E8D")]
	[Address(RVA = "0x28C6DF0", Offset = "0x28C6DF0", VA = "0x28C6DF0")]
	public int ThemeColor()
	{
		return default(int);
	}

	[Token(Token = "0x6005E8E")]
	[Address(RVA = "0x28C6ECC", Offset = "0x28C6ECC", VA = "0x28C6ECC")]
	public bool LocSwitch()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E8F")]
	[Address(RVA = "0x28C6FA8", Offset = "0x28C6FA8", VA = "0x28C6FA8")]
	public string TitleText()
	{
		return null;
	}

	[Token(Token = "0x6005E90")]
	[Address(RVA = "0x28C7084", Offset = "0x28C7084", VA = "0x28C7084")]
	public string DescText()
	{
		return null;
	}
}
