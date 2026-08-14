using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002A42")]
public class UIPaymentTotalContentItemController : UIBaseController
{
	[Token(Token = "0x40103D0")]
	[FieldOffset(Offset = "0x28")]
	private UIPaymentTotalContentItemView m_View;

	[Token(Token = "0x40103D1")]
	[FieldOffset(Offset = "0x2C")]
	private UIStandardItemMiniController m_UIStandardItemMiniController;

	[Token(Token = "0x601125D")]
	[Address(RVA = "0x23DC084", Offset = "0x23DC084", VA = "0x23DC084")]
	public UIPaymentTotalContentItemController()
	{
	}

	[Token(Token = "0x601125E")]
	[Address(RVA = "0x23DC108", Offset = "0x23DC108", VA = "0x23DC108")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601125F")]
	[Address(RVA = "0x23DC1B0", Offset = "0x23DC1B0", VA = "0x23DC1B0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011260")]
	[Address(RVA = "0x23DC31C", Offset = "0x23DC31C", VA = "0x23DC31C")]
	public void SetData(AwardDesc award, bool claimed)
	{
	}

	[Token(Token = "0x6011261")]
	[Address(RVA = "0x23DC4D0", Offset = "0x23DC4D0", VA = "0x23DC4D0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
