using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002751")]
internal class UIHudFlightRoamUpController : UIHudButtonBaseController
{
	[Token(Token = "0x400F2C2")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudFlightRoamUpView m_View;

	[Token(Token = "0x600F027")]
	[Address(RVA = "0x1BB23BC", Offset = "0x1BB23BC", VA = "0x1BB23BC")]
	public UIHudFlightRoamUpController()
	{
	}

	[Token(Token = "0x600F028")]
	[Address(RVA = "0x1BB23C4", Offset = "0x1BB23C4", VA = "0x1BB23C4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F029")]
	[Address(RVA = "0x1BB246C", Offset = "0x1BB246C", VA = "0x1BB246C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F02A")]
	[Address(RVA = "0x1BB254C", Offset = "0x1BB254C", VA = "0x1BB254C", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600F02B")]
	[Address(RVA = "0x1BB25F0", Offset = "0x1BB25F0", VA = "0x1BB25F0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
