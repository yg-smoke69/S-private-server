using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x2003CEB")]
public class UMABlendFrame
{
	[Token(Token = "0x4019DEE")]
	[FieldOffset(Offset = "0x8")]
	public float frameWeight;

	[Token(Token = "0x4019DEF")]
	[FieldOffset(Offset = "0xC")]
	public Vector3[] deltaVertices;

	[Token(Token = "0x4019DF0")]
	[FieldOffset(Offset = "0x10")]
	public Vector3[] deltaNormals;

	[Token(Token = "0x4019DF1")]
	[FieldOffset(Offset = "0x14")]
	public Vector3[] deltaTangents;

	[Token(Token = "0x601860B")]
	[Address(RVA = "0x2DEDC1C", Offset = "0x2DEDC1C", VA = "0x2DEDC1C")]
	public UMABlendFrame(int vertexCount)
	{
	}
}
