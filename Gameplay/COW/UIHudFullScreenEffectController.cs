using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002754")]
internal class UIHudFullScreenEffectController : UIBaseController
{
	[Token(Token = "0x400F2E7")]
	[FieldOffset(Offset = "0x28")]
	private UIHudFullScreenEffectView m_View;

	[Token(Token = "0x400F2E8")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_IsTweenFinished;

	[Token(Token = "0x600F051")]
	[Address(RVA = "0x1886FE0", Offset = "0x1886FE0", VA = "0x1886FE0")]
	public UIHudFullScreenEffectController()
	{
	}

	[Token(Token = "0x600F052")]
	[Address(RVA = "0x188706C", Offset = "0x188706C", VA = "0x188706C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F053")]
	[Address(RVA = "0x1887114", Offset = "0x1887114", VA = "0x1887114", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F054")]
	[Address(RVA = "0x18873E8", Offset = "0x18873E8", VA = "0x18873E8")]
	private void OnFinished()
	{
	}

	[Token(Token = "0x600F055")]
	[Address(RVA = "0x1887444", Offset = "0x1887444", VA = "0x1887444")]
	public void Play()
	{
	}

	[Token(Token = "0x600F056")]
	[Address(RVA = "0x1887518", Offset = "0x1887518", VA = "0x1887518")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
