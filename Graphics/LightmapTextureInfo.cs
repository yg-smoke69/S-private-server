using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003F6F")]
public class LightmapTextureInfo : MonoBehaviour
{
	[Token(Token = "0x401ABF3")]
	[FieldOffset(Offset = "0xC")]
	public int lightmapOffset;

	[Token(Token = "0x401ABF4")]
	[FieldOffset(Offset = "0x10")]
	public Texture2D[] lightmaps;

	[Token(Token = "0x401ABF5")]
	[FieldOffset(Offset = "0x14")]
	public Texture2D[] shadowmasks;

	[Token(Token = "0x6019D37")]
	[Address(RVA = "0x31173E0", Offset = "0x31173E0", VA = "0x31173E0")]
	public LightmapTextureInfo()
	{
	}

	[Token(Token = "0x6019D38")]
	[Address(RVA = "0x31173E8", Offset = "0x31173E8", VA = "0x31173E8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6019D39")]
	[Address(RVA = "0x3117524", Offset = "0x3117524", VA = "0x3117524")]
	private void OnDestroy()
	{
	}
}
