using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003F6C")]
public class RuntimePrefabLightmap : MonoBehaviour
{
	[Token(Token = "0x401ABE9")]
	[FieldOffset(Offset = "0xC")]
	public string prefabID;

	[Token(Token = "0x401ABEA")]
	[FieldOffset(Offset = "0x10")]
	public List<Renderer> renderers;

	[Token(Token = "0x401ABEB")]
	[FieldOffset(Offset = "0x14")]
	public List<Texture2D> lightmaps;

	[Token(Token = "0x401ABEC")]
	[FieldOffset(Offset = "0x18")]
	public List<LightmapInfo> lightmapInfo;

	[Token(Token = "0x401ABED")]
	[FieldOffset(Offset = "0x1C")]
	private bool m_loadedLightmap;

	[Token(Token = "0x6019D2E")]
	[Address(RVA = "0x316E6D0", Offset = "0x316E6D0", VA = "0x316E6D0")]
	public RuntimePrefabLightmap()
	{
	}

	[Token(Token = "0x6019D2F")]
	[Address(RVA = "0x316E7C4", Offset = "0x316E7C4", VA = "0x316E7C4")]
	private void Start()
	{
	}

	[Token(Token = "0x6019D30")]
	[Address(RVA = "0x316EB08", Offset = "0x316EB08", VA = "0x316EB08")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6019D31")]
	[Address(RVA = "0x316E7E0", Offset = "0x316E7E0", VA = "0x316E7E0")]
	public void LoadLightmap()
	{
	}

	[Token(Token = "0x6019D32")]
	[Address(RVA = "0x316EC60", Offset = "0x316EC60", VA = "0x316EC60")]
	public void Clear()
	{
	}
}
