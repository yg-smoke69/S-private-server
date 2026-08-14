using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002A02")]
public class UINewVaultInstallmentContainerController : UIBaseController, _Attribute
{
	[Token(Token = "0x401029F")]
	[FieldOffset(Offset = "0x28")]
	private UINewVaultInstallmentContainerView m_View;

	[Token(Token = "0x40102A0")]
	[FieldOffset(Offset = "0x2C")]
	private Func<Transform, UIEasyListItemController> m_funcOpenItemController;

	[Token(Token = "0x6010F85")]
	[Address(RVA = "0x26C7AA4", Offset = "0x26C7AA4", VA = "0x26C7AA4")]
	public UINewVaultInstallmentContainerController()
	{
	}

	[Token(Token = "0x6010F86")]
	[Address(RVA = "0x26C7B28", Offset = "0x26C7B28", VA = "0x26C7B28")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010F87")]
	[Address(RVA = "0x26C7BD0", Offset = "0x26C7BD0", VA = "0x26C7BD0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010F88")]
	[Address(RVA = "0x26C7D00", Offset = "0x26C7D00", VA = "0x26C7D00")]
	public void SetViewData(Func<Transform, UIEasyListItemController> func)
	{
	}

	[Token(Token = "0x6010F89")]
	[Address(RVA = "0x26C7D60", Offset = "0x26C7D60", VA = "0x26C7D60")]
	public UIEasyList GetEasyList()
	{
		return null;
	}

	[Token(Token = "0x6010F8A")]
	[Address(RVA = "0x26C7DD0", Offset = "0x26C7DD0", VA = "0x26C7DD0", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6010F8B")]
	[Address(RVA = "0x26C7E9C", Offset = "0x26C7E9C", VA = "0x26C7E9C", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6010F8C")]
	[Address(RVA = "0x26C7F18", Offset = "0x26C7F18", VA = "0x26C7F18")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
