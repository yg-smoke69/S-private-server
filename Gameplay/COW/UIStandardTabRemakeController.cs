using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20023C8")]
public class UIStandardTabRemakeController : UIStandardTabController
{
	[Token(Token = "0x600C9C6")]
	[Address(RVA = "0x20046D8", Offset = "0x20046D8", VA = "0x20046D8")]
	public UIStandardTabRemakeController()
	{
	}

	[Token(Token = "0x600C9C7")]
	[Address(RVA = "0x200497C", Offset = "0x200497C", VA = "0x200497C")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C9C8")]
	[Address(RVA = "0x2004884", Offset = "0x2004884", VA = "0x2004884", Slot = "34")]
	protected override UIStandardTabItemController CreateTabItem(Transform container)
	{
		return null;
	}

	[Token(Token = "0x600C9C9")]
	[Address(RVA = "0x2004A24", Offset = "0x2004A24", VA = "0x2004A24")]
	public UIStandardTabItemController _003C_003EiFixBaseProxy_CreateTabItem(Transform P0)
	{
		return null;
	}
}
