using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000738")]
public class WeaponBoxSpawnConfig : MonoBehaviour
{
	[Token(Token = "0x4004CAB")]
	[FieldOffset(Offset = "0xC")]
	public GameObject SpawnPointsObj;

	[Token(Token = "0x4004CAC")]
	[FieldOffset(Offset = "0x10")]
	public GameObject ColliderTemplate;

	[Token(Token = "0x6002DA5")]
	[Address(RVA = "0x26F5874", Offset = "0x26F5874", VA = "0x26F5874")]
	public WeaponBoxSpawnConfig()
	{
	}
}
