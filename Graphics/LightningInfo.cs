using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003F70")]
public class LightningInfo : MonoBehaviour
{
	[Token(Token = "0x401ABF6")]
	[FieldOffset(Offset = "0xC")]
	public int lightmapIndex;

	[Token(Token = "0x401ABF7")]
	[FieldOffset(Offset = "0x10")]
	public Vector4 lightmapScaleOffset;

	[Token(Token = "0x6019D3A")]
	[Address(RVA = "0x31178E0", Offset = "0x31178E0", VA = "0x31178E0")]
	public LightningInfo()
	{
	}

	[Token(Token = "0x6019D3B")]
	[Address(RVA = "0x31178F0", Offset = "0x31178F0", VA = "0x31178F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6019D3C")]
	[Address(RVA = "0x3117900", Offset = "0x3117900", VA = "0x3117900")]
	public void SetLightingInfo()
	{
	}
}
