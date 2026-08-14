using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000A2A")]
public class PreviewCommon3dAdjust : MonoBehaviour
{
	[Token(Token = "0x4005B2A")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 scale;

	[Token(Token = "0x4005B2B")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 OffsetScale;

	[Token(Token = "0x4005B2C")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 OffsetPos;

	[Token(Token = "0x4005B2D")]
	[FieldOffset(Offset = "0x30")]
	public float HeightY;

	[Token(Token = "0x6004F66")]
	[Address(RVA = "0x1C19D58", Offset = "0x1C19D58", VA = "0x1C19D58")]
	public PreviewCommon3dAdjust()
	{
	}
}
