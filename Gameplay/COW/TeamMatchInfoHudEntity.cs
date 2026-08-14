using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000C6C")]
public class TeamMatchInfoHudEntity : _Attribute
{
	[Token(Token = "0x400662D")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x400662E")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x400662F")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x4006630")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnOpenStateChangeEvent;

	[Token(Token = "0x4006631")]
	[FieldOffset(Offset = "0x18")]
	public Action<bool, bool> OnLocSwitchChangeEvent;

	[Token(Token = "0x4006632")]
	[FieldOffset(Offset = "0x1C")]
	public Action<Vector3, Vector3> OnOffsetPositionChangeEvent;

	[Token(Token = "0x4006633")]
	[FieldOffset(Offset = "0x20")]
	public Action<int, int> OnRankChangeEvent;

	[Token(Token = "0x4006634")]
	[FieldOffset(Offset = "0x24")]
	public Action<int, int> OnTeamColorChangeEvent;

	[Token(Token = "0x4006635")]
	[FieldOffset(Offset = "0x28")]
	public Action<string, string> OnIconSpriteNameChangeEvent;

	[Token(Token = "0x4006636")]
	[FieldOffset(Offset = "0x2C")]
	public Action<bool, bool> OnShowFrameChangeEvent;

	[Token(Token = "0x4006637")]
	[FieldOffset(Offset = "0x30")]
	public Action<string, string> OnScoreTextKeyChangeEvent;

	[Token(Token = "0x4006638")]
	[FieldOffset(Offset = "0x34")]
	public Action<List<object>, List<object>> OnScoreTextKey_ParamsChangeEvent;

	[Token(Token = "0x6005F1E")]
	[Address(RVA = "0x289DCB4", Offset = "0x289DCB4", VA = "0x289DCB4")]
	public TeamMatchInfoHudEntity(string entityID)
	{
	}

	[Token(Token = "0x6005F1F")]
	[Address(RVA = "0x289DDCC", Offset = "0x289DDCC", VA = "0x289DDCC", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005F20")]
	[Address(RVA = "0x289DE24", Offset = "0x289DE24", VA = "0x289DE24")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005F21")]
	[Address(RVA = "0x289DF54", Offset = "0x289DF54", VA = "0x289DF54")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005F22")]
	[Address(RVA = "0x289E758", Offset = "0x289E758", VA = "0x289E758")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F23")]
	[Address(RVA = "0x289E838", Offset = "0x289E838", VA = "0x289E838")]
	public bool OpenState()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F24")]
	[Address(RVA = "0x289E914", Offset = "0x289E914", VA = "0x289E914")]
	public bool LocSwitch()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F25")]
	[Address(RVA = "0x289E9F0", Offset = "0x289E9F0", VA = "0x289E9F0")]
	public Vector3 OffsetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6005F26")]
	[Address(RVA = "0x289EAE8", Offset = "0x289EAE8", VA = "0x289EAE8")]
	public int Rank()
	{
		return default(int);
	}

	[Token(Token = "0x6005F27")]
	[Address(RVA = "0x289EBC4", Offset = "0x289EBC4", VA = "0x289EBC4")]
	public int TeamColor()
	{
		return default(int);
	}

	[Token(Token = "0x6005F28")]
	[Address(RVA = "0x289ECA0", Offset = "0x289ECA0", VA = "0x289ECA0")]
	public string IconSpriteName()
	{
		return null;
	}

	[Token(Token = "0x6005F29")]
	[Address(RVA = "0x289ED7C", Offset = "0x289ED7C", VA = "0x289ED7C")]
	public bool ShowFrame()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F2A")]
	[Address(RVA = "0x289EE58", Offset = "0x289EE58", VA = "0x289EE58")]
	public string ScoreTextKey()
	{
		return null;
	}

	[Token(Token = "0x6005F2B")]
	[Address(RVA = "0x289EF34", Offset = "0x289EF34", VA = "0x289EF34")]
	public List<object> ScoreTextKey_Params()
	{
		return null;
	}
}
