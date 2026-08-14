using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002764")]
internal class UIHudGetOnVehicleAsDriverController : UIHudGetOnVehicleController
{
	[Token(Token = "0x400F32A")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudGetOnVehicleAsDriverView m_View;

	[Token(Token = "0x600F0BE")]
	[Address(RVA = "0x1892CA4", Offset = "0x1892CA4", VA = "0x1892CA4")]
	public UIHudGetOnVehicleAsDriverController()
	{
	}

	[Token(Token = "0x600F0BF")]
	[Address(RVA = "0x1892CB4", Offset = "0x1892CB4", VA = "0x1892CB4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F0C0")]
	[Address(RVA = "0x1892D58", Offset = "0x1892D58", VA = "0x1892D58", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F0C1")]
	[Address(RVA = "0x1892FDC", Offset = "0x1892FDC", VA = "0x1892FDC", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600F0C2")]
	[Address(RVA = "0x1893080", Offset = "0x1893080", VA = "0x1893080", Slot = "38")]
	protected override bool ShouldShow(bool driverEmpty, bool passengerEmpty)
	{
		return default(bool);
	}

	[Token(Token = "0x600F0C3")]
	[Address(RVA = "0x18930FC", Offset = "0x18930FC", VA = "0x18930FC", Slot = "37")]
	protected override void OnActionEnter(object[] param)
	{
	}

	[Token(Token = "0x600F0C4")]
	[Address(RVA = "0x18933BC", Offset = "0x18933BC", VA = "0x18933BC", Slot = "33")]
	protected override void OnBtnClick()
	{
	}

	[Token(Token = "0x600F0C5")]
	[Address(RVA = "0x18934A8", Offset = "0x18934A8", VA = "0x18934A8", Slot = "35")]
	protected override void OnBtnRelease()
	{
	}

	[Token(Token = "0x600F0C6")]
	[Address(RVA = "0x1893594", Offset = "0x1893594", VA = "0x1893594")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F0C7")]
	[Address(RVA = "0x1893598", Offset = "0x1893598", VA = "0x1893598")]
	public bool _003C_003EiFixBaseProxy_ShouldShow(bool P0, bool P1)
	{
		return default(bool);
	}

	[Token(Token = "0x600F0C8")]
	[Address(RVA = "0x1893618", Offset = "0x1893618", VA = "0x1893618")]
	public void _003C_003EiFixBaseProxy_OnActionEnter(object[] P0)
	{
	}

	[Token(Token = "0x600F0C9")]
	[Address(RVA = "0x189361C", Offset = "0x189361C", VA = "0x189361C")]
	public void _003C_003EiFixBaseProxy_OnBtnClick()
	{
	}

	[Token(Token = "0x600F0CA")]
	[Address(RVA = "0x1893624", Offset = "0x1893624", VA = "0x1893624")]
	public void _003C_003EiFixBaseProxy_OnBtnRelease()
	{
	}
}
