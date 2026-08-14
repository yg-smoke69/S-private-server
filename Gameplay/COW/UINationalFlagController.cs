using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20029D8")]
public class UINationalFlagController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x4010155")]
	[FieldOffset(Offset = "0x48")]
	private UINationalFlagView m_View;

	[Token(Token = "0x6010D59")]
	[Address(RVA = "0x1B2F99C", Offset = "0x1B2F99C", VA = "0x1B2F99C")]
	public UINationalFlagController()
	{
	}

	[Token(Token = "0x6010D5A")]
	[Address(RVA = "0x1B2F9A4", Offset = "0x1B2F9A4", VA = "0x1B2F9A4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010D5B")]
	[Address(RVA = "0x1B2FA4C", Offset = "0x1B2FA4C", VA = "0x1B2FA4C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010D5C")]
	[Address(RVA = "0x1B2FD4C", Offset = "0x1B2FD4C", VA = "0x1B2FD4C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010D5D")]
	[Address(RVA = "0x1B2FE80", Offset = "0x1B2FE80", VA = "0x1B2FE80")]
	public void SetColliderMaskAlpha()
	{
	}

	[Token(Token = "0x6010D5E")]
	[Address(RVA = "0x1B2FF00", Offset = "0x1B2FF00", VA = "0x1B2FF00", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6010D5F")]
	[Address(RVA = "0x1B2FFF8", Offset = "0x1B2FFF8", VA = "0x1B2FFF8", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6010D60")]
	[Address(RVA = "0x1B30074", Offset = "0x1B30074", VA = "0x1B30074")]
	public void FlagSelectHandler(object[] args)
	{
	}

	[Token(Token = "0x6010D61")]
	[Address(RVA = "0x1B300E0", Offset = "0x1B300E0", VA = "0x1B300E0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010D62")]
	[Address(RVA = "0x1B300E8", Offset = "0x1B300E8", VA = "0x1B300E8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
