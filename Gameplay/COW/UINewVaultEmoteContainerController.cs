using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20029FA")]
internal class UINewVaultEmoteContainerController : UIBaseController, _Attribute
{
	[Token(Token = "0x4010278")]
	[FieldOffset(Offset = "0x28")]
	private UINewVaultEmoteContainerView m_View;

	[Token(Token = "0x4010279")]
	[FieldOffset(Offset = "0x2C")]
	private Func<Transform, UIEasyListItemController> m_funcOpenItemController;

	[Token(Token = "0x6010F38")]
	[Address(RVA = "0x2C1E070", Offset = "0x2C1E070", VA = "0x2C1E070")]
	public UINewVaultEmoteContainerController()
	{
	}

	[Token(Token = "0x6010F39")]
	[Address(RVA = "0x2C1E0F4", Offset = "0x2C1E0F4", VA = "0x2C1E0F4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010F3A")]
	[Address(RVA = "0x2C1E19C", Offset = "0x2C1E19C", VA = "0x2C1E19C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010F3B")]
	[Address(RVA = "0x2C0419C", Offset = "0x2C0419C", VA = "0x2C0419C")]
	public void SetViewData(Func<Transform, UIEasyListItemController> func)
	{
	}

	[Token(Token = "0x6010F3C")]
	[Address(RVA = "0x2C04760", Offset = "0x2C04760", VA = "0x2C04760")]
	public UIEasyList GetEasyList()
	{
		return null;
	}

	[Token(Token = "0x6010F3D")]
	[Address(RVA = "0x2C1E2CC", Offset = "0x2C1E2CC", VA = "0x2C1E2CC", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6010F3E")]
	[Address(RVA = "0x2C1E398", Offset = "0x2C1E398", VA = "0x2C1E398", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6010F3F")]
	[Address(RVA = "0x2C1E414", Offset = "0x2C1E414", VA = "0x2C1E414")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
