using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A69")]
public class UIPopMenuBigController : UIPopMenuSmallControler
{
	[Token(Token = "0x4010495")]
	[FieldOffset(Offset = "0x64")]
	private List<UIPopMenuItemBigController> m_UIPopMenuItemBigControllerList;

	[Token(Token = "0x4010496")]
	public const int BIGCELLHEIGHT = 46;

	[Token(Token = "0x4010497")]
	public new const int FIXEDSPACE = 2;

	[Token(Token = "0x4010498")]
	[FieldOffset(Offset = "0x68")]
	private new UIPopMenuBigView m_View;

	[Token(Token = "0x601141E")]
	[Address(RVA = "0x2C57068", Offset = "0x2C57068", VA = "0x2C57068")]
	public UIPopMenuBigController()
	{
	}

	[Token(Token = "0x601141F")]
	[Address(RVA = "0x2C571C0", Offset = "0x2C571C0", VA = "0x2C571C0")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011420")]
	[Address(RVA = "0x2C57264", Offset = "0x2C57264", VA = "0x2C57264", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011421")]
	[Address(RVA = "0x2C5761C", Offset = "0x2C5761C", VA = "0x2C5761C", Slot = "38")]
	protected override void AdjustScrollView()
	{
	}

	[Token(Token = "0x6011422")]
	[Address(RVA = "0x2C57AAC", Offset = "0x2C57AAC", VA = "0x2C57AAC", Slot = "41")]
	public override void ShowPopUpItem()
	{
	}

	[Token(Token = "0x6011423")]
	[Address(RVA = "0x2C5975C", Offset = "0x2C5975C", VA = "0x2C5975C", Slot = "44")]
	protected override void OnPopMenuClose()
	{
	}

	[Token(Token = "0x6011424")]
	[Address(RVA = "0x2C59AF0", Offset = "0x2C59AF0", VA = "0x2C59AF0")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011425")]
	[Address(RVA = "0x2C59AF4", Offset = "0x2C59AF4", VA = "0x2C59AF4")]
	public void _003C_003EiFixBaseProxy_AdjustScrollView()
	{
	}

	[Token(Token = "0x6011426")]
	[Address(RVA = "0x2C59F88", Offset = "0x2C59F88", VA = "0x2C59F88")]
	public void _003C_003EiFixBaseProxy_ShowPopUpItem()
	{
	}

	[Token(Token = "0x6011427")]
	[Address(RVA = "0x2C5B4B0", Offset = "0x2C5B4B0", VA = "0x2C5B4B0")]
	public void _003C_003EiFixBaseProxy_OnPopMenuClose()
	{
	}
}
