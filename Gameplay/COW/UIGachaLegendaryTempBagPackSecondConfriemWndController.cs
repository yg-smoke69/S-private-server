using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002648")]
public class UIGachaLegendaryTempBagPackSecondConfriemWndController : UIPopupWindowController
{
	[Token(Token = "0x400EC72")]
	[FieldOffset(Offset = "0x48")]
	private uint m_GachaID;

	[Token(Token = "0x400EC73")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelGacha m_Model;

	[Token(Token = "0x400EC74")]
	[FieldOffset(Offset = "0x50")]
	private UIGachaLegendaryTempBagPackSecondConfriemWndView m_View;

	[Token(Token = "0x400EC75")]
	[FieldOffset(Offset = "0x54")]
	private List<uint> m_List;

	[Token(Token = "0x600E461")]
	[Address(RVA = "0x2E6AD10", Offset = "0x2E6AD10", VA = "0x2E6AD10")]
	public UIGachaLegendaryTempBagPackSecondConfriemWndController()
	{
	}

	[Token(Token = "0x600E462")]
	[Address(RVA = "0x2E6AD18", Offset = "0x2E6AD18", VA = "0x2E6AD18")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E463")]
	[Address(RVA = "0x2E6ADBC", Offset = "0x2E6ADBC", VA = "0x2E6ADBC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E464")]
	[Address(RVA = "0x2E6B0A8", Offset = "0x2E6B0A8", VA = "0x2E6B0A8")]
	private void OnToggleClick()
	{
	}

	[Token(Token = "0x600E465")]
	[Address(RVA = "0x2E6B194", Offset = "0x2E6B194", VA = "0x2E6B194")]
	public void SetView(uint gachaID, string text, List<uint> list)
	{
	}

	[Token(Token = "0x600E466")]
	[Address(RVA = "0x2E6B250", Offset = "0x2E6B250", VA = "0x2E6B250")]
	private void OnCancelClick()
	{
	}

	[Token(Token = "0x600E467")]
	[Address(RVA = "0x2E6B2B4", Offset = "0x2E6B2B4", VA = "0x2E6B2B4")]
	private void OnConfirmClick()
	{
	}

	[Token(Token = "0x600E468")]
	[Address(RVA = "0x2E6B3B0", Offset = "0x2E6B3B0", VA = "0x2E6B3B0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
