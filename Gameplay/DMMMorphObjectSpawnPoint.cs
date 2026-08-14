using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000467")]
public class DMMMorphObjectSpawnPoint : MonoBehaviour
{
	[Token(Token = "0x2000468")]
	public enum SpawnPointType
	{
		[Token(Token = "0x4003CDD")]
		Large = 1,
		[Token(Token = "0x4003CDE")]
		Mini
	}

	[Token(Token = "0x4003CDA")]
	[FieldOffset(Offset = "0xC")]
	public SpawnPointType SpwanPointType;

	[Token(Token = "0x4003CDB")]
	[FieldOffset(Offset = "0x10")]
	public uint Weight;

	[Token(Token = "0x6001623")]
	[Address(RVA = "0x23113CC", Offset = "0x23113CC", VA = "0x23113CC")]
	public DMMMorphObjectSpawnPoint()
	{
	}
}
