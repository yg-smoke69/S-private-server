using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000C5F")]
public class PresentEffectEntity : _Attribute
{
	[Token(Token = "0x40065CC")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x40065CD")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x40065CE")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x40065CF")]
	[FieldOffset(Offset = "0x14")]
	public Action<string, string> OnEffectTypeChangeEvent;

	[Token(Token = "0x40065D0")]
	[FieldOffset(Offset = "0x18")]
	public Action<int, int> OnColorChangeEvent;

	[Token(Token = "0x40065D1")]
	[FieldOffset(Offset = "0x1C")]
	public Action<float, float> OnScaleChangeEvent;

	[Token(Token = "0x40065D2")]
	[FieldOffset(Offset = "0x20")]
	public Action<Vector3, Vector3> OnOffsetChangeEvent;

	[Token(Token = "0x40065D3")]
	[FieldOffset(Offset = "0x24")]
	public Action<string, string> OnFollowTargetChangeEvent;

	[Token(Token = "0x6005EA3")]
	[Address(RVA = "0x1C0E188", Offset = "0x1C0E188", VA = "0x1C0E188")]
	public PresentEffectEntity(string entityID)
	{
	}

	[Token(Token = "0x6005EA4")]
	[Address(RVA = "0x1C0E2A0", Offset = "0x1C0E2A0", VA = "0x1C0E2A0", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005EA5")]
	[Address(RVA = "0x1C0E2F8", Offset = "0x1C0E2F8", VA = "0x1C0E2F8")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005EA6")]
	[Address(RVA = "0x1C0E420", Offset = "0x1C0E420", VA = "0x1C0E420")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005EA7")]
	[Address(RVA = "0x1C0E9C0", Offset = "0x1C0E9C0", VA = "0x1C0E9C0")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005EA8")]
	[Address(RVA = "0x1C0EAA0", Offset = "0x1C0EAA0", VA = "0x1C0EAA0")]
	public string EffectType()
	{
		return null;
	}

	[Token(Token = "0x6005EA9")]
	[Address(RVA = "0x1C0EB7C", Offset = "0x1C0EB7C", VA = "0x1C0EB7C")]
	public int Color()
	{
		return default(int);
	}

	[Token(Token = "0x6005EAA")]
	[Address(RVA = "0x1C0EC58", Offset = "0x1C0EC58", VA = "0x1C0EC58")]
	public float Scale()
	{
		return default(float);
	}

	[Token(Token = "0x6005EAB")]
	[Address(RVA = "0x1C0ED34", Offset = "0x1C0ED34", VA = "0x1C0ED34")]
	public Vector3 Offset()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6005EAC")]
	[Address(RVA = "0x1C0EE2C", Offset = "0x1C0EE2C", VA = "0x1C0EE2C")]
	public string FollowTarget()
	{
		return null;
	}
}
