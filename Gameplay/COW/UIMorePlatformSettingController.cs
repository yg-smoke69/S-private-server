using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002382")]
public class UIMorePlatformSettingController : UIBaseController
{
	[Token(Token = "0x400DCFB")]
	[FieldOffset(Offset = "0x28")]
	private UIMorePlatformSettingView m_View;

	[Token(Token = "0x400DCFC")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelLogin m_LoginModel;

	[Token(Token = "0x400DCFD")]
	private const int m_BgAdditionalHeight = 30;

	[Token(Token = "0x400DCFE")]
	[FieldOffset(Offset = "0x30")]
	private UIClickMask m_ClickMask;

	[Token(Token = "0x600C6D3")]
	[Address(RVA = "0x194F830", Offset = "0x194F830", VA = "0x194F830")]
	public UIMorePlatformSettingController()
	{
	}

	[Token(Token = "0x600C6D4")]
	[Address(RVA = "0x194F8B4", Offset = "0x194F8B4", VA = "0x194F8B4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C6D5")]
	[Address(RVA = "0x194F95C", Offset = "0x194F95C", VA = "0x194F95C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C6D6")]
	[Address(RVA = "0x19501D8", Offset = "0x19501D8", VA = "0x19501D8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600C6D7")]
	[Address(RVA = "0x1950250", Offset = "0x1950250", VA = "0x1950250")]
	public void SetViewData(MorePlatformPageType pageType, bool showFb, bool showVK, bool showHw, bool showGoogle, bool showApple, bool showTwitter)
	{
	}

	[Token(Token = "0x600C6D8")]
	[Address(RVA = "0x1950B48", Offset = "0x1950B48", VA = "0x1950B48")]
	private void OnFacebookBindClick()
	{
	}

	[Token(Token = "0x600C6D9")]
	[Address(RVA = "0x1950BC4", Offset = "0x1950BC4", VA = "0x1950BC4")]
	private void OnAppleBindClick()
	{
	}

	[Token(Token = "0x600C6DA")]
	[Address(RVA = "0x1950C40", Offset = "0x1950C40", VA = "0x1950C40")]
	private void OnVKontakteBindClick()
	{
	}

	[Token(Token = "0x600C6DB")]
	[Address(RVA = "0x1950CBC", Offset = "0x1950CBC", VA = "0x1950CBC")]
	private void OnTwitterBindClick()
	{
	}

	[Token(Token = "0x600C6DC")]
	[Address(RVA = "0x1950D38", Offset = "0x1950D38", VA = "0x1950D38")]
	private void OnHuaweiBindClick()
	{
	}

	[Token(Token = "0x600C6DD")]
	[Address(RVA = "0x1950E14", Offset = "0x1950E14", VA = "0x1950E14")]
	private void OnGoogleBindClick()
	{
	}

	[Token(Token = "0x600C6DE")]
	[Address(RVA = "0x1950E90", Offset = "0x1950E90", VA = "0x1950E90")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C6DF")]
	[Address(RVA = "0x1950E98", Offset = "0x1950E98", VA = "0x1950E98")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
