using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D28")]
public class ABSceneLightMapInfo
{
	[Token(Token = "0x4019F06")]
	[FieldOffset(Offset = "0x8")]
	public int m_id;

	[Token(Token = "0x4019F07")]
	[FieldOffset(Offset = "0xC")]
	public Vector4 m_offset;

	[Token(Token = "0x601878E")]
	[Address(RVA = "0x35BBCB4", Offset = "0x35BBCB4", VA = "0x35BBCB4")]
	public ABSceneLightMapInfo(int id, Vector4 offset)
	{
	}
}
