using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002584")]
public class UICommonPopMenuItemController : UIBaseController
{
	[Token(Token = "0x400E81B")]
	[FieldOffset(Offset = "0x28")]
	private UICommonPopMenuItemView m_View;

	[Token(Token = "0x400E81C")]
	[FieldOffset(Offset = "0x2C")]
	private CommonPopMenuData m_Data;

	[Token(Token = "0x400E81D")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 m_localPostition;

	[Token(Token = "0x600DB56")]
	[Address(RVA = "0x2CE449C", Offset = "0x2CE449C", VA = "0x2CE449C")]
	public UICommonPopMenuItemController()
	{
	}

	[Token(Token = "0x600DB57")]
	[Address(RVA = "0x2CE4520", Offset = "0x2CE4520", VA = "0x2CE4520")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DB58")]
	[Address(RVA = "0x2CE45C4", Offset = "0x2CE45C4", VA = "0x2CE45C4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DB59")]
	[Address(RVA = "0x2CE47B8", Offset = "0x2CE47B8", VA = "0x2CE47B8")]
	public void SetItemData(CommonPopMenuData data, int width, int height)
	{
	}

	[Token(Token = "0x600DB5A")]
	[Address(RVA = "0x2CE4B3C", Offset = "0x2CE4B3C", VA = "0x2CE4B3C")]
	public int getTextPixelWidth()
	{
		return default(int);
	}

	[Token(Token = "0x600DB5B")]
	[Address(RVA = "0x2CE4BDC", Offset = "0x2CE4BDC", VA = "0x2CE4BDC")]
	public void setContainerWidth(int width)
	{
	}

	[Token(Token = "0x600DB5C")]
	[Address(RVA = "0x2CE4F50", Offset = "0x2CE4F50", VA = "0x2CE4F50")]
	private void OnPopMenuItemClick()
	{
	}

	[Token(Token = "0x600DB5D")]
	[Address(RVA = "0x2CE5104", Offset = "0x2CE5104", VA = "0x2CE5104")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
