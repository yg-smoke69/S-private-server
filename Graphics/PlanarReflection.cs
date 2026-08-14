using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003EA8")]
public class PlanarReflection : MonoBehaviour
{
	[Token(Token = "0x2003EA9")]
	public enum SizeEnum
	{
		[Token(Token = "0x401A783")]
		Sixteenth = 0x40,
		[Token(Token = "0x401A784")]
		Eighth = 0x80,
		[Token(Token = "0x401A785")]
		Quarter = 0x100,
		[Token(Token = "0x401A786")]
		Half = 0x200,
		[Token(Token = "0x401A787")]
		One = 0x400
	}

	[Token(Token = "0x401A77A")]
	[FieldOffset(Offset = "0xC")]
	public SizeEnum m_sizeType;

	[Token(Token = "0x401A77B")]
	[FieldOffset(Offset = "0x10")]
	public Camera m_mainCamera;

	[Token(Token = "0x401A77C")]
	[FieldOffset(Offset = "0x14")]
	public Camera m_reflectionCamera;

	[Token(Token = "0x401A77D")]
	[FieldOffset(Offset = "0x18")]
	private Material m_reflectionMaterial;

	[Token(Token = "0x401A77E")]
	[FieldOffset(Offset = "0x1C")]
	private RenderTexture m_reflectionRT;

	[Token(Token = "0x401A77F")]
	[FieldOffset(Offset = "0x20")]
	private int m_reflectionRTsize;

	[Token(Token = "0x401A780")]
	[FieldOffset(Offset = "0x24")]
	private int m_reflectionTexID;

	[Token(Token = "0x401A781")]
	[FieldOffset(Offset = "0x28")]
	private Matrix4x4 m_reflectMatrix;

	[Token(Token = "0x60197D0")]
	[Address(RVA = "0x1C7B1B0", Offset = "0x1C7B1B0", VA = "0x1C7B1B0")]
	public PlanarReflection()
	{
	}

	[Token(Token = "0x60197D1")]
	[Address(RVA = "0x1C7B1E8", Offset = "0x1C7B1E8", VA = "0x1C7B1E8")]
	private void Start()
	{
	}

	[Token(Token = "0x60197D2")]
	[Address(RVA = "0x1C7B9C0", Offset = "0x1C7B9C0", VA = "0x1C7B9C0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60197D3")]
	[Address(RVA = "0x1C7B4DC", Offset = "0x1C7B4DC", VA = "0x1C7B4DC")]
	public void UpdateRefCamera()
	{
	}

	[Token(Token = "0x60197D4")]
	[Address(RVA = "0x1C7BB34", Offset = "0x1C7BB34", VA = "0x1C7BB34")]
	private void OnDestroy()
	{
	}
}
