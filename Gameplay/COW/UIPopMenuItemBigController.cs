using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A6E")]
public class UIPopMenuItemBigController : UIBaseController
{
	[Token(Token = "0x40104A7")]
	[FieldOffset(Offset = "0x28")]
	private UIPopMenuItemBigView m_View;

	[Token(Token = "0x40104A8")]
	[FieldOffset(Offset = "0x2C")]
	private PopMenuData m_Data;

	[Token(Token = "0x6011442")]
	[Address(RVA = "0x2C5D468", Offset = "0x2C5D468", VA = "0x2C5D468")]
	public UIPopMenuItemBigController()
	{
	}

	[Token(Token = "0x6011443")]
	[Address(RVA = "0x2C5D4EC", Offset = "0x2C5D4EC", VA = "0x2C5D4EC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011444")]
	[Address(RVA = "0x2C5D590", Offset = "0x2C5D590", VA = "0x2C5D590", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011445")]
	[Address(RVA = "0x2C5D6EC", Offset = "0x2C5D6EC", VA = "0x2C5D6EC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011446")]
	[Address(RVA = "0x2C596CC", Offset = "0x2C596CC", VA = "0x2C596CC")]
	public void SetDragDisable()
	{
	}

	[Token(Token = "0x6011447")]
	[Address(RVA = "0x2C59134", Offset = "0x2C59134", VA = "0x2C59134")]
	public void SetItemData(PopMenuData data)
	{
	}

	[Token(Token = "0x6011448")]
	[Address(RVA = "0x2C59634", Offset = "0x2C59634", VA = "0x2C59634")]
	public void SetCellWidthWithParent(int width)
	{
	}

	[Token(Token = "0x6011449")]
	[Address(RVA = "0x2C5D750", Offset = "0x2C5D750", VA = "0x2C5D750")]
	private void OnPopMenuItemClick()
	{
	}

	[Token(Token = "0x601144A")]
	[Address(RVA = "0x2C5DAA4", Offset = "0x2C5DAA4", VA = "0x2C5DAA4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601144B")]
	[Address(RVA = "0x2C5DAAC", Offset = "0x2C5DAAC", VA = "0x2C5DAAC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
