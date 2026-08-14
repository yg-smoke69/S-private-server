using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000C4E")]
public class HudEmptyWidgetEntity : _Attribute
{
	[Token(Token = "0x400655B")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x400655C")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x400655D")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x400655E")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnActiveSelfChangeEvent;

	[Token(Token = "0x400655F")]
	[FieldOffset(Offset = "0x18")]
	public Action<Vector3, Vector3> OnLocalPositionChangeEvent;

	[Token(Token = "0x4006560")]
	[FieldOffset(Offset = "0x1C")]
	public Action<int, int> OnWidthChangeEvent;

	[Token(Token = "0x4006561")]
	[FieldOffset(Offset = "0x20")]
	public Action<int, int> OnHeightChangeEvent;

	[Token(Token = "0x4006562")]
	[FieldOffset(Offset = "0x24")]
	public Action<float, float> OnAngleChangeEvent;

	[Token(Token = "0x4006563")]
	[FieldOffset(Offset = "0x28")]
	public Action<string, string> OnHostHudEntityIDChangeEvent;

	[Token(Token = "0x4006564")]
	[FieldOffset(Offset = "0x2C")]
	public Action<int, int> OnFileIDChangeEvent;

	[Token(Token = "0x6005E10")]
	[Address(RVA = "0x2C6A8AC", Offset = "0x2C6A8AC", VA = "0x2C6A8AC")]
	public HudEmptyWidgetEntity(string entityID)
	{
	}

	[Token(Token = "0x6005E11")]
	[Address(RVA = "0x2C6A9C4", Offset = "0x2C6A9C4", VA = "0x2C6A9C4", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005E12")]
	[Address(RVA = "0x2C6AA1C", Offset = "0x2C6AA1C", VA = "0x2C6AA1C")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005E13")]
	[Address(RVA = "0x2C6AB40", Offset = "0x2C6AB40", VA = "0x2C6AB40")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005E14")]
	[Address(RVA = "0x2C6B0D8", Offset = "0x2C6B0D8", VA = "0x2C6B0D8")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E15")]
	[Address(RVA = "0x2C6B1B8", Offset = "0x2C6B1B8", VA = "0x2C6B1B8")]
	public bool ActiveSelf()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E16")]
	[Address(RVA = "0x2C6B294", Offset = "0x2C6B294", VA = "0x2C6B294")]
	public Vector3 LocalPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6005E17")]
	[Address(RVA = "0x2C6B38C", Offset = "0x2C6B38C", VA = "0x2C6B38C")]
	public int Width()
	{
		return default(int);
	}

	[Token(Token = "0x6005E18")]
	[Address(RVA = "0x2C6B468", Offset = "0x2C6B468", VA = "0x2C6B468")]
	public int Height()
	{
		return default(int);
	}

	[Token(Token = "0x6005E19")]
	[Address(RVA = "0x2C6B544", Offset = "0x2C6B544", VA = "0x2C6B544")]
	public float Angle()
	{
		return default(float);
	}

	[Token(Token = "0x6005E1A")]
	[Address(RVA = "0x2C6B620", Offset = "0x2C6B620", VA = "0x2C6B620")]
	public string HostHudEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005E1B")]
	[Address(RVA = "0x2C6B6FC", Offset = "0x2C6B6FC", VA = "0x2C6B6FC")]
	public int FileID()
	{
		return default(int);
	}
}
