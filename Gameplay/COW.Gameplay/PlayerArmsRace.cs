using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Gameplay;

[Token(Token = "0x2000992")]
internal class PlayerArmsRace : PlayerNetwork
{
	[Token(Token = "0x40058C6")]
	[FieldOffset(Offset = "0x9C8")]
	private UIModelMatch m_UIModelMatch;

	[Token(Token = "0x40058C7")]
	[FieldOffset(Offset = "0x9CC")]
	private GameObject m_LeaderIcon;

	[Token(Token = "0x60048EF")]
	[Address(RVA = "0x24AB764", Offset = "0x24AB764", VA = "0x24AB764")]
	public PlayerArmsRace()
	{
	}

	[Token(Token = "0x60048F0")]
	[Address(RVA = "0x24AB76C", Offset = "0x24AB76C", VA = "0x24AB76C", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x60048F1")]
	[Address(RVA = "0x24ABB4C", Offset = "0x24ABB4C", VA = "0x24ABB4C")]
	private void OnPlayerLevelAndPointsChange(ushort oldValue, ushort newValue)
	{
	}

	[Token(Token = "0x60048F2")]
	[Address(RVA = "0x24AC410", Offset = "0x24AC410", VA = "0x24AC410")]
	private void OnPlayerRankChange(byte oldValue, byte newValue)
	{
	}

	[Token(Token = "0x60048F3")]
	[Address(RVA = "0x24AC55C", Offset = "0x24AC55C", VA = "0x24AC55C")]
	private void OnPlayerIsLeaderChange(bool oldValue, bool newValue)
	{
	}

	[Token(Token = "0x60048F4")]
	[Address(RVA = "0x24AC910", Offset = "0x24AC910", VA = "0x24AC910")]
	private void OnOpponentLevelChange(byte oldLevel, byte newLevel)
	{
	}

	[Token(Token = "0x60048F5")]
	[Address(RVA = "0x24AC0E8", Offset = "0x24AC0E8", VA = "0x24AC0E8")]
	private void UpdateMatchModeLocalPlayerArmsLevel(int level)
	{
	}

	[Token(Token = "0x60048F6")]
	[Address(RVA = "0x24ACA80", Offset = "0x24ACA80", VA = "0x24ACA80")]
	private void UpdateMatchModeOpponentArmsLevel(int level)
	{
	}
}
