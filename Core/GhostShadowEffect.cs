using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A58")]
public class GhostShadowEffect : MonoBehaviour
{
	[Token(Token = "0x4005BBF")]
	[FieldOffset(Offset = "0xC")]
	public float duration;

	[Token(Token = "0x4005BC0")]
	[FieldOffset(Offset = "0x10")]
	public Renderer GhostRenderer;

	[Token(Token = "0x4005BC1")]
	[FieldOffset(Offset = "0x14")]
	public Color ghostColor;

	[Token(Token = "0x6005034")]
	[Address(RVA = "0x35023BC", Offset = "0x35023BC", VA = "0x35023BC")]
	public GhostShadowEffect()
	{
	}

	[Token(Token = "0x6005035")]
	[Address(RVA = "0x35023C4", Offset = "0x35023C4", VA = "0x35023C4")]
	public void ReActive()
	{
	}

	[Token(Token = "0x6005036")]
	[Address(RVA = "0x35023FC", Offset = "0x35023FC", VA = "0x35023FC")]
	public void UpdateEffect(float passTime)
	{
	}
}
