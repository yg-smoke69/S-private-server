using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A11")]
public class UIPaymentActivityController : UIPaymentController.PaymentTabContentController
{
	[Token(Token = "0x40102C1")]
	[FieldOffset(Offset = "0x28")]
	private UIPaymentActivityView m_View;

	[Token(Token = "0x40102C2")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelActivity m_Activity;

	[Token(Token = "0x6011025")]
	[Address(RVA = "0x2867D7C", Offset = "0x2867D7C", VA = "0x2867D7C")]
	public UIPaymentActivityController()
	{
	}

	[Token(Token = "0x6011026")]
	[Address(RVA = "0x2867E04", Offset = "0x2867E04", VA = "0x2867E04")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011027")]
	[Address(RVA = "0x2867EAC", Offset = "0x2867EAC", VA = "0x2867EAC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011028")]
	[Address(RVA = "0x286808C", Offset = "0x286808C", VA = "0x286808C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011029")]
	[Address(RVA = "0x28680F0", Offset = "0x28680F0", VA = "0x28680F0", Slot = "32")]
	public override void RefreshContent()
	{
	}

	[Token(Token = "0x601102A")]
	[Address(RVA = "0x28684A4", Offset = "0x28684A4", VA = "0x28684A4")]
	private void OnButtonClick()
	{
	}

	[Token(Token = "0x601102B")]
	[Address(RVA = "0x28683F8", Offset = "0x28683F8", VA = "0x28683F8")]
	private void ApplyCdnUrlToNetworkTexture(UINetworkTextureExt networkTexture, string url)
	{
	}

	[Token(Token = "0x601102C")]
	[Address(RVA = "0x2868634", Offset = "0x2868634", VA = "0x2868634")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601102D")]
	[Address(RVA = "0x286863C", Offset = "0x286863C", VA = "0x286863C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x601102E")]
	[Address(RVA = "0x2868644", Offset = "0x2868644", VA = "0x2868644")]
	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}
}
