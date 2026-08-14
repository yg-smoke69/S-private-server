using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022D0")]
public class UIHudReaperIntroInfoController : UIBaseController
{
	[Token(Token = "0x400D97D")]
	[FieldOffset(Offset = "0x28")]
	private UIHudReaperIntroInfoView m_View;

	[Token(Token = "0x400D97E")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCallId;

	[Token(Token = "0x600BFCC")]
	[Address(RVA = "0x1FDB980", Offset = "0x1FDB980", VA = "0x1FDB980")]
	public UIHudReaperIntroInfoController()
	{
	}

	[Token(Token = "0x600BFCD")]
	[Address(RVA = "0x1FDBA04", Offset = "0x1FDBA04", VA = "0x1FDBA04")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BFCE")]
	[Address(RVA = "0x1FDBAAC", Offset = "0x1FDBAAC", VA = "0x1FDBAAC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BFCF")]
	[Address(RVA = "0x1FDBE54", Offset = "0x1FDBE54", VA = "0x1FDBE54", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600BFD0")]
	[Address(RVA = "0x1FDBF70", Offset = "0x1FDBF70", VA = "0x1FDBF70")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600BFD1")]
	[Address(RVA = "0x1FDC0C4", Offset = "0x1FDC0C4", VA = "0x1FDC0C4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BFD2")]
	[Address(RVA = "0x1FDC0CC", Offset = "0x1FDC0CC", VA = "0x1FDC0CC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
