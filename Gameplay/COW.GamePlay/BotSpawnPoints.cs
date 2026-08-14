using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20005B7")]
public class BotSpawnPoints : MonoBehaviour
{
	[Token(Token = "0x4004393")]
	[FieldOffset(Offset = "0xC")]
	public int SpawnPointStartId;

	[Token(Token = "0x4004394")]
	[FieldOffset(Offset = "0x10")]
	public int IdCounter;

	[Token(Token = "0x60022B6")]
	[Address(RVA = "0x13B69FC", Offset = "0x13B69FC", VA = "0x13B69FC")]
	public BotSpawnPoints()
	{
	}

	[Token(Token = "0x60022B7")]
	[Address(RVA = "0x13B6A0C", Offset = "0x13B6A0C", VA = "0x13B6A0C")]
	public int GetSpawnObjectType()
	{
		return default(int);
	}
}
