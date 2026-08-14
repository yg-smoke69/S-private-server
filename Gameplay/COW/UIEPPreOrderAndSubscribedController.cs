using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20020D6")]
public class UIEPPreOrderAndSubscribedController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400CD86")]
	[FieldOffset(Offset = "0x48")]
	private UIEPPreOrderAndSubscribedView m_View;

	[Token(Token = "0x400CD87")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelElitePass m_Model;

	[Token(Token = "0x400CD88")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<AdvertDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600A9ED")]
	[Address(RVA = "0x2BAD23C", Offset = "0x2BAD23C", VA = "0x2BAD23C")]
	public UIEPPreOrderAndSubscribedController()
	{
	}

	[Token(Token = "0x600A9EE")]
	[Address(RVA = "0x2BAD244", Offset = "0x2BAD244", VA = "0x2BAD244")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A9EF")]
	[Address(RVA = "0x2BAD2E8", Offset = "0x2BAD2E8", VA = "0x2BAD2E8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A9F0")]
	[Address(RVA = "0x2BAD954", Offset = "0x2BAD954", VA = "0x2BAD954", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A9F1")]
	[Address(RVA = "0x2BAD6C4", Offset = "0x2BAD6C4", VA = "0x2BAD6C4")]
	private void InitUI()
	{
	}

	[Token(Token = "0x600A9F2")]
	[Address(RVA = "0x2BAE050", Offset = "0x2BAE050", VA = "0x2BAE050")]
	private void SetCDN(object[] data)
	{
	}

	[Token(Token = "0x600A9F3")]
	[Address(RVA = "0x2BAE310", Offset = "0x2BAE310", VA = "0x2BAE310")]
	private void OnClickSubscribeEPBtn()
	{
	}

	[Token(Token = "0x600A9F4")]
	[Address(RVA = "0x2BAE438", Offset = "0x2BAE438", VA = "0x2BAE438")]
	private void OnClickPreorderBtn()
	{
	}

	[Token(Token = "0x600A9F5")]
	[Address(RVA = "0x2BAE560", Offset = "0x2BAE560", VA = "0x2BAE560")]
	private void OnPreorderSuccess(object[] data)
	{
	}

	[Token(Token = "0x600A9F6")]
	[Address(RVA = "0x2BAE5C8", Offset = "0x2BAE5C8", VA = "0x2BAE5C8")]
	private void UpdateSubscriptionBonus()
	{
	}

	[Token(Token = "0x600A9F7")]
	[Address(RVA = "0x2BADB14", Offset = "0x2BADB14", VA = "0x2BADB14")]
	private void SetBtnState()
	{
	}

	[Token(Token = "0x600A9F8")]
	[Address(RVA = "0x2BAE7DC", Offset = "0x2BAE7DC", VA = "0x2BAE7DC", Slot = "46")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A9F9")]
	[Address(RVA = "0x2BAE8B4", Offset = "0x2BAE8B4", VA = "0x2BAE8B4", Slot = "47")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A9FA")]
	[Address(RVA = "0x2BAE948", Offset = "0x2BAE948", VA = "0x2BAE948")]
	private static bool _003CSetCDN_003Em__0(AdvertDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x600A9FB")]
	[Address(RVA = "0x2BAE978", Offset = "0x2BAE978", VA = "0x2BAE978")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A9FC")]
	[Address(RVA = "0x2BAE980", Offset = "0x2BAE980", VA = "0x2BAE980")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
