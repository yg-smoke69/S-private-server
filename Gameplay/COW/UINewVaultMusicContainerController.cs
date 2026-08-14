using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002A03")]
internal class UINewVaultMusicContainerController : UIBaseController, _Attribute
{
	[Token(Token = "0x40102A1")]
	[FieldOffset(Offset = "0x28")]
	private UINewVaultMusicContainerView m_View;

	[Token(Token = "0x40102A2")]
	[FieldOffset(Offset = "0x2C")]
	private Func<Transform, UIEasyListItemController> m_funcOpenItemController;

	[Token(Token = "0x6010F8D")]
	[Address(RVA = "0x26C8140", Offset = "0x26C8140", VA = "0x26C8140")]
	public UINewVaultMusicContainerController()
	{
	}

	[Token(Token = "0x6010F8E")]
	[Address(RVA = "0x26C81C4", Offset = "0x26C81C4", VA = "0x26C81C4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010F8F")]
	[Address(RVA = "0x26C826C", Offset = "0x26C826C", VA = "0x26C826C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010F90")]
	[Address(RVA = "0x26C839C", Offset = "0x26C839C", VA = "0x26C839C", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6010F91")]
	[Address(RVA = "0x26C8400", Offset = "0x26C8400", VA = "0x26C8400", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6010F92")]
	[Address(RVA = "0x26C8464", Offset = "0x26C8464", VA = "0x26C8464", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6010F93")]
	[Address(RVA = "0x26C84C8", Offset = "0x26C84C8", VA = "0x26C84C8")]
	public void SetViewData(Func<Transform, UIEasyListItemController> func)
	{
	}

	[Token(Token = "0x6010F94")]
	[Address(RVA = "0x26C8528", Offset = "0x26C8528", VA = "0x26C8528")]
	public UIEasyList GetEasyList()
	{
		return null;
	}

	[Token(Token = "0x6010F95")]
	[Address(RVA = "0x26C8598", Offset = "0x26C8598", VA = "0x26C8598", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6010F96")]
	[Address(RVA = "0x26C8664", Offset = "0x26C8664", VA = "0x26C8664", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6010F97")]
	[Address(RVA = "0x26C86E0", Offset = "0x26C86E0", VA = "0x26C86E0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010F98")]
	[Address(RVA = "0x26C86E8", Offset = "0x26C86E8", VA = "0x26C86E8")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x6010F99")]
	[Address(RVA = "0x26C86F0", Offset = "0x26C86F0", VA = "0x26C86F0")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6010F9A")]
	[Address(RVA = "0x26C86F8", Offset = "0x26C86F8", VA = "0x26C86F8")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
