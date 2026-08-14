using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000701")]
public class PartyNPCSpawnPoint : MonoBehaviour
{
	[Token(Token = "0x4004BD4")]
	[FieldOffset(Offset = "0xC")]
	public uint NPC_PosID;

	[Token(Token = "0x6002CB4")]
	[Address(RVA = "0xBC6E5C", Offset = "0xBC6E5C", VA = "0xBC6E5C")]
	public PartyNPCSpawnPoint()
	{
	}
}
