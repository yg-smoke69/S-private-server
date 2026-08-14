using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D25")]
public class StreamerTextureInfo : StreamerObjectRefInfo
{
	[Token(Token = "0x4019EFA")]
	[FieldOffset(Offset = "0xC")]
	public uint TextureIndex;

	[Token(Token = "0x4019EFB")]
	[FieldOffset(Offset = "0x10")]
	public Texture OwnedTexture;

	[Token(Token = "0x601877E")]
	[Address(RVA = "0x21C5230", Offset = "0x21C5230", VA = "0x21C5230")]
	public StreamerTextureInfo()
	{
	}

	[Token(Token = "0x601877F")]
	[Address(RVA = "0x21DB670", Offset = "0x21DB670", VA = "0x21DB670", Slot = "4")]
	public override void UnLoadAsset(SceneStreamerInfoHelper helper)
	{
	}
}
