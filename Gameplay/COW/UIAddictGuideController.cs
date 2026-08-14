using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200249A")]
internal class UIAddictGuideController : UIPopupWindowController
{
	[Token(Token = "0x400E2E4")]
	[FieldOffset(Offset = "0x48")]
	private UIAddictGuideView m_View;

	[Token(Token = "0x600D141")]
	[Address(RVA = "0x1F3017C", Offset = "0x1F3017C", VA = "0x1F3017C")]
	public UIAddictGuideController()
	{
	}

	[Token(Token = "0x600D142")]
	[Address(RVA = "0x1F30184", Offset = "0x1F30184", VA = "0x1F30184")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D143")]
	[Address(RVA = "0x1F30228", Offset = "0x1F30228", VA = "0x1F30228", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D144")]
	[Address(RVA = "0x1F30384", Offset = "0x1F30384", VA = "0x1F30384")]
	public void SetWarningViewData(string message, string cdn)
	{
	}

	[Token(Token = "0x600D145")]
	[Address(RVA = "0x1F30584", Offset = "0x1F30584", VA = "0x1F30584")]
	public void SetBanViewData(string message, string cdn, string unbanTime)
	{
	}

	[Token(Token = "0x600D146")]
	[Address(RVA = "0x1F307C4", Offset = "0x1F307C4", VA = "0x1F307C4")]
	private void OnConfirmBtnClick()
	{
	}

	[Token(Token = "0x600D147")]
	[Address(RVA = "0x1F30828", Offset = "0x1F30828", VA = "0x1F30828")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
