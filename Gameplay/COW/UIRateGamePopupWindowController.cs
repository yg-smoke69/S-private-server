using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002AB9")]
public class UIRateGamePopupWindowController : UIPopupWindowController
{
	[Token(Token = "0x401069B")]
	[FieldOffset(Offset = "0x48")]
	private UIRateGamePopupWindowView m_View;

	[Token(Token = "0x170012D2")]
	private static bool UseInAppReview
	{
		[Token(Token = "0x60117D5")]
		[Address(RVA = "0x1AD0658", Offset = "0x1AD0658", VA = "0x1AD0658")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60117CF")]
	[Address(RVA = "0x1ACFA2C", Offset = "0x1ACFA2C", VA = "0x1ACFA2C")]
	public UIRateGamePopupWindowController()
	{
	}

	[Token(Token = "0x60117D0")]
	[Address(RVA = "0x1ACFA34", Offset = "0x1ACFA34", VA = "0x1ACFA34")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60117D1")]
	[Address(RVA = "0x1ACFADC", Offset = "0x1ACFADC", VA = "0x1ACFADC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60117D2")]
	[Address(RVA = "0x1ACFDF4", Offset = "0x1ACFDF4", VA = "0x1ACFDF4", Slot = "34")]
	public override int GlassDelay()
	{
		return default(int);
	}

	[Token(Token = "0x60117D3")]
	[Address(RVA = "0x1ACFE4C", Offset = "0x1ACFE4C", VA = "0x1ACFE4C")]
	private void OnClickCloseBtn()
	{
	}

	[Token(Token = "0x60117D4")]
	[Address(RVA = "0x1ACFFC0", Offset = "0x1ACFFC0", VA = "0x1ACFFC0")]
	private void OnClickSuggestBtn()
	{
	}

	[Token(Token = "0x60117D6")]
	[Address(RVA = "0x1AD07A0", Offset = "0x1AD07A0", VA = "0x1AD07A0")]
	private void OnClickPraiseBtn()
	{
	}

	[Token(Token = "0x60117D7")]
	[Address(RVA = "0x1AD09B8", Offset = "0x1AD09B8", VA = "0x1AD09B8")]
	private void InAppReviewCallback(bool success)
	{
	}

	[Token(Token = "0x60117D8")]
	[Address(RVA = "0x1AD0C08", Offset = "0x1AD0C08", VA = "0x1AD0C08", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60117D9")]
	[Address(RVA = "0x1AD0C6C", Offset = "0x1AD0C6C", VA = "0x1AD0C6C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60117DA")]
	[Address(RVA = "0x1AD0C74", Offset = "0x1AD0C74", VA = "0x1AD0C74")]
	public int _003C_003EiFixBaseProxy_GlassDelay()
	{
		return default(int);
	}

	[Token(Token = "0x60117DB")]
	[Address(RVA = "0x1AD0C7C", Offset = "0x1AD0C7C", VA = "0x1AD0C7C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
