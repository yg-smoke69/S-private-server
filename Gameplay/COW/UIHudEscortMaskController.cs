using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002743")]
public class UIHudEscortMaskController : UIBaseController
{
	[Token(Token = "0x400F244")]
	[FieldOffset(Offset = "0x28")]
	private UIHudEscortMaskView m_View;

	[Token(Token = "0x400F245")]
	[FieldOffset(Offset = "0x2C")]
	private POECKIDCBKC m_Game;

	[Token(Token = "0x600EF78")]
	[Address(RVA = "0x1B93FCC", Offset = "0x1B93FCC", VA = "0x1B93FCC")]
	public UIHudEscortMaskController()
	{
	}

	[Token(Token = "0x600EF79")]
	[Address(RVA = "0x1B94050", Offset = "0x1B94050", VA = "0x1B94050")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EF7A")]
	[Address(RVA = "0x1B940F8", Offset = "0x1B940F8", VA = "0x1B940F8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EF7B")]
	[Address(RVA = "0x1B942BC", Offset = "0x1B942BC", VA = "0x1B942BC")]
	private void UpdateAlpha(float alpha)
	{
	}

	[Token(Token = "0x600EF7C")]
	[Address(RVA = "0x1B9435C", Offset = "0x1B9435C", VA = "0x1B9435C")]
	private void Update()
	{
	}

	[Token(Token = "0x600EF7D")]
	[Address(RVA = "0x1B945C8", Offset = "0x1B945C8", VA = "0x1B945C8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
