using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003F6B")]
public class LightmapTextureInfo2 : MonoBehaviour
{
	[Token(Token = "0x401ABE6")]
	[FieldOffset(Offset = "0xC")]
	public int[] lightmapIndexes;

	[Token(Token = "0x401ABE7")]
	[FieldOffset(Offset = "0x10")]
	public Texture2D[] lightmaps;

	[Token(Token = "0x401ABE8")]
	[FieldOffset(Offset = "0x14")]
	public Texture2D[] shadowmasks;

	[Token(Token = "0x6019D2B")]
	[Address(RVA = "0x3117660", Offset = "0x3117660", VA = "0x3117660")]
	public LightmapTextureInfo2()
	{
	}

	[Token(Token = "0x6019D2C")]
	[Address(RVA = "0x3117668", Offset = "0x3117668", VA = "0x3117668")]
	private void Awake()
	{
	}

	[Token(Token = "0x6019D2D")]
	[Address(RVA = "0x31177A4", Offset = "0x31177A4", VA = "0x31177A4")]
	private void OnDestroy()
	{
	}
}
