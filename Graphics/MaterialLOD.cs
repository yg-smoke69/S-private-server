using System;
using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003F81")]
public class MaterialLOD : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2003F82")]
	public class TextureLODInfo
	{
		[Token(Token = "0x401AC55")]
		[FieldOffset(Offset = "0x8")]
		public List<Material> m_matList;

		[Token(Token = "0x6019DAE")]
		[Address(RVA = "0x1C6C4B0", Offset = "0x1C6C4B0", VA = "0x1C6C4B0")]
		public TextureLODInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2003F83")]
	public class MaterialLODInfo
	{
		[Token(Token = "0x401AC56")]
		[FieldOffset(Offset = "0x8")]
		public Renderer m_renderer;

		[Token(Token = "0x401AC57")]
		[FieldOffset(Offset = "0xC")]
		public List<int> m_matIDList;

		[Token(Token = "0x401AC58")]
		[FieldOffset(Offset = "0x10")]
		public List<string> m_matNameList;

		[Token(Token = "0x6019DAF")]
		[Address(RVA = "0x1C6C3F0", Offset = "0x1C6C3F0", VA = "0x1C6C3F0")]
		public MaterialLODInfo()
		{
		}
	}

	[Token(Token = "0x401AC52")]
	[FieldOffset(Offset = "0xC")]
	public List<MaterialLODInfo> m_materialLODInfoList;

	[Token(Token = "0x401AC53")]
	[FieldOffset(Offset = "0x10")]
	public List<TextureLODInfo> m_textureLODInfoList;

	[Token(Token = "0x401AC54")]
	[FieldOffset(Offset = "0x14")]
	private GAGILKKDDMJ m_quality;

	[Token(Token = "0x6019DAB")]
	[Address(RVA = "0x1C6AFE8", Offset = "0x1C6AFE8", VA = "0x1C6AFE8")]
	public MaterialLOD()
	{
	}

	[Token(Token = "0x6019DAC")]
	[Address(RVA = "0x1C6B0A8", Offset = "0x1C6B0A8", VA = "0x1C6B0A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6019DAD")]
	[Address(RVA = "0x1C6BBB4", Offset = "0x1C6BBB4", VA = "0x1C6BBB4")]
	private void OnDestroy()
	{
	}
}
