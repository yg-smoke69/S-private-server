using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200205E")]
public class CupMatchRewardBoxResultItem : MonoBehaviour
{
	[Token(Token = "0x400CAEB")]
	[FieldOffset(Offset = "0xC")]
	public GameObject Win;

	[Token(Token = "0x400CAEC")]
	[FieldOffset(Offset = "0x10")]
	public GameObject Lose;

	[Token(Token = "0x400CAED")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UnKnow;

	[Token(Token = "0x600A581")]
	[Address(RVA = "0x1C86C3C", Offset = "0x1C86C3C", VA = "0x1C86C3C")]
	public CupMatchRewardBoxResultItem()
	{
	}
}
