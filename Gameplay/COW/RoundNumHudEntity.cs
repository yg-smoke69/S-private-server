using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C65")]
public class RoundNumHudEntity : _Attribute
{
	[Token(Token = "0x40065F5")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x40065F6")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x40065F7")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x40065F8")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x40065F9")]
	[FieldOffset(Offset = "0x18")]
	public Action<bool, bool> OnLocSwitchChangeEvent;

	[Token(Token = "0x40065FA")]
	[FieldOffset(Offset = "0x1C")]
	public Action<string, string> OnTextKeyChangeEvent;

	[Token(Token = "0x40065FB")]
	[FieldOffset(Offset = "0x20")]
	public Action<List<object>, List<object>> OnTextKey_ParamsChangeEvent;

	[Token(Token = "0x40065FC")]
	[FieldOffset(Offset = "0x24")]
	public Action<int, int> OnThemeColorChangeEvent;

	[Token(Token = "0x6005ED8")]
	[Address(RVA = "0x2417C3C", Offset = "0x2417C3C", VA = "0x2417C3C")]
	public RoundNumHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005ED9")]
	[Address(RVA = "0x2417D54", Offset = "0x2417D54", VA = "0x2417D54", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005EDA")]
	[Address(RVA = "0x2417DAC", Offset = "0x2417DAC", VA = "0x2417DAC")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005EDB")]
	[Address(RVA = "0x2417ED4", Offset = "0x2417ED4", VA = "0x2417ED4")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005EDC")]
	[Address(RVA = "0x2418424", Offset = "0x2418424", VA = "0x2418424")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005EDD")]
	[Address(RVA = "0x2418504", Offset = "0x2418504", VA = "0x2418504")]
	public bool OpenState()
	{
		return default(bool);
	}

	[Token(Token = "0x6005EDE")]
	[Address(RVA = "0x24185E0", Offset = "0x24185E0", VA = "0x24185E0")]
	public bool LocSwitch()
	{
		return default(bool);
	}

	[Token(Token = "0x6005EDF")]
	[Address(RVA = "0x24186BC", Offset = "0x24186BC", VA = "0x24186BC")]
	public string TextKey()
	{
		return null;
	}

	[Token(Token = "0x6005EE0")]
	[Address(RVA = "0x2418798", Offset = "0x2418798", VA = "0x2418798")]
	public List<object> TextKey_Params()
	{
		return null;
	}

	[Token(Token = "0x6005EE1")]
	[Address(RVA = "0x2418874", Offset = "0x2418874", VA = "0x2418874")]
	public int ThemeColor()
	{
		return default(int);
	}
}
