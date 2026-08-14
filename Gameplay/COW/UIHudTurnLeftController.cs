using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200288D")]
internal class UIHudTurnLeftController : UIHudVehicleButtonBaseController
{
	[Token(Token = "0x400F9B7")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudTurnLeftView m_View;

	[Token(Token = "0x600FE82")]
	[Address(RVA = "0x158DE34", Offset = "0x158DE34", VA = "0x158DE34")]
	public UIHudTurnLeftController()
	{
	}

	[Token(Token = "0x600FE83")]
	[Address(RVA = "0x158DE3C", Offset = "0x158DE3C", VA = "0x158DE3C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FE84")]
	[Address(RVA = "0x158DEE0", Offset = "0x158DEE0", VA = "0x158DEE0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FE85")]
	[Address(RVA = "0x158DFC0", Offset = "0x158DFC0", VA = "0x158DFC0", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600FE86")]
	[Address(RVA = "0x158E064", Offset = "0x158E064", VA = "0x158E064", Slot = "37")]
	protected override EControlMode ShowInControlMode()
	{
		return default(EControlMode);
	}

	[Token(Token = "0x600FE87")]
	[Address(RVA = "0x158E0BC", Offset = "0x158E0BC", VA = "0x158E0BC")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
