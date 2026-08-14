using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x2003CF3")]
internal class UMARenderTexturePool
{
	[Token(Token = "0x4019E24")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<int, List<RenderTexture>> mTexturePool;

	[Token(Token = "0x4019E25")]
	[FieldOffset(Offset = "0xC")]
	private RenderTextureFormat mTextureFormat;

	[Token(Token = "0x601865F")]
	[Address(RVA = "0x35E4340", Offset = "0x35E4340", VA = "0x35E4340")]
	public UMARenderTexturePool(RenderTextureFormat textureFMT)
	{
	}

	[Token(Token = "0x6018660")]
	[Address(RVA = "0x35E43D4", Offset = "0x35E43D4", VA = "0x35E43D4")]
	public void RecylceRenderTexture(RenderTexture rt)
	{
	}

	[Token(Token = "0x6018661")]
	[Address(RVA = "0x35E4638", Offset = "0x35E4638", VA = "0x35E4638")]
	public RenderTexture GetRenderTexture(int width, int height, bool enableMipmap)
	{
		return null;
	}

	[Token(Token = "0x6018662")]
	[Address(RVA = "0x35E4914", Offset = "0x35E4914", VA = "0x35E4914")]
	public void Clean()
	{
	}

	[Token(Token = "0x6018663")]
	[Address(RVA = "0x35E4628", Offset = "0x35E4628", VA = "0x35E4628")]
	private int GetHashKey(int width, int height, bool enableMipmap)
	{
		return default(int);
	}

	[Token(Token = "0x6018664")]
	[Address(RVA = "0x35E4CA0", Offset = "0x35E4CA0", VA = "0x35E4CA0")]
	public static void RelaseSingle(RenderTexture rt)
	{
	}
}
