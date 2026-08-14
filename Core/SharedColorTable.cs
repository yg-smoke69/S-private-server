using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

[Serializable]
[Token(Token = "0x2003C96")]
public class SharedColorTable : ScriptableObject, _Attribute
{
	[Token(Token = "0x4019C1E")]
	[FieldOffset(Offset = "0xC")]
	public int channelCount;

	[Token(Token = "0x4019C1F")]
	[FieldOffset(Offset = "0x10")]
	public string sharedColorName;

	[Token(Token = "0x4019C20")]
	[FieldOffset(Offset = "0x14")]
	public float colorNormalized;

	[Token(Token = "0x4019C21")]
	[FieldOffset(Offset = "0x18")]
	public OverlayColorData[] colors;

	[Token(Token = "0x60183DA")]
	[Address(RVA = "0x21C5A98", Offset = "0x21C5A98", VA = "0x21C5A98")]
	public SharedColorTable()
	{
	}

	[Token(Token = "0x60183DB")]
	[Address(RVA = "0x21C5AA8", Offset = "0x21C5AA8", VA = "0x21C5AA8", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x60183DC")]
	[Address(RVA = "0x21C5AAC", Offset = "0x21C5AAC", VA = "0x21C5AAC", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}
}
