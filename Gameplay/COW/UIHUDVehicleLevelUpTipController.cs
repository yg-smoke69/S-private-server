using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028AA")]
public class UIHUDVehicleLevelUpTipController : UIBaseController
{
	[Token(Token = "0x400FA3D")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDVehicleLevelUpTipView m_View;

	[Token(Token = "0x400FA3E")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCallCD;

	[Token(Token = "0x600FF9B")]
	[Address(RVA = "0x29347A8", Offset = "0x29347A8", VA = "0x29347A8")]
	public UIHUDVehicleLevelUpTipController()
	{
	}

	[Token(Token = "0x600FF9C")]
	[Address(RVA = "0x293482C", Offset = "0x293482C", VA = "0x293482C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FF9D")]
	[Address(RVA = "0x29348D0", Offset = "0x29348D0", VA = "0x29348D0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FF9E")]
	[Address(RVA = "0x2934A20", Offset = "0x2934A20", VA = "0x2934A20", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600FF9F")]
	[Address(RVA = "0x2934B54", Offset = "0x2934B54", VA = "0x2934B54")]
	private void OnLocalVehcleLevelUp(object[] data)
	{
	}

	[Token(Token = "0x600FFA0")]
	[Address(RVA = "0x2934E58", Offset = "0x2934E58", VA = "0x2934E58")]
	private void _003COnLocalVehcleLevelUp_003Em__0()
	{
	}

	[Token(Token = "0x600FFA1")]
	[Address(RVA = "0x2934E68", Offset = "0x2934E68", VA = "0x2934E68")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FFA2")]
	[Address(RVA = "0x2934E70", Offset = "0x2934E70", VA = "0x2934E70")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
