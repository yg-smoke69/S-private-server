using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003FD1")]
public class RotateAroundLocalAxis : MonoBehaviour
{
	[Token(Token = "0x2003FD2")]
	public enum ERotateAxis
	{
		[Token(Token = "0x401ADBF")]
		X,
		[Token(Token = "0x401ADC0")]
		Y,
		[Token(Token = "0x401ADC1")]
		Z
	}

	[Token(Token = "0x401ADBB")]
	[FieldOffset(Offset = "0xC")]
	public ERotateAxis Axis;

	[Token(Token = "0x401ADBC")]
	[FieldOffset(Offset = "0x10")]
	public float Speed;

	[Token(Token = "0x401ADBD")]
	[FieldOffset(Offset = "0x14")]
	private Vector3 m_RotationAxis;

	[Token(Token = "0x6019F9E")]
	[Address(RVA = "0x3230780", Offset = "0x3230780", VA = "0x3230780")]
	public RotateAroundLocalAxis()
	{
	}

	[Token(Token = "0x6019F9F")]
	[Address(RVA = "0x3230798", Offset = "0x3230798", VA = "0x3230798")]
	private void Start()
	{
	}

	[Token(Token = "0x6019FA0")]
	[Address(RVA = "0x32308E0", Offset = "0x32308E0", VA = "0x32308E0")]
	private void Update()
	{
	}
}
