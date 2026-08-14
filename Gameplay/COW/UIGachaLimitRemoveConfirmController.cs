using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002665")]
internal class UIGachaLimitRemoveConfirmController : UIPopupWindowController
{
	[Token(Token = "0x400ED24")]
	[FieldOffset(Offset = "0x48")]
	private UIGachaLimitRemoveConfrimWndView m_View;

	[Token(Token = "0x400ED25")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelGacha m_ModelGacha;

	[Token(Token = "0x400ED26")]
	[FieldOffset(Offset = "0x50")]
	private uint m_GachaID;

	[Token(Token = "0x400ED27")]
	[FieldOffset(Offset = "0x54")]
	private uint m_SubID;

	[Token(Token = "0x600E5A7")]
	[Address(RVA = "0x2A16730", Offset = "0x2A16730", VA = "0x2A16730")]
	public UIGachaLimitRemoveConfirmController()
	{
	}

	[Token(Token = "0x600E5A8")]
	[Address(RVA = "0x2A16738", Offset = "0x2A16738", VA = "0x2A16738")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E5A9")]
	[Address(RVA = "0x2A167DC", Offset = "0x2A167DC", VA = "0x2A167DC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E5AA")]
	[Address(RVA = "0x2A169A8", Offset = "0x2A169A8", VA = "0x2A169A8")]
	private void OnOKClick()
	{
	}

	[Token(Token = "0x600E5AB")]
	[Address(RVA = "0x2A16A38", Offset = "0x2A16A38", VA = "0x2A16A38")]
	public void SetViewData(uint gachaID, uint subID)
	{
	}

	[Token(Token = "0x600E5AC")]
	[Address(RVA = "0x2A16DC8", Offset = "0x2A16DC8", VA = "0x2A16DC8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
