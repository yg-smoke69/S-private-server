using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D7D")]
public class PreviewZoomConfig : MonoBehaviour
{
	[Token(Token = "0x4011746")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 Position;

	[Token(Token = "0x4011747")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 Scale;

	[Token(Token = "0x60130A9")]
	[Address(RVA = "0x19682BC", Offset = "0x19682BC", VA = "0x19682BC")]
	public PreviewZoomConfig()
	{
	}
}
