using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028E7")]
internal class UIInvitePlatformController : UIPopupWindowController
{
	[Token(Token = "0x400FB8D")]
	[FieldOffset(Offset = "0x48")]
	protected UIInvitePlatformView m_View;

	[Token(Token = "0x400FB8E")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelShare m_ModelShare;

	[Token(Token = "0x601027A")]
	[Address(RVA = "0x1ADBED8", Offset = "0x1ADBED8", VA = "0x1ADBED8")]
	public UIInvitePlatformController()
	{
	}

	[Token(Token = "0x601027B")]
	[Address(RVA = "0x1ADBEE0", Offset = "0x1ADBEE0", VA = "0x1ADBEE0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601027C")]
	[Address(RVA = "0x1ADBF84", Offset = "0x1ADBF84", VA = "0x1ADBF84", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601027D")]
	[Address(RVA = "0x1ADC770", Offset = "0x1ADC770", VA = "0x1ADC770", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x601027E")]
	[Address(RVA = "0x1ADC7D4", Offset = "0x1ADC7D4", VA = "0x1ADC7D4")]
	private string MakeInviteUrl(string urlTemplate)
	{
		return null;
	}

	[Token(Token = "0x601027F")]
	[Address(RVA = "0x1ADCDAC", Offset = "0x1ADCDAC", VA = "0x1ADCDAC")]
	private void OnBtnLineInviteClick()
	{
	}

	[Token(Token = "0x6010280")]
	[Address(RVA = "0x1ADD2C4", Offset = "0x1ADD2C4", VA = "0x1ADD2C4")]
	private void OnBtnFBInviteClick()
	{
	}

	[Token(Token = "0x6010281")]
	[Address(RVA = "0x1ADD920", Offset = "0x1ADD920", VA = "0x1ADD920")]
	private void OnBtnVKInviteClick()
	{
	}

	[Token(Token = "0x6010282")]
	[Address(RVA = "0x1ADDC90", Offset = "0x1ADDC90", VA = "0x1ADDC90")]
	private void OnBtnOtherInviteClick()
	{
	}

	[Token(Token = "0x6010283")]
	[Address(RVA = "0x1ADE0B8", Offset = "0x1ADE0B8", VA = "0x1ADE0B8")]
	private void OnCopyLink()
	{
	}

	[Token(Token = "0x6010284")]
	[Address(RVA = "0x1ADE510", Offset = "0x1ADE510", VA = "0x1ADE510")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010285")]
	[Address(RVA = "0x1ADE518", Offset = "0x1ADE518", VA = "0x1ADE518")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
