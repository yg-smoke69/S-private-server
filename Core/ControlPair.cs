using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000B39")]
public class ControlPair
{
	[Token(Token = "0x400608D")]
	[FieldOffset(Offset = "0x8")]
	public Vector3 Offset1;

	[Token(Token = "0x400608E")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 Offset2;

	[Token(Token = "0x600562B")]
	[Address(RVA = "0x230FD34", Offset = "0x230FD34", VA = "0x230FD34")]
	public ControlPair(Vector3 node1, Vector3 node2)
	{
	}
}
