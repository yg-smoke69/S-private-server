using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026F7")]
internal class UIHudBrakeController : UIHudVehicleButtonBaseController
{
	[Token(Token = "0x400F09A")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudBrakeView m_View;

	[Token(Token = "0x600EC80")]
	[Address(RVA = "0x1E16E04", Offset = "0x1E16E04", VA = "0x1E16E04")]
	public UIHudBrakeController()
	{
	}

	[Token(Token = "0x600EC81")]
	[Address(RVA = "0x1E16E0C", Offset = "0x1E16E0C", VA = "0x1E16E0C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EC82")]
	[Address(RVA = "0x1E16EB0", Offset = "0x1E16EB0", VA = "0x1E16EB0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EC83")]
	[Address(RVA = "0x1E16F90", Offset = "0x1E16F90", VA = "0x1E16F90", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600EC84")]
	[Address(RVA = "0x1E17034", Offset = "0x1E17034", VA = "0x1E17034", Slot = "37")]
	protected override EControlMode ShowInControlMode()
	{
		return default(EControlMode);
	}

	[Token(Token = "0x600EC85")]
	[Address(RVA = "0x1E1708C", Offset = "0x1E1708C", VA = "0x1E1708C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
