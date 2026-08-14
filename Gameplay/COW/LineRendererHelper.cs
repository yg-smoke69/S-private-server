using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D60")]
public class LineRendererHelper : MonoBehaviour
{
	[Token(Token = "0x4011668")]
	[FieldOffset(Offset = "0xC")]
	private List<Transform> _dummyPositions;

	[Token(Token = "0x4011669")]
	[FieldOffset(Offset = "0x10")]
	public bool useTileAnimation;

	[Token(Token = "0x401166A")]
	[FieldOffset(Offset = "0x14")]
	public float animCtl;

	[Token(Token = "0x401166B")]
	[FieldOffset(Offset = "0x18")]
	public float mainTexTiling;

	[Token(Token = "0x401166C")]
	[FieldOffset(Offset = "0x1C")]
	public Texture MainTex;

	[Token(Token = "0x401166D")]
	[FieldOffset(Offset = "0x20")]
	public LineRenderer lineRenderer;

	[Token(Token = "0x401166E")]
	[FieldOffset(Offset = "0x24")]
	public bool UIFX_random;

	[Token(Token = "0x401166F")]
	[FieldOffset(Offset = "0x28")]
	private Color lineColor;

	[Token(Token = "0x4011670")]
	[FieldOffset(Offset = "0x38")]
	public bool useDistanceFade;

	[Token(Token = "0x4011671")]
	[FieldOffset(Offset = "0x3C")]
	public float farDistance;

	[Token(Token = "0x4011672")]
	[FieldOffset(Offset = "0x40")]
	public float nearDistance;

	[Token(Token = "0x4011673")]
	[FieldOffset(Offset = "0x44")]
	private float lineDistance;

	[Token(Token = "0x4011674")]
	[FieldOffset(Offset = "0x48")]
	public Material mMat;

	[Token(Token = "0x4011675")]
	[FieldOffset(Offset = "0x4C")]
	public Transform scaleRoot;

	[Token(Token = "0x4011676")]
	[FieldOffset(Offset = "0x50")]
	private int MainTex_ID;

	[Token(Token = "0x4011677")]
	[FieldOffset(Offset = "0x54")]
	private int MainTex_ST_ID;

	[Token(Token = "0x4011678")]
	[FieldOffset(Offset = "0x58")]
	private bool m_IsPlayAnimation;

	[Token(Token = "0x1700136A")]
	public List<Transform> DummyPositions
	{
		[Token(Token = "0x6012FB8")]
		[Address(RVA = "0xEC3F44", Offset = "0xEC3F44", VA = "0xEC3F44")]
		get
		{
			return null;
		}
		[Token(Token = "0x6012FB7")]
		[Address(RVA = "0xEC3ED8", Offset = "0xEC3ED8", VA = "0xEC3ED8")]
		set
		{
		}
	}

	[Token(Token = "0x6012FAE")]
	[Address(RVA = "0xEC2ED8", Offset = "0xEC2ED8", VA = "0xEC2ED8")]
	public LineRendererHelper()
	{
	}

	[Token(Token = "0x6012FAF")]
	[Address(RVA = "0xEC2F40", Offset = "0xEC2F40", VA = "0xEC2F40")]
	private void GetMaterial()
	{
	}

	[Token(Token = "0x6012FB0")]
	[Address(RVA = "0xEC2FBC", Offset = "0xEC2FBC", VA = "0xEC2FBC")]
	private void GetScaleRoot()
	{
	}

	[Token(Token = "0x6012FB1")]
	[Address(RVA = "0xEC3130", Offset = "0xEC3130", VA = "0xEC3130")]
	public void InitShaderID()
	{
	}

	[Token(Token = "0x6012FB2")]
	[Address(RVA = "0xEC31FC", Offset = "0xEC31FC", VA = "0xEC31FC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6012FB3")]
	[Address(RVA = "0xEC3354", Offset = "0xEC3354", VA = "0xEC3354")]
	public void UpdateLineDots()
	{
	}

	[Token(Token = "0x6012FB4")]
	[Address(RVA = "0xEC365C", Offset = "0xEC365C", VA = "0xEC365C")]
	public void UpdateLineMats()
	{
	}

	[Token(Token = "0x6012FB5")]
	[Address(RVA = "0xEC395C", Offset = "0xEC395C", VA = "0xEC395C")]
	public void UpdateLineColor()
	{
	}

	[Token(Token = "0x6012FB6")]
	[Address(RVA = "0xEC3B70", Offset = "0xEC3B70", VA = "0xEC3B70")]
	private float CalculateLineRendererLength()
	{
		return default(float);
	}

	[Token(Token = "0x6012FB9")]
	[Address(RVA = "0xEC3F9C", Offset = "0xEC3F9C", VA = "0xEC3F9C")]
	private void LateUpdate()
	{
	}
}
