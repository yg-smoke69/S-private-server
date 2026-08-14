using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20006FE")]
public class PacketedSpawnPoint : MonoBehaviour
{
	[Token(Token = "0x4004BD0")]
	[FieldOffset(Offset = "0xC")]
	public int PacketID;

	[Token(Token = "0x6002CB0")]
	[Address(RVA = "0xBC441C", Offset = "0xBC441C", VA = "0xBC441C")]
	public PacketedSpawnPoint()
	{
	}
}
