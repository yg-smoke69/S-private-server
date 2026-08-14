using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

[Token(Token = "0x2003FA4")]
public class RenderNode_Shadow : PlanarShadowNode
{
	[Token(Token = "0x2003FA5")]
	public delegate void RenderNodeActiveChanged(RenderNode_Shadow node, bool active);

	[Token(Token = "0x401ACEE")]
	[FieldOffset(Offset = "0xC")]
	private Renderer m_Renderer;

	[Token(Token = "0x401ACEF")]
	[FieldOffset(Offset = "0x10")]
	public CommandBuffer commandBuffer;

	[Token(Token = "0x401ACF0")]
	[FieldOffset(Offset = "0x14")]
	private ShadowCastingMode shadowCastingMode;

	[Token(Token = "0x401ACF1")]
	[FieldOffset(Offset = "0x18")]
	public RenderNodeActiveChanged OnRenderNodeChanged;

	[Token(Token = "0x401ACF2")]
	[FieldOffset(Offset = "0x1C")]
	public int subMeshCnt;

	[Token(Token = "0x17001C4A")]
	public Renderer Render
	{
		[Token(Token = "0x6019E55")]
		[Address(RVA = "0x316BAD0", Offset = "0x316BAD0", VA = "0x316BAD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6019E56")]
		[Address(RVA = "0x316BAD8", Offset = "0x316BAD8", VA = "0x316BAD8")]
		set
		{
		}
	}

	[Token(Token = "0x6019E54")]
	[Address(RVA = "0x316BAC8", Offset = "0x316BAC8", VA = "0x316BAC8")]
	public RenderNode_Shadow()
	{
	}

	[Token(Token = "0x6019E57")]
	[Address(RVA = "0x316BC44", Offset = "0x316BC44", VA = "0x316BC44", Slot = "6")]
	protected override void OnEnableDisable(bool isActive)
	{
	}

	[Token(Token = "0x6019E58")]
	[Address(RVA = "0x316BAE0", Offset = "0x316BAE0", VA = "0x316BAE0")]
	private void Init()
	{
	}

	[Token(Token = "0x6019E59")]
	[Address(RVA = "0x316C058", Offset = "0x316C058", VA = "0x316C058")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6019E5A")]
	[Address(RVA = "0x316C164", Offset = "0x316C164", VA = "0x316C164", Slot = "7")]
	protected override void OnDestroy()
	{
	}
}
