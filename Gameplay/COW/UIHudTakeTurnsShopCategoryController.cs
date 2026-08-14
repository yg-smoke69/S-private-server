using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20020EC")]
internal class UIHudTakeTurnsShopCategoryController : UIHudCSEquipCategoryController
{
	[Token(Token = "0x600AA90")]
	[Address(RVA = "0x1FFC6B0", Offset = "0x1FFC6B0", VA = "0x1FFC6B0")]
	public UIHudTakeTurnsShopCategoryController()
	{
	}

	[Token(Token = "0x600AA91")]
	[Address(RVA = "0x1FFC6B8", Offset = "0x1FFC6B8", VA = "0x1FFC6B8")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AA92")]
	[Address(RVA = "0x1FFC760", Offset = "0x1FFC760", VA = "0x1FFC760", Slot = "31")]
	protected override UIHudCSEquipItemController CreateItem(Transform container)
	{
		return null;
	}

	[Token(Token = "0x600AA93")]
	[Address(RVA = "0x1FFC858", Offset = "0x1FFC858", VA = "0x1FFC858")]
	public UIHudCSEquipItemController _003C_003EiFixBaseProxy_CreateItem(Transform P0)
	{
		return null;
	}
}
