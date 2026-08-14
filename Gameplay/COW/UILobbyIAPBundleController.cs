using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002925")]
public class UILobbyIAPBundleController : UIBaseController
{
	[Token(Token = "0x400FD72")]
	[FieldOffset(Offset = "0x28")]
	private UILobbyIAPBundleView m_View;

	[Token(Token = "0x400FD73")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelIAPBundle m_Model;

	[Token(Token = "0x601058B")]
	[Address(RVA = "0xDB3030", Offset = "0xDB3030", VA = "0xDB3030")]
	public UILobbyIAPBundleController()
	{
	}

	[Token(Token = "0x601058C")]
	[Address(RVA = "0xDB30B4", Offset = "0xDB30B4", VA = "0xDB30B4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601058D")]
	[Address(RVA = "0xDB315C", Offset = "0xDB315C", VA = "0xDB315C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601058E")]
	[Address(RVA = "0xDB3328", Offset = "0xDB3328", VA = "0xDB3328", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x601058F")]
	[Address(RVA = "0xDB338C", Offset = "0xDB338C", VA = "0xDB338C")]
	private void OnIAPBundleButtonClick()
	{
	}

	[Token(Token = "0x6010590")]
	[Address(RVA = "0xDB35F4", Offset = "0xDB35F4", VA = "0xDB35F4")]
	public void UpdateData()
	{
	}

	[Token(Token = "0x6010591")]
	[Address(RVA = "0xDB392C", Offset = "0xDB392C", VA = "0xDB392C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010592")]
	[Address(RVA = "0xDB3934", Offset = "0xDB3934", VA = "0xDB3934")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
