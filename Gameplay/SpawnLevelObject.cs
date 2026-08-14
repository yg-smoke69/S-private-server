using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000795")]
public class SpawnLevelObject : MonoBehaviour
{
	[Token(Token = "0x4004EAD")]
	[FieldOffset(Offset = "0xC")]
	public TriggerActionSpawnLevelObjectType LevelObjectType;

	[Token(Token = "0x4004EAE")]
	[FieldOffset(Offset = "0x10")]
	public float ZoneRadius;

	[Token(Token = "0x4004EAF")]
	[FieldOffset(Offset = "0x14")]
	public float Duration;

	[Token(Token = "0x4004EB0")]
	[FieldOffset(Offset = "0x18")]
	public bool SelfCanTrigger;

	[Token(Token = "0x4004EB1")]
	[FieldOffset(Offset = "0x19")]
	public bool TeammatesCanTrigger;

	[Token(Token = "0x4004EB2")]
	[FieldOffset(Offset = "0x1C")]
	public List<int> BuffID;

	[Token(Token = "0x600308D")]
	[Address(RVA = "0x21D76DC", Offset = "0x21D76DC", VA = "0x21D76DC")]
	public SpawnLevelObject()
	{
	}
}
