using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002494")]
public class UIAccountForbiddenPopWndController : UIPopupWindowController
{
	[Token(Token = "0x400E2C2")]
	[FieldOffset(Offset = "0x48")]
	private UIAccountForbiddenPopWndView m_View;

	[Token(Token = "0x400E2C3")]
	[FieldOffset(Offset = "0x4C")]
	private string m_InfoUrl;

	[Token(Token = "0x400E2C4")]
	[FieldOffset(Offset = "0x50")]
	private UICountDownController m_CountDownCtrl;

	[Token(Token = "0x600D0F4")]
	[Address(RVA = "0x29FDA0C", Offset = "0x29FDA0C", VA = "0x29FDA0C")]
	public UIAccountForbiddenPopWndController()
	{
	}

	[Token(Token = "0x600D0F5")]
	[Address(RVA = "0x29FDAAC", Offset = "0x29FDAAC", VA = "0x29FDAAC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D0F6")]
	[Address(RVA = "0x29FDB54", Offset = "0x29FDB54", VA = "0x29FDB54", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D0F7")]
	[Address(RVA = "0x29FDD9C", Offset = "0x29FDD9C", VA = "0x29FDD9C")]
	private void RefreshCountDownLabel(uint timeStamp)
	{
	}

	[Token(Token = "0x600D0F8")]
	[Address(RVA = "0x29FE0A0", Offset = "0x29FE0A0", VA = "0x29FE0A0")]
	public void SetMessageKey(BlacklistInfoRes blackList)
	{
	}

	[Token(Token = "0x600D0F9")]
	[Address(RVA = "0x29FE410", Offset = "0x29FE410", VA = "0x29FE410")]
	private void OnConfirmBtnClick()
	{
	}

	[Token(Token = "0x600D0FA")]
	[Address(RVA = "0x29FE474", Offset = "0x29FE474", VA = "0x29FE474")]
	private void OnHelpBtnClick()
	{
	}

	[Token(Token = "0x600D0FB")]
	[Address(RVA = "0x29FE5D4", Offset = "0x29FE5D4", VA = "0x29FE5D4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
