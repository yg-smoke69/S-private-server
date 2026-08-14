using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2003FDB")]
public class LightmapAreaInfoNoRef
{
	[Token(Token = "0x401AE6F")]
	[FieldOffset(Offset = "0x8")]
	public int[] areaID;

	[Token(Token = "0x401AE70")]
	[FieldOffset(Offset = "0xC")]
	public List<string> rendererID;

	[Token(Token = "0x401AE71")]
	[FieldOffset(Offset = "0x10")]
	public List<Texture2D> lightmaps;

	[Token(Token = "0x401AE72")]
	[FieldOffset(Offset = "0x14")]
	public List<Texture2D> shadowmasks;

	[Token(Token = "0x401AE73")]
	[FieldOffset(Offset = "0x18")]
	public List<LightmapInfo> lightmapInfo;

	[Token(Token = "0x601A014")]
	[Address(RVA = "0x3116B5C", Offset = "0x3116B5C", VA = "0x3116B5C")]
	public LightmapAreaInfoNoRef()
	{
	}

	[Token(Token = "0x601A015")]
	[Address(RVA = "0x3116C68", Offset = "0x3116C68", VA = "0x3116C68")]
	public void Clear()
	{
	}
}
