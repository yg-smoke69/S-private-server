using Il2CppDummyDll;
using UnityEngine;

namespace COW.Graphics;

[Token(Token = "0x2003F87")]
public class MaterialOverride : MonoBehaviour
{
	[Token(Token = "0x2003F88")]
	public enum HNJKOBAGPDA
	{
		[Token(Token = "0x401AC68")]
		Type_Snow,
		[Token(Token = "0x401AC69")]
		Type_None
	}

	[Token(Token = "0x401AC63")]
	[FieldOffset(Offset = "0xC")]
	public HNJKOBAGPDA type;

	[Token(Token = "0x401AC64")]
	[FieldOffset(Offset = "0x10")]
	public string materialPath;

	[Token(Token = "0x401AC65")]
	[FieldOffset(Offset = "0x14")]
	public string materialOverridePath;

	[Token(Token = "0x401AC66")]
	[FieldOffset(Offset = "0x18")]
	private MeshRenderer BJPGHGGNNLO;

	[Token(Token = "0x6019DB9")]
	[Address(RVA = "0x25C3E90", Offset = "0x25C3E90", VA = "0x25C3E90")]
	public MaterialOverride()
	{
	}

	[Token(Token = "0x6019DBA")]
	[Address(RVA = "0x25C3E98", Offset = "0x25C3E98", VA = "0x25C3E98")]
	private void Start()
	{
	}

	[Token(Token = "0x6019DBB")]
	[Address(RVA = "0x25C3EC0", Offset = "0x25C3EC0", VA = "0x25C3EC0")]
	public Material ApplyOverrideMaterial()
	{
		return null;
	}

	[Token(Token = "0x6019DBC")]
	[Address(RVA = "0x25C3FB8", Offset = "0x25C3FB8", VA = "0x25C3FB8")]
	private Material NEICIGGNOFG(string CCKANBLDEOD)
	{
		return null;
	}
}
