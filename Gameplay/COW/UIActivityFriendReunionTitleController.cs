using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001F63")]
public class UIActivityFriendReunionTitleController : UIBaseController
{
	[Token(Token = "0x400C52C")]
	[FieldOffset(Offset = "0x28")]
	private UIActivityFriendReunionTitleView m_View;

	[Token(Token = "0x400C52D")]
	[FieldOffset(Offset = "0x2C")]
	private string m_Detail;

	[Token(Token = "0x6009B77")]
	[Address(RVA = "0x2FB4D80", Offset = "0x2FB4D80", VA = "0x2FB4D80")]
	public UIActivityFriendReunionTitleController()
	{
	}

	[Token(Token = "0x6009B78")]
	[Address(RVA = "0x2FB4E04", Offset = "0x2FB4E04", VA = "0x2FB4E04")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009B79")]
	[Address(RVA = "0x2FB4EAC", Offset = "0x2FB4EAC", VA = "0x2FB4EAC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009B7A")]
	[Address(RVA = "0x2FB5180", Offset = "0x2FB5180", VA = "0x2FB5180")]
	private void ShowDetail()
	{
	}

	[Token(Token = "0x6009B7B")]
	[Address(RVA = "0x2FAEC70", Offset = "0x2FAEC70", VA = "0x2FAEC70")]
	public void SetData(string name, string desc, bool selfLink = false)
	{
	}

	[Token(Token = "0x6009B7C")]
	[Address(RVA = "0x2FAF7D4", Offset = "0x2FAF7D4", VA = "0x2FAF7D4")]
	public void SetCallbackButton(bool flag)
	{
	}

	[Token(Token = "0x6009B7D")]
	[Address(RVA = "0x2FB53D4", Offset = "0x2FB53D4", VA = "0x2FB53D4")]
	public void OnClickCallbackButton()
	{
	}

	[Token(Token = "0x6009B7E")]
	[Address(RVA = "0x2FB54E0", Offset = "0x2FB54E0", VA = "0x2FB54E0")]
	public void OnClickGoto()
	{
	}

	[Token(Token = "0x6009B7F")]
	[Address(RVA = "0x2FB569C", Offset = "0x2FB569C", VA = "0x2FB569C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
