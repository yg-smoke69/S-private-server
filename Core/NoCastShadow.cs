using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

[Token(Token = "0x2003F98")]
public class NoCastShadow : MonoBehaviour
{
	[Token(Token = "0x401ACAE")]
	[FieldOffset(Offset = "0xC")]
	public Renderer[] renderers;

	[Token(Token = "0x401ACAF")]
	[FieldOffset(Offset = "0x10")]
	public ShadowCastingMode[] shadowCastingMode;

	[Token(Token = "0x6019E0B")]
	[Address(RVA = "0x1C732C0", Offset = "0x1C732C0", VA = "0x1C732C0")]
	public NoCastShadow()
	{
	}

	[Token(Token = "0x6019E0C")]
	[Address(RVA = "0x1C732C8", Offset = "0x1C732C8", VA = "0x1C732C8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6019E0D")]
	[Address(RVA = "0x1C734D8", Offset = "0x1C734D8", VA = "0x1C734D8")]
	private void OnDisable()
	{
	}
}
