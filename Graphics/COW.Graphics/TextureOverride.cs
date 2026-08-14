using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Graphics;

[Token(Token = "0x2004000")]
public class TextureOverride : MonoBehaviour
{
	[Token(Token = "0x2004001")]
	public enum LMAJOFFNLFL
	{
		[Token(Token = "0x401AEDD")]
		Type_Snow,
		[Token(Token = "0x401AEDE")]
		Type_RTShadow,
		[Token(Token = "0x401AEDF")]
		Type_HD,
		[Token(Token = "0x401AEE0")]
		Type_RegionActivity,
		[Token(Token = "0x401AEE1")]
		Type_Count
	}

	[Serializable]
	[Token(Token = "0x2004002")]
	public class OverrideMode
	{
		[Token(Token = "0x401AEE2")]
		[FieldOffset(Offset = "0x8")]
		public LMAJOFFNLFL type;

		[Token(Token = "0x401AEE3")]
		[FieldOffset(Offset = "0xC")]
		public string sub_type;

		[Token(Token = "0x401AEE4")]
		[FieldOffset(Offset = "0x10")]
		public string[] textureOverridePaths;

		[Token(Token = "0x601A12D")]
		[Address(RVA = "0x1D3D670", Offset = "0x1D3D670", VA = "0x1D3D670")]
		public OverrideMode()
		{
		}
	}

	[Token(Token = "0x2004003")]
	private sealed class LBFPBAONOLC
	{
		[Token(Token = "0x401AEE5")]
		[FieldOffset(Offset = "0x8")]
		internal Dictionary<int, int> DDIKKEGICNI;

		[Token(Token = "0x601A12E")]
		[Address(RVA = "0x1D3CF40", Offset = "0x1D3CF40", VA = "0x1D3CF40")]
		public LBFPBAONOLC()
		{
		}

		[Token(Token = "0x601A12F")]
		[Address(RVA = "0x1D3D484", Offset = "0x1D3D484", VA = "0x1D3D484")]
		internal int CHOPCLCOBKC(OverrideMode MKNFGPOONMF, OverrideMode PJFPHENKMIJ)
		{
			return default(int);
		}
	}

	[Token(Token = "0x401AED8")]
	[FieldOffset(Offset = "0xC")]
	public string[] textureNames;

	[Token(Token = "0x401AED9")]
	[FieldOffset(Offset = "0x10")]
	public string[] texturePaths;

	[Token(Token = "0x401AEDA")]
	[FieldOffset(Offset = "0x14")]
	public List<OverrideMode> overrideModeList;

	[Token(Token = "0x401AEDB")]
	[FieldOffset(Offset = "0x18")]
	private MeshRenderer BJPGHGGNNLO;

	[Token(Token = "0x601A126")]
	[Address(RVA = "0x1D3CC64", Offset = "0x1D3CC64", VA = "0x1D3CC64")]
	public TextureOverride()
	{
	}

	[Token(Token = "0x601A127")]
	[Address(RVA = "0x1D3CCF0", Offset = "0x1D3CCF0", VA = "0x1D3CCF0")]
	private void Awake()
	{
	}

	[Token(Token = "0x601A128")]
	[Address(RVA = "0x1D3CF48", Offset = "0x1D3CF48", VA = "0x1D3CF48")]
	private void Start()
	{
	}

	[Token(Token = "0x601A129")]
	[Address(RVA = "0x1D3CF70", Offset = "0x1D3CF70", VA = "0x1D3CF70")]
	public bool NeedRegistToSceneGraphics()
	{
		return default(bool);
	}

	[Token(Token = "0x601A12A")]
	[Address(RVA = "0x1D3D084", Offset = "0x1D3D084", VA = "0x1D3D084")]
	public Material GetMaterial()
	{
		return null;
	}

	[Token(Token = "0x601A12B")]
	[Address(RVA = "0x1D3A434", Offset = "0x1D3A434", VA = "0x1D3A434")]
	public Material ApplyOverrideTextures()
	{
		return null;
	}

	[Token(Token = "0x601A12C")]
	[Address(RVA = "0x1D3D15C", Offset = "0x1D3D15C", VA = "0x1D3D15C")]
	private Material DPHHBIBACFJ(string[] HAACIOKGOJN)
	{
		return null;
	}
}
