using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000690")]
public class LevelRoom : BaseLevelObject
{
	[Token(Token = "0x40048A6")]
	[FieldOffset(Offset = "0x74")]
	public List<LevelRoom> neighborRooms;

	[Token(Token = "0x40048A7")]
	[FieldOffset(Offset = "0x78")]
	public List<PVEAISpawnPoint> AISpawnPointList;

	[Token(Token = "0x40048A8")]
	[FieldOffset(Offset = "0x7C")]
	private BoxCollider AJHCFNCHKLC;

	[Token(Token = "0x6002A23")]
	[Address(RVA = "0x20CD154", Offset = "0x20CD154", VA = "0x20CD154")]
	public LevelRoom()
	{
	}

	[Token(Token = "0x6002A24")]
	[Address(RVA = "0x20CD214", Offset = "0x20CD214", VA = "0x20CD214", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002A25")]
	[Address(RVA = "0x20CD2B8", Offset = "0x20CD2B8", VA = "0x20CD2B8")]
	private void Awake()
	{
	}
}
