using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200250F")]
public class UIChatPopMenuController : UIBasePopMenuController<UIChatPopMenuItemContoller>
{
	[Token(Token = "0x400E5FE")]
	[FieldOffset(Offset = "0x84")]
	private UICommonPopMenuView m_View;

	[Token(Token = "0x600D711")]
	[Address(RVA = "0x2072C54", Offset = "0x2072C54", VA = "0x2072C54")]
	public UIChatPopMenuController()
	{
	}

	[Token(Token = "0x600D712")]
	[Address(RVA = "0x2072CB8", Offset = "0x2072CB8", VA = "0x2072CB8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D713")]
	[Address(RVA = "0x2072D5C", Offset = "0x2072D5C", VA = "0x2072D5C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D714")]
	[Address(RVA = "0x2072E9C", Offset = "0x2072E9C", VA = "0x2072E9C")]
	public void UpdateMenuData(List<CommonPopMenuData> list, ulong userid)
	{
	}

	[Token(Token = "0x600D715")]
	[Address(RVA = "0x2072FAC", Offset = "0x2072FAC", VA = "0x2072FAC")]
	public void UpdateMenuData(List<CommonPopMenuData> list, ulong userid, Vector3 WindowPos)
	{
	}

	[Token(Token = "0x600D716")]
	[Address(RVA = "0x207370C", Offset = "0x207370C", VA = "0x207370C")]
	private void UpdateMenuDataWithFixedWidth(List<CommonPopMenuData> list, int width)
	{
	}

	[Token(Token = "0x600D717")]
	[Address(RVA = "0x2073A60", Offset = "0x2073A60", VA = "0x2073A60")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
