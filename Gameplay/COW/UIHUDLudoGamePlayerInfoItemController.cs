using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200219B")]
public class UIHUDLudoGamePlayerInfoItemController : UIHudSingleFightMatchResultItemController
{
	[Token(Token = "0x400D296")]
	[FieldOffset(Offset = "0xE0")]
	private bool m_IsLeaderBoard;

	[Token(Token = "0x600B27E")]
	[Address(RVA = "0x167F4E8", Offset = "0x167F4E8", VA = "0x167F4E8")]
	public UIHUDLudoGamePlayerInfoItemController()
	{
	}

	[Token(Token = "0x600B27F")]
	[Address(RVA = "0x167F4F0", Offset = "0x167F4F0", VA = "0x167F4F0")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B280")]
	[Address(RVA = "0x167F598", Offset = "0x167F598", VA = "0x167F598", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B281")]
	[Address(RVA = "0x167F704", Offset = "0x167F704", VA = "0x167F704")]
	public void SetIsInLeaderBoard(bool isLeaderBoard)
	{
	}

	[Token(Token = "0x600B282")]
	[Address(RVA = "0x167FAB0", Offset = "0x167FAB0", VA = "0x167FAB0", Slot = "40")]
	protected override void OnSetPlayerData(TeammateStats data, bool single)
	{
	}

	[Token(Token = "0x600B283")]
	[Address(RVA = "0x167FDDC", Offset = "0x167FDDC", VA = "0x167FDDC", Slot = "49")]
	protected override void UpdatePlayerData(TeammateStats player)
	{
	}

	[Token(Token = "0x600B284")]
	[Address(RVA = "0x16800B4", Offset = "0x16800B4", VA = "0x16800B4")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B285")]
	[Address(RVA = "0x16800BC", Offset = "0x16800BC", VA = "0x16800BC")]
	public new void _003C_003EiFixBaseProxy_OnSetPlayerData(TeammateStats P0, bool P1)
	{
	}

	[Token(Token = "0x600B286")]
	[Address(RVA = "0x16800C4", Offset = "0x16800C4", VA = "0x16800C4")]
	public void _003C_003EiFixBaseProxy_UpdatePlayerData(TeammateStats P0)
	{
	}
}
