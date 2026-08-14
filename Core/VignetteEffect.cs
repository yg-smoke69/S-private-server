using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003EBE")]
public class VignetteEffect : MonoBehaviour
{
	[Token(Token = "0x401A7E4")]
	[FieldOffset(Offset = "0xC")]
	public Shader curShader;

	[Token(Token = "0x401A7E5")]
	[FieldOffset(Offset = "0x10")]
	public float VignettePower;

	[Token(Token = "0x401A7E6")]
	[FieldOffset(Offset = "0x14")]
	private Material curMaterial;

	[Token(Token = "0x17001BD8")]
	private Material material
	{
		[Token(Token = "0x601985F")]
		[Address(RVA = "0x2A6A3A8", Offset = "0x2A6A3A8", VA = "0x2A6A3A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601985E")]
	[Address(RVA = "0x2A6A394", Offset = "0x2A6A394", VA = "0x2A6A394")]
	public VignetteEffect()
	{
	}

	[Token(Token = "0x6019860")]
	[Address(RVA = "0x2A6A48C", Offset = "0x2A6A48C", VA = "0x2A6A48C")]
	private void Start()
	{
	}

	[Token(Token = "0x6019861")]
	[Address(RVA = "0x2A6A4BC", Offset = "0x2A6A4BC", VA = "0x2A6A4BC")]
	private void OnRenderImage(RenderTexture sourceTexture, RenderTexture destTexture)
	{
	}

	[Token(Token = "0x6019862")]
	[Address(RVA = "0x2A6A630", Offset = "0x2A6A630", VA = "0x2A6A630")]
	private void OnDisable()
	{
	}
}
