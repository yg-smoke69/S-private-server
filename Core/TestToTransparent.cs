using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2004193")]
internal class TestToTransparent : MonoBehaviour
{
	[Token(Token = "0x401B7C8")]
	[FieldOffset(Offset = "0xC")]
	private Renderer renderer;

	[Token(Token = "0x401B7C9")]
	[FieldOffset(Offset = "0x10")]
	private Material[] origMats;

	[Token(Token = "0x401B7CA")]
	[FieldOffset(Offset = "0x14")]
	private Material[] fadeinMats;

	[Token(Token = "0x401B7CB")]
	[FieldOffset(Offset = "0x18")]
	private Material[] fadeoutMats;

	[Token(Token = "0x401B7CC")]
	[FieldOffset(Offset = "0x1C")]
	private bool aniamtionStart;

	[Token(Token = "0x401B7CD")]
	[FieldOffset(Offset = "0x20")]
	private float animationAlpha;

	[Token(Token = "0x401B7CE")]
	[FieldOffset(Offset = "0x24")]
	private bool inTransparent;

	[Token(Token = "0x601AC8E")]
	[Address(RVA = "0x263684C", Offset = "0x263684C", VA = "0x263684C")]
	public TestToTransparent()
	{
	}

	[Token(Token = "0x601AC8F")]
	[Address(RVA = "0x263685C", Offset = "0x263685C", VA = "0x263685C")]
	private void Awake()
	{
	}

	[Token(Token = "0x601AC90")]
	[Address(RVA = "0x2636C78", Offset = "0x2636C78", VA = "0x2636C78")]
	public void ChangeMat()
	{
	}

	[Token(Token = "0x601AC91")]
	[Address(RVA = "0x2636DF0", Offset = "0x2636DF0", VA = "0x2636DF0")]
	public void RestoreMat()
	{
	}

	[Token(Token = "0x601AC92")]
	[Address(RVA = "0x2636F5C", Offset = "0x2636F5C", VA = "0x2636F5C")]
	private void Update()
	{
	}
}
