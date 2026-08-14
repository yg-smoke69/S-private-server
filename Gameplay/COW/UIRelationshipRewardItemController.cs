using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002ACC")]
internal class UIRelationshipRewardItemController : UIBaseController
{
	[Token(Token = "0x40106E8")]
	[FieldOffset(Offset = "0x28")]
	private IntimacyAwardDesc m_desc;

	[Token(Token = "0x40106E9")]
	[FieldOffset(Offset = "0x2C")]
	private IntimacyRankAwardInfo m_info;

	[Token(Token = "0x40106EA")]
	[FieldOffset(Offset = "0x30")]
	private UIRelationshipRewardItemView m_View;

	[Token(Token = "0x40106EB")]
	[FieldOffset(Offset = "0x38")]
	private ulong m_AccountID;

	[Token(Token = "0x40106EC")]
	[FieldOffset(Offset = "0x40")]
	private AwardItemState curState;

	[Token(Token = "0x40106ED")]
	private const uint SpecialRankWithSpecialAwards = 5u;

	[Token(Token = "0x6011894")]
	[Address(RVA = "0x1E4FD68", Offset = "0x1E4FD68", VA = "0x1E4FD68")]
	public UIRelationshipRewardItemController()
	{
	}

	[Token(Token = "0x6011895")]
	[Address(RVA = "0x1E4FDEC", Offset = "0x1E4FDEC", VA = "0x1E4FDEC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011896")]
	[Address(RVA = "0x1E4FE90", Offset = "0x1E4FE90", VA = "0x1E4FE90", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011897")]
	[Address(RVA = "0x1E500D4", Offset = "0x1E500D4", VA = "0x1E500D4")]
	public void SetRewardItemInfo(IntimacyAwardDesc desc, IntimacyRankAwardInfo info, ulong accountID, AwardItemState state)
	{
	}

	[Token(Token = "0x6011898")]
	[Address(RVA = "0x1E50374", Offset = "0x1E50374", VA = "0x1E50374")]
	private void RefreshRewardState(AwardItemState state)
	{
	}

	[Token(Token = "0x6011899")]
	[Address(RVA = "0x1E50918", Offset = "0x1E50918", VA = "0x1E50918")]
	private void ReceeiveRewards()
	{
	}

	[Token(Token = "0x601189A")]
	[Address(RVA = "0x1E50178", Offset = "0x1E50178", VA = "0x1E50178")]
	public void SetLocalPosition()
	{
	}

	[Token(Token = "0x601189B")]
	[Address(RVA = "0x1E50BA8", Offset = "0x1E50BA8", VA = "0x1E50BA8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
