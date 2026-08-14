using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003F96")]
public class NetworkMaterialInfo
{
	[Token(Token = "0x401ACA9")]
	[FieldOffset(Offset = "0x8")]
	public Vector2 TextureSize;

	[Token(Token = "0x401ACAA")]
	[FieldOffset(Offset = "0x10")]
	public Material TargetMaterial;

	[Token(Token = "0x6019DFC")]
	[Address(RVA = "0x2979730", Offset = "0x2979730", VA = "0x2979730")]
	public NetworkMaterialInfo(Material mat, Vector2 size)
	{
	}

	[Token(Token = "0x6019DFD")]
	[Address(RVA = "0x2979760", Offset = "0x2979760", VA = "0x2979760", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6019DFE")]
	[Address(RVA = "0x2979768", Offset = "0x2979768", VA = "0x2979768", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
