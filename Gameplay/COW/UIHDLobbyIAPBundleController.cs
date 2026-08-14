using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026C4")]
public class UIHDLobbyIAPBundleController : UIBaseController
{
	[Token(Token = "0x400EF3C")]
	[FieldOffset(Offset = "0x28")]
	private UIHDLobbyIAPBundleView m_View;

	[Token(Token = "0x400EF3D")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelIAPBundle m_Model;

	[Token(Token = "0x600EA33")]
	[Address(RVA = "0x202D88C", Offset = "0x202D88C", VA = "0x202D88C")]
	public UIHDLobbyIAPBundleController()
	{
	}

	[Token(Token = "0x600EA34")]
	[Address(RVA = "0x202D910", Offset = "0x202D910", VA = "0x202D910")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EA35")]
	[Address(RVA = "0x202D9B8", Offset = "0x202D9B8", VA = "0x202D9B8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EA36")]
	[Address(RVA = "0x202DB84", Offset = "0x202DB84", VA = "0x202DB84", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EA37")]
	[Address(RVA = "0x202DBE8", Offset = "0x202DBE8", VA = "0x202DBE8")]
	private void OnIAPBundleButtonClick()
	{
	}

	[Token(Token = "0x600EA38")]
	[Address(RVA = "0x202DE50", Offset = "0x202DE50", VA = "0x202DE50")]
	public void UpdateData()
	{
	}

	[Token(Token = "0x600EA39")]
	[Address(RVA = "0x202E188", Offset = "0x202E188", VA = "0x202E188")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EA3A")]
	[Address(RVA = "0x202E190", Offset = "0x202E190", VA = "0x202E190")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
