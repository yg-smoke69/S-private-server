using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028A4")]
internal abstract class UIHudVehicleButtonBaseController : UIHudButtonBaseController
{
	[Token(Token = "0x600FF4D")]
	[Address(RVA = "0x1A6B910", Offset = "0x1A6B910", VA = "0x1A6B910")]
	protected UIHudVehicleButtonBaseController()
	{
	}

	[Token(Token = "0x600FF4E")]
	protected abstract EControlMode ShowInControlMode();

	[Token(Token = "0x600FF4F")]
	[Address(RVA = "0x1A6BA9C", Offset = "0x1A6BA9C", VA = "0x1A6BA9C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FF50")]
	[Address(RVA = "0x1A6D368", Offset = "0x1A6D368", VA = "0x1A6D368", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FF51")]
	[Address(RVA = "0x1A6D4A4", Offset = "0x1A6D4A4", VA = "0x1A6D4A4", Slot = "18")]
	protected override void OnUIActiveGroupSwitch(ulong activeGroup)
	{
	}

	[Token(Token = "0x600FF52")]
	[Address(RVA = "0x1A6D628", Offset = "0x1A6D628", VA = "0x1A6D628", Slot = "38")]
	protected virtual void RefreshVisibleWithControlMode(object[] data)
	{
	}

	[Token(Token = "0x600FF53")]
	[Address(RVA = "0x1A6D938", Offset = "0x1A6D938", VA = "0x1A6D938")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FF54")]
	[Address(RVA = "0x1A6D940", Offset = "0x1A6D940", VA = "0x1A6D940")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600FF55")]
	[Address(RVA = "0x1A6D948", Offset = "0x1A6D948", VA = "0x1A6D948")]
	public void _003C_003EiFixBaseProxy_OnUIActiveGroupSwitch(ulong P0)
	{
	}
}
