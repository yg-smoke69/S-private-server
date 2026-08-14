using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20005B3")]
internal class BombZoneEffect : MonoBehaviour
{
	[Token(Token = "0x400438E")]
	[FieldOffset(Offset = "0xC")]
	public GameObject EffectContainer;

	[Token(Token = "0x400438F")]
	[FieldOffset(Offset = "0x10")]
	public GameObject NormalEffect;

	[Token(Token = "0x4004390")]
	[FieldOffset(Offset = "0x14")]
	public GameObject BombEffect;

	[Token(Token = "0x60022B0")]
	[Address(RVA = "0x180D29C", Offset = "0x180D29C", VA = "0x180D29C")]
	public BombZoneEffect()
	{
	}
}
