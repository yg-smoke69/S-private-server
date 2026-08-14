using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20006FF")]
public class PartyGameTrack : MonoBehaviour
{
	[Token(Token = "0x4004BD1")]
	[FieldOffset(Offset = "0xC")]
	public GameObject[] StartPoints;

	[Token(Token = "0x4004BD2")]
	[FieldOffset(Offset = "0x10")]
	public GameObject[] EndPoints;

	[Token(Token = "0x6002CB1")]
	[Address(RVA = "0xBC6DC8", Offset = "0xBC6DC8", VA = "0xBC6DC8")]
	public PartyGameTrack()
	{
	}
}
