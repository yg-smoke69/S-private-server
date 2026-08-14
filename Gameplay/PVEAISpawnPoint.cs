using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using message;

[Token(Token = "0x200070C")]
public class PVEAISpawnPoint : MonoBehaviour
{
	[Token(Token = "0x4004BF2")]
	[FieldOffset(Offset = "0xC")]
	public int Id;

	[Token(Token = "0x4004BF3")]
	[FieldOffset(Offset = "0x10")]
	public LAKANBFBEOK SpawnAIType;

	[Token(Token = "0x4004BF4")]
	[FieldOffset(Offset = "0x14")]
	public int SpecificPathGroupId;

	[Token(Token = "0x4004BF5")]
	[FieldOffset(Offset = "0x18")]
	public int AttackSafeDoorId;

	[Token(Token = "0x4004BF6")]
	[FieldOffset(Offset = "0x1C")]
	public bool isGroundPoint;

	[Token(Token = "0x4004BF7")]
	[FieldOffset(Offset = "0x1D")]
	public bool isBossOnly;

	[Token(Token = "0x4004BF8")]
	[FieldOffset(Offset = "0x20")]
	public List<int> RoundsId;

	[Token(Token = "0x6002CD0")]
	[Address(RVA = "0x1C77318", Offset = "0x1C77318", VA = "0x1C77318")]
	public PVEAISpawnPoint()
	{
	}

	[Token(Token = "0x6002CD1")]
	[Address(RVA = "0x1C773B4", Offset = "0x1C773B4", VA = "0x1C773B4")]
	private void Awake()
	{
	}
}
