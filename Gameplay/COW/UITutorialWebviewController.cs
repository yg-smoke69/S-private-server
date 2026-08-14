using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B8E")]
internal class UITutorialWebviewController : UIWebViewWindowBaseController
{
	[Token(Token = "0x4010AA0")]
	[FieldOffset(Offset = "0x50")]
	private UITutorialWebViewView m_View;

	[Token(Token = "0x6011FFA")]
	[Address(RVA = "0x2B7E704", Offset = "0x2B7E704", VA = "0x2B7E704")]
	public UITutorialWebviewController()
	{
	}

	[Token(Token = "0x6011FFB")]
	[Address(RVA = "0x2B7E70C", Offset = "0x2B7E70C", VA = "0x2B7E70C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011FFC")]
	[Address(RVA = "0x2B7E7B4", Offset = "0x2B7E7B4", VA = "0x2B7E7B4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011FFD")]
	[Address(RVA = "0x2B7E870", Offset = "0x2B7E870", VA = "0x2B7E870")]
	public void SetData(string url, string title)
	{
	}

	[Token(Token = "0x6011FFE")]
	[Address(RVA = "0x2B7E9E0", Offset = "0x2B7E9E0", VA = "0x2B7E9E0")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
