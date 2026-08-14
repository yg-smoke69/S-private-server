using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D2D")]
public class ABSceneMatRef
{
	[Token(Token = "0x4019F16")]
	[FieldOffset(Offset = "0x8")]
	public List<KeyValuePair<int, short>> m_texPairs;

	[Token(Token = "0x4019F17")]
	[FieldOffset(Offset = "0xC")]
	public int m_refCount;

	[Token(Token = "0x4019F18")]
	[FieldOffset(Offset = "0x10")]
	public Material m_mat;

	[Token(Token = "0x6018794")]
	[Address(RVA = "0x35BBCF4", Offset = "0x35BBCF4", VA = "0x35BBCF4")]
	public ABSceneMatRef()
	{
	}
}
