using COW;
using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x2002659")]
public class UIGachaLimitChestSecondConfirmPopUpController : UIPopupWindowController
{
	[Token(Token = "0x400ECDF")]
	[FieldOffset(Offset = "0x46")]
	private bool m_bIsInit;

	[Token(Token = "0x400ECE0")]
	[FieldOffset(Offset = "0x48")]
	private int m_gachaID;

	[Token(Token = "0x400ECE1")]
	[FieldOffset(Offset = "0x4C")]
	private int m_uFirstItemID;

	[Token(Token = "0x400ECE2")]
	[FieldOffset(Offset = "0x50")]
	private int m_uSecondItemID;

	[Token(Token = "0x400ECE3")]
	[FieldOffset(Offset = "0x54")]
	private UIGachaLimitChestSecondConfirmView m_View;

	[Token(Token = "0x600E529")]
	[Address(RVA = "0x1474348", Offset = "0x1474348", VA = "0x1474348")]
	public UIGachaLimitChestSecondConfirmPopUpController()
	{
	}

	[Token(Token = "0x600E52A")]
	[Address(RVA = "0x1474360", Offset = "0x1474360", VA = "0x1474360")]
	private void RefreshUI()
	{
	}

	[Token(Token = "0x600E52B")]
	[Address(RVA = "0x1474770", Offset = "0x1474770", VA = "0x1474770")]
	public void Init(int gachaID, int itemID, int otherItemID)
	{
	}

	[Token(Token = "0x600E52C")]
	[Address(RVA = "0x147477C", Offset = "0x147477C", VA = "0x147477C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E52D")]
	[Address(RVA = "0x1474904", Offset = "0x1474904", VA = "0x1474904")]
	private void OnClickConfirm()
	{
	}

	[Token(Token = "0x600E52E")]
	[Address(RVA = "0x1474A10", Offset = "0x1474A10", VA = "0x1474A10")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}
}
