using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000A23")]
public class PreviewAutoChangePosByCamera : MonoBehaviour
{
	[Token(Token = "0x4005B09")]
	[FieldOffset(Offset = "0xC")]
	public float radio;

	[Token(Token = "0x4005B0A")]
	[FieldOffset(Offset = "0x10")]
	private Camera m_camera;

	[Token(Token = "0x6004F32")]
	[Address(RVA = "0x1C12CFC", Offset = "0x1C12CFC", VA = "0x1C12CFC")]
	public PreviewAutoChangePosByCamera()
	{
	}

	[Token(Token = "0x6004F33")]
	[Address(RVA = "0x1C12D04", Offset = "0x1C12D04", VA = "0x1C12D04")]
	public void SetCamera(Camera cam)
	{
	}
}
