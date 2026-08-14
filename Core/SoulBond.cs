using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B3B")]
public class SoulBond : MonoBehaviour
{
	[Token(Token = "0x4006091")]
	public const int MAXREFREHFRAMECOUNT = 200;

	[Token(Token = "0x4006092")]
	[FieldOffset(Offset = "0xC")]
	public GameObject AnchorGameObject;

	[Token(Token = "0x4006093")]
	[FieldOffset(Offset = "0x10")]
	public int Interpolation;

	[Token(Token = "0x4006094")]
	[FieldOffset(Offset = "0x14")]
	private bool UseLocalPosition;

	[Token(Token = "0x4006095")]
	[FieldOffset(Offset = "0x18")]
	public List<Transform> LinePoints;

	[Token(Token = "0x4006096")]
	[FieldOffset(Offset = "0x1C")]
	public List<AnchorPoint> AnchorPoints;

	[Token(Token = "0x4006097")]
	[FieldOffset(Offset = "0x20")]
	public List<ControlPair> ControlPoints;

	[Token(Token = "0x4006098")]
	[FieldOffset(Offset = "0x24")]
	public List<RandomVertexRecorder> RandomPoints;

	[Token(Token = "0x4006099")]
	[FieldOffset(Offset = "0x28")]
	private LineRenderer m_lineRenderer;

	[Token(Token = "0x400609A")]
	[FieldOffset(Offset = "0x2C")]
	private readonly List<Transform> m_linePoints;

	[Token(Token = "0x400609B")]
	[FieldOffset(Offset = "0x30")]
	private readonly List<ControlPair> m_controlPoints;

	[Token(Token = "0x400609C")]
	[FieldOffset(Offset = "0x34")]
	private Vector3[] m_pointArray;

	[Token(Token = "0x400609D")]
	[FieldOffset(Offset = "0x38")]
	private Vector3[] m_ditherArray;

	[Token(Token = "0x400609E")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3[] m_traingles;

	[Token(Token = "0x400609F")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<int, Vector3[]> m_RandomVertexs;

	[Token(Token = "0x40060A0")]
	[FieldOffset(Offset = "0x44")]
	private Dictionary<int, int[]> m_RandomTriangles;

	[Token(Token = "0x40060A1")]
	[FieldOffset(Offset = "0x48")]
	public bool Edit;

	[Token(Token = "0x40060A2")]
	[FieldOffset(Offset = "0x49")]
	public bool Curve;

	[Token(Token = "0x40060A3")]
	[FieldOffset(Offset = "0x4A")]
	public bool Dither;

	[Token(Token = "0x40060A4")]
	[FieldOffset(Offset = "0x4C")]
	public float PointMaxSpeed;

	[Token(Token = "0x40060A5")]
	[FieldOffset(Offset = "0x50")]
	public float PointMaxDrift;

	[Token(Token = "0x40060A6")]
	[FieldOffset(Offset = "0x54")]
	public int CurrentMidPointIndex;

	[Token(Token = "0x40060A7")]
	[FieldOffset(Offset = "0x58")]
	public int ReFreshFrameCount;

	[Token(Token = "0x40060A8")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 m_ditherUnitSpeed;

	[Token(Token = "0x40060A9")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 m_currentPointOffset;

	[Token(Token = "0x40060AA")]
	[FieldOffset(Offset = "0x74")]
	private int m_frameCountForRandom;

	[Token(Token = "0x600562E")]
	[Address(RVA = "0x21D3A18", Offset = "0x21D3A18", VA = "0x21D3A18")]
	public SoulBond()
	{
	}

	[Token(Token = "0x600562F")]
	[Address(RVA = "0x21D3C3C", Offset = "0x21D3C3C", VA = "0x21D3C3C")]
	private void Start()
	{
	}

	[Token(Token = "0x6005630")]
	[Address(RVA = "0x21D3D2C", Offset = "0x21D3D2C", VA = "0x21D3D2C")]
	private void Update()
	{
	}

	[Token(Token = "0x6005631")]
	[Address(RVA = "0x21D4920", Offset = "0x21D4920", VA = "0x21D4920")]
	private void DrawStraight()
	{
	}

	[Token(Token = "0x6005632")]
	[Address(RVA = "0x21D4544", Offset = "0x21D4544", VA = "0x21D4544")]
	private void DrawDither()
	{
	}

	[Token(Token = "0x6005633")]
	[Address(RVA = "0x21D3E0C", Offset = "0x21D3E0C", VA = "0x21D3E0C")]
	private void DrawCurve()
	{
	}

	[Token(Token = "0x6005634")]
	[Address(RVA = "0x21D4D10", Offset = "0x21D4D10", VA = "0x21D4D10")]
	private Vector3 GetLinePoints(int index, bool isLessThanSet)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6005635")]
	[Address(RVA = "0x21D5494", Offset = "0x21D5494", VA = "0x21D5494")]
	private Vector3 RandomMeshPoint(int index)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6005636")]
	[Address(RVA = "0x21D52D0", Offset = "0x21D52D0", VA = "0x21D52D0")]
	private Vector3 CalculateCubicBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}
}
