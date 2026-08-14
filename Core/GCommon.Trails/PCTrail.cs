using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon.Utillities;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon.Trails;

[Token(Token = "0x2003EB9")]
public class PCTrail : _Attribute
{
	[Token(Token = "0x401A7BB")]
	[FieldOffset(Offset = "0x8")]
	public CircularBuffer<PCTrailPoint> Points;

	[Token(Token = "0x401A7BC")]
	[FieldOffset(Offset = "0xC")]
	public Mesh Mesh;

	[Token(Token = "0x401A7BD")]
	[FieldOffset(Offset = "0x10")]
	public List<Vector3> verticies;

	[Token(Token = "0x401A7BE")]
	[FieldOffset(Offset = "0x14")]
	public List<Vector3> normals;

	[Token(Token = "0x401A7BF")]
	[FieldOffset(Offset = "0x18")]
	public List<Vector2> uvs;

	[Token(Token = "0x401A7C0")]
	[FieldOffset(Offset = "0x1C")]
	public List<Color> colors;

	[Token(Token = "0x401A7C1")]
	[FieldOffset(Offset = "0x20")]
	public int[] indicies;

	[Token(Token = "0x401A7C2")]
	[FieldOffset(Offset = "0x24")]
	public int activePointCount;

	[Token(Token = "0x401A7C3")]
	[FieldOffset(Offset = "0x28")]
	public bool IsActiveTrail;

	[Token(Token = "0x601983B")]
	[Address(RVA = "0x323F134", Offset = "0x323F134", VA = "0x323F134")]
	public PCTrail(int numPoints)
	{
	}

	[Token(Token = "0x601983C")]
	[Address(RVA = "0x323F364", Offset = "0x323F364", VA = "0x323F364", Slot = "4")]
	public void Dispose()
	{
	}
}
