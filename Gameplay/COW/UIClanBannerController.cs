using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200252E")]
public class UIClanBannerController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400E677")]
	[FieldOffset(Offset = "0x48")]
	private UIClanBannerView m_View;

	[Token(Token = "0x600D83F")]
	[Address(RVA = "0x2F22DF4", Offset = "0x2F22DF4", VA = "0x2F22DF4")]
	public UIClanBannerController()
	{
	}

	[Token(Token = "0x600D840")]
	[Address(RVA = "0x2F22DFC", Offset = "0x2F22DFC", VA = "0x2F22DFC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D841")]
	[Address(RVA = "0x2F22EA4", Offset = "0x2F22EA4", VA = "0x2F22EA4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D842")]
	[Address(RVA = "0x2F231D0", Offset = "0x2F231D0", VA = "0x2F231D0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D843")]
	[Address(RVA = "0x2F23304", Offset = "0x2F23304", VA = "0x2F23304")]
	public void SetColliderMaskAlpha()
	{
	}

	[Token(Token = "0x600D844")]
	[Address(RVA = "0x2F23384", Offset = "0x2F23384", VA = "0x2F23384", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600D845")]
	[Address(RVA = "0x2F2347C", Offset = "0x2F2347C", VA = "0x2F2347C", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600D846")]
	[Address(RVA = "0x2F234F8", Offset = "0x2F234F8", VA = "0x2F234F8")]
	public void BannerSelectHandler(object[] args)
	{
	}

	[Token(Token = "0x600D847")]
	[Address(RVA = "0x2F23564", Offset = "0x2F23564", VA = "0x2F23564")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D848")]
	[Address(RVA = "0x2F2356C", Offset = "0x2F2356C", VA = "0x2F2356C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
