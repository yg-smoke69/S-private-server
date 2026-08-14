using Il2CppDummyDll;
using UnityEngine;

namespace TsiU;

[Token(Token = "0x2003C44")]
public class THoverCameraController : MonoBehaviour
{
	[Token(Token = "0x2003C45")]
	private enum MouseButton
	{
		[Token(Token = "0x4019A4D")]
		Left,
		[Token(Token = "0x4019A4E")]
		Right,
		[Token(Token = "0x4019A4F")]
		Middle,
		[Token(Token = "0x4019A50")]
		None
	}

	[Token(Token = "0x4019A3C")]
	[FieldOffset(Offset = "0xC")]
	private readonly string MouseHorizontalAxisName;

	[Token(Token = "0x4019A3D")]
	[FieldOffset(Offset = "0x10")]
	private readonly string MouseVerticalAxisName;

	[Token(Token = "0x4019A3E")]
	[FieldOffset(Offset = "0x14")]
	private readonly string MouseScrollAxisName;

	[Token(Token = "0x4019A3F")]
	[FieldOffset(Offset = "0x18")]
	public Transform TargetObject;

	[Token(Token = "0x4019A40")]
	[FieldOffset(Offset = "0x1C")]
	public float CurrentPanAngle;

	[Token(Token = "0x4019A41")]
	[FieldOffset(Offset = "0x20")]
	public float CurrentTiltAngle;

	[Token(Token = "0x4019A42")]
	[FieldOffset(Offset = "0x24")]
	public float CurrentDistance;

	[Token(Token = "0x4019A43")]
	[FieldOffset(Offset = "0x28")]
	public float MinPanAngle;

	[Token(Token = "0x4019A44")]
	[FieldOffset(Offset = "0x2C")]
	public float MaxPanAngle;

	[Token(Token = "0x4019A45")]
	[FieldOffset(Offset = "0x30")]
	public float MinTiltAngle;

	[Token(Token = "0x4019A46")]
	[FieldOffset(Offset = "0x34")]
	public float MaxTiltAngle;

	[Token(Token = "0x4019A47")]
	[FieldOffset(Offset = "0x38")]
	public float PanMovementSensitivity;

	[Token(Token = "0x4019A48")]
	[FieldOffset(Offset = "0x3C")]
	public float TiltMovementSensitivity;

	[Token(Token = "0x4019A49")]
	[FieldOffset(Offset = "0x40")]
	public float DistanceMovementSensitivity;

	[Token(Token = "0x4019A4A")]
	[FieldOffset(Offset = "0x44")]
	public float UpOffset;

	[Token(Token = "0x4019A4B")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 _lookAtPosition;

	[Token(Token = "0x60180E0")]
	[Address(RVA = "0x26426F0", Offset = "0x26426F0", VA = "0x26426F0")]
	public THoverCameraController()
	{
	}

	[Token(Token = "0x60180E1")]
	[Address(RVA = "0x26427D8", Offset = "0x26427D8", VA = "0x26427D8")]
	private void Start()
	{
	}

	[Token(Token = "0x60180E2")]
	[Address(RVA = "0x26428EC", Offset = "0x26428EC", VA = "0x26428EC")]
	private void Update()
	{
	}
}
