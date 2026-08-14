using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000C51")]
public class HudLabelWidgetEntity : _Attribute
{
	[Token(Token = "0x400657B")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x400657C")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x400657D")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x400657E")]
	[FieldOffset(Offset = "0x14")]
	public Action<bool, bool> OnActiveSelfChangeEvent;

	[Token(Token = "0x400657F")]
	[FieldOffset(Offset = "0x18")]
	public Action<Vector3, Vector3> OnLocalPositionChangeEvent;

	[Token(Token = "0x4006580")]
	[FieldOffset(Offset = "0x1C")]
	public Action<int, int> OnWidthChangeEvent;

	[Token(Token = "0x4006581")]
	[FieldOffset(Offset = "0x20")]
	public Action<int, int> OnHeightChangeEvent;

	[Token(Token = "0x4006582")]
	[FieldOffset(Offset = "0x24")]
	public Action<float, float> OnAngleChangeEvent;

	[Token(Token = "0x4006583")]
	[FieldOffset(Offset = "0x28")]
	public Action<int, int> OnColorChangeEvent;

	[Token(Token = "0x4006584")]
	[FieldOffset(Offset = "0x2C")]
	public Action<string, string> OnTextChangeEvent;

	[Token(Token = "0x4006585")]
	[FieldOffset(Offset = "0x30")]
	public Action<string, string> OnHostHudEntityIDChangeEvent;

	[Token(Token = "0x4006586")]
	[FieldOffset(Offset = "0x34")]
	public Action<int, int> OnFileIDChangeEvent;

	[Token(Token = "0x6005E36")]
	[Address(RVA = "0x2C6D994", Offset = "0x2C6D994", VA = "0x2C6D994")]
	public HudLabelWidgetEntity(string entityID)
	{
	}

	[Token(Token = "0x6005E37")]
	[Address(RVA = "0x2C6DAAC", Offset = "0x2C6DAAC", VA = "0x2C6DAAC", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005E38")]
	[Address(RVA = "0x2C6DB04", Offset = "0x2C6DB04", VA = "0x2C6DB04")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005E39")]
	[Address(RVA = "0x2C6DC34", Offset = "0x2C6DC34", VA = "0x2C6DC34")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005E3A")]
	[Address(RVA = "0x2C6E36C", Offset = "0x2C6E36C", VA = "0x2C6E36C")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E3B")]
	[Address(RVA = "0x2C6E44C", Offset = "0x2C6E44C", VA = "0x2C6E44C")]
	public bool ActiveSelf()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E3C")]
	[Address(RVA = "0x2C6E528", Offset = "0x2C6E528", VA = "0x2C6E528")]
	public Vector3 LocalPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6005E3D")]
	[Address(RVA = "0x2C6E620", Offset = "0x2C6E620", VA = "0x2C6E620")]
	public int Width()
	{
		return default(int);
	}

	[Token(Token = "0x6005E3E")]
	[Address(RVA = "0x2C6E6FC", Offset = "0x2C6E6FC", VA = "0x2C6E6FC")]
	public int Height()
	{
		return default(int);
	}

	[Token(Token = "0x6005E3F")]
	[Address(RVA = "0x2C6E7D8", Offset = "0x2C6E7D8", VA = "0x2C6E7D8")]
	public float Angle()
	{
		return default(float);
	}

	[Token(Token = "0x6005E40")]
	[Address(RVA = "0x2C6E8B4", Offset = "0x2C6E8B4", VA = "0x2C6E8B4")]
	public int Color()
	{
		return default(int);
	}

	[Token(Token = "0x6005E41")]
	[Address(RVA = "0x2C6E990", Offset = "0x2C6E990", VA = "0x2C6E990")]
	public string Text()
	{
		return null;
	}

	[Token(Token = "0x6005E42")]
	[Address(RVA = "0x2C6EA6C", Offset = "0x2C6EA6C", VA = "0x2C6EA6C")]
	public string HostHudEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005E43")]
	[Address(RVA = "0x2C6EB48", Offset = "0x2C6EB48", VA = "0x2C6EB48")]
	public int FileID()
	{
		return default(int);
	}
}
