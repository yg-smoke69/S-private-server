using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D88")]
public class UIFake3DCamera : MonoBehaviour
{
	[Token(Token = "0x401176C")]
	[FieldOffset(Offset = "0xC")]
	public Transform FakeCamera;

	[Token(Token = "0x401176D")]
	[FieldOffset(Offset = "0x10")]
	private float originDistance;

	[Token(Token = "0x401176E")]
	[FieldOffset(Offset = "0x14")]
	public float focusDistance;

	[Token(Token = "0x401176F")]
	[FieldOffset(Offset = "0x18")]
	public List<float> ImageDistance;

	[Token(Token = "0x4011770")]
	[FieldOffset(Offset = "0x1C")]
	public List<Transform> targets;

	[Token(Token = "0x60130E2")]
	[Address(RVA = "0x1DB4A54", Offset = "0x1DB4A54", VA = "0x1DB4A54")]
	public UIFake3DCamera()
	{
	}

	[Token(Token = "0x60130E3")]
	[Address(RVA = "0x1DB4A6C", Offset = "0x1DB4A6C", VA = "0x1DB4A6C")]
	public void Update()
	{
	}

	[Token(Token = "0x60130E4")]
	[Address(RVA = "0x1DB4B8C", Offset = "0x1DB4B8C", VA = "0x1DB4B8C")]
	public void UpdateTargetsPosition()
	{
	}

	[Token(Token = "0x60130E5")]
	[Address(RVA = "0x1DB5210", Offset = "0x1DB5210", VA = "0x1DB5210")]
	public void InitRoots()
	{
	}
}
