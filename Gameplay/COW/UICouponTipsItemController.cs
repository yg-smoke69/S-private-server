using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200262B")]
internal class UICouponTipsItemController : UIBaseController
{
	[Token(Token = "0x400EBBC")]
	[FieldOffset(Offset = "0x28")]
	private UICouponTipsItemView m_View;

	[Token(Token = "0x400EBBD")]
	[FieldOffset(Offset = "0x2C")]
	private UIStandardItemMiniController m_ItemController;

	[Token(Token = "0x400EBBE")]
	[FieldOffset(Offset = "0x30")]
	private UICountDownController m_Ctrl;

	[Token(Token = "0x600E2B1")]
	[Address(RVA = "0x1EC3268", Offset = "0x1EC3268", VA = "0x1EC3268")]
	public UICouponTipsItemController()
	{
	}

	[Token(Token = "0x600E2B2")]
	[Address(RVA = "0x1EC32EC", Offset = "0x1EC32EC", VA = "0x1EC32EC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E2B3")]
	[Address(RVA = "0x1EC3394", Offset = "0x1EC3394", VA = "0x1EC3394", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E2B4")]
	[Address(RVA = "0x1EC3450", Offset = "0x1EC3450", VA = "0x1EC3450")]
	public void SetData(Item item)
	{
	}

	[Token(Token = "0x600E2B5")]
	[Address(RVA = "0x1EC38FC", Offset = "0x1EC38FC", VA = "0x1EC38FC")]
	private void _003CSetData_003Em__0()
	{
	}

	[Token(Token = "0x600E2B6")]
	[Address(RVA = "0x1EC3930", Offset = "0x1EC3930", VA = "0x1EC3930")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
