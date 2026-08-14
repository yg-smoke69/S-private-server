using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using message;

[Token(Token = "0x2000745")]
internal class WolfTrapManager
{
	[Token(Token = "0x4004CD5")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<int, LevelWolfTrap> m_WolfTrapMap;

	[Token(Token = "0x4004CD6")]
	[FieldOffset(Offset = "0xC")]
	private List<int> m_LocalPlayerInRescureTrapIDs;

	[Token(Token = "0x6002DEA")]
	[Address(RVA = "0x2A6CEE4", Offset = "0x2A6CEE4", VA = "0x2A6CEE4")]
	public WolfTrapManager()
	{
	}

	[Token(Token = "0x6002DEB")]
	[Address(RVA = "0x2A6CFA4", Offset = "0x2A6CFA4", VA = "0x2A6CFA4")]
	public void AddTrap(KDDCLBPDCFB trapInfo)
	{
	}

	[Token(Token = "0x6002DEC")]
	[Address(RVA = "0x2A6D2BC", Offset = "0x2A6D2BC", VA = "0x2A6D2BC")]
	public void RemoveTrap(int trapID)
	{
	}

	[Token(Token = "0x6002DED")]
	[Address(RVA = "0x2A6D73C", Offset = "0x2A6D73C", VA = "0x2A6D73C")]
	public void SyncTrapCatchInfo(PCOGMCMOOFA catchInfo)
	{
	}

	[Token(Token = "0x6002DEE")]
	[Address(RVA = "0x2A6D3BC", Offset = "0x2A6D3BC", VA = "0x2A6D3BC")]
	public LevelWolfTrap GetTrap(int trapID)
	{
		return null;
	}

	[Token(Token = "0x6002DEF")]
	[Address(RVA = "0x2A6D454", Offset = "0x2A6D454", VA = "0x2A6D454")]
	public void LocalPlayerEnterOrExitTrapRescureTrigger(bool isEnter, int trapID)
	{
	}
}
