using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003F68")]
public class CutSceneLightmapStorage : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2003F69")]
	public class RendererInfo
	{
		[Token(Token = "0x401ABE0")]
		[FieldOffset(Offset = "0x8")]
		public Renderer renderer;

		[Token(Token = "0x401ABE1")]
		[FieldOffset(Offset = "0xC")]
		public int lightmapIndex;

		[Token(Token = "0x401ABE2")]
		[FieldOffset(Offset = "0x10")]
		public Vector4 lightmapOffsetScale;

		[Token(Token = "0x6019D29")]
		[Address(RVA = "0x23113BC", Offset = "0x23113BC", VA = "0x23113BC")]
		public RendererInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2003F6A")]
	public class LightInfo
	{
		[Token(Token = "0x401ABE3")]
		[FieldOffset(Offset = "0x8")]
		public Light light;

		[Token(Token = "0x401ABE4")]
		[FieldOffset(Offset = "0xC")]
		public int lightmapBaketype;

		[Token(Token = "0x401ABE5")]
		[FieldOffset(Offset = "0x10")]
		public int mixedLightingMode;

		[Token(Token = "0x6019D2A")]
		[Address(RVA = "0x23113B4", Offset = "0x23113B4", VA = "0x23113B4")]
		public LightInfo()
		{
		}
	}

	[Token(Token = "0x401ABDC")]
	[FieldOffset(Offset = "0xC")]
	public RendererInfo[] m_RendererInfo;

	[Token(Token = "0x401ABDD")]
	[FieldOffset(Offset = "0x10")]
	public Texture2D[] m_Lightmaps;

	[Token(Token = "0x401ABDE")]
	[FieldOffset(Offset = "0x14")]
	public Texture2D[] m_ShadowMasks;

	[Token(Token = "0x401ABDF")]
	[FieldOffset(Offset = "0x18")]
	public LightInfo[] m_LightInfo;

	[Token(Token = "0x6019D24")]
	[Address(RVA = "0x2310B04", Offset = "0x2310B04", VA = "0x2310B04")]
	public CutSceneLightmapStorage()
	{
	}

	[Token(Token = "0x6019D25")]
	[Address(RVA = "0x2310B0C", Offset = "0x2310B0C", VA = "0x2310B0C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6019D26")]
	[Address(RVA = "0x2310B10", Offset = "0x2310B10", VA = "0x2310B10")]
	private void Init()
	{
	}

	[Token(Token = "0x6019D27")]
	[Address(RVA = "0x23110A4", Offset = "0x23110A4", VA = "0x23110A4")]
	private void ApplyRendererInfo(RendererInfo[] infos, int[] lightmapOffsetIndex, LightInfo[] lightsInfo)
	{
	}

	[Token(Token = "0x6019D28")]
	[Address(RVA = "0x23111F0", Offset = "0x23111F0", VA = "0x23111F0")]
	private void SetAllLightBaked(LightInfo[] lightsInfo)
	{
	}
}
