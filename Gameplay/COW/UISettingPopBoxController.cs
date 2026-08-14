using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200238F")]
public class UISettingPopBoxController : UIPopupWindowController
{
	[Token(Token = "0x400DD73")]
	[FieldOffset(Offset = "0x48")]
	private UISettingPopBoxView m_View;

	[Token(Token = "0x400DD74")]
	[FieldOffset(Offset = "0x4C")]
	public Action m_OKCallBack;

	[Token(Token = "0x400DD75")]
	[FieldOffset(Offset = "0x50")]
	public Action m_CancelCallBack;

	[Token(Token = "0x600C7A9")]
	[Address(RVA = "0x1A5B30C", Offset = "0x1A5B30C", VA = "0x1A5B30C")]
	public UISettingPopBoxController()
	{
	}

	[Token(Token = "0x600C7AA")]
	[Address(RVA = "0x1A5B314", Offset = "0x1A5B314", VA = "0x1A5B314")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C7AB")]
	[Address(RVA = "0x1A5B3BC", Offset = "0x1A5B3BC", VA = "0x1A5B3BC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C7AC")]
	[Address(RVA = "0x1A5B5E4", Offset = "0x1A5B5E4", VA = "0x1A5B5E4")]
	public void ShowInfo(string loc_key)
	{
	}

	[Token(Token = "0x600C7AD")]
	[Address(RVA = "0x1A5B798", Offset = "0x1A5B798", VA = "0x1A5B798")]
	private void OnBtnOkClick()
	{
	}

	[Token(Token = "0x600C7AE")]
	[Address(RVA = "0x1A5B810", Offset = "0x1A5B810", VA = "0x1A5B810")]
	private void OnBtnCancelClick()
	{
	}

	[Token(Token = "0x600C7AF")]
	[Address(RVA = "0x1A5B888", Offset = "0x1A5B888", VA = "0x1A5B888")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
