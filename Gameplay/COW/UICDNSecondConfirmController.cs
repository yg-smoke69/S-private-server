using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023B0")]
public class UICDNSecondConfirmController : UIPopupWindowController
{
	[Token(Token = "0x400DE35")]
	[FieldOffset(Offset = "0x48")]
	private UICDNSecondConfirmView m_View;

	[Token(Token = "0x600C8C0")]
	[Address(RVA = "0x1449488", Offset = "0x1449488", VA = "0x1449488")]
	public UICDNSecondConfirmController()
	{
	}

	[Token(Token = "0x600C8C1")]
	[Address(RVA = "0x1449490", Offset = "0x1449490", VA = "0x1449490")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C8C2")]
	[Address(RVA = "0x1449534", Offset = "0x1449534", VA = "0x1449534", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C8C3")]
	[Address(RVA = "0x14498CC", Offset = "0x14498CC", VA = "0x14498CC")]
	public void SetViewData(string contentKey, string titleKey = "", [Optional] Callback onConfirmClick)
	{
	}

	[Token(Token = "0x600C8C4")]
	[Address(RVA = "0x1449698", Offset = "0x1449698", VA = "0x1449698")]
	private void SetCDNTexture()
	{
	}

	[Token(Token = "0x600C8C5")]
	[Address(RVA = "0x1449B50", Offset = "0x1449B50", VA = "0x1449B50")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
