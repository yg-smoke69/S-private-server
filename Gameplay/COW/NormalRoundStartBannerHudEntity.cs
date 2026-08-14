using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C5A")]
public class NormalRoundStartBannerHudEntity : _Attribute
{
	[Token(Token = "0x40065AE")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x40065AF")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x40065B0")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x40065B1")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x40065B2")]
	[FieldOffset(Offset = "0x18")]
	public Action<bool, bool> OnLocSwitchChangeEvent;

	[Token(Token = "0x40065B3")]
	[FieldOffset(Offset = "0x1C")]
	public Action<string, string> OnRoundNumLocKeyChangeEvent;

	[Token(Token = "0x40065B4")]
	[FieldOffset(Offset = "0x20")]
	public Action<List<object>, List<object>> OnRoundNumLocKey_ParamsChangeEvent;

	[Token(Token = "0x40065B5")]
	[FieldOffset(Offset = "0x24")]
	public Action<string, string> OnDescTextChangeEvent;

	[Token(Token = "0x40065B6")]
	[FieldOffset(Offset = "0x28")]
	public Action<int, int> OnThemeColorChangeEvent;

	[Token(Token = "0x6005E7B")]
	[Address(RVA = "0x28BA424", Offset = "0x28BA424", VA = "0x28BA424")]
	public NormalRoundStartBannerHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005E7C")]
	[Address(RVA = "0x28BA53C", Offset = "0x28BA53C", VA = "0x28BA53C", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005E7D")]
	[Address(RVA = "0x28BA594", Offset = "0x28BA594", VA = "0x28BA594")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005E7E")]
	[Address(RVA = "0x28BA6B8", Offset = "0x28BA6B8", VA = "0x28BA6B8")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005E7F")]
	[Address(RVA = "0x28BAD4C", Offset = "0x28BAD4C", VA = "0x28BAD4C")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E80")]
	[Address(RVA = "0x28BAE2C", Offset = "0x28BAE2C", VA = "0x28BAE2C")]
	public bool OpenState()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E81")]
	[Address(RVA = "0x28BAF08", Offset = "0x28BAF08", VA = "0x28BAF08")]
	public bool LocSwitch()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E82")]
	[Address(RVA = "0x28BAFE4", Offset = "0x28BAFE4", VA = "0x28BAFE4")]
	public string RoundNumLocKey()
	{
		return null;
	}

	[Token(Token = "0x6005E83")]
	[Address(RVA = "0x28BB0C0", Offset = "0x28BB0C0", VA = "0x28BB0C0")]
	public List<object> RoundNumLocKey_Params()
	{
		return null;
	}

	[Token(Token = "0x6005E84")]
	[Address(RVA = "0x28BB19C", Offset = "0x28BB19C", VA = "0x28BB19C")]
	public string DescText()
	{
		return null;
	}

	[Token(Token = "0x6005E85")]
	[Address(RVA = "0x28BB278", Offset = "0x28BB278", VA = "0x28BB278")]
	public int ThemeColor()
	{
		return default(int);
	}
}
