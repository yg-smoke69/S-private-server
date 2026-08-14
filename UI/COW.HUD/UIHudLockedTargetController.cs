using GCommon;
using Il2CppDummyDll;

namespace COW.HUD;

[Token(Token = "0x20027A4")]
internal class UIHudLockedTargetController : UIHudVehicleAsMissileTargetControllerBase
{
	[Token(Token = "0x400F4BB")]
	[FieldOffset(Offset = "0x8C")]
	private UIHudLockedTargetView NOJLDPLOCIH;

	[Token(Token = "0x600F470")]
	[Address(RVA = "0x121A458", Offset = "0x121A458", VA = "0x121A458")]
	public UIHudLockedTargetController()
	{
	}

	[Token(Token = "0x600F471")]
	[Address(RVA = "0x121A460", Offset = "0x121A460", VA = "0x121A460")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F472")]
	[Address(RVA = "0x121A4C4", Offset = "0x121A4C4", VA = "0x121A4C4", Slot = "13")]
	protected override void OnUIInit()
	{
	}
}
