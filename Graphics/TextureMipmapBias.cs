using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003FFF")]
public class TextureMipmapBias : MonoBehaviour
{
	[Token(Token = "0x401AED5")]
	[FieldOffset(Offset = "0xC")]
	public string[] textureNames;

	[Token(Token = "0x401AED6")]
	[FieldOffset(Offset = "0x10")]
	public bool[] textureMipmapBias;

	[Token(Token = "0x401AED7")]
	[FieldOffset(Offset = "0x14")]
	private MeshRenderer renderer;

	[Token(Token = "0x601A123")]
	[Address(RVA = "0x2637208", Offset = "0x2637208", VA = "0x2637208")]
	public TextureMipmapBias()
	{
	}

	[Token(Token = "0x601A124")]
	[Address(RVA = "0x2637210", Offset = "0x2637210", VA = "0x2637210")]
	private void Awake()
	{
	}

	[Token(Token = "0x601A125")]
	[Address(RVA = "0x2637278", Offset = "0x2637278", VA = "0x2637278")]
	public void SetMipmapBias(bool forceUpdate = false)
	{
	}
}
