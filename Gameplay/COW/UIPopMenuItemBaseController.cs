using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A6D")]
public class UIPopMenuItemBaseController : UIBaseController
{
	[Token(Token = "0x40104A6")]
	[FieldOffset(Offset = "0x28")]
	public uint ItemIdex;

	[Token(Token = "0x601143E")]
	[Address(RVA = "0x2C5D274", Offset = "0x2C5D274", VA = "0x2C5D274")]
	public UIPopMenuItemBaseController()
	{
	}

	[Token(Token = "0x601143F")]
	[Address(RVA = "0x2C5D2F8", Offset = "0x2C5D2F8", VA = "0x2C5D2F8", Slot = "31")]
	public virtual void SetItemData(PopMenuData data)
	{
	}

	[Token(Token = "0x6011440")]
	[Address(RVA = "0x2C5D354", Offset = "0x2C5D354", VA = "0x2C5D354", Slot = "32")]
	public virtual void SetItemData(PopMenuData data, int CellWidth, int CellHeight)
	{
	}

	[Token(Token = "0x6011441")]
	[Address(RVA = "0x2C5D3C8", Offset = "0x2C5D3C8", VA = "0x2C5D3C8", Slot = "33")]
	public virtual void SetItemData(PopMenuData data, int CellWidth, int CellHeight, float itemLocalPositionX, Alignment labelAlignment, Pivot labelPivot)
	{
	}
}
