using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000808")]
internal class TransformRotater
{
	[Token(Token = "0x40050A2")]
	[FieldOffset(Offset = "0x8")]
	public Transform Root;

	[Token(Token = "0x40050A3")]
	[FieldOffset(Offset = "0xC")]
	public Transform RotX;

	[Token(Token = "0x40050A4")]
	[FieldOffset(Offset = "0x10")]
	public Transform RotY;

	[Token(Token = "0x40050A5")]
	[FieldOffset(Offset = "0x14")]
	public Transform RotZ;

	[Token(Token = "0x40050A6")]
	[FieldOffset(Offset = "0x18")]
	public Transform Center;

	[Token(Token = "0x40050A7")]
	[FieldOffset(Offset = "0x1C")]
	public TransformRotaterAngleCalculator AngleCalculator;

	[Token(Token = "0x40050A8")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 m_CurrentRotAngles;

	[Token(Token = "0x40050A9")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 m_CurrentLocalDir;

	[Token(Token = "0x40050AA")]
	[FieldOffset(Offset = "0x38")]
	private Matrix4x4 m_ToLocal;

	[Token(Token = "0x6003342")]
	[Address(RVA = "0x263B5A8", Offset = "0x263B5A8", VA = "0x263B5A8")]
	public TransformRotater()
	{
	}

	[Token(Token = "0x6003343")]
	[Address(RVA = "0x263B5B0", Offset = "0x263B5B0", VA = "0x263B5B0")]
	public void Init(bool reset)
	{
	}

	[Token(Token = "0x6003344")]
	[Address(RVA = "0x263BC28", Offset = "0x263BC28", VA = "0x263BC28")]
	private bool NeedUpdate(Transform tr, float current, float val)
	{
		return default(bool);
	}

	[Token(Token = "0x6003345")]
	[Address(RVA = "0x263B898", Offset = "0x263B898", VA = "0x263B898")]
	public bool RotateToEular(float x, float y, float z)
	{
		return default(bool);
	}

	[Token(Token = "0x6003346")]
	[Address(RVA = "0x263BD08", Offset = "0x263BD08", VA = "0x263BD08")]
	public bool RotateToDir(Vector3 targetPoint, float maxAngles = 360f)
	{
		return default(bool);
	}
}
