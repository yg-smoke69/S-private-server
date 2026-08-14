using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002951")]
public class UILoginMoreChannelController : UIPopupWindowController
{
	[Token(Token = "0x400FEB0")]
	[FieldOffset(Offset = "0x48")]
	private UILoginMoreChannelView m_View;

	[Token(Token = "0x400FEB1")]
	[FieldOffset(Offset = "0x4C")]
	public Action ActionVKClick;

	[Token(Token = "0x400FEB2")]
	[FieldOffset(Offset = "0x50")]
	public Action ActionGoogleClick;

	[Token(Token = "0x400FEB3")]
	[FieldOffset(Offset = "0x54")]
	public Action ActionFacebookClick;

	[Token(Token = "0x400FEB4")]
	[FieldOffset(Offset = "0x58")]
	public Action ActionTwitterClick;

	[Token(Token = "0x400FEB5")]
	[FieldOffset(Offset = "0x5C")]
	public Action ActionGarenaClick;

	[Token(Token = "0x6010862")]
	[Address(RVA = "0x21F3D88", Offset = "0x21F3D88", VA = "0x21F3D88")]
	public UILoginMoreChannelController()
	{
	}

	[Token(Token = "0x6010863")]
	[Address(RVA = "0x21F3D90", Offset = "0x21F3D90", VA = "0x21F3D90")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010864")]
	[Address(RVA = "0x21F3E34", Offset = "0x21F3E34", VA = "0x21F3E34", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010865")]
	[Address(RVA = "0x21F42F0", Offset = "0x21F42F0", VA = "0x21F42F0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010866")]
	[Address(RVA = "0x21EEDA0", Offset = "0x21EEDA0", VA = "0x21EEDA0")]
	public void Init(bool hasShowVK, bool hasShowFacebook, bool hasShowGoogle, bool hasShowTwitter, bool hasShowGarena)
	{
	}

	[Token(Token = "0x6010867")]
	[Address(RVA = "0x21F44AC", Offset = "0x21F44AC", VA = "0x21F44AC")]
	private void OnVKClick()
	{
	}

	[Token(Token = "0x6010868")]
	[Address(RVA = "0x21F4524", Offset = "0x21F4524", VA = "0x21F4524")]
	private void OnGoogleClick()
	{
	}

	[Token(Token = "0x6010869")]
	[Address(RVA = "0x21F459C", Offset = "0x21F459C", VA = "0x21F459C")]
	private void OnFacebookClick()
	{
	}

	[Token(Token = "0x601086A")]
	[Address(RVA = "0x21F4614", Offset = "0x21F4614", VA = "0x21F4614")]
	private void OnTwitterClick()
	{
	}

	[Token(Token = "0x601086B")]
	[Address(RVA = "0x21F468C", Offset = "0x21F468C", VA = "0x21F468C")]
	private void OnGarenaClick()
	{
	}

	[Token(Token = "0x601086C")]
	[Address(RVA = "0x21F4704", Offset = "0x21F4704", VA = "0x21F4704")]
	private void OnGarenaTipsClick()
	{
	}

	[Token(Token = "0x601086D")]
	[Address(RVA = "0x21F494C", Offset = "0x21F494C", VA = "0x21F494C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601086E")]
	[Address(RVA = "0x21F4954", Offset = "0x21F4954", VA = "0x21F4954")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
