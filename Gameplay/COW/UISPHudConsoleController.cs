using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B2D")]
public class UISPHudConsoleController : UIBaseController
{
	[Token(Token = "0x401091A")]
	[FieldOffset(Offset = "0x28")]
	private UISPHudConsoleView m_View;

	[Token(Token = "0x6011C3C")]
	[Address(RVA = "0x1D1B46C", Offset = "0x1D1B46C", VA = "0x1D1B46C")]
	public UISPHudConsoleController()
	{
	}

	[Token(Token = "0x6011C3D")]
	[Address(RVA = "0x1D1B4F0", Offset = "0x1D1B4F0", VA = "0x1D1B4F0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011C3E")]
	[Address(RVA = "0x1D1B598", Offset = "0x1D1B598", VA = "0x1D1B598", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011C3F")]
	[Address(RVA = "0x1D1B7E8", Offset = "0x1D1B7E8", VA = "0x1D1B7E8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6011C40")]
	[Address(RVA = "0x1D1B91C", Offset = "0x1D1B91C", VA = "0x1D1B91C")]
	private void OnLostFocus()
	{
	}

	[Token(Token = "0x6011C41")]
	[Address(RVA = "0x1D1BBA0", Offset = "0x1D1BBA0", VA = "0x1D1BBA0")]
	private void OnConsoleProcess(object[] data)
	{
	}

	[Token(Token = "0x6011C42")]
	[Address(RVA = "0x1D1BF40", Offset = "0x1D1BF40", VA = "0x1D1BF40")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011C43")]
	[Address(RVA = "0x1D1BF48", Offset = "0x1D1BF48", VA = "0x1D1BF48")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
