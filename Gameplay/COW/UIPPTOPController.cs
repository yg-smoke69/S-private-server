using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A7F")]
public class UIPPTOPController : UIPopupWindowController
{
	[Token(Token = "0x4010511")]
	[FieldOffset(Offset = "0x48")]
	private UIPPTOPView m_View;

	[Token(Token = "0x4010512")]
	[FieldOffset(Offset = "0x4C")]
	private string m_PrivacyURL;

	[Token(Token = "0x4010513")]
	[FieldOffset(Offset = "0x50")]
	private string m_ServiceURL;

	[Token(Token = "0x4010514")]
	[FieldOffset(Offset = "0x54")]
	private bool m_IsAgreed;

	[Token(Token = "0x60114CE")]
	[Address(RVA = "0x15A24D8", Offset = "0x15A24D8", VA = "0x15A24D8")]
	public UIPPTOPController()
	{
	}

	[Token(Token = "0x60114CF")]
	[Address(RVA = "0x15A24E0", Offset = "0x15A24E0", VA = "0x15A24E0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60114D0")]
	[Address(RVA = "0x15A2588", Offset = "0x15A2588", VA = "0x15A2588", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60114D1")]
	[Address(RVA = "0x15A27CC", Offset = "0x15A27CC", VA = "0x15A27CC")]
	public void SetData(bool privacyShow, bool serviceShow, string privacyURL, string serviceURL)
	{
	}

	[Token(Token = "0x60114D2")]
	[Address(RVA = "0x15A296C", Offset = "0x15A296C", VA = "0x15A296C")]
	private void OnBtnPrivacyClick()
	{
	}

	[Token(Token = "0x60114D3")]
	[Address(RVA = "0x15A2A44", Offset = "0x15A2A44", VA = "0x15A2A44")]
	private void OnBtnServiceClick()
	{
	}

	[Token(Token = "0x60114D4")]
	[Address(RVA = "0x15A2B1C", Offset = "0x15A2B1C", VA = "0x15A2B1C")]
	private void OnBtnAgreeClick()
	{
	}

	[Token(Token = "0x60114D5")]
	[Address(RVA = "0x15A2C3C", Offset = "0x15A2C3C", VA = "0x15A2C3C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x60114D6")]
	[Address(RVA = "0x15A2DE4", Offset = "0x15A2DE4", VA = "0x15A2DE4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60114D7")]
	[Address(RVA = "0x15A2DEC", Offset = "0x15A2DEC", VA = "0x15A2DEC")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
