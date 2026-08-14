using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20022EB")]
public class UIHUDRushingPetsPlayerInfoItemController : UIHudSingleFightMatchResultItemController
{
	[Token(Token = "0x400D9FC")]
	[FieldOffset(Offset = "0xE0")]
	private bool m_IsLeaderBoard;

	[Token(Token = "0x600C06D")]
	[Address(RVA = "0x220EA08", Offset = "0x220EA08", VA = "0x220EA08")]
	public UIHUDRushingPetsPlayerInfoItemController()
	{
	}

	[Token(Token = "0x600C06E")]
	[Address(RVA = "0x220EA10", Offset = "0x220EA10", VA = "0x220EA10")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C06F")]
	[Address(RVA = "0x220EAB8", Offset = "0x220EAB8", VA = "0x220EAB8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C070")]
	[Address(RVA = "0x220EC24", Offset = "0x220EC24", VA = "0x220EC24")]
	public void SetIsInLeaderBoard(bool isLeaderBoard)
	{
	}

	[Token(Token = "0x600C071")]
	[Address(RVA = "0x220EFD0", Offset = "0x220EFD0", VA = "0x220EFD0", Slot = "40")]
	protected override void OnSetPlayerData(TeammateStats data, bool single)
	{
	}

	[Token(Token = "0x600C072")]
	[Address(RVA = "0x220F1B8", Offset = "0x220F1B8", VA = "0x220F1B8", Slot = "49")]
	protected override void UpdatePlayerData(TeammateStats player)
	{
	}

	[Token(Token = "0x600C073")]
	[Address(RVA = "0x220F33C", Offset = "0x220F33C", VA = "0x220F33C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C074")]
	[Address(RVA = "0x220F344", Offset = "0x220F344", VA = "0x220F344")]
	public new void _003C_003EiFixBaseProxy_OnSetPlayerData(TeammateStats P0, bool P1)
	{
	}

	[Token(Token = "0x600C075")]
	[Address(RVA = "0x220F34C", Offset = "0x220F34C", VA = "0x220F34C")]
	public void _003C_003EiFixBaseProxy_UpdatePlayerData(TeammateStats P0)
	{
	}
}
