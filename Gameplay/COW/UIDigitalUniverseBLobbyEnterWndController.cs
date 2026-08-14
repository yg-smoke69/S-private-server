using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001ED2")]
public class UIDigitalUniverseBLobbyEnterWndController : UIBigEventLobbyEnterWndControler
{
	[Token(Token = "0x60095FC")]
	[Address(RVA = "0x2D85F20", Offset = "0x2D85F20", VA = "0x2D85F20")]
	public UIDigitalUniverseBLobbyEnterWndController()
	{
	}

	[Token(Token = "0x60095FD")]
	[Address(RVA = "0x2D85F28", Offset = "0x2D85F28", VA = "0x2D85F28")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60095FE")]
	[Address(RVA = "0x2D85FD0", Offset = "0x2D85FD0", VA = "0x2D85FD0", Slot = "48")]
	public override UIBigEventLobbyEnterItemControler GetLobbyEnterItem()
	{
		return null;
	}

	[Token(Token = "0x60095FF")]
	[Address(RVA = "0x2D860C4", Offset = "0x2D860C4", VA = "0x2D860C4")]
	public UIBigEventLobbyEnterItemControler _003C_003EiFixBaseProxy_GetLobbyEnterItem()
	{
		return null;
	}
}
