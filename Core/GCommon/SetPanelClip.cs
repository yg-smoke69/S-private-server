using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2004118")]
public class SetPanelClip : MonoBehaviour
{
	[Token(Token = "0x401B57B")]
	[FieldOffset(Offset = "0xC")]
	private UIPanel panel;

	[Token(Token = "0x401B57C")]
	[FieldOffset(Offset = "0x10")]
	private Shader originalShader;

	[Token(Token = "0x401B57D")]
	[FieldOffset(Offset = "0x14")]
	private Renderer CachedRenderer;

	[Token(Token = "0x401B57E")]
	[FieldOffset(Offset = "0x18")]
	private bool isParticle;

	[Token(Token = "0x401B57F")]
	[FieldOffset(Offset = "0x0")]
	private static int[] LocalToPanelMatrix;

	[Token(Token = "0x401B580")]
	[FieldOffset(Offset = "0x4")]
	private static int[] ClipRange;

	[Token(Token = "0x401B581")]
	[FieldOffset(Offset = "0x8")]
	private static int[] ClipArgs;

	[Token(Token = "0x601A954")]
	[Address(RVA = "0x3232420", Offset = "0x3232420", VA = "0x3232420")]
	public SetPanelClip()
	{
	}

	[Token(Token = "0x601A955")]
	[Address(RVA = "0x3232428", Offset = "0x3232428", VA = "0x3232428")]
	private void Start()
	{
	}

	[Token(Token = "0x601A956")]
	[Address(RVA = "0x323242C", Offset = "0x323242C", VA = "0x323242C")]
	public void SetClipping()
	{
	}

	[Token(Token = "0x601A957")]
	[Address(RVA = "0x3232E80", Offset = "0x3232E80", VA = "0x3232E80")]
	private void RemoveClipping()
	{
	}

	[Token(Token = "0x601A958")]
	[Address(RVA = "0x3233728", Offset = "0x3233728", VA = "0x3233728")]
	private void OnWillRenderObject()
	{
	}
}
