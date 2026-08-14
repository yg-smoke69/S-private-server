using Il2CppDummyDll;
using UnityEngine;

namespace GCommon.Trails;

[Token(Token = "0x2003EB3")]
public class SmokePlume : TrailRenderer_Base
{
	[Token(Token = "0x401A79F")]
	[FieldOffset(Offset = "0x20")]
	public float TimeBetweenPoints;

	[Token(Token = "0x401A7A0")]
	[FieldOffset(Offset = "0x24")]
	public Color MainColor;

	[Token(Token = "0x401A7A1")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 ConstantForce;

	[Token(Token = "0x401A7A2")]
	[FieldOffset(Offset = "0x40")]
	public float RandomForceScale;

	[Token(Token = "0x401A7A3")]
	[FieldOffset(Offset = "0x44")]
	public int MaxNumberOfPoints;

	[Token(Token = "0x401A7A4")]
	[FieldOffset(Offset = "0x48")]
	private float m_TimeSincePoint;

	[Token(Token = "0x6019802")]
	[Address(RVA = "0x323F56C", Offset = "0x323F56C", VA = "0x323F56C")]
	public SmokePlume()
	{
	}

	[Token(Token = "0x6019803")]
	[Address(RVA = "0x323F674", Offset = "0x323F674", VA = "0x323F674", Slot = "5")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6019804")]
	[Address(RVA = "0x323F820", Offset = "0x323F820", VA = "0x323F820", Slot = "12")]
	protected override void Reset()
	{
	}

	[Token(Token = "0x6019805")]
	[Address(RVA = "0x323FD84", Offset = "0x323FD84", VA = "0x323FD84", Slot = "7")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6019806")]
	[Address(RVA = "0x3240358", Offset = "0x3240358", VA = "0x3240358", Slot = "13")]
	protected override void InitialiseNewPoint(PCTrailPoint newPoint)
	{
	}

	[Token(Token = "0x6019807")]
	[Address(RVA = "0x3240544", Offset = "0x3240544", VA = "0x3240544", Slot = "14")]
	protected override void UpdateTrail(PCTrail trail, float deltaTime)
	{
	}

	[Token(Token = "0x6019808")]
	[Address(RVA = "0x324071C", Offset = "0x324071C", VA = "0x324071C", Slot = "10")]
	protected override Color GetMainColor()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6019809")]
	[Address(RVA = "0x324072C", Offset = "0x324072C", VA = "0x324072C", Slot = "11")]
	protected override int GetMaxNumberOfPoints()
	{
		return default(int);
	}
}
