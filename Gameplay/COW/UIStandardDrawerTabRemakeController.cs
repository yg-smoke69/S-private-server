using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20023B8")]
public class UIStandardDrawerTabRemakeController : UIStandardDrawerTabController
{
	[Token(Token = "0x600C906")]
	[Address(RVA = "0x2065D20", Offset = "0x2065D20", VA = "0x2065D20")]
	public UIStandardDrawerTabRemakeController()
	{
	}

	[Token(Token = "0x600C907")]
	[Address(RVA = "0x2065D24", Offset = "0x2065D24", VA = "0x2065D24")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C908")]
	[Address(RVA = "0x2065DCC", Offset = "0x2065DCC", VA = "0x2065DCC", Slot = "31")]
	protected override UIStandardTabItemController CreateTabItem(Transform container)
	{
		return null;
	}

	[Token(Token = "0x600C909")]
	[Address(RVA = "0x2065EC4", Offset = "0x2065EC4", VA = "0x2065EC4")]
	public UIStandardTabItemController _003C_003EiFixBaseProxy_CreateTabItem(Transform P0)
	{
		return null;
	}
}
