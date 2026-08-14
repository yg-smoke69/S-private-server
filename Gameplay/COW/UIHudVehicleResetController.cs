using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028B2")]
internal class UIHudVehicleResetController : UIHudButtonBaseController
{
	[Token(Token = "0x400FA5E")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudVehicleResetView m_View;

	[Token(Token = "0x400FA5F")]
	[FieldOffset(Offset = "0x30")]
	private Vehicle m_Vehicle;

	[Token(Token = "0x400FA60")]
	[FieldOffset(Offset = "0x34")]
	private float m_ResetTime;

	[Token(Token = "0x400FA61")]
	[FieldOffset(Offset = "0x38")]
	private float m_ResetVal;

	[Token(Token = "0x600FFDC")]
	[Address(RVA = "0x1A6FCF0", Offset = "0x1A6FCF0", VA = "0x1A6FCF0")]
	public UIHudVehicleResetController()
	{
	}

	[Token(Token = "0x600FFDD")]
	[Address(RVA = "0x1A6FCF8", Offset = "0x1A6FCF8", VA = "0x1A6FCF8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FFDE")]
	[Address(RVA = "0x1A6FD9C", Offset = "0x1A6FD9C", VA = "0x1A6FD9C", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600FFDF")]
	[Address(RVA = "0x1A6FE40", Offset = "0x1A6FE40", VA = "0x1A6FE40", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FFE0")]
	[Address(RVA = "0x1A7013C", Offset = "0x1A7013C", VA = "0x1A7013C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FFE1")]
	[Address(RVA = "0x1A702D8", Offset = "0x1A702D8", VA = "0x1A702D8")]
	private void Update()
	{
	}

	[Token(Token = "0x600FFE2")]
	[Address(RVA = "0x1A7055C", Offset = "0x1A7055C", VA = "0x1A7055C")]
	private void OnTryReset()
	{
	}

	[Token(Token = "0x600FFE3")]
	[Address(RVA = "0x1A70994", Offset = "0x1A70994", VA = "0x1A70994")]
	private void OnPlayerGetOnVehicle(object[] ps)
	{
	}

	[Token(Token = "0x600FFE4")]
	[Address(RVA = "0x1A70BE4", Offset = "0x1A70BE4", VA = "0x1A70BE4")]
	private void OnPlayerGetOffVehicle(object[] ps)
	{
	}

	[Token(Token = "0x600FFE5")]
	[Address(RVA = "0x1A70DC0", Offset = "0x1A70DC0", VA = "0x1A70DC0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FFE6")]
	[Address(RVA = "0x1A70DC8", Offset = "0x1A70DC8", VA = "0x1A70DC8")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
