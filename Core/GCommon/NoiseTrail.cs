using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003EA3")]
public class NoiseTrail : MonoBehaviour
{
	[Token(Token = "0x2003EA4")]
	public enum SmokeTypes
	{
		[Token(Token = "0x401A766")]
		Noise,
		[Token(Token = "0x401A767")]
		Sin,
		[Token(Token = "0x401A768")]
		SinNoise
	}

	[Token(Token = "0x2003EA5")]
	public enum CurveTypes
	{
		[Token(Token = "0x401A76A")]
		Linear,
		[Token(Token = "0x401A76B")]
		Quadratic,
		[Token(Token = "0x401A76C")]
		Cubic,
		[Token(Token = "0x401A76D")]
		Quartic,
		[Token(Token = "0x401A76E")]
		Quintic,
		[Token(Token = "0x401A76F")]
		Sinusoidal,
		[Token(Token = "0x401A770")]
		Exponential,
		[Token(Token = "0x401A771")]
		Circular
	}

	[Token(Token = "0x401A751")]
	[FieldOffset(Offset = "0xC")]
	public SmokeTypes m_smokeType;

	[Token(Token = "0x401A752")]
	[FieldOffset(Offset = "0x10")]
	public int m_numOfPoints;

	[Token(Token = "0x401A753")]
	[FieldOffset(Offset = "0x14")]
	public float m_updateSpeed;

	[Token(Token = "0x401A754")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 m_speed;

	[Token(Token = "0x401A755")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 m_noiseStrength;

	[Token(Token = "0x401A756")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 m_sinStrength;

	[Token(Token = "0x401A757")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 m_sinRatio;

	[Token(Token = "0x401A758")]
	[FieldOffset(Offset = "0x48")]
	public CurveTypes m_curveType;

	[Token(Token = "0x401A759")]
	[FieldOffset(Offset = "0x4C")]
	public Vector3 m_curvePower;

	[Token(Token = "0x401A75A")]
	[FieldOffset(Offset = "0x58")]
	private LineRenderer m_lr;

	[Token(Token = "0x401A75B")]
	[FieldOffset(Offset = "0x5C")]
	private Transform m_trans;

	[Token(Token = "0x401A75C")]
	[FieldOffset(Offset = "0x60")]
	private Vector3[] m_pos;

	[Token(Token = "0x401A75D")]
	[FieldOffset(Offset = "0x64")]
	private Vector3[] m_dirs;

	[Token(Token = "0x401A75E")]
	[FieldOffset(Offset = "0x68")]
	private Vector3[] m_weights;

	[Token(Token = "0x401A75F")]
	[FieldOffset(Offset = "0x6C")]
	private float m_timeSinceUpdate;

	[Token(Token = "0x401A760")]
	[FieldOffset(Offset = "0x70")]
	private float m_lineSegment;

	[Token(Token = "0x401A761")]
	[FieldOffset(Offset = "0x74")]
	private int m_currentNumOfPoints;

	[Token(Token = "0x401A762")]
	[FieldOffset(Offset = "0x78")]
	private bool m_allPointsAdded;

	[Token(Token = "0x401A763")]
	[FieldOffset(Offset = "0x79")]
	private bool m_useWorldSpace;

	[Token(Token = "0x401A764")]
	[FieldOffset(Offset = "0x7C")]
	private float m_timer;

	[Token(Token = "0x60197B2")]
	[Address(RVA = "0x297AE64", Offset = "0x297AE64", VA = "0x297AE64")]
	public NoiseTrail()
	{
	}

	[Token(Token = "0x60197B3")]
	[Address(RVA = "0x297AFB4", Offset = "0x297AFB4", VA = "0x297AFB4")]
	private void Start()
	{
	}

	[Token(Token = "0x60197B4")]
	[Address(RVA = "0x297B928", Offset = "0x297B928", VA = "0x297B928")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60197B5")]
	[Address(RVA = "0x297B2C4", Offset = "0x297B2C4", VA = "0x297B2C4")]
	private bool GetLineRendererUseWorldSpace()
	{
		return default(bool);
	}

	[Token(Token = "0x60197B6")]
	[Address(RVA = "0x297C23C", Offset = "0x297C23C", VA = "0x297C23C")]
	private void InitWeights()
	{
	}

	[Token(Token = "0x60197B7")]
	[Address(RVA = "0x297B32C", Offset = "0x297B32C", VA = "0x297B32C")]
	private Vector3[] CalcWeight()
	{
		return null;
	}

	[Token(Token = "0x60197B8")]
	[Address(RVA = "0x297B2F0", Offset = "0x297B2F0", VA = "0x297B2F0")]
	private Vector3 GetSmokeVec()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60197B9")]
	[Address(RVA = "0x297C458", Offset = "0x297C458", VA = "0x297C458")]
	private Vector3 GetSmokeVec_Noise()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60197BA")]
	[Address(RVA = "0x297C5A8", Offset = "0x297C5A8", VA = "0x297C5A8")]
	private Vector3 GetSmokeVec_Sin()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60197BB")]
	[Address(RVA = "0x297C71C", Offset = "0x297C71C", VA = "0x297C71C")]
	private Vector3 GetSmokeVec_SinNoise()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60197BC")]
	[Address(RVA = "0x297C8DC", Offset = "0x297C8DC", VA = "0x297C8DC")]
	private Vector3 Pow2(Vector3 a)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60197BD")]
	[Address(RVA = "0x297C98C", Offset = "0x297C98C", VA = "0x297C98C")]
	private Vector3 Pow3(Vector3 a)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60197BE")]
	[Address(RVA = "0x297CA4C", Offset = "0x297CA4C", VA = "0x297CA4C")]
	private Vector3 Pow4(Vector3 a)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60197BF")]
	[Address(RVA = "0x297CB2C", Offset = "0x297CB2C", VA = "0x297CB2C")]
	private Vector3 Pow5(Vector3 a)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60197C0")]
	[Address(RVA = "0x297CBF0", Offset = "0x297CBF0", VA = "0x297CBF0")]
	private Vector3 Sin(Vector3 a)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60197C1")]
	[Address(RVA = "0x297CCC4", Offset = "0x297CCC4", VA = "0x297CCC4")]
	private Vector3 Exp(Vector3 a)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60197C2")]
	[Address(RVA = "0x297CD98", Offset = "0x297CD98", VA = "0x297CD98")]
	private Vector3 Cir(Vector3 a)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60197C3")]
	[Address(RVA = "0x297C378", Offset = "0x297C378", VA = "0x297C378")]
	private Vector3 Quadratic(Vector3 a)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60197C4")]
	[Address(RVA = "0x297C398", Offset = "0x297C398", VA = "0x297C398")]
	private Vector3 Cubic(Vector3 a)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60197C5")]
	[Address(RVA = "0x297C3B8", Offset = "0x297C3B8", VA = "0x297C3B8")]
	private Vector3 Quartic(Vector3 a)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60197C6")]
	[Address(RVA = "0x297C3D8", Offset = "0x297C3D8", VA = "0x297C3D8")]
	private Vector3 Quintic(Vector3 a)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60197C7")]
	[Address(RVA = "0x297C3F8", Offset = "0x297C3F8", VA = "0x297C3F8")]
	private Vector3 Sinusoidal(Vector3 a)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60197C8")]
	[Address(RVA = "0x297C418", Offset = "0x297C418", VA = "0x297C418")]
	private Vector3 Exponential(Vector3 a)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60197C9")]
	[Address(RVA = "0x297C438", Offset = "0x297C438", VA = "0x297C438")]
	private Vector3 Circular(Vector3 a)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}
}
