using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D7C")]
public class PositionChasing : MonoBehaviour
{
	[Token(Token = "0x4011741")]
	[FieldOffset(Offset = "0xC")]
	private Vector3 lastPos;

	[Token(Token = "0x4011742")]
	[FieldOffset(Offset = "0x18")]
	public float smoothFact;

	[Token(Token = "0x4011743")]
	[FieldOffset(Offset = "0x1C")]
	private float smoothFactRandom;

	[Token(Token = "0x4011744")]
	[FieldOffset(Offset = "0x20")]
	public float smoothRandom;

	[Token(Token = "0x4011745")]
	[FieldOffset(Offset = "0x24")]
	public Transform parentRoot;

	[Token(Token = "0x60130A6")]
	[Address(RVA = "0x1C0DA58", Offset = "0x1C0DA58", VA = "0x1C0DA58")]
	public PositionChasing()
	{
	}

	[Token(Token = "0x60130A7")]
	[Address(RVA = "0x1C0DB14", Offset = "0x1C0DB14", VA = "0x1C0DB14")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60130A8")]
	[Address(RVA = "0x1C0DCE0", Offset = "0x1C0DCE0", VA = "0x1C0DCE0")]
	private void Update()
	{
	}
}
