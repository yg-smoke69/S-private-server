using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000087")]
internal class ArenaPlayerManager : MonoBehaviour
{
	[Token(Token = "0x40002CC")]
	[FieldOffset(Offset = "0xC")]
	private bool m_Created;

	[Token(Token = "0x40002CD")]
	[FieldOffset(Offset = "0x10")]
	public Transform[] m_SpawnPoints;

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x14CD00C", Offset = "0x14CD00C", VA = "0x14CD00C")]
	public ArenaPlayerManager()
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x14CD014", Offset = "0x14CD014", VA = "0x14CD014")]
	protected void Start()
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x14CD170", Offset = "0x14CD170", VA = "0x14CD170")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x14CD2C4", Offset = "0x14CD2C4", VA = "0x14CD2C4")]
	private void OnUmaDCReady(object[] data)
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x14CD340", Offset = "0x14CD340", VA = "0x14CD340")]
	private void CreatePlayers()
	{
	}
}
