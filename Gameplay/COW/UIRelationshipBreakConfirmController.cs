using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002ABF")]
internal class UIRelationshipBreakConfirmController : UIPopupWindowController
{
	[Token(Token = "0x40106BF")]
	[FieldOffset(Offset = "0x48")]
	private UIRelationshipBreakConfirmView m_View;

	[Token(Token = "0x40106C0")]
	[FieldOffset(Offset = "0x4C")]
	private FriendAccountInfo m_TargetInfo;

	[Token(Token = "0x40106C1")]
	[FieldOffset(Offset = "0x50")]
	private ulong m_FriendID;

	[Token(Token = "0x6011822")]
	[Address(RVA = "0x1E45A58", Offset = "0x1E45A58", VA = "0x1E45A58")]
	public UIRelationshipBreakConfirmController()
	{
	}

	[Token(Token = "0x6011823")]
	[Address(RVA = "0x1E45A60", Offset = "0x1E45A60", VA = "0x1E45A60")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011824")]
	[Address(RVA = "0x1E45B04", Offset = "0x1E45B04", VA = "0x1E45B04", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011825")]
	[Address(RVA = "0x1E45CD4", Offset = "0x1E45CD4", VA = "0x1E45CD4")]
	public void SetFriendData(FriendAccountInfo accountInfo, ulong friendID, EFriend.RelationType relationType)
	{
	}

	[Token(Token = "0x6011826")]
	[Address(RVA = "0x1E460D8", Offset = "0x1E460D8", VA = "0x1E460D8")]
	private void OnCancelBtnClick()
	{
	}

	[Token(Token = "0x6011827")]
	[Address(RVA = "0x1E4613C", Offset = "0x1E4613C", VA = "0x1E4613C")]
	private void OnConfirmBtnClick()
	{
	}

	[Token(Token = "0x6011828")]
	[Address(RVA = "0x1E46288", Offset = "0x1E46288", VA = "0x1E46288")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
