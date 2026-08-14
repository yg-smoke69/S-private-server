using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C70")]
public class TwoTeamFactionHudEntity : _Attribute
{
	[Token(Token = "0x4006653")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x4006654")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x4006655")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x4006656")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnLocSwitchChangeEvent;

	[Token(Token = "0x4006657")]
	[FieldOffset(Offset = "0x18")]
	public Action<string, string> OnLeftTeamNameChangeEvent;

	[Token(Token = "0x4006658")]
	[FieldOffset(Offset = "0x1C")]
	public Action<string, string> OnLeftTeamDescChangeEvent;

	[Token(Token = "0x4006659")]
	[FieldOffset(Offset = "0x20")]
	public Action<string, string> OnRightTeamNameChangeEvent;

	[Token(Token = "0x400665A")]
	[FieldOffset(Offset = "0x24")]
	public Action<string, string> OnRightTeamDescChangeEvent;

	[Token(Token = "0x400665B")]
	[FieldOffset(Offset = "0x28")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x6005F4C")]
	[Address(RVA = "0x2338ED0", Offset = "0x2338ED0", VA = "0x2338ED0")]
	public TwoTeamFactionHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005F4D")]
	[Address(RVA = "0x2338FE0", Offset = "0x2338FE0", VA = "0x2338FE0", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005F4E")]
	[Address(RVA = "0x2339038", Offset = "0x2339038", VA = "0x2339038")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005F4F")]
	[Address(RVA = "0x2339154", Offset = "0x2339154", VA = "0x2339154")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005F50")]
	[Address(RVA = "0x2339894", Offset = "0x2339894", VA = "0x2339894")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F51")]
	[Address(RVA = "0x2339974", Offset = "0x2339974", VA = "0x2339974")]
	public bool LocSwitch()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F52")]
	[Address(RVA = "0x2339A50", Offset = "0x2339A50", VA = "0x2339A50")]
	public string LeftTeamName()
	{
		return null;
	}

	[Token(Token = "0x6005F53")]
	[Address(RVA = "0x2339B2C", Offset = "0x2339B2C", VA = "0x2339B2C")]
	public string LeftTeamDesc()
	{
		return null;
	}

	[Token(Token = "0x6005F54")]
	[Address(RVA = "0x2339C08", Offset = "0x2339C08", VA = "0x2339C08")]
	public string RightTeamName()
	{
		return null;
	}

	[Token(Token = "0x6005F55")]
	[Address(RVA = "0x2339CE4", Offset = "0x2339CE4", VA = "0x2339CE4")]
	public string RightTeamDesc()
	{
		return null;
	}

	[Token(Token = "0x6005F56")]
	[Address(RVA = "0x2339DC0", Offset = "0x2339DC0", VA = "0x2339DC0")]
	public bool OpenState()
	{
		return default(bool);
	}
}
