using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW.UI.Controller;

[Token(Token = "0x200255D")]
public class UIClanWarMarchTeamPresenceWndController : UIPopupWindowController
{
	[Token(Token = "0x400E762")]
	[FieldOffset(Offset = "0x48")]
	private UIClanWarMarchTeamPresenceWndView m_View;

	[Token(Token = "0x600DA11")]
	[Address(RVA = "0x29F6520", Offset = "0x29F6520", VA = "0x29F6520")]
	public UIClanWarMarchTeamPresenceWndController()
	{
	}

	[Token(Token = "0x600DA12")]
	[Address(RVA = "0x29F6528", Offset = "0x29F6528", VA = "0x29F6528")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DA13")]
	[Address(RVA = "0x29F6590", Offset = "0x29F6590", VA = "0x29F6590", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DA14")]
	[Address(RVA = "0x29F6858", Offset = "0x29F6858", VA = "0x29F6858")]
	public void SetOfflineMemberList(List<ulong> memberList)
	{
	}

	[Token(Token = "0x600DA15")]
	[Address(RVA = "0x29F66F8", Offset = "0x29F66F8", VA = "0x29F66F8")]
	private void AddClicks()
	{
	}

	[Token(Token = "0x600DA16")]
	[Address(RVA = "0x29F6BE0", Offset = "0x29F6BE0", VA = "0x29F6BE0")]
	private void OnBtnConfirmClick()
	{
	}
}
