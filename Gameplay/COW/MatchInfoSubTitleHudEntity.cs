using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C58")]
public class MatchInfoSubTitleHudEntity : _Attribute
{
	[Token(Token = "0x400659E")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x400659F")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x40065A0")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x40065A1")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x40065A2")]
	[FieldOffset(Offset = "0x18")]
	public Action<bool, bool> OnLocSwitchChangeEvent;

	[Token(Token = "0x40065A3")]
	[FieldOffset(Offset = "0x1C")]
	public Action<string, string> OnTextKeyChangeEvent;

	[Token(Token = "0x40065A4")]
	[FieldOffset(Offset = "0x20")]
	public Action<List<object>, List<object>> OnTextKey_ParamsChangeEvent;

	[Token(Token = "0x6005E67")]
	[Address(RVA = "0x154391C", Offset = "0x154391C", VA = "0x154391C")]
	public MatchInfoSubTitleHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005E68")]
	[Address(RVA = "0x1543A34", Offset = "0x1543A34", VA = "0x1543A34", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005E69")]
	[Address(RVA = "0x1543A8C", Offset = "0x1543A8C", VA = "0x1543A8C")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005E6A")]
	[Address(RVA = "0x1543BB0", Offset = "0x1543BB0", VA = "0x1543BB0")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005E6B")]
	[Address(RVA = "0x1544084", Offset = "0x1544084", VA = "0x1544084")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E6C")]
	[Address(RVA = "0x1544164", Offset = "0x1544164", VA = "0x1544164")]
	public bool OpenState()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E6D")]
	[Address(RVA = "0x1544240", Offset = "0x1544240", VA = "0x1544240")]
	public bool LocSwitch()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E6E")]
	[Address(RVA = "0x154431C", Offset = "0x154431C", VA = "0x154431C")]
	public string TextKey()
	{
		return null;
	}

	[Token(Token = "0x6005E6F")]
	[Address(RVA = "0x15443F8", Offset = "0x15443F8", VA = "0x15443F8")]
	public List<object> TextKey_Params()
	{
		return null;
	}
}
