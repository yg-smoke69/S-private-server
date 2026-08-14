using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002926")]
public class UILobbyIAPWeekCardController : UIBaseController
{
	[Token(Token = "0x400FD74")]
	[FieldOffset(Offset = "0x28")]
	private UILobbyIAPWeekCardView m_View;

	[Token(Token = "0x400FD75")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelIAPBundle m_Model;

	[Token(Token = "0x6010593")]
	[Address(RVA = "0xDB3BB4", Offset = "0xDB3BB4", VA = "0xDB3BB4")]
	public UILobbyIAPWeekCardController()
	{
	}

	[Token(Token = "0x6010594")]
	[Address(RVA = "0xDB3C38", Offset = "0xDB3C38", VA = "0xDB3C38")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010595")]
	[Address(RVA = "0xDB3CE0", Offset = "0xDB3CE0", VA = "0xDB3CE0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010596")]
	[Address(RVA = "0xDB3EAC", Offset = "0xDB3EAC", VA = "0xDB3EAC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010597")]
	[Address(RVA = "0xDB3F10", Offset = "0xDB3F10", VA = "0xDB3F10")]
	private void OnIAPBundleButtonClick()
	{
	}

	[Token(Token = "0x6010598")]
	[Address(RVA = "0xDB40F4", Offset = "0xDB40F4", VA = "0xDB40F4")]
	public void UpdateData()
	{
	}

	[Token(Token = "0x6010599")]
	[Address(RVA = "0xDB442C", Offset = "0xDB442C", VA = "0xDB442C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601059A")]
	[Address(RVA = "0xDB4434", Offset = "0xDB4434", VA = "0xDB4434")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
