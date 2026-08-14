using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200227F")]
internal class UIHudPartyNPCInteractReactItemController : UIBaseController
{
	[Token(Token = "0x400D7ED")]
	[FieldOffset(Offset = "0x28")]
	private UIHudPartyNPCInteractReactItemView m_View;

	[Token(Token = "0x400D7EE")]
	[FieldOffset(Offset = "0x2C")]
	private OENEFEGDAFP m_CurNode;

	[Token(Token = "0x600BD27")]
	[Address(RVA = "0x1845A4C", Offset = "0x1845A4C", VA = "0x1845A4C")]
	public UIHudPartyNPCInteractReactItemController()
	{
	}

	[Token(Token = "0x600BD28")]
	[Address(RVA = "0x1845AD0", Offset = "0x1845AD0", VA = "0x1845AD0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BD29")]
	[Address(RVA = "0x1845B78", Offset = "0x1845B78", VA = "0x1845B78", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BD2A")]
	[Address(RVA = "0x18455FC", Offset = "0x18455FC", VA = "0x18455FC")]
	public void SetInteractNode(OENEFEGDAFP node)
	{
	}

	[Token(Token = "0x600BD2B")]
	[Address(RVA = "0x1845CD4", Offset = "0x1845CD4", VA = "0x1845CD4")]
	private void OnItemButtonClick()
	{
	}

	[Token(Token = "0x600BD2C")]
	[Address(RVA = "0x1845E44", Offset = "0x1845E44", VA = "0x1845E44")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
