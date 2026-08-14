using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200042B")]
public class MockCamera : MonoBehaviour
{
	[Token(Token = "0x4003B71")]
	[FieldOffset(Offset = "0xC")]
	public Camera targetCamera;

	[Token(Token = "0x4003B72")]
	[FieldOffset(Offset = "0x10")]
	private Camera m_camera;

	[Token(Token = "0x60014A9")]
	[Address(RVA = "0x1C70468", Offset = "0x1C70468", VA = "0x1C70468")]
	public MockCamera()
	{
	}

	[Token(Token = "0x60014AA")]
	[Address(RVA = "0x1C70470", Offset = "0x1C70470", VA = "0x1C70470")]
	private void Start()
	{
	}

	[Token(Token = "0x60014AB")]
	[Address(RVA = "0x1C70564", Offset = "0x1C70564", VA = "0x1C70564")]
	private void LateUpdate()
	{
	}
}
