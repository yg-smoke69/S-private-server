using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x200059E")]
public class AirDropInGameShopSpawnConfig : MonoBehaviour
{
	[Token(Token = "0x4004343")]
	[FieldOffset(Offset = "0xC")]
	public GameObject SpawnPointsObj;

	[Token(Token = "0x4004344")]
	[FieldOffset(Offset = "0x10")]
	public GameObject ColliderTemplate;

	[Token(Token = "0x600223A")]
	[Address(RVA = "0x1135D8C", Offset = "0x1135D8C", VA = "0x1135D8C")]
	public AirDropInGameShopSpawnConfig()
	{
	}

	[Token(Token = "0x600223B")]
	[Address(RVA = "0x1135D94", Offset = "0x1135D94", VA = "0x1135D94")]
	public List<Transform> GetSpawnPoints()
	{
		return null;
	}
}
