using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200218F")]
public class UILinkActivityTDMController : UILinkActivitySimpleController<UILinkActivityTDMRewardItemController>
{
	[Token(Token = "0x600B210")]
	[Address(RVA = "0x255ABA0", Offset = "0x255ABA0", VA = "0x255ABA0")]
	public UILinkActivityTDMController()
	{
	}

	[Token(Token = "0x600B211")]
	[Address(RVA = "0x255AC04", Offset = "0x255AC04", VA = "0x255AC04")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B212")]
	[Address(RVA = "0x255ACAC", Offset = "0x255ACAC", VA = "0x255ACAC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B213")]
	[Address(RVA = "0x255AE60", Offset = "0x255AE60", VA = "0x255AE60", Slot = "36")]
	protected override void InitActivityInfo(LinkActivityData data)
	{
	}

	[Token(Token = "0x600B214")]
	[Address(RVA = "0x255B0F0", Offset = "0x255B0F0", VA = "0x255B0F0")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B215")]
	[Address(RVA = "0x255B0F4", Offset = "0x255B0F4", VA = "0x255B0F4")]
	public void _003C_003EiFixBaseProxy_InitActivityInfo(LinkActivityData P0)
	{
	}
}
