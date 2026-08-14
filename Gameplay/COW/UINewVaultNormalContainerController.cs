using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002A04")]
public class UINewVaultNormalContainerController : UIBaseController, _Attribute
{
	[Token(Token = "0x40102A3")]
	[FieldOffset(Offset = "0x28")]
	private UINewVaultNormalContainerView m_View;

	[Token(Token = "0x40102A4")]
	[FieldOffset(Offset = "0x2C")]
	private Func<Transform, UIEasyListItemController> m_funcOpenItemController;

	[Token(Token = "0x6010F9B")]
	[Address(RVA = "0x26C8918", Offset = "0x26C8918", VA = "0x26C8918")]
	public UINewVaultNormalContainerController()
	{
	}

	[Token(Token = "0x6010F9C")]
	[Address(RVA = "0x26C899C", Offset = "0x26C899C", VA = "0x26C899C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010F9D")]
	[Address(RVA = "0x26C8A44", Offset = "0x26C8A44", VA = "0x26C8A44", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010F9E")]
	[Address(RVA = "0x26C8B74", Offset = "0x26C8B74", VA = "0x26C8B74")]
	public void SetViewData(Func<Transform, UIEasyListItemController> func)
	{
	}

	[Token(Token = "0x6010F9F")]
	[Address(RVA = "0x26C8BD4", Offset = "0x26C8BD4", VA = "0x26C8BD4")]
	public UIEasyList GetEasyList()
	{
		return null;
	}

	[Token(Token = "0x6010FA0")]
	[Address(RVA = "0x26C8C44", Offset = "0x26C8C44", VA = "0x26C8C44", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6010FA1")]
	[Address(RVA = "0x26C8D10", Offset = "0x26C8D10", VA = "0x26C8D10", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6010FA2")]
	[Address(RVA = "0x26C8D8C", Offset = "0x26C8D8C", VA = "0x26C8D8C")]
	public void ShowAni()
	{
	}

	[Token(Token = "0x6010FA3")]
	[Address(RVA = "0x26C8E64", Offset = "0x26C8E64", VA = "0x26C8E64")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
