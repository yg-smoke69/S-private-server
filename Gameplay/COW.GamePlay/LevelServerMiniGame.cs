using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000692")]
public class LevelServerMiniGame : BaseLevelObject
{
	[Token(Token = "0x40048AD")]
	[FieldOffset(Offset = "0x74")]
	public MALGAHKKNNN gameType;

	[Token(Token = "0x40048AE")]
	[FieldOffset(Offset = "0x78")]
	public float Radius;

	[Token(Token = "0x40048AF")]
	[FieldOffset(Offset = "0x7C")]
	public Transform[] SpawnPoints;

	[Token(Token = "0x6002A26")]
	[Address(RVA = "0x20CD454", Offset = "0x20CD454", VA = "0x20CD454")]
	public LevelServerMiniGame()
	{
	}

	[Token(Token = "0x6002A27")]
	[Address(RVA = "0x20CD45C", Offset = "0x20CD45C", VA = "0x20CD45C", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002A28")]
	[Address(RVA = "0x20CD500", Offset = "0x20CD500", VA = "0x20CD500", Slot = "10")]
	public override void InitEntityInfo()
	{
	}

	[Token(Token = "0x6002A29")]
	[Address(RVA = "0x20CD574", Offset = "0x20CD574", VA = "0x20CD574")]
	public new void _003C_003EiFixBaseProxy_InitEntityInfo()
	{
	}
}
