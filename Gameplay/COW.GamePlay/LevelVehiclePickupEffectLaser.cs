using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20006DE")]
internal class LevelVehiclePickupEffectLaser : MonoBehaviour
{
	[Token(Token = "0x4004B21")]
	[FieldOffset(Offset = "0xC")]
	public GameObject Laser;

	[Token(Token = "0x4004B22")]
	[FieldOffset(Offset = "0x10")]
	public GameObject Tail;

	[Token(Token = "0x6002BF5")]
	[Address(RVA = "0x2435800", Offset = "0x2435800", VA = "0x2435800")]
	public LevelVehiclePickupEffectLaser()
	{
	}
}
