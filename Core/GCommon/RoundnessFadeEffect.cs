using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003EB1")]
public class RoundnessFadeEffect : MonoBehaviour
{
	[Token(Token = "0x401A798")]
	[FieldOffset(Offset = "0xC")]
	private Material m_CurMaterial;

	[Token(Token = "0x401A799")]
	[FieldOffset(Offset = "0x10")]
	private Shader m_Shader;

	[Token(Token = "0x401A79A")]
	[FieldOffset(Offset = "0x14")]
	public Color m_Color;

	[Token(Token = "0x401A79B")]
	[FieldOffset(Offset = "0x24")]
	public float m_Radius;

	[Token(Token = "0x401A79C")]
	[FieldOffset(Offset = "0x28")]
	public float m_Speed;

	[Token(Token = "0x60197FC")]
	[Address(RVA = "0x323095C", Offset = "0x323095C", VA = "0x323095C")]
	public RoundnessFadeEffect()
	{
	}

	[Token(Token = "0x60197FD")]
	[Address(RVA = "0x32309B4", Offset = "0x32309B4", VA = "0x32309B4")]
	private void Start()
	{
	}

	[Token(Token = "0x60197FE")]
	[Address(RVA = "0x3230C7C", Offset = "0x3230C7C", VA = "0x3230C7C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
