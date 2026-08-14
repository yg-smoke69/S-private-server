using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002220")]
internal class UIHudTutorialCSMatchResultController : UIHudCSMatchResultController
{
	[Token(Token = "0x600B8CD")]
	[Address(RVA = "0x158E6C4", Offset = "0x158E6C4", VA = "0x158E6C4")]
	public UIHudTutorialCSMatchResultController()
	{
	}

	[Token(Token = "0x600B8CE")]
	[Address(RVA = "0x158E6CC", Offset = "0x158E6CC", VA = "0x158E6CC")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B8CF")]
	[Address(RVA = "0x158E774", Offset = "0x158E774", VA = "0x158E774", Slot = "52")]
	protected override List<PlayerData> CreateShowAvatarPlayerData()
	{
		return null;
	}

	[Token(Token = "0x600B8D0")]
	[Address(RVA = "0x158EC08", Offset = "0x158EC08", VA = "0x158EC08")]
	public List<PlayerData> _003C_003EiFixBaseProxy_CreateShowAvatarPlayerData()
	{
		return null;
	}
}
