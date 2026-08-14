using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002AC5")]
internal class UIRelationshipInviteConfirmController : UIPopupWindowController
{
	[Token(Token = "0x40106D2")]
	[FieldOffset(Offset = "0x48")]
	private UIRelationshipInviteConfirmView m_View;

	[Token(Token = "0x40106D3")]
	[FieldOffset(Offset = "0x4C")]
	private FriendAccountInfo m_TargetInfo;

	[Token(Token = "0x6011854")]
	[Address(RVA = "0x1E494E8", Offset = "0x1E494E8", VA = "0x1E494E8")]
	public UIRelationshipInviteConfirmController()
	{
	}

	[Token(Token = "0x6011855")]
	[Address(RVA = "0x1E494F0", Offset = "0x1E494F0", VA = "0x1E494F0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011856")]
	[Address(RVA = "0x1E49594", Offset = "0x1E49594", VA = "0x1E49594", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011857")]
	[Address(RVA = "0x1E49764", Offset = "0x1E49764", VA = "0x1E49764")]
	public void SetFriendData(FriendAccountInfo accountInfo, EFriend.RelationType relationType)
	{
	}

	[Token(Token = "0x6011858")]
	[Address(RVA = "0x1E49B14", Offset = "0x1E49B14", VA = "0x1E49B14")]
	private void OnCancelBtnClick()
	{
	}

	[Token(Token = "0x6011859")]
	[Address(RVA = "0x1E49B78", Offset = "0x1E49B78", VA = "0x1E49B78")]
	private void OnConfirmBtnClick()
	{
	}

	[Token(Token = "0x601185A")]
	[Address(RVA = "0x1E49CD8", Offset = "0x1E49CD8", VA = "0x1E49CD8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
