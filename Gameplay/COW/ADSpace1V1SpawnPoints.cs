using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200059D")]
public class ADSpace1V1SpawnPoints : MonoBehaviour
{
	[Token(Token = "0x4004341")]
	[FieldOffset(Offset = "0xC")]
	public PlayerSpawnPoint Team1Point;

	[Token(Token = "0x4004342")]
	[FieldOffset(Offset = "0x10")]
	public PlayerSpawnPoint Team2Point;

	[Token(Token = "0x6002239")]
	[Address(RVA = "0x14B7C00", Offset = "0x14B7C00", VA = "0x14B7C00")]
	public ADSpace1V1SpawnPoints()
	{
	}
}
