using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028A1")]
internal class UIHudVehicleAutoDriveController : UIHudVehicleButtonBaseController
{
	[Token(Token = "0x400FA13")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudVehicleAutoDriveView m_View;

	[Token(Token = "0x600FF32")]
	[Address(RVA = "0x1A6B908", Offset = "0x1A6B908", VA = "0x1A6B908")]
	public UIHudVehicleAutoDriveController()
	{
	}

	[Token(Token = "0x600FF33")]
	[Address(RVA = "0x1A6B918", Offset = "0x1A6B918", VA = "0x1A6B918", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FF34")]
	[Address(RVA = "0x1A6BBD8", Offset = "0x1A6BBD8", VA = "0x1A6BBD8")]
	private void OnPlayerGetOnVehicle(object[] data)
	{
	}

	[Token(Token = "0x600FF35")]
	[Address(RVA = "0x1A6BC34", Offset = "0x1A6BC34", VA = "0x1A6BC34", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600FF36")]
	[Address(RVA = "0x1A6BD68", Offset = "0x1A6BD68", VA = "0x1A6BD68")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FF37")]
	[Address(RVA = "0x1A6BE0C", Offset = "0x1A6BE0C", VA = "0x1A6BE0C", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600FF38")]
	[Address(RVA = "0x1A6BEB0", Offset = "0x1A6BEB0", VA = "0x1A6BEB0", Slot = "37")]
	protected override EControlMode ShowInControlMode()
	{
		return default(EControlMode);
	}

	[Token(Token = "0x600FF39")]
	[Address(RVA = "0x1A6BF08", Offset = "0x1A6BF08", VA = "0x1A6BF08")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FF3A")]
	[Address(RVA = "0x1A6BF0C", Offset = "0x1A6BF0C", VA = "0x1A6BF0C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
