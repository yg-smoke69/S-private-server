using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A1E")]
public class PrefabLightmapData : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000A1F")]
	private struct RendererInfo
	{
		[Token(Token = "0x4005AF3")]
		[FieldOffset(Offset = "0x0")]
		public Renderer renderer;

		[Token(Token = "0x4005AF4")]
		[FieldOffset(Offset = "0x4")]
		public int lightmapIndex;

		[Token(Token = "0x4005AF5")]
		[FieldOffset(Offset = "0x8")]
		public Vector4 lightmapOffsetScale;
	}

	[Token(Token = "0x4005AF1")]
	[FieldOffset(Offset = "0xC")]
	private RendererInfo[] m_RendererInfo;

	[Token(Token = "0x4005AF2")]
	[FieldOffset(Offset = "0x10")]
	private Texture2D[] m_Lightmaps;

	[Token(Token = "0x6004F17")]
	[Address(RVA = "0x1E2F20C", Offset = "0x1E2F20C", VA = "0x1E2F20C")]
	public PrefabLightmapData()
	{
	}

	[Token(Token = "0x6004F18")]
	[Address(RVA = "0x1E2F214", Offset = "0x1E2F214", VA = "0x1E2F214")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004F19")]
	[Address(RVA = "0x1E2F474", Offset = "0x1E2F474", VA = "0x1E2F474")]
	private static void ApplyRendererInfo(RendererInfo[] infos, int lightmapOffsetIndex)
	{
	}
}
