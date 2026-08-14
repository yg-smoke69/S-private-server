using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002B21")]
public class UIShowAllLuckyBagWndController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x401089B")]
	[FieldOffset(Offset = "0x48")]
	private UIShowAllLuckyBagWndView m_View;

	[Token(Token = "0x401089C")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelClan m_ModelClan;

	[Token(Token = "0x6011BC4")]
	[Address(RVA = "0x20545D8", Offset = "0x20545D8", VA = "0x20545D8")]
	public UIShowAllLuckyBagWndController()
	{
	}

	[Token(Token = "0x6011BC5")]
	[Address(RVA = "0x20545E0", Offset = "0x20545E0", VA = "0x20545E0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011BC6")]
	[Address(RVA = "0x2054688", Offset = "0x2054688", VA = "0x2054688", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011BC7")]
	[Address(RVA = "0x2054800", Offset = "0x2054800", VA = "0x2054800")]
	private void RefreshScrollViewData()
	{
	}

	[Token(Token = "0x6011BC8")]
	[Address(RVA = "0x2054928", Offset = "0x2054928", VA = "0x2054928")]
	private void HighlightCurrent()
	{
	}

	[Token(Token = "0x6011BC9")]
	[Address(RVA = "0x2054B58", Offset = "0x2054B58", VA = "0x2054B58", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6011BCA")]
	[Address(RVA = "0x2054C50", Offset = "0x2054C50", VA = "0x2054C50", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6011BCB")]
	[Address(RVA = "0x2054CCC", Offset = "0x2054CCC", VA = "0x2054CCC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
