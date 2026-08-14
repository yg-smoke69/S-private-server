using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003E90")]
internal class BlackWhiteEffect : MonoBehaviour
{
	[Token(Token = "0x401A6C9")]
	[FieldOffset(Offset = "0xC")]
	private Material m_CurMaterial;

	[Token(Token = "0x401A6CA")]
	[FieldOffset(Offset = "0x10")]
	private Shader m_BWShader;

	[Token(Token = "0x17001BCD")]
	private Shader BWShader
	{
		[Token(Token = "0x6019763")]
		[Address(RVA = "0x307D928", Offset = "0x307D928", VA = "0x307D928")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BCE")]
	private Material CurMaterial
	{
		[Token(Token = "0x6019764")]
		[Address(RVA = "0x307DAB8", Offset = "0x307DAB8", VA = "0x307DAB8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6019762")]
	[Address(RVA = "0x307D920", Offset = "0x307D920", VA = "0x307D920")]
	public BlackWhiteEffect()
	{
	}

	[Token(Token = "0x6019765")]
	[Address(RVA = "0x307DCAC", Offset = "0x307DCAC", VA = "0x307DCAC")]
	private void Start()
	{
	}

	[Token(Token = "0x6019766")]
	[Address(RVA = "0x307DD98", Offset = "0x307DD98", VA = "0x307DD98")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
