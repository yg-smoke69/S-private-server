using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2003FD4")]
public class LightmapInfo
{
	[Token(Token = "0x401ADC4")]
	[FieldOffset(Offset = "0x8")]
	public int lightmapIndex;

	[Token(Token = "0x401ADC5")]
	[FieldOffset(Offset = "0xC")]
	public Vector4 lightmapScaleOffset;

	[Token(Token = "0x6019FA9")]
	[Address(RVA = "0x3116D64", Offset = "0x3116D64", VA = "0x3116D64")]
	public LightmapInfo()
	{
	}
}
