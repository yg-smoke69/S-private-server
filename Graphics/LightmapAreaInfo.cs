using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2003FD5")]
public class LightmapAreaInfo
{
	[Token(Token = "0x401ADC6")]
	[FieldOffset(Offset = "0x8")]
	public int[] areaID;

	[Token(Token = "0x401ADC7")]
	[FieldOffset(Offset = "0xC")]
	public List<Renderer> renderers;

	[Token(Token = "0x401ADC8")]
	[FieldOffset(Offset = "0x10")]
	public List<Texture2D> lightmaps;

	[Token(Token = "0x401ADC9")]
	[FieldOffset(Offset = "0x14")]
	public List<Texture2D> shadowmasks;

	[Token(Token = "0x401ADCA")]
	[FieldOffset(Offset = "0x18")]
	public List<LightmapInfo> lightmapInfo;

	[Token(Token = "0x6019FAA")]
	[Address(RVA = "0x3116954", Offset = "0x3116954", VA = "0x3116954")]
	public LightmapAreaInfo()
	{
	}

	[Token(Token = "0x6019FAB")]
	[Address(RVA = "0x3116A60", Offset = "0x3116A60", VA = "0x3116A60")]
	public void Clear()
	{
	}
}
