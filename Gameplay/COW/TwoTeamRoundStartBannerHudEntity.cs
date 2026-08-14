using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C75")]
public class TwoTeamRoundStartBannerHudEntity : _Attribute
{
	[Token(Token = "0x4006686")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x4006687")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x4006688")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x4006689")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x400668A")]
	[FieldOffset(Offset = "0x18")]
	public Action<bool, bool> OnLocSwitchChangeEvent;

	[Token(Token = "0x400668B")]
	[FieldOffset(Offset = "0x1C")]
	public Action<string, string> OnRoundNumLocKeyChangeEvent;

	[Token(Token = "0x400668C")]
	[FieldOffset(Offset = "0x20")]
	public Action<List<object>, List<object>> OnRoundNumLocKey_ParamsChangeEvent;

	[Token(Token = "0x400668D")]
	[FieldOffset(Offset = "0x24")]
	public Action<string, string> OnDescTextChangeEvent;

	[Token(Token = "0x400668E")]
	[FieldOffset(Offset = "0x28")]
	public Action<int, int> OnLeftColorChangeEvent;

	[Token(Token = "0x400668F")]
	[FieldOffset(Offset = "0x2C")]
	public Action<int, int> OnRightColorChangeEvent;

	[Token(Token = "0x6005F89")]
	[Address(RVA = "0x233DE2C", Offset = "0x233DE2C", VA = "0x233DE2C")]
	public TwoTeamRoundStartBannerHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005F8A")]
	[Address(RVA = "0x233DF3C", Offset = "0x233DF3C", VA = "0x233DF3C", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005F8B")]
	[Address(RVA = "0x233DF94", Offset = "0x233DF94", VA = "0x233DF94")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005F8C")]
	[Address(RVA = "0x233E0B0", Offset = "0x233E0B0", VA = "0x233E0B0")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005F8D")]
	[Address(RVA = "0x233E7A8", Offset = "0x233E7A8", VA = "0x233E7A8")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F8E")]
	[Address(RVA = "0x233E888", Offset = "0x233E888", VA = "0x233E888")]
	public bool OpenState()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F8F")]
	[Address(RVA = "0x233E964", Offset = "0x233E964", VA = "0x233E964")]
	public bool LocSwitch()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F90")]
	[Address(RVA = "0x233EA40", Offset = "0x233EA40", VA = "0x233EA40")]
	public string RoundNumLocKey()
	{
		return null;
	}

	[Token(Token = "0x6005F91")]
	[Address(RVA = "0x233EB1C", Offset = "0x233EB1C", VA = "0x233EB1C")]
	public List<object> RoundNumLocKey_Params()
	{
		return null;
	}

	[Token(Token = "0x6005F92")]
	[Address(RVA = "0x233EBF8", Offset = "0x233EBF8", VA = "0x233EBF8")]
	public string DescText()
	{
		return null;
	}

	[Token(Token = "0x6005F93")]
	[Address(RVA = "0x233ECD4", Offset = "0x233ECD4", VA = "0x233ECD4")]
	public int LeftColor()
	{
		return default(int);
	}

	[Token(Token = "0x6005F94")]
	[Address(RVA = "0x233EDB0", Offset = "0x233EDB0", VA = "0x233EDB0")]
	public int RightColor()
	{
		return default(int);
	}
}
