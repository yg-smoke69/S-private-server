using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x200413E")]
public interface IEasyList
{
	[Token(Token = "0x601AA80")]
	UIEasyListItemController OpenItemController(Transform parent);

	[Token(Token = "0x601AA81")]
	void CloseItemController(UIEasyListItemController itemController);
}
