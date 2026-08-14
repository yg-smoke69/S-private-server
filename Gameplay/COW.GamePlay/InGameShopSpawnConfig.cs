using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20005D2")]
public class InGameShopSpawnConfig : MonoBehaviour
{
	[Token(Token = "0x4004408")]
	[FieldOffset(Offset = "0xC")]
	public GameObject SpawnPointsObj;

	[Token(Token = "0x4004409")]
	[FieldOffset(Offset = "0x10")]
	public GameObject ColliderTemplate;

	[Token(Token = "0x6002329")]
	[Address(RVA = "0x198BA34", Offset = "0x198BA34", VA = "0x198BA34")]
	public InGameShopSpawnConfig()
	{
	}

	[Token(Token = "0x600232A")]
	[Address(RVA = "0x198BA3C", Offset = "0x198BA3C", VA = "0x198BA3C")]
	public List<Transform> GetSpawnPoints()
	{
		return null;
	}
}
