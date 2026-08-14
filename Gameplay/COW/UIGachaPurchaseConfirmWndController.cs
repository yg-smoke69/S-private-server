using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002673")]
public class UIGachaPurchaseConfirmWndController : UIPopupWindowController
{
	[Token(Token = "0x400ED66")]
	[FieldOffset(Offset = "0x48")]
	private UIGachaPurchaseConfirmWndView m_View;

	[Token(Token = "0x400ED67")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelGacha.GachaDrawType m_DrawType;

	[Token(Token = "0x400ED68")]
	[FieldOffset(Offset = "0x50")]
	private bool m_IsRepurchase;

	[Token(Token = "0x400ED69")]
	[FieldOffset(Offset = "0x54")]
	private uint m_GachaID;

	[Token(Token = "0x400ED6A")]
	[FieldOffset(Offset = "0x0")]
	private static Color GemChestNameColor;

	[Token(Token = "0x400ED6B")]
	[FieldOffset(Offset = "0x10")]
	private static Color CoinChestNameColor;

	[Token(Token = "0x17001187")]
	public UIModelGacha.GachaDrawType DrawType
	{
		[Token(Token = "0x600E64F")]
		[Address(RVA = "0x2A26FD4", Offset = "0x2A26FD4", VA = "0x2A26FD4")]
		set
		{
		}
	}

	[Token(Token = "0x600E64E")]
	[Address(RVA = "0x2A26FCC", Offset = "0x2A26FCC", VA = "0x2A26FCC")]
	public UIGachaPurchaseConfirmWndController()
	{
	}

	[Token(Token = "0x600E650")]
	[Address(RVA = "0x2A27034", Offset = "0x2A27034", VA = "0x2A27034", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E651")]
	[Address(RVA = "0x2A27430", Offset = "0x2A27430", VA = "0x2A27430")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E652")]
	[Address(RVA = "0x2A274D4", Offset = "0x2A274D4", VA = "0x2A274D4")]
	public void RefreshUIData(bool isRepurchase, uint chestID)
	{
	}

	[Token(Token = "0x600E653")]
	[Address(RVA = "0x2A27D44", Offset = "0x2A27D44", VA = "0x2A27D44")]
	private void ShowDrawInfo(UIModelGacha.GachaDrawType m_drawType)
	{
	}

	[Token(Token = "0x600E654")]
	[Address(RVA = "0x2A2886C", Offset = "0x2A2886C", VA = "0x2A2886C")]
	private void RefreshIcon(EInventory.CurrencyType type, UIModelGacha.GachaDrawType drawType)
	{
	}

	[Token(Token = "0x600E655")]
	[Address(RVA = "0x2A28FC0", Offset = "0x2A28FC0", VA = "0x2A28FC0")]
	private void OnPurchaseBtnClick()
	{
	}

	[Token(Token = "0x600E656")]
	[Address(RVA = "0x2A292E8", Offset = "0x2A292E8", VA = "0x2A292E8")]
	private bool OnPurchaseBtnClickByEnter()
	{
		return default(bool);
	}

	[Token(Token = "0x600E657")]
	[Address(RVA = "0x2A2934C", Offset = "0x2A2934C", VA = "0x2A2934C")]
	private void OnNoShowBtnClick()
	{
	}

	[Token(Token = "0x600E658")]
	[Address(RVA = "0x2A294DC", Offset = "0x2A294DC", VA = "0x2A294DC", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E659")]
	[Address(RVA = "0x2A29684", Offset = "0x2A29684", VA = "0x2A29684", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E65B")]
	[Address(RVA = "0x2A2989C", Offset = "0x2A2989C", VA = "0x2A2989C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E65C")]
	[Address(RVA = "0x2A298A4", Offset = "0x2A298A4", VA = "0x2A298A4")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E65D")]
	[Address(RVA = "0x2A298AC", Offset = "0x2A298AC", VA = "0x2A298AC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
