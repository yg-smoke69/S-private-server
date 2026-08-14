using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000C62")]
public class PresentTextEntity : _Attribute
{
	[Token(Token = "0x40065E3")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x40065E4")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x40065E5")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x40065E6")]
	[FieldOffset(Offset = "0x14")]
	public Action<string, string> OnTextKeyChangeEvent;

	[Token(Token = "0x40065E7")]
	[FieldOffset(Offset = "0x18")]
	public Action<int, int> OnColorChangeEvent;

	[Token(Token = "0x40065E8")]
	[FieldOffset(Offset = "0x1C")]
	public Action<float, float> OnScaleChangeEvent;

	[Token(Token = "0x40065E9")]
	[FieldOffset(Offset = "0x20")]
	public Action<Vector3, Vector3> OnOffsetChangeEvent;

	[Token(Token = "0x40065EA")]
	[FieldOffset(Offset = "0x24")]
	public Action<string, string> OnFollowTargetChangeEvent;

	[Token(Token = "0x40065EB")]
	[FieldOffset(Offset = "0x28")]
	public Action<bool, bool> OnIgnoreDepthChangeEvent;

	[Token(Token = "0x6005EC0")]
	[Address(RVA = "0x1C1081C", Offset = "0x1C1081C", VA = "0x1C1081C")]
	public PresentTextEntity(string entityID)
	{
	}

	[Token(Token = "0x6005EC1")]
	[Address(RVA = "0x1C10934", Offset = "0x1C10934", VA = "0x1C10934", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005EC2")]
	[Address(RVA = "0x1C1098C", Offset = "0x1C1098C", VA = "0x1C1098C")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005EC3")]
	[Address(RVA = "0x1C10AB0", Offset = "0x1C10AB0", VA = "0x1C10AB0")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005EC4")]
	[Address(RVA = "0x1C110BC", Offset = "0x1C110BC", VA = "0x1C110BC")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005EC5")]
	[Address(RVA = "0x1C1119C", Offset = "0x1C1119C", VA = "0x1C1119C")]
	public string TextKey()
	{
		return null;
	}

	[Token(Token = "0x6005EC6")]
	[Address(RVA = "0x1C11278", Offset = "0x1C11278", VA = "0x1C11278")]
	public int Color()
	{
		return default(int);
	}

	[Token(Token = "0x6005EC7")]
	[Address(RVA = "0x1C11354", Offset = "0x1C11354", VA = "0x1C11354")]
	public float Scale()
	{
		return default(float);
	}

	[Token(Token = "0x6005EC8")]
	[Address(RVA = "0x1C11430", Offset = "0x1C11430", VA = "0x1C11430")]
	public Vector3 Offset()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6005EC9")]
	[Address(RVA = "0x1C11528", Offset = "0x1C11528", VA = "0x1C11528")]
	public string FollowTarget()
	{
		return null;
	}

	[Token(Token = "0x6005ECA")]
	[Address(RVA = "0x1C11604", Offset = "0x1C11604", VA = "0x1C11604")]
	public bool IgnoreDepth()
	{
		return default(bool);
	}
}
