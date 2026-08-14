using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002708")]
public class UIHUDChangeSeatConfirmController : UIBaseController
{
	[Token(Token = "0x400F0ED")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDChangeSeatConfirmView m_View;

	[Token(Token = "0x400F0EE")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_CallID;

	[Token(Token = "0x400F0EF")]
	[FieldOffset(Offset = "0x30")]
	private string m_TeammateName;

	[Token(Token = "0x600ED1F")]
	[Address(RVA = "0x16761DC", Offset = "0x16761DC", VA = "0x16761DC")]
	public UIHUDChangeSeatConfirmController()
	{
	}

	[Token(Token = "0x600ED20")]
	[Address(RVA = "0x16762A8", Offset = "0x16762A8", VA = "0x16762A8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600ED21")]
	[Address(RVA = "0x1676350", Offset = "0x1676350", VA = "0x1676350", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600ED22")]
	[Address(RVA = "0x16765BC", Offset = "0x16765BC", VA = "0x16765BC")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x600ED23")]
	[Address(RVA = "0x16766C8", Offset = "0x16766C8", VA = "0x16766C8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600ED24")]
	[Address(RVA = "0x1676864", Offset = "0x1676864", VA = "0x1676864")]
	private void OnChangeSeatConfirm(object[] data)
	{
	}

	[Token(Token = "0x600ED25")]
	[Address(RVA = "0x16768E0", Offset = "0x16768E0", VA = "0x16768E0")]
	private void OnAskChangeSeat(object[] data)
	{
	}

	[Token(Token = "0x600ED26")]
	[Address(RVA = "0x1677024", Offset = "0x1677024", VA = "0x1677024")]
	private void _003COnAskChangeSeat_003Em__0()
	{
	}

	[Token(Token = "0x600ED27")]
	[Address(RVA = "0x167703C", Offset = "0x167703C", VA = "0x167703C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600ED28")]
	[Address(RVA = "0x1677044", Offset = "0x1677044", VA = "0x1677044")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
