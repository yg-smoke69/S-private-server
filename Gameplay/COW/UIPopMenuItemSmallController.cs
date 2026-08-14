using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A70")]
public class UIPopMenuItemSmallController : UIBaseController
{
	[Token(Token = "0x40104AB")]
	[FieldOffset(Offset = "0x28")]
	private UIPopMenuItemSmallView m_View;

	[Token(Token = "0x40104AC")]
	[FieldOffset(Offset = "0x2C")]
	private PopMenuData m_Data;

	[Token(Token = "0x6011453")]
	[Address(RVA = "0x2C5E3C4", Offset = "0x2C5E3C4", VA = "0x2C5E3C4")]
	public UIPopMenuItemSmallController()
	{
	}

	[Token(Token = "0x6011454")]
	[Address(RVA = "0x2C5E448", Offset = "0x2C5E448", VA = "0x2C5E448")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011455")]
	[Address(RVA = "0x2C5E4EC", Offset = "0x2C5E4EC", VA = "0x2C5E4EC")]
	public void SetDragDisable()
	{
	}

	[Token(Token = "0x6011456")]
	[Address(RVA = "0x2C5E57C", Offset = "0x2C5E57C", VA = "0x2C5E57C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011457")]
	[Address(RVA = "0x2C5E6D8", Offset = "0x2C5E6D8", VA = "0x2C5E6D8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011458")]
	[Address(RVA = "0x2C5E73C", Offset = "0x2C5E73C", VA = "0x2C5E73C")]
	public void SetItemData(PopMenuData data)
	{
	}

	[Token(Token = "0x6011459")]
	[Address(RVA = "0x2C5F4C4", Offset = "0x2C5F4C4", VA = "0x2C5F4C4")]
	public void SetLabelModifier(Modifier modifier)
	{
	}

	[Token(Token = "0x601145A")]
	[Address(RVA = "0x2C5F55C", Offset = "0x2C5F55C", VA = "0x2C5F55C")]
	public void SetCellWidthWithParent(int width)
	{
	}

	[Token(Token = "0x601145B")]
	[Address(RVA = "0x2C5F5F4", Offset = "0x2C5F5F4", VA = "0x2C5F5F4")]
	private void OnPopMenuItemClick()
	{
	}

	[Token(Token = "0x601145C")]
	[Address(RVA = "0x2C5F974", Offset = "0x2C5F974", VA = "0x2C5F974")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601145D")]
	[Address(RVA = "0x2C5F97C", Offset = "0x2C5F97C", VA = "0x2C5F97C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
