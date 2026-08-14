using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2004050")]
public class WorldSpaceDissolve : MonoBehaviour
{
	[Token(Token = "0x401B101")]
	[FieldOffset(Offset = "0xC")]
	public List<Renderer> targets;

	[Token(Token = "0x401B102")]
	[FieldOffset(Offset = "0x10")]
	public Transform FadeCenterDummy;

	[Token(Token = "0x401B103")]
	[FieldOffset(Offset = "0x14")]
	public float AnimCtl;

	[Token(Token = "0x401B104")]
	[FieldOffset(Offset = "0x18")]
	public float WaveScale;

	[Token(Token = "0x401B105")]
	[FieldOffset(Offset = "0x1C")]
	public float HeightScale;

	[Token(Token = "0x401B106")]
	[FieldOffset(Offset = "0x20")]
	public bool Invert;

	[Token(Token = "0x401B107")]
	[FieldOffset(Offset = "0x21")]
	public bool TopFront;

	[Token(Token = "0x401B108")]
	[FieldOffset(Offset = "0x24")]
	public Color Color;

	[Token(Token = "0x401B109")]
	[FieldOffset(Offset = "0x34")]
	public float CC;

	[Token(Token = "0x401B10A")]
	[FieldOffset(Offset = "0x38")]
	public float ColorIntensive;

	[Token(Token = "0x401B10B")]
	[FieldOffset(Offset = "0x3C")]
	public float ColorPower;

	[Token(Token = "0x401B10C")]
	[FieldOffset(Offset = "0x40")]
	public float AlphaIntensive;

	[Token(Token = "0x401B10D")]
	[FieldOffset(Offset = "0x44")]
	public Texture DistortTexRG;

	[Token(Token = "0x401B10E")]
	[FieldOffset(Offset = "0x48")]
	public Vector2 DistortTiling;

	[Token(Token = "0x401B10F")]
	[FieldOffset(Offset = "0x50")]
	public Vector2 DistortOffset;

	[Token(Token = "0x401B110")]
	[FieldOffset(Offset = "0x58")]
	public Vector2 DistortXY;

	[Token(Token = "0x401B111")]
	[FieldOffset(Offset = "0x60")]
	public Vector2 DistortPanner;

	[Token(Token = "0x401B112")]
	[FieldOffset(Offset = "0x68")]
	public Texture SeamTex;

	[Token(Token = "0x401B113")]
	[FieldOffset(Offset = "0x6C")]
	public Vector2 SeamTexTiling;

	[Token(Token = "0x401B114")]
	[FieldOffset(Offset = "0x74")]
	public Vector2 SeamTexOffset;

	[Token(Token = "0x401B115")]
	[FieldOffset(Offset = "0x7C")]
	public float SeamSize;

	[Token(Token = "0x401B116")]
	[FieldOffset(Offset = "0x80")]
	public float FixAlpha;

	[Token(Token = "0x401B117")]
	[FieldOffset(Offset = "0x84")]
	public bool SeamAddMul;

	[Token(Token = "0x401B118")]
	[FieldOffset(Offset = "0x85")]
	public bool Updating;

	[Token(Token = "0x401B119")]
	[FieldOffset(Offset = "0x86")]
	public bool _NULL_BasicSettings;

	[Token(Token = "0x401B11A")]
	[FieldOffset(Offset = "0x87")]
	public bool _NULL_ColorCorrection;

	[Token(Token = "0x401B11B")]
	[FieldOffset(Offset = "0x88")]
	public bool _NULL_Distort;

	[Token(Token = "0x401B11C")]
	[FieldOffset(Offset = "0x89")]
	public bool _NULL_Seam;

	[Token(Token = "0x401B11D")]
	[FieldOffset(Offset = "0x8C")]
	private MaterialPropertyBlock _mpb;

	[Token(Token = "0x401B11E")]
	[FieldOffset(Offset = "0x90")]
	private int DummyPos01_ID;

	[Token(Token = "0x401B11F")]
	[FieldOffset(Offset = "0x94")]
	private int AnimCtl_ID;

	[Token(Token = "0x401B120")]
	[FieldOffset(Offset = "0x98")]
	private int Color_ID;

	[Token(Token = "0x401B121")]
	[FieldOffset(Offset = "0x9C")]
	private int ColorCorrection_ID;

	[Token(Token = "0x401B122")]
	[FieldOffset(Offset = "0xA0")]
	private int DistortTexRG_ID;

	[Token(Token = "0x401B123")]
	[FieldOffset(Offset = "0xA4")]
	private int DistortTexRG_ST_ID;

	[Token(Token = "0x401B124")]
	[FieldOffset(Offset = "0xA8")]
	private int DistortValue_ID;

	[Token(Token = "0x401B125")]
	[FieldOffset(Offset = "0xAC")]
	private int SeamTex_ID;

	[Token(Token = "0x401B126")]
	[FieldOffset(Offset = "0xB0")]
	private int SeamTex_ST_ID;

	[Token(Token = "0x401B127")]
	[FieldOffset(Offset = "0xB4")]
	private int Vector01_ID;

	[Token(Token = "0x401B128")]
	[FieldOffset(Offset = "0xB8")]
	private int Toggle_ID;

	[Token(Token = "0x601A2C1")]
	[Address(RVA = "0x2BDB930", Offset = "0x2BDB930", VA = "0x2BDB930")]
	public WorldSpaceDissolve()
	{
	}

	[Token(Token = "0x601A2C2")]
	[Address(RVA = "0x2BDBAE0", Offset = "0x2BDBAE0", VA = "0x2BDBAE0")]
	private void InitShaderID()
	{
	}

	[Token(Token = "0x601A2C3")]
	[Address(RVA = "0x2BDBC60", Offset = "0x2BDBC60", VA = "0x2BDBC60")]
	public void UpdateData()
	{
	}

	[Token(Token = "0x601A2C4")]
	[Address(RVA = "0x2BDC17C", Offset = "0x2BDC17C", VA = "0x2BDC17C")]
	public void InitData()
	{
	}

	[Token(Token = "0x601A2C5")]
	[Address(RVA = "0x2BDC268", Offset = "0x2BDC268", VA = "0x2BDC268")]
	private void Awake()
	{
	}

	[Token(Token = "0x601A2C6")]
	[Address(RVA = "0x2BDC2D8", Offset = "0x2BDC2D8", VA = "0x2BDC2D8")]
	private void Start()
	{
	}

	[Token(Token = "0x601A2C7")]
	[Address(RVA = "0x2BDC2F4", Offset = "0x2BDC2F4", VA = "0x2BDC2F4")]
	private void LateUpdate()
	{
	}
}
