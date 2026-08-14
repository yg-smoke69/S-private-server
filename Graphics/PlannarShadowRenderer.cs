using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

[Token(Token = "0x2003EAA")]
public class PlannarShadowRenderer : MonoBehaviour
{
	[Token(Token = "0x2003EAB")]
	public delegate void OnPLShadowContainerChanged(PlannarShadowRenderer shadowRenderer, bool isAdd);

	[Token(Token = "0x401A788")]
	[FieldOffset(Offset = "0xC")]
	public CommandBuffer commandBuffer;

	[Token(Token = "0x401A789")]
	[FieldOffset(Offset = "0x10")]
	public Camera drawCamera;

	[Token(Token = "0x401A78A")]
	[FieldOffset(Offset = "0x14")]
	public bool inconsistentCamera;

	[Token(Token = "0x401A78B")]
	[FieldOffset(Offset = "0x18")]
	public OnPLShadowContainerChanged onContainerChanged;

	[Token(Token = "0x60197D5")]
	[Address(RVA = "0x1E1D73C", Offset = "0x1E1D73C", VA = "0x1E1D73C")]
	public PlannarShadowRenderer()
	{
	}

	[Token(Token = "0x60197D6")]
	[Address(RVA = "0x1E1D744", Offset = "0x1E1D744", VA = "0x1E1D744")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60197D7")]
	[Address(RVA = "0x1E1D814", Offset = "0x1E1D814", VA = "0x1E1D814")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60197D8")]
	[Address(RVA = "0x1E1D8E4", Offset = "0x1E1D8E4", VA = "0x1E1D8E4")]
	private void OnDestroy()
	{
	}
}
