using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000C50")]
public class HudInputWidgetEntity : _Attribute
{
	[Token(Token = "0x4006571")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x4006572")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x4006573")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x4006574")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnActiveSelfChangeEvent;

	[Token(Token = "0x4006575")]
	[FieldOffset(Offset = "0x18")]
	public Action<Vector3, Vector3> OnLocalPositionChangeEvent;

	[Token(Token = "0x4006576")]
	[FieldOffset(Offset = "0x1C")]
	public Action<int, int> OnWidthChangeEvent;

	[Token(Token = "0x4006577")]
	[FieldOffset(Offset = "0x20")]
	public Action<int, int> OnHeightChangeEvent;

	[Token(Token = "0x4006578")]
	[FieldOffset(Offset = "0x24")]
	public Action<float, float> OnAngleChangeEvent;

	[Token(Token = "0x4006579")]
	[FieldOffset(Offset = "0x28")]
	public Action<string, string> OnHostHudEntityIDChangeEvent;

	[Token(Token = "0x400657A")]
	[FieldOffset(Offset = "0x2C")]
	public Action<int, int> OnFileIDChangeEvent;

	[Token(Token = "0x6005E2A")]
	[Address(RVA = "0x2C6CA68", Offset = "0x2C6CA68", VA = "0x2C6CA68")]
	public HudInputWidgetEntity(string entityID)
	{
	}

	[Token(Token = "0x6005E2B")]
	[Address(RVA = "0x2C6CB80", Offset = "0x2C6CB80", VA = "0x2C6CB80", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005E2C")]
	[Address(RVA = "0x2C6CBD8", Offset = "0x2C6CBD8", VA = "0x2C6CBD8")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005E2D")]
	[Address(RVA = "0x2C6CCFC", Offset = "0x2C6CCFC", VA = "0x2C6CCFC")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005E2E")]
	[Address(RVA = "0x2C6D294", Offset = "0x2C6D294", VA = "0x2C6D294")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E2F")]
	[Address(RVA = "0x2C6D374", Offset = "0x2C6D374", VA = "0x2C6D374")]
	public bool ActiveSelf()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E30")]
	[Address(RVA = "0x2C6D450", Offset = "0x2C6D450", VA = "0x2C6D450")]
	public Vector3 LocalPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6005E31")]
	[Address(RVA = "0x2C6D548", Offset = "0x2C6D548", VA = "0x2C6D548")]
	public int Width()
	{
		return default(int);
	}

	[Token(Token = "0x6005E32")]
	[Address(RVA = "0x2C6D624", Offset = "0x2C6D624", VA = "0x2C6D624")]
	public int Height()
	{
		return default(int);
	}

	[Token(Token = "0x6005E33")]
	[Address(RVA = "0x2C6D700", Offset = "0x2C6D700", VA = "0x2C6D700")]
	public float Angle()
	{
		return default(float);
	}

	[Token(Token = "0x6005E34")]
	[Address(RVA = "0x2C6D7DC", Offset = "0x2C6D7DC", VA = "0x2C6D7DC")]
	public string HostHudEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005E35")]
	[Address(RVA = "0x2C6D8B8", Offset = "0x2C6D8B8", VA = "0x2C6D8B8")]
	public int FileID()
	{
		return default(int);
	}
}
