using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20029FF")]
internal class UINewVaultHeadPicContainerController : UIBaseController, _Attribute
{
	[Token(Token = "0x4010291")]
	[FieldOffset(Offset = "0x28")]
	private UINewVaultHeadPicContainerView m_View;

	[Token(Token = "0x4010292")]
	[FieldOffset(Offset = "0x2C")]
	private Func<Transform, UIEasyListItemController> m_funcOpenItemController;

	[Token(Token = "0x6010F6E")]
	[Address(RVA = "0x26C50A4", Offset = "0x26C50A4", VA = "0x26C50A4")]
	public UINewVaultHeadPicContainerController()
	{
	}

	[Token(Token = "0x6010F6F")]
	[Address(RVA = "0x26C5128", Offset = "0x26C5128", VA = "0x26C5128")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010F70")]
	[Address(RVA = "0x26C51D0", Offset = "0x26C51D0", VA = "0x26C51D0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010F71")]
	[Address(RVA = "0x26C5300", Offset = "0x26C5300", VA = "0x26C5300")]
	public void SetViewData(Func<Transform, UIEasyListItemController> func)
	{
	}

	[Token(Token = "0x6010F72")]
	[Address(RVA = "0x26C5360", Offset = "0x26C5360", VA = "0x26C5360")]
	public UIEasyList GetEasyList()
	{
		return null;
	}

	[Token(Token = "0x6010F73")]
	[Address(RVA = "0x26C53D0", Offset = "0x26C53D0", VA = "0x26C53D0", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6010F74")]
	[Address(RVA = "0x26C549C", Offset = "0x26C549C", VA = "0x26C549C", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6010F75")]
	[Address(RVA = "0x26C5518", Offset = "0x26C5518", VA = "0x26C5518")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
