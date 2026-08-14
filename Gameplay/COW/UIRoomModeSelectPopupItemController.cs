using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002AF3")]
public class UIRoomModeSelectPopupItemController : UIEasyListItemController
{
	[Token(Token = "0x40107A9")]
	[FieldOffset(Offset = "0x38")]
	private UIRoomModeSelectPopupItemView m_View;

	[Token(Token = "0x40107AA")]
	[FieldOffset(Offset = "0x3C")]
	private FRoomModeSelectData m_Data;

	[Token(Token = "0x6011A00")]
	[Address(RVA = "0x23D2D20", Offset = "0x23D2D20", VA = "0x23D2D20")]
	public UIRoomModeSelectPopupItemController()
	{
	}

	[Token(Token = "0x6011A01")]
	[Address(RVA = "0x23D2D28", Offset = "0x23D2D28", VA = "0x23D2D28")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011A02")]
	[Address(RVA = "0x23D2DCC", Offset = "0x23D2DCC", VA = "0x23D2DCC", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6011A03")]
	[Address(RVA = "0x23D2FC8", Offset = "0x23D2FC8", VA = "0x23D2FC8")]
	public bool IsSelect()
	{
		return default(bool);
	}

	[Token(Token = "0x6011A04")]
	[Address(RVA = "0x23D3054", Offset = "0x23D3054", VA = "0x23D3054", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011A05")]
	[Address(RVA = "0x23D31B0", Offset = "0x23D31B0", VA = "0x23D31B0")]
	private void OnClickSelectBtn()
	{
	}

	[Token(Token = "0x6011A06")]
	[Address(RVA = "0x23D32D0", Offset = "0x23D32D0", VA = "0x23D32D0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
