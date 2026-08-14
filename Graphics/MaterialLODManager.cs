using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003F84")]
public class MaterialLODManager : MonoSingleton<MaterialLODManager>
{
	[Serializable]
	[Token(Token = "0x2003F85")]
	public class TextureLODInfoManager
	{
		[Token(Token = "0x401AC5E")]
		[FieldOffset(Offset = "0x8")]
		public string m_matName;

		[Token(Token = "0x401AC5F")]
		[FieldOffset(Offset = "0xC")]
		public List<string> m_texNameList;

		[Token(Token = "0x401AC60")]
		[FieldOffset(Offset = "0x10")]
		public List<string> m_texPathList;

		[Token(Token = "0x6019DB7")]
		[Address(RVA = "0x1C6CC90", Offset = "0x1C6CC90", VA = "0x1C6CC90")]
		public TextureLODInfoManager()
		{
		}
	}

	[Token(Token = "0x2003F86")]
	public class MaterialLODInfoManager
	{
		[Token(Token = "0x401AC61")]
		[FieldOffset(Offset = "0x8")]
		public Material m_material;

		[Token(Token = "0x401AC62")]
		[FieldOffset(Offset = "0xC")]
		public int m_refCount;

		[Token(Token = "0x6019DB8")]
		[Address(RVA = "0x1C6CC88", Offset = "0x1C6CC88", VA = "0x1C6CC88")]
		public MaterialLODInfoManager()
		{
		}
	}

	[Token(Token = "0x401AC59")]
	[FieldOffset(Offset = "0xC")]
	public List<TextureLODInfoManager> m_TextureLODList;

	[Token(Token = "0x401AC5A")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, TextureLODInfoManager> m_textureLODDict;

	[Token(Token = "0x401AC5B")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<string, int> m_loadedMatDict;

	[Token(Token = "0x401AC5C")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, MaterialLODInfoManager> m_materialLOD;

	[Token(Token = "0x401AC5D")]
	[FieldOffset(Offset = "0x1C")]
	private string m_materialLODResPath;

	[Token(Token = "0x6019DB0")]
	[Address(RVA = "0x1C6C53C", Offset = "0x1C6C53C", VA = "0x1C6C53C")]
	public MaterialLODManager()
	{
	}

	[Token(Token = "0x6019DB1")]
	[Address(RVA = "0x1C6C6B0", Offset = "0x1C6C6B0", VA = "0x1C6C6B0")]
	private void Start()
	{
	}

	[Token(Token = "0x6019DB2")]
	[Address(RVA = "0x1C6B3F4", Offset = "0x1C6B3F4", VA = "0x1C6B3F4")]
	public void ApplyMaterial(Renderer render, List<int> matIDList, List<string> matNameList)
	{
	}

	[Token(Token = "0x6019DB3")]
	[Address(RVA = "0x1C6CA10", Offset = "0x1C6CA10", VA = "0x1C6CA10")]
	private Material CreateMaterial(string matName)
	{
		return null;
	}

	[Token(Token = "0x6019DB4")]
	[Address(RVA = "0x1C6B6D8", Offset = "0x1C6B6D8", VA = "0x1C6B6D8")]
	public void ApplyTexture(List<Material> matList)
	{
	}

	[Token(Token = "0x6019DB5")]
	[Address(RVA = "0x1C6BF6C", Offset = "0x1C6BF6C", VA = "0x1C6BF6C")]
	public void UnloadMaterial(string matName)
	{
	}

	[Token(Token = "0x6019DB6")]
	[Address(RVA = "0x1C6C0FC", Offset = "0x1C6C0FC", VA = "0x1C6C0FC")]
	public void UnloadTexture(List<Material> matList)
	{
	}
}
