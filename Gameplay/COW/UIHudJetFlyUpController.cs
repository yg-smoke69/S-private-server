using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002799")]
internal class UIHudJetFlyUpController : UIHudButtonBaseController
{
	[Token(Token = "0x400F483")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudJetFlyUpView m_View;

	[Token(Token = "0x600F405")]
	[Address(RVA = "0x20B2188", Offset = "0x20B2188", VA = "0x20B2188")]
	public UIHudJetFlyUpController()
	{
	}

	[Token(Token = "0x600F406")]
	[Address(RVA = "0x20B2190", Offset = "0x20B2190", VA = "0x20B2190")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F407")]
	[Address(RVA = "0x20B2238", Offset = "0x20B2238", VA = "0x20B2238", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F408")]
	[Address(RVA = "0x20B2318", Offset = "0x20B2318", VA = "0x20B2318", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600F409")]
	[Address(RVA = "0x20B23BC", Offset = "0x20B23BC", VA = "0x20B23BC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
