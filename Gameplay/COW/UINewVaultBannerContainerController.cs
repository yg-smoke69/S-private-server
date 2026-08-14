using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20029EE")]
internal class UINewVaultBannerContainerController : UIBaseController, _Attribute
{
	[Token(Token = "0x40101E1")]
	[FieldOffset(Offset = "0x28")]
	private UINewVaultBannerContainerView m_View;

	[Token(Token = "0x40101E2")]
	[FieldOffset(Offset = "0x2C")]
	private Func<Transform, UIEasyListItemController> m_funcOpenItemController;

	[Token(Token = "0x6010E45")]
	[Address(RVA = "0x27B3800", Offset = "0x27B3800", VA = "0x27B3800")]
	public UINewVaultBannerContainerController()
	{
	}

	[Token(Token = "0x6010E46")]
	[Address(RVA = "0x27B3884", Offset = "0x27B3884", VA = "0x27B3884")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010E47")]
	[Address(RVA = "0x27B392C", Offset = "0x27B392C", VA = "0x27B392C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010E48")]
	[Address(RVA = "0x27B3A5C", Offset = "0x27B3A5C", VA = "0x27B3A5C")]
	public void SetViewData(Func<Transform, UIEasyListItemController> func)
	{
	}

	[Token(Token = "0x6010E49")]
	[Address(RVA = "0x27B3ABC", Offset = "0x27B3ABC", VA = "0x27B3ABC")]
	public UIEasyList GetEasyList()
	{
		return null;
	}

	[Token(Token = "0x6010E4A")]
	[Address(RVA = "0x27B3B2C", Offset = "0x27B3B2C", VA = "0x27B3B2C", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6010E4B")]
	[Address(RVA = "0x27B3BF8", Offset = "0x27B3BF8", VA = "0x27B3BF8", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6010E4C")]
	[Address(RVA = "0x27B3C74", Offset = "0x27B3C74", VA = "0x27B3C74")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
