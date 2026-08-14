using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200257B")]
public class UICommonErrorWndController : UIPopupWindowController
{
	[Token(Token = "0x400E7EE")]
	[FieldOffset(Offset = "0x48")]
	private UICommonErrorWndView m_View;

	[Token(Token = "0x400E7EF")]
	[FieldOffset(Offset = "0x4C")]
	private Action m_callback;

	[Token(Token = "0x600DB1C")]
	[Address(RVA = "0x2CDDEEC", Offset = "0x2CDDEEC", VA = "0x2CDDEEC")]
	public UICommonErrorWndController()
	{
	}

	[Token(Token = "0x600DB1D")]
	[Address(RVA = "0x2CDDEF4", Offset = "0x2CDDEF4", VA = "0x2CDDEF4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DB1E")]
	[Address(RVA = "0x2CDDF98", Offset = "0x2CDDF98", VA = "0x2CDDF98", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DB1F")]
	[Address(RVA = "0x2CDE0F4", Offset = "0x2CDE0F4", VA = "0x2CDE0F4")]
	public void SetInfo(string message, string title, Action callback)
	{
	}

	[Token(Token = "0x600DB20")]
	[Address(RVA = "0x2CDE31C", Offset = "0x2CDE31C", VA = "0x2CDE31C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600DB21")]
	[Address(RVA = "0x2CDE39C", Offset = "0x2CDE39C", VA = "0x2CDE39C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DB22")]
	[Address(RVA = "0x2CDE3A4", Offset = "0x2CDE3A4", VA = "0x2CDE3A4")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
