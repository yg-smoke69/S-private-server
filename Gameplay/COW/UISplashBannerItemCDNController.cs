using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002B56")]
internal class UISplashBannerItemCDNController : UIPreviewPopUpWindowController, _Attribute
{
	[Token(Token = "0x40109A0")]
	[FieldOffset(Offset = "0x5C")]
	private UISplashBannerItemCDNView m_View;

	[Token(Token = "0x40109A1")]
	[FieldOffset(Offset = "0x60")]
	private SplashBannerInfo m_SplashBannerInfo;

	[Token(Token = "0x40109A2")]
	[FieldOffset(Offset = "0x64")]
	public Action<bool> m_UICloseCallBack;

	[Token(Token = "0x40109A3")]
	[FieldOffset(Offset = "0x68")]
	public ulong m_StartShowTime;

	[Token(Token = "0x40109A4")]
	private const float m_RotateRate = 0.5f;

	[Token(Token = "0x6011D97")]
	[Address(RVA = "0x205ABF0", Offset = "0x205ABF0", VA = "0x205ABF0")]
	public UISplashBannerItemCDNController()
	{
	}

	[Token(Token = "0x6011D98")]
	[Address(RVA = "0x205ABF8", Offset = "0x205ABF8", VA = "0x205ABF8", Slot = "68")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011D99")]
	[Address(RVA = "0x205AC8C", Offset = "0x205AC8C", VA = "0x205AC8C", Slot = "67")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011D9A")]
	[Address(RVA = "0x205BB9C", Offset = "0x205BB9C", VA = "0x205BB9C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011D9B")]
	[Address(RVA = "0x205BC40", Offset = "0x205BC40", VA = "0x205BC40", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011D9C")]
	[Address(RVA = "0x205C034", Offset = "0x205C034", VA = "0x205C034")]
	protected void Ondraging(GameObject go, Vector2 delta)
	{
	}

	[Token(Token = "0x6011D9D")]
	[Address(RVA = "0x205C334", Offset = "0x205C334", VA = "0x205C334")]
	public void SetData(SplashBannerInfo info)
	{
	}

	[Token(Token = "0x6011D9E")]
	[Address(RVA = "0x205AD60", Offset = "0x205AD60", VA = "0x205AD60")]
	public void CreateWeaponInfo(SplashBannerInfo info, bool refresh = false)
	{
	}

	[Token(Token = "0x6011D9F")]
	[Address(RVA = "0x205C4D4", Offset = "0x205C4D4", VA = "0x205C4D4", Slot = "44")]
	public override void OnNavigationBack()
	{
	}

	[Token(Token = "0x6011DA0")]
	[Address(RVA = "0x205C548", Offset = "0x205C548", VA = "0x205C548", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6011DA1")]
	[Address(RVA = "0x205C5AC", Offset = "0x205C5AC", VA = "0x205C5AC", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6011DA2")]
	[Address(RVA = "0x205C76C", Offset = "0x205C76C", VA = "0x205C76C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011DA3")]
	[Address(RVA = "0x205C89C", Offset = "0x205C89C", VA = "0x205C89C", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x6011DA4")]
	[Address(RVA = "0x205C8F4", Offset = "0x205C8F4", VA = "0x205C8F4")]
	private void OnGotoNavigation()
	{
	}

	[Token(Token = "0x6011DA5")]
	[Address(RVA = "0x205CAB4", Offset = "0x205CAB4", VA = "0x205CAB4", Slot = "46")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x6011DA6")]
	[Address(RVA = "0x205CB0C", Offset = "0x205CB0C", VA = "0x205CB0C", Slot = "47")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x6011DA7")]
	[Address(RVA = "0x205CBE0", Offset = "0x205CBE0", VA = "0x205CBE0")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011DA8")]
	[Address(RVA = "0x205CBE8", Offset = "0x205CBE8", VA = "0x205CBE8")]
	public new void _003C_003EiFixBaseProxy_OnNavigationBack()
	{
	}

	[Token(Token = "0x6011DA9")]
	[Address(RVA = "0x205CBF0", Offset = "0x205CBF0", VA = "0x205CBF0")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6011DAA")]
	[Address(RVA = "0x205CBF8", Offset = "0x205CBF8", VA = "0x205CBF8")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6011DAB")]
	[Address(RVA = "0x205CC00", Offset = "0x205CC00", VA = "0x205CC00")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6011DAC")]
	[Address(RVA = "0x205CC08", Offset = "0x205CC08", VA = "0x205CC08")]
	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return default(bool);
	}
}
