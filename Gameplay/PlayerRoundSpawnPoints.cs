using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000707")]
public class PlayerRoundSpawnPoints : MonoBehaviour
{
	[Token(Token = "0x2000708")]
	public enum EPlayerSpawnType
	{
		[Token(Token = "0x4004BEB")]
		SpawnTypePVE,
		[Token(Token = "0x4004BEC")]
		SpawnTypeCS,
		[Token(Token = "0x4004BED")]
		SpawnTypeTDM,
		[Token(Token = "0x4004BEE")]
		SpawnTypeAR,
		[Token(Token = "0x4004BEF")]
		SpawnTypeNone
	}

	[Token(Token = "0x4004BE3")]
	[FieldOffset(Offset = "0xC")]
	public int RoundId;

	[Token(Token = "0x4004BE4")]
	[FieldOffset(Offset = "0x10")]
	public int TeamIndex;

	[Token(Token = "0x4004BE5")]
	[FieldOffset(Offset = "0x14")]
	public BoxCollider SpawnAreaTrigger;

	[Token(Token = "0x4004BE6")]
	[FieldOffset(Offset = "0x18")]
	public BoxCollider ReviveSpawnAreaTrigger;

	[Token(Token = "0x4004BE7")]
	[FieldOffset(Offset = "0x1C")]
	public List<PlayerSpawnPoint> RoundSpawnPoints;

	[Token(Token = "0x4004BE8")]
	[FieldOffset(Offset = "0x20")]
	public List<PlayerSpawnPoint> ReviveSpawnPoints;

	[Token(Token = "0x4004BE9")]
	[FieldOffset(Offset = "0x24")]
	public EPlayerSpawnType PlayerSpawnType;

	[Token(Token = "0x6002CCB")]
	[Address(RVA = "0x1E22FB0", Offset = "0x1E22FB0", VA = "0x1E22FB0")]
	public PlayerRoundSpawnPoints()
	{
	}
}
