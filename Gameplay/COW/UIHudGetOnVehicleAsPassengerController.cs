using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002765")]
internal class UIHudGetOnVehicleAsPassengerController : UIHudGetOnVehicleController
{
	[Token(Token = "0x400F32B")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudGetOnVehicleAsPassengerView m_View;

	[Token(Token = "0x600F0CB")]
	[Address(RVA = "0x1893844", Offset = "0x1893844", VA = "0x1893844")]
	public UIHudGetOnVehicleAsPassengerController()
	{
	}

	[Token(Token = "0x600F0CC")]
	[Address(RVA = "0x189384C", Offset = "0x189384C", VA = "0x189384C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F0CD")]
	[Address(RVA = "0x18938F0", Offset = "0x18938F0", VA = "0x18938F0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F0CE")]
	[Address(RVA = "0x18939CC", Offset = "0x18939CC", VA = "0x18939CC", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600F0CF")]
	[Address(RVA = "0x1893A70", Offset = "0x1893A70", VA = "0x1893A70", Slot = "38")]
	protected override bool ShouldShow(bool driverEmpty, bool passengerEmpty)
	{
		return default(bool);
	}

	[Token(Token = "0x600F0D0")]
	[Address(RVA = "0x1893AEC", Offset = "0x1893AEC", VA = "0x1893AEC", Slot = "33")]
	protected override void OnBtnClick()
	{
	}

	[Token(Token = "0x600F0D1")]
	[Address(RVA = "0x1893BD8", Offset = "0x1893BD8", VA = "0x1893BD8", Slot = "35")]
	protected override void OnBtnRelease()
	{
	}

	[Token(Token = "0x600F0D2")]
	[Address(RVA = "0x1893CC4", Offset = "0x1893CC4", VA = "0x1893CC4")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F0D3")]
	[Address(RVA = "0x1893CC8", Offset = "0x1893CC8", VA = "0x1893CC8")]
	public bool _003C_003EiFixBaseProxy_ShouldShow(bool P0, bool P1)
	{
		return default(bool);
	}

	[Token(Token = "0x600F0D4")]
	[Address(RVA = "0x1893CCC", Offset = "0x1893CCC", VA = "0x1893CCC")]
	public void _003C_003EiFixBaseProxy_OnBtnClick()
	{
	}

	[Token(Token = "0x600F0D5")]
	[Address(RVA = "0x1893CD4", Offset = "0x1893CD4", VA = "0x1893CD4")]
	public void _003C_003EiFixBaseProxy_OnBtnRelease()
	{
	}
}
