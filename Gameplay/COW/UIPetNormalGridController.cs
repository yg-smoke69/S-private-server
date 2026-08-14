using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002A5B")]
public class UIPetNormalGridController : UIBaseController, _Attribute
{
	[Token(Token = "0x4010447")]
	private const int ALL_GRID_COLUMN = 3;

	[Token(Token = "0x4010448")]
	[FieldOffset(Offset = "0x28")]
	private UIPetNormalScrollViewView m_View;

	[Token(Token = "0x4010449")]
	[FieldOffset(Offset = "0x2C")]
	private UIShowType m_ShowGridFlag;

	[Token(Token = "0x601137D")]
	[Address(RVA = "0x2C4924C", Offset = "0x2C4924C", VA = "0x2C4924C")]
	public UIPetNormalGridController()
	{
	}

	[Token(Token = "0x601137E")]
	[Address(RVA = "0x2C492D0", Offset = "0x2C492D0", VA = "0x2C492D0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601137F")]
	[Address(RVA = "0x2C49378", Offset = "0x2C49378", VA = "0x2C49378", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011380")]
	[Address(RVA = "0x2C49470", Offset = "0x2C49470", VA = "0x2C49470", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011381")]
	[Address(RVA = "0x2C494D4", Offset = "0x2C494D4", VA = "0x2C494D4")]
	public void ShowActionGridList(List<PetActionData> dataShowList)
	{
	}

	[Token(Token = "0x6011382")]
	[Address(RVA = "0x2C495E8", Offset = "0x2C495E8", VA = "0x2C495E8")]
	public void ShowSkinGridList(List<PetSkinData> dataShowList)
	{
	}

	[Token(Token = "0x6011383")]
	[Address(RVA = "0x2C496FC", Offset = "0x2C496FC", VA = "0x2C496FC", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6011384")]
	public void ShowItemAtIndex<T>(int index) where T : UIEasyListItemController
	{
	}

	[Token(Token = "0x6011385")]
	[Address(RVA = "0x2C49930", Offset = "0x2C49930", VA = "0x2C49930", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6011386")]
	[Address(RVA = "0x2C499AC", Offset = "0x2C499AC", VA = "0x2C499AC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011387")]
	[Address(RVA = "0x2C499B4", Offset = "0x2C499B4", VA = "0x2C499B4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
