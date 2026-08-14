using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20021C0")]
public class UIGiftLeaderBoardRewardItemController : UIEasyListItemController
{
	[Token(Token = "0x20021C1")]
	private enum ERewardState
	{
		[Token(Token = "0x400D33C")]
		None,
		[Token(Token = "0x400D33D")]
		UnClaimed,
		[Token(Token = "0x400D33E")]
		Claimed,
		[Token(Token = "0x400D33F")]
		Cant
	}

	[Token(Token = "0x400D330")]
	[FieldOffset(Offset = "0x38")]
	private UIGiftLeaderBoardRewardItemView m_View;

	[Token(Token = "0x400D331")]
	[FieldOffset(Offset = "0x3C")]
	private GiftRewardDesc m_RewardDesc;

	[Token(Token = "0x400D332")]
	[FieldOffset(Offset = "0x40")]
	private UIGiftLeaderBoardController m_ParentController;

	[Token(Token = "0x400D333")]
	[FieldOffset(Offset = "0x44")]
	private UIModelGift m_ModelGift;

	[Token(Token = "0x400D334")]
	[FieldOffset(Offset = "0x48")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x400D335")]
	[FieldOffset(Offset = "0x4C")]
	private ERewardState m_State;

	[Token(Token = "0x400D336")]
	[FieldOffset(Offset = "0x50")]
	private BaseItemInfo m_ItemInfo;

	[Token(Token = "0x400D337")]
	[FieldOffset(Offset = "0x54")]
	private uint m_GiftItemCount;

	[Token(Token = "0x400D338")]
	[FieldOffset(Offset = "0x58")]
	private int m_RewardCount;

	[Token(Token = "0x400D339")]
	private const uint CLAIMED_ITEM_GREY = 2526451455u;

	[Token(Token = "0x400D33A")]
	private const uint ITEM_WHITE = uint.MaxValue;

	[Token(Token = "0x600B447")]
	[Address(RVA = "0x1CEA844", Offset = "0x1CEA844", VA = "0x1CEA844")]
	public UIGiftLeaderBoardRewardItemController()
	{
	}

	[Token(Token = "0x600B448")]
	[Address(RVA = "0x1CEA84C", Offset = "0x1CEA84C", VA = "0x1CEA84C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B449")]
	[Address(RVA = "0x1CEA8F4", Offset = "0x1CEA8F4", VA = "0x1CEA8F4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B44A")]
	[Address(RVA = "0x1CEAB04", Offset = "0x1CEAB04", VA = "0x1CEAB04", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600B44B")]
	[Address(RVA = "0x1CEAF34", Offset = "0x1CEAF34", VA = "0x1CEAF34", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B44C")]
	[Address(RVA = "0x1CEAF98", Offset = "0x1CEAF98", VA = "0x1CEAF98", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600B44D")]
	[Address(RVA = "0x1CEB9F4", Offset = "0x1CEB9F4", VA = "0x1CEB9F4")]
	public void SetRewardInfo(uint giftItemCount, int rewardCount)
	{
	}

	[Token(Token = "0x600B44E")]
	[Address(RVA = "0x1CEB1B0", Offset = "0x1CEB1B0", VA = "0x1CEB1B0")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600B44F")]
	[Address(RVA = "0x1CEBCDC", Offset = "0x1CEBCDC", VA = "0x1CEBCDC")]
	private void SetItemCanClaimState()
	{
	}

	[Token(Token = "0x600B450")]
	[Address(RVA = "0x1CEBA74", Offset = "0x1CEBA74", VA = "0x1CEBA74")]
	private void ResetItemView()
	{
	}

	[Token(Token = "0x600B451")]
	[Address(RVA = "0x1CEBDDC", Offset = "0x1CEBDDC", VA = "0x1CEBDDC")]
	private void SetItemIconColor(uint color)
	{
	}

	[Token(Token = "0x600B452")]
	[Address(RVA = "0x1CEC040", Offset = "0x1CEC040", VA = "0x1CEC040")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B453")]
	[Address(RVA = "0x1CEC048", Offset = "0x1CEC048", VA = "0x1CEC048")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600B454")]
	[Address(RVA = "0x1CEC050", Offset = "0x1CEC050", VA = "0x1CEC050")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
