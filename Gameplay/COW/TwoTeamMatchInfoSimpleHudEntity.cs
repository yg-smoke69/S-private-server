using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C73")]
public class TwoTeamMatchInfoSimpleHudEntity : _Attribute
{
	[Token(Token = "0x4006671")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x4006672")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x4006673")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x4006674")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x4006675")]
	[FieldOffset(Offset = "0x18")]
	public Action<int, int> OnLeftTeamScoreChangeEvent;

	[Token(Token = "0x4006676")]
	[FieldOffset(Offset = "0x1C")]
	public Action<int, int> OnRightTeamScoreChangeEvent;

	[Token(Token = "0x4006677")]
	[FieldOffset(Offset = "0x20")]
	public Action<int, int> OnLeftTeammateAliveCountChangeEvent;

	[Token(Token = "0x4006678")]
	[FieldOffset(Offset = "0x24")]
	public Action<int, int> OnRightTeammateAliveCountChangeEvent;

	[Token(Token = "0x4006679")]
	[FieldOffset(Offset = "0x28")]
	public Action<string, string> OnLeftIconSpriteNameChangeEvent;

	[Token(Token = "0x400667A")]
	[FieldOffset(Offset = "0x2C")]
	public Action<string, string> OnRightIconSpriteNameChangeEvent;

	[Token(Token = "0x6005F70")]
	[Address(RVA = "0x233BE04", Offset = "0x233BE04", VA = "0x233BE04")]
	public TwoTeamMatchInfoSimpleHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005F71")]
	[Address(RVA = "0x233BF14", Offset = "0x233BF14", VA = "0x233BF14", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005F72")]
	[Address(RVA = "0x233BF6C", Offset = "0x233BF6C", VA = "0x233BF6C")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005F73")]
	[Address(RVA = "0x233C088", Offset = "0x233C088", VA = "0x233C088")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005F74")]
	[Address(RVA = "0x233C68C", Offset = "0x233C68C", VA = "0x233C68C")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F75")]
	[Address(RVA = "0x233C76C", Offset = "0x233C76C", VA = "0x233C76C")]
	public bool OpenState()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F76")]
	[Address(RVA = "0x233C848", Offset = "0x233C848", VA = "0x233C848")]
	public int LeftTeamScore()
	{
		return default(int);
	}

	[Token(Token = "0x6005F77")]
	[Address(RVA = "0x233C924", Offset = "0x233C924", VA = "0x233C924")]
	public int RightTeamScore()
	{
		return default(int);
	}

	[Token(Token = "0x6005F78")]
	[Address(RVA = "0x233CA00", Offset = "0x233CA00", VA = "0x233CA00")]
	public int LeftTeammateAliveCount()
	{
		return default(int);
	}

	[Token(Token = "0x6005F79")]
	[Address(RVA = "0x233CADC", Offset = "0x233CADC", VA = "0x233CADC")]
	public int RightTeammateAliveCount()
	{
		return default(int);
	}

	[Token(Token = "0x6005F7A")]
	[Address(RVA = "0x233CBB8", Offset = "0x233CBB8", VA = "0x233CBB8")]
	public string LeftIconSpriteName()
	{
		return null;
	}

	[Token(Token = "0x6005F7B")]
	[Address(RVA = "0x233CC94", Offset = "0x233CC94", VA = "0x233CC94")]
	public string RightIconSpriteName()
	{
		return null;
	}
}
