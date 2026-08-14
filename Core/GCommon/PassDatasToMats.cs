using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003E75")]
public class PassDatasToMats : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2003E76")]
	public class MusicObject
	{
		[Token(Token = "0x401A69D")]
		[FieldOffset(Offset = "0x8")]
		public int Band;

		[Token(Token = "0x401A69E")]
		[FieldOffset(Offset = "0xC")]
		public GameObject Obj;

		[Token(Token = "0x60196D1")]
		[Address(RVA = "0x2982FB8", Offset = "0x2982FB8", VA = "0x2982FB8")]
		public MusicObject()
		{
		}
	}

	[Token(Token = "0x401A68A")]
	[FieldOffset(Offset = "0xC")]
	public bool UseBuffer;

	[Token(Token = "0x401A68B")]
	[FieldOffset(Offset = "0x10")]
	public List<MusicObject> MObjs;

	[Token(Token = "0x401A68C")]
	[FieldOffset(Offset = "0x14")]
	private List<Material> Mat_List;

	[Token(Token = "0x401A68D")]
	[FieldOffset(Offset = "0x18")]
	private List<int> Band_List;

	[Token(Token = "0x401A68E")]
	[FieldOffset(Offset = "0x1C")]
	private int _musicData_id;

	[Token(Token = "0x401A68F")]
	[FieldOffset(Offset = "0x20")]
	private int _emissionColor_id;

	[Token(Token = "0x401A690")]
	[FieldOffset(Offset = "0x24")]
	private int _musicDataTexture_id;

	[Token(Token = "0x401A691")]
	[FieldOffset(Offset = "0x28")]
	public bool IsRenderingDataToTexture2D;

	[Token(Token = "0x401A692")]
	[FieldOffset(Offset = "0x2C")]
	public float Delay;

	[Token(Token = "0x401A693")]
	[FieldOffset(Offset = "0x30")]
	public float LowFrequencyThreshold;

	[Token(Token = "0x401A694")]
	[FieldOffset(Offset = "0x34")]
	public float LowFrequencyStrength;

	[Token(Token = "0x401A695")]
	[FieldOffset(Offset = "0x38")]
	public float HighFrequencyStrength;

	[Token(Token = "0x401A696")]
	[FieldOffset(Offset = "0x3C")]
	public Texture2D _musicDataTexture;

	[Token(Token = "0x401A697")]
	[FieldOffset(Offset = "0x40")]
	public FilterMode FilterMode;

	[Token(Token = "0x401A698")]
	[FieldOffset(Offset = "0x44")]
	private float[] spectrumDataDelay;

	[Token(Token = "0x401A699")]
	[FieldOffset(Offset = "0x48")]
	public float ScrMin;

	[Token(Token = "0x401A69A")]
	[FieldOffset(Offset = "0x4C")]
	public float ScrMax;

	[Token(Token = "0x401A69B")]
	[FieldOffset(Offset = "0x50")]
	public float DstMin;

	[Token(Token = "0x401A69C")]
	[FieldOffset(Offset = "0x54")]
	public float DstMax;

	[Token(Token = "0x60196C8")]
	[Address(RVA = "0x2982058", Offset = "0x2982058", VA = "0x2982058")]
	public PassDatasToMats()
	{
	}

	[Token(Token = "0x60196C9")]
	[Address(RVA = "0x298214C", Offset = "0x298214C", VA = "0x298214C")]
	private void Start()
	{
	}

	[Token(Token = "0x60196CA")]
	[Address(RVA = "0x2982670", Offset = "0x2982670", VA = "0x2982670")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60196CB")]
	[Address(RVA = "0x2982EE8", Offset = "0x2982EE8", VA = "0x2982EE8")]
	private float Remap(float iMin, float iMax, float cMin, float cMax, float t)
	{
		return default(float);
	}

	[Token(Token = "0x60196CC")]
	[Address(RVA = "0x29826CC", Offset = "0x29826CC", VA = "0x29826CC")]
	private void PassAmplitudeToMat(int id, bool useBuffer, float strength = 1f)
	{
	}

	[Token(Token = "0x60196CD")]
	[Address(RVA = "0x2982870", Offset = "0x2982870", VA = "0x2982870")]
	private void PassBandToMat(int id, bool useBuffer, float strength = 1f)
	{
	}

	[Token(Token = "0x60196CE")]
	[Address(RVA = "0x2982AF0", Offset = "0x2982AF0", VA = "0x2982AF0")]
	private void RenderDataToTexture2D(float LowFrequencyStrength = 8000f, float HighFrequencyStrength = 1f, float LowFrequencyThreshold = 0f)
	{
	}

	[Token(Token = "0x60196CF")]
	[Address(RVA = "0x29824F8", Offset = "0x29824F8", VA = "0x29824F8")]
	private void GenerateMusicDataTexture2D()
	{
	}

	[Token(Token = "0x60196D0")]
	[Address(RVA = "0x29821EC", Offset = "0x29821EC", VA = "0x29821EC")]
	private void GetAllMats()
	{
	}
}
