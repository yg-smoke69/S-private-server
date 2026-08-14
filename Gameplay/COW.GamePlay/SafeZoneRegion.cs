using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000718")]
public class SafeZoneRegion : MonoBehaviour
{
	[Token(Token = "0x4004C18")]
	[FieldOffset(Offset = "0xC")]
	public int m_Radius;

	[Token(Token = "0x4004C19")]
	[FieldOffset(Offset = "0x10")]
	public bool m_IsNotWantRegion;

	[Token(Token = "0x4004C1A")]
	[FieldOffset(Offset = "0x14")]
	public float m_Theta;

	[Token(Token = "0x6002CF2")]
	[Address(RVA = "0x29B08B8", Offset = "0x29B08B8", VA = "0x29B08B8")]
	public SafeZoneRegion()
	{
	}
}
