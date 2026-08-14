using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003F6D")]
public class LightmapStorage : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2003F6E")]
	private struct RendererInfo
	{
		[Token(Token = "0x401ABF0")]
		[FieldOffset(Offset = "0x0")]
		public Renderer renderer;

		[Token(Token = "0x401ABF1")]
		[FieldOffset(Offset = "0x4")]
		public int lightmapIndex;

		[Token(Token = "0x401ABF2")]
		[FieldOffset(Offset = "0x8")]
		public Vector4 lightmapOffsetScale;
	}

	[Token(Token = "0x401ABEE")]
	[FieldOffset(Offset = "0xC")]
	private List<Texture2D> m_Lightmaps;

	[Token(Token = "0x401ABEF")]
	[FieldOffset(Offset = "0x10")]
	private List<RendererInfo> m_RendererInfos;

	[Token(Token = "0x6019D33")]
	[Address(RVA = "0x3116D6C", Offset = "0x3116D6C", VA = "0x3116D6C")]
	public LightmapStorage()
	{
	}

	[Token(Token = "0x6019D34")]
	[Address(RVA = "0x3116E2C", Offset = "0x3116E2C", VA = "0x3116E2C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6019D35")]
	[Address(RVA = "0x311716C", Offset = "0x311716C", VA = "0x311716C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6019D36")]
	[Address(RVA = "0x3117170", Offset = "0x3117170", VA = "0x3117170")]
	public void SaveLightmapInfo()
	{
	}
}
