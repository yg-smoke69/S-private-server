using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000C4F")]
public class HudImageWidgetEntity : _Attribute
{
	[Token(Token = "0x4006565")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x4006566")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x4006567")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x4006568")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnActiveSelfChangeEvent;

	[Token(Token = "0x4006569")]
	[FieldOffset(Offset = "0x18")]
	public Action<Vector3, Vector3> OnLocalPositionChangeEvent;

	[Token(Token = "0x400656A")]
	[FieldOffset(Offset = "0x1C")]
	public Action<int, int> OnWidthChangeEvent;

	[Token(Token = "0x400656B")]
	[FieldOffset(Offset = "0x20")]
	public Action<int, int> OnHeightChangeEvent;

	[Token(Token = "0x400656C")]
	[FieldOffset(Offset = "0x24")]
	public Action<float, float> OnAngleChangeEvent;

	[Token(Token = "0x400656D")]
	[FieldOffset(Offset = "0x28")]
	public Action<int, int> OnColorChangeEvent;

	[Token(Token = "0x400656E")]
	[FieldOffset(Offset = "0x2C")]
	public Action<string, string> OnSpriteNameChangeEvent;

	[Token(Token = "0x400656F")]
	[FieldOffset(Offset = "0x30")]
	public Action<string, string> OnHostHudEntityIDChangeEvent;

	[Token(Token = "0x4006570")]
	[FieldOffset(Offset = "0x34")]
	public Action<int, int> OnFileIDChangeEvent;

	[Token(Token = "0x6005E1C")]
	[Address(RVA = "0x2C6B7D8", Offset = "0x2C6B7D8", VA = "0x2C6B7D8")]
	public HudImageWidgetEntity(string entityID)
	{
	}

	[Token(Token = "0x6005E1D")]
	[Address(RVA = "0x2C6B8F0", Offset = "0x2C6B8F0", VA = "0x2C6B8F0", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005E1E")]
	[Address(RVA = "0x2C6B948", Offset = "0x2C6B948", VA = "0x2C6B948")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005E1F")]
	[Address(RVA = "0x2C6BA78", Offset = "0x2C6BA78", VA = "0x2C6BA78")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005E20")]
	[Address(RVA = "0x2C6C1B0", Offset = "0x2C6C1B0", VA = "0x2C6C1B0")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E21")]
	[Address(RVA = "0x2C6C290", Offset = "0x2C6C290", VA = "0x2C6C290")]
	public bool ActiveSelf()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E22")]
	[Address(RVA = "0x2C6C36C", Offset = "0x2C6C36C", VA = "0x2C6C36C")]
	public Vector3 LocalPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6005E23")]
	[Address(RVA = "0x2C6C464", Offset = "0x2C6C464", VA = "0x2C6C464")]
	public int Width()
	{
		return default(int);
	}

	[Token(Token = "0x6005E24")]
	[Address(RVA = "0x2C6C540", Offset = "0x2C6C540", VA = "0x2C6C540")]
	public int Height()
	{
		return default(int);
	}

	[Token(Token = "0x6005E25")]
	[Address(RVA = "0x2C6C61C", Offset = "0x2C6C61C", VA = "0x2C6C61C")]
	public float Angle()
	{
		return default(float);
	}

	[Token(Token = "0x6005E26")]
	[Address(RVA = "0x2C6C6F8", Offset = "0x2C6C6F8", VA = "0x2C6C6F8")]
	public int Color()
	{
		return default(int);
	}

	[Token(Token = "0x6005E27")]
	[Address(RVA = "0x2C6C7D4", Offset = "0x2C6C7D4", VA = "0x2C6C7D4")]
	public string SpriteName()
	{
		return null;
	}

	[Token(Token = "0x6005E28")]
	[Address(RVA = "0x2C6C8B0", Offset = "0x2C6C8B0", VA = "0x2C6C8B0")]
	public string HostHudEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005E29")]
	[Address(RVA = "0x2C6C98C", Offset = "0x2C6C98C", VA = "0x2C6C98C")]
	public int FileID()
	{
		return default(int);
	}
}
