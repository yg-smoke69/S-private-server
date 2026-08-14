using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002609")]
public class UIEquipSetSelectionLobbyController : UIEquipSetSelectionController
{
	[Token(Token = "0x600E0DC")]
	[Address(RVA = "0x19DA13C", Offset = "0x19DA13C", VA = "0x19DA13C")]
	public UIEquipSetSelectionLobbyController()
	{
	}

	[Token(Token = "0x600E0DD")]
	[Address(RVA = "0x19DA150", Offset = "0x19DA150", VA = "0x19DA150")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E0DE")]
	[Address(RVA = "0x19DA1F4", Offset = "0x19DA1F4", VA = "0x19DA1F4", Slot = "48")]
	protected override UIEquipSetItemController OpenChildContainer(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600E0DF")]
	[Address(RVA = "0x19DA2EC", Offset = "0x19DA2EC", VA = "0x19DA2EC")]
	public UIEquipSetItemController _003C_003EiFixBaseProxy_OpenChildContainer(Transform P0)
	{
		return null;
	}
}
