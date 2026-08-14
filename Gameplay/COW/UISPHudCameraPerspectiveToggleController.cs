using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B2B")]
public class UISPHudCameraPerspectiveToggleController : UIBaseController
{
	[Token(Token = "0x4010919")]
	[FieldOffset(Offset = "0x28")]
	private UISPHudCameraPerspectiveToggleView m_View;

	[Token(Token = "0x6011C33")]
	[Address(RVA = "0x1D1A7B4", Offset = "0x1D1A7B4", VA = "0x1D1A7B4")]
	public UISPHudCameraPerspectiveToggleController()
	{
	}

	[Token(Token = "0x6011C34")]
	[Address(RVA = "0x1D1A838", Offset = "0x1D1A838", VA = "0x1D1A838")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011C35")]
	[Address(RVA = "0x1D1A8E0", Offset = "0x1D1A8E0", VA = "0x1D1A8E0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011C36")]
	[Address(RVA = "0x1D1ABE4", Offset = "0x1D1ABE4", VA = "0x1D1ABE4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011C37")]
	[Address(RVA = "0x1D1AD18", Offset = "0x1D1AD18", VA = "0x1D1AD18")]
	private void OnSwitchCameraPerspective()
	{
	}

	[Token(Token = "0x6011C38")]
	[Address(RVA = "0x1D1ADF4", Offset = "0x1D1ADF4", VA = "0x1D1ADF4")]
	private void UpdateUIView(object[] data)
	{
	}

	[Token(Token = "0x6011C39")]
	[Address(RVA = "0x1D1AFA8", Offset = "0x1D1AFA8", VA = "0x1D1AFA8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011C3A")]
	[Address(RVA = "0x1D1AFB0", Offset = "0x1D1AFB0", VA = "0x1D1AFB0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
