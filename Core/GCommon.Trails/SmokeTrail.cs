using Il2CppDummyDll;
using UnityEngine;

namespace GCommon.Trails;

[Token(Token = "0x2003EB4")]
public class SmokeTrail : TrailRenderer_Base
{
	[Token(Token = "0x401A7A5")]
	[FieldOffset(Offset = "0x20")]
	public Color MainColor;

	[Token(Token = "0x401A7A6")]
	[FieldOffset(Offset = "0x30")]
	public float MinVertexDistance;

	[Token(Token = "0x401A7A7")]
	[FieldOffset(Offset = "0x34")]
	public int MaxNumberOfPoints;

	[Token(Token = "0x401A7A8")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 m_LastPosition;

	[Token(Token = "0x401A7A9")]
	[FieldOffset(Offset = "0x44")]
	private float m_DistanceMoved;

	[Token(Token = "0x401A7AA")]
	[FieldOffset(Offset = "0x48")]
	public float RandomForceScale;

	[Token(Token = "0x601980A")]
	[Address(RVA = "0x3240734", Offset = "0x3240734", VA = "0x3240734")]
	public SmokeTrail()
	{
	}

	[Token(Token = "0x601980B")]
	[Address(RVA = "0x3240794", Offset = "0x3240794", VA = "0x3240794", Slot = "5")]
	protected override void Start()
	{
	}

	[Token(Token = "0x601980C")]
	[Address(RVA = "0x3240880", Offset = "0x3240880", VA = "0x3240880", Slot = "7")]
	protected override void Update()
	{
	}

	[Token(Token = "0x601980D")]
	[Address(RVA = "0x3240A58", Offset = "0x3240A58", VA = "0x3240A58", Slot = "12")]
	protected override void Reset()
	{
	}

	[Token(Token = "0x601980E")]
	[Address(RVA = "0x3240A80", Offset = "0x3240A80", VA = "0x3240A80", Slot = "13")]
	protected override void InitialiseNewPoint(PCTrailPoint newPoint)
	{
	}

	[Token(Token = "0x601980F")]
	[Address(RVA = "0x3240C6C", Offset = "0x3240C6C", VA = "0x3240C6C", Slot = "9")]
	protected override void OnTranslate(Vector3 t)
	{
	}

	[Token(Token = "0x6019810")]
	[Address(RVA = "0x3240D38", Offset = "0x3240D38", VA = "0x3240D38", Slot = "10")]
	protected override Color GetMainColor()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6019811")]
	[Address(RVA = "0x3240D48", Offset = "0x3240D48", VA = "0x3240D48", Slot = "11")]
	protected override int GetMaxNumberOfPoints()
	{
		return default(int);
	}
}
