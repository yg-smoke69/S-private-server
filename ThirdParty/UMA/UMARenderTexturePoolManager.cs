using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x2003CF2")]
public class UMARenderTexturePoolManager
{
	[Token(Token = "0x4019E20")]
	[FieldOffset(Offset = "0x0")]
	private static UMARenderTexturePoolManager _instance;

	[Token(Token = "0x4019E21")]
	[FieldOffset(Offset = "0x4")]
	public static int MAX_CACHE;

	[Token(Token = "0x4019E22")]
	[FieldOffset(Offset = "0x8")]
	public static int freeCount;

	[Token(Token = "0x4019E23")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<RenderTextureFormat, UMARenderTexturePool> mPools;

	[Token(Token = "0x170019BD")]
	public static UMARenderTexturePoolManager instance
	{
		[Token(Token = "0x6018659")]
		[Address(RVA = "0x35E4E0C", Offset = "0x35E4E0C", VA = "0x35E4E0C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6018658")]
	[Address(RVA = "0x35E4D80", Offset = "0x35E4D80", VA = "0x35E4D80")]
	private UMARenderTexturePoolManager()
	{
	}

	[Token(Token = "0x601865A")]
	[Address(RVA = "0x35E4F34", Offset = "0x35E4F34", VA = "0x35E4F34")]
	public RenderTexture GetRenderTexture(int width, int height, RenderTextureFormat textFormat, bool enableMipmap)
	{
		return null;
	}

	[Token(Token = "0x601865B")]
	[Address(RVA = "0x35E509C", Offset = "0x35E509C", VA = "0x35E509C")]
	public void RecycleRenderTexture(RenderTexture rt)
	{
	}

	[Token(Token = "0x601865C")]
	[Address(RVA = "0x35E5190", Offset = "0x35E5190", VA = "0x35E5190")]
	public void Clear()
	{
	}

	[Token(Token = "0x601865D")]
	[Address(RVA = "0x35E4F84", Offset = "0x35E4F84", VA = "0x35E4F84")]
	private UMARenderTexturePool GetPool(RenderTextureFormat textFormat)
	{
		return null;
	}
}
