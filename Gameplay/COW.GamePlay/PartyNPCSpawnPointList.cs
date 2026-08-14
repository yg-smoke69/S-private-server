using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000702")]
public class PartyNPCSpawnPointList : MonoBehaviour
{
	[Token(Token = "0x4004BD5")]
	[FieldOffset(Offset = "0xC")]
	public List<PartyNPCSpawnPoint> pointList;

	[Token(Token = "0x6002CB5")]
	[Address(RVA = "0xBC6E64", Offset = "0xBC6E64", VA = "0xBC6E64")]
	public PartyNPCSpawnPointList()
	{
	}
}
