using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000C60")]
public class PresentIconEntity : _Attribute
{
	[Token(Token = "0x40065D4")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x40065D5")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x40065D6")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x40065D7")]
	[FieldOffset(Offset = "0x14")]
	public Action<string, string> OnIconTypeChangeEvent;

	[Token(Token = "0x40065D8")]
	[FieldOffset(Offset = "0x18")]
	public Action<int, int> OnColorChangeEvent;

	[Token(Token = "0x40065D9")]
	[FieldOffset(Offset = "0x1C")]
	public Action<float, float> OnScaleChangeEvent;

	[Token(Token = "0x40065DA")]
	[FieldOffset(Offset = "0x20")]
	public Action<Vector3, Vector3> OnOffsetChangeEvent;

	[Token(Token = "0x40065DB")]
	[FieldOffset(Offset = "0x24")]
	public Action<string, string> OnFollowTargetChangeEvent;

	[Token(Token = "0x40065DC")]
	[FieldOffset(Offset = "0x28")]
	public Action<bool, bool> OnIgnoreDepthChangeEvent;

	[Token(Token = "0x40065DD")]
	[FieldOffset(Offset = "0x2C")]
	public Action<bool, bool> OnAlwaysInScreenChangeEvent;

	[Token(Token = "0x6005EAD")]
	[Address(RVA = "0x1C0EF08", Offset = "0x1C0EF08", VA = "0x1C0EF08")]
	public PresentIconEntity(string entityID)
	{
	}

	[Token(Token = "0x6005EAE")]
	[Address(RVA = "0x1C0F020", Offset = "0x1C0F020", VA = "0x1C0F020", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005EAF")]
	[Address(RVA = "0x1C0F078", Offset = "0x1C0F078", VA = "0x1C0F078")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005EB0")]
	[Address(RVA = "0x1C0F19C", Offset = "0x1C0F19C", VA = "0x1C0F19C")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005EB1")]
	[Address(RVA = "0x1C0F814", Offset = "0x1C0F814", VA = "0x1C0F814")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005EB2")]
	[Address(RVA = "0x1C0F8F4", Offset = "0x1C0F8F4", VA = "0x1C0F8F4")]
	public string IconType()
	{
		return null;
	}

	[Token(Token = "0x6005EB3")]
	[Address(RVA = "0x1C0F9D0", Offset = "0x1C0F9D0", VA = "0x1C0F9D0")]
	public int Color()
	{
		return default(int);
	}

	[Token(Token = "0x6005EB4")]
	[Address(RVA = "0x1C0FAAC", Offset = "0x1C0FAAC", VA = "0x1C0FAAC")]
	public float Scale()
	{
		return default(float);
	}

	[Token(Token = "0x6005EB5")]
	[Address(RVA = "0x1C0FB88", Offset = "0x1C0FB88", VA = "0x1C0FB88")]
	public Vector3 Offset()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6005EB6")]
	[Address(RVA = "0x1C0FC80", Offset = "0x1C0FC80", VA = "0x1C0FC80")]
	public string FollowTarget()
	{
		return null;
	}

	[Token(Token = "0x6005EB7")]
	[Address(RVA = "0x1C0FD5C", Offset = "0x1C0FD5C", VA = "0x1C0FD5C")]
	public bool IgnoreDepth()
	{
		return default(bool);
	}

	[Token(Token = "0x6005EB8")]
	[Address(RVA = "0x1C0FE38", Offset = "0x1C0FE38", VA = "0x1C0FE38")]
	public bool AlwaysInScreen()
	{
		return default(bool);
	}
}
