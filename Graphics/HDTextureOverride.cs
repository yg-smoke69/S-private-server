using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003F60")]
public class HDTextureOverride : MonoBehaviour
{
	[Token(Token = "0x401ABC0")]
	[FieldOffset(Offset = "0xC")]
	public string[] textureNames;

	[Token(Token = "0x401ABC1")]
	[FieldOffset(Offset = "0x10")]
	public string[] texturePaths;

	[Token(Token = "0x401ABC2")]
	[FieldOffset(Offset = "0x14")]
	private Texture2D[] originalTextures;

	[Token(Token = "0x401ABC3")]
	[FieldOffset(Offset = "0x18")]
	private MeshRenderer renderer;

	[Token(Token = "0x6019D04")]
	[Address(RVA = "0x350CB74", Offset = "0x350CB74", VA = "0x350CB74")]
	public HDTextureOverride()
	{
	}

	[Token(Token = "0x6019D05")]
	[Address(RVA = "0x350CB7C", Offset = "0x350CB7C", VA = "0x350CB7C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6019D06")]
	[Address(RVA = "0x350CBE4", Offset = "0x350CBE4", VA = "0x350CBE4")]
	public void SetOverrideTextures()
	{
	}

	[Token(Token = "0x6019D07")]
	[Address(RVA = "0x350D060", Offset = "0x350D060", VA = "0x350D060")]
	public void ResetTextures()
	{
	}
}
