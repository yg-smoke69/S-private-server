using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000B3A")]
public class RandomVertexRecorder
{
	[Token(Token = "0x400608F")]
	[FieldOffset(Offset = "0x8")]
	public bool UseRandom;

	[Token(Token = "0x4006090")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 RandomVertex;

	[Token(Token = "0x600562C")]
	[Address(RVA = "0x3155C98", Offset = "0x3155C98", VA = "0x3155C98")]
	public RandomVertexRecorder()
	{
	}

	[Token(Token = "0x600562D")]
	[Address(RVA = "0x3155D3C", Offset = "0x3155D3C", VA = "0x3155D3C")]
	public RandomVertexRecorder(bool useRandom, Vector3 randomVertex)
	{
	}
}
