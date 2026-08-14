using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200418A")]
internal class FollowAndAutoRotationCamera : MonoBehaviour
{
	[Token(Token = "0x401B7A5")]
	private const float C_OFFSET_RIGHT = 0.22f;

	[Token(Token = "0x401B7A6")]
	private const float C_OFFSET_UP = 0.25f;

	[Token(Token = "0x401B7A7")]
	private const float C_OFFSET_BACK = 1.75f;

	[Token(Token = "0x401B7A8")]
	[FieldOffset(Offset = "0xC")]
	public float RightOffset;

	[Token(Token = "0x401B7A9")]
	[FieldOffset(Offset = "0x10")]
	public float UpOffset;

	[Token(Token = "0x401B7AA")]
	[FieldOffset(Offset = "0x14")]
	public float BackOffset;

	[Token(Token = "0x401B7AB")]
	[FieldOffset(Offset = "0x18")]
	public MPICKNDAPEB Target;

	[Token(Token = "0x401B7AC")]
	[FieldOffset(Offset = "0x1C")]
	private List<GameObject> lastHits;

	[Token(Token = "0x601AC6E")]
	[Address(RVA = "0x26ADDEC", Offset = "0x26ADDEC", VA = "0x26ADDEC")]
	public FollowAndAutoRotationCamera()
	{
	}

	[Token(Token = "0x601AC6F")]
	[Address(RVA = "0x26ADE98", Offset = "0x26ADE98", VA = "0x26ADE98")]
	private void LateUpdate()
	{
	}
}
