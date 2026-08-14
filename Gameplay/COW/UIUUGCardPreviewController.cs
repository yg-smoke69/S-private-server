using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002BC9")]
public class UIUUGCardPreviewController : UIPopupWindowController
{
	[Token(Token = "0x4010B9C")]
	[FieldOffset(Offset = "0x48")]
	private UIUUGCardPreViewView m_View;

	[Token(Token = "0x4010B9D")]
	[FieldOffset(Offset = "0x4C")]
	private uint card1;

	[Token(Token = "0x4010B9E")]
	[FieldOffset(Offset = "0x50")]
	private uint card2;

	[Token(Token = "0x4010B9F")]
	[FieldOffset(Offset = "0x54")]
	private uint card3;

	[Token(Token = "0x4010BA0")]
	[FieldOffset(Offset = "0x58")]
	private uint card4;

	[Token(Token = "0x60121CF")]
	[Address(RVA = "0xF44A48", Offset = "0xF44A48", VA = "0xF44A48")]
	public UIUUGCardPreviewController()
	{
	}

	[Token(Token = "0x60121D0")]
	[Address(RVA = "0xF44A70", Offset = "0xF44A70", VA = "0xF44A70")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60121D1")]
	[Address(RVA = "0xF44B18", Offset = "0xF44B18", VA = "0xF44B18", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60121D2")]
	[Address(RVA = "0xF44BD4", Offset = "0xF44BD4", VA = "0xF44BD4", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x60121D3")]
	[Address(RVA = "0xF44C38", Offset = "0xF44C38", VA = "0xF44C38")]
	public void RefreshAllUI()
	{
	}

	[Token(Token = "0x60121D4")]
	[Address(RVA = "0xF44F8C", Offset = "0xF44F8C", VA = "0xF44F8C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60121D5")]
	[Address(RVA = "0xF44F94", Offset = "0xF44F94", VA = "0xF44F94")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
