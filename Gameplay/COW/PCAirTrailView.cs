using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D32")]
internal class PCAirTrailView : MonoBehaviour
{
	[Token(Token = "0x4011448")]
	[FieldOffset(Offset = "0xC")]
	public GameObject Particle1PGo;

	[Token(Token = "0x4011449")]
	[FieldOffset(Offset = "0x10")]
	public GameObject Particle3PGo;

	[Token(Token = "0x401144A")]
	[FieldOffset(Offset = "0x14")]
	private Player player;

	[Token(Token = "0x6012E87")]
	[Address(RVA = "0x28C9574", Offset = "0x28C9574", VA = "0x28C9574")]
	public PCAirTrailView()
	{
	}

	[Token(Token = "0x6012E88")]
	[Address(RVA = "0x28C957C", Offset = "0x28C957C", VA = "0x28C957C")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6012E89")]
	[Address(RVA = "0x28C96B0", Offset = "0x28C96B0", VA = "0x28C96B0")]
	public void Set1PEffect()
	{
	}

	[Token(Token = "0x6012E8A")]
	[Address(RVA = "0x28C9750", Offset = "0x28C9750", VA = "0x28C9750")]
	public void Set3PEffect()
	{
	}
}
