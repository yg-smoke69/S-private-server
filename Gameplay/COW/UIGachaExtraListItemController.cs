using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200263B")]
public class UIGachaExtraListItemController : UIBaseController
{
	[Token(Token = "0x200263C")]
	public enum ExtraAwardItemState
	{
		[Token(Token = "0x400EC0E")]
		STATE_NONE,
		[Token(Token = "0x400EC0F")]
		STATE_ALREADY_RECEIVE,
		[Token(Token = "0x400EC10")]
		STATE_CAN_RECEIVE,
		[Token(Token = "0x400EC11")]
		STATE_CANNOT_RECEIVE
	}

	[Token(Token = "0x400EC06")]
	[FieldOffset(Offset = "0x28")]
	private UIGachaExtraListItemView m_View;

	[Token(Token = "0x400EC07")]
	[FieldOffset(Offset = "0x2C")]
	private UIGachaExtraRewardItemController m_MiniCtrl;

	[Token(Token = "0x400EC08")]
	[FieldOffset(Offset = "0x30")]
	private ExtraAwardItemState m_State;

	[Token(Token = "0x400EC09")]
	[FieldOffset(Offset = "0x34")]
	private ExtraRewardDesc m_ItemDesc;

	[Token(Token = "0x400EC0A")]
	[FieldOffset(Offset = "0x38")]
	private int m_Indx;

	[Token(Token = "0x400EC0B")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_GachaID;

	[Token(Token = "0x400EC0C")]
	[FieldOffset(Offset = "0x40")]
	private uint m_ItemDelayCall;

	[Token(Token = "0x17001173")]
	public ExtraAwardItemState State
	{
		[Token(Token = "0x600E3B0")]
		[Address(RVA = "0x247542C", Offset = "0x247542C", VA = "0x247542C")]
		get
		{
			return default(ExtraAwardItemState);
		}
	}

	[Token(Token = "0x600E3AF")]
	[Address(RVA = "0x24753A0", Offset = "0x24753A0", VA = "0x24753A0")]
	public UIGachaExtraListItemController()
	{
	}

	[Token(Token = "0x600E3B1")]
	[Address(RVA = "0x2475484", Offset = "0x2475484", VA = "0x2475484")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E3B2")]
	[Address(RVA = "0x2475528", Offset = "0x2475528", VA = "0x2475528", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E3B3")]
	[Address(RVA = "0x2475584", Offset = "0x2475584", VA = "0x2475584", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E3B4")]
	[Address(RVA = "0x24756E0", Offset = "0x24756E0", VA = "0x24756E0")]
	public void SetData(ExtraRewardDesc data, int data_index, uint chestID)
	{
	}

	[Token(Token = "0x600E3B5")]
	[Address(RVA = "0x247577C", Offset = "0x247577C", VA = "0x247577C")]
	public void UpdateItemState()
	{
	}

	[Token(Token = "0x600E3B6")]
	[Address(RVA = "0x2476FEC", Offset = "0x2476FEC", VA = "0x2476FEC")]
	private void InitView()
	{
	}

	[Token(Token = "0x600E3B7")]
	[Address(RVA = "0x24759A4", Offset = "0x24759A4", VA = "0x24759A4")]
	private void RefreshExtraAwardItem(uint chestID, bool isFirstReward)
	{
	}

	[Token(Token = "0x600E3B8")]
	[Address(RVA = "0x24773C8", Offset = "0x24773C8", VA = "0x24773C8")]
	public void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600E3B9")]
	[Address(RVA = "0x2477B90", Offset = "0x2477B90", VA = "0x2477B90")]
	private void ReOpenBtnClick()
	{
	}

	[Token(Token = "0x600E3BA")]
	[Address(RVA = "0x2477C28", Offset = "0x2477C28", VA = "0x2477C28")]
	private void PlayExchangeRewardSound()
	{
	}

	[Token(Token = "0x600E3BB")]
	[Address(RVA = "0x2477D40", Offset = "0x2477D40", VA = "0x2477D40")]
	public uint GetItemCdtValue()
	{
		return default(uint);
	}

	[Token(Token = "0x600E3BC")]
	[Address(RVA = "0x2477DB0", Offset = "0x2477DB0", VA = "0x2477DB0", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E3BD")]
	[Address(RVA = "0x2477EC4", Offset = "0x2477EC4", VA = "0x2477EC4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E3BE")]
	[Address(RVA = "0x2477F28", Offset = "0x2477F28", VA = "0x2477F28")]
	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E3BF")]
	[Address(RVA = "0x2477F30", Offset = "0x2477F30", VA = "0x2477F30")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E3C0")]
	[Address(RVA = "0x2477F38", Offset = "0x2477F38", VA = "0x2477F38")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E3C1")]
	[Address(RVA = "0x2477F40", Offset = "0x2477F40", VA = "0x2477F40")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
