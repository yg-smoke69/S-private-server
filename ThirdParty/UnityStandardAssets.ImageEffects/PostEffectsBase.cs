using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects;

[Token(Token = "0x2003EAC")]
public class PostEffectsBase : MonoBehaviour
{
	[Token(Token = "0x401A78C")]
	[FieldOffset(Offset = "0xC")]
	protected bool supportHDRTextures;

	[Token(Token = "0x401A78D")]
	[FieldOffset(Offset = "0xD")]
	protected bool supportDX11;

	[Token(Token = "0x401A78E")]
	[FieldOffset(Offset = "0xE")]
	protected bool isSupported;

	[Token(Token = "0x401A78F")]
	[FieldOffset(Offset = "0x10")]
	private List<Material> createdMaterials;

	[Token(Token = "0x60197DD")]
	[Address(RVA = "0x2A67148", Offset = "0x2A67148", VA = "0x2A67148")]
	public PostEffectsBase()
	{
	}

	[Token(Token = "0x60197DE")]
	[Address(RVA = "0x2A671E0", Offset = "0x2A671E0", VA = "0x2A671E0")]
	protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	[Token(Token = "0x60197DF")]
	[Address(RVA = "0x2A67794", Offset = "0x2A67794", VA = "0x2A67794")]
	protected Material CreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	[Token(Token = "0x60197E0")]
	[Address(RVA = "0x2A67A34", Offset = "0x2A67A34", VA = "0x2A67A34")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60197E1")]
	[Address(RVA = "0x2A67A40", Offset = "0x2A67A40", VA = "0x2A67A40")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60197E2")]
	[Address(RVA = "0x2A67A44", Offset = "0x2A67A44", VA = "0x2A67A44")]
	private void RemoveCreatedMaterials()
	{
	}

	[Token(Token = "0x60197E3")]
	[Address(RVA = "0x2A67B64", Offset = "0x2A67B64", VA = "0x2A67B64")]
	protected bool CheckSupport()
	{
		return default(bool);
	}

	[Token(Token = "0x60197E4")]
	[Address(RVA = "0x2A67CB8", Offset = "0x2A67CB8", VA = "0x2A67CB8", Slot = "4")]
	public virtual bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60197E5")]
	[Address(RVA = "0x2A67DB4", Offset = "0x2A67DB4", VA = "0x2A67DB4")]
	protected void Start()
	{
	}

	[Token(Token = "0x60197E6")]
	[Address(RVA = "0x2A67B6C", Offset = "0x2A67B6C", VA = "0x2A67B6C")]
	protected bool CheckSupport(bool needDepth)
	{
		return default(bool);
	}

	[Token(Token = "0x60197E7")]
	[Address(RVA = "0x2A67DC4", Offset = "0x2A67DC4", VA = "0x2A67DC4")]
	protected bool CheckSupport(bool needDepth, bool needHdr)
	{
		return default(bool);
	}

	[Token(Token = "0x60197E8")]
	[Address(RVA = "0x2A67E18", Offset = "0x2A67E18", VA = "0x2A67E18")]
	public bool Dx11Support()
	{
		return default(bool);
	}

	[Token(Token = "0x60197E9")]
	[Address(RVA = "0x2A67E20", Offset = "0x2A67E20", VA = "0x2A67E20")]
	protected void ReportAutoDisable()
	{
	}

	[Token(Token = "0x60197EA")]
	[Address(RVA = "0x2A67F18", Offset = "0x2A67F18", VA = "0x2A67F18")]
	private bool CheckShader(Shader s)
	{
		return default(bool);
	}

	[Token(Token = "0x60197EB")]
	[Address(RVA = "0x2A67770", Offset = "0x2A67770", VA = "0x2A67770")]
	protected void NotSupported()
	{
	}

	[Token(Token = "0x60197EC")]
	[Address(RVA = "0x2A6825C", Offset = "0x2A6825C", VA = "0x2A6825C")]
	protected void DrawBorder(RenderTexture dest, Material material)
	{
	}
}
