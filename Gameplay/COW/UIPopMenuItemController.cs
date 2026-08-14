using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A6F")]
public class UIPopMenuItemController : UIBaseController
{
	[Token(Token = "0x40104A9")]
	[FieldOffset(Offset = "0x28")]
	private UIPopMenuItemView m_View;

	[Token(Token = "0x40104AA")]
	[FieldOffset(Offset = "0x2C")]
	private PopMenuData m_Data;

	[Token(Token = "0x601144C")]
	[Address(RVA = "0x2C5DE40", Offset = "0x2C5DE40", VA = "0x2C5DE40")]
	public UIPopMenuItemController()
	{
	}

	[Token(Token = "0x601144D")]
	[Address(RVA = "0x2C5DEC4", Offset = "0x2C5DEC4", VA = "0x2C5DEC4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601144E")]
	[Address(RVA = "0x2C5DF68", Offset = "0x2C5DF68", VA = "0x2C5DF68", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601144F")]
	[Address(RVA = "0x2C5CB1C", Offset = "0x2C5CB1C", VA = "0x2C5CB1C")]
	public void SetItemData(PopMenuData data, int CellWidth, int CellHeight, float itemLocalPositionX, Alignment labelAlignment, Pivot labelPivot)
	{
	}

	[Token(Token = "0x6011450")]
	[Address(RVA = "0x2C5E0C4", Offset = "0x2C5E0C4", VA = "0x2C5E0C4")]
	private void SetSelectedState(bool selected)
	{
	}

	[Token(Token = "0x6011451")]
	[Address(RVA = "0x2C5E22C", Offset = "0x2C5E22C", VA = "0x2C5E22C")]
	private void OnPopMenuItemClick()
	{
	}

	[Token(Token = "0x6011452")]
	[Address(RVA = "0x2C5E3BC", Offset = "0x2C5E3BC", VA = "0x2C5E3BC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
