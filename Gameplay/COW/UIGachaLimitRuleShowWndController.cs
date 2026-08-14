using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002666")]
internal class UIGachaLimitRuleShowWndController : UIPopupWindowController
{
	[Token(Token = "0x400ED28")]
	[FieldOffset(Offset = "0x48")]
	private UIGachaLimitRuleShowWndView m_View;

	[Token(Token = "0x600E5AD")]
	[Address(RVA = "0x2A17048", Offset = "0x2A17048", VA = "0x2A17048")]
	public UIGachaLimitRuleShowWndController()
	{
	}

	[Token(Token = "0x600E5AE")]
	[Address(RVA = "0x2A17050", Offset = "0x2A17050", VA = "0x2A17050")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E5AF")]
	[Address(RVA = "0x2A170F4", Offset = "0x2A170F4", VA = "0x2A170F4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E5B0")]
	[Address(RVA = "0x2A171B0", Offset = "0x2A171B0", VA = "0x2A171B0")]
	public void SetViewData(string rareProbability, string priceLine)
	{
	}

	[Token(Token = "0x600E5B1")]
	[Address(RVA = "0x2A1757C", Offset = "0x2A1757C", VA = "0x2A1757C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
