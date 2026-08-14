using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028A2")]
internal class UIHudVehicleBoostController : UIHudVehicleItemButtonController
{
	[Token(Token = "0x400FA14")]
	[FieldOffset(Offset = "0x44")]
	private UIHudVehicleBoostView m_View;

	[Token(Token = "0x400FA15")]
	[FieldOffset(Offset = "0x48")]
	private bool m_DriverAiming;

	[Token(Token = "0x600FF3B")]
	[Address(RVA = "0x1A6C0CC", Offset = "0x1A6C0CC", VA = "0x1A6C0CC")]
	public UIHudVehicleBoostController()
	{
	}

	[Token(Token = "0x600FF3C")]
	[Address(RVA = "0x1A6C0EC", Offset = "0x1A6C0EC", VA = "0x1A6C0EC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FF3D")]
	[Address(RVA = "0x1A6C190", Offset = "0x1A6C190", VA = "0x1A6C190", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600FF3E")]
	[Address(RVA = "0x1A6C234", Offset = "0x1A6C234", VA = "0x1A6C234", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FF3F")]
	[Address(RVA = "0x1A6C600", Offset = "0x1A6C600", VA = "0x1A6C600", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FF40")]
	[Address(RVA = "0x1A6C93C", Offset = "0x1A6C93C", VA = "0x1A6C93C")]
	private void OnDriverAiming(object[] param)
	{
	}

	[Token(Token = "0x600FF41")]
	[Address(RVA = "0x1A6CBD4", Offset = "0x1A6CBD4", VA = "0x1A6CBD4", Slot = "37")]
	protected override void OnPlayerGetOnVehicle(object[] ps)
	{
	}

	[Token(Token = "0x600FF42")]
	[Address(RVA = "0x1A6CCB0", Offset = "0x1A6CCB0", VA = "0x1A6CCB0", Slot = "38")]
	protected override bool ShouldHide()
	{
		return default(bool);
	}

	[Token(Token = "0x600FF43")]
	[Address(RVA = "0x1A6CD08", Offset = "0x1A6CD08", VA = "0x1A6CD08")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FF44")]
	[Address(RVA = "0x1A6CD0C", Offset = "0x1A6CD0C", VA = "0x1A6CD0C")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600FF45")]
	[Address(RVA = "0x1A6CD10", Offset = "0x1A6CD10", VA = "0x1A6CD10")]
	public void _003C_003EiFixBaseProxy_OnPlayerGetOnVehicle(object[] P0)
	{
	}

	[Token(Token = "0x600FF46")]
	[Address(RVA = "0x1A6CD14", Offset = "0x1A6CD14", VA = "0x1A6CD14")]
	public bool _003C_003EiFixBaseProxy_ShouldHide()
	{
		return default(bool);
	}
}
