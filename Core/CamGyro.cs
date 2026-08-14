using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200410E")]
public class CamGyro : MonoBehaviour
{
	[Token(Token = "0x401B52A")]
	[FieldOffset(Offset = "0xC")]
	private Camera Cam1;

	[Token(Token = "0x401B52B")]
	[FieldOffset(Offset = "0x10")]
	private Camera Cam2;

	[Token(Token = "0x401B52C")]
	[FieldOffset(Offset = "0x14")]
	private Vector3 initEuler;

	[Token(Token = "0x401B52D")]
	[FieldOffset(Offset = "0x20")]
	private Quaternion initRotation;

	[Token(Token = "0x401B52E")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 lastInitEuler;

	[Token(Token = "0x401B52F")]
	[FieldOffset(Offset = "0x3C")]
	private float vertRotateRateScale;

	[Token(Token = "0x401B530")]
	[FieldOffset(Offset = "0x40")]
	private float horiRotateRateScale;

	[Token(Token = "0x401B531")]
	[FieldOffset(Offset = "0x44")]
	private float restoreRate;

	[Token(Token = "0x401B532")]
	[FieldOffset(Offset = "0x48")]
	private float maxRotateAngleX;

	[Token(Token = "0x401B533")]
	[FieldOffset(Offset = "0x4C")]
	private float maxRotateAngleY;

	[Token(Token = "0x401B534")]
	[FieldOffset(Offset = "0x50")]
	private Material Mat;

	[Token(Token = "0x401B535")]
	[FieldOffset(Offset = "0x54")]
	private Material Mat2;

	[Token(Token = "0x401B536")]
	[FieldOffset(Offset = "0x58")]
	private int m_matoffsetXID;

	[Token(Token = "0x401B537")]
	[FieldOffset(Offset = "0x5C")]
	private int m_matoffsetYID;

	[Token(Token = "0x401B538")]
	[FieldOffset(Offset = "0x60")]
	private float offsetX;

	[Token(Token = "0x401B539")]
	[FieldOffset(Offset = "0x64")]
	private float offsetY;

	[Token(Token = "0x401B53A")]
	[FieldOffset(Offset = "0x68")]
	private float vertRotateRate;

	[Token(Token = "0x401B53B")]
	[FieldOffset(Offset = "0x6C")]
	private float horiRotateRate;

	[Token(Token = "0x601A910")]
	[Address(RVA = "0x2308620", Offset = "0x2308620", VA = "0x2308620")]
	public CamGyro()
	{
	}

	[Token(Token = "0x601A911")]
	[Address(RVA = "0x2308754", Offset = "0x2308754", VA = "0x2308754")]
	private void Init()
	{
	}

	[Token(Token = "0x601A912")]
	[Address(RVA = "0x23088BC", Offset = "0x23088BC", VA = "0x23088BC")]
	private void CameraRotateControl()
	{
	}

	[Token(Token = "0x601A913")]
	[Address(RVA = "0x2309440", Offset = "0x2309440", VA = "0x2309440")]
	private void Start()
	{
	}

	[Token(Token = "0x601A914")]
	[Address(RVA = "0x2309444", Offset = "0x2309444", VA = "0x2309444")]
	private void Update()
	{
	}

	[Token(Token = "0x601A915")]
	[Address(RVA = "0x2309448", Offset = "0x2309448", VA = "0x2309448")]
	public void ResetCamRotation()
	{
	}
}
