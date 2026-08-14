using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A66")]
public class CSGameZoneAirDrop : MonoBehaviour
{
	[Token(Token = "0x4005C20")]
	[FieldOffset(Offset = "0xC")]
	public List<Transform> SpawnPointList;

	[Token(Token = "0x6005084")]
	[Address(RVA = "0x23081AC", Offset = "0x23081AC", VA = "0x23081AC")]
	public CSGameZoneAirDrop()
	{
	}

	[Token(Token = "0x6005085")]
	[Address(RVA = "0x2308238", Offset = "0x2308238", VA = "0x2308238")]
	public void InitSpawnPoint()
	{
	}

	[Token(Token = "0x6005086")]
	[Address(RVA = "0x2308404", Offset = "0x2308404", VA = "0x2308404")]
	private void OnDrawGizmos()
	{
	}
}
