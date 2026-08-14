using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200288E")]
internal class UIHudTurnRightController : UIHudVehicleButtonBaseController
{
	[Token(Token = "0x400F9B8")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudTurnRightView m_View;

	[Token(Token = "0x600FE88")]
	[Address(RVA = "0x158E27C", Offset = "0x158E27C", VA = "0x158E27C")]
	public UIHudTurnRightController()
	{
	}

	[Token(Token = "0x600FE89")]
	[Address(RVA = "0x158E284", Offset = "0x158E284", VA = "0x158E284")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FE8A")]
	[Address(RVA = "0x158E328", Offset = "0x158E328", VA = "0x158E328", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FE8B")]
	[Address(RVA = "0x158E408", Offset = "0x158E408", VA = "0x158E408", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600FE8C")]
	[Address(RVA = "0x158E4AC", Offset = "0x158E4AC", VA = "0x158E4AC", Slot = "37")]
	protected override EControlMode ShowInControlMode()
	{
		return default(EControlMode);
	}

	[Token(Token = "0x600FE8D")]
	[Address(RVA = "0x158E504", Offset = "0x158E504", VA = "0x158E504")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
