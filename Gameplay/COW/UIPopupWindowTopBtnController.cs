using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A7D")]
public class UIPopupWindowTopBtnController : UIBaseController
{
	[Token(Token = "0x4010502")]
	[FieldOffset(Offset = "0x28")]
	private UIPopupWindowTopBtnView m_View;

	[Token(Token = "0x60114B3")]
	[Address(RVA = "0xEF665C", Offset = "0xEF665C", VA = "0xEF665C")]
	public UIPopupWindowTopBtnController()
	{
	}

	[Token(Token = "0x60114B4")]
	[Address(RVA = "0xEF66E0", Offset = "0xEF66E0", VA = "0xEF66E0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60114B5")]
	[Address(RVA = "0xEF679C", Offset = "0xEF679C", VA = "0xEF679C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60114B6")]
	[Address(RVA = "0xEF6844", Offset = "0xEF6844", VA = "0xEF6844")]
	public void SetViewData(Callback onBtnClose)
	{
	}

	[Token(Token = "0x60114B7")]
	[Address(RVA = "0xEF699C", Offset = "0xEF699C", VA = "0xEF699C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
