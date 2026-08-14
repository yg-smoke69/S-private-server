using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D2B")]
public class ABSceneMeshRef
{
	[Token(Token = "0x4019F12")]
	[FieldOffset(Offset = "0x8")]
	public int m_refCount;

	[Token(Token = "0x4019F13")]
	[FieldOffset(Offset = "0xC")]
	public Mesh m_mesh;

	[Token(Token = "0x6018792")]
	[Address(RVA = "0x35BBCFC", Offset = "0x35BBCFC", VA = "0x35BBCFC")]
	public ABSceneMeshRef(int refCount, Mesh mesh)
	{
	}
}
