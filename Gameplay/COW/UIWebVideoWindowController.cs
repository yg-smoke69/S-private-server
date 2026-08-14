using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C1D")]
internal class UIWebVideoWindowController : UIWebViewWindowBaseController
{
	[Token(Token = "0x4010D70")]
	[FieldOffset(Offset = "0x50")]
	private UIWebVideoWindowView m_View;

	[Token(Token = "0x60125A8")]
	[Address(RVA = "0x1B7CBA8", Offset = "0x1B7CBA8", VA = "0x1B7CBA8")]
	public UIWebVideoWindowController()
	{
	}

	[Token(Token = "0x60125A9")]
	[Address(RVA = "0x1B7CBB8", Offset = "0x1B7CBB8", VA = "0x1B7CBB8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60125AA")]
	[Address(RVA = "0x1B7CC60", Offset = "0x1B7CC60", VA = "0x1B7CC60", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60125AB")]
	[Address(RVA = "0x1B7D084", Offset = "0x1B7D084", VA = "0x1B7D084", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60125AC")]
	[Address(RVA = "0x1B7D354", Offset = "0x1B7D354", VA = "0x1B7D354")]
	public void SetData(string url, bool forcePlay = false, [Optional] string bgCdnUrl)
	{
	}

	[Token(Token = "0x60125AD")]
	[Address(RVA = "0x1B7D77C", Offset = "0x1B7D77C", VA = "0x1B7D77C", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x60125AE")]
	[Address(RVA = "0x1B7CEF0", Offset = "0x1B7CEF0", VA = "0x1B7CEF0")]
	private void EnableLobbyBGM(bool v)
	{
	}

	[Token(Token = "0x60125AF")]
	[Address(RVA = "0x1B7DA7C", Offset = "0x1B7DA7C", VA = "0x1B7DA7C")]
	private void OnClickCloseBtn()
	{
	}

	[Token(Token = "0x60125B0")]
	[Address(RVA = "0x1B7DAE0", Offset = "0x1B7DAE0", VA = "0x1B7DAE0")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60125B1")]
	[Address(RVA = "0x1B7DAE4", Offset = "0x1B7DAE4", VA = "0x1B7DAE4")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60125B2")]
	[Address(RVA = "0x1B7DAE8", Offset = "0x1B7DAE8", VA = "0x1B7DAE8")]
	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
