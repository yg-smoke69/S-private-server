using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000703")]
public class PetRacingTrack : MonoBehaviour
{
	[Token(Token = "0x4004BD6")]
	[FieldOffset(Offset = "0xC")]
	public GameObject StartPoint;

	[Token(Token = "0x4004BD7")]
	[FieldOffset(Offset = "0x10")]
	public GameObject EndPoint;

	[Token(Token = "0x4004BD8")]
	[FieldOffset(Offset = "0x14")]
	public GameObject[] ControlPoints;

	[Token(Token = "0x4004BD9")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] Barriers;

	[Token(Token = "0x6002CB6")]
	[Address(RVA = "0xBCF7D8", Offset = "0xBCF7D8", VA = "0xBCF7D8")]
	public PetRacingTrack()
	{
	}
}
