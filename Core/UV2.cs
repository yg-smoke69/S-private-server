using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2004035")]
public class UV2
{
	[Token(Token = "0x401B020")]
	[FieldOffset(Offset = "0x8")]
	public Vector2[] verts;

	[Token(Token = "0x601A268")]
	[Address(RVA = "0x2A63494", Offset = "0x2A63494", VA = "0x2A63494")]
	public UV2(Vector2[] verts)
	{
	}

	[Token(Token = "0x601A269")]
	[Address(RVA = "0x2A634B4", Offset = "0x2A634B4", VA = "0x2A634B4")]
	public static implicit operator UV2(Vector2[] verts)
	{
		return null;
	}
}
