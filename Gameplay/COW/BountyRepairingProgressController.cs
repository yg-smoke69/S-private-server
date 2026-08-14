using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001FEE")]
public class BountyRepairingProgressController : UIBaseController
{
	[Token(Token = "0x400C8CC")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDBountyRepairProgressView m_view;

	[Token(Token = "0x600A113")]
	[Address(RVA = "0x180E810", Offset = "0x180E810", VA = "0x180E810")]
	public BountyRepairingProgressController()
	{
	}

	[Token(Token = "0x600A114")]
	[Address(RVA = "0x180E894", Offset = "0x180E894", VA = "0x180E894")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A115")]
	[Address(RVA = "0x180E93C", Offset = "0x180E93C", VA = "0x180E93C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A116")]
	[Address(RVA = "0x180EB88", Offset = "0x180EB88", VA = "0x180EB88")]
	private void OnProgressCome(object[] param)
	{
	}

	[Token(Token = "0x600A117")]
	[Address(RVA = "0x180EEAC", Offset = "0x180EEAC", VA = "0x180EEAC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
