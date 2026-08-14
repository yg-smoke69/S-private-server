using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002AC0")]
internal class UIRelationshipBreakRequestConfirmController : UIPopupWindowController
{
	[Token(Token = "0x40106C2")]
	[FieldOffset(Offset = "0x48")]
	private UIRelationshipBreakRequsetConfirmView m_View;

	[Token(Token = "0x40106C3")]
	[FieldOffset(Offset = "0x4C")]
	private FriendAccountInfo m_TargetInfo;

	[Token(Token = "0x6011829")]
	[Address(RVA = "0x1E46508", Offset = "0x1E46508", VA = "0x1E46508")]
	public UIRelationshipBreakRequestConfirmController()
	{
	}

	[Token(Token = "0x601182A")]
	[Address(RVA = "0x1E46510", Offset = "0x1E46510", VA = "0x1E46510")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601182B")]
	[Address(RVA = "0x1E465B4", Offset = "0x1E465B4", VA = "0x1E465B4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601182C")]
	[Address(RVA = "0x1E46784", Offset = "0x1E46784", VA = "0x1E46784")]
	public void SetFriendData(FriendAccountInfo accountInfo, EFriend.RelationType relationType)
	{
	}

	[Token(Token = "0x601182D")]
	[Address(RVA = "0x1E46B68", Offset = "0x1E46B68", VA = "0x1E46B68")]
	private void OnCancelBtnClick()
	{
	}

	[Token(Token = "0x601182E")]
	[Address(RVA = "0x1E46CC8", Offset = "0x1E46CC8", VA = "0x1E46CC8")]
	private void OnConfirmBtnClick()
	{
	}

	[Token(Token = "0x601182F")]
	[Address(RVA = "0x1E46E28", Offset = "0x1E46E28", VA = "0x1E46E28")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
