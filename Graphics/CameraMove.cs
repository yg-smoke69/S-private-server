using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002D2")]
public class CameraMove : MonoBehaviour
{
	[Token(Token = "0x4003314")]
	[FieldOffset(Offset = "0xC")]
	private Transform currentObject;

	[Token(Token = "0x4003315")]
	[FieldOffset(Offset = "0x10")]
	public float translateSpeed;

	[Token(Token = "0x4003316")]
	[FieldOffset(Offset = "0x14")]
	public float rotateSpeed;

	[Token(Token = "0x4003317")]
	[FieldOffset(Offset = "0x18")]
	public float zoomSpeed;

	[Token(Token = "0x6000D97")]
	[Address(RVA = "0x2309674", Offset = "0x2309674", VA = "0x2309674")]
	public CameraMove()
	{
	}

	[Token(Token = "0x6000D98")]
	[Address(RVA = "0x2309698", Offset = "0x2309698", VA = "0x2309698")]
	private void Update()
	{
	}
}
