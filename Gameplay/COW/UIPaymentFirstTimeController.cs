using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002A2A")]
public class UIPaymentFirstTimeController : UIPaymentController.PaymentTabContentController
{
	[Token(Token = "0x401035C")]
	[FieldOffset(Offset = "0x28")]
	private UIPaymentFirstTimeView m_View;

	[Token(Token = "0x401035D")]
	[FieldOffset(Offset = "0x2C")]
	private List<AdvertDesc> _MainAds;

	[Token(Token = "0x60110DD")]
	[Address(RVA = "0x28876E4", Offset = "0x28876E4", VA = "0x28876E4")]
	public UIPaymentFirstTimeController()
	{
	}

	[Token(Token = "0x60110DE")]
	[Address(RVA = "0x28876E8", Offset = "0x28876E8", VA = "0x28876E8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60110DF")]
	[Address(RVA = "0x2887790", Offset = "0x2887790", VA = "0x2887790", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60110E0")]
	[Address(RVA = "0x2887A4C", Offset = "0x2887A4C", VA = "0x2887A4C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60110E1")]
	[Address(RVA = "0x2887AB0", Offset = "0x2887AB0", VA = "0x2887AB0", Slot = "32")]
	public override void RefreshContent()
	{
	}

	[Token(Token = "0x60110E2")]
	[Address(RVA = "0x2888430", Offset = "0x2888430", VA = "0x2888430")]
	private void OnHelpButtonClick()
	{
	}

	[Token(Token = "0x60110E3")]
	[Address(RVA = "0x28886BC", Offset = "0x28886BC", VA = "0x28886BC")]
	private void OnGotoButtonClick()
	{
	}

	[Token(Token = "0x60110E4")]
	[Address(RVA = "0x28887CC", Offset = "0x28887CC", VA = "0x28887CC")]
	private void ApplyCdnUrlKeyToNetworkTexture(UINetworkTextureExt networkTexture, string key)
	{
	}

	[Token(Token = "0x60110E5")]
	[Address(RVA = "0x28882D0", Offset = "0x28882D0", VA = "0x28882D0")]
	private void ApplyCdnUrlToNetworkTexture(UINetworkTextureExt networkTexture, string url)
	{
	}

	[Token(Token = "0x60110E6")]
	[Address(RVA = "0x2888914", Offset = "0x2888914", VA = "0x2888914")]
	private void OnCDNImgClick()
	{
	}

	[Token(Token = "0x60110E7")]
	[Address(RVA = "0x2888ACC", Offset = "0x2888ACC", VA = "0x2888ACC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60110E8")]
	[Address(RVA = "0x2888AD4", Offset = "0x2888AD4", VA = "0x2888AD4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60110E9")]
	[Address(RVA = "0x2888ADC", Offset = "0x2888ADC", VA = "0x2888ADC")]
	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}
}
