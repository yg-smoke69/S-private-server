using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200336E")]
public class MouseOrTouch
{
	[Token(Token = "0x4013959")]
	[FieldOffset(Offset = "0x8")]
	public KeyCode key;

	[Token(Token = "0x401395A")]
	[FieldOffset(Offset = "0xC")]
	public Vector2 pos;

	[Token(Token = "0x401395B")]
	[FieldOffset(Offset = "0x14")]
	public Vector2 lastPos;

	[Token(Token = "0x401395C")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2 dragStartPos;

	[Token(Token = "0x401395D")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 delta;

	[Token(Token = "0x401395E")]
	[FieldOffset(Offset = "0x2C")]
	public Vector2 totalDelta;

	[Token(Token = "0x401395F")]
	[FieldOffset(Offset = "0x34")]
	public GameObject last;

	[Token(Token = "0x4013960")]
	[FieldOffset(Offset = "0x38")]
	public GameObject current;

	[Token(Token = "0x4013961")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject pressed;

	[Token(Token = "0x4013962")]
	[FieldOffset(Offset = "0x40")]
	public GameObject dragged;

	[Token(Token = "0x4013963")]
	[FieldOffset(Offset = "0x44")]
	public float pressTime;

	[Token(Token = "0x4013964")]
	[FieldOffset(Offset = "0x48")]
	public float clickTime;

	[Token(Token = "0x4013965")]
	[FieldOffset(Offset = "0x4C")]
	public bool touchBegan;

	[Token(Token = "0x4013966")]
	[FieldOffset(Offset = "0x4D")]
	public bool pressStarted;

	[Token(Token = "0x4013967")]
	[FieldOffset(Offset = "0x4E")]
	public bool dragStarted;

	[Token(Token = "0x170016D5")]
	public float deltaTime
	{
		[Token(Token = "0x6015DEC")]
		[Address(RVA = "0x228FF78", Offset = "0x228FF78", VA = "0x228FF78")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6015DEB")]
	[Address(RVA = "0x228FF68", Offset = "0x228FF68", VA = "0x228FF68")]
	public MouseOrTouch()
	{
	}
}
