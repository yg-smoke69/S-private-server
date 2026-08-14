using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000C4D")]
public class HudButtonWidgetEntity : _Attribute
{
	[Token(Token = "0x4006550")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x4006551")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x4006552")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x4006553")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnActiveSelfChangeEvent;

	[Token(Token = "0x4006554")]
	[FieldOffset(Offset = "0x18")]
	public Action<Vector3, Vector3> OnLocalPositionChangeEvent;

	[Token(Token = "0x4006555")]
	[FieldOffset(Offset = "0x1C")]
	public Action<int, int> OnWidthChangeEvent;

	[Token(Token = "0x4006556")]
	[FieldOffset(Offset = "0x20")]
	public Action<int, int> OnHeightChangeEvent;

	[Token(Token = "0x4006557")]
	[FieldOffset(Offset = "0x24")]
	public Action<float, float> OnAngleChangeEvent;

	[Token(Token = "0x4006558")]
	[FieldOffset(Offset = "0x28")]
	public Action<string, string> OnSpriteNameChangeEvent;

	[Token(Token = "0x4006559")]
	[FieldOffset(Offset = "0x2C")]
	public Action<string, string> OnHostHudEntityIDChangeEvent;

	[Token(Token = "0x400655A")]
	[FieldOffset(Offset = "0x30")]
	public Action<int, int> OnFileIDChangeEvent;

	[Token(Token = "0x6005E03")]
	[Address(RVA = "0x2C68F3C", Offset = "0x2C68F3C", VA = "0x2C68F3C")]
	public HudButtonWidgetEntity(string entityID)
	{
	}

	[Token(Token = "0x6005E04")]
	[Address(RVA = "0x2C69054", Offset = "0x2C69054", VA = "0x2C69054", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005E05")]
	[Address(RVA = "0x2C690AC", Offset = "0x2C690AC", VA = "0x2C690AC")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005E06")]
	[Address(RVA = "0x2C691D8", Offset = "0x2C691D8", VA = "0x2C691D8")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005E07")]
	[Address(RVA = "0x2C698AC", Offset = "0x2C698AC", VA = "0x2C698AC")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E08")]
	[Address(RVA = "0x2C6998C", Offset = "0x2C6998C", VA = "0x2C6998C")]
	public bool ActiveSelf()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E09")]
	[Address(RVA = "0x2C69A68", Offset = "0x2C69A68", VA = "0x2C69A68")]
	public Vector3 LocalPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6005E0A")]
	[Address(RVA = "0x2C69B60", Offset = "0x2C69B60", VA = "0x2C69B60")]
	public int Width()
	{
		return default(int);
	}

	[Token(Token = "0x6005E0B")]
	[Address(RVA = "0x2C69C3C", Offset = "0x2C69C3C", VA = "0x2C69C3C")]
	public int Height()
	{
		return default(int);
	}

	[Token(Token = "0x6005E0C")]
	[Address(RVA = "0x2C69D18", Offset = "0x2C69D18", VA = "0x2C69D18")]
	public float Angle()
	{
		return default(float);
	}

	[Token(Token = "0x6005E0D")]
	[Address(RVA = "0x2C69DF4", Offset = "0x2C69DF4", VA = "0x2C69DF4")]
	public string SpriteName()
	{
		return null;
	}

	[Token(Token = "0x6005E0E")]
	[Address(RVA = "0x2C69ED0", Offset = "0x2C69ED0", VA = "0x2C69ED0")]
	public string HostHudEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005E0F")]
	[Address(RVA = "0x2C69FAC", Offset = "0x2C69FAC", VA = "0x2C69FAC")]
	public int FileID()
	{
		return default(int);
	}
}
