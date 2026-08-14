using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UMA;

[Serializable]
[Token(Token = "0x2003CE7")]
public struct SubMeshTriangles
{
	[Token(Token = "0x4019DE4")]
	[FieldOffset(Offset = "0x0")]
	public int[] triangles;

	[Token(Token = "0x4019DE5")]
	[FieldOffset(Offset = "0x4")]
	public List<int> trianglesList;
}
